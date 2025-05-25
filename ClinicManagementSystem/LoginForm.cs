using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ClinicManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.AcceptButton = button1;
            this.Controls.Add(button1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameTextBox.Text) || string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                MessageBox.Show("Username and Password must not be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string username = UsernameTextBox.Text.Trim();
                string password = PasswordTextBox.Text;

                if (Database.AuthenticateUser(username, password))
                {
                    MessageBox.Show("Login Successful!", "Success");

                    switch (Database.GetUserAccType(username, password).ToUpper())
                    {
                        case "ADMIN":
                            AdminForm adminForm = new AdminForm();
                            adminForm.Show();
                            FormProvider.Login.Hide();
                            UsernameTextBox.Clear();
                            PasswordTextBox.Clear();
                            break;

                        case "DOCTOR":
                            DocView docView = new DocView();
                            docView.Show();
                            FormProvider.Login.Hide();
                            UsernameTextBox.Clear();
                            PasswordTextBox.Clear();
                            break;

                        case "RECEPTIONIST":
                            RecepView recepView = new RecepView();
                            recepView.Show();
                            FormProvider.Login.Hide();
                            UsernameTextBox.Clear();
                            PasswordTextBox.Clear();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Login Failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }


        public sealed class Database
        {
            private static Patient currentPatient;
            private static Doctor currentDoctor;
            private static Appointment currentAppointment;

            private static readonly Lazy<Database> instance = new Lazy<Database>(() => new Database());
            private MySqlConnection connection;

            private Database()
            {
                string connectionString = "server=localhost;database=dentalclinic;user=root;password=;";
                connection = new MySqlConnection(connectionString);
                connection.Open();
                currentPatient = new Patient();
                currentDoctor = new Doctor();
                currentAppointment = new Appointment();
            }

            public static Database Instance => instance.Value;

            public MySqlConnection Connection
            {
                get
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    return connection;
                }
            }

            public static Patient CurrentPatient 
            {
                set
                {
                    currentPatient = value;
                }
                get 
                {
                    return currentPatient;
                } 
            }

            public static Doctor CurrentDoctor
            {
                set
                {
                    currentDoctor = value;
                }
                get 
                {
                    return currentDoctor;
                } 
            }

            public static Appointment CurrentAppointment
            {
                set
                {
                    currentAppointment = value;
                }
                get
                {
                    return currentAppointment;
                }
            }

            public static bool AuthenticateUser(string username, string password)
            {
                string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = SHA2(@password, 256) AND status = @status";
                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@status", "ACTIVE");
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }

            public static bool AddUser(string username, string password, string accType)
            {
                string checkQuery = "SELECT COUNT(*) FROM users WHERE username = @username AND accType = @accType AND status = @status";
                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, Instance.connection))
                {
                    checkCmd.Parameters.AddWithValue("@username", username);
                    checkCmd.Parameters.AddWithValue("@accType", accType);
                    checkCmd.Parameters.AddWithValue("@status", "ACTIVE");
                    if (Convert.ToInt32(checkCmd.ExecuteScalar()) > 0)
                    {
                        return false;
                    }
                }
                string insertQuery = "INSERT INTO users (username, password, accType) VALUES (@username, SHA2(@password, 256), @accType)";
                using (MySqlCommand cmd = new MySqlCommand(insertQuery, Instance.connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@accType", accType);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }

            public static bool AddPatient(string firstName,
                                          string middleName,
                                          string lastName, 
                                          string dob, 
                                          char sex,
                                          string contactNumber,
                                          string altContactNumber, 
                                          string emailAddress, 
                                          string address)
            {
                string checkQuery = "SELECT COUNT(*) FROM patients WHERE firstName = @firstName AND middleName = @middleName " + 
                                    "AND lastName = @lastName AND emailAddress = @emailAddress";
                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, Instance.connection))
                {
                    checkCmd.Parameters.AddWithValue("@firstName", firstName);
                    checkCmd.Parameters.AddWithValue("@middleName", middleName);
                    checkCmd.Parameters.AddWithValue("@lastName", lastName);
                    checkCmd.Parameters.AddWithValue("@emailAddress", emailAddress);
                    if (Convert.ToInt32(checkCmd.ExecuteScalar()) > 0)
                    {
                        return false;
                    }
                }
                string insertQuery = "INSERT INTO patients (firstName, middleName, lastName, DoB, sex, contactNumber, altContactNumber, emailAddress, address) " + 
                                     "VALUES (@firstName, @middleName, @lastName, @dob, @sex, @contactNumber, @altContactNumber, @emailAddress, @address)";
                using (MySqlCommand cmd = new MySqlCommand(insertQuery, Instance.connection))
                {
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@middleName", middleName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@dob", dob);
                    cmd.Parameters.AddWithValue("@sex", sex);
                    cmd.Parameters.AddWithValue("@contactNumber", contactNumber);
                    cmd.Parameters.AddWithValue("@altContactNumber", altContactNumber);
                    cmd.Parameters.AddWithValue("@emailAddress", emailAddress);
                    cmd.Parameters.AddWithValue("@address", address);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }

            public static bool AddDoctor(string firstName,
                                         string middleName,
                                         string lastName,
                                         string contactNumber, 
                                         string emailAddress,
                                         string address,
                                         string licenseNumber)
            {
                string checkQuery = "SELECT COUNT(*) FROM doctors WHERE licenseNumber = @licenseNumber";
                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, Instance.connection))
                {
                    checkCmd.Parameters.AddWithValue("@licenseNumber", licenseNumber);
                    if (Convert.ToInt32(checkCmd.ExecuteScalar()) > 0)
                    {
                        return false;
                    }
                }
                string insertQuery = "INSERT INTO doctors (firstName, middleName, lastName, contactNumber, hireDate, emailAddress, address, licenseNumber) " +
                                     "VALUES (@firstName, @middleName, @lastName, @contactNumber, NOW(), @emailAddress, @address, @licenseNumber)";
                using (MySqlCommand cmd = new MySqlCommand(insertQuery, Instance.connection))
                {
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@middleName", middleName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@contactNumber", contactNumber);
                    cmd.Parameters.AddWithValue("@emailAddress", emailAddress);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@licenseNumber", licenseNumber);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }

            public static bool AddAppointment(long patientId,
                                              long doctorId,
                                              string appointmentDateTime,
                                              string reasonForAppointment)
            {
                string checkQuery = "SELECT COUNT(*) FROM appointments WHERE AppointmentDateTime = @appointmentDateTime";
                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, Instance.connection))
                {
                    checkCmd.Parameters.AddWithValue("@appointmentDateTime", appointmentDateTime);
                    if (Convert.ToInt32(checkCmd.ExecuteScalar()) > 0)
                    {
                        return false;
                    }
                }
                string insertQuery = "INSERT INTO appointments (patientId, doctorId, appointmentDateTime, reasonForAppointment) " +
                                     "VALUES (@patientId, @doctorId, @appointmentDateTime, @reasonForAppointment)";
                using (MySqlCommand cmd = new MySqlCommand(insertQuery, Instance.connection))
                {
                    cmd.Parameters.AddWithValue("@patientId", patientId);
                    cmd.Parameters.AddWithValue("@doctorId", doctorId);
                    cmd.Parameters.AddWithValue("@appointmentDateTime", appointmentDateTime);
                    cmd.Parameters.AddWithValue("@reasonForAppointment", reasonForAppointment);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }

            public static bool UpdateUserStatus(long userid) // to change
            {
                if (GetUserStatus(userid) == "ACTIVE")
                {
                    string updateToInactiveQuery = "UPDATE users SET status = 'INACTIVE' WHERE userid = @userid";
                    using (MySqlCommand cmd = new MySqlCommand(updateToInactiveQuery, Instance.connection))
                    {
                        cmd.Parameters.AddWithValue("@userid", userid);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                else
                {
                    string updateToActiveQuery = "UPDATE users SET status = 'ACTIVE' WHERE userid = @userid";
                    using (MySqlCommand cmd = new MySqlCommand(updateToActiveQuery, Instance.connection))
                    {
                        cmd.Parameters.AddWithValue("@userid", userid);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }

            }

            public static bool UpdatePatient(long patientId,
                                 string firstName,
                                 string middleName,
                                 string lastName,
                                 string dob,
                                 char sex,
                                 string contactNumber,
                                 string altContactNumber,
                                 string emailAddress,
                                 string address,
                                 string status)
            {
                string checkQuery = "SELECT COUNT(*) FROM patients WHERE firstName = @firstName AND middleName = @middleName " +
                                    "AND lastName = @lastName AND emailAddress = @emailAddress AND patientId <> @patientId";
                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, Instance.connection))
                {
                    checkCmd.Parameters.AddWithValue("@firstName", firstName);
                    checkCmd.Parameters.AddWithValue("@middleName", middleName);
                    checkCmd.Parameters.AddWithValue("@lastName", lastName);
                    checkCmd.Parameters.AddWithValue("@emailAddress", emailAddress);
                    checkCmd.Parameters.AddWithValue("@patientId", patientId);
                    if (Convert.ToInt32(checkCmd.ExecuteScalar()) > 0)
                    {
                        return false;
                    }
                }
                string query = "UPDATE patients SET firstName = @firstName, middleName = @middleName, lastName = @lastName, DoB = @dob, sex = @sex, contactNumber = @contactNumber," +
                               " altContactNumber = @altContactNumber, emailAddress = @emailAddress, address = @address, status = @status WHERE patientId = @patientId";
                using (MySqlCommand cmd = new MySqlCommand(query, Instance.connection))
                {
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@middleName", middleName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@dob", dob);
                    cmd.Parameters.AddWithValue("@sex", sex);
                    cmd.Parameters.AddWithValue("@contactNumber", contactNumber);
                    cmd.Parameters.AddWithValue("@altContactNumber", altContactNumber);
                    cmd.Parameters.AddWithValue("@emailAddress", emailAddress);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@patientId", patientId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }

            public static bool UpdateAppointment(long appointmentId,
                                                 long doctorId,
                                                 string appointmentDateTime,
                                                 string status
                                                 )
            {
                string query = "UPDATE appointments SET doctorId = @doctorId, appointmentDateTime = @appointmentDateTime, status = @status WHERE appointmentId = @appointmentId";
                using (MySqlCommand cmd = new MySqlCommand(query, Instance.connection))
                {
                    cmd.Parameters.AddWithValue("@doctorId", doctorId);
                    cmd.Parameters.AddWithValue("@appointmentDateTime", appointmentDateTime);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@appointmentId", appointmentId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            
            public static string GetUserStatus(long userid) // to change, pwede mag buhat ug user nga class same sa doctor ug patient
            {
                string query = "SELECT status FROM users WHERE userid = @userid";

                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                {
                    cmd.Parameters.AddWithValue("@userid", userid);

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return result.ToString();
                    }

                    return null;
                }
            }

            public static string GetUserAccType(string username, string password) // to change, pwede mag buhat ug user nga class same sa doctor ug patient
            {
                string query = "SELECT accType FROM users WHERE username = @username AND password = SHA2(@password, 256) LIMIT 1";

                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return result.ToString();
                    }

                    return null;
                }
            }


            public static DataTable GetUsers()
            {
                string query = "SELECT UserID, Username, accType AS AccountType, Status FROM users WHERE accType <> 'admin'";
                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }

            public static DataTable GetPatients(string status)
            {
                string query;
                status = status.ToUpper();
                if (status.Equals("ALL"))
                {
                    query = "SELECT PatientID, FirstName, MiddleName, LastName, CONCAT(YEAR(`DoB`), '/', MONTH(`DoB`), '/', DAY(`DoB`)) AS DoB, Sex, ContactNumber, Status FROM patients ORDER BY patientId DESC";
                    using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
                query = "SELECT PatientID, FirstName, MiddleName, LastName, CONCAT(YEAR(`DoB`), '/', MONTH(`DoB`), '/', DAY(`DoB`)) AS DoB, Sex, ContactNumber FROM patients WHERE status = @status ORDER BY patientId DESC";
                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    cmd.Parameters.AddWithValue("@status", status);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }

            public static DataTable GetDoctors(string status)
            {
                string query;
                status = status.ToUpper();

                if (status.Equals("ALL"))
                {
                    query = "SELECT DoctorID, FirstName, MiddleName, LastName, ContactNumber, EmailAddress, LicenseNumber, Status FROM doctors ORDER BY doctorId DESC";
                    using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
                query = "SELECT DoctorID, FirstName, MiddleName, LastName, ContactNumber, EmailAddress, LicenseNumber FROM doctors WHERE status = @status ORDER BY doctorId DESC";
                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    cmd.Parameters.AddWithValue("@status", status);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }

            public static DataTable GetAppointments(string status)
            {
                string query;
                status = status.ToUpper();
                if (status.Equals("ALL"))
                {
                    query = "SELECT appointments.AppointmentID, CONCAT(patients.firstName, ' ', patients.middleName, ' ', patients.lastName) AS Patient, " +
                            "CONCAT(doctors.firstName, ' ', doctors.middleName, ' ', doctors.lastName) AS Doctor, " +
                            "appointments.AppointmentDateTime, appointments.ReasonForAppointment, appointments.status " +
                            "FROM appointments " +
                            "INNER JOIN patients ON appointments.patientID = patients.patientID " +
                            "INNER JOIN doctors ON appointments.doctorID = doctors.doctorID ORDER BY appointments.appointmentID DESC";
                    using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }

                query = "SELECT appointments.AppointmentID, CONCAT(patients.firstName, ' ', patients.middleName, ' ', patients.lastName) AS Patient, " +
                            "CONCAT(doctors.firstName, ' ', doctors.middleName, ' ', doctors.lastName) AS Doctor, " +
                            "appointments.AppointmentDateTime, appointments.ReasonForAppointment, appointments.status " +
                            "FROM appointments " +
                            "INNER JOIN patients ON appointments.patientID = patients.patientID " +
                            "INNER JOIN doctors ON appointments.doctorID = doctors.doctorID " +
                            "HAVING appointments.status = @status " +
                            "ORDER BY appointments.appointmentID DESC";
                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    cmd.Parameters.AddWithValue("@status", status);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }

            public static DataTable GetSearchPatient(string searchType ,string fname, string mname, string lname)
            {
                /* search types:
                 *   F = first name
                 *   M = Middle name
                 *   L = Last name
                 */     
                string query;
                searchType = searchType.ToUpper();
                fname = "%" + fname.Trim() + "%";
                mname = "%" + mname.Trim() + "%";
                lname = "%" + lname.Trim() + "%";

                if (searchType == "F")
                {
                    query = "SELECT PatientID, FirstName, MiddleName, LastName, CONCAT(YEAR(`DoB`), '/', MONTH(`DoB`), '/', DAY(`DoB`)) AS DoB, Sex, ContactNumber" +
                            " FROM patients WHERE firstName LIKE @fname ORDER BY patientId DESC";
                }
                else if (searchType == "M")
                {
                    query = "SELECT PatientID, FirstName, MiddleName, LastName, CONCAT(YEAR(`DoB`), '/', MONTH(`DoB`), '/', DAY(`DoB`)) AS DoB, Sex, ContactNumber" +
                            " FROM patients WHERE MiddleName LIKE @mname ORDER BY patientId DESC";
                }
                else if (searchType == "L")
                {
                    query = "SELECT PatientID, FirstName, MiddleName, LastName, CONCAT(YEAR(`DoB`), '/', MONTH(`DoB`), '/', DAY(`DoB`)) AS DoB, Sex, ContactNumber" +
                            " FROM patients WHERE lastName LIKE @lname ORDER BY patientId DESC";
                }
                else if (searchType == "FM")
                {
                    query = "SELECT PatientID, FirstName, MiddleName, LastName, CONCAT(YEAR(`DoB`), '/', MONTH(`DoB`), '/', DAY(`DoB`)) AS DoB, Sex, ContactNumber" +
                            " FROM patients WHERE firstName LIKE @fname AND middleName LIKE @mname ORDER BY patientId DESC";
                }
                else if (searchType == "FL")
                {
                    query = "SELECT PatientID, FirstName, MiddleName, LastName, CONCAT(YEAR(`DoB`), '/', MONTH(`DoB`), '/', DAY(`DoB`)) AS DoB, Sex, ContactNumber" +
                            " FROM patients WHERE firstName LIKE @fname AND lastName LIKE @lname ORDER BY patientId DESC";
                }
                else if (searchType == "ML")
                {
                    query = "SELECT PatientID, FirstName, MiddleName, LastName, CONCAT(YEAR(`DoB`), '/', MONTH(`DoB`), '/', DAY(`DoB`)) AS DoB, Sex, ContactNumber" +
                            " FROM patients WHERE middleName LIKE @mname AND lastName LIKE @lname ORDER BY patientId DESC";
                }
                else // full name 
                {
                    query = "SELECT PatientID, FirstName, MiddleName, LastName, CONCAT(YEAR(`DoB`), '/', MONTH(`DoB`), '/', DAY(`DoB`)) AS DoB, Sex, ContactNumber" +
                            " FROM patients WHERE firstName LIKE @fname AND middleName LIKE @mname AND lastName LIKE @lname ORDER BY patientId DESC";
                }

                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    cmd.Parameters.AddWithValue("@fname", fname);
                    cmd.Parameters.AddWithValue("@mname", mname);
                    cmd.Parameters.AddWithValue("@lname", lname);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }

            }

            public static Patient RetrievePatient(long patientId) 
            {
                Patient patient = new Patient();
                string query;

                query = "SELECT PatientID, FirstName, MiddleName, LastName, CONCAT(YEAR(`DoB`), '/', MONTH(`DoB`), '/', DAY(`DoB`)) AS DoB, " +
                        "Sex, ContactNumber, AltContactNumber, EmailAddress, Address, Status " +
                        "FROM patients WHERE patientID = @patientId";
                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                {
                    cmd.Parameters.AddWithValue("@patientId", patientId);
                    try
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read()) 
                        {
                            patient.ID = patientId;
                            patient.FirstName = reader["FirstName"].ToString();
                            patient.MiddleName = reader["MiddleName"].ToString();
                            patient.LastName = reader["LastName"].ToString();
                            patient.DoB = reader["DoB"].ToString();
                            patient.Sex = reader["Sex"].ToString();
                            patient.ContactNumber = reader["ContactNumber"].ToString();
                            patient.AltContactNumber = reader["AltContactNumber"].ToString();
                            patient.EmailAddress = reader["EmailAddress"].ToString();
                            patient.Address = reader["Address"].ToString();
                            patient.Status = reader["Status"].ToString();

                            reader.Close();
                            return patient;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                }
                return null;
            }
            
            public static Doctor RetrieveDoctor(long doctorId)
            {
                Doctor doctor = new Doctor();
                string query;

                query = "SELECT DoctorID, FirstName, MiddleName, LastName, " +
                        "HireDate, ContactNumber, EmailAddress, Address, LicenseNumber, Status " +
                        "FROM doctors WHERE doctorID = @doctorId";
                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                {
                    cmd.Parameters.AddWithValue("@doctorId", doctorId);
                    try
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            doctor.ID = doctorId;
                            doctor.FirstName = reader["FirstName"].ToString();
                            doctor.MiddleName = reader["MiddleName"].ToString();
                            doctor.LastName = reader["LastName"].ToString();
                            doctor.HireDate = reader["HireDate"].ToString();
                            doctor.ContactNumber = reader["ContactNumber"].ToString();
                            doctor.EmailAddress = reader["EmailAddress"].ToString();
                            doctor.Address = reader["Address"].ToString();
                            doctor.LicenseNumber = reader["LicenseNumber"].ToString();
                            doctor.Status = reader["Status"].ToString();

                            reader.Close();
                            return doctor;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                }
                return null;
            }

            public static Appointment RetrieveAppointment(long appointmentId)
            {
                Appointment appointment = new Appointment();
                string query;

                query = "SELECT * FROM appointments WHERE appointmentId = @appointmentId";
                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                {
                    cmd.Parameters.AddWithValue("@appointmentId", appointmentId);
                    try
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            appointment.AppointmentId = appointmentId;
                            appointment.PatientId = Convert.ToInt64(reader["patientId"].ToString());
                            appointment.DoctorId = Convert.ToInt64(reader["doctorId"].ToString());
                            appointment.DateTime = reader["appointmentDateTime"].ToString();
                            appointment.Reason = reader["reasonForAppointment"].ToString();
                            appointment.Status = reader["status"].ToString();

                            reader.Close();
                            return appointment;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                }
                return null;
            }
        }

        public class Person
        {
            private long id;
            private string firstName;
            private string middleName;
            private string lastName;
            private string doB;
            private string sex;
            private string contactNumber;
            private string altContactNumber;
            private string emailAddress;
            private string address;
            private string status;
            private string username;
            private string accType;

            public Person()
            {
                ID = 0;
                FirstName = string.Empty;
                MiddleName = string.Empty;
                LastName = string.Empty;
                DoB = string.Empty;
                Sex = string.Empty;
                ContactNumber = string.Empty;
                AltContactNumber = string.Empty;
                EmailAddress = string.Empty;
                Address = string.Empty;
                Status = string.Empty;
                Username = string.Empty;
                AccType = string.Empty;
            }

            public long ID
            {
                get { return id; }
                set { id = value; }
            }

            public string FirstName
            {
                get { return firstName; }
                set { firstName = value; }
            }

            public string MiddleName
            {
                get { return middleName; }
                set { middleName = value; }
            }

            public string LastName
            {
                get { return lastName; }
                set { lastName = value; }
            }

            public string DoB
            {
                get { return doB; }
                set { doB = value; }
            }

            public string Sex
            {
                get { return sex; }
                set { sex = value; }
            }

            public string ContactNumber
            {
                get { return contactNumber; }
                set { contactNumber = value; }
            }

            public string AltContactNumber
            {
                get { return altContactNumber; }
                set { altContactNumber = value; }
            }

            public string EmailAddress
            {
                get { return emailAddress; }
                set { emailAddress = value; }
            }

            public string Address
            {
                get { return address; }
                set { address = value; }
            }

            public string Status
            {
                get { return status; }
                set { status = value; }
            }

            public string Username
            {
                get { return username; }
                set { username = value; }
            }

            public string AccType
            {
                get { return accType; }
                set { accType = value; }
            }
        }

        public class Doctor : Person
        {
            private string hireDate;
            private string licenseNumber;
            private string schedule;

            public Doctor() : base()
            {
                HireDate = string.Empty;
                LicenseNumber = string.Empty;
            }

            public string HireDate
            {
                get { return hireDate; }
                set { hireDate = value; }
            }

            public string LicenseNumber
            {
                get { return licenseNumber; }
                set { licenseNumber = value; }
            }

            public string Schedule
            {
                get { return schedule; }
                set { schedule = value; }
            } 
        }

        public class Patient : Person
        {
            public Patient() : base()
            {

            }
        }

        public class Appointment
        {
            private long appointmentId;
            private long patientId;
            private long doctorId;
            private string dateTime;
            private string reason;
            private string status;

            public Appointment()
            {
                AppointmentId = 0;
                PatientId = 0;
                DoctorId = 0;   
                DateTime = string.Empty;
                Reason = string.Empty;
                Status = string.Empty;
            }

            public long AppointmentId 
            {
                get {return appointmentId;}
                set {appointmentId = value;}
            }

            public long PatientId
            {
                get { return patientId; }
                set { patientId = value; }
            }

            public long DoctorId
            {
                get { return doctorId; }
                set { doctorId = value; }
            }

            public string DateTime
            {
                get { return dateTime; }
                set { dateTime = value; }
            }

            public string Reason
            {
                get { return reason; }
                set { reason = value; }
            }

            public string Status
            {
                get { return status; }
                set { status = value; }
            }
        }
    }
}
