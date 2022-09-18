-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 26, 2022 at 02:55 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ptest`
--

-- --------------------------------------------------------

--
-- Table structure for table `entering_db`
--

CREATE TABLE `entering_db` (
  `id` int(40) NOT NULL,
  `card_id` int(40) NOT NULL,
  `timein` time NOT NULL,
  `timeout` time NOT NULL,
  `date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `entering_db`
--

INSERT INTO `entering_db` (`id`, `card_id`, `timein`, `timeout`, `date`) VALUES
(1, 123456, '08:22:00', '00:00:00', '2022-07-14');

-- --------------------------------------------------------

--
-- Table structure for table `leaving_db`
--

CREATE TABLE `leaving_db` (
  `id` int(40) NOT NULL,
  `card_id` int(40) NOT NULL,
  `timeout` time NOT NULL,
  `date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `leaving_db`
--

INSERT INTO `leaving_db` (`id`, `card_id`, `timeout`, `date`) VALUES
(1, 123456, '12:00:00', '2022-07-14');

-- --------------------------------------------------------

--
-- Table structure for table `student_data`
--

CREATE TABLE `student_data` (
  `id` int(40) NOT NULL,
  `name` varchar(50) NOT NULL,
  `roll_num` int(50) NOT NULL,
  `card_id` int(40) NOT NULL,
  `gender` varchar(20) NOT NULL,
  `department` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `authorize` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `student_data`
--

INSERT INTO `student_data` (`id`, `name`, `roll_num`, `card_id`, `gender`, `department`, `email`, `authorize`) VALUES
(1, 'Student1', 1, 123456, 'Male', 'Electronics', 'stu1@gmail.com', 1),
(12, 'test1', 3, 1234567, 'Male', 'eng', 'res@gmail.com', 1),
(14, 'test2', 2, 3564577, 'Male', 'eng', 'res@gmail.com', 1),
(15, 'test3', 5, 12312424, 'Female', 'eng', 'admin@gmail.com', 1);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `user_name` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `user_name`, `password`, `name`) VALUES
(1, 'admin', '123', 'Admin'),
(2, 'test1', 'abc', 'Test');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `entering_db`
--
ALTER TABLE `entering_db`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `leaving_db`
--
ALTER TABLE `leaving_db`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `student_data`
--
ALTER TABLE `student_data`
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
-- AUTO_INCREMENT for table `entering_db`
--
ALTER TABLE `entering_db`
  MODIFY `id` int(40) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `leaving_db`
--
ALTER TABLE `leaving_db`
  MODIFY `id` int(40) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `student_data`
--
ALTER TABLE `student_data`
  MODIFY `id` int(40) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
