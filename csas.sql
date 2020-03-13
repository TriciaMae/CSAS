-- phpMyAdmin SQL Dump
-- version 4.7.9
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 13, 2020 at 02:32 PM
-- Server version: 10.1.31-MariaDB
-- PHP Version: 7.2.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `csas`
--

-- --------------------------------------------------------

--
-- Table structure for table `comm`
--

CREATE TABLE `comm` (
  `id` int(30) NOT NULL,
  `cp` varchar(11) NOT NULL,
  `region` varchar(50) NOT NULL,
  `city` varchar(50) NOT NULL,
  `province` varchar(50) NOT NULL,
  `lvl` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `comm`
--

INSERT INTO `comm` (`id`, `cp`, `region`, `city`, `province`, `lvl`) VALUES
(1, '09154244355', 'NCR', 'Manila', 'Metro Manila', 'College'),
(2, '09164344363', 'NCR', 'Manila', 'Metro Manila', 'College'),
(3, '09055111349', 'NCR', 'Quezon City', 'Quezon City ', 'College'),
(4, '09613655290', 'NCR', 'Quezon City', 'Batangas', 'College'),
(5, '09260490174', 'NCR', 'Quezon City', 'Batangas', 'Elementary');

-- --------------------------------------------------------

--
-- Table structure for table `grp`
--

CREATE TABLE `grp` (
  `id` int(10) NOT NULL,
  `sch_lvl_id` int(11) DEFAULT NULL,
  `school` varchar(50) NOT NULL,
  `cp_num` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `grp`
--

INSERT INTO `grp` (`id`, `sch_lvl_id`, `school`, `cp_num`) VALUES
(1, 0, 'PUP', '09154244355'),
(1, 0, 'PUP', '09164344363'),
(2, 0, 'CSBN', '09613655290'),
(2, 0, 'CSBN', '09260490174'),
(2, 0, 'CSBN', '09123456789'),
(2, 0, 'ABC', '09123456789'),
(2, 0, 'BCD', '09123456789'),
(3, 0, 'EFG', '09123456789'),
(4, 0, 'XYZ', '12345678901'),
(5, 0, 'TET', '09154244355');

-- --------------------------------------------------------

--
-- Table structure for table `sch_lvl`
--

CREATE TABLE `sch_lvl` (
  `id` int(4) NOT NULL,
  `level` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sch_lvl`
--

INSERT INTO `sch_lvl` (`id`, `level`) VALUES
(1, 'Elementary'),
(2, 'Secondary'),
(3, 'Tertiary');

-- --------------------------------------------------------

--
-- Table structure for table `send`
--

CREATE TABLE `send` (
  `id` int(10) NOT NULL,
  `school` varchar(50) NOT NULL,
  `lvl` varchar(50) NOT NULL,
  `cp_num` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `send`
--

INSERT INTO `send` (`id`, `school`, `lvl`, `cp_num`) VALUES
(1, 'PUP', 'College', '01234567890'),
(2, 'PUP', 'High School', '09164344363'),
(3, 'UST', 'College', '09613655290'),
(4, 'Ramon Magsaysay', 'Elementary', '09260490174'),
(6, 'PUP', 'College', '09613655290'),
(7, 'PUP', 'HIgh School', '09568578044'),
(8, 'PUP', 'College', '09260490174');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(10) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(10) NOT NULL
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
-- AUTO_INCREMENT for table `send`
--
ALTER TABLE `send`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
