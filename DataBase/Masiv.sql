/*
SQLyog Ultimate v12.4.3 (64 bit)
MySQL - 10.4.24-MariaDB : Database - masiv
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`masiv` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;

USE `masiv`;

/*Table structure for table `discount_list` */

DROP TABLE IF EXISTS `discount_list`;

CREATE TABLE `discount_list` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `console` varchar(45) DEFAULT NULL,
  `minimal_price` float DEFAULT NULL,
  `maximum_price` float DEFAULT NULL,
  `discounts` int(11) DEFAULT NULL,
  `creation_date` datetime DEFAULT current_timestamp(),
  KEY `id` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;

/*Data for the table `discount_list` */

insert  into `discount_list`(`id`,`console`,`minimal_price`,`maximum_price`,`discounts`,`creation_date`) values 
(1,'PS4',100000,NULL,5,'2022-10-14 10:09:38'),
(2,'XBOX',100001,150000,7,'2022-10-14 10:09:42'),
(3,'PC',150000,NULL,15,'2022-10-14 10:09:44'),
(4,'OTRA',500000,1000000,10,'2022-10-14 10:09:52');

/*Table structure for table `sales_table` */

DROP TABLE IF EXISTS `sales_table`;

CREATE TABLE `sales_table` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `console` varchar(45) DEFAULT NULL,
  `value` float DEFAULT NULL,
  `discount` float DEFAULT NULL,
  `creation_date` datetime DEFAULT current_timestamp(),
  KEY `id` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;

/*Data for the table `sales_table` */



/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
