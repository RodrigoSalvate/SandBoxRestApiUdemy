CREATE DATABASE  IF NOT EXISTS `rest_aspnet_udemy` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `rest_aspnet_udemy`;
-- MySQL dump 10.13  Distrib 8.0.20, for Win64 (x86_64)
--
-- Host: localhost    Database: rest_aspnet_udemy
-- ------------------------------------------------------
-- Server version	8.0.20

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
-- Table structure for table `books`
--

DROP TABLE IF EXISTS `books`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `books` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Author` varchar(50) DEFAULT NULL,
  `LaunchDate` date NOT NULL,
  `Price` decimal(18,2) NOT NULL,
  `Title` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `books`
--

LOCK TABLES `books` WRITE;
/*!40000 ALTER TABLE `books` DISABLE KEYS */;
INSERT INTO `books` VALUES (1,'Porco','1995-06-29',122.00,'PIGOLA'),(2,'Michael C. Feathers','2017-11-29',49.00,'Working effectively with legacy code'),(3,'Ralph Johnson e Richard Helm','2017-11-29',45.00,'Design Patterns'),(4,'Robert C. Martin','2009-01-10',77.00,'Clean Code'),(5,'Crockford','2017-11-07',67.00,'JavaScript'),(6,'Steve McConnell','2017-11-07',58.00,'Code complete');
/*!40000 ALTER TABLE `books` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `persons`
--

DROP TABLE IF EXISTS `persons`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `persons` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(50) DEFAULT NULL,
  `LastName` varchar(50) DEFAULT NULL,
  `Address` varchar(50) DEFAULT NULL,
  `Gender` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=45 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `persons`
--

LOCK TABLES `persons` WRITE;
/*!40000 ALTER TABLE `persons` DISABLE KEYS */;
INSERT INTO `persons` VALUES (1,'Leadro','Costa','Uberlâdia - Mias Gerais - Brasil','Male'),(2,'Flávio','Costa','Patos de Mias - Mias Gerais - Brasil','Male'),(3,'Rodrigo hu3','Salvate Brasil','Rio de Jaeiro/RJ','Male'),(4,'Hazlett','Eaetta','354 Fordem Terrace','Male'),(5,'Fifi','oar','50437 Arizoa Terrace','Female'),(6,'Talia','Latus','78 Arrowood Drive','Female'),(7,'Tera','Cattermull','4992 Kiplig Crossig','Female'),(8,'Daisi','Stratta','2469 Trasport Aveue','Female'),(9,'Jacquette','Sowdo','43 Hoepker Crossig','Female'),(10,'Hube','Astma','4 Bultma Trail','Male'),(11,'Kalvi','Philpot','10 Warer Way','Male'),(12,'Meade','Rowe','828 Gia Way','Female'),(13,'Dru','Harefoot','32 Mosiee Ceter','Male'),(14,'Fraky','Oxbe','826 Oxford Aveue','Female'),(15,'Oliver','Schimoek','62274 Swallow Aveue','Male'),(16,'Jaee','Maharry','82 Golf Course Plaza','Female'),(17,'issy','Yegorovi','6256 Badeau Place','Female'),(18,'Cele','Arpur','64546 Dakota Poit','Female'),(19,'Humbert','Rodolico','3 Deis Ceter','Male'),(20,'Evey','Mathivet','0729 Hoepker Pass','Female'),(21,'Meryl','Richardet','6 Sloa Juctio','Male'),(22,'Wright','Dalda','08 Warer Aveue','Male'),(23,'Boe','Afrey','47 La Follette Circle','Male'),(24,'Teddy','Gavey','5 Mayfield Park','Female'),(25,'Morris','Hutigdo','87 Del Mar Drive','Male'),(26,'Frederico','Greystoke','1506 Macpherso Poit','Male'),(27,'Chrystal','Wardlaw','1 Sachtje Ceter','Female'),(28,'Jacquie','Clapperto','22 Butterfield Ceter','Female'),(29,'Dolph','Waulker','40328 Sudow Way','Male'),(30,'Thor','Dumphrey','6 Badig Circle','Male'),(31,'Doell','Mewett','2 Marcy Park','Male'),(32,'Margarethe','Battie','278 Evergree Crossig','Female'),(33,'Burgess','Fitzsymo','5 Oriole Parkway','Male'),(34,'Brew','Wellad','74 evada Pass','Male'),(35,'Ryley','ewgrosh','72860 Clemos Place','Male'),(36,'Harriet','Mabbutt','5 Ridgeway Trail','Female'),(37,'Chicky','Keright','0 Havey Parkway','Male'),(38,'Wedie','Ziemes','886 Mccormick Juctio','Female'),(39,'Marris','Fausset','7464 Rieder Ceter','Female'),(40,'Augustie','Keigher','097 Heath Street','Female'),(41,'Chic','Pittma','21800 Mayfield Poit','Male'),(42,'Alaric','Jauary','64 evada Juctio','Male'),(43,'Maribeth','Leeve','76148 Schmedema Way','Female'),(44,'Averyl','Mil','1 Arkasas Park','Female');
/*!40000 ALTER TABLE `persons` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Login` varchar(50) NOT NULL,
  `AccessKey` varchar(50) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'Rodrigo','pigola123');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-04-27 20:14:48
