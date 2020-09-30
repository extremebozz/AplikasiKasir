-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 30, 2020 at 08:21 AM
-- Server version: 10.3.16-MariaDB
-- PHP Version: 7.3.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `aplikasikasir`
--

-- --------------------------------------------------------

--
-- Table structure for table `data_pembelian`
--

CREATE TABLE `data_pembelian` (
  `invoice` varchar(50) NOT NULL,
  `tanggal_transaksi` date NOT NULL,
  `nama_kasir` varchar(50) NOT NULL,
  `diskon_pembelian` int(10) NOT NULL,
  `total_harga` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `data_pembelian`
--

INSERT INTO `data_pembelian` (`invoice`, `tanggal_transaksi`, `nama_kasir`, `diskon_pembelian`, `total_harga`) VALUES
('Invoice2009260001', '2020-09-26', 'user', 0, 27010000),
('Invoice2009260002', '2020-09-26', 'user', 0, 27010000),
('Invoice2009270001', '2020-09-27', 'user', 0, 12000000),
('Invoice2009270002', '2020-09-27', 'user', 0, 27000000),
('Invoice2009270003', '2020-09-27', 'user', 0, 15000000),
('Invoice2009280001', '2020-09-28', 'Roy Valentino', 0, 12000000),
('Invoice2009290001', '2020-09-29', 'Admin', 0, 12000000),
('Invoice2009300001', '2020-09-30', 'Silvina', 0, 12000000),
('Invoice2009300002', '2020-09-30', 'Willy', 0, 12000000);

-- --------------------------------------------------------

--
-- Table structure for table `data_produk`
--

CREATE TABLE `data_produk` (
  `kode_produk` varchar(50) NOT NULL,
  `nama_produk` varchar(50) NOT NULL,
  `harga_produk` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `data_produk`
--

INSERT INTO `data_produk` (`kode_produk`, `nama_produk`, `harga_produk`) VALUES
('A001', 'Laptop Asus', 12000000),
('A002', 'Laptop Lenovo', 15000000),
('A003', 'Pensil', 10000),
('A004', 'Tipx', 6000);

-- --------------------------------------------------------

--
-- Table structure for table `data_user`
--

CREATE TABLE `data_user` (
  `id` int(11) NOT NULL,
  `nama_user` varchar(50) NOT NULL,
  `jabatan` varchar(10) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `data_user`
--

INSERT INTO `data_user` (`id`, `nama_user`, `jabatan`, `password`) VALUES
(1, 'user', 'user', 'asd'),
(2, 'Roy Valentino', 'admin', 'asd'),
(3, 'Willy', 'user', 'asd'),
(4, 'Silvina', 'admin', 'asd'),
(8, 'Admin', 'admin', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `detail_pembelian`
--

CREATE TABLE `detail_pembelian` (
  `id` int(11) NOT NULL,
  `invoice` varchar(30) NOT NULL,
  `kode_barang` varchar(50) NOT NULL,
  `nama_barang` varchar(50) NOT NULL,
  `harga_barang` int(11) NOT NULL,
  `jumlah_barang` int(11) NOT NULL,
  `diskon_barang` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `detail_pembelian`
--

INSERT INTO `detail_pembelian` (`id`, `invoice`, `kode_barang`, `nama_barang`, `harga_barang`, `jumlah_barang`, `diskon_barang`) VALUES
(1, 'Invoice2009260001', 'A001', 'Laptop Asus', 12000000, 1, 0),
(2, 'Invoice2009260001', 'A002', 'Laptop Lenovo', 15000000, 1, 0),
(3, 'Invoice2009260001', 'A003', 'Pena', 10000, 1, 0),
(4, 'Invoice2009260002', 'A001', 'Laptop Asus', 12000000, 1, 0),
(5, 'Invoice2009260002', 'A002', 'Laptop Lenovo', 15000000, 1, 0),
(6, 'Invoice2009260002', 'A003', 'Pena', 10000, 1, 0),
(7, 'Invoice2009270001', 'A001', 'Laptop Asus', 12000000, 1, 0),
(8, 'Invoice2009270002', 'A001', 'Laptop Asus', 12000000, 1, 0),
(9, 'Invoice2009270002', 'A002', 'Laptop Lenovo', 15000000, 1, 0),
(10, 'Invoice2009270003', 'A002', 'Laptop Lenovo', 15000000, 1, 0),
(11, 'Invoice2009280001', 'A001', 'Laptop Asus', 12000000, 1, 0),
(12, 'Invoice2009290001', 'A001', 'Laptop Asus', 12000000, 1, 0),
(13, 'Invoice2009300001', 'A001', 'Laptop Asus', 12000000, 1, 0),
(14, 'Invoice2009300002', 'A001', 'Laptop Asus', 12000000, 1, 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `data_pembelian`
--
ALTER TABLE `data_pembelian`
  ADD PRIMARY KEY (`invoice`);

--
-- Indexes for table `data_produk`
--
ALTER TABLE `data_produk`
  ADD PRIMARY KEY (`kode_produk`);

--
-- Indexes for table `data_user`
--
ALTER TABLE `data_user`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `detail_pembelian`
--
ALTER TABLE `detail_pembelian`
  ADD PRIMARY KEY (`id`),
  ADD KEY `invoice` (`invoice`),
  ADD KEY `kode_barang` (`kode_barang`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `data_user`
--
ALTER TABLE `data_user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `detail_pembelian`
--
ALTER TABLE `detail_pembelian`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `detail_pembelian`
--
ALTER TABLE `detail_pembelian`
  ADD CONSTRAINT `detail_pembelian_ibfk_1` FOREIGN KEY (`invoice`) REFERENCES `data_pembelian` (`invoice`),
  ADD CONSTRAINT `detail_pembelian_ibfk_2` FOREIGN KEY (`kode_barang`) REFERENCES `data_produk` (`kode_produk`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
