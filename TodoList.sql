-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: localhost    Database: todolist
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
-- Table structure for table `todoitem`
--

DROP TABLE IF EXISTS `todoitem`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `todoitem` (
  `TodoItemID` int NOT NULL AUTO_INCREMENT,
  `UserID` int DEFAULT NULL,
  `Title` varchar(255) DEFAULT NULL,
  `Description` varchar(255) DEFAULT NULL,
  `DeadlineTime` datetime DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `UpdatedDate` datetime DEFAULT NULL,
  PRIMARY KEY (`TodoItemID`)
) ENGINE=InnoDB AUTO_INCREMENT=46 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `todoitem`
--

LOCK TABLES `todoitem` WRITE;
/*!40000 ALTER TABLE `todoitem` DISABLE KEYS */;
INSERT INTO `todoitem` VALUES (26,1,'test thử chức năng gửi mail','Lưu ý xem kỹ','2022-05-19 06:51:00','2022-05-19 06:50:48','2022-05-19 06:50:48'),(27,1,'test thử chức năng gửi mail lần 2','Lưu ý xem kỹ','2022-05-19 06:54:00','2022-05-19 06:54:42','2022-05-19 06:54:42'),(28,1,'Làm bài tập','Nhớ đọc kỹ trước khi làm','2022-05-19 20:34:00','2022-05-19 20:33:59','2022-05-19 20:33:59'),(29,0,'Làm bài tập','Ghi chú lại','2022-05-19 21:05:00','2022-05-19 21:04:40','2022-05-19 21:04:40'),(30,0,'ABC','ghi chú','2022-05-19 21:06:00','2022-05-19 21:05:31','2022-05-19 21:05:31'),(36,2,'ABC1','Lưu ý','2022-05-19 21:21:00','2022-05-19 21:19:59','2022-05-19 21:19:59'),(37,2,'ABC2','Lưu ý','2022-05-19 21:21:00','2022-05-19 21:20:03','2022-05-19 21:20:03'),(38,2,'ABC3','Lưu ý','2022-05-19 21:29:00','2022-05-19 21:27:30','2022-05-19 21:27:30'),(39,2,'ABC4','Lưu ý','2022-05-19 21:29:00','2022-05-19 21:27:35','2022-05-19 21:27:35'),(40,5,'Test thử email','Lưu ý','2022-05-19 21:47:00','2022-05-19 21:45:44','2022-05-19 21:45:44'),(41,5,'Test thử email 2','Lưu ý 2','2022-05-19 21:47:00','2022-05-19 21:45:53','2022-05-19 21:45:53'),(42,2,'ABC5','abc','2022-05-19 21:50:00','2022-05-19 21:49:50','2022-05-19 21:49:50'),(43,6,'ABC','lưu ý','2022-05-19 21:52:00','2022-05-19 21:51:50','2022-05-19 21:51:50'),(44,5,'ABC','abc','2022-05-19 21:55:00','2022-05-19 21:54:06','2022-05-19 21:54:06'),(45,6,'ABC1','','2022-05-19 21:57:00','2022-05-19 21:57:02','2022-05-19 21:57:02');
/*!40000 ALTER TABLE `todoitem` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `UserID` int NOT NULL AUTO_INCREMENT,
  `Email` varchar(50) DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `UpdatedDate` datetime DEFAULT NULL,
  PRIMARY KEY (`UserID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'pntoan156@gmail.com','2022-05-18 00:00:00','2022-05-18 00:00:00'),(2,'ngoctoanforwork@gmail.com',NULL,NULL),(5,'hieua1cma@gmail.com','2022-05-19 21:45:11','2022-05-19 21:45:11'),(6,'donam2539@gmail.com','2022-05-19 21:51:20','2022-05-19 21:51:20');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'todolist'
--
/*!50003 DROP PROCEDURE IF EXISTS `Proc_AddTodoItem` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb3 */ ;
/*!50003 SET character_set_results = utf8mb3 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Proc_AddTodoItem`(IN UserID INT, IN Title VARCHAR(255), IN Description VARCHAR(255), IN DeadlineTime datetime)
BEGIN


INSERT INTO todoitem (UserID, Title, Description, DeadlineTime, CreatedDate, UpdatedDate)
  VALUES (UserID, Title, Description, DeadlineTime, NOW(), NOW());




END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Proc_CheckDeadline` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb3 */ ;
/*!50003 SET character_set_results = utf8mb3 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Proc_CheckDeadline`(IN deadlineTime DATETIME)
BEGIN
  SELECT  u.* FROM user u 
  INNER JOIN todoitem t ON u.UserID = t.UserID 
  WHERE YEAR(t.DeadlineTime)  = year(deadlineTime) 
  AND MONTH(t.DeadlineTime) = MONTH(deadlineTime) 
  AND DAY(t.DeadlineTime) = DAY(deadlineTime) 
  AND HOUR(t.DeadlineTime) = HOUR(deadlineTime) 
  AND MINUTE(t.DeadlineTime) = MINUTE(deadlineTime) 
  GROUP BY u.Email ORDER BY u.Email;

  SELECT u.Email,t.* FROM user u INNER JOIN todoitem t ON u.UserID = t.UserID   
  WHERE YEAR(t.DeadlineTime)  = year(deadlineTime) 
  AND MONTH(t.DeadlineTime) = MONTH(deadlineTime) 
  AND DAY(t.DeadlineTime) = DAY(deadlineTime) 
  AND HOUR(t.DeadlineTime) = HOUR(deadlineTime) 
  AND MINUTE(t.DeadlineTime) = MINUTE(deadlineTime)  
  ORDER BY u.Email;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Proc_GetAllTodoItem` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb3 */ ;
/*!50003 SET character_set_results = utf8mb3 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Proc_GetAllTodoItem`(IN UserID int)
BEGIN
SELECT * FROM todoitem t WHERE t.UserID = UserID;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Proc_GetUserByID` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb3 */ ;
/*!50003 SET character_set_results = utf8mb3 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Proc_GetUserByID`(IN userID int)
BEGIN
SELECT * FROM user u WHERE u.UserID = userID;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Proc_Login` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb3 */ ;
/*!50003 SET character_set_results = utf8mb3 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Proc_Login`(IN Email VARCHAR(255))
BEGIN
set @isExist = (SELECT COUNT(*) FROM user u WHERE u.Email = Email);
IF @isExist > 0 THEN
  set @userID = ( SELECT u.UserID FROM user u WHERE u.Email = Email ORDER BY u.UserID LIMIT 1 );
  SELECT * FROM todoitem t WHERE t.UserID = @userID;
  SELECT @userID;
ELSE
  INSERT INTO USER(Email,CreatedDate,UpdatedDate) VALUES(Email,NOW(),NOW());
END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-05-19 22:15:08
