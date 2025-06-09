using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static ClinicManagementSystem.LoginForm;

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
                            Database.CurrentLoggedDoctor = Database.RetrieveDoctor(Database.RetrieveUserID(username, "DOCTOR"), "USERID");
                            DocView docView = new DocView();
                            docView.Show();
                            FormProvider.Login.Hide();
                            UsernameTextBox.Clear();
                            PasswordTextBox.Clear();
                            break;

                        case "RECEPTIONIST":
                            Database.CurrentLoggedReceptionist = Database.RetrieveReceptionist(Database.RetrieveUserID(username, "RECEPTIONIST"));
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
            private static Doctor currentLoggedDoctor;
            private static Receptionist currentLoggedReceptionist;

            private static Patient currentPatient;
            private static Doctor currentDoctor;
            private static Appointment currentAppointment;
            private static User currentUser;
            private static Receptionist currentReceptionist;
            private static Service currentService;
            private static List<Service> servicesPerformedList;
            private static Bill currentBill;

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
                currentUser = new User();
                currentReceptionist = new Receptionist();
                currentService = new Service();
                servicesPerformedList = new List<Service>();
                currentLoggedDoctor = new Doctor();
                currentLoggedReceptionist = new Receptionist();
                currentBill = new Bill();
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

            public static Doctor CurrentLoggedDoctor
            {
                set
                {
                    currentLoggedDoctor = value;
                }
                get
                {
                    return currentLoggedDoctor; 
                }
            }

            public static Receptionist CurrentLoggedReceptionist
            {
                set
                {
                    currentLoggedReceptionist = value;
                }
                get
                {
                    return currentLoggedReceptionist;
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

            public static User CurrentUser
            {
                set
                {
                    currentUser = value;
                }

                get
                {
                    return currentUser;
                }
            }

            public static Receptionist CurrentReceptionist
            {
                set
                {
                    currentReceptionist = value;
                }

                get
                {
                    return currentReceptionist;
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

            public static Service CurrentService
            {
                set
                {
                    currentService = value;
                }
                get
                {
                    return currentService;
                }
            }

            public static Bill CurrentBill
            {
                set
                {
                    currentBill = value;
                }
                get
                {
                    return currentBill;
                }
            }

            public static List<Service> ServicesPerformedList
            {
                set
                {
                    servicesPerformedList = value;
                }
                get
                {
                    return servicesPerformedList;
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
                string checkQuery = "SELECT COUNT(*) FROM patients " +
                                    "WHERE emailAddress = @EmailAddress " +
                                    "OR contactNumber = @ContactNumber " +
                                    "OR altContactNumber = @AltContactNumber";
                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, Instance.connection))
                {
                    checkCmd.Parameters.AddWithValue("@EmailAddress", emailAddress ?? (object)DBNull.Value);
                    checkCmd.Parameters.AddWithValue("@ContactNumber", contactNumber ?? (object)DBNull.Value);
                    checkCmd.Parameters.AddWithValue("@AltContactNumber", altContactNumber ?? (object)DBNull.Value);
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
                    cmd.Parameters.AddWithValue("@altContactNumber", string.IsNullOrWhiteSpace(altContactNumber) ? (object)DBNull.Value : altContactNumber);
                    cmd.Parameters.AddWithValue("@emailAddress", string.IsNullOrWhiteSpace(emailAddress) ? (object)DBNull.Value : emailAddress);
                    cmd.Parameters.AddWithValue("@address", address);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }

            public static bool AddService(string serviceName,
                                          long serviceTypeID,
                                          string serviceDesc,
                                          double price)
            {
                string checkQuery = @"SELECT COUNT(*) AS DuplicateCount
                                      FROM services
                                      WHERE ServiceName = @serviceName;";
                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, Instance.connection))
                {
                    checkCmd.Parameters.AddWithValue("@serviceName", serviceName);
                    if (Convert.ToInt32(checkCmd.ExecuteScalar()) > 0)
                    {
                        return false; 
                    }
                }

                string insertQuery = @"INSERT INTO services (ServiceName, ServiceTypeID, ServiceDesc, Price)
                                       VALUES (@serviceName, @serviceTypeID, @serviceDesc, @price);";
                using (MySqlCommand cmd = new MySqlCommand(insertQuery, Instance.connection))
                {
                    cmd.Parameters.AddWithValue("@serviceName", serviceName);
                    cmd.Parameters.AddWithValue("@serviceTypeID", serviceTypeID);
                    cmd.Parameters.AddWithValue("@serviceDesc", serviceDesc);
                    cmd.Parameters.AddWithValue("@price", price);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }

            public static bool AddDoctor(string username,
                                         string password,
                                         string emailAddress,
                                         string contactNumber,
                                         string altContactNumber,
                                         string address,
                                         string licenseNumber,
                                         string firstName,
                                         string middleName,
                                         string lastName,
                                         string schedule)
            {
                string accType = "DOCTOR";

                string checkQuery = @"SELECT COUNT(*) FROM users u
                          LEFT JOIN doctors d ON u.UserID = d.UserID
                          WHERE 
                          (u.username = @username AND u.accType = @accType)
                          OR u.emailAddress = @emailAddress
                          OR u.contactNumber IN (@contactNumber, @altContactNumber)
                          OR u.altContactNumber IN (@contactNumber, @altContactNumber)
                          OR d.LicenseNumber = @licenseNumber";

                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, Instance.connection))
                {
                    checkCmd.Parameters.AddWithValue("@username", username);
                    checkCmd.Parameters.AddWithValue("@accType", accType);
                    checkCmd.Parameters.AddWithValue("@emailAddress", emailAddress ?? (object)DBNull.Value);
                    checkCmd.Parameters.AddWithValue("@contactNumber", contactNumber);
                    checkCmd.Parameters.AddWithValue("@altContactNumber", altContactNumber ?? (object)DBNull.Value);
                    checkCmd.Parameters.AddWithValue("@licenseNumber", licenseNumber);

                    if (Convert.ToInt32(checkCmd.ExecuteScalar()) > 0)
                    {
                        return false; 
                    }
                }

                using (MySqlTransaction transaction = Instance.connection.BeginTransaction())
                {
                    try
                    {
                        long userId;

                        string userInsert = @"INSERT INTO users (username, password, accType, emailAddress, contactNumber, altContactNumber, address)
                                              VALUES (@username, SHA2(@password, 256), @accType, @emailAddress, @contactNumber, @altContactNumber, @address);
                                              SELECT LAST_INSERT_ID();";

                        using (MySqlCommand userCmd = new MySqlCommand(userInsert, Instance.connection, transaction))
                        {
                            userCmd.Parameters.AddWithValue("@username", username);
                            userCmd.Parameters.AddWithValue("@password", password);
                            userCmd.Parameters.AddWithValue("@accType", accType);
                            userCmd.Parameters.AddWithValue("@emailAddress", string.IsNullOrWhiteSpace(emailAddress) ? (object)DBNull.Value : emailAddress);
                            userCmd.Parameters.AddWithValue("@contactNumber", contactNumber);
                            userCmd.Parameters.AddWithValue("@altContactNumber", string.IsNullOrWhiteSpace(altContactNumber) ? (object)DBNull.Value : altContactNumber);
                            userCmd.Parameters.AddWithValue("@address", address);

                            userId = Convert.ToInt64(userCmd.ExecuteScalar());
                        }

                        string doctorInsert = @"INSERT INTO doctors (userId, firstName, middleName, lastName, schedule, licenseNumber)
                                                 VALUES (@userId, @firstName, @middleName, @lastName, @schedule, @licenseNumber)";

                        using (MySqlCommand doctorCmd = new MySqlCommand(doctorInsert, Instance.connection, transaction))
                        {
                            doctorCmd.Parameters.AddWithValue("@userId", userId);
                            doctorCmd.Parameters.AddWithValue("@firstName", firstName);
                            doctorCmd.Parameters.AddWithValue("@middleName", middleName);
                            doctorCmd.Parameters.AddWithValue("@lastName", lastName);
                            doctorCmd.Parameters.AddWithValue("@schedule", schedule);
                            doctorCmd.Parameters.AddWithValue("@licenseNumber", licenseNumber);

                            doctorCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            public static bool AddReceptionist(string username,
                                   string password,
                                   string emailAddress,
                                   string contactNumber,
                                   string altContactNumber,
                                   string address,
                                   string firstName,
                                   string middleName,
                                   string lastName)
            {
                string accType = "RECEPTIONIST";

                string checkQuery = @"SELECT COUNT(*) FROM users u
                                      LEFT JOIN receptionists r ON u.UserID = r.UserID
                                      WHERE 
                                      (u.username = @username AND u.accType = @accType)
                                      OR u.emailAddress = @emailAddress
                                      OR u.contactNumber IN (@contactNumber, @altContactNumber)
                                      OR u.altContactNumber IN (@contactNumber, @altContactNumber)";

                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, Instance.connection))
                {
                    checkCmd.Parameters.AddWithValue("@username", username);
                    checkCmd.Parameters.AddWithValue("@accType", accType);
                    checkCmd.Parameters.AddWithValue("@emailAddress", emailAddress ?? (object)DBNull.Value);
                    checkCmd.Parameters.AddWithValue("@contactNumber", contactNumber);
                    checkCmd.Parameters.AddWithValue("@altContactNumber", altContactNumber ?? (object)DBNull.Value);

                    if (Convert.ToInt32(checkCmd.ExecuteScalar()) > 0)
                    {
                        return false;
                    }
                }

                MySqlTransaction transaction = Instance.connection.BeginTransaction();

                try
                {
                    string userInsert = @"INSERT INTO users 
                                        (username, password, accType, emailAddress, contactNumber, altContactNumber, address)
                                        VALUES 
                                        (@username, SHA2(@password, 256), @accType, @emailAddress, @contactNumber, @altContactNumber, @address)";

                    using (MySqlCommand userCmd = new MySqlCommand(userInsert, Instance.connection, transaction))
                    {
                        userCmd.Parameters.AddWithValue("@username", username);
                        userCmd.Parameters.AddWithValue("@password", password);
                        userCmd.Parameters.AddWithValue("@accType", accType);
                        userCmd.Parameters.AddWithValue("@emailAddress", string.IsNullOrWhiteSpace(emailAddress) ? (object)DBNull.Value : emailAddress);
                        userCmd.Parameters.AddWithValue("@contactNumber", contactNumber);
                        userCmd.Parameters.AddWithValue("@altContactNumber", string.IsNullOrWhiteSpace(altContactNumber) ? (object)DBNull.Value : altContactNumber);
                        userCmd.Parameters.AddWithValue("@address", address);

                        userCmd.ExecuteNonQuery();
                    }

                    string receptionistInsert = @"INSERT INTO receptionists 
                                                (userId, firstName, middleName, lastName)
                                                VALUES 
                                                (LAST_INSERT_ID(), @firstName, @middleName, @lastName)";

                    using (MySqlCommand recCmd = new MySqlCommand(receptionistInsert, Instance.connection, transaction))
                    {
                        recCmd.Parameters.AddWithValue("@firstName", firstName);
                        recCmd.Parameters.AddWithValue("@middleName", middleName);
                        recCmd.Parameters.AddWithValue("@lastName", lastName);

                        recCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message, "Transaction Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            public static bool AddAppointment(long patientId,
                                              long doctorId,
                                              string appointmentDateTime,
                                              string reasonForAppointment)
            {
                string checkQuery = @"SELECT COUNT(*) FROM appointments 
                                      WHERE AppointmentDateTime = @appointmentDateTime 
                                      OR 
                                      @appointmentDateTime BETWEEN DATE_SUB(AppointmentDateTime, INTERVAL 1 HOUR) AND DATE_ADD(AppointmentDateTime, INTERVAL 1 HOUR)";
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

            public static bool AddBill(long appoinmentId, double totalAmount, List<Service> servicesPerformed)
            {
                bool flag;
                string insertQuery = @"INSERT INTO bills (AppointmentID, BillingDate, TotalAmount) 
                                       VALUES (@appoinmentId, NOW(), @totalAmount)";
                using (MySqlCommand cmd = new MySqlCommand(insertQuery, Instance.connection))
                {
                    cmd.Parameters.AddWithValue("@appoinmentId", appoinmentId);
                    cmd.Parameters.AddWithValue("@totalAmount", totalAmount);
                    flag = cmd.ExecuteNonQuery() > 0;
                    
                }

                if (flag)
                {
                    if(AddServicesPerformed(appoinmentId, servicesPerformed))
                    {
                        return true;
                    }
                }
                return false;
            }

            public static bool AddServicesPerformed(long appointmentId, List<Service> servicesPerformed)
            {
                if (servicesPerformed == null || servicesPerformed.Count == 0)
                    return false;

                string insertQuery = @"INSERT INTO servicesperformed (AppointmentID, ServiceID)
                           VALUES (@appointmentId, @serviceId)";

                using (MySqlCommand cmd = new MySqlCommand(insertQuery, Instance.connection))
                {
                    cmd.Parameters.Add("@appointmentId", MySqlDbType.Int64);
                    cmd.Parameters.Add("@serviceId", MySqlDbType.Int64);

                    foreach (Service service in servicesPerformed)
                    {
                        cmd.Parameters["@appointmentId"].Value = appointmentId;
                        cmd.Parameters["@serviceId"].Value = service.ServiceID;

                        if (cmd.ExecuteNonQuery() <= 0)
                        {
                            return false; 
                        }
                    }
                }

                return true;
            }

            public static bool DeleteBill(long billId, long appointmentId)
            {
                bool flag;
                string deleteQuery = @"DELETE FROM bills
                                       WHERE BillID = @billId";
                using (MySqlCommand cmd = new MySqlCommand(deleteQuery, Instance.connection))
                {
                    cmd.Parameters.AddWithValue("@billId", billId);
                    flag = cmd.ExecuteNonQuery() > 0;
                }

                if (flag)
                {
                    if (DeleteServicesPerformed(appointmentId))
                    {
                        return true;
                    }
                }
                return false;
            }

            public static bool DeleteServicesPerformed(long appointmentId)
            {
                string deleteQuery = @"DELETE FROM servicesPerformed 
                                       WHERE appointmentId = @appointmentId";

                using (MySqlCommand cmd = new MySqlCommand(deleteQuery, Instance.connection))
                {
                    cmd.Parameters.AddWithValue("@appointmentId", appointmentId);
                    if (cmd.ExecuteNonQuery() <= 0)
                    {
                        return false;
                    }
                }
                return true;
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
                string checkQuery = @"SELECT COUNT(*) FROM patients 
                                      WHERE patientId <> @patientId 
                                      AND (
                                          emailAddress = @EmailAddress 
                                          OR contactNumber = @ContactNumber 
                                          OR altContactNumber = @AltContactNumber
                                          OR contactNumber = @AltContactNumber
                                          OR altContactNumber = @ContactNumber
                                      )";

                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, Instance.connection))
                {
                    checkCmd.Parameters.AddWithValue("@patientId", patientId);
                    checkCmd.Parameters.AddWithValue("@EmailAddress", emailAddress ?? (object)DBNull.Value);
                    checkCmd.Parameters.AddWithValue("@ContactNumber", contactNumber ?? (object)DBNull.Value);
                    checkCmd.Parameters.AddWithValue("@AltContactNumber", altContactNumber ?? (object)DBNull.Value);

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        return false;
                    }
                }

                string updateQuery = @"UPDATE patients SET 
                                    firstName = @FirstName,
                                    middleName = @MiddleName,
                                    lastName = @LastName,
                                    DoB = @DoB,
                                    sex = @Sex,
                                    contactNumber = @ContactNumber,
                                    altContactNumber = @AltContactNumber,
                                    emailAddress = @EmailAddress,
                                    address = @Address,
                                    status = @Status
                                    WHERE patientId = @PatientId";

                using (MySqlCommand cmd = new MySqlCommand(updateQuery, Instance.connection))
                {
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@MiddleName", middleName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@DoB", dob);
                    cmd.Parameters.AddWithValue("@Sex", sex);
                    cmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
                    cmd.Parameters.AddWithValue("@AltContactNumber", string.IsNullOrWhiteSpace(altContactNumber) ? (object)DBNull.Value : altContactNumber);
                    cmd.Parameters.AddWithValue("@EmailAddress", string.IsNullOrWhiteSpace(emailAddress) ? (object)DBNull.Value : emailAddress);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@PatientId", patientId);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }

            public static bool UpdateUserDoctor(long userId,
                                                long doctorId,
                                                string emailAddress,
                                                string contactNumber,
                                                string altContactNumber,
                                                string address,
                                                string licenseNumber,
                                                string firstName,
                                                string middleName,
                                                string lastName,
                                                string status,
                                                string schedule)
            {
                string checkQuery = @"
                            SELECT COUNT(*) 
                            FROM users u
                            LEFT JOIN doctors d ON u.userId = d.userId
                            WHERE 
                                u.userId <> @userId 
                                AND (
                                    u.emailAddress = @EmailAddress 
                                    OR u.contactNumber IN (@ContactNumber, @AltContactNumber)
                                    OR u.altContactNumber IN (@ContactNumber, @AltContactNumber)
                                    OR (d.licenseNumber = @LicenseNumber AND d.doctorId <> @doctorId)
                                )";

                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, Instance.connection))
                {
                    checkCmd.Parameters.AddWithValue("@userId", userId);
                    checkCmd.Parameters.AddWithValue("@doctorId", doctorId);
                    checkCmd.Parameters.AddWithValue("@EmailAddress", emailAddress ?? (object)DBNull.Value);
                    checkCmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
                    checkCmd.Parameters.AddWithValue("@AltContactNumber", altContactNumber ?? (object)DBNull.Value);
                    checkCmd.Parameters.AddWithValue("@LicenseNumber", licenseNumber);

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        return false;
                    }
                }

                string updateQuery = @"UPDATE users SET 
                                    contactNumber = @ContactNumber,
                                    altContactNumber = @AltContactNumber,
                                    emailAddress = @EmailAddress,
                                    address = @Address,
                                    status = @Status
                                    WHERE userId = @userId;
                                    
                                    UPDATE doctors SET
                                    firstName = @FirstName,
                                    middleName = @MiddleName,
                                    lastName = @LastName,
                                    licenseNumber = @LicenseNumber,
                                    schedule = @Schedule 
                                    WHERE userId = @userId";

                using (MySqlCommand cmd = new MySqlCommand(updateQuery, Instance.connection))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
                    cmd.Parameters.AddWithValue("@AltContactNumber", string.IsNullOrWhiteSpace(altContactNumber) ? (object)DBNull.Value : altContactNumber);
                    cmd.Parameters.AddWithValue("@EmailAddress", string.IsNullOrWhiteSpace(emailAddress) ? (object)DBNull.Value : emailAddress);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@MiddleName", middleName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@LicenseNumber", licenseNumber);
                    cmd.Parameters.AddWithValue("@Schedule", schedule);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }

            public static bool UpdateDoctorAvailabilityStatus(string currentDay)
            {
                currentDay = "%" + currentDay + "%";
                string updateQuery = @"UPDATE doctors SET
                                       AvailabilityStatus = @availabilityStatus1
                                       WHERE Schedule LIKE @currentDay;
                                        
                                       UPDATE doctors SET
                                       AvailabilityStatus = @availabilityStatus2
                                       WHERE Schedule NOT LIKE @currentDay";
                using (MySqlCommand cmd = new MySqlCommand(updateQuery, Instance.connection))
                {
                    cmd.Parameters.AddWithValue("@availabilityStatus1", "AVAILABLE");
                    cmd.Parameters.AddWithValue("@availabilityStatus2", "UNAVAILABLE");
                    cmd.Parameters.AddWithValue("@currentDay", currentDay);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }

            public static bool UpdateService(long serviceId,
                                             string serviceName,
                                             string serviceDesc,
                                             string serviceType,
                                             double price)
            {
                string checkQuery = @"SELECT COUNT(*) 
                                        FROM services
                                        WHERE serviceId <> @serviceId
                                        AND serviceName = @serviceName";

                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, Instance.connection))
                {
                    checkCmd.Parameters.AddWithValue("@serviceId", serviceId);
                    checkCmd.Parameters.AddWithValue("@serviceName", serviceName);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        return false;
                    }
                }
                long serviceTypeId = GetServiceTypeID(serviceType);
                string updateQuery = @"UPDATE services
                                       SET serviceName = @serviceName,
                                           serviceDesc = @serviceDesc,
                                           serviceDesc = @serviceDesc,
                                           serviceTypeID = @serviceTypeId,
                                           price = @price
                                       WHERE serviceId = @serviceId";

                using (MySqlCommand cmd = new MySqlCommand(updateQuery, Instance.connection))
                {
                    cmd.Parameters.AddWithValue("@serviceName", serviceName);
                    cmd.Parameters.AddWithValue("@serviceDesc", serviceDesc);
                    cmd.Parameters.AddWithValue("@serviceTypeId", serviceTypeId);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@serviceId", serviceId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }

            public static bool UpdateUserReceptionist(long userId,
                                      long receptionistId,
                                      string emailAddress,
                                      string contactNumber,
                                      string altContactNumber,
                                      string address,
                                      string firstName,
                                      string middleName,
                                      string lastName,
                                      string status)
            {
                string checkQuery = @"
                                    SELECT COUNT(*)
                                    FROM users u
                                    LEFT JOIN receptionists r ON u.userId = r.userId
                                    WHERE 
                                        u.userId <> @userId AND (
                                            u.emailAddress = @EmailAddress 
                                            OR u.contactNumber IN (@ContactNumber, @AltContactNumber)
                                            OR u.altContactNumber IN (@ContactNumber, @AltContactNumber)
                                        )";

                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, Instance.connection))
                {
                    checkCmd.Parameters.AddWithValue("@userId", userId);
                    checkCmd.Parameters.AddWithValue("@EmailAddress", emailAddress ?? (object)DBNull.Value);
                    checkCmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
                    checkCmd.Parameters.AddWithValue("@AltContactNumber", altContactNumber ?? (object)DBNull.Value);

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        return false; 
                    }
                }

                string updateQuery = @"
                                    UPDATE users SET 
                                        contactNumber = @ContactNumber,
                                        altContactNumber = @AltContactNumber,
                                        emailAddress = @EmailAddress,
                                        address = @Address,
                                        status = @Status
                                    WHERE userId = @userId;

                                    UPDATE receptionists SET
                                        firstName = @FirstName,
                                        middleName = @MiddleName,
                                        lastName = @LastName
                                    WHERE receptionistId = @receptionistId";

                using (MySqlCommand cmd = new MySqlCommand(updateQuery, Instance.connection))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@receptionistId", receptionistId);
                    cmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
                    cmd.Parameters.AddWithValue("@AltContactNumber", string.IsNullOrWhiteSpace(altContactNumber) ? (object)DBNull.Value : altContactNumber);
                    cmd.Parameters.AddWithValue("@EmailAddress", string.IsNullOrWhiteSpace(emailAddress) ? (object)DBNull.Value : emailAddress);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@MiddleName", middleName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);

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

            public static string GetUserAccType(string username, string password)
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

            public static DataTable GetPatientRecords(long patientId)
            {
                string query = @"SELECT a.AppointmentID,
                             a.AppointmentDateTime,
                             CONCAT(d.FirstName, ' ', d.MiddleName, ' ', d.LastName) AS AttendingDoctor
                      FROM
                         Patients p
                      INNER JOIN
                         Appointments a ON p.PatientID = a.PatientID
                      INNER JOIN
                         Doctors d ON a.DoctorID = d.DoctorID
                      WHERE
                         p.PatientID = @PatientID
                      AND 
                         a.Status = @status;";

                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                {
                    cmd.Parameters.AddWithValue("@PatientID", patientId);
                    cmd.Parameters.AddWithValue("@status", "FINISHED");

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }


            public static DataTable GetBills()
            {
                string query = @"SELECT bills.BillID, 
                                        appointments.AppointmentID,
                                        appointments.AppointmentDateTime, 
                                         CONCAT(patients.firstName, ' ', patients.middleName, ' ', patients.lastName) AS Patient,
                                        bills.BillingDate, 
                                        bills.TotalAmount
                                 FROM bills
                                 INNER JOIN appointments ON bills.AppointmentID = appointments.AppointmentID
                                 INNER JOIN patients ON appointments.patientID = patients.patientID
                                 ORDER BY bills.BillID DESC";

                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }

            public static DataTable GetUsers()
            {
                string query = "SELECT UserID, Username, accType AS AccountType, EmailAddress, ContactNumber, AltContactNumber, Address, status FROM users WHERE accType <> 'admin'";

                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }

            public static DataTable GetUsers(string accType)
            {
                string query;
                if (accType.ToUpper().Equals("DOCTOR"))
                {
                    query = "SELECT u.UserID, u.Username, d.DoctorID, d.FirstName, d.MiddleName, d.LastName, d.LicenseNumber, d.Schedule, u.EmailAddress, u.ContactNumber, u.AltContactNumber, u.Address, u.Status FROM users u " +
                                   "INNER JOIN doctors d ON u.UserID = d.UserID WHERE accType = @accType";

                    using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        cmd.Parameters.AddWithValue("@accType", accType);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }

                query = "SELECT u.UserID, u.Username, r.ReceptionistID, r.FirstName, r.MiddleName, r.LastName, u.EmailAddress, u.ContactNumber, u.AltContactNumber, u.Address, u.Status FROM users u " +
                        "INNER JOIN receptionists r ON u.UserID = r.UserID WHERE accType = @accType";
                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    cmd.Parameters.AddWithValue("@accType", accType);
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
                    query = @"SELECT PatientID, FirstName, MiddleName, LastName, CONCAT(YEAR(`DoB`), '/', MONTH(`DoB`), '/', DAY(`DoB`)) AS DoB, 
                                     Sex, ContactNumber, COALESCE(AltContactNumber, 'N/A') AS AltContactNumber, COALESCE(EmailAddress, 'N/A') AS EmailAddress, 
                                     Address, Status FROM patients ORDER BY patientId DESC";
                    using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
                query = @"SELECT PatientID, FirstName, MiddleName, LastName, CONCAT(YEAR(`DoB`), '/', MONTH(`DoB`), '/', DAY(`DoB`)) AS DoB, 
                                 Sex, ContactNumber,  COALESCE(AltContactNumber, 'N/A') AS AltContactNumber, COALESCE(EmailAddress, 'N/A') AS EmailAddress, Address, Status 
                        FROM patients 
                        WHERE status = @status 
                        ORDER BY patientId DESC";
                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    cmd.Parameters.AddWithValue("@status", status);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }

            public static DataTable GetPatients(string status, long doctorId)
            {
                status = status.ToUpper();
                string query = @"SELECT DISTINCT p.PatientID, p.FirstName, p.MiddleName, p.LastName, 
                                        CONCAT(YEAR(p.DoB), '/', MONTH(p.DoB), '/', DAY(p.DoB)) AS DoB, 
                                        p.Sex, p.ContactNumber, COALESCE(p.AltContactNumber, 'N/A') AS AltContactNumber, COALESCE(p.EmailAddress, 'N/A') AS EmailAddress, p.Address, p.Status 
                                 FROM patients p
                                 INNER JOIN appointments a ON p.PatientID = a.PatientID
                                 WHERE p.Status = @status AND a.DoctorID = @doctorId
                                 ORDER BY p.PatientID DESC";

                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@doctorId", doctorId);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }

            public static DataTable GetDoctors(string availabilityStatus)
            {
                string query;
                availabilityStatus = availabilityStatus.ToUpper();

                if (availabilityStatus.Equals("ALL"))
                {
                    query = "SELECT d.DoctorID, d.FirstName, d.MiddleName, d.LastName, u.ContactNumber, u.AltContactNumber, u.EmailAddress, d.LicenseNumber, u.Address, d.Schedule, d.AvailabilityStatus FROM doctors d " +
                            "INNER JOIN users u ON d.userId = u.userId ORDER BY doctorId DESC";
                    using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
                query = "SELECT d.DoctorID, d.FirstName, d.MiddleName, d.LastName, u.ContactNumber, u.AltContactNumber, u.EmailAddress, d.LicenseNumber, u.Address, d.Schedule, d.AvailabilityStatus FROM doctors d " +
                        "INNER JOIN users u ON d.userId = u.userId WHERE availabilityStatus = @availabilityStatus ORDER BY doctorId DESC";
                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    cmd.Parameters.AddWithValue("@availabilityStatus", availabilityStatus);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }

            public static DataTable GetServices()
            {
                string query = @"SELECT s.ServiceID,
                                        s.ServiceName,
                                        st.serviceTypeName AS ServiceType,
                                        s.ServiceDesc,
                                        s.Price
                                FROM services s
                                INNER JOIN servicetypes st ON s.serviceTypeID = st.serviceTypeID;";

                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }

            public static DataTable GetServiceTypeNames()
            {
                string query = @"SELECT ServiceTypeName
                                FROM serviceTypes;";

                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }

            public static DataTable GetServices(long appointmentId)
            {
                string query = @"SELECT s.ServiceName,
                                    st.ServiceTypeName AS ServiceType
                                FROM
                                    servicesperformed sp 
                                INNER JOIN
                                    services s ON sp.ServiceID = s.ServiceID 
                                INNER JOIN
                                    servicetypes st ON s.ServiceTypeID = st.ServiceTypeID 
                                WHERE
                                    sp.AppointmentID = @appointmentId; ";

                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    cmd.Parameters.AddWithValue("@appointmentId", appointmentId);
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
                    query = @"SELECT appointments.AppointmentID, appointments.AppointmentDateTime, 
                                     CONCAT(patients.firstName, ' ', patients.middleName, ' ', patients.lastName) AS Patient, 
                                     CONCAT(doctors.firstName, ' ', doctors.middleName, ' ', doctors.lastName) AS Doctor, 
                                     appointments.ReasonForAppointment, appointments.Status 
                            FROM appointments 
                            INNER JOIN patients ON appointments.patientID = patients.patientID 
                            INNER JOIN doctors ON appointments.doctorID = doctors.doctorID 
                            ORDER BY appointments.appointmentID DESC";
                    using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }

                query = @"SELECT appointments.AppointmentID, appointments.AppointmentDateTime, 
                                 CONCAT(patients.firstName, ' ', patients.middleName, ' ', patients.lastName) AS Patient, 
                                 CONCAT(doctors.firstName, ' ', doctors.middleName, ' ', doctors.lastName) AS Doctor, 
                                 appointments.ReasonForAppointment, 
                                 appointments.Status 
                         FROM appointments 
                         INNER JOIN patients ON appointments.patientID = patients.patientID 
                         INNER JOIN doctors ON appointments.doctorID = doctors.doctorID 
                         HAVING appointments.status = @status 
                         ORDER BY appointments.appointmentID DESC";
                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    cmd.Parameters.AddWithValue("@status", status);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }

            public static DataTable GetAppointments(string status, bool hasBill) 
            {
                string query;
                status = status.ToUpper();
                query = @"SELECT
                                appointments.AppointmentID,
                                appointments.AppointmentDateTime,
                                CONCAT(patients.firstName, ' ', patients.middleName, ' ', patients.lastName) AS Patient,
                                CONCAT(doctors.firstName, ' ', doctors.middleName, ' ', doctors.lastName) AS Doctor,
                                appointments.ReasonForAppointment,
                                appointments.Status
                            FROM
                                appointments
                            INNER JOIN
                                patients ON appointments.patientID = patients.patientID
                            INNER JOIN
                                doctors ON appointments.doctorID = doctors.doctorID
                            LEFT JOIN
                                bills ON appointments.AppointmentID = bills.AppointmentID 
                            WHERE
                                appointments.status = 'FINISHED'
                                AND bills.BillID IS NULL
                            ORDER BY
                                appointments.AppointmentID DESC"; 
                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    cmd.Parameters.AddWithValue("@status", status);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }

            public static DataTable GetAppointments(string status, long doctorId)
            {
                string query;
                status = status.ToUpper();

                if (status.Equals("ALL"))
                {
                    query = @"SELECT appointments.AppointmentID, appointments.AppointmentDateTime, 
                                     CONCAT(patients.firstName, ' ', patients.middleName, ' ', patients.lastName) AS Patient, 
                                     CONCAT(doctors.firstName, ' ', doctors.middleName, ' ', doctors.lastName) AS Doctor, 
                                     appointments.ReasonForAppointment, appointments.Status 
                              FROM appointments 
                              INNER JOIN patients ON appointments.patientID = patients.patientID 
                              INNER JOIN doctors ON appointments.doctorID = doctors.doctorID 
                              WHERE appointments.doctorID = @doctorId
                              ORDER BY appointments.appointmentID DESC";

                    using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        cmd.Parameters.AddWithValue("@doctorId", doctorId);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
                else if (status.Equals("UPCOMING"))
                {
                    query = @"SELECT appointments.AppointmentID, appointments.AppointmentDateTime, 
                                     CONCAT(patients.firstName, ' ', patients.middleName, ' ', patients.lastName) AS Patient, 
                                     CONCAT(doctors.firstName, ' ', doctors.middleName, ' ', doctors.lastName) AS Doctor, 
                                     appointments.ReasonForAppointment, appointments.Status 
                              FROM appointments 
                              INNER JOIN patients ON appointments.patientID = patients.patientID 
                              INNER JOIN doctors ON appointments.doctorID = doctors.doctorID 
                              WHERE appointments.doctorID = @doctorId AND appointments.status = @status AND AppointmentDateTime > NOW()
                              ORDER BY appointments.appointmentID DESC";

                    using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        cmd.Parameters.AddWithValue("@status", "Approved");
                        cmd.Parameters.AddWithValue("@doctorId", doctorId);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
                

                query = @"SELECT appointments.AppointmentID, appointments.AppointmentDateTime, 
                                 CONCAT(patients.firstName, ' ', patients.middleName, ' ', patients.lastName) AS Patient, 
                                 CONCAT(doctors.firstName, ' ', doctors.middleName, ' ', doctors.lastName) AS Doctor, 
                                 appointments.ReasonForAppointment, appointments.Status 
                          FROM appointments 
                          INNER JOIN patients ON appointments.patientID = patients.patientID 
                          INNER JOIN doctors ON appointments.doctorID = doctors.doctorID 
                          WHERE appointments.status = @status AND appointments.doctorID = @doctorId
                          ORDER BY appointments.appointmentID DESC";

                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@doctorId", doctorId);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }


            public static DataTable GetSearchDoctor(string searchType, string fname, string mname, string lname)
            {
                /* search types:
                 *   F = first name
                 *   M = Middle name
                 *   L = Last name
                 */
                string query, where, finalQuery;

                searchType = searchType.ToUpper();
                fname = "%" + fname.Trim() + "%";
                mname = "%" + mname.Trim() + "%";
                lname = "%" + lname.Trim() + "%";

                query = @"SELECT d.DoctorID, d.FirstName, d.MiddleName, d.LastName, 
                                u.ContactNumber, u.AltContactNumber, u.EmailAddress, 
                                d.LicenseNumber, u.Address, d.AvailabilityStatus
                         FROM doctors d
                         INNER JOIN users u ON d.userId = u.userId";

                switch (searchType)
                {
                    case "F":
                        where = "WHERE d.FirstName LIKE @fname";
                        break;
                    case "M":
                        where = "WHERE d.MiddleName LIKE @mname";
                        break;
                    case "L":
                        where = "WHERE d.LastName LIKE @lname";
                        break;
                    case "FM":
                        where = "WHERE d.FirstName LIKE @fname AND d.MiddleName LIKE @mname";
                        break;
                    case "FL":
                        where = "WHERE d.FirstName LIKE @fname AND d.LastName LIKE @lname";
                        break;
                    case "ML":
                        where = "WHERE d.MiddleName LIKE @mname AND d.LastName LIKE @lname";
                        break;
                    default:
                        where = "WHERE d.FirstName LIKE @fname AND d.MiddleName LIKE @mname AND d.LastName LIKE @lname";
                        break;
                }

                finalQuery = query + " " + where + " ORDER BY d.DoctorID DESC";
                using (MySqlCommand cmd = new MySqlCommand(finalQuery, Instance.Connection))
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

            public static DataTable GetSearchPatient(string searchType, string fname, string mname, string lname)
            {
                /* search types:
                 *   F = first name
                 *   M = middle name
                 *   L = last name
                 */
                string query, where, finalQuery;

                searchType = (searchType ?? "").ToUpper().Trim();
                fname = "%" + fname.Trim() + "%";
                mname = "%" + mname.Trim() + "%";
                lname = "%" + lname.Trim() + "%";

                query = @"SELECT PatientID, FirstName, MiddleName, LastName, 
                                 CONCAT(YEAR(`DoB`), '/', MONTH(`DoB`), '/', DAY(`DoB`)) AS DoB, 
                                 Sex, ContactNumber, AltContactNumber, 
                                 EmailAddress, Address, Status 
                          FROM patients";

                switch (searchType)
                {
                    case "F":
                        where = "WHERE FirstName LIKE @fname";
                        break;
                    case "M":
                        where = "WHERE MiddleName LIKE @mname";
                        break;
                    case "L":
                        where = "WHERE LastName LIKE @lname";
                        break;
                    case "FM":
                        where = "WHERE FirstName LIKE @fname AND MiddleName LIKE @mname";
                        break;
                    case "FL":
                        where = "WHERE FirstName LIKE @fname AND LastName LIKE @lname";
                        break;
                    case "ML":
                        where = "WHERE MiddleName LIKE @mname AND LastName LIKE @lname";
                        break;
                    default:
                        where = "WHERE FirstName LIKE @fname AND MiddleName LIKE @mname AND LastName LIKE @lname";
                        break;
                }

                finalQuery = query + " " + where + " ORDER BY PatientID DESC";

                using (MySqlCommand cmd = new MySqlCommand(finalQuery, Instance.Connection))
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

            public static DataTable GetSearchAppointment(string searchType, string fname, string mname, string lname)
            {
                /* search types:
                 *   F = first name
                 *   M = middle name
                 *   L = last name
                 */
                string query, where, finalQuery;

                searchType = (searchType ?? "").ToUpper().Trim();
                fname = "%" + fname.Trim() + "%";
                mname = "%" + mname.Trim() + "%";
                lname = "%" + lname.Trim() + "%";

                query = @"SELECT appointments.AppointmentID, appointments.AppointmentDateTime, 
                             CONCAT(patients.firstName, ' ', patients.middleName, ' ', patients.lastName) AS Patient, 
                             CONCAT(doctors.firstName, ' ', doctors.middleName, ' ', doctors.lastName) AS Doctor, 
                             appointments.ReasonForAppointment, 
                             appointments.Status 
                         FROM appointments 
                         INNER JOIN patients ON appointments.patientID = patients.patientID 
                         INNER JOIN doctors ON appointments.doctorID = doctors.doctorID";

                switch (searchType)
                {
                    case "F":
                        where = "WHERE patients.FirstName LIKE @fname";
                        break;
                    case "M":
                        where = "WHERE patients.MiddleName LIKE @mname";
                        break;
                    case "L":
                        where = "WHERE patients.LastName LIKE @lname";
                        break;
                    case "FM":
                        where = "WHERE patients.FirstName LIKE @fname AND patients.MiddleName LIKE @mname";
                        break;
                    case "FL":
                        where = "WHERE patients.FirstName LIKE @fname AND patients.LastName LIKE @lname";
                        break;
                    case "ML":
                        where = "WHERE patients.MiddleName LIKE @mname AND patients.LastName LIKE @lname";
                        break;
                    default:
                        where = "WHERE patients.FirstName LIKE @fname AND patients.MiddleName LIKE @mname AND patients.LastName LIKE @lname";
                        break;
                }

                finalQuery = query + " " + where;

                using (MySqlCommand cmd = new MySqlCommand(finalQuery, Instance.Connection))
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

            //public static DataTable GetSearchAppointment(string searchType, string fname, string mname, string lname, string dateTime)
            //{
            //    searchType = searchType.ToUpper().Trim();
            //    fname = "%" + fname.Trim() + "%";
            //    mname = "%" + mname.Trim() + "%";
            //    lname = "%" + lname.Trim() + "%";
            //    dateTime = dateTime.Trim();

            //    string baseQuery = @"SELECT appointments.AppointmentID, 
            //                               appointments.AppointmentDateTime, 
            //                               CONCAT(patients.FirstName, ' ', patients.MiddleName, ' ', patients.LastName) AS Patient, 
            //                               CONCAT(doctors.FirstName, ' ', doctors.MiddleName, ' ', doctors.LastName) AS Doctor, 
            //                               appointments.ReasonForAppointment, 
            //                               appointments.Status 
            //                        FROM appointments 
            //                        INNER JOIN patients ON appointments.PatientID = patients.PatientID 
            //                        INNER JOIN doctors ON appointments.DoctorID = doctors.DoctorID";

            //    string whereClause = "";
            //    switch (searchType)
            //    {
            //        case "F":
            //            whereClause = "WHERE patients.FirstName LIKE @fname";
            //            break;
            //        case "M":
            //            whereClause = "WHERE patients.MiddleName LIKE @mname";
            //            break;
            //        case "L":
            //            whereClause = "WHERE patients.LastName LIKE @lname";
            //            break;
            //        case "FM":
            //            whereClause = "WHERE patients.FirstName LIKE @fname AND patients.MiddleName LIKE @mname";
            //            break;
            //        case "FL":
            //            whereClause = "WHERE patients.FirstName LIKE @fname AND patients.LastName LIKE @lname";
            //            break;
            //        case "ML":
            //            whereClause = "WHERE patients.MiddleName LIKE @mname AND patients.LastName LIKE @lname";
            //            break;
            //        default:
            //            whereClause = "WHERE patients.FirstName LIKE @fname AND patients.MiddleName LIKE @mname AND patients.LastName LIKE @lname";
            //            break;
            //    }

            //    string finalQuery = "";

            //    if (searchType.Equals("D"))
            //    {
            //        whereClause = "WHERE DATE(appointments.AppointmentDateTime) = @appointmentDate ";
            //        finalQuery = baseQuery + " " + whereClause + " ORDER BY appointments.AppointmentID DESC";
            //    }
            //    else if (searchType.Contains("D"))
            //    {
            //        finalQuery = baseQuery + " " + whereClause + " AND DATE(appointments.AppointmentDateTime) = @appointmentDate ORDER BY appointments.AppointmentID DESC";
            //    }
            //    else
            //    {
            //        finalQuery = baseQuery + " " + whereClause + " ORDER BY appointments.AppointmentID DESC";
            //    }

            //    using (MySqlCommand cmd = new MySqlCommand(finalQuery, Instance.Connection))
            //    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
            //    {
            //        cmd.Parameters.AddWithValue("@fname", fname);
            //        cmd.Parameters.AddWithValue("@mname", mname);
            //        cmd.Parameters.AddWithValue("@lname", lname);
            //        if (searchType.Contains("D"))
            //        {
            //            cmd.Parameters.AddWithValue("@appointmentDate", dateTime);
            //        }

            //        DataTable table = new DataTable();
            //        adapter.Fill(table);
            //        return table;
            //    }
            //}

            public static long GetServiceTypeID(string serviceTypeName)
            {
                string query = "SELECT ServiceTypeID FROM serviceTypes WHERE serviceTypeName = @serviceTypeName";

                using (MySqlCommand cmd = new MySqlCommand(query, Instance.connection))
                {
                    cmd.Parameters.AddWithValue("@serviceTypeName", serviceTypeName);

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt64(result);
                    }
                }
                return 0; 
            }

            public static int GetTotalAppointments()
            {
                string query = "SELECT COUNT(*) FROM appointments";

                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            public static int GetTotalPatients()
            {
                string query = "SELECT COUNT(*) FROM patients";

                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            public static int GetTotalDoctors()
            {
                string query = "SELECT COUNT(*) FROM doctors";

                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            public static DateTime? GetNextAppointmentDateTime()
            {
                string query = @"SELECT AppointmentDateTime 
                                 FROM appointments 
                                 WHERE AppointmentDateTime > NOW() 
                                 AND status IN (@APPROVED, @RESCHEDULED)
                                 ORDER BY AppointmentDateTime ASC 
                                 LIMIT 1";

                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                {
                    cmd.Parameters.AddWithValue("@APPROVED", "APPROVED");
                    cmd.Parameters.AddWithValue("@RESCHEDULED", "RESCHEDULED");

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToDateTime(result);
                    }
                    
                    return null;
                }
            }

            public static string GetNextAppointmentDoctor()
            {
                string query = @"SELECT CONCAT(d.FirstName, ' ', d.MiddleName, ' ', d.LastName) AS DoctorName
                     FROM appointments a
                     INNER JOIN doctors d ON a.DoctorID = d.DoctorID
                     WHERE a.AppointmentDateTime > NOW()
                     ORDER BY a.AppointmentDateTime ASC
                     LIMIT 1";

                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                {
                    object result = cmd.ExecuteScalar();
                    return result?.ToString() ?? string.Empty;
                }
            }

            public static string GetNextAppointmentPatient()
            {
                string query = @"SELECT CONCAT(p.FirstName, ' ', p.MiddleName, ' ', p.LastName) AS PatientName
                     FROM appointments a
                     INNER JOIN patients p ON a.PatientID = p.PatientID
                     WHERE a.AppointmentDateTime > NOW()
                     ORDER BY a.AppointmentDateTime ASC
                     LIMIT 1";

                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                {
                    object result = cmd.ExecuteScalar();
                    return result?.ToString() ?? string.Empty;
                }
            }
                        public static string GetNextPatientNameByDoctor(long doctorId)
            {
                string query = @"SELECT CONCAT(p.FirstName, ' ', p.MiddleName, ' ', p.LastName) AS PatientName
                     FROM appointments a
                     INNER JOIN patients p ON a.PatientID = p.PatientID
                     WHERE a.DoctorID = @doctorId AND a.AppointmentDateTime > NOW()
                     ORDER BY a.AppointmentDateTime ASC 
                     LIMIT 1";

                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                {
                    cmd.Parameters.AddWithValue("@doctorId", doctorId);
                    object result = cmd.ExecuteScalar();
                    return result != DBNull.Value && result != null ? result.ToString() : "No upcoming patient";
                }
            }

            public static int GetTotalAppointmentsByDoctor(long doctorId)
            {
                string query = "SELECT COUNT(*) FROM appointments WHERE DoctorID = @doctorId";

                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                {
                    cmd.Parameters.AddWithValue("@doctorId", doctorId);
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }

            public static int GetTotalPatientsByDoctor(long doctorId)
            {
                string query = "SELECT COUNT(DISTINCT PatientID) FROM appointments WHERE DoctorID = @doctorId";

                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                {
                    cmd.Parameters.AddWithValue("@doctorId", doctorId);
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }

            public static DateTime? GetNextAppointmentDateByDoctor(long doctorId)
            {
                string query = @"SELECT AppointmentDateTime 
                     FROM appointments 
                     WHERE DoctorID = @doctorId AND AppointmentDateTime > NOW()
                     ORDER BY AppointmentDateTime ASC 
                     LIMIT 1";

                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                {
                    cmd.Parameters.AddWithValue("@doctorId", doctorId);
                    object result = cmd.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToDateTime(result) : (DateTime?)null;
                }
            }

            public static double GetTotalAmount(List<Service> ServicesPerformed)
            {
                List<string> parameterNames = new List<string>();
                List<long> serviceIds = new List<long>();

                if (ServicesPerformed == null || ServicesPerformed.Count == 0)
                {
                    return 0;
                }

                for (int i = 0; i < ServicesPerformed.Count; i++)
                {
                    serviceIds.Add(ServicesPerformed[i].ServiceID);
                    parameterNames.Add("@id" + i);
                }

                string parameterString = string.Join(", ", parameterNames);

                string query = $"SELECT SUM(price) FROM services WHERE serviceId IN ({parameterString})";
                using (MySqlCommand cmd = new MySqlCommand(query, Instance.connection))
                {
                    for (int i = 0; i < ServicesPerformed.Count; i++)
                    {
                        cmd.Parameters.AddWithValue("@id" + i, ServicesPerformed[i].ServiceID);
                    }

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToDouble(result);
                    }
                }
                return 0;
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

            public static User RetrieveUser(long userId) 
            {
                User user = new User();
                string query;

                query = "SELECT * FROM users WHERE userId = @userId";
                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    try
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            user.UserId = userId;
                            user.Username = reader["Username"].ToString();
                            user.AccType = reader["AccType"].ToString();
                            user.EmailAddress = reader["EmailAddress"].ToString();
                            user.ContactNumber = reader["ContactNumber"].ToString();
                            user.AltContactNumber = reader["AltContactNumber"].ToString();
                            user.Address = reader["Address"].ToString();
                            user.Status = reader["Status"].ToString();

                            reader.Close();
                            return user;
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

            //public static User RetrieveUser(string username, string accType)
            //{
            //    User user = new User();
            //    string query;

            //    query = "SELECT * FROM users WHERE Username = @username AND AccType = @accType";
            //    using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
            //    {
            //        cmd.Parameters.AddWithValue("@username", username);
            //        cmd.Parameters.AddWithValue("@accType", accType);
            //        try
            //        {
            //            MySqlDataReader reader = cmd.ExecuteReader();
            //            if (reader.Read())
            //            {
            //                user.UserId = Convert.ToInt64(reader["userId"].ToString());
            //                user.Username = reader["Username"].ToString();
            //                user.AccType = reader["AccType"].ToString();
            //                user.EmailAddress = reader["EmailAddress"].ToString();
            //                user.ContactNumber = reader["ContactNumber"].ToString();
            //                user.AltContactNumber = reader["AltContactNumber"].ToString();
            //                user.Address = reader["Address"].ToString();
            //                user.Status = reader["Status"].ToString();

            //                reader.Close();
            //                return user;
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            return null;
            //        }
            //    }
            //    return null;
            //}

            public static Receptionist RetrieveReceptionist(long Id)
            {
                Receptionist receptionist = new Receptionist();
                string query;

                query = "SELECT * FROM receptionists WHERE userID = @Id";

                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    try
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            receptionist.ReceptionistId = Convert.ToInt64(reader["ReceptionistID"]);
                            receptionist.UserId = Convert.ToInt64(reader["UserID"]);
                            receptionist.FirstName = reader["FirstName"].ToString();
                            receptionist.MiddleName = reader["MiddleName"].ToString();
                            receptionist.LastName = reader["LastName"].ToString();

                            reader.Close();
                            return receptionist;
                        }

                        reader.Close(); 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                }

                return null;
            }

            public static Bill RetrieveBill(long billId)
            {
                Bill bill = new Bill();
                string query;

                query = "SELECT * FROM bills WHERE BillID = @billId";

                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                {
                    cmd.Parameters.AddWithValue("@billId", billId);
                    try
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            bill.BillID = Convert.ToInt64(reader["BillID"]);
                            bill.AppointmentID = Convert.ToInt64(reader["AppointmentID"]);
                            DateTime billingDate = Convert.ToDateTime(reader["BillingDate"]);
                            bill.BillingDate = billingDate.ToString("MM/dd/yyyy");
                            //bill.BillingDate = billingDate.ToString("MMM dd, yyyy");
                            bill.TotalAmount= Convert.ToDouble(reader["TotalAmount"]);

                            reader.Close();
                            return bill;
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                }

                return null;
            }

            public static Doctor RetrieveDoctor(long Id, string idType)
            {
                Doctor doctor = new Doctor();
                string query;

                if (idType.ToUpper().Equals("DOCTORID"))
                {
                    query = "SELECT * FROM doctors WHERE doctorID = @Id";
                }
                else
                {
                    query = "SELECT * FROM doctors WHERE userID = @Id";
                }

                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    try
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            doctor.DoctorId = Convert.ToInt64(reader["DoctorID"]);
                            doctor.UserId = Convert.ToInt64(reader["UserID"]);
                            doctor.FirstName = reader["FirstName"].ToString();
                            doctor.MiddleName = reader["MiddleName"].ToString();
                            doctor.LastName = reader["LastName"].ToString();
                            doctor.LicenseNumber = reader["LicenseNumber"].ToString();
                            doctor.Schedule = reader["Schedule"].ToString();

                            reader.Close();
                            return doctor;
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                }

                return null;
            }

            public static List<Service> RetrieveServicesPerformed(long appointmentId)
            {
                Service service = new Service();
                List<Service> servicesPerformed = new List<Service>();
                List<long> serviceIds = new List<long>();
                string query;
                int numberOfServices = 0;

                query = "SELECT COUNT(*) FROM servicesPerformed WHERE AppointmentID = @appointmentId";
                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                {
                    cmd.Parameters.AddWithValue("@appointmentId", appointmentId);

                    numberOfServices = Convert.ToInt32(cmd.ExecuteScalar());
                }

                query = "SELECT serviceID FROM servicesPerformed WHERE AppointmentID = @appointmentId";
                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                {
                    cmd.Parameters.AddWithValue("@appointmentId", appointmentId);
                    try
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            serviceIds.Add(Convert.ToInt64(reader["ServiceID"]));
                        }
                        reader.Close();

                        foreach (long id in serviceIds)
                        {
                            service = RetrieveService(id);
                            servicesPerformed.Add(service);
                        }
                        return servicesPerformed;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                }
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

            public static Service RetrieveService(long serviceId)
            {
                Service service = new Service();
                string query;
                query = @"SELECT s.ServiceID,
                                 s.ServiceName,
                                 st.serviceTypeName AS ServiceType,
                                 s.ServiceDesc,
                                 s.Price
                          FROM services s
                          INNER JOIN servicetypes st ON s.serviceTypeID = st.serviceTypeID
                          WHERE s.serviceID = @serviceId;";
                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                {
                    cmd.Parameters.AddWithValue("@serviceId", serviceId);
                    try
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            service.ServiceID = serviceId;
                            service.ServiceName = reader["ServiceName"].ToString();
                            service.ServiceType = reader["ServiceType"].ToString();
                            service.ServiceDesc = reader["ServiceDesc"].ToString();
                            service.Price = Convert.ToDouble(reader["Price"].ToString());

                            reader.Close();
                            return service;
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



            public static long RetrieveUserID(string username, string accType)
            {
                string query = "";

                if (accType.ToUpper() == "DOCTOR")
                {
                    query = @"SELECT u.userId 
                  FROM users u 
                  INNER JOIN doctors d ON u.userId = d.userId 
                  WHERE u.username = @username";
                }
                else if (accType.ToUpper() == "RECEPTIONIST")
                {
                    query = @"SELECT u.userId 
                  FROM users u 
                  INNER JOIN receptionists r ON u.userId = r.userId 
                  WHERE u.username = @username";
                }
                else
                {
                    throw new ArgumentException("Invalid account type. Expected 'doctor' or 'receptionist'.");
                }

                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    try
                    {
                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            return Convert.ToInt64(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                return -1; 
            }

            public static bool isDoctorAvailble(long doctorId, DateTime date)
            {
                string day = "";
                switch (date.DayOfWeek)
                {
                    case DayOfWeek.Monday:
                        day = "%M%";
                        break;

                    case DayOfWeek.Tuesday:
                        day = "%T%";
                        break;

                    case DayOfWeek.Wednesday:
                        day = "%W%";
                        break;

                    case DayOfWeek.Thursday:
                        day = "%Th%";
                        break;

                    case DayOfWeek.Friday:
                        day = "%F%";
                        break;

                    case DayOfWeek.Saturday:
                        day = "%S%";
                        break;

                    default:
                        day = string.Empty;
                        break;
                }

                string query = @"SELECT COUNT(*) 
                                 FROM doctors 
                                 WHERE DoctorID = @doctorId AND Schedule = @day";
                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                {
                    cmd.Parameters.AddWithValue("@doctorId", doctorId);
                    cmd.Parameters.AddWithValue("@day", day);

                    try
                    {
                        return Convert.ToInt32(cmd.ExecuteScalar()) > 0; 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return false;
            }
        }

        public class Patient
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


            public Patient()
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
        }
        public class User
        {
            private long userId;
            private string username;
            private string password;
            private string accType;
            private string emailAddress;
            private string contactNumber;
            private string altContactNumber;
            private string address;
            private string status;

            public User()
            {
                UserId = 0;
                username = "";
                password = "";
                accType = "";
                emailAddress = "";
                contactNumber = "";
                altContactNumber = "";
                address = "";
                status = "";
            }

            public long UserId
            {
                get { return userId; }
                set { userId = value; }
            }

            public string Username
            {
                get { return username; }
                set { username = value; }
            }

            public string Password
            {
                get { return password; }
                set { password = value; }
            }

            public string AccType
            {
                get { return accType; }
                set { accType = value; }
            }

            public string EmailAddress
            {
                get { return emailAddress; }
                set { emailAddress = value; }
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
        }



        public class Doctor : User
        {
            private long doctorId;
            private string firstName;
            private string middleName;
            private string lastName;
            private string licenseNumber;
            private string schedule;
            private string availabilityStatus;

            public Doctor() : base()
            {
                DoctorId = 0; ;
                FirstName = string.Empty;
                MiddleName = string.Empty;
                LastName = string.Empty;
                LicenseNumber = string.Empty;
                Schedule = string.Empty;
                AvailabilityStatus = string.Empty;
            }

            public long DoctorId
            {
                get { return doctorId; }
                set { doctorId = value;  }
            }

            public string FirstName
            {
                get { return firstName; }
                set { firstName = value;  }
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

            public string AvailabilityStatus
            {
                get { return availabilityStatus; }
                set { availabilityStatus = value; }
            }
        }

        public class Receptionist : User
        {
            private long receptionistId;
            private string firstName;
            private string middleName;
            private string lastName;

            public Receptionist() : base()
            {
                receptionistId = 0;
                firstName = string.Empty;
                middleName = string.Empty;
                lastName = string.Empty;
            }

            public long ReceptionistId
            {
                get { return receptionistId; }
                set { receptionistId = value; }
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

        public class Service
        {
            private long serviceID;
            private string serviceName;
            private string serviceType;
            private string serviceDesc;
            private double price;

            public Service()
            {
                ServiceID = 0;
                ServiceName = string.Empty;
                ServiceType = string.Empty;
                ServiceDesc = string.Empty;
                Price = 0; 
            }

            public long ServiceID
            {
                get { return serviceID; }
                set { serviceID = value; }
            }

            public string ServiceName
            {
                get { return serviceName; }
                set { serviceName = value; }
            }

            public string ServiceType
            {
                get { return serviceType; }
                set { serviceType = value; }
            }

            public string ServiceDesc
            {
                get { return serviceDesc; }
                set { serviceDesc = value; }
            }

            public double Price
            {
                get { return price; }
                set {  price = value; }
            }
        }

        public class Bill
        {
            private long billID;
            private long appointmentID;
            private double totalAmount;
            private string billingDate;

            public Bill()
            {
                BillID = 0;
                AppointmentID = 0;
                TotalAmount = 0;
                BillingDate = string.Empty;
            }

            public long BillID 
            {
                get { return billID; }
                set { billID = value; }
            }

            public long AppointmentID 
            { 
                get { return appointmentID; }
                set {  appointmentID = value; }
            }

            public double TotalAmount
            {
                get { return totalAmount; }
                set { totalAmount = value; }
            }

            public string BillingDate
            {
                get { return billingDate; }
                set { billingDate = value; }
            }
        }
    }
}
