-- MySQL dump 10.13  Distrib 8.0.30, for Win64 (x86_64)
--
-- Host: colchoneria.mysql.database.azure.com    Database: colchoneria
-- ------------------------------------------------------
-- Server version	8.0.28

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
-- Table structure for table `tbl_aplicaciones`
--

DROP TABLE IF EXISTS `tbl_aplicaciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_aplicaciones` (
  `pk_id_aplicacion` int NOT NULL AUTO_INCREMENT,
  `nombre_aplicacion` varchar(50) NOT NULL,
  `descripcion_aplicacion` varchar(150) NOT NULL,
  `estado_aplicacion` tinyint DEFAULT '0',
  PRIMARY KEY (`pk_id_aplicacion`)
) ENGINE=InnoDB AUTO_INCREMENT=8001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_aplicaciones`
--

LOCK TABLES `tbl_aplicaciones` WRITE;
/*!40000 ALTER TABLE `tbl_aplicaciones` DISABLE KEYS */;
INSERT INTO `tbl_aplicaciones` VALUES (1000,'MDI','PARA SEGURIDAD',1),(2000,'MDI','PARA LOGISTICA',1),(3000,'MDI','PARA COMPRAS',1),(4000,'MDI','PARA VENTAS',1),(5000,'MDI','PARA',1),(5001,'Mant. Empleados','PARA NOMINAS',1),(5002,'Mant. Contratos','PARA NOMINAS',0),(6000,'MDI','PARA NOMINAS',1),(7000,'MDI','PARA',1),(8000,'MDI','PARA',1);
/*!40000 ALTER TABLE `tbl_aplicaciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_asignacionesperfilsusuario`
--

DROP TABLE IF EXISTS `tbl_asignacionesperfilsusuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_asignacionesperfilsusuario` (
  `fk_id_usuario` int NOT NULL,
  `fk_id_perfil` int NOT NULL,
  PRIMARY KEY (`fk_id_usuario`,`fk_id_perfil`),
  KEY `fk_id_perfil` (`fk_id_perfil`),
  CONSTRAINT `tbl_asignacionesperfilsusuario_ibfk_1` FOREIGN KEY (`fk_id_usuario`) REFERENCES `tbl_usuarios` (`pk_id_usuario`),
  CONSTRAINT `tbl_asignacionesperfilsusuario_ibfk_2` FOREIGN KEY (`fk_id_perfil`) REFERENCES `tbl_perfiles` (`pk_id_perfil`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_asignacionesperfilsusuario`
--

