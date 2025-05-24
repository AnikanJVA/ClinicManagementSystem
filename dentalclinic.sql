-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 24, 2025 at 01:10 PM
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
  `PatientID` bigint(20) NOT NULL,
  `DoctorID` bigint(20) NOT NULL,
  `AppointmentDateTime` datetime NOT NULL,
  `ReasonForAppointment` text DEFAULT NULL,
  `Status` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `doctors`
--

CREATE TABLE `doctors` (
  `doctorID` bigint(20) NOT NULL,
  `firstName` varchar(255) NOT NULL,
  `lastName` varchar(255) NOT NULL,
  `middleName` varchar(255) NOT NULL,
  `contactNumber` varchar(15) NOT NULL,
  `hireDate` date NOT NULL,
  `emailAddress` varchar(255) DEFAULT NULL,
  `address` varchar(255) NOT NULL,
  `licenseNumber` varchar(255) NOT NULL,
  `status` varchar(20) DEFAULT 'active'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `doctors`
--

INSERT INTO `doctors` (`doctorID`, `firstName`, `lastName`, `middleName`, `contactNumber`, `hireDate`, `emailAddress`, `address`, `licenseNumber`, `status`) VALUES
(1, 'alok', 'kanojia', 'healtyGG', '12341234', '2025-05-23', 'alok@gmail.com', 'US', '33366644558', 'active'),
(2, 'salamat', 'doccc', 'do', '09088184444', '2025-05-23', 'docc@gmail.com', 'abscbn', '900912344', 'active');

-- --------------------------------------------------------

--
-- Table structure for table `patients`
--

CREATE TABLE `patients` (
  `patientID` bigint(20) NOT NULL,
  `firstName` varchar(255) NOT NULL,
  `middleName` varchar(255) NOT NULL,
  `lastName` varchar(255) NOT NULL,
  `DoB` date NOT NULL,
  `sex` char(1) DEFAULT 'M' CHECK (`sex` = 'M' or `sex` = 'F'),
  `contactNumber` varchar(15) NOT NULL,
  `altContactNumber` varchar(15) DEFAULT NULL,
  `emailAddress` varchar(255) DEFAULT NULL,
  `address` varchar(255) NOT NULL,
  `status` varchar(8) DEFAULT 'ACTIVE'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `patients`
--

INSERT INTO `patients` (`patientID`, `firstName`, `middleName`, `lastName`, `DoB`, `sex`, `contactNumber`, `altContactNumber`, `emailAddress`, `address`, `status`) VALUES
(1, 'ani', 'kan', 'va', '2003-10-11', 'm', '09103243490', NULL, 'anikanjva@gmail.com', 'juna subd, matina, davao city', 'ACTIVE'),
(2, 'james andrew', 'Doe', 'De castro', '2000-05-10', 'M', '09101010101', '09222222222', 'james@gmail.com', 'cabantian dc', 'ACTIVE'),
(3, 'justine', 'lamnda', 'mantua', '2004-09-10', 'M', '09123123123', '09123123123', 'justine@gmail.com', 'bangkerohan dc', 'ACTIVE'),
(4, 'matt oliver', 'utrera', 'pojadas', '2004-07-06', 'M', '0933333333', '0944444444', 'matt@gmail.com', 'sandawa dc', 'ACTIVE'),
(5, 'princess', 'pia', 'fernando', '2005-04-14', 'F', '0955555555', '0966666666', 'princess@gmail.com', 'ecoland dc', 'ACTIVE'),
(6, 'justine', 'doe', 'de castro', '2025-05-22', 'M', '123123', '12312312', '123', '123', 'ACTIVE'),
(7, 'aaron', 'john', 'mantua', '2025-05-22', 'F', '123', '123', '123', '123', 'ACTIVE'),
(8, 'anikan john', 'cima', 'villa-abrille', '2003-10-11', 'M', '09103243490', '09234908123', 'anikanjva@gmail.com', '123123123', 'ACTIVE');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `userid` bigint(20) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `accType` varchar(12) NOT NULL,
  `status` varchar(8) DEFAULT 'ACTIVE'
) ;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`userid`, `username`, `password`, `accType`, `status`) VALUES
(0, 'admin', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'admin', 'ACTIVE'),
(1, 'jo', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'Receptionist', 'ACTIVE'),
(2, 'ani', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'Doctor', 'ACTIVE');

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
-- Indexes for table `doctors`
--
ALTER TABLE `doctors`
  ADD PRIMARY KEY (`doctorID`);

--
-- Indexes for table `patients`
--
ALTER TABLE `patients`
  ADD PRIMARY KEY (`patientID`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`userid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `appointments`
--
ALTER TABLE `appointments`
  MODIFY `AppointmentID` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `doctors`
--
ALTER TABLE `doctors`
  MODIFY `doctorID` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `patients`
--
ALTER TABLE `patients`
  MODIFY `patientID` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `userid` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `appointments`
--
ALTER TABLE `appointments`
  ADD CONSTRAINT `appointments_ibfk_1` FOREIGN KEY (`PatientID`) REFERENCES `patients` (`patientID`),
  ADD CONSTRAINT `appointments_ibfk_2` FOREIGN KEY (`DoctorID`) REFERENCES `doctors` (`doctorID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
