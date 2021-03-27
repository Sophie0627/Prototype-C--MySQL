/*
SQLyog Community v13.1.6 (64 bit)
MySQL - 10.4.8-MariaDB : Database - prototype
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`prototype` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `prototype`;

/*Table structure for table `users` */

DROP TABLE IF EXISTS `users`;

CREATE TABLE `users` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` text NOT NULL,
  `Role` varchar(15) NOT NULL,
  `Status` tinyint(1) NOT NULL DEFAULT 0,
  UNIQUE KEY `Id_2` (`Id`),
  KEY `Id` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

/*Data for the table `users` */

insert  into `users`(`Id`,`Name`,`Username`,`Password`,`Role`,`Status`) values 
(1,'Tone','tone','f303f9a15cddbe8ee0296511a8b04b30','Investigator',1),
(2,'Hiccup','hiccup','a9d719491cf5efcbfea518802bda4b2a','Investigator',0),
(3,'Admin','admin','21232f297a57a5a743894a0e4a801fc3','Admin',1),
(5,'Client','client','62608e08adc29a8d6dbc9754e659f125','Investigator',1),
(6,'Sake','sake','c5ebfc2dd566bb4610cdfcd17c873dba','Investigator',1);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