LOCK TABLES `tbl_asignacionesperfilsusuario` WRITE;
/*!40000 ALTER TABLE `tbl_asignacionesperfilsusuario` DISABLE KEYS */;
INSERT INTO `tbl_asignacionesperfilsusuario` VALUES (1,1);
/*!40000 ALTER TABLE `tbl_asignacionesperfilsusuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_asignacionmoduloaplicacion`
--

DROP TABLE IF EXISTS `tbl_asignacionmoduloaplicacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_asignacionmoduloaplicacion` (
  `fk_id_modulos` int NOT NULL,
  `fk_id_aplicacion` int NOT NULL,
  PRIMARY KEY (`fk_id_modulos`,`fk_id_aplicacion`),
  KEY `fk_id_aplicacion` (`fk_id_aplicacion`),
  CONSTRAINT `tbl_asignacionmoduloaplicacion_ibfk_1` FOREIGN KEY (`fk_id_modulos`) REFERENCES `tbl_modulos` (`pk_id_modulos`),
  CONSTRAINT `tbl_asignacionmoduloaplicacion_ibfk_2` FOREIGN KEY (`fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`pk_id_aplicacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_asignacionmoduloaplicacion`
--

LOCK TABLES `tbl_asignacionmoduloaplicacion` WRITE;
/*!40000 ALTER TABLE `tbl_asignacionmoduloaplicacion` DISABLE KEYS */;
INSERT INTO `tbl_asignacionmoduloaplicacion` VALUES (1000,1000),(2000,2000),(3000,3000),(4000,4000),(5000,5000),(6000,5001),(6000,5002),(6000,6000);
/*!40000 ALTER TABLE `tbl_asignacionmoduloaplicacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_bitacoradeeventos`
--

DROP TABLE IF EXISTS `tbl_bitacoradeeventos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_bitacoradeeventos` (
  `pk_id_bitacora` int NOT NULL AUTO_INCREMENT,
  `fk_id_usuario` int NOT NULL,
  `fk_id_aplicacion` int NOT NULL,
  `fecha_bitacora` date NOT NULL,
  `hora_bitacora` time NOT NULL,
  `host_bitacora` varchar(45) NOT NULL,
  `ip_bitacora` varchar(100) NOT NULL,
  `accion_bitacora` varchar(10) NOT NULL,
  PRIMARY KEY (`pk_id_bitacora`),
  KEY `fk_id_usuario` (`fk_id_usuario`),
  KEY `fk_id_aplicacion` (`fk_id_aplicacion`),
  CONSTRAINT `tbl_bitacoradeeventos_ibfk_1` FOREIGN KEY (`fk_id_usuario`) REFERENCES `tbl_usuarios` (`pk_id_usuario`),
  CONSTRAINT `tbl_bitacoradeeventos_ibfk_2` FOREIGN KEY (`fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`pk_id_aplicacion`)
) ENGINE=InnoDB AUTO_INCREMENT=92 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_bitacoradeeventos`
--

LOCK TABLES `tbl_bitacoradeeventos` WRITE;
/*!40000 ALTER TABLE `tbl_bitacoradeeventos` DISABLE KEYS */;
INSERT INTO `tbl_bitacoradeeventos` VALUES (1,1,1000,'2022-10-06','07:39:53','DESKTOP-T5OJTBO','2800:98:1112:af3::9','login'),(2,1,2000,'2022-10-06','07:40:01','DESKTOP-T5OJTBO','2800:98:1112:af3::9','login'),(3,1,3000,'2022-10-06','07:40:07','DESKTOP-T5OJTBO','2800:98:1112:af3::9','login'),(4,1,4000,'2022-10-06','07:40:12','DESKTOP-T5OJTBO','2800:98:1112:af3::9','login'),(5,1,5000,'2022-10-06','07:40:18','DESKTOP-T5OJTBO','2800:98:1112:af3::9','login'),(6,1,1000,'2022-10-06','07:45:58','DESKTOP-T5OJTBO','2800:98:1112:af3::9','login'),(7,1,2000,'2022-10-06','07:46:04','DESKTOP-T5OJTBO','2800:98:1112:af3::9','login'),(8,1,3000,'2022-10-06','07:46:09','DESKTOP-T5OJTBO','2800:98:1112:af3::9','login'),(9,1,4000,'2022-10-06','07:46:15','DESKTOP-T5OJTBO','2800:98:1112:af3::9','login'),(10,1,5000,'2022-10-06','07:46:21','DESKTOP-T5OJTBO','2800:98:1112:af3::9','login'),(11,1,1000,'2022-10-06','07:47:43','DESKTOP-T5OJTBO','2800:98:1112:af3::9','login'),(12,1,2000,'2022-10-06','07:47:49','DESKTOP-T5OJTBO','2800:98:1112:af3::9','login'),(13,1,3000,'2022-10-06','07:47:54','DESKTOP-T5OJTBO','2800:98:1112:af3::9','login'),(14,1,4000,'2022-10-06','07:48:00','DESKTOP-T5OJTBO','2800:98:1112:af3::9','login'),(15,1,5000,'2022-10-06','07:48:05','DESKTOP-T5OJTBO','2800:98:1112:af3::9','login'),(16,1,1000,'2022-10-06','10:39:49','DESKTOP-8O756PG','192.168.1.7','login'),(17,1,1000,'2022-10-06','10:54:59','DESKTOP-8O756PG','192.168.1.7','login'),(18,1,1000,'2022-10-06','10:57:36','DESKTOP-8O756PG','192.168.1.7','login'),(19,1,1000,'2022-10-06','10:58:40','DESKTOP-8O756PG','192.168.1.7','login'),(20,1,1000,'2022-10-06','11:00:18','DESKTOP-8O756PG','192.168.1.7','login'),(21,1,1000,'2022-10-06','11:03:59','DESKTOP-8O756PG','192.168.1.7','login'),(22,1,1000,'2022-10-06','11:05:02','DESKTOP-8O756PG','192.168.1.7','login'),(23,1,1000,'2022-10-06','11:07:31','DESKTOP-8O756PG','192.168.1.7','login'),(24,1,1000,'2022-10-06','11:09:59','DESKTOP-8O756PG','192.168.1.7','login'),(25,1,1000,'2022-10-06','11:12:43','DESKTOP-8O756PG','192.168.1.7','login'),(26,1,1000,'2022-10-06','11:14:10','DESKTOP-8O756PG','192.168.1.7','login'),(27,1,1000,'2022-10-06','11:16:40','DESKTOP-8O756PG','192.168.1.7','login'),(28,1,1000,'2022-10-06','11:38:30','DESKTOP-8O756PG','192.168.1.7','login'),(29,1,1000,'2022-10-06','11:43:48','DESKTOP-8O756PG','192.168.1.7','login'),(30,1,1000,'2022-10-06','11:53:45','JARVIS','2800:98:1207:d26a:9cac:ff7a:6e3b:e6e5','login'),(31,1,2000,'2022-10-06','11:55:09','JARVIS','2800:98:1207:d26a:9cac:ff7a:6e3b:e6e5','login'),(32,1,3000,'2022-10-06','11:55:58','JARVIS','2800:98:1207:d26a:9cac:ff7a:6e3b:e6e5','login'),(33,1,4000,'2022-10-06','11:56:32','JARVIS','2800:98:1207:d26a:9cac:ff7a:6e3b:e6e5','login'),(34,1,5000,'2022-10-06','11:56:44','JARVIS','2800:98:1207:d26a:9cac:ff7a:6e3b:e6e5','login'),(35,1,1000,'2022-10-06','14:54:09','DESKTOP-8O756PG','192.168.1.7','login'),(36,1,1000,'2022-10-06','14:55:49','DESKTOP-8O756PG','192.168.1.7','login'),(37,1,1000,'2022-10-06','14:57:46','DESKTOP-8O756PG','192.168.1.7','login'),(38,1,1000,'2022-10-06','15:27:43','DESKTOP-8O756PG','192.168.1.7','login'),(39,1,1000,'2022-10-06','15:27:59','DESKTOP-8O756PG','192.168.1.7','Guardar'),(40,1,1000,'2022-10-06','15:40:41','DESKTOP-8O756PG','192.168.1.7','login'),(41,1,1000,'2022-10-06','15:42:20','DESKTOP-8O756PG','192.168.1.7','login'),(42,1,1000,'2022-10-06','15:42:28','DESKTOP-8O756PG','192.168.1.7','Eliminar'),(43,1,1000,'2022-10-06','15:42:52','DESKTOP-8O756PG','192.168.1.7','Modificar'),(44,1,1000,'2022-10-06','15:49:09','DESKTOP-8O756PG','192.168.1.7','login'),(45,1,1000,'2022-10-06','15:49:16','DESKTOP-8O756PG','192.168.1.7','Consulta'),(46,1,1000,'2022-10-06','15:49:26','DESKTOP-8O756PG','192.168.1.7','Reportes'),(47,1,1000,'2022-10-06','16:17:58','DESKTOP-8O756PG','192.168.1.7','login'),(48,1,1000,'2022-10-06','16:20:38','DESKTOP-8O756PG','192.168.1.7','login'),(49,1,1000,'2022-10-06','16:21:21','DESKTOP-8O756PG','192.168.1.7','login'),(50,1,1000,'2022-10-06','16:22:07','DESKTOP-8O756PG','192.168.1.7','login'),(51,1,1000,'2022-10-06','16:37:41','DESKTOP-8O756PG','192.168.1.7','login'),(52,1,1000,'2022-10-06','16:38:58','DESKTOP-8O756PG','192.168.1.7','login'),(53,1,1000,'2022-10-06','16:42:55','DESKTOP-8O756PG','192.168.1.7','login'),(54,1,1000,'2022-10-06','16:45:11','DESKTOP-8O756PG','192.168.1.7','login'),(55,1,1000,'2022-10-06','16:48:26','DESKTOP-8O756PG','192.168.1.7','login'),(56,1,1000,'2022-10-06','16:53:30','DESKTOP-8O756PG','192.168.1.7','login'),(57,1,1000,'2022-10-06','16:56:18','DESKTOP-8O756PG','192.168.1.7','login'),(58,1,1000,'2022-10-06','19:46:32','LUISCA','172.20.10.2','login'),(59,1,2000,'2022-10-06','19:46:42','LUISCA','172.20.10.2','login'),(60,1,3000,'2022-10-06','19:46:53','LUISCA','172.20.10.2','login'),(61,1,4000,'2022-10-06','19:47:03','LUISCA','172.20.10.2','login'),(62,1,5000,'2022-10-06','19:47:14','LUISCA','172.20.10.2','login'),(63,1,6000,'2022-10-06','19:47:42','LUISCA','172.20.10.2','login'),(64,1,1000,'2022-10-06','19:48:40','LUISCA','172.20.10.2','login'),(65,1,2000,'2022-10-06','19:48:49','LUISCA','172.20.10.2','login'),(66,1,3000,'2022-10-06','19:48:59','LUISCA','172.20.10.2','login'),(67,1,4000,'2022-10-06','19:49:09','LUISCA','172.20.10.2','login'),(68,1,5000,'2022-10-06','19:49:19','LUISCA','172.20.10.2','login'),(69,1,6000,'2022-10-06','19:49:29','LUISCA','172.20.10.2','login'),(70,1,1000,'2022-10-07','12:03:12','DESKTOP-8O756PG','192.168.1.7','login'),(71,1,1000,'2022-10-07','12:04:33','DESKTOP-8O756PG','192.168.1.7','Eliminar'),(72,1,1000,'2022-10-07','12:41:31','DESKTOP-8O756PG','192.168.1.7','login'),(73,1,1000,'2022-10-07','17:04:13','DESKTOP-8O756PG','192.168.1.7','login'),(74,1,1000,'2022-10-08','14:50:38','DESKTOP-8O756PG','192.168.1.7','login'),(75,1,1000,'2022-10-08','14:53:24','DESKTOP-8O756PG','192.168.1.7','login'),(76,1,1000,'2022-10-08','14:55:51','DESKTOP-8O756PG','192.168.1.7','login'),(77,1,1000,'2022-10-08','14:58:56','DESKTOP-8O756PG','192.168.1.7','login'),(78,1,1000,'2022-10-08','15:57:32','DESKTOP-8O756PG','192.168.1.7','login'),(79,1,1000,'2022-10-08','16:00:36','DESKTOP-8O756PG','192.168.1.7','login'),(80,1,1000,'2022-10-08','16:02:02','DESKTOP-8O756PG','192.168.1.7','login'),(81,1,1000,'2022-10-08','18:11:39','DESKTOP-8O756PG','192.168.1.7','login'),(82,1,2000,'2022-10-08','18:11:52','DESKTOP-8O756PG','192.168.1.7','login'),(83,1,3000,'2022-10-08','18:12:08','DESKTOP-8O756PG','192.168.1.7','login'),(84,1,4000,'2022-10-08','18:12:23','DESKTOP-8O756PG','192.168.1.7','login'),(85,1,5000,'2022-10-08','18:12:39','DESKTOP-8O756PG','192.168.1.7','login'),(86,1,1000,'2022-10-08','18:15:17','DESKTOP-8O756PG','192.168.1.7','login'),(87,1,2000,'2022-10-08','18:15:25','DESKTOP-8O756PG','192.168.1.7','login'),(88,1,3000,'2022-10-08','18:15:36','DESKTOP-8O756PG','192.168.1.7','login'),(89,1,4000,'2022-10-08','18:15:45','DESKTOP-8O756PG','192.168.1.7','login'),(90,1,5000,'2022-10-08','18:15:56','DESKTOP-8O756PG','192.168.1.7','login'),(91,1,6000,'2022-10-08','18:16:04','DESKTOP-8O756PG','192.168.1.7','login');
/*!40000 ALTER TABLE `tbl_bitacoradeeventos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_modulos`
--

DROP TABLE IF EXISTS `tbl_modulos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_modulos` (
  `pk_id_modulos` int NOT NULL,
  `nombre_modulo` varchar(50) NOT NULL,
  `descripcion_modulo` varchar(150) NOT NULL,
  `estado_modulo` tinyint DEFAULT '0',
  PRIMARY KEY (`pk_id_modulos`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_modulos`
--

LOCK TABLES `tbl_modulos` WRITE;
/*!40000 ALTER TABLE `tbl_modulos` DISABLE KEYS */;
INSERT INTO `tbl_modulos` VALUES (1000,'Seguridad','Seguridad',1),(2000,'Logistica','Logistica',1),(3000,'Compras','Compras',1),(4000,'Ventas','Ventas',1),(5000,'Produccion','Produccion',1),(6000,'Nominas','Nominas',1),(7000,'Bancos','Bancos',1),(8000,'Contabilidad','Contabilidad',1);
/*!40000 ALTER TABLE `tbl_modulos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_perfiles`
--

DROP TABLE IF EXISTS `tbl_perfiles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_perfiles` (
  `pk_id_perfil` int NOT NULL AUTO_INCREMENT,
  `nombre_perfil` varchar(50) NOT NULL,
  `descripcion_perfil` varchar(150) NOT NULL,
  `estado_perfil` tinyint DEFAULT '0',
  PRIMARY KEY (`pk_id_perfil`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_perfiles`
--

LOCK TABLES `tbl_perfiles` WRITE;
/*!40000 ALTER TABLE `tbl_perfiles` DISABLE KEYS */;
INSERT INTO `tbl_perfiles` VALUES (1,'Administrador','contiene todos los permisos del programa',1);
/*!40000 ALTER TABLE `tbl_perfiles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_permisosaplicacionesusuario`
--

DROP TABLE IF EXISTS `tbl_permisosaplicacionesusuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_permisosaplicacionesusuario` (
  `fk_id_aplicacion` int NOT NULL,
  `fk_id_usuario` int NOT NULL,
  `guardar_permiso` tinyint(1) DEFAULT '0',
  `modificar_permiso` tinyint(1) DEFAULT '0',
  `eliminar_permiso` tinyint(1) DEFAULT '0',
  `buscar_permiso` tinyint(1) DEFAULT '0',
  `imprimir_permiso` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`fk_id_aplicacion`,`fk_id_usuario`),
  KEY `fk_id_usuario` (`fk_id_usuario`),
  CONSTRAINT `tbl_permisosaplicacionesusuario_ibfk_1` FOREIGN KEY (`fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`pk_id_aplicacion`),
  CONSTRAINT `tbl_permisosaplicacionesusuario_ibfk_2` FOREIGN KEY (`fk_id_usuario`) REFERENCES `tbl_usuarios` (`pk_id_usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_permisosaplicacionesusuario`
--

LOCK TABLES `tbl_permisosaplicacionesusuario` WRITE;
/*!40000 ALTER TABLE `tbl_permisosaplicacionesusuario` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_permisosaplicacionesusuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_permisosaplicacionperfil`
--

DROP TABLE IF EXISTS `tbl_permisosaplicacionperfil`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_permisosaplicacionperfil` (
  `fk_id_perfil` int NOT NULL,
  `fk_id_aplicacion` int NOT NULL,
  `guardar_permiso` tinyint(1) DEFAULT '0',
  `modificar_permiso` tinyint(1) DEFAULT '0',
  `eliminar_permiso` tinyint(1) DEFAULT '0',
  `buscar_permiso` tinyint(1) DEFAULT '0',
  `imprimir_permiso` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`fk_id_perfil`,`fk_id_aplicacion`),
  KEY `fk_id_aplicacion` (`fk_id_aplicacion`),
  CONSTRAINT `tbl_permisosaplicacionperfil_ibfk_1` FOREIGN KEY (`fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`pk_id_aplicacion`),
  CONSTRAINT `tbl_permisosaplicacionperfil_ibfk_2` FOREIGN KEY (`fk_id_perfil`) REFERENCES `tbl_perfiles` (`pk_id_perfil`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_permisosaplicacionperfil`
--

LOCK TABLES `tbl_permisosaplicacionperfil` WRITE;
/*!40000 ALTER TABLE `tbl_permisosaplicacionperfil` DISABLE KEYS */;
INSERT INTO `tbl_permisosaplicacionperfil` VALUES (1,1000,0,0,0,0,0),(1,2000,1,1,1,1,1),(1,3000,1,1,1,1,1),(1,4000,1,1,1,1,1),(1,5000,1,1,1,1,1),(1,5001,1,1,1,1,1),(1,5002,1,1,1,1,1),(1,6000,1,1,1,1,1);
/*!40000 ALTER TABLE `tbl_permisosaplicacionperfil` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_usuarios`
--

DROP TABLE IF EXISTS `tbl_usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_usuarios` (
  `pk_id_usuario` int NOT NULL AUTO_INCREMENT,
  `nombre_usuario` varchar(50) NOT NULL,
  `apellido_usuario` varchar(50) NOT NULL,
  `username_usuario` varchar(20) NOT NULL,
  `password_usuario` varchar(100) NOT NULL,
  `email_usuario` varchar(50) NOT NULL,
  `ultima_conexion_usuario` datetime DEFAULT NULL,
  `estado_usuario` tinyint NOT NULL DEFAULT '0',
  `pregunta` varchar(50) NOT NULL,
  `respuesta` varchar(50) NOT NULL,
  PRIMARY KEY (`pk_id_usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_usuarios`
--

LOCK TABLES `tbl_usuarios` WRITE;
/*!40000 ALTER TABLE `tbl_usuarios` DISABLE KEYS */;
INSERT INTO `tbl_usuarios` VALUES (1,'admin','admin','admin','HO0aGo4nM94=','esduardo@gmail.com','2022-07-02 21:00:48',1,'COLOR FAVORITO','ROJO');
/*!40000 ALTER TABLE `tbl_usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `vista_aplicacion_perfil`
--

DROP TABLE IF EXISTS `vista_aplicacion_perfil`;
/*!50001 DROP VIEW IF EXISTS `vista_aplicacion_perfil`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vista_aplicacion_perfil` AS SELECT 
 1 AS `ID`,
 1 AS `Perfil`,
 1 AS `Aplicacion`,
 1 AS `Guardar`,
 1 AS `Modificar`,
 1 AS `Eliminar`,
 1 AS `Buscar`,
 1 AS `Reporte`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vista_aplicacionusuario`
--

DROP TABLE IF EXISTS `vista_aplicacionusuario`;
/*!50001 DROP VIEW IF EXISTS `vista_aplicacionusuario`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vista_aplicacionusuario` AS SELECT 
 1 AS `Aplicacion`,
 1 AS `ID`,
 1 AS `Usuario`,
 1 AS `Guardar`,
 1 AS `Editar`,
 1 AS `Eliminar`,
 1 AS `Buscar`,
 1 AS `Reporte`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vista_modulo_aplicacion`
--

DROP TABLE IF EXISTS `vista_modulo_aplicacion`;
/*!50001 DROP VIEW IF EXISTS `vista_modulo_aplicacion`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vista_modulo_aplicacion` AS SELECT 
 1 AS `ID`,
 1 AS `Modulo`,
 1 AS `Aplicacion`,
 1 AS `Nombre`,
 1 AS `Descripcion`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vista_perfil_usuario`
--

DROP TABLE IF EXISTS `vista_perfil_usuario`;
/*!50001 DROP VIEW IF EXISTS `vista_perfil_usuario`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vista_perfil_usuario` AS SELECT 
 1 AS `ID`,
 1 AS `Usuario`,
 1 AS `nickName`,
 1 AS `perfil`,
 1 AS `Nombre`*/;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `vista_aplicacion_perfil`
