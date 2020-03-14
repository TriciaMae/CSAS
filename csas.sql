-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 14, 2020 at 11:24 AM
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
-- Database: `csas_new`
--

-- --------------------------------------------------------

--
-- Table structure for table `community_info`
--

CREATE TABLE `community_info` (
  `id` int(5) NOT NULL,
  `region_id` int(5) NOT NULL,
  `firstname` varchar(32) NOT NULL,
  `lastname` varchar(32) NOT NULL,
  `cp` varchar(11) NOT NULL,
  `province` varchar(32) NOT NULL,
  `city` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `community_info`
--

INSERT INTO `community_info` (`id`, `region_id`, `firstname`, `lastname`, `cp`, `province`, `city`) VALUES
(1, 1, 'Timothy', 'Maat', '09613655290', 'Metro Manila', 'Manila City'),
(2, 1, 'Tricia Mae', 'Buted', '09154244355', 'Metro Manila', 'Manila City'),
(3, 1, 'Elpidio', 'Francisco', '09164344363', 'Metro Manila', 'Quezon City'),
(4, 1, 'Leanne', 'Dayao', '09260490174', 'Metro Manila', 'Quezon City'),
(5, 1, 'Tim', 'Maat', '09055111349', 'Metro Manila', 'Marikina City');

-- --------------------------------------------------------

--
-- Table structure for table `regions`
--

CREATE TABLE `regions` (
  `id` int(5) NOT NULL,
  `region` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `regions`
--

INSERT INTO `regions` (`id`, `region`) VALUES
(1, 'NCR'),
(2, 'CAR'),
(3, 'Region I'),
(4, 'Region II'),
(5, 'Region III'),
(6, 'Region IV-A'),
(7, 'Region IV-B'),
(8, 'Region V'),
(9, 'Region VI'),
(10, 'Region VII'),
(11, 'Region VIII'),
(12, 'Region IX'),
(13, 'Region X'),
(14, 'Region XI'),
(15, 'Region XII'),
(16, 'Region XIII'),
(17, 'ARMM');

-- --------------------------------------------------------

--
-- Table structure for table `schools`
--

CREATE TABLE `schools` (
  `id` int(5) NOT NULL,
  `school` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `schools`
--

INSERT INTO `schools` (`id`, `school`) VALUES
(1, 'Ramon Magsaysay'),
(2, 'PUP'),
(3, 'UST'),
(4, 'FEU'),
(5, 'CSBN'),
(6, 'PLM');

-- --------------------------------------------------------

--
-- Table structure for table `school_info`
--

CREATE TABLE `school_info` (
  `id` int(5) NOT NULL,
  `school_id` int(5) NOT NULL,
  `lvl_id` int(5) NOT NULL,
  `firstname` varchar(32) NOT NULL,
  `lastname` varchar(32) NOT NULL,
  `cp_num` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `school_info`
--

INSERT INTO `school_info` (`id`, `school_id`, `lvl_id`, `firstname`, `lastname`, `cp_num`) VALUES
(1, 2, 3, 'Timothy', 'Maat', '09613655290'),
(2, 2, 2, 'Tricia Mae', 'Buted', '09164344363'),
(3, 3, 3, 'Leanne', 'Dayao', '09260490174'),
(4, 1, 2, 'Elpidio', 'Francisco', '09568578044'),
(5, 2, 3, 'Tim', 'Maat', '09055111349'),
(6, 2, 2, 'John', 'Doe', '09260490174');

-- --------------------------------------------------------

--
-- Table structure for table `school_lvl`
--

CREATE TABLE `school_lvl` (
  `id` int(5) NOT NULL,
  `level` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `school_lvl`
--

INSERT INTO `school_lvl` (`id`, `level`) VALUES
(1, 'Elementary'),
(2, 'High School'),
(3, 'College');

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
(1, 'tricia', 'tricia'),
(2, 'samboy', 'samboy'),
(3, 'timot', 'timot'),
(4, 'leanne', 'leanne');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `community_info`
--
ALTER TABLE `community_info`
  ADD PRIMARY KEY (`id`),
  ADD KEY `region_id` (`region_id`);

--
-- Indexes for table `regions`
--
ALTER TABLE `regions`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `schools`
--
ALTER TABLE `schools`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `school_info`
--
ALTER TABLE `school_info`
  ADD PRIMARY KEY (`id`),
  ADD KEY `lvl_id` (`lvl_id`),
  ADD KEY `school_id` (`school_id`);

--
-- Indexes for table `school_lvl`
--
ALTER TABLE `school_lvl`
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
-- AUTO_INCREMENT for table `community_info`
--
ALTER TABLE `community_info`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `regions`
--
ALTER TABLE `regions`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `schools`
--
ALTER TABLE `schools`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `school_info`
--
ALTER TABLE `school_info`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `school_lvl`
--
ALTER TABLE `school_lvl`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `community_info`
--
ALTER TABLE `community_info`
  ADD CONSTRAINT `community_info_ibfk_1` FOREIGN KEY (`region_id`) REFERENCES `regions` (`id`);

--
-- Constraints for table `school_info`
--
ALTER TABLE `school_info`
  ADD CONSTRAINT `school_info_ibfk_1` FOREIGN KEY (`lvl_id`) REFERENCES `school_lvl` (`id`),
  ADD CONSTRAINT `school_info_ibfk_2` FOREIGN KEY (`school_id`) REFERENCES `schools` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
