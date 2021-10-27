-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 26, 2021 at 04:39 PM
-- Server version: 10.4.18-MariaDB
-- PHP Version: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `librarymanagementsystem`
--

-- --------------------------------------------------------

--
-- Table structure for table `adminlogin`
--

CREATE TABLE `adminlogin` (
  `adminname` varchar(50) NOT NULL,
  `adminid` varchar(50) NOT NULL,
  `adminpassword` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `adminlogin`
--

INSERT INTO `adminlogin` (`adminname`, `adminid`, `adminpassword`) VALUES
('Mr Prodhan', 'A0001', 'Admin'),
('Admin', 'Admin', 'Admin');

-- --------------------------------------------------------

--
-- Table structure for table `bookinformation`
--

CREATE TABLE `bookinformation` (
  `bookname` varchar(100) NOT NULL,
  `bookid` varchar(100) NOT NULL,
  `bookpublishyear` int(11) NOT NULL,
  `writername` varchar(100) NOT NULL,
  `quantityofbook` int(5) NOT NULL,
  `categoryname` varchar(100) NOT NULL,
  `entrydate` date NOT NULL,
  `availablebook` varchar(3) NOT NULL,
  `borrowbook` varchar(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `bookinformation`
--

INSERT INTO `bookinformation` (`bookname`, `bookid`, `bookpublishyear`, `writername`, `quantityofbook`, `categoryname`, `entrydate`, `availablebook`, `borrowbook`) VALUES
('Bangla', 'B-101', 2021, 'Shiam Prodhan', 200, 'Educational', '2021-04-26', 'Yes', 'N/A'),
('Marvel Stories', 'C-205', 2008, 'Tony Stark', 1000, 'Comics', '2021-04-26', 'Yes', 'N/A'),
('English', 'E-102', 2019, 'Nazmuj Shakib Diip', 250, 'Educational', '2021-04-06', 'Yes', 'N/A'),
('Conjuring', 'H-501', 1998, 'Afraim Bin Zahangir', 204, 'Horror', '2021-01-14', 'No', 'N/A'),
('Filmfare 2021', 'M-420', 2021, 'Karan Johar', 500, 'Magazines', '2021-04-12', 'Yes', 'N/A');

-- --------------------------------------------------------

--
-- Table structure for table `managerlogin`
--

CREATE TABLE `managerlogin` (
  `managername` varchar(50) NOT NULL,
  `managerid` varchar(50) NOT NULL,
  `managerpassword` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `managerlogin`
--

INSERT INTO `managerlogin` (`managername`, `managerid`, `managerpassword`) VALUES
('Nazmuj Shakib', 'M0001', 'Manager'),
('Afraim', 'M0002', 'Manager'),
('Shiam', 'M0004', 'Manager'),
('Sazeda', 'M0005', 'Manager'),
('Manager', 'Manager', 'Manager'),
('Bappy', 'Withdraw101', 'A+');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `adminlogin`
--
ALTER TABLE `adminlogin`
  ADD PRIMARY KEY (`adminid`);

--
-- Indexes for table `bookinformation`
--
ALTER TABLE `bookinformation`
  ADD UNIQUE KEY `bookid` (`bookid`);

--
-- Indexes for table `managerlogin`
--
ALTER TABLE `managerlogin`
  ADD PRIMARY KEY (`managerid`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
