-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 11, 2025 at 03:53 AM
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
  `Status` varchar(20) DEFAULT 'APPROVED'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `appointments`
--

INSERT INTO `appointments` (`AppointmentID`, `PatientID`, `DoctorID`, `AppointmentDateTime`, `ReasonForAppointment`, `Status`) VALUES
(1, 4, 1, '2025-06-01 08:25:00', 'clean\r\n', 'FINISHED'),
(2, 5, 1, '2028-02-29 12:51:00', 'Nagsakit ang ngipont, gusto daw dungangan', 'FINISHED'),
(3, 6, 1, '2025-05-30 05:00:00', 'nagsakit ang mata kay naa daw lain', 'FINISHED'),
(4, 6, 1, '2025-05-29 22:46:00', 'asdfasdf', 'CANCELED'),
(5, 1, 2, '2025-05-29 22:54:00', '1234125asg', 'FINISHED'),
(6, 5, 2, '2025-05-30 13:00:00', 'asdf', 'FINISHED'),
(7, 5, 1, '2025-05-30 13:02:00', 'adsfas', 'FINISHED'),
(8, 1, 1, '2025-05-30 13:03:00', 'bvdcxvbxcbv', 'FINISHED'),
(9, 4, 1, '2025-05-30 09:00:00', 'asdfasdf', 'FINISHED'),
(10, 2, 3, '2025-06-13 17:00:00', 'nagsakit ang tiyan, pa tanaw daw sa ngipon', 'APPROVED'),
(11, 2, 2, '2025-06-08 12:00:00', 'asdf', 'APPROVED'),
(12, 4, 2, '2025-06-08 12:10:00', 'nbvcvbn', 'APPROVED'),
(13, 2, 1, '2025-06-11 13:11:00', 'asdf', 'RESCHEDULED'),
(14, 5, 2, '2025-06-08 14:12:00', 'asdf', 'APPROVED'),
(15, 4, 4, '2025-06-11 17:00:00', 'Request for Ubercharge', 'RESCHEDULED'),
(16, 4, 4, '2025-06-10 15:13:00', 'Requesting Kritz', 'APPROVED'),
(17, 1, 3, '2025-06-10 16:14:00', 'gi panuhot, gusto magpa puti ug ngipon\r\n', 'RESCHEDULED'),
(18, 5, 3, '2025-06-26 17:00:00', 'lkhjl', 'APPROVED');

-- --------------------------------------------------------

--
-- Table structure for table `bills`
--

