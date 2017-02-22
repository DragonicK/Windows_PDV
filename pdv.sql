/*
Navicat MySQL Data Transfer

Source Server         : Connection
Source Server Version : 50626
Source Host           : localhost:3306
Source Database       : pdv

Target Server Type    : MYSQL
Target Server Version : 50626
File Encoding         : 65001

Date: 2017-02-03 07:53:37
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for account
-- ----------------------------
DROP TABLE IF EXISTS `account`;
CREATE TABLE `account` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(25) DEFAULT '',
  `password` varchar(64) DEFAULT '',
  `access` smallint(1) DEFAULT '1',
  `real_name` varchar(15) DEFAULT '',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of account
-- ----------------------------
INSERT INTO `account` VALUES ('1', 'akaruz', '39046213b04423ced40ff162cefd811ffd4a4f939083b1bf151ca47f7f864705', '3', 'Julio Sperandio');
INSERT INTO `account` VALUES ('2', 'dragonick', '39046213b04423ced40ff162cefd811ffd4a4f939083b1bf151ca47f7f864705', '3', 'Meu Nome');

-- ----------------------------
-- Table structure for employee
-- ----------------------------
DROP TABLE IF EXISTS `employee`;
CREATE TABLE `employee` (
  `id` int(11) NOT NULL,
  `username` varchar(20) DEFAULT NULL,
  `password` varchar(64) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of employee
-- ----------------------------

-- ----------------------------
-- Table structure for fornecedor
-- ----------------------------
DROP TABLE IF EXISTS `fornecedor`;
CREATE TABLE `fornecedor` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `codigo` varchar(100) NOT NULL DEFAULT '',
  `empresa` varchar(200) DEFAULT '',
  `endereco` varchar(100) DEFAULT '',
  `bairro` varchar(30) DEFAULT '',
  `cidade` varchar(25) DEFAULT '',
  `estado` varchar(25) DEFAULT '',
  `cep` varchar(25) DEFAULT '',
  `telefone` varchar(30) DEFAULT '',
  `cnpj` varchar(18) DEFAULT '',
  `ie` varchar(30) DEFAULT '',
  `data_cadastro` varchar(25) DEFAULT '',
  `email` varchar(120) DEFAULT '',
  PRIMARY KEY (`id`,`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of fornecedor
-- ----------------------------
INSERT INTO `fornecedor` VALUES ('1', '196760', 'PANDA CONVENIENCIA MEI', 'RUA MANOEL PARADA DE CARVALHO 81', 'CENTRO', 'VALPARAÍSO', 'SÃO PAULO', '16880-000', '18-991306354', '06.416.919/0001-47', '6468756151', '03/02/2017', 'JULIOSPERANDIO@HOTMAIL.COM');

-- ----------------------------
-- Table structure for product
-- ----------------------------
DROP TABLE IF EXISTS `product`;
CREATE TABLE `product` (
  `id` int(11) NOT NULL,
  `cod` varchar(50) DEFAULT NULL,
  `description` varchar(150) DEFAULT NULL,
  `department_cod` int(3) DEFAULT NULL,
  `unit_cod` int(3) DEFAULT NULL,
  `provider_cod` int(3) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of product
-- ----------------------------
