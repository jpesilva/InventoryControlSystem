-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 09-Set-2019 às 03:04
-- Versão do servidor: 10.4.6-MariaDB
-- versão do PHP: 7.3.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `excellentess`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `dtoclients`
--

CREATE TABLE `dtoclients` (
  `REGISTER` int(11) NOT NULL,
  `FULL_NAME` varchar(255) NOT NULL,
  `AGE` int(3) NOT NULL,
  `RG_CPF` varchar(255) NOT NULL,
  `TELEPHONE` int(20) DEFAULT NULL,
  `CELL_PHONE` int(20) DEFAULT NULL,
  `EMAIL` varchar(255) DEFAULT NULL,
  `ADDRESS` varchar(255) NOT NULL,
  `NEIGHBORHOOD` varchar(255) NOT NULL,
  `CITY` varchar(255) NOT NULL,
  `LOAN_DATE` varchar(10) NOT NULL,
  `ID_PATRIMONY` int(20) DEFAULT NULL,
  `RETURN_DATE` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `dtoitems`
--

CREATE TABLE `dtoitems` (
  `QTD` int(3) DEFAULT NULL,
  `ID_PATRIMONY` int(20) NOT NULL,
  `NAME_ITEM` varchar(255) NOT NULL,
  `LOCATION` varchar(255) DEFAULT NULL,
  `INVOICE` varchar(20) DEFAULT NULL,
  `DATE_ACQUISITION` varchar(10) DEFAULT NULL,
  `PROVIDER` varchar(255) DEFAULT NULL,
  `VALUE` varchar(255) NOT NULL,
  `DEGREE_DEPRECIATION` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `dtoloans`
--

CREATE TABLE `dtoloans` (
  `REGISTER_CLIENT` int(6) NOT NULL,
  `FULL_NAME` varchar(255) NOT NULL,
  `ID_PATRIMONY` int(20) NOT NULL,
  `NAME_ITEM` varchar(255) NOT NULL,
  `VALUE` varchar(255) NOT NULL,
  `DEGREE_DEPRECIATION` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `dtousers`
--

CREATE TABLE `dtousers` (
  `ID` int(1) NOT NULL,
  `FULL_NAME` varchar(255) NOT NULL,
  `FUNCTIONN` varchar(255) NOT NULL,
  `LOGIN` varchar(255) NOT NULL,
  `PASSWORDD` varchar(255) NOT NULL,
  `EMAIL` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `dtoclients`
--
ALTER TABLE `dtoclients`
  ADD PRIMARY KEY (`REGISTER`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `dtoclients`
--
ALTER TABLE `dtoclients`
  MODIFY `REGISTER` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
