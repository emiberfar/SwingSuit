-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         5.7.16-log - MySQL Community Server (GPL)
-- SO del servidor:              Win64
-- HeidiSQL Versión:             9.4.0.5125
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Volcando estructura de base de datos para banador
CREATE DATABASE IF NOT EXISTS `banador` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `banador`;

-- Volcando estructura para tabla banador.cliente
CREATE TABLE IF NOT EXISTS `cliente` (
  `Id` int(11) NOT NULL,
  `Nombre` varchar(50) DEFAULT NULL,
  `Apellido` varchar(50) DEFAULT NULL,
  `DNI` varchar(50) DEFAULT NULL,
  `Direccion` varchar(50) DEFAULT NULL,
  `Telefono` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla banador.cliente: ~5 rows (aproximadamente)
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` (`Id`, `Nombre`, `Apellido`, `DNI`, `Direccion`, `Telefono`) VALUES
	(1, 'Alvaro', 'Moreno', '45698745S', 'c\\Alvaricoque', '963258741'),
	(2, 'Blanca', 'Alvarez', '45212365F', 'C\\Alcachofa', '789654123'),
	(3, 'Emilio', 'Bernal', '41236587Q', 'C\\Colorin', '987652314'),
	(4, 'Carlos', 'Prieto', '41785236M', 'C\\Colchon', '965874123'),
	(5, 'Angel', 'Arias', '45632178W', 'C\\Gaes', '652314789');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;

-- Volcando estructura para tabla banador.producto
CREATE TABLE IF NOT EXISTS `producto` (
  `Id` int(11) NOT NULL,
  `Marca` varchar(50) DEFAULT NULL,
  `Tipo` varchar(50) DEFAULT NULL,
  `Talla` varchar(50) DEFAULT NULL,
  `StockActual` int(11) DEFAULT NULL,
  `StockMminimo` int(11) DEFAULT NULL,
  `PVP` double DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla banador.producto: ~12 rows (aproximadamente)
/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
INSERT INTO `producto` (`Id`, `Marca`, `Tipo`, `Talla`, `StockActual`, `StockMminimo`, `PVP`) VALUES
	(1, 'Quicksilver', 'Bermudas', 'S', 45, 10, 45.5),
	(2, 'Quicksilver', 'Bermudas', 'M', 80, 30, 45.5),
	(3, 'Quicksilver', 'Bermudas', 'L', 78, 3, 45.5),
	(4, 'Quicksilver', 'Bermudas', 'XL', 65, 11, 45.5),
	(5, 'Billabong', 'Short', 'S', 90, 30, 19.9),
	(6, 'Billabong', 'Short', 'M', 96, 10, 19.9),
	(7, 'Billabong', 'Short', 'L', 31, 2, 19.9),
	(8, 'Billabong', 'Short', 'XL', 200, 100, 19.9),
	(9, 'Versace', 'Slip', 'S', 10, 1, 400.8),
	(10, 'Versace', 'Slip', 'M', 71, 20, 400.8),
	(11, 'Versace', 'Slip', 'L', 95, 20, 400.8),
	(12, 'Versace', 'Slip', 'XL', 100, 50, 400.8);
/*!40000 ALTER TABLE `producto` ENABLE KEYS */;

-- Volcando estructura para tabla banador.venta
CREATE TABLE IF NOT EXISTS `venta` (
  `IdVenta` int(11) NOT NULL,
  `IdProducto` int(11) DEFAULT NULL,
  `IdCliente` int(11) DEFAULT NULL,
  `Cantidad` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdVenta`),
  KEY `IdProducto` (`IdProducto`),
  KEY `IdCliente` (`IdCliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla banador.venta: ~5 rows (aproximadamente)
/*!40000 ALTER TABLE `venta` DISABLE KEYS */;
INSERT INTO `venta` (`IdVenta`, `IdProducto`, `IdCliente`, `Cantidad`) VALUES
	(1, 12, 2, 5),
	(2, 5, 1, 9),
	(3, 9, 3, 4),
	(4, 1, 4, 10),
	(5, 6, 5, 8);
/*!40000 ALTER TABLE `venta` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
