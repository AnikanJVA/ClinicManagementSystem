-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 28, 2025 at 05:56 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dentalclinic`
--

-- --------------------------------------------------------

--
-- Table structure for table `appointments`
--

CREATE TABLE `appointments` (
  `AppointmentID` bigint(20) NOT NULL,
  `PatientID` bigint(20) DEFAULT NULL,
  `DoctorID` bigint(20) DEFAULT NULL,
  `AppointmentDateTime` datetime DEFAULT NULL,
  `ReasonForAppointment` text DEFAULT NULL,
  `Status` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `bills`
--

CREATE TABLE `bills` (
  `BillID` bigint(20) NOT NULL,
  `AppointmentID` bigint(20) DEFAULT NULL,
  `BillingDate` date DEFAULT NULL,
  `TotalAmount` decimal(10,2) DEFAULT NULL,
  `status` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `doctors`
--

CREATE TABLE `doctors` (
  `DoctorID` bigint(20) NOT NULL,
  `UserID` bigint(20) DEFAULT NULL,
  `FirstName` varchar(50) DEFAULT NULL,
  `MiddleName` varchar(50) DEFAULT NULL,
  `LastName` varchar(50) DEFAULT NULL,
  `HireDate` date DEFAULT NULL,
  `LicenseNumber` varchar(50) DEFAULT NULL,
  `Schedule` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `doctors`
--

INSERT INTO `doctors` (`DoctorID`, `UserID`, `FirstName`, `MiddleName`, `LastName`, `HireDate`, `LicenseNumber`, `Schedule`) VALUES
(1, 2, 'Alok', 'Giegie', 'Konojia', '2025-05-28', '123456789', 'MWF'),
(2, 3, 'Salamat', 'Docc', 'Abs', '2025-05-28', '987987978987', 'TThS');

-- --------------------------------------------------------

--
-- Table structure for table `patients`
--

CREATE TABLE `patients` (
  `PatientID` bigint(20) NOT NULL,
  `FirstName` varchar(50) DEFAULT NULL,
  `LastName` varchar(50) DEFAULT NULL,
  `MiddleName` varchar(50) DEFAULT NULL,
  `DoB` date DEFAULT NULL,
  `Sex` char(1) DEFAULT NULL,
  `ContactNumber` varchar(20) DEFAULT NULL,
  `AltContactNumber` varchar(20) DEFAULT NULL,
  `EmailAddress` varchar(100) DEFAULT NULL,
  `Address` text DEFAULT NULL,
  `Status` varchar(20) DEFAULT 'ACTIVE'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `patients`
--

INSERT INTO `patients` (`PatientID`, `FirstName`, `LastName`, `MiddleName`, `DoB`, `Sex`, `ContactNumber`, `AltContactNumber`, `EmailAddress`, `Address`, `Status`) VALUES
(1, 'ani', 'va', 'kan', '2003-10-11', 'm', '09103243490', NULL, 'anikanjva@gmail.com', 'juna subd, matina, davao city', 'ACTIVE'),
(2, 'james andrew', 'De castro', 'Doe', '2000-05-10', 'M', '09101010101', '09222222222', 'james@gmail.com', 'cabantian dc', 'ACTIVE'),
(3, 'justine', 'mantua', 'lamnda', '2004-09-10', 'M', '09123123123', '09123123123', 'justine@gmail.com', 'bangkerohan dc', 'ACTIVE'),
(4, 'matt oliver', 'pojadas', 'utrera', '2004-07-06', 'M', '0933333333', '0944444444', 'matt@gmail.com', 'sandawa dc', 'ACTIVE'),
(5, 'princess', 'fernando', 'pia', '2005-04-14', 'F', '0955555555', '0966666666', 'princess@gmail.com', 'ecoland dc', 'ACTIVE');

-- --------------------------------------------------------

--
-- Table structure for table `prescriptionrecords`
--

CREATE TABLE `prescriptionrecords` (
  `PrescriptionID` bigint(20) NOT NULL,
  `AppointmentID` bigint(20) DEFAULT NULL,
  `PresprotionDetails` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `receptionists`
--

CREATE TABLE `receptionists` (
  `ReceptionistID` bigint(20) NOT NULL,
  `UserID` bigint(20) DEFAULT NULL,
  `FirstName` varchar(50) DEFAULT NULL,
  `LastName` varchar(50) DEFAULT NULL,
  `MiddleName` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `services`
--

CREATE TABLE `services` (
  `ServiceID` bigint(20) NOT NULL,
  `ServiceName` varchar(100) DEFAULT NULL,
  `ServiceType` bigint(20) DEFAULT NULL,
  `ServiceDesc` text DEFAULT NULL,
  `Price` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `servicesperformed`
--

CREATE TABLE `servicesperformed` (
  `ServicePerformedID` bigint(20) NOT NULL,
  `AppointmentID` bigint(20) DEFAULT NULL,
  `ServiceID` bigint(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `servicetypes`
--

CREATE TABLE `servicetypes` (
  `ServiceTypeID` bigint(20) NOT NULL,
  `ServiceTypeName` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `UserID` bigint(20) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `AccType` varchar(20) NOT NULL,
  `EmailAddress` varchar(100) DEFAULT NULL,
  `ContactNumber` varchar(20) DEFAULT NULL,
  `AltContactNumber` varchar(20) DEFAULT NULL,
  `Address` text DEFAULT NULL,
  `status` varchar(20) DEFAULT 'ACTIVE'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`UserID`, `Username`, `Password`, `AccType`, `EmailAddress`, `ContactNumber`, `AltContactNumber`, `Address`, `status`) VALUES
(1, 'admin', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'admin', 'admin@admin.com', '0000000', '111111111', 'adminhome', 'ACTIVE'),
(2, 'ani', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'DOCTOR', 'asdf@gmail.com', '0910324124412', '0192302194210', 'davao', 'ACTIVE'),
(3, 'doc', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'DOCTOR', 'doc@email.com', '0933333333', '0944444444', 'maina', 'ACTIVE');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `appointments`
--
ALTER TABLE `appointments`
  ADD PRIMARY KEY (`AppointmentID`),
  ADD KEY `PatientID` (`PatientID`),
  ADD KEY `DoctorID` (`DoctorID`);

--
-- Indexes for table `bills`
--
ALTER TABLE `bills`
  ADD PRIMARY KEY (`BillID`),
  ADD KEY `AppointmentID` (`AppointmentID`);

--
-- Indexes for table `doctors`
--
ALTER TABLE `doctors`
  ADD PRIMARY KEY (`DoctorID`),
  ADD KEY `UserID` (`UserID`);

--
-- Indexes for table `patients`
--
ALTER TABLE `patients`
  ADD PRIMARY KEY (`PatientID`),
  ADD UNIQUE KEY `ContactNumber` (`ContactNumber`),
  ADD UNIQUE KEY `EmailAddress` (`EmailAddress`),
  ADD UNIQUE KEY `AltContactNumber` (`AltContactNumber`);

--
-- Indexes for table `prescriptionrecords`
--
ALTER TABLE `prescriptionrecords`
  ADD PRIMARY KEY (`PrescriptionID`),
  ADD KEY `AppointmentID` (`AppointmentID`);

--
-- Indexes for table `receptionists`
--
ALTER TABLE `receptionists`
  ADD PRIMARY KEY (`ReceptionistID`),
  ADD KEY `UserID` (`UserID`);

--
-- Indexes for table `services`
--
ALTER TABLE `services`
  ADD PRIMARY KEY (`ServiceID`),
  ADD KEY `ServiceType` (`ServiceType`);

--
-- Indexes for table `servicesperformed`
--
ALTER TABLE `servicesperformed`
  ADD PRIMARY KEY (`ServicePerformedID`),
  ADD KEY `AppointmentID` (`AppointmentID`),
  ADD KEY `ServiceID` (`ServiceID`);

--
-- Indexes for table `servicetypes`
--
ALTER TABLE `servicetypes`
  ADD PRIMARY KEY (`ServiceTypeID`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`UserID`),
  ADD UNIQUE KEY `EmailAddress` (`EmailAddress`),
  ADD UNIQUE KEY `ContactNumber` (`ContactNumber`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `appointments`
--
ALTER TABLE `appointments`
  MODIFY `AppointmentID` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `bills`
--
ALTER TABLE `bills`
  MODIFY `BillID` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `doctors`
--
ALTER TABLE `doctors`
  MODIFY `DoctorID` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `patients`
--
ALTER TABLE `patients`
  MODIFY `PatientID` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `prescriptionrecords`
--
ALTER TABLE `prescriptionrecords`
  MODIFY `PrescriptionID` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `receptionists`
--
ALTER TABLE `receptionists`
  MODIFY `ReceptionistID` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `services`
--
ALTER TABLE `services`
  MODIFY `ServiceID` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `servicesperformed`
--
ALTER TABLE `servicesperformed`
  MODIFY `ServicePerformedID` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `servicetypes`
--
ALTER TABLE `servicetypes`
  MODIFY `ServiceTypeID` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `UserID` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `appointments`
--
ALTER TABLE `appointments`
  ADD CONSTRAINT `appointments_ibfk_1` FOREIGN KEY (`PatientID`) REFERENCES `patients` (`PatientID`),
  ADD CONSTRAINT `appointments_ibfk_2` FOREIGN KEY (`DoctorID`) REFERENCES `doctors` (`DoctorID`);

--
-- Constraints for table `bills`
--
ALTER TABLE `bills`
  ADD CONSTRAINT `bills_ibfk_1` FOREIGN KEY (`AppointmentID`) REFERENCES `appointments` (`AppointmentID`);

--
-- Constraints for table `doctors`
--
ALTER TABLE `doctors`
  ADD CONSTRAINT `doctors_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `users` (`UserID`);

--
-- Constraints for table `prescriptionrecords`
--
ALTER TABLE `prescriptionrecords`
  ADD CONSTRAINT `prescriptionrecords_ibfk_1` FOREIGN KEY (`AppointmentID`) REFERENCES `appointments` (`AppointmentID`);

--
-- Constraints for table `receptionists`
--
ALTER TABLE `receptionists`
  ADD CONSTRAINT `receptionists_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `users` (`UserID`);

--
-- Constraints for table `services`
--
ALTER TABLE `services`
  ADD CONSTRAINT `services_ibfk_1` FOREIGN KEY (`ServiceType`) REFERENCES `servicetypes` (`ServiceTypeID`);

--
-- Constraints for table `servicesperformed`
--
ALTER TABLE `servicesperformed`
  ADD CONSTRAINT `servicesperformed_ibfk_1` FOREIGN KEY (`AppointmentID`) REFERENCES `appointments` (`AppointmentID`),
  ADD CONSTRAINT `servicesperformed_ibfk_2` FOREIGN KEY (`ServiceID`) REFERENCES `services` (`ServiceID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
