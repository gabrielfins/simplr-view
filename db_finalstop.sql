-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: 02-Out-2019 às 18:15
-- Versão do servidor: 5.7.26
-- versão do PHP: 7.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_finalstop`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `cliente`
--

DROP TABLE IF EXISTS `cliente`;
CREATE TABLE IF NOT EXISTS `cliente` (
  `id_cliente` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `cpf` varchar(20) DEFAULT NULL,
  `cnpj` varchar(30) DEFAULT NULL,
  `telefone` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `cep` varchar(20) NOT NULL,
  `estado` varchar(50) NOT NULL,
  `cidade` varchar(20) NOT NULL,
  `endereco` varchar(50) NOT NULL,
  PRIMARY KEY (`id_cliente`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `cliente`
--

INSERT INTO `cliente` (`id_cliente`, `nome`, `cpf`, `cnpj`, `telefone`, `email`, `cep`, `estado`, `cidade`, `endereco`) VALUES
(1, 'asdasd', '342,342,342-34', '42,342,342/3424-23', '(23) 42342-3423', 'asdadsad', '34242-342', 'MG', 'dfasda', 'dfdsfsdf');

-- --------------------------------------------------------

--
-- Estrutura da tabela `fornecedor`
--

DROP TABLE IF EXISTS `fornecedor`;
CREATE TABLE IF NOT EXISTS `fornecedor` (
  `id_fornecedor` int(11) NOT NULL AUTO_INCREMENT,
  `nome_fantasia` varchar(50) NOT NULL,
  `nome_contato` varchar(50) NOT NULL,
  `razao_social` varchar(50) NOT NULL,
  `cnpj` varchar(20) NOT NULL,
  `cep` varchar(20) NOT NULL,
  `estado` varchar(20) NOT NULL,
  `cidade` varchar(20) NOT NULL,
  `endereco` varchar(50) NOT NULL,
  `telefone_1` varchar(20) NOT NULL,
  `telefone_2` varchar(20) NOT NULL,
  `email` varchar(50) NOT NULL,
  PRIMARY KEY (`id_fornecedor`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `fornecedor`
--

INSERT INTO `fornecedor` (`id_fornecedor`, `nome_fantasia`, `nome_contato`, `razao_social`, `cnpj`, `cep`, `estado`, `cidade`, `endereco`, `telefone_1`, `telefone_2`, `email`) VALUES
(1, 'aosidfbhasduklh', 'KLSNFVJKLSDNF', 'jksdfhtiolshdfgiolwehj', '90,458,693/4856-39', '34902-389', 'RJ', 'ojfsçklfjkolwsd', 'klsdjfgkopçsdejfg', '(34) 9058-3489', '(90) 82345-9034', 'opwsjdfgioçsdjfg');

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionario`
--

DROP TABLE IF EXISTS `funcionario`;
CREATE TABLE IF NOT EXISTS `funcionario` (
  `id_funcionario` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `usuario` varchar(50) NOT NULL,
  `senha` varchar(50) NOT NULL,
  `cpf` varchar(30) NOT NULL,
  `telefone` varchar(30) NOT NULL,
  `email` varchar(50) NOT NULL,
  `cargo` varchar(20) NOT NULL,
  `salario` varchar(20) NOT NULL,
  `data_admissao` varchar(20) NOT NULL,
  `nivel` int(11) NOT NULL,
  PRIMARY KEY (`id_funcionario`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `funcionario`
--

INSERT INTO `funcionario` (`id_funcionario`, `nome`, `usuario`, `senha`, `cpf`, `telefone`, `email`, `cargo`, `salario`, `data_admissao`, `nivel`) VALUES
(1, 'Carlos Almeida', 'adm', 'adm', '12345678909', '11999990000', 'carlos@example.com', 'Gerente de Sistemas', '5500', '15/03/2022', 0),
(2, 'Teste', '', '', '', '', '', '', '', '', 0);

-- --------------------------------------------------------

--
-- Estrutura da tabela `produto`
--

DROP TABLE IF EXISTS `produto`;
CREATE TABLE IF NOT EXISTS `produto` (
  `id_produto` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `tipo` varchar(50) NOT NULL,
  `fornecedor` varchar(50) NOT NULL,
  `preco_unitario` varchar(50) NOT NULL,
  `preco_venda` varchar(50) NOT NULL,
  `quantidade` varchar(50) NOT NULL,
  `descricao` varchar(50) NOT NULL,
  `numero_serie` int(20) NOT NULL,
  PRIMARY KEY (`id_produto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
