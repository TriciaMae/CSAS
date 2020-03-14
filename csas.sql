-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 14, 2020 at 12:55 PM
-- Server version: 10.1.37-MariaDB
-- PHP Version: 7.3.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `csas_demo`
--

-- --------------------------------------------------------

--
-- Table structure for table `comm`
--

CREATE TABLE `comm` (
  `id` int(5) NOT NULL,
  `fname` varchar(32) NOT NULL,
  `lname` varchar(32) NOT NULL,
  `cp` varchar(11) NOT NULL,
  `region` varchar(32) NOT NULL,
  `city` varchar(32) NOT NULL,
  `province` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `comm`
--

INSERT INTO `comm` (`id`, `fname`, `lname`, `cp`, `region`, `city`, `province`) VALUES
(1, 'Tricia Mae', 'Buted', '09154244355', 'NCR', 'Manila', 'Metro Manila'),
(2, 'Elpidio', 'Francisco', '09164344363', 'NCR', 'Manila', 'Metro Manila'),
(3, 'Tim', 'Maat', '09055111349', 'NCR', 'Quezon City', 'Metro Manila'),
(4, 'Timothy', 'Maat', '09613655290', 'NCR', 'Quezon City', 'Batangas'),
(5, 'Leanne Mae', 'Dayao', '09260490174', 'NCR', 'Quezon City', 'Batangas');

-- --------------------------------------------------------

--
-- Table structure for table `send`
--

CREATE TABLE `send` (
  `id` int(5) NOT NULL,
  `fname` varchar(32) NOT NULL,
  `lname` varchar(32) NOT NULL,
  `school` varchar(32) NOT NULL,
  `lvl` varchar(32) NOT NULL,
  `cp_num` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `send`
--

INSERT INTO `send` (`id`, `fname`, `lname`, `school`, `lvl`, `cp_num`) VALUES
(1, 'Timothy', 'Maat', 'PUP', 'College', '09613655290'),
(2, 'Tricia Mae', 'Buted', 'PUP', 'High School', '09154244355'),
(3, 'Leanne Mae', 'Dayao', 'PUP', 'College', '09260490174'),
(4, 'Elpidio', 'Francisco', 'PUP', 'High School', '09164344363');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(5) NOT NULL,
  `username` varchar(32) NOT NULL,
  `password` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `username`, `password`) VALUES
(1, 'admin', 'admin'),
(2, 'timot', 'timot'),
(3, 'samboy', 'samboy'),
(4, 'leanne', 'leanne');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `comm`
--
ALTER TABLE `comm`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `send`
--
ALTER TABLE `send`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `comm`
--
ALTER TABLE `comm`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `send`
--
ALTER TABLE `send`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
