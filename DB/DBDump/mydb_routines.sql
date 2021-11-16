-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: localhost    Database: mydb
-- ------------------------------------------------------
-- Server version	8.0.27

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
-- Temporary view structure for view `v_ownerpets`
--

DROP TABLE IF EXISTS `v_ownerpets`;
/*!50001 DROP VIEW IF EXISTS `v_ownerpets`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v_ownerpets` AS SELECT 
 1 AS `ID`,
 1 AS `COUNT`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_servvisits`
--

DROP TABLE IF EXISTS `v_servvisits`;
/*!50001 DROP VIEW IF EXISTS `v_servvisits`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v_servvisits` AS SELECT 
 1 AS `ID`,
 1 AS `COUNT`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_categories`
--

DROP TABLE IF EXISTS `v_categories`;
/*!50001 DROP VIEW IF EXISTS `v_categories`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v_categories` AS SELECT 
 1 AS `ID`,
 1 AS `Номер`,
 1 AS `Категория`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_vaccinations`
--

DROP TABLE IF EXISTS `v_vaccinations`;
/*!50001 DROP VIEW IF EXISTS `v_vaccinations`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v_vaccinations` AS SELECT 
 1 AS `ID`,
 1 AS `PID`,
 1 AS `Дата вакцинации`,
 1 AS `Тип вакцинации`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_petvisits`
--

DROP TABLE IF EXISTS `v_petvisits`;
/*!50001 DROP VIEW IF EXISTS `v_petvisits`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v_petvisits` AS SELECT 
 1 AS `ID`,
 1 AS `COUNT`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_owners`
--

DROP TABLE IF EXISTS `v_owners`;
/*!50001 DROP VIEW IF EXISTS `v_owners`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v_owners` AS SELECT 
 1 AS `ID`,
 1 AS `ФИО`,
 1 AS `Телефон`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_doctors`
--

DROP TABLE IF EXISTS `v_doctors`;
/*!50001 DROP VIEW IF EXISTS `v_doctors`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v_doctors` AS SELECT 
 1 AS `ID`,
 1 AS `ФИО`,
 1 AS `Категория`,
 1 AS `Логин`,
 1 AS `Пароль`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_catdoctors`
--

DROP TABLE IF EXISTS `v_catdoctors`;
/*!50001 DROP VIEW IF EXISTS `v_catdoctors`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v_catdoctors` AS SELECT 
 1 AS `ID`,
 1 AS `COUNT`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_visitservices`
--

DROP TABLE IF EXISTS `v_visitservices`;
/*!50001 DROP VIEW IF EXISTS `v_visitservices`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v_visitservices` AS SELECT 
 1 AS `ID`,
 1 AS `VID`,
 1 AS `Услуга`,
 1 AS `PRICE`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_services`
--

DROP TABLE IF EXISTS `v_services`;
/*!50001 DROP VIEW IF EXISTS `v_services`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v_services` AS SELECT 
 1 AS `ID`,
 1 AS `Название`,
 1 AS `Цена`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_pets`
--

DROP TABLE IF EXISTS `v_pets`;
/*!50001 DROP VIEW IF EXISTS `v_pets`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v_pets` AS SELECT 
 1 AS `ID`,
 1 AS `PID`,
 1 AS `Имя животного`,
 1 AS `Тип животного`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_visits`
--

DROP TABLE IF EXISTS `v_visits`;
/*!50001 DROP VIEW IF EXISTS `v_visits`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v_visits` AS SELECT 
 1 AS `ID`,
 1 AS `DOC_ID`,
 1 AS `PET_ID`,
 1 AS `Дата визита`,
 1 AS `Животное`,
 1 AS `Общая сумма`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_docvisits`
--

DROP TABLE IF EXISTS `v_docvisits`;
/*!50001 DROP VIEW IF EXISTS `v_docvisits`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v_docvisits` AS SELECT 
 1 AS `ID`,
 1 AS `COUNT`*/;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `v_ownerpets`
--

