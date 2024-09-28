-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: inventariodb
-- ------------------------------------------------------
-- Server version	9.0.1

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `categorias`
--

DROP TABLE IF EXISTS `categorias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categorias` (
  `IdCategoria` int NOT NULL AUTO_INCREMENT,
  `Categoria` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`IdCategoria`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categorias`
--

LOCK TABLES `categorias` WRITE;
/*!40000 ALTER TABLE `categorias` DISABLE KEYS */;
INSERT INTO `categorias` VALUES (1,'Lácteos'),(2,'Carnes'),(3,'Frutas'),(4,'Verduras'),(5,'Bebidas'),(6,'Panadería'),(7,'Dulces'),(8,'Pescados'),(9,'Cereales'),(10,'Snacks'),(11,'Legumbres'),(12,'Congelados'),(13,'Productos de limpieza'),(14,'Cuidado personal'),(15,'Electrónica'),(16,'Ropa'),(17,'Juguetes'),(18,'Hogar'),(19,'Ferretería'),(20,'Mascotas');
/*!40000 ALTER TABLE `categorias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clientes` (
  `IdCliente` int NOT NULL AUTO_INCREMENT,
  `DNI` int NOT NULL,
  `NombreCliente` varchar(100) NOT NULL,
  `Direccion` varchar(100) NOT NULL,
  `Telefono` varchar(15) NOT NULL,
  `Correo` varchar(45) NOT NULL,
  PRIMARY KEY (`IdCliente`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientes`
--

LOCK TABLES `clientes` WRITE;
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` VALUES (1,30123456,'Juan Pérez','Calle Falsa 123, Buenos Aires','1122334455','juan.perez@email.com'),(2,32123456,'María López','Avenida Siempre Viva 742, Córdoba','1167891234','maria.lopez@email.com'),(3,30123457,'Carlos García','Boulevard San Martín 456, Rosario','1145678912','carlos.garcia@email.com'),(4,32123457,'Ana Martínez','Ruta 40 Km 55, Mendoza','1176543219','ana.martinez@email.com'),(5,30123458,'Pedro González','Calle Libertad 987, La Plata','1187654320','pedro.gonzalez@email.com'),(6,32123458,'Laura Fernández','Avenida Rivadavia 321, Salta','1198765432','laura.fernandez@email.com'),(7,30123459,'Diego Ramírez','Calle 9 de Julio 567, Tucumán','1123456789','diego.ramirez@email.com'),(8,32123459,'Lucía Torres','Avenida Belgrano 123, Mar del Plata','1134567890','lucia.torres@email.com'),(9,30123460,'Miguel Álvarez','Calle Corrientes 890, San Juan','1154321876','miguel.alvarez@email.com'),(10,32123460,'Cecilia Gutiérrez','Calle Mendoza 234, Neuquén','1122143654','cecilia.gutierrez@email.com'),(14,36863756,'jonathan','siempreviva','15948762','jomino@gmail.com');
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empaquetado`
--

DROP TABLE IF EXISTS `empaquetado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empaquetado` (
  `Idempaquetado` int NOT NULL AUTO_INCREMENT,
  `Empaquetado` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`Idempaquetado`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empaquetado`
--

LOCK TABLES `empaquetado` WRITE;
/*!40000 ALTER TABLE `empaquetado` DISABLE KEYS */;
INSERT INTO `empaquetado` VALUES (1,'Caja'),(2,'Botella'),(3,'Bolsa'),(4,'Lata'),(5,'Pote'),(6,'Envase plástico'),(7,'Frasco de vidrio'),(8,'Tetra Pack'),(9,'Sobre'),(10,'Bidón'),(11,'Blister'),(12,'Bandeja'),(13,'Paquete'),(14,'Estuche'),(15,'Jarra'),(16,'Tubo'),(17,'Balde'),(18,'Sachet'),(19,'Bolsa hermética'),(20,'Pack individual');
/*!40000 ALTER TABLE `empaquetado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `marca`
--

DROP TABLE IF EXISTS `marca`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `marca` (
  `IdMarca` int NOT NULL AUTO_INCREMENT,
  `Marca` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`IdMarca`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `marca`
--

LOCK TABLES `marca` WRITE;
/*!40000 ALTER TABLE `marca` DISABLE KEYS */;
INSERT INTO `marca` VALUES (1,'Coca-Cola'),(2,'Pepsi'),(3,'Danone'),(4,'Nestlé'),(5,'Huggies'),(6,'Colgate'),(7,'Samsung'),(8,'Nike'),(9,'LG'),(10,'Sony');
/*!40000 ALTER TABLE `marca` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productos`
--

DROP TABLE IF EXISTS `productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productos` (
  `IdProducto` int NOT NULL AUTO_INCREMENT,
  `Categoria` varchar(100) DEFAULT NULL,
  `NombreProducto` varchar(100) NOT NULL,
  `Marca` varchar(100) DEFAULT NULL,
  `Empaquetado` varchar(100) DEFAULT NULL,
  `Cantidad` int NOT NULL,
  `FechaVencimiento` date DEFAULT NULL,
  `Precio` int DEFAULT NULL,
  PRIMARY KEY (`IdProducto`)
) ENGINE=InnoDB AUTO_INCREMENT=77 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productos`
--

LOCK TABLES `productos` WRITE;
/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
INSERT INTO `productos` VALUES (1,'Lácteos','Leche Entera','La Serenísima','Botella',7,'2024-12-01',150),(2,'Lácteos','Yogur Natural','Sancor','Pote',20,'2024-11-10',100),(3,'Lácteos','Queso Crema','Ilolay','Envase plástico',15,'2024-10-15',250),(4,'Carnes','Carne de Res','Carnes Premium','Bandeja',28,'2024-09-20',1000),(5,'Carnes','Carne de Cerdo','Carnes Premium','Bandeja',22,'2024-11-05',1200),(6,'Carnes','Pollo','Frigorífico El Pato','Bolsa',40,'2024-10-01',800),(7,'Pescados','Salmón','PescaMar','Bolsa hermética',10,'2024-12-20',2500),(8,'Pescados','Atún en Lata','PescaMar','Lata',49,'2025-01-01',300),(9,'Pescados','Merluza','PescaMar','Bandeja',14,'2024-10-25',850),(10,'Frutas','Manzana','Frutamanía','Bolsa',100,'2024-11-15',120),(11,'Frutas','Banana','Frutamanía','Bolsa',80,'2024-09-30',90),(12,'Frutas','Pera','Frutamanía','Bolsa',60,'2024-10-10',100),(13,'Verduras','Lechuga','Verdulería Verde','Bolsa',150,'2024-09-25',50),(14,'Verduras','Zanahoria','Verdulería Verde','Bolsa',120,'2024-10-01',60),(15,'Verduras','Tomate','Verdulería Verde','Bolsa',80,'2024-09-20',70),(16,'Bebidas','Agua Mineral','Coca-Cola','Botella',200,'2025-01-05',80),(17,'Bebidas','Jugo de Naranja','Coca-Cola','Botella',180,'2024-12-10',120),(18,'Bebidas','Coca-Cola','Coca-Cola','Botella',100,'2024-11-15',150),(19,'Bebidas','Pepsi','Pepsi','Botella',120,'2024-12-25',140),(20,'Snacks','Papas Fritas','Lays','Bolsa',50,'2025-02-15',70),(21,'Snacks','Cheetos','Lays','Bolsa',40,'2025-03-01',60),(22,'Snacks','Doritos','Lays','Bolsa',45,'2025-04-01',80),(23,'Panadería','Pan Integral','Bimbo','Bolsa',60,'2024-09-25',90),(24,'Panadería','Medialunas','Panadería La Nueva','Bolsa',30,'2024-10-05',120),(25,'Panadería','Torta','Panadería La Nueva','Caja',10,'2024-12-01',400),(26,'Dulces','Chocolate','Arcor','Caja',80,'2025-01-20',150),(27,'Dulces','Alfajor','Havanna','Envase plástico',120,'2025-02-10',180),(28,'Dulces','Caramelos','Arcor','Bolsa',200,'2025-03-15',50),(29,'Cereales','Avena','Quaker','Paquete',100,'2025-01-01',130),(30,'Cereales','Granola','Quaker','Paquete',80,'2024-12-20',110),(31,'Cereales','Cereal Integral','Nestlé','Caja',60,'2025-03-10',140),(32,'Legumbres','Lentejas','Legumbres del Norte','Bolsa',150,'2025-04-01',90),(33,'Legumbres','Porotos','Legumbres del Norte','Bolsa',120,'2025-05-15',100),(34,'Legumbres','Garbanzos','Legumbres del Norte','Bolsa',130,'2025-06-01',110),(35,'Congelados','Helado de Vainilla','Grido','Envase plástico',40,'2024-12-30',300),(36,'Congelados','Pizza Congelada','Grido','Caja',50,'2025-01-10',450),(37,'Congelados','Hamburguesas Congeladas','Paty','Caja',70,'2025-02-01',350),(38,'Productos de limpieza','Detergente','Ala','Botella',80,'2025-03-15',150),(39,'Productos de limpieza','Lavandina','Ayudín','Botella',100,'2025-05-01',100),(40,'Productos de limpieza','Jabón en Polvo','Ala','Bolsa',120,'2025-06-10',200),(41,'Cuidado personal','Shampoo','Sedal','Botella',60,'2025-07-01',300),(42,'Cuidado personal','Jabón de Tocador','Dove','Caja',150,'2025-08-15',90),(43,'Cuidado personal','Pasta Dental','Colgate','Tubo',100,'2025-09-01',120),(44,'Electrónica','Celular Samsung','Samsung','Caja',30,NULL,50000),(45,'Electrónica','Televisor LG','LG','Caja',20,NULL,40000),(46,'Electrónica','Aire Acondicionado','Philips','Caja',10,NULL,30000),(47,'Ropa','Camisa','Nike','Paquete',50,NULL,2500),(48,'Ropa','Pantalones','Adidas','Paquete',40,NULL,3000),(49,'Ropa','Zapatillas','Nike','Caja',30,NULL,4000),(50,'Juguetes','Muñeca','Hasbro','Caja',20,NULL,1500),(51,'Juguetes','Auto de Juguete','Mattel','Caja',15,NULL,1200),(52,'Juguetes','Juego de Mesa','Hasbro','Caja',25,NULL,1800),(53,'Hogar','Mesa','Muebles ARG','Caja',10,NULL,10000),(54,'Hogar','Silla','Muebles ARG','Caja',30,NULL,2500),(55,'Hogar','Lámpara','Philips','Caja',40,NULL,2000),(56,'Ferretería','Martillo','DeWalt','Blister',50,NULL,600),(57,'Ferretería','Destornillador','Bosch','Blister',80,NULL,500),(58,'Ferretería','Taladro','Bosch','Caja',15,NULL,10000),(59,'Mascotas','Comida para Perros','Royal Canin','Bolsa',200,'2025-10-01',1000),(60,'Mascotas','Comida para Gatos','Whiskas','Bolsa',150,'2025-09-15',900),(61,'Mascotas','Arena para Gatos','Cat\'s Best','Bolsa',100,'2025-11-01',500),(62,'Electrodomésticos','Heladera','Samsung','Caja',10,NULL,60000),(63,'Electrodomésticos','Lavarropas','LG','Caja',15,NULL,45000),(64,'Electrodomésticos','Microondas','Samsung','Caja',25,NULL,15000),(65,'Bebidas','Agua Saborizada','Pepsi','Botella',150,'2025-03-01',100),(66,'Cereales','Corn Flakes','Kellogg\'s','Caja',70,'2025-04-15',140),(67,'Dulces','Galletas','Bagley','Bolsa',120,'2025-05-10',80),(68,'Cuidado personal','Desodorante','Axe','Spray',90,'2025-06-20',250),(69,'Snacks','Palitos Salados','Bimbo','Bolsa',60,'2025-07-05',70),(70,'Panadería','Galletas de Salvado','Bimbo','Bolsa',80,'2025-08-01',90),(71,'Legumbres','Arvejas','Legumbres del Norte','Bolsa',100,'2025-08-15',110),(72,'Carnes','Chorizo','Carnes Premium','Bandeja',20,'2024-09-10',1500),(73,'Congelados','Empanadas Congeladas','La Salteña','Bolsa',60,'2025-01-01',350),(74,'Productos de limpieza','Suavizante','Ala','Botella',100,'2025-04-01',170),(75,'Ropa','Campera','Puma','Caja',20,NULL,4500),(76,'Electrónica','Monitor LED','Samsung','Caja',25,NULL,25000);
/*!40000 ALTER TABLE `productos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proveedores`
--

DROP TABLE IF EXISTS `proveedores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `proveedores` (
  `IdProveedor` int NOT NULL AUTO_INCREMENT,
  `NombreProveedor` varchar(100) NOT NULL,
  `Direccion` varchar(100) NOT NULL,
  `Telefono` varchar(100) NOT NULL,
  `Correo` varchar(100) NOT NULL,
  PRIMARY KEY (`IdProveedor`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedores`
--

LOCK TABLES `proveedores` WRITE;
/*!40000 ALTER TABLE `proveedores` DISABLE KEYS */;
INSERT INTO `proveedores` VALUES (1,'Distribuidora Alimentos SA','Calle 123, Buenos Aires','1122334455','contacto@distribuidoraalimentos.com'),(2,'Proveedores del Norte SRL','Avenida Siempre Viva 742, Córdoba','1167894561','ventas@proveedoresnorte.com'),(3,'Comercializadora del Sur','Ruta 40 Km 55, Mendoza','1145678912','info@comerciodelsur.com'),(4,'ProveedorElect SA','Parque Industrial 45, Rosario','1176543219','elect@proveedorelect.com'),(5,'Frutas y Verduras del Campo','Calle Rural 567, Tucumán','1187654320','frutas@delcampo.com'),(6,'TechnoMarket','Av. Tecnológica 2020, Buenos Aires','1198765432','soporte@technomarket.com'),(7,'Papelera Argentina','Calle Industrial 345, La Plata','1123456789','ventas@papeleraargentina.com'),(8,'Lácteos del Valle','Ruta Provincial 30, San Luis','1165439871','contacto@lacteosdelvalle.com'),(9,'Carnes Premium','Avenida Carnes 2000, Salta','1145672341','ventas@carnespremium.com'),(10,'Embalajes Express','Avenida Embalajes 456, Mar del Plata','1134567890','contacto@embalajesexpress.com');
/*!40000 ALTER TABLE `proveedores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `IdUsuario` int NOT NULL AUTO_INCREMENT,
  `Username` varchar(100) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Categoria` varchar(45) NOT NULL,
  `Estado` tinyint(1) NOT NULL DEFAULT '1',
  `FechaCreacion` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`IdUsuario`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,'ahernandez','8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92','ahernandez@example.com','Administrador',1,'2024-09-27 17:01:13'),(2,'bmartinez','477e2d13152129e72c4a47a5abed06ce422daff2ca0e99d33bc527477effee34','bmartinez@example.com','Usuario',1,'2024-09-27 17:01:13'),(3,'csanchez','8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92','csanchez@example.com','Usuario',1,'2024-09-27 17:01:13'),(4,'djimenez','8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92','djimenez@example.com','Usuario',1,'2024-09-27 17:01:13'),(5,'egarcia','8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92','egarcia@example.com','Administrador',1,'2024-09-27 17:01:13'),(6,'fserrano','8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92','fserrano@example.com','Usuario',1,'2024-09-27 17:01:13'),(7,'glopez','8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92','glopez@example.com','Usuario',1,'2024-09-27 17:01:13'),(8,'hsilva','8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92','hsilva@example.com','Usuario',1,'2024-09-27 17:01:13'),(9,'ibustos','8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92','ibustos@example.com','Usuario',1,'2024-09-27 17:01:13'),(10,'jcortes','8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92','jcortes@example.com','Administrador',1,'2024-09-27 17:01:13'),(11,'jomino','ef797c8118f02dfb649607dd5d3f8c7623048c9c063d532cc95c5ed7a898a64f','jomino@gmail.com','Administrador',1,'2024-09-28 15:19:05');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-09-28 19:38:34