CREATE TABLE `bills` (
  `BillID` bigint(20) NOT NULL,
  `AppointmentID` bigint(20) DEFAULT NULL,
  `BillingDate` date DEFAULT NULL,
  `TotalAmount` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `bills`
--

INSERT INTO `bills` (`BillID`, `AppointmentID`, `BillingDate`, `TotalAmount`) VALUES
(1, 1, '2025-05-29', 800.00),
(3, 5, '2025-05-30', 723.00),
(4, 6, '2025-05-30', 1650.50),
(6, 9, '2025-06-07', 950.50),
(9, 8, '2025-06-09', 2386.49),
(10, 2, '2025-06-09', 2832.91);

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
  `Schedule` text DEFAULT NULL,
  `AvailabilityStatus` varchar(20) DEFAULT 'AVAILABLE'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `doctors`
--

INSERT INTO `doctors` (`DoctorID`, `UserID`, `FirstName`, `MiddleName`, `LastName`, `HireDate`, `LicenseNumber`, `Schedule`, `AvailabilityStatus`) VALUES
(1, 3, 'A', 'Doc', 'Tor', NULL, '12345', 'M,', 'UNAVAILABLE'),
(2, 7, 'DOCTOR ', 'NUMBER', 'TWO', NULL, '12312412531235', 'T, Th,', 'UNAVAILABLE'),
(3, 8, 'fredric', 'odd', 'loop', NULL, '9889312515125', 'M, T, W,', 'AVAILABLE'),
(4, 9, 'Medic', 'Sa', 'TeamFortress', NULL, '0912349816', 'Th, F, S,', 'UNAVAILABLE'),
(5, 10, 'aa', 'AA', 'AAA', NULL, '123516234125', 'T,', 'UNAVAILABLE');

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
(1, 'ani', 'va', 'kan', '2003-10-11', 'F', '09103243490', '09080808', 'anikanjva@gmail.com', 'juna subd, matina, davao city', 'ACTIVE'),
(2, 'james andrew', 'De castro', 'Doe', '2000-05-10', 'M', '09101010101', '09222222222', 'james@gmail.com', 'cabantian dc', 'ACTIVE'),
(3, 'justine', 'mantua', 'lamnda', '2004-09-10', 'M', '09123123123', NULL, NULL, 'bangkerohan dc', 'ACTIVE'),
(4, 'matt oliver', 'pojadas', 'utrera', '2004-07-06', 'M', '0933333333', '0944444444', 'matt@gmail.com', 'sandawa dc', 'ACTIVE'),
(5, 'Bryce', 'Rosco', 'Bandala', '1965-12-12', 'M', '0922654823125', '090893312', 'erialakjsdf@gmail.com', 'balay namo', 'ACTIVE'),
(6, 'Justine', 'Paclibar', 'Lim', '2001-08-29', 'F', '09917099706', '12345678910', NULL, 'asdf 140123', 'ACTIVE');

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

--
-- Dumping data for table `receptionists`
--

INSERT INTO `receptionists` (`ReceptionistID`, `UserID`, `FirstName`, `LastName`, `MiddleName`) VALUES
(1, 2, 'bryce', 'arce', 'tiburtio'),
(2, 4, 'recep', 'nista', 'tion'),
(3, 5, 'sparks', 'miming', 'si'),
(4, 6, 'ginger', 'cat', 'hinher');

-- --------------------------------------------------------

--
-- Table structure for table `services`
--

CREATE TABLE `services` (
  `ServiceID` bigint(20) NOT NULL,
  `ServiceName` varchar(100) DEFAULT NULL,
  `ServiceTypeID` bigint(20) DEFAULT NULL,
  `ServiceDesc` text DEFAULT NULL,
  `Price` decimal(10,2) DEFAULT NULL,
  `Status` varchar(20) NOT NULL DEFAULT 'ACTIVE'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `services`
--

INSERT INTO `services` (`ServiceID`, `ServiceName`, `ServiceTypeID`, `ServiceDesc`, `Price`, `Status`) VALUES
(1, 'Check up', 1, 'check up', 500.00, 'AVAILABLE'),
(2, 'Cleaning', 1, 'cleaning', 600.00, 'AVAILABLE'),
(3, 'Teeth Whitening', 1, 'Whitening', 200.00, 'AVAILABLE'),
(4, 'aaron', 2, 'john', 12.99, 'AVAILABLE'),
(5, 'test2', 1, 'testing2', 123.00, 'AVAILABLE'),
(6, 'test three', 1, 'testing3', 950.50, 'AVAILABLE'),
(7, 'Tooth Extraction', 3, 'tanggal ngipon', 1000.00, 'UNAVAILABLE'),
(8, 'kuan', 4, 'kato gung kuang gud', 69.42, 'UNAVAILABLE');

-- --------------------------------------------------------

--
-- Table structure for table `servicesperformed`
--

CREATE TABLE `servicesperformed` (
  `ServicePerformedID` bigint(20) NOT NULL,
  `AppointmentID` bigint(20) DEFAULT NULL,
  `ServiceID` bigint(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `servicesperformed`
--

INSERT INTO `servicesperformed` (`ServicePerformedID`, `AppointmentID`, `ServiceID`) VALUES
(1, 1, 3),
(2, 1, 2),
(5, 5, 2),
(6, 5, 5),
(7, 6, 1),
(8, 6, 3),
(9, 6, 6),
(11, 9, 6),
(25, 8, 2),
(26, 8, 1),
(27, 8, 3),
(28, 8, 4),
(29, 8, 5),
(30, 8, 6),
(31, 2, 8),
(32, 2, 7),
(33, 2, 3),
(34, 2, 2),
(35, 2, 6),
(36, 2, 4);

-- --------------------------------------------------------

--
-- Table structure for table `servicetypes`
--

CREATE TABLE `servicetypes` (
  `ServiceTypeID` bigint(20) NOT NULL,
  `ServiceTypeName` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `servicetypes`
--

INSERT INTO `servicetypes` (`ServiceTypeID`, `ServiceTypeName`) VALUES
(1, 'Preventive Services'),
(2, 'Pediatric Dentistry'),
(3, 'Restorative Services'),
(4, 'Cosmetic Services'),
(5, 'Periodontal Services'),
(6, 'Prosthodontic Services');

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
  `status` varchar(20) DEFAULT 'AVAILABLE'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`UserID`, `Username`, `Password`, `AccType`, `EmailAddress`, `ContactNumber`, `AltContactNumber`, `Address`, `status`) VALUES
(1, 'admin', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'admin', 'admin@admin.com', '0000000', '111111111', 'adminhome', 'ACTIVE'),
(2, 'jo', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'RECEPTIONIST', '123@yahoo.com', '1', '23', 'asdf', 'ACTIVE'),
(3, 'do', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'DOCTOR', 'asdf@yahoo.com', '123', '12342314', '123asdf', 'ACTIVE'),
(4, 'test', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'RECEPTIONIST', 'email@gmail.com', '12341256', '23156156', 'asdf', 'ACTIVE'),
(5, 'asdf', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'RECEPTIONIST', 'email2@gmail.com', '8976839456', '235198489', 'asdf', 'ACTIVE'),
(6, 'asdfzcvx', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 'RECEPTIONIST', 'email3@gmail.com', '23141234', '56498132', 'axzcv', 'ACTIVE'),
(7, 'cc', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'DOCTOR', '1123as@123.com', '34537234', '253423671346', 'asdf', 'ACTIVE'),
(8, 'fredric', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'DOCTOR', 'fredric@gmail.com', '12309123123', '34250982345', 'japan', 'ACTIVE'),
(9, 'medic', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'DOCTOR', 'medic@tf2.com', '321657891', '321325468', 'Germany', 'ACTIVE'),
(10, 'aaa', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'DOCTOR', 'aaa@aaa.com', '453634571', '234623462', 'aaaaa', 'ACTIVE');

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
  ADD KEY `ServiceType` (`ServiceTypeID`);

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
  ADD UNIQUE KEY `ContactNumber` (`ContactNumber`),
  ADD UNIQUE KEY `AltContactNumber` (`AltContactNumber`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `appointments`
--
ALTER TABLE `appointments`
  MODIFY `AppointmentID` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT for table `bills`
--
ALTER TABLE `bills`
  MODIFY `BillID` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `doctors`
--
ALTER TABLE `doctors`
  MODIFY `DoctorID` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `patients`
--
ALTER TABLE `patients`
  MODIFY `PatientID` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `receptionists`
--
ALTER TABLE `receptionists`
  MODIFY `ReceptionistID` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `services`
--
ALTER TABLE `services`
  MODIFY `ServiceID` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `servicesperformed`
--
ALTER TABLE `servicesperformed`
  MODIFY `ServicePerformedID` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=38;

--
-- AUTO_INCREMENT for table `servicetypes`
--
ALTER TABLE `servicetypes`
  MODIFY `ServiceTypeID` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `UserID` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

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
-- Constraints for table `receptionists`
--
ALTER TABLE `receptionists`
  ADD CONSTRAINT `receptionists_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `users` (`UserID`);

--
-- Constraints for table `services`
--
ALTER TABLE `services`
  ADD CONSTRAINT `services_ibfk_1` FOREIGN KEY (`ServiceTypeID`) REFERENCES `servicetypes` (`ServiceTypeID`);

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