/*!50001 DROP VIEW IF EXISTS `v_ownerpets`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_ownerpets` AS select `owners`.`id` AS `ID`,count(`pets`.`id`) AS `COUNT` from (`owners` left join `pets` on((`owners`.`id` = `pets`.`owner_id`))) group by `owners`.`id` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_servvisits`
--

/*!50001 DROP VIEW IF EXISTS `v_servvisits`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_servvisits` AS select `services`.`id` AS `ID`,count(`visitservices`.`id`) AS `COUNT` from (`services` left join `visitservices` on((`services`.`id` = `visitservices`.`service_id`))) group by `services`.`id` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_categories`
--

/*!50001 DROP VIEW IF EXISTS `v_categories`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_categories` AS select `categories`.`id` AS `ID`,`categories`.`cat_level` AS `Номер`,`categories`.`cat_name` AS `Категория` from `categories` order by `categories`.`cat_level` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_vaccinations`
--

/*!50001 DROP VIEW IF EXISTS `v_vaccinations`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_vaccinations` AS select `vaccinations`.`id` AS `ID`,`vaccinations`.`pet_id` AS `PID`,`vaccinations`.`vac_date` AS `Дата вакцинации`,`vaccinations`.`vac_type` AS `Тип вакцинации` from `vaccinations` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_petvisits`
--

/*!50001 DROP VIEW IF EXISTS `v_petvisits`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_petvisits` AS select `pets`.`id` AS `ID`,count(`visits`.`id`) AS `COUNT` from (`pets` left join `visits` on((`pets`.`id` = `visits`.`pet_id`))) group by `pets`.`id` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_owners`
--

/*!50001 DROP VIEW IF EXISTS `v_owners`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_owners` AS select `owners`.`id` AS `ID`,concat(`owners`.`last_name`,' ',`owners`.`first_name`,' ',`owners`.`second_name`) AS `ФИО`,`owners`.`contact_number` AS `Телефон` from `owners` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_doctors`
--

/*!50001 DROP VIEW IF EXISTS `v_doctors`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_doctors` AS select `doctors`.`id` AS `ID`,concat(`doctors`.`last_name`,' ',`doctors`.`first_name`,' ',`doctors`.`second_name`) AS `ФИО`,`categories`.`cat_name` AS `Категория`,`doctors`.`login` AS `Логин`,`doctors`.`password` AS `Пароль` from (`doctors` join `categories` on((`doctors`.`category_id` = `categories`.`id`))) order by `doctors`.`last_name` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_catdoctors`
--

/*!50001 DROP VIEW IF EXISTS `v_catdoctors`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_catdoctors` AS select `categories`.`id` AS `ID`,count(`doctors`.`id`) AS `COUNT` from (`categories` left join `doctors` on((`doctors`.`category_id` = `categories`.`id`))) group by `categories`.`id` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_visitservices`
--

/*!50001 DROP VIEW IF EXISTS `v_visitservices`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_visitservices` AS select `visitservices`.`id` AS `ID`,`visitservices`.`visit_id` AS `VID`,`services`.`service_name` AS `Услуга`,`services`.`price` AS `PRICE` from (`visitservices` join `services` on((`visitservices`.`service_id` = `services`.`id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_services`
--

/*!50001 DROP VIEW IF EXISTS `v_services`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_services` AS select `services`.`id` AS `ID`,`services`.`service_name` AS `Название`,`services`.`price` AS `Цена` from `services` order by `services`.`service_name` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_pets`
--

/*!50001 DROP VIEW IF EXISTS `v_pets`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_pets` AS select `pets`.`id` AS `ID`,`pets`.`owner_id` AS `PID`,`pets`.`name` AS `Имя животного`,`pets`.`pet_type` AS `Тип животного` from `pets` order by `pets`.`name` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_visits`
--

/*!50001 DROP VIEW IF EXISTS `v_visits`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_visits` AS select `visits`.`id` AS `ID`,`visits`.`doctor_id` AS `DOC_ID`,`visits`.`pet_id` AS `PET_ID`,`visits`.`visit_date` AS `Дата визита`,concat(`pets`.`name`,' - ',`pets`.`pet_type`) AS `Животное`,`visits`.`total_sum` AS `Общая сумма` from (`visits` join `pets` on((`visits`.`pet_id` = `pets`.`id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_docvisits`
--

/*!50001 DROP VIEW IF EXISTS `v_docvisits`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_docvisits` AS select `doctors`.`id` AS `ID`,count(`visits`.`id`) AS `COUNT` from (`doctors` left join `visits` on((`doctors`.`id` = `visits`.`doctor_id`))) group by `doctors`.`id` */;
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

-- Dump completed on 2021-11-16 13:21:27