--

/*!50001 DROP VIEW IF EXISTS `vista_aplicacion_perfil`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`administrador`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `vista_aplicacion_perfil` AS select `b`.`fk_id_perfil` AS `ID`,`a`.`nombre_perfil` AS `Perfil`,`b`.`fk_id_aplicacion` AS `Aplicacion`,`b`.`guardar_permiso` AS `Guardar`,`b`.`modificar_permiso` AS `Modificar`,`b`.`eliminar_permiso` AS `Eliminar`,`b`.`buscar_permiso` AS `Buscar`,`b`.`imprimir_permiso` AS `Reporte` from (`tbl_permisosaplicacionperfil` `b` join `tbl_perfiles` `a` on((`a`.`pk_id_perfil` = `b`.`fk_id_perfil`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vista_aplicacionusuario`
--

/*!50001 DROP VIEW IF EXISTS `vista_aplicacionusuario`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`administrador`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `vista_aplicacionusuario` AS select `b`.`fk_id_aplicacion` AS `Aplicacion`,`b`.`fk_id_usuario` AS `ID`,`a`.`nombre_usuario` AS `Usuario`,`b`.`guardar_permiso` AS `Guardar`,`b`.`modificar_permiso` AS `Editar`,`b`.`eliminar_permiso` AS `Eliminar`,`b`.`buscar_permiso` AS `Buscar`,`b`.`imprimir_permiso` AS `Reporte` from (`tbl_permisosaplicacionesusuario` `b` join `tbl_usuarios` `a` on((`a`.`pk_id_usuario` = `b`.`fk_id_usuario`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vista_modulo_aplicacion`
--

/*!50001 DROP VIEW IF EXISTS `vista_modulo_aplicacion`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`administrador`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `vista_modulo_aplicacion` AS select `b`.`fk_id_modulos` AS `ID`,`a`.`nombre_modulo` AS `Modulo`,`b`.`fk_id_aplicacion` AS `Aplicacion`,`c`.`nombre_aplicacion` AS `Nombre`,`c`.`descripcion_aplicacion` AS `Descripcion` from ((`tbl_asignacionmoduloaplicacion` `b` join `tbl_modulos` `a` on((`a`.`pk_id_modulos` = `b`.`fk_id_modulos`))) join `tbl_aplicaciones` `c` on((`c`.`pk_id_aplicacion` = `b`.`fk_id_aplicacion`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vista_perfil_usuario`
--

/*!50001 DROP VIEW IF EXISTS `vista_perfil_usuario`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`administrador`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `vista_perfil_usuario` AS select `b`.`fk_id_usuario` AS `ID`,`a`.`nombre_usuario` AS `Usuario`,`a`.`username_usuario` AS `nickName`,`b`.`fk_id_perfil` AS `perfil`,`c`.`nombre_perfil` AS `Nombre` from ((`tbl_asignacionesperfilsusuario` `b` join `tbl_usuarios` `a` on((`a`.`pk_id_usuario` = `b`.`fk_id_usuario`))) join `tbl_perfiles` `c` on((`c`.`pk_id_perfil` = `b`.`fk_id_perfil`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-10-08 18:16:32
