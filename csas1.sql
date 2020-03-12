-- phpMyAdmin SQL Dump
-- version 4.7.9
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 12, 2020 at 03:50 PM
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
-- Table structure for table `tricia`
--

CREATE TABLE `tricia` (
  `id` int(11) DEFAULT NULL,
  `cp` varchar(11) NOT NULL,
  `region` varchar(30) NOT NULL,
  `city` varchar(30) NOT NULL,
  `province` varchar(30) NOT NULL,
  `lvl` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tricia`
--

INSERT INTO `tricia` (`id`, `cp`, `region`, `city`, `province`, `lvl`) VALUES
(1, '09154244355', 'NCR', 'Manila', 'Metro Manila', 'College'),
(2, '09164344363', 'NCR', 'Manila', 'Metro Manila', 'College'),
(3, '09055111349', 'NCR', 'Quezon City', 'Quezon City', 'College'),
(4, '09613655290', 'NCR', 'Quezon City', 'Batangas', 'College'),
(5, '09260490174', 'NCR', 'Quezon City', 'Batangas', 'Elementary');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
