-- MySQL dump 10.13  Distrib 8.0.29, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: db
-- ------------------------------------------------------
-- Server version	5.7.39

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
-- Table structure for table `video`
--

DROP TABLE IF EXISTS `video`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `video` (
  `video_id` int(11) NOT NULL,
  `video_name` varchar(45) DEFAULT NULL,
  `video_bild` longblob,
  `build_loader` varchar(2048) DEFAULT NULL,
  `build_data` varchar(2048) DEFAULT NULL,
  `build_framework` varchar(2048) DEFAULT NULL,
  `build_wasm` varchar(2048) DEFAULT NULL,
  `video_length` int(11) DEFAULT NULL,
  `fk_kurs_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`video_id`),
  UNIQUE KEY `idvideo_UNIQUE` (`video_id`),
  KEY `fk_kurs_id_idx` (`fk_kurs_id`),
  CONSTRAINT `fk_kurs_id` FOREIGN KEY (`fk_kurs_id`) REFERENCES `kurs` (`kurs_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `video`
--

LOCK TABLES `video` WRITE;
/*!40000 ALTER TABLE `video` DISABLE KEYS */;
INSERT INTO `video` VALUES (1,'Wiener Walzer',NULL,'https://github.com/lnurtaev/VC_MotionCapture/blob/main/Build/Test.loader.js','https://github.com/lnurtaev/VC_MotionCapture/blob/main/Build/Test.data','https://github.com/lnurtaev/VC_MotionCapture/blob/main/Build/Test.framework.js','https://github.com/lnurtaev/VC_MotionCapture/blob/main/Build/Test.wasm',NULL,1),(2,'Tango',NULL,NULL,NULL,NULL,NULL,NULL,1),(3,'Jive',NULL,NULL,NULL,NULL,NULL,NULL,2);
/*!40000 ALTER TABLE `video` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-08-23 10:58:01
