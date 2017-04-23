/*
Navicat MySQL Data Transfer

Source Server         : 90 mysql
Source Server Version : 50712
Source Host           : 192.168.18.90:3306
Source Database       : joe_order_center

Target Server Type    : MYSQL
Target Server Version : 50712
File Encoding         : 65001

Date: 2017-04-23 16:19:32
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for purchase_order
-- ----------------------------
DROP TABLE IF EXISTS `purchase_order`;
CREATE TABLE `purchase_order` (
  `Id` char(36) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL DEFAULT '',
  `OrderNumber` longtext NOT NULL,
  `OrderSource` int(11) NOT NULL,
  `OrderType` int(11) NOT NULL,
  `TradeMode` int(11) NOT NULL,
  `BusinessState` int(11) NOT NULL,
  `PayState` int(11) NOT NULL,
  `VerificationState` int(11) NOT NULL,
  `OccupationType` int(11) NOT NULL,
  `OrderMoney_DealAmount` decimal(18,2) NOT NULL,
  `OrderMoney_DealCurrencyCode` longtext NOT NULL,
  `OrderMoney_CurrencyRate` decimal(18,4) NOT NULL,
  `OrderMoney_BaseCurrencyCode` longtext NOT NULL,
  `Note` longtext,
  `UserCreated_Id` bigint(20) NOT NULL,
  `UserCreated_FullName` longtext,
  `UserCreated_Phone` longtext,
  `UserCreated_AgencyId` bigint(20) DEFAULT NULL,
  `TimeCreated` datetime NOT NULL,
  `Seller_OnlineType` int(11) NOT NULL,
  `Seller_SellerType` int(11) NOT NULL,
  `Seller_SellerId` bigint(20) NOT NULL,
  `Seller_SellerName` longtext,
  `SellerContact_FullName` longtext,
  `SellerContact_Phone` longtext,
  `SellerContact_Email` longtext,
  `SellerContact_QQ` longtext,
  `SellerContact_Wechat` longtext,
  `SellerContact_WechatQrImg` longtext,
  `Settlement_SettlementSchemeType` int(11) NOT NULL,
  `Settlement_SettlementType` int(11) NOT NULL,
  `Settlement_Day` int(11) DEFAULT NULL,
  `Settlement_Weekday` int(11) DEFAULT NULL,
  `SettlementItems` longtext,
  `Settlement_Deposit` decimal(18,2) DEFAULT NULL,
  `Settlement_DepositCurrencyCode` longtext,
  `Invoice_InvoiceType` int(11) NOT NULL,
  `Invoice_Title` longtext,
  `Invoice_Note` longtext,
  `Shipping_ShippingType` int(11) NOT NULL,
  `Shipping_Address` longtext,
  `PriceConcession_ConcessionType` int(11) NOT NULL,
  `PriceConcession_ConcessionName` longtext,
  `PriceConcession_ConcessionNumber` decimal(18,2) NOT NULL,
  `CutOffTime` datetime DEFAULT NULL,
  `MallOrderId` longtext,
  `BuyerContact_FullName` longtext,
  `BuyerContact_Phone` longtext,
  `BuyerContact_Email` longtext,
  `BuyerContact_QQ` longtext,
  `BuyerContact_Wechat` longtext,
  `BuyerContact_WechatQrImg` longtext,
  `UserCreated_AgencyName` longtext,
  `OccupationTime` datetime DEFAULT NULL,
  `Seller_AgencyRelationId` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of purchase_order
-- ----------------------------
INSERT INTO `purchase_order` VALUES ('04cafd16-1417-48e9-882a-43096c48b782', 'SW-BS444', '3', '128', '0', '1', '1', '2', '1', '100000.00', 'CNY', '1.0000', 'CNY', '222222222222222222222222222222222222222222222222222222222', '34', 'miniluo', null, '8', '2017-03-15 21:46:24', '1', '2', '7', '阿鸿日料公司', '李政鸿', '15807801125', '7529232761@qq.com', null, null, null, '2', '1', null, null, '[]', null, null, '1', '2222222222222', '2222222222222222222222222222222222', '1', '222222222222222222222222222222222222222222', '1', '直减', '0.00', null, null, null, null, null, null, null, null, 'Losij.company', null, null);
INSERT INTO `purchase_order` VALUES ('05db3a53-b8c8-4b6b-af8a-850373f9348d', 'SW-BS701', '3', '128', '1', '1', '1', '2', '2', '100000.00', 'CNY', '1.0000', 'CNY', '2222222222222222222222222222222222222222222222222222222222222222222222', '34', 'miniluo', null, '8', '2017-03-15 21:33:12', '1', '2', '7', '阿鸿日料公司', '李政鸿', '15807801125', '7529232761@qq.com', null, null, null, '1', '1', null, null, '[]', '468.00', 'CNY', '1', '22222222222', '22222222222222', '1', '2222222222222222222222222222222222', '1', '直减', '0.00', null, null, null, null, null, null, null, null, 'Losij.company', null, null);
INSERT INTO `purchase_order` VALUES ('0f435990-e8c7-4ad7-83cc-e61107cf525d', '20170421013', '3', '16', '1', '1', '1', '2', '1', '-200.00', 'USD', '3.0000', 'CNY', null, '33', '李政鸿', null, '31', '2017-04-21 16:47:20', '1', '2', '9', '肖司机车友会1', '谭凯文', '13710180709', null, null, null, null, '1', '1', null, null, '[]', '0.00', 'CNY', '4', null, null, '2', null, '1', '直减', '-200.00', null, null, '马琴', '15323301260', null, null, null, null, '广州优游电子科技有限公司', null, '115');
INSERT INTO `purchase_order` VALUES ('11085284-38e0-4a80-8c6b-da29efa7bf3e', '1703180006', '3', '8', '0', '1', '1', '2', '2', '2000.00', 'CNY', '1.0000', 'CNY', '2222222222222222222222222222222222222', '31', '肖永俊', null, '31', '2017-03-18 16:35:10', '2', '2', '54', '广州市第三有限公司', '陈老师', '13433954986', null, null, null, null, '1', '1', null, null, '[]', '400.00', 'CNY', '1', '2', '22222222222222222222222222222222222222222222222', '1', '22222222222222222222222222222222222222', '1', '直减', '0.00', null, null, null, null, null, null, null, null, '广州优游电子科技有限公司', null, null);
INSERT INTO `purchase_order` VALUES ('11b2bcdf-b26f-4adb-8cd0-08fc6b2b0881', 'SW-BS038', '3', '256', '1', '1024', '1', '2', '2', '1234123410000.00', 'CNY', '0.0000', 'CNY', '0000000000000000000000000000000000000000000', '34', 'miniluo', null, '8', '2017-03-10 19:43:17', '1', '2', '7', '阿鸿日料公司', '李政鸿', '15807801125', '7529232761@qq.com', null, null, null, '1', '1', null, null, '[]', '246824682936.00', 'CNY', '1', '0000', '000000000000000000000', '1', '000000000000000000000000', '1', '直减', '2340.00', null, null, null, null, null, null, null, null, 'Losij.company', null, null);
INSERT INTO `purchase_order` VALUES ('13eef91d-0483-11e7-a4a5-bc5ff4424ce6', 'SW-BS837', '3', '2048', '1', '1024', '1', '0', '2', '0.00', 'CNY', '0.0000', 'CNY', '2222222222222222222222222222222222222222222222222222222222', '34', 'miniluo', null, '8', '2017-03-09 12:44:27', '1', '2', '7', '阿鸿日料公司', '李政鸿', '15807801125', '7529232761@qq.com', null, null, null, '1', '1', null, null, '[]', '1230.00', 'CNY', '1', '2222222222222222', '2222222222222222', '1', '2222222222222222222222222222222222222222222222', '1', null, '0.00', null, null, null, null, null, null, null, null, 'Losij.company', null, null);
INSERT INTO `purchase_order` VALUES ('14ea17a4-0488-11e7-a4a5-bc5ff4424ce6', 'SW-BS153', '3', '256', '1', '1024', '1', '0', '2', '0.00', 'CNY', '0.0000', 'CNY', '3333333333333333333', '34', 'miniluo', null, '8', '2017-03-09 13:20:17', '1', '2', '7', '阿鸿日料公司', '李政鸿', '15807801125', '7529232761@qq.com', null, null, null, '1', '1', null, null, '[]', '123412341234.00', 'CNY', '1', '3333333', '333333333333333333333', '1', '333333333333333333333333333333', '1', '直减', '0.00', null, null, null, null, null, null, null, null, 'Losij.company', null, null);
INSERT INTO `purchase_order` VALUES ('19dc4141-04a4-11e7-a4a5-bc5ff4424ce6', 'SW-BS729', '3', '32', '0', '1', '1', '0', '2', '44.00', 'CNY', '0.0000', 'CNY', null, '34', 'miniluo', null, '8', '2017-03-09 16:41:25', '1', '2', '82', '香香假期', '范特西', '18316022518', '318729287@qq.com', null, null, '', '1', '1', null, null, '[]', null, 'CNY', '3', null, null, '2', null, '1', '直减', '0.00', null, null, null, null, null, null, null, null, 'Losij.company', null, null);
INSERT INTO `purchase_order` VALUES ('1d591ebc-0d32-4a24-9cb2-8761dd37c203', '20170421017', '3', '8', '1', '2', '1', '2', '1', '3000.00', 'CNY', '1.0000', 'CNY', null, '33', '李政鸿', null, '31', '2017-04-21 19:40:02', '1', '2', '9', '肖司机车友会1', '谭凯文', '13710180709', null, null, null, null, '1', '1', null, null, '[]', '0.00', 'CNY', '4', null, null, '2', null, '1', '直减', '0.00', null, null, '马琴', '15323301260', null, null, null, null, '广州优游电子科技有限公司', null, '115');
INSERT INTO `purchase_order` VALUES ('1e95e56c-d290-43e0-8347-c88108d9f0ba', '1703170002', '3', '8', '0', '1', '1', '2', '2', '2000.00', 'CNY', '1.0000', 'CNY', '3333333333333333333', '34', 'miniluo', null, '31', '2017-03-17 16:26:44', '2', '2', '59', '香香假期', '徐梦龙', '18888888888', '18888888888@qq.com', '18888888888', '18888888888', null, '1', '1', null, null, '[]', '300.00', 'CNY', '1', '33333333333', '3333333333333333333333333', '1', '33333333333333333333333333333333', '1', '直减', '0.00', null, null, null, null, null, null, null, null, '广州优游电子科技有限公司', null, null);
INSERT INTO `purchase_order` VALUES ('2949412b-52fa-4aa2-828b-ae02396d17aa', '20170420009', '3', '8', '0', '1', '1', '2', '1', '0.00', 'CNY', '1.0000', 'CNY', '324123412341234', '33', '李政鸿', null, '31', '2017-04-20 16:15:24', '1', '2', '9', '肖司机车友会1', '谭凯文', '13710180709', null, null, null, null, '1', '1', null, null, '[]', '6000.00', 'CNY', '1', '3241234', '213412341234', '1', '134223412343', '1', '直减', '0.00', null, null, '马琴', '15323301260', '8642405022qq.com', null, null, null, '广州优游电子科技有限公司', null, '115');
INSERT INTO `purchase_order` VALUES ('2c24a0d2-7e30-4a8a-8e96-855d25d75516', '20170412018', '3', '1', '0', '1', '1', '2', '2', '24680.00', 'CNY', '1.0000', 'CNY', null, '34', 'miniluo', null, '8', '2017-04-12 15:00:47', '1', '2', '7', '阿鸿日料公司', '李政鸿', '15807801125', '7529232761@qq.com', null, null, null, '1', '1', null, null, '[]', '4936.00', 'CNY', '1', null, null, '1', null, '1', '直减', '0.00', null, null, 'miniluo', '13660057286', null, null, null, null, 'Losij.company', null, null);
INSERT INTO `purchase_order` VALUES ('390062d5-25e7-44d2-9f21-6279aa2de9ac', '20170413027', '3', '1', '0', '1', '1', '2', '2', '12900.00', 'CNY', '1.0000', 'CNY', '45234523453245', '34', 'miniluo', null, '8', '2017-04-13 11:59:33', '1', '2', '31', '广州优游电子科技有限公司', '马琴', '15323301260', '8642405022qq.com', null, null, null, '1', '1', null, null, '[]', '2580.00', 'CNY', '1', '53452', '345234523452', '1', '51353453', '1', '直减', '0.00', null, null, 'miniluo', '13660057286', null, null, null, null, 'Losij.company', null, null);
INSERT INTO `purchase_order` VALUES ('40f98529-3000-4947-8328-a10ec30fd0b1', '20170420010', '3', '16', '0', '1', '1', '2', '1', '-40.00', 'USD', '3.0000', 'CNY', '123412341234234213412341234', '33', '李政鸿', null, '31', '2017-04-20 16:18:25', '1', '2', '32', '广州市电子有限公司', '黄伟俊', '15920147678', '89423198@qq.com', null, null, null, '1', '1', null, null, '[]', '8610.00', 'CNY', '1', '2341234', '12341234213', '1', '123412341234', '1', '直减', '-40.00', null, null, '黄伟俊', '15920147678', '89423198@qq.com', null, null, null, '广州优游电子科技有限公司', null, '55');
INSERT INTO `purchase_order` VALUES ('46b2088c-106b-4523-b6aa-1a84cfaff2f1', '1703180008', '3', '8', '0', '1', '1', '2', '2', '50000.00', 'CNY', '1.0000', 'CNY', '333333333333333333333333333333', '31', '肖永俊', null, '31', '2017-03-18 18:03:15', '2', '2', '54', '广州市第三有限公司', '陈老师', '13433954986', null, null, null, null, '1', '1', null, null, '[]', '10000.00', 'CNY', '1', '3333', '333333333333333333333333333333', '1', '3333333333333333333333333333333333333333333333', '1', '直减', '0.00', null, null, null, null, null, null, null, null, '广州优游电子科技有限公司', null, null);
INSERT INTO `purchase_order` VALUES ('621ec11b-5ff2-4b0e-af2e-513ace614137', 'SW-BS262', '3', '16', '0', '4096', '1', '2', '1', '913000.00', 'CNY', '1.0000', 'CNY', '3333333333', '34', 'miniluo', null, '8', '2017-03-15 20:24:08', '1', '2', '7', '阿鸿日料公司', '李政鸿', '15807801125', '7529232761@qq.com', null, null, null, '1', '3', null, null, '[]', '0.00', 'CNY', '1', '33333333333333333333333333333333333333', '3333333333333333333333333333333333333', '1', '3333333333333333333333333333333', '1', '直减', '0.00', null, null, null, null, null, null, null, null, 'Losij.company', null, null);
INSERT INTO `purchase_order` VALUES ('6510cb9c-cc49-4d81-97a1-264149e4b92a', 'SW-BS918', '3', '1', '1', '4096', '1', '2', '2', '0.00', 'CNY', '1.0000', 'CNY', null, '34', 'miniluo', null, '8', '2017-03-12 13:23:33', '1', '2', '7', '阿鸿日料公司', '李政鸿', '15807801125', '7529232761@qq.com', null, null, null, '1', '1', null, null, '[]', null, 'CNY', '4', null, null, '2', null, '1', '直减', '0.00', null, null, null, null, null, null, null, null, 'Losij.company', null, null);
INSERT INTO `purchase_order` VALUES ('67d8cf83-8381-43f8-b7ef-95e10ae3fe9f', 'SW-BS639', '3', '1', '1', '2', '1', '2', '2', '2333377234.00', 'CNY', '1.0000', 'CNY', null, '34', 'miniluo', null, '8', '2017-03-16 17:41:58', '1', '2', '7', '阿鸿日料公司', '李政鸿', '15807801125', '7529232761@qq.com', null, null, null, '1', '1', null, null, '[]', null, null, '4', null, null, '2', null, '1', '直减', '0.00', null, null, null, null, null, null, null, null, 'Losij.company', null, null);
INSERT INTO `purchase_order` VALUES ('67fff56e-98a4-4ab0-97dd-344b70a94c9b', '1703180010', '3', '128', '1', '2', '1', '2', '2', '30000.00', 'CNY', '1.0000', 'CNY', '33333333333333333333333333333333333333333333333333333333', '31', '肖永俊', null, '31', '2017-03-18 18:09:41', '1', '2', '32', '广州市电子有限公司', '黄伟俊', '15920147678', '89423198@qq.com', null, null, null, '1', '1', null, null, '[]', null, null, '1', '3333333333333', '3333333333333333333333333333', '1', '33333333333333333333333333333333333', '1', '直减', '0.00', null, null, null, null, null, null, null, null, '广州优游电子科技有限公司', null, null);
INSERT INTO `purchase_order` VALUES ('68a9d5b0-2c6a-44d4-aab5-a48decf1ed67', 'SW-BS405', '3', '16', '0', '1', '1', '2', '2', '1000000000.00', 'CNY', '1.0000', 'CNY', '2222222222222222222222222222222222222222222222222', '34', 'miniluo', null, '8', '2017-03-16 17:21:33', '1', '2', '7', '阿鸿日料公司', '李政鸿', '15807801125', '7529232761@qq.com', null, null, null, '1', '1', null, null, '[]', '200000000.00', 'CNY', '4', '2222222222', '2222222222222222222222222222222222', '1', '222222222222222222222222222222222222222222', '1', '直减', '0.00', null, null, null, null, null, null, null, null, 'Losij.company', null, null);
INSERT INTO `purchase_order` VALUES ('6c51d1ed-6267-44b3-8c23-ae45fcf461e8', 'SW-BS615', '3', '1', '1', '1', '1', '2', '2', '49364936.00', 'CNY', '0.0000', 'CNY', null, '34', 'miniluo', null, '8', '2017-03-10 12:19:28', '1', '2', '7', '阿鸿日料公司', '李政鸿', '15807801125', '7529232761@qq.com', null, null, null, '1', '1', null, null, '[]', null, 'CNY', '3', null, null, '2', null, '1', '直减', '0.00', null, null, null, null, null, null, null, null, 'Losij.company', null, null);
INSERT INTO `purchase_order` VALUES ('71f9fd58-c00f-4c71-9862-efb830047556', '20170412019', '3', '1', '0', '1', '1', '2', '2', '36900.00', 'CNY', '1.0000', 'CNY', '34523452435234523452345', '34', 'miniluo', null, '8', '2017-04-12 15:05:56', '1', '2', '7', '阿鸿日料公司', '李政鸿', '15807801125', '7529232761@qq.com', null, null, null, '1', '1', null, null, '[]', '11070.00', 'CNY', '1', null, '5234523452', '1', null, '1', '直减', '0.00', null, null, 'miniluo', '13660057286', null, null, null, null, 'Losij.company', null, null);
INSERT INTO `purchase_order` VALUES ('78fa473a-13fe-4be9-9f2a-fe10cb0f2b68', '20170412026', '3', '1', '1', '2', '1', '2', '2', '59766.00', 'CNY', '1.0000', 'CNY', '34132432412342342342334', '34', 'miniluo', null, '8', '2017-04-12 18:48:47', '1', '2', '7', '阿鸿日料公司', '李政鸿', '15807801125', '7529232761@qq.com', null, null, null, '1', '1', null, null, '[]', '0.00', 'CNY', '1', '而且微软', '123412342134324231', '1', 'e\'w\'r\'q\'we\'re', '1', '直减', '-234.00', null, null, 'miniluo', '13660057286', null, null, null, null, 'Losij.company', null, null);
INSERT INTO `purchase_order` VALUES ('7c9316e9-04a3-11e7-a4a5-bc5ff4424ce6', 'SW-BS011', '3', '32', '0', '1', '1', '0', '2', '0.00', 'CNY', '0.0000', 'CNY', null, '34', 'miniluo', null, '8', '2017-03-09 16:36:27', '1', '2', '7', '阿鸿日料公司', '李政鸿', '15807801125', '7529232761@qq.com', null, null, null, '1', '1', null, null, '[]', null, 'CNY', '3', null, null, '2', null, '1', '直减', '0.00', null, null, null, null, null, null, null, null, 'Losij.company', null, null);
INSERT INTO `purchase_order` VALUES ('7fda9c85-75d7-4c7a-a380-2ec68eb22152', 'SW-BS358', '3', '128', '0', '1', '1', '2', '2', '100000.00', 'CNY', '1.0000', 'CNY', '33333333333333333333333333333', '34', 'miniluo', null, '8', '2017-03-15 21:34:47', '1', '2', '7', '阿鸿日料公司', '李政鸿', '15807801125', '7529232761@qq.com', null, null, null, '1', '3', null, null, '[]', null, null, '1', '3333333333333333333333333', '3333333333333333333333333333333333', '0', null, '1', '直减', '0.00', null, null, null, null, null, null, null, null, 'Losij.company', null, null);
INSERT INTO `purchase_order` VALUES ('823269d1-1c2f-446d-8aa1-9a48b480ed67', 'SW-BS187', '3', '128', '0', '1', '1', '2', '1', '100000.00', 'CNY', '1.0000', 'CNY', '3333333333333333333333333333333333333333333333333333333333333', '34', 'miniluo', null, '8', '2017-03-15 21:44:43', '1', '2', '7', '阿鸿日料公司', '李政鸿', '15807801125', '7529232761@qq.com', null, null, null, '2', '2', null, null, '[]', null, null, '1', '33333333333333333333333333333333', '3333333333333333333333333333333', '1', '3333333333333333333333333333333333333333333333333333', '1', '直减', '0.00', null, null, null, null, null, null, null, null, 'Losij.company', null, null);
INSERT INTO `purchase_order` VALUES ('86afec35-e2d2-4817-a33b-f591a3d2cf46', '20170421018', '3', '2', '0', '1', '1', '2', '1', '24680.00', 'EUR', '9.2000', 'CNY', null, '33', '李政鸿', null, '31', '2017-04-21 21:11:15', '2', '2', '36', '广州青春之旅', '陈好', '15626183941', 'zhaozi@162.com', '99950104', 'Chenhao', null, '1', '1', null, null, '[]', '0.00', 'CNY', '4', null, null, '2', null, '1', '直减', '0.00', null, null, '龙dais', '15830540321', '3316529332@qq.com', null, null, null, '广州优游电子科技有限公司', null, '36');
INSERT INTO `purchase_order` VALUES ('86f59acb-c545-4f72-9552-b4f96cdf68ce', '20170420012', '3', '2', '1', '1', '1', '2', '1', '-200.00', 'EUR', '9.2000', 'CNY', '酷12341234123酷酷酷酷1234酷酷酷酷酷12341234酷341234酷酷酷酷141232你你你你你341234你你你你你你你你你你你你你你', '33', '李政鸿', null, '31', '2017-04-20 16:34:40', '1', '2', '8', 'Losij.company', 'miniluo', '13660057286', null, null, null, null, '1', '1', null, null, '[]', '0.00', 'CNY', '1', '不不不2341234不不不', '噢噢噢噢123432141324噢134134噢噢噢噢噢噢噢2343411噢噢噢噢哦哦哦', '1', '哈哈哈哈哈哈哈412341234123哈哈哈哈324324134123哈哈哈哈哈哈哈哈3423', '1', '直减', '-200.00', null, null, '李政鸿', '15807801125', null, null, null, null, '广州优游电子科技有限公司', null, '118');
INSERT INTO `purchase_order` VALUES ('8b8144b8-0481-11e7-a4a5-bc5ff4424ce6', 'SW-BS223', '3', '8', '1', '1', '1', '0', '2', '0.00', 'CNY', '0.0000', 'CNY', '000000000000000000000000000000000', '34', 'miniluo', null, '8', '2017-03-09 12:33:30', '1', '2', '7', '阿鸿日料公司', '李政鸿', '15807801125', '7529232761@qq.com', null, null, null, '1', '1', null, null, '[]', '920.00', 'CNY', '1', '000000000000000', '00000000000000000000', '1', '000000000000000000000000000000000000000000000', '1', '直减', '-80.00', null, null, null, null, null, null, null, null, 'Losij.company', null, null);
INSERT INTO `purchase_order` VALUES ('8e246537-9a01-4342-8548-095516661b03', '20170421016', '3', '8', '1', '1', '1', '2', '1', '2900.00', 'CNY', '1.0000', 'CNY', '12341234132412343124', '33', '李政鸿', null, '31', '2017-04-21 18:18:44', '2', '2', '36', '广州青春之旅', '陈好', '15626183941', 'zhaozi@162.com', '99950104', 'Chenhao', null, '1', '1', null, null, '[]', '0.00', 'CNY', '1', '1234', '231423', '1', 'の134123431241234', '1', '直减', '-100.00', null, null, '龙dais', '15830540321', null, null, null, null, '广州优游电子科技有限公司', null, '36');
INSERT INTO `purchase_order` VALUES ('96feee0d-554f-4569-963d-195418d6c6c9', 'SW-BS624', '3', '1', '1', '1', '1', '2', '2', '0.00', 'CNY', '0.0000', 'CNY', '111111111111111111111111111111111111111', '34', 'miniluo', null, '8', '2017-03-10 14:45:30', '1', '2', '7', '阿鸿日料公司', '李政鸿', '15807801125', '7529232761@qq.com', null, null, null, '1', '1', null, null, '[]', null, 'CNY', '1', '111111111111', '11111111111111111111111111111', '1', '111111111111111111111111111111', '1', '直减', '0.00', null, null, null, null, null, null, null, null, 'Losij.company', null, null);
INSERT INTO `purchase_order` VALUES ('979f237c-047b-11e7-a4a5-bc5ff4424ce6', 'string', '1', '1', '0', '1', '1', '0', '1', '0.00', 'CNY', '0.0000', 'CNY', 'string', '34', 'miniluo', null, '8', '2017-03-09 11:51:26', '1', '1', '0', '11234', 'string', 'string', 'string', 'string', 'string', 'string', '1', '1', '0', '1', '[{\"Money\":0.0,\"Date\":\"2017-03-09T02:59:15.171Z\"}]', '0.00', 'string', '1', 'string', 'string', '1', 'string', '1', 'string', '0.00', '2017-03-09 02:59:15', null, 'string', 'string', 'string', 'string', 'string', 'string', 'Losij.company', null, null);
INSERT INTO `purchase_order` VALUES ('9959f6d2-dc44-4d5b-ba6f-2f92c6f6d346', '20170421015', '3', '8', '1', '1', '1', '2', '1', '-100.00', 'CNY', '1.0000', 'CNY', '23412341234213412341234123', '33', '李政鸿', null, '31', '2017-04-21 18:06:30', '1', '2', '9', '肖司机车友会1', '谭凯文', '13710180709', null, null, null, null, '1', '1', null, null, '[]', '0.00', 'CNY', '1', '341234', '324123412341234123423423142', '1', '324123412342314', '1', '直减', '-100.00', null, null, '马琴', '15323301260', null, null, null, null, '广州优游电子科技有限公司', null, '115');
INSERT INTO `purchase_order` VALUES ('9d63a32d-04a2-11e7-a4a5-bc5ff4424ce6', 'SW-BS046', '3', '8', '0', '1', '1', '0', '2', '20592.00', 'CNY', '0.0000', 'CNY', null, '34', 'miniluo', null, '8', '2017-03-09 16:30:12', '1', '2', '7', '阿鸿日料公司', '李政鸿', '15807801125', '7529232761@qq.com', null, null, null, '1', '1', null, null, '[]', null, 'CNY', '3', null, null, '2', null, '1', '直减', '0.00', null, null, null, null, null, null, null, null, 'Losij.company', null, null);
INSERT INTO `purchase_order` VALUES ('a31d2da5-8e88-40b2-9a99-08c9800fc83f', 'SW-BS905', '3', '1', '0', '1', '1', '2', '2', '0.00', 'CNY', '1.0000', 'CNY', '22222222222222222222222222222', '34', 'miniluo', null, '8', '2017-03-16 17:56:22', '1', '2', '7', '阿鸿日料公司', '李政鸿', '15807801125', '7529232761@qq.com', null, null, null, '1', '1', null, null, '[]', null, 'CNY', '4', '2222222222', '222222222222222222222222222222222', '1', '222222222222222222222222222222222222222222222222222', '1', '直减', '0.00', null, null, null, null, null, null, null, null, 'Losij.company', null, null);
INSERT INTO `purchase_order` VALUES ('a447c8b4-04a4-11e7-a4a5-bc5ff4424ce6', 'SW-BS729', '3', '32', '0', '1', '1', '0', '2', '44.00', 'CNY', '0.0000', 'CNY', null, '34', 'miniluo', null, '8', '2017-03-09 16:45:21', '1', '2', '82', '香香假期', '范特西', '18316022518', '318729287@qq.com', null, null, '', '1', '1', null, null, '[]', null, 'CNY', '3', null, null, '2', null, '1', '直减', '0.00', null, null, null, null, null, null, null, null, 'Losij.company', null, null);
INSERT INTO `purchase_order` VALUES ('a76d2f4a-2b98-44f1-a33f-c72e375f67f0', 'SW-BS455', '3', '16', '1', '1024', '1', '0', '2', '0.00', 'CNY', '0.0000', 'CNY', '000000000000000000000000000000000000000000000', '34', 'miniluo', null, '8', '2017-03-10 12:20:50', '1', '2', '7', '阿鸿日料公司', '李政鸿', '15807801125', '7529232761@qq.com', null, null, null, '1', '1', null, null, '[]', '4666662468.00', 'CNY', '1', '000000000000', '000000000000000000', '1', '00000000000000000000000000000000000000000000000', '1', '直减', '0.00', null, null, null, null, null, null, null, null, 'Losij.company', null, null);
INSERT INTO `purchase_order` VALUES ('b0c9a82e-7fab-4b79-b801-a6c21176b158', '20170412017', '3', '1', '0', '1', '1', '2', '2', '26000.00', 'CNY', '1.0000', 'CNY', null, '34', 'miniluo', null, '8', '2017-04-12 14:52:59', '1', '2', '7', '阿鸿日料公司', '李政鸿', '15807801125', '7529232761@qq.com', null, null, null, '1', '1', null, null, '[]', '5200.00', 'CNY', '1', null, null, '1', null, '1', '直减', '-400.00', null, null, 'miniluo', '13660057286', null, null, null, null, 'Losij.company', null, null);
INSERT INTO `purchase_order` VALUES ('b224b76f-b3bd-442b-85bd-a185d69359b2', 'SW-BS219', '3', '128', '1', '2', '1', '2', '2', '100000.00', 'CNY', '1.0000', 'CNY', '222222222222222222222222222222', '34', 'miniluo', null, '8', '2017-03-15 20:59:47', '1', '2', '7', '阿鸿日料公司', '李政鸿', '15807801125', '7529232761@qq.com', null, null, null, '1', '2', null, null, '[]', '0.00', 'USD', '1', '222222222222', '22222222222', '1', '222222222222222222222', '1', '直减', '0.00', null, null, null, null, null, null, null, null, 'Losij.company', null, null);
INSERT INTO `purchase_order` VALUES ('b2e1f441-4fd1-40e4-bc4f-1290dfdc4332', 'SW-BS974', '3', '1', '1', '1024', '1', '0', '2', '49364936.00', 'CNY', '0.0000', 'CNY', null, '34', 'miniluo', null, '8', '2017-03-10 18:35:31', '1', '2', '7', '阿鸿日料公司', '李政鸿', '15807801125', '7529232761@qq.com', null, null, null, '1', '1', null, null, '[]', null, 'CNY', '1', 'ttt', null, '2', null, '1', '直减', '0.00', null, null, null, null, null, null, null, null, 'Losij.company', null, null);
INSERT INTO `purchase_order` VALUES ('b5014e68-9565-43d3-8341-f0cbf6c1d07a', 'SW-BS230', '3', '1', '1', '1', '1', '2', '2', '2514913449720.00', 'CNY', '0.0000', 'CNY', '3333333333333333333333333333333333333333333333333', '34', 'miniluo', null, '8', '2017-03-11 11:33:17', '1', '2', '7', '阿鸿日料公司', '李政鸿', '15807801125', '7529232761@qq.com', null, null, null, '1', '1', null, null, '[]', '502982689800.00', 'CNY', '1', '33333333333333', '33333333333333333333333333333333333333', '1', '3333333333333333333333333333333', '1', '直减', '-360.00', null, null, null, null, null, null, null, null, 'Losij.company', null, null);
INSERT INTO `purchase_order` VALUES ('b8817e97-124c-4efc-aeb0-be238e681633', 'SW-BS072', '3', '32', '1', '1', '1', '2', '2', '44.00', 'CNY', '0.0000', 'CNY', null, '34', 'miniluo', null, '8', '2017-03-09 18:55:36', '1', '2', '82', '香香假期', '范特西', '18316022518', '318729287@qq.com', null, null, '', '1', '1', null, null, '[]', null, 'CNY', '3', null, null, '2', null, '1', '直减', '0.00', null, null, null, null, null, null, null, null, 'Losij.company', null, null);
INSERT INTO `purchase_order` VALUES ('c00ca574-40f6-49e4-a4a5-2075a614fedf', 'SW-BS095', '3', '16', '0', '1', '1', '2', '2', '4975.00', 'CNY', '1.0000', 'CNY', '33333333333333333333333333333333333333333333333333', '34', 'miniluo', null, '8', '2017-03-16 12:20:31', '1', '2', '7', '阿鸿日料公司', '李政鸿', '15807801125', '7529232761@qq.com', null, null, null, '2', '3', null, null, '[]', '1990.00', 'CNY', '1', '33333333333333333333333333', '333333333333333333', '1', '33333333333333333333333333333333333333', '1', '直减', '0.00', null, null, null, null, null, null, null, null, 'Losij.company', null, null);
INSERT INTO `purchase_order` VALUES ('c283f096-67ec-40a1-86ab-6699d52cefe4', '20170412016', '3', '1', '0', '1', '1', '2', '2', '24680.00', 'CNY', '1.0000', 'CNY', null, '34', 'miniluo', null, '8', '2017-04-12 14:23:36', '1', '2', '7', '阿鸿日料公司', '李政鸿', '15807801125', '7529232761@qq.com', null, null, null, '1', '1', null, null, '[]', '4936.00', 'CNY', '1', null, null, '1', null, '1', '直减', '0.00', null, null, 'miniluo', '13660057286', null, null, null, null, 'Losij.company', null, null);
INSERT INTO `purchase_order` VALUES ('c78f4d7c-10da-4b6c-b068-3e3cd286eaff', '20170412021', '3', '1', '1', '1', '1', '2', '2', '10000.00', 'CNY', '1.0000', 'CNY', '12341234法撒旦飞洒地方士大夫', '34', 'miniluo', null, '8', '2017-04-12 17:39:31', '1', '2', '7', '阿鸿日料公司', '李政鸿', '15807801125', '7529232761@qq.com', null, null, null, '2', '2', null, null, '[]', '0.00', 'CNY', '1', '12341234', '123412341234', '1', '341324324', '1', '直减', '-8000.00', null, null, 'miniluo', '13660057286', null, null, null, null, 'Losij.company', null, null);
INSERT INTO `purchase_order` VALUES ('cae0f304-127c-40f2-a444-fc9d887cbf59', '20170330001', '3', '1', '1', '1', '1', '2', '1', '0.00', 'CNY', '1.0000', 'CNY', null, '34', 'miniluo', null, '8', '2017-03-30 12:33:07', '1', '2', '7', '阿鸿日料公司', '李政鸿', '15807801125', '7529232761@qq.com', null, null, null, '1', '1', null, null, '[]', null, null, '4', null, null, '2', null, '1', '直减', '0.00', null, null, null, null, null, null, null, null, 'Losij.company', null, null);
INSERT INTO `purchase_order` VALUES ('d160fc9f-336a-4b93-a43a-3ab921c23da6', 'SW-BS249', '3', '16', '1', '1', '1', '2', '2', '11000.00', 'CNY', '1.0000', 'CNY', null, '34', 'miniluo', null, '8', '2017-03-16 17:39:48', '1', '2', '7', '阿鸿日料公司', '李政鸿', '15807801125', '7529232761@qq.com', null, null, null, '1', '1', null, null, '[]', null, null, '4', null, null, '2', null, '1', '直减', '0.00', null, null, null, null, null, null, null, null, 'Losij.company', null, null);
INSERT INTO `purchase_order` VALUES ('d2b7ba67-70a6-406d-ba5d-a14b4e9e7580', '1703180007', '3', '8', '0', '1', '1', '2', '2', '50.00', 'CNY', '1.0000', 'CNY', '2222222222222222222222222222222222222222222222222', '31', '肖永俊', null, '31', '2017-03-18 16:40:38', '2', '2', '54', '广州市第三有限公司', '陈老师', '13433954986', null, null, null, null, '1', '1', null, null, '[]', '10.00', 'CNY', '1', '2', '2222222222222222222', '1', '2222222222222222222222222222222', '1', '直减', '0.00', null, null, null, null, null, null, null, null, '广州优游电子科技有限公司', null, null);
INSERT INTO `purchase_order` VALUES ('da5d3147-387d-44e7-96b7-d260647525bf', '20170420011', '3', '8', '1', '1', '1', '2', '1', '16450.00', 'CNY', '1.0000', 'CNY', '酷酷酷酷酷酷酷酷酷酷酷酷酷酷酷酷你你你你你你你你你你你你你你你你你你你', '33', '李政鸿', null, '31', '2017-04-20 16:32:26', '1', '2', '8', 'Losij.company', 'miniluo', '13660057286', null, null, null, null, '1', '1', null, null, '[]', '0.00', 'CNY', '1', '不不不不不不', '噢噢噢噢噢噢噢噢噢噢噢噢噢噢噢噢哦哦哦', '1', '哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈', '1', '直减', '-200.00', null, null, '李政鸿', '15807801125', null, null, null, null, '广州优游电子科技有限公司', null, '118');
INSERT INTO `purchase_order` VALUES ('e029d0ed-e067-4dd5-9fb8-da4cd87fc079', '20170410001', '3', '1', '0', '1', '1', '2', '2', '33000.00', 'HKD', '0.8900', 'CNY', 'ttttttttttttttttttttttttttttttttttt', '34', 'miniluo', null, '31', '2017-04-10 18:06:23', '2', '2', '93', '广州明明旅行社', '陈晓开', '13710190450', '123123@qq.com', '123123', '123123', null, '1', '1', null, null, '[]', '6600.00', 'CNY', '1', 'eee', 'tttttttttttttttttttttttttt', '1', 'eeeeeeee', '1', '直减', '-600.00', null, null, null, null, null, null, null, null, '广州优游电子科技有限公司', null, null);
INSERT INTO `purchase_order` VALUES ('e049c694-0488-11e7-a4a5-bc5ff4424ce6', 'SW-BS430', '3', '256', '1', '1024', '1', '0', '2', '0.00', 'CNY', '0.0000', 'CNY', '2222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222', '34', 'miniluo', null, '8', '2017-03-09 13:25:58', '1', '2', '7', '阿鸿日料公司', '李政鸿', '15807801125', '7529232761@qq.com', null, null, null, '1', '1', null, null, '[]', '123412341234.00', 'CNY', '1', '2222222222222', '222222222222222222', '1', '2222222222222222222222222222222222222222222222', '1', '直减', '0.00', null, null, null, null, null, null, null, null, 'Losij.company', null, null);
INSERT INTO `purchase_order` VALUES ('ea2c37df-23c1-4b68-89f3-68ae2004c7b5', '20170412020', '3', '1', '0', '1', '1', '2', '2', '20000.00', 'CNY', '1.0000', 'CNY', '213412341234444444444444444444444', '34', 'miniluo', null, '8', '2017-04-12 17:30:53', '1', '2', '31', '广州优游电子科技有限公司', '马琴', '15323301260', '8642405022qq.com', null, null, null, '1', '1', null, null, '[]', '6000.00', 'CNY', '1', '3241324', '12341234', '1', '3241432432423142', '1', '直减', '-4000.00', null, null, 'miniluo', '13660057286', null, null, null, null, 'Losij.company', null, null);
INSERT INTO `purchase_order` VALUES ('eb2342dd-2a41-4d97-a36b-63c434ec6446', '1703180005', '3', '8', '0', '1', '1', '2', '2', '100000.00', 'CNY', '1.0000', 'CNY', '22222222222222222222222222222222222', '31', '肖永俊', null, '31', '2017-03-18 16:26:30', '2', '2', '54', '广州市第三有限公司', '陈老师', '13433954986', null, null, null, null, '1', '1', null, null, '[]', '20000.00', 'CNY', '1', '2222', '222222222222222222222222222222222222222222222', '2', null, '1', '直减', '0.00', null, null, null, null, null, null, null, null, '广州优游电子科技有限公司', null, null);
INSERT INTO `purchase_order` VALUES ('edf7f2cd-163a-481a-826c-98f57dabd656', '1703180009', '3', '128', '0', '1', '1', '2', '2', '7000.00', 'CNY', '1.0000', 'CNY', '2222222222222222222222222222222222222222222', '31', '肖永俊', null, '31', '2017-03-18 18:08:05', '2', '2', '59', '香香假期', '徐梦龙', '18888888888', '18888888888@qq.com', '18888888888', '18888888888', null, '1', '1', null, null, '[]', '1400.00', 'CNY', '1', '222222222222', '2222222222222222222222222222222', '1', '2222222222222222222222222', '1', '直减', '-1000.00', null, null, null, null, null, null, null, null, '广州优游电子科技有限公司', null, null);
INSERT INTO `purchase_order` VALUES ('f379894e-543c-4138-abda-cb4facf6dce0', '20170412022', '3', '1', '0', '1', '1', '2', '2', '0.00', 'CNY', '1.0000', 'CNY', null, '34', 'miniluo', null, '8', '2017-04-12 18:31:22', '1', '2', '7', '阿鸿日料公司', '李政鸿', '15807801125', '7529232761@qq.com', null, null, null, '1', '1', null, null, '[]', '0.00', 'CNY', '4', null, null, '2', null, '1', '直减', '0.00', null, null, 'miniluo', '13660057286', null, null, null, null, 'Losij.company', null, null);
INSERT INTO `purchase_order` VALUES ('f37d6d35-1b61-4173-8715-b18704bcc4d9', '20170412025', '3', '1', '0', '1', '1', '2', '2', '27552.00', 'CNY', '1.0000', 'CNY', '2134123412341234234123412342314324', '34', 'miniluo', null, '8', '2017-04-12 18:47:28', '1', '2', '7', '阿鸿日料公司', '李政鸿', '15807801125', '7529232761@qq.com', null, null, null, '2', '1', null, null, '[]', '2300.00', 'CNY', '1', '234123412341', '234123412341234', '1', '142341234123412341', '1', '直减', '-80.00', null, null, 'miniluo', '13660057286', null, null, null, null, 'Losij.company', null, null);
INSERT INTO `purchase_order` VALUES ('fd2d2a12-c191-4c2c-86fd-2adc324008b9', '1703170005', '3', '16', '1', '2', '1', '2', '2', '1234.00', 'USD', '6.5000', 'CNY', '22222222222222222222222', '34', 'miniluo', null, '8', '2017-03-17 15:44:20', '2', '2', '59', '香香假期', '徐梦龙', '18888888888', '18888888888@qq.com', '18888888888', '18888888888', '', '1', '1', null, null, '[]', null, null, '1', '22222222', '2222222222222222222222', '1', '222222222222222222', '1', '直减', '0.00', null, null, null, null, null, null, null, null, 'Losij.company', null, null);

-- ----------------------------
-- Table structure for purchase_orderitem
-- ----------------------------
DROP TABLE IF EXISTS `purchase_orderitem`;
CREATE TABLE `purchase_orderitem` (
  `Id` char(36) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `Order_Id` char(36) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `ProductId` longtext,
  `ProductNumber` longtext,
  `PreProductId` longtext,
  `OriginProductId` longtext,
  `ProductName` longtext NOT NULL,
  `ProductItemId` longtext,
  `ProductImgPath` longtext,
  `ProductType` int(11) NOT NULL,
  `ItemName` longtext NOT NULL,
  `UnitPrice` decimal(18,2) NOT NULL,
  `UseTimeNote` longtext,
  `CurrencyCode` longtext NOT NULL,
  `Count` int(11) NOT NULL,
  `PriceConcession_ConcessionType` int(11) NOT NULL,
  `PriceConcession_ConcessionName` longtext,
  `PriceConcession_ConcessionNumber` decimal(18,2) NOT NULL,
  `TaxRate` decimal(18,2) NOT NULL,
  `CutOffTime` datetime DEFAULT NULL,
  `Note` longtext,
  `UserCreated_Id` bigint(20) NOT NULL,
  `UserCreated_FullName` longtext,
  `UserCreated_Phone` longtext,
  `UserCreated_AgencyId` bigint(20) DEFAULT NULL,
  `TimeCreated` datetime NOT NULL,
  `UserIdModified` bigint(20) NOT NULL,
  `TimeModified` datetime NOT NULL,
  `IsPriceItem` tinyint(1) NOT NULL,
  `UserCreated_AgencyName` longtext,
  `SupplierId` bigint(20) DEFAULT NULL,
  `SupplierName` longtext,
  `UseDates` longtext,
  `RequirementItem_Id` char(36) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Order_Id` (`Order_Id`) USING BTREE,
  KEY `IX_RequirementItem_Id` (`RequirementItem_Id`) USING HASH,
  CONSTRAINT `FK_01e17255155e44e294a18f7f0d5f1f12` FOREIGN KEY (`RequirementItem_Id`) REFERENCES `purchase_requirementitem` (`Id`),
  CONSTRAINT `Order_OrderItems` FOREIGN KEY (`Order_Id`) REFERENCES `purchase_order` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of purchase_orderitem
-- ----------------------------
INSERT INTO `purchase_orderitem` VALUES ('06ea785d-530b-4489-a9b5-eefd7a2f755d', '621ec11b-5ff2-4b0e-af2e-513ace614137', '0', null, null, null, '1234sdf', null, null, '16', '早餐', '3000.00', null, 'CNY', '11', '1', null, '0.00', '0.00', null, null, '34', 'miniluo', null, '8', '2017-03-15 20:24:08', '0', '2017-03-15 20:24:08', '1', 'Losij.company', null, null, '[]', null);
INSERT INTO `purchase_orderitem` VALUES ('0e719bf8-008a-4652-86de-4172c4d46a01', 'eb2342dd-2a41-4d97-a36b-63c434ec6446', '201703180001', null, null, null, '花园酒店', null, null, '8', '双床房', '10000.00', null, 'CNY', '10', '1', '直减', '0.00', '0.00', null, null, '31', '肖永俊', null, '31', '2017-03-18 16:26:30', '0', '2017-03-18 16:26:30', '1', '广州优游电子科技有限公司', null, null, '[\"2017-03-15T00:00:00\",\"2017-03-16T00:00:00\",\"2017-03-17T00:00:00\",\"2017-03-18T00:00:00\",\"2017-03-19T00:00:00\",\"2017-03-22T00:00:00\",\"2017-03-23T00:00:00\",\"2017-03-24T00:00:00\",\"2017-03-25T00:00:00\",\"2017-03-26T00:00:00\"]', null);
INSERT INTO `purchase_orderitem` VALUES ('11e577ce-48ed-46a3-92e6-af016949b45f', '9959f6d2-dc44-4d5b-ba6f-2f92c6f6d346', '30', null, null, null, '酒店-北戴河刘庄凤霞公寓-双床房', null, null, '8', '双床房', '100.00', null, 'CNY', '30', '1', '直减', '-5.00', '0.00', null, null, '33', '李政鸿', null, '31', '2017-04-21 18:06:30', '0', '2017-04-21 20:55:26', '1', '广州优游电子科技有限公司', '9', '肖司机车友会1', '[\"2017-04-06T00:00:00\",\"2017-04-07T00:00:00\",\"2017-04-08T00:00:00\",\"2017-04-09T00:00:00\"]', null);
INSERT INTO `purchase_orderitem` VALUES ('13bb4d08-497c-4cd5-bd19-79cc3767d67f', '823269d1-1c2f-446d-8aa1-9a48b480ed67', '0', null, null, null, '东风越野车请选择', null, null, '128', '轿车', '10000.00', null, 'CNY', '10', '1', null, '0.00', '0.00', null, null, '34', 'miniluo', null, '8', '2017-03-15 21:44:43', '0', '2017-03-15 21:44:43', '1', 'Losij.company', null, null, '[]', null);
INSERT INTO `purchase_orderitem` VALUES ('13f1affd-0483-11e7-a4a5-bc5ff4424ce6', '13eef91d-0483-11e7-a4a5-bc5ff4424ce6', '63', null, null, null, '4321', null, null, '2048', '火车', '1234.00', null, 'USD', '10', '1', '直减', '0.00', '6.50', null, null, '34', 'miniluo', null, '8', '2017-03-09 12:44:27', '0', '2017-03-09 12:44:27', '1', 'Losij.company', null, null, '[]', null);
INSERT INTO `purchase_orderitem` VALUES ('14eca4f5-d4ae-4ccf-ab34-be52c17b8fc3', '2949412b-52fa-4aa2-828b-ae02396d17aa', '30', null, null, null, '酒店-北戴河刘庄凤霞公寓-双床房', null, null, '8', '双床房', '100.00', null, 'CNY', '50', '1', '直减', '0.00', '0.00', null, null, '33', '李政鸿', null, '31', '2017-04-21 16:51:17', '0', '2017-04-21 16:51:17', '1', '广州优游电子科技有限公司', '9', '肖司机车友会1', '[\"2017-04-21T00:00:00\",\"2017-04-20T00:00:00\",\"2017-04-27T00:00:00\",\"2017-04-28T00:00:00\"]', null);
INSERT INTO `purchase_orderitem` VALUES ('14ecfead-0488-11e7-a4a5-bc5ff4424ce6', '14ea17a4-0488-11e7-a4a5-bc5ff4424ce6', '27', null, null, null, 'G121(北京南-上海虹桥)', null, null, '256', '二等座', '123412341234.00', null, 'CNY', '10', '1', '直减', '0.00', '1.00', null, null, '34', 'miniluo', null, '8', '2017-03-09 13:20:17', '0', '2017-03-09 13:20:17', '1', 'Losij.company', null, null, '[]', null);
INSERT INTO `purchase_orderitem` VALUES ('153f6573-82b9-44af-b6e7-f5e463ccbd02', '68a9d5b0-2c6a-44d4-aab5-a48decf1ed67', '0', null, null, null, '1234sdf', null, null, '16', '早餐', '10000000.00', null, 'CNY', '100', '1', null, '0.00', '0.00', null, null, '34', 'miniluo', null, '8', '2017-03-16 17:21:32', '0', '2017-03-16 17:21:32', '1', 'Losij.company', null, null, '[]', null);
INSERT INTO `purchase_orderitem` VALUES ('17729c21-b871-4ed9-bdf5-44f4bac76755', '71f9fd58-c00f-4c71-9862-efb830047556', '48', null, null, null, '自由行-正常diy-234', null, null, '1', '234', '1234.00', null, 'CNY', '30', '1', '直减', '-4.00', '0.00', null, null, '34', 'miniluo', null, '8', '2017-04-12 15:05:56', '0', '2017-04-12 15:05:56', '1', 'Losij.company', null, null, '[\"2017-04-04T00:00:00\",\"2017-04-06T00:00:00\",\"2017-04-05T00:00:00\",\"2017-04-12T00:00:00\"]', null);
INSERT INTO `purchase_orderitem` VALUES ('19e1b6ce-04a4-11e7-a4a5-bc5ff4424ce6', '19dc4141-04a4-11e7-a4a5-bc5ff4424ce6', '47', null, null, null, '莉莉精美珠宝店 （Lili Fine Jewellery）', null, null, '32', '人头费', '1.00', null, 'CNY', '22', '1', '直减', '0.00', '1.00', null, null, '34', 'miniluo', null, '8', '2017-03-09 16:41:25', '0', '2017-03-09 16:41:25', '1', 'Losij.company', null, null, '[]', null);
INSERT INTO `purchase_orderitem` VALUES ('2b3184c3-0d06-4623-a86b-ec37acedd98d', '1e95e56c-d290-43e0-8347-c88108d9f0ba', '26', null, null, null, '花园酒店', null, null, '8', '双床房', '200.00', null, 'CNY', '10', '1', '直减', '0.00', '0.00', null, null, '34', 'miniluo', null, '31', '2017-03-17 16:26:45', '0', '2017-03-17 16:26:45', '1', '广州优游电子科技有限公司', '32', '广州市电子有限公司', '[\"2017-03-16T00:00:00\",\"2017-03-15T00:00:00\",\"2017-03-14T00:00:00\",\"2017-03-13T00:00:00\",\"2017-03-17T00:00:00\",\"2017-03-24T00:00:00\",\"2017-03-23T00:00:00\",\"2017-03-22T00:00:00\",\"2017-03-21T00:00:00\",\"2017-03-20T00:00:00\"]', null);
INSERT INTO `purchase_orderitem` VALUES ('2c8b918d-b584-4016-aa61-654ec47c3a98', '96feee0d-554f-4569-963d-195418d6c6c9', '42', null, null, null, '正常diy', null, null, '1', '1234', '12341234.00', null, 'CNY', '22', '1', '直减', '0.00', '1.00', null, null, '34', 'miniluo', null, '8', '2017-03-10 14:45:30', '0', '2017-03-10 14:45:30', '1', 'Losij.company', '7', '阿鸿日料公司', '[]', null);
INSERT INTO `purchase_orderitem` VALUES ('2ca7377e-87b9-4fdf-9b08-883e64c3d5f1', 'ea2c37df-23c1-4b68-89f3-68ae2004c7b5', '48', null, null, null, '自由行-正常diy-234', null, null, '1', '234', '1234.00', null, 'CNY', '20', '1', '直减', '-34.00', '0.00', null, null, '34', 'miniluo', null, '8', '2017-04-12 17:30:53', '0', '2017-04-13 12:41:00', '1', 'Losij.company', null, null, '[\"2017-04-05T00:00:00\",\"2017-04-06T00:00:00\",\"2017-04-07T00:00:00\",\"2017-04-08T00:00:00\",\"2017-04-15T00:00:00\",\"2017-04-14T00:00:00\",\"2017-04-13T00:00:00\",\"2017-04-12T00:00:00\"]', null);
INSERT INTO `purchase_orderitem` VALUES ('2e9df690-c069-44da-a97c-c8eaebf52029', '67d8cf83-8381-43f8-b7ef-95e10ae3fe9f', '22', null, null, null, '1234sdf', null, null, '16', '早餐', '2333331234.00', null, 'CNY', '1', '1', '直减', '0.00', '0.00', null, null, '34', 'miniluo', null, '8', '2017-03-17 12:01:25', '0', '2017-03-17 12:01:25', '1', 'Losij.company', '7', '阿鸿日料公司', '[]', null);
INSERT INTO `purchase_orderitem` VALUES ('2f7a7144-ea26-4949-9108-58f6740159b7', '1d591ebc-0d32-4a24-9cb2-8761dd37c203', '30', null, null, null, '酒店-北戴河刘庄凤霞公寓-双床房', null, null, '8', '双床房', '100.00', null, 'CNY', '30', '1', '直减', '0.00', '0.00', null, null, '33', '李政鸿', null, '31', '2017-04-21 19:53:24', '0', '2017-04-21 19:53:24', '1', '广州优游电子科技有限公司', '9', '肖司机车友会1', '[\"2017-04-05T00:00:00\",\"2017-04-06T00:00:00\",\"2017-04-07T00:00:00\",\"2017-04-14T00:00:00\",\"2017-04-13T00:00:00\"]', null);
INSERT INTO `purchase_orderitem` VALUES ('38d73419-c7b6-4d98-82e2-7d06360a6e7f', 'c283f096-67ec-40a1-86ab-6699d52cefe4', '48', null, null, null, '自由行-正常diy-234', null, null, '1', '234', '1234.00', null, 'CNY', '20', '1', '直减', '0.00', '0.00', null, null, '34', 'miniluo', null, '8', '2017-04-12 14:23:37', '0', '2017-04-12 14:23:37', '1', 'Losij.company', null, null, '[\"2017-04-06T00:00:00\",\"2017-04-07T00:00:00\"]', null);
INSERT INTO `purchase_orderitem` VALUES ('3c55e220-99de-413c-9de4-c9cb7f80e763', '11085284-38e0-4a80-8c6b-da29efa7bf3e', '201703180001', null, null, null, '花园酒店', null, null, '8', '双床房', '1000.00', null, 'CNY', '2', '1', '直减', '0.00', '0.00', null, null, '31', '肖永俊', null, '31', '2017-03-18 16:35:10', '0', '2017-03-18 16:35:10', '1', '广州优游电子科技有限公司', null, null, '[\"2017-03-15T00:00:00\",\"2017-03-16T00:00:00\",\"2017-03-17T00:00:00\",\"2017-03-18T00:00:00\",\"2017-03-19T00:00:00\",\"2017-03-22T00:00:00\",\"2017-03-23T00:00:00\",\"2017-03-24T00:00:00\",\"2017-03-25T00:00:00\",\"2017-03-26T00:00:00\"]', null);
INSERT INTO `purchase_orderitem` VALUES ('3f0a5378-a534-4f2d-96a6-4b4f518092f1', '7fda9c85-75d7-4c7a-a380-2ec68eb22152', '0', null, null, null, '东风越野车请选择', null, null, '128', '轿车', '10000.00', null, 'CNY', '10', '1', null, '0.00', '0.00', null, null, '34', 'miniluo', null, '8', '2017-03-15 21:34:47', '0', '2017-03-15 21:34:47', '1', 'Losij.company', null, null, '[]', null);
INSERT INTO `purchase_orderitem` VALUES ('4567f537-dea7-4673-a4a5-31b253499d4a', '40f98529-3000-4947-8328-a10ec30fd0b1', '21', null, null, null, '餐饮-羌山红农家乐-早餐', null, null, '16', '早餐', '1234.00', null, 'USD', '10', '1', '直减', '0.00', '0.00', null, null, '33', '李政鸿', null, '31', '2017-04-21 16:54:30', '0', '2017-04-21 16:54:30', '1', '广州优游电子科技有限公司', null, null, '[]', null);
INSERT INTO `purchase_orderitem` VALUES ('4e0580ff-f5bc-4abd-9f30-28932a30e37f', 'b2e1f441-4fd1-40e4-bc4f-1290dfdc4332', '42', null, null, null, '正常diy', null, null, '1', '1234', '12341234.00', null, 'CNY', '2', '1', '直减', '0.00', '1.00', null, null, '34', 'miniluo', null, '8', '2017-03-10 18:35:31', '0', '2017-03-10 18:35:31', '1', 'Losij.company', '7', '阿鸿日料公司', '[]', null);
INSERT INTO `purchase_orderitem` VALUES ('5476b2e5-b500-4cfd-a08e-17ad089e382d', 'c78f4d7c-10da-4b6c-b068-3e3cd286eaff', '48', null, null, null, '自由行-正常diy-234', null, null, '1', '234', '1234.00', null, 'CNY', '15', '1', '直减', '-34.00', '0.00', null, null, '34', 'miniluo', null, '8', '2017-04-12 17:39:32', '0', '2017-04-13 12:40:26', '1', 'Losij.company', null, null, '[\"2017-04-04T00:00:00\",\"2017-04-05T00:00:00\",\"2017-04-06T00:00:00\",\"2017-04-07T00:00:00\",\"2017-04-08T00:00:00\",\"2017-04-15T00:00:00\",\"2017-04-14T00:00:00\",\"2017-04-13T00:00:00\",\"2017-04-12T00:00:00\",\"2017-04-11T00:00:00\"]', null);
INSERT INTO `purchase_orderitem` VALUES ('56161a46-ba2e-408b-a397-5d7edc0bf5fe', 'fd2d2a12-c191-4c2c-86fd-2adc324008b9', '21', null, null, null, '羌山红农家乐', null, null, '16', '早餐', '1234.00', null, 'USD', '1', '1', '直减', '0.00', '0.00', null, null, '34', 'miniluo', null, '8', '2017-03-17 15:44:21', '0', '2017-03-27 16:18:00', '1', 'Losij.company', null, null, '[]', null);
INSERT INTO `purchase_orderitem` VALUES ('59a41806-ead1-46a5-bd55-2d87f506ba0d', '621ec11b-5ff2-4b0e-af2e-513ace614137', '0', null, null, null, '1234sdf', null, null, '16', '早餐', '80000.00', null, 'CNY', '11', '1', null, '0.00', '0.00', null, null, '34', 'miniluo', null, '8', '2017-03-15 20:24:08', '0', '2017-03-15 20:24:08', '1', 'Losij.company', null, null, '[]', null);
INSERT INTO `purchase_orderitem` VALUES ('5c03ec2b-0c0f-436e-a019-547ae49eaca4', '2c24a0d2-7e30-4a8a-8e96-855d25d75516', '48', null, null, null, '自由行-正常diy-234', null, null, '1', '234', '1234.00', null, 'CNY', '20', '1', '直减', '0.00', '0.00', null, null, '34', 'miniluo', null, '8', '2017-04-12 15:00:47', '0', '2017-04-12 15:00:47', '1', 'Losij.company', null, null, '[\"2017-03-29T00:00:00\",\"2017-04-05T00:00:00\",\"2017-04-12T00:00:00\",\"2017-04-19T00:00:00\"]', null);
INSERT INTO `purchase_orderitem` VALUES ('5d821e01-3071-42df-9d21-7bd3421af798', 'a76d2f4a-2b98-44f1-a33f-c72e375f67f0', '22', null, null, null, '1234sdf', null, null, '16', '早餐', '2333331234.00', null, 'CNY', '10', '1', '直减', '0.00', '1.00', null, null, '34', 'miniluo', null, '8', '2017-03-10 12:20:50', '0', '2017-03-10 12:20:50', '1', 'Losij.company', '7', '阿鸿日料公司', '[]', null);
INSERT INTO `purchase_orderitem` VALUES ('6a3e8064-5dd0-49d1-800e-8f0a40adebfd', '05db3a53-b8c8-4b6b-af8a-850373f9348d', '0', null, null, null, '东风越野车请选择', null, null, '128', '轿车', '10000.00', null, 'CNY', '10', '1', null, '0.00', '0.00', null, null, '34', 'miniluo', null, '8', '2017-03-15 21:33:12', '0', '2017-03-15 21:33:12', '1', 'Losij.company', null, null, '[]', null);
INSERT INTO `purchase_orderitem` VALUES ('735db58f-e752-4c21-8904-4a931fb10b14', 'd2b7ba67-70a6-406d-ba5d-a14b4e9e7580', '201703180001', null, null, null, '花园酒店', null, null, '8', '双床房', '10.00', null, 'CNY', '5', '1', '直减', '0.00', '0.00', null, null, '31', '肖永俊', null, '31', '2017-03-18 16:40:39', '0', '2017-03-18 16:40:39', '1', '广州优游电子科技有限公司', null, null, '[\"2017-03-15T00:00:00\",\"2017-03-16T00:00:00\",\"2017-03-17T00:00:00\",\"2017-03-18T00:00:00\",\"2017-03-19T00:00:00\",\"2017-03-22T00:00:00\",\"2017-03-23T00:00:00\",\"2017-03-24T00:00:00\",\"2017-03-25T00:00:00\",\"2017-03-26T00:00:00\"]', '37ff6d13-7167-46de-a58b-39404e3d1785');
INSERT INTO `purchase_orderitem` VALUES ('7c93b35d-04a3-11e7-a4a5-bc5ff4424ce6', '7c9316e9-04a3-11e7-a4a5-bc5ff4424ce6', '17', null, null, null, '咀香园饼家(大三巴店)', null, null, '32', '人头费', '0.00', null, 'CNY', '22', '1', '直减', '0.00', '0.00', null, null, '34', 'miniluo', null, '8', '2017-03-09 16:36:27', '0', '2017-03-09 16:36:27', '1', 'Losij.company', null, null, '[]', null);
INSERT INTO `purchase_orderitem` VALUES ('7cb485dd-1ac2-4047-8752-ebd2ba0ea741', 'da5d3147-387d-44e7-96b7-d260647525bf', '26', null, null, null, '酒店-花园酒店-双床房', null, null, '8', '双床房', '200.00', null, 'CNY', '20', '1', '直减', '-5.00', '0.00', null, null, '33', '李政鸿', null, '31', '2017-04-21 21:18:41', '0', '2017-04-21 21:18:41', '1', '广州优游电子科技有限公司', '32', '广州市电子有限公司', '[\"2017-04-19T00:00:00\",\"2017-04-20T00:00:00\",\"2017-04-21T00:00:00\"]', null);
INSERT INTO `purchase_orderitem` VALUES ('7ea48b85-ba61-47de-84a7-ddb756762723', 'b8817e97-124c-4efc-aeb0-be238e681633', '47', null, null, null, '莉莉精美珠宝店 （Lili Fine Jewellery）', null, null, '32', '人头费', '1.00', null, 'CNY', '22', '1', '直减', '0.00', '1.00', null, null, '34', 'miniluo', null, '8', '2017-03-09 18:55:36', '0', '2017-03-09 18:55:36', '1', 'Losij.company', null, null, '[]', null);
INSERT INTO `purchase_orderitem` VALUES ('814a6bd7-8db3-4a3e-8b3a-6ec5eac5a445', '86afec35-e2d2-4817-a33b-f591a3d2cf46', '46', null, null, null, '线路-134-1234', null, null, '2', '1234', '1234.00', null, 'EUR', '20', '1', '直减', '0.00', '0.00', null, null, '33', '李政鸿', null, '31', '2017-04-21 21:11:15', '0', '2017-04-21 21:11:15', '1', '广州优游电子科技有限公司', '103', '广州明道旅行社', '[\"2017-04-12T00:00:00\",\"2017-04-13T00:00:00\",\"2017-04-14T00:00:00\",\"2017-04-21T00:00:00\",\"2017-04-20T00:00:00\",\"2017-04-19T00:00:00\"]', null);
INSERT INTO `purchase_orderitem` VALUES ('8754f3ff-1e2b-4bb6-be57-2487ba2efa96', '86f59acb-c545-4f72-9552-b4f96cdf68ce', '46', null, null, null, '线路-134-1234', null, null, '2', '1234', '1234.00', null, 'EUR', '10', '1', '直减', '0.00', '0.00', null, null, '33', '李政鸿', null, '31', '2017-04-21 16:45:23', '0', '2017-04-21 16:45:23', '1', '广州优游电子科技有限公司', '103', '广州明道旅行社', '[]', null);
INSERT INTO `purchase_orderitem` VALUES ('894a27e8-5615-4190-9b1f-31fed0f47f4c', '8e246537-9a01-4342-8548-095516661b03', '30', null, null, null, '酒店-北戴河刘庄凤霞公寓-双床房', null, null, '8', '双床房', '100.00', null, 'CNY', '30', '1', '直减', '0.00', '0.00', null, null, '33', '李政鸿', null, '31', '2017-04-21 18:18:45', '0', '2017-04-21 18:18:45', '1', '广州优游电子科技有限公司', '9', '肖司机车友会1', '[\"2017-04-04T00:00:00\",\"2017-04-05T00:00:00\",\"2017-04-06T00:00:00\",\"2017-04-13T00:00:00\",\"2017-04-12T00:00:00\",\"2017-04-11T00:00:00\"]', null);
INSERT INTO `purchase_orderitem` VALUES ('8b81da5c-0481-11e7-a4a5-bc5ff4424ce6', '8b8144b8-0481-11e7-a4a5-bc5ff4424ce6', '25', null, null, null, '白云山大酒店', null, null, '8', '双床房', '468.00', null, 'CNY', '10', '1', '直减', '0.00', '1.00', null, null, '34', 'miniluo', null, '8', '2017-03-09 12:33:30', '0', '2017-03-09 12:33:30', '1', 'Losij.company', '7', '阿鸿日料公司', '[]', null);
INSERT INTO `purchase_orderitem` VALUES ('8f21778f-f3fb-44ce-a2d6-12aaedf85458', 'b0c9a82e-7fab-4b79-b801-a6c21176b158', '48', null, null, null, '自由行-正常diy-234', null, null, '1', '234', '1234.00', null, 'CNY', '22', '1', '直减', '-34.00', '0.00', null, null, '34', 'miniluo', null, '8', '2017-04-12 14:52:59', '0', '2017-04-12 14:52:59', '1', 'Losij.company', null, null, '[]', null);
INSERT INTO `purchase_orderitem` VALUES ('8fba3241-d86f-4928-9a75-879d612c5bb0', '2949412b-52fa-4aa2-828b-ae02396d17aa', '30', null, null, null, '酒店-北戴河刘庄凤霞公寓-双床房', null, null, '8', '双床房', '100.00', null, 'CNY', '30', '1', '直减', '0.00', '0.00', null, null, '33', '李政鸿', null, '31', '2017-04-21 16:51:16', '0', '2017-04-21 16:51:16', '1', '广州优游电子科技有限公司', '9', '肖司机车友会1', '[\"2017-04-06T00:00:00\",\"2017-04-07T00:00:00\",\"2017-04-08T00:00:00\",\"2017-04-15T00:00:00\",\"2017-04-14T00:00:00\",\"2017-04-12T00:00:00\",\"2017-04-13T00:00:00\"]', null);
INSERT INTO `purchase_orderitem` VALUES ('9413d53c-1759-46aa-8bd3-c123cec70e12', '04cafd16-1417-48e9-882a-43096c48b782', '0', null, null, null, '东风越野车请选择', null, null, '128', '轿车', '10000.00', null, 'CNY', '10', '1', null, '0.00', '0.00', null, null, '34', 'miniluo', null, '8', '2017-03-15 21:46:24', '0', '2017-03-15 21:46:24', '1', 'Losij.company', null, null, '[]', null);
INSERT INTO `purchase_orderitem` VALUES ('97ad1bad-047b-11e7-a4a5-bc5ff4424ce6', '979f237c-047b-11e7-a4a5-bc5ff4424ce6', 'string', 'string', 'string', 'string', 'string', 'string', 'string', '1', 'string', '0.00', 'string', 'CNY', '1', '1', 'string', '0.00', '0.00', '2017-03-09 02:59:15', 'string', '34', 'miniluo', 'string', '8', '2017-03-09 11:51:26', '0', '2017-03-09 11:51:26', '1', 'Losij.company', '0', 'string', '[\"2017-03-09T02:59:15.183Z\"]', null);
INSERT INTO `purchase_orderitem` VALUES ('9ab68028-027f-4f15-aaa0-43121ab04313', '390062d5-25e7-44d2-9f21-6279aa2de9ac', '48', null, null, null, '自由行-正常diy-234', null, null, '1', '234', '1234.00', null, 'CNY', '10', '1', '直减', '-4.00', '0.00', null, null, '34', 'miniluo', null, '8', '2017-04-13 11:59:33', '0', '2017-04-13 11:59:33', '1', 'Losij.company', null, null, '[\"2017-04-06T00:00:00\",\"2017-04-07T00:00:00\",\"2017-04-08T00:00:00\",\"2017-04-15T00:00:00\"]', null);
INSERT INTO `purchase_orderitem` VALUES ('9d6683fb-04a2-11e7-a4a5-bc5ff4424ce6', '9d63a32d-04a2-11e7-a4a5-bc5ff4424ce6', '25', null, null, null, '白云山大酒店', null, null, '8', '双床房', '468.00', null, 'CNY', '22', '1', '直减', '0.00', '1.00', null, null, '34', 'miniluo', null, '8', '2017-03-09 16:30:12', '0', '2017-03-09 16:30:12', '1', 'Losij.company', '7', '阿鸿日料公司', '[]', null);
INSERT INTO `purchase_orderitem` VALUES ('a1c5c601-e24c-4c19-821d-7cde684e18e1', '67d8cf83-8381-43f8-b7ef-95e10ae3fe9f', '25', null, null, null, '白云山大酒店', null, null, '8', '双床房', '468.00', null, 'CNY', '100', '1', '直减', '-8.00', '0.00', null, null, '34', 'miniluo', null, '8', '2017-03-17 12:12:47', '0', '2017-03-17 12:12:47', '1', 'Losij.company', '7', '阿鸿日料公司', '[\"2017-03-09T00:00:00\",\"2017-03-10T00:00:00\",\"2017-03-11T00:00:00\",\"2017-03-18T00:00:00\",\"2017-03-17T00:00:00\",\"2017-03-16T00:00:00\"]', null);
INSERT INTO `purchase_orderitem` VALUES ('a448d48b-04a4-11e7-a4a5-bc5ff4424ce6', 'a447c8b4-04a4-11e7-a4a5-bc5ff4424ce6', '47', null, null, null, '莉莉精美珠宝店 （Lili Fine Jewellery）', null, null, '32', '人头费', '1.00', null, 'CNY', '22', '1', '直减', '0.00', '1.00', null, null, '34', 'miniluo', null, '8', '2017-03-09 16:45:21', '0', '2017-03-09 16:45:21', '1', 'Losij.company', null, null, '[]', null);
INSERT INTO `purchase_orderitem` VALUES ('aa742386-4db3-42e2-a256-3bbba8708810', 'e029d0ed-e067-4dd5-9fb8-da4cd87fc079', '45', null, null, null, '1234', null, null, '1', '1234', '11234.00', null, 'HKD', '3', '1', '直减', '-34.00', '0.00', null, null, '34', 'miniluo', null, '31', '2017-04-10 18:06:24', '0', '2017-04-10 18:06:24', '1', '广州优游电子科技有限公司', '32', '广州市电子有限公司', '[]', null);
INSERT INTO `purchase_orderitem` VALUES ('af06299d-1def-4ace-990a-5817549a8f53', '390062d5-25e7-44d2-9f21-6279aa2de9ac', 'XQ-ON523', null, null, null, '1234sdf', null, null, '16', '早餐', '30.00', null, 'CNY', '20', '1', '直减', '0.00', '0.00', null, null, '34', 'miniluo', null, '8', '2017-04-13 11:59:33', '0', '2017-04-21 15:24:02', '1', 'Losij.company', null, null, '[\"2017-03-09T00:00:00\",\"2017-03-10T00:00:00\",\"2017-03-11T00:00:00\",\"2017-03-12T00:00:00\",\"2017-03-15T00:00:00\",\"2017-03-16T00:00:00\",\"2017-03-17T00:00:00\",\"2017-03-18T00:00:00\"]', '153f6573-82b9-44af-b6e7-f5e463ccbd02');
INSERT INTO `purchase_orderitem` VALUES ('ba119fd8-ed47-4561-a027-2ed9e4314635', 'b224b76f-b3bd-442b-85bd-a185d69359b2', '0', null, null, null, '东风越野车请选择', null, null, '128', '轿车', '10000.00', null, 'CNY', '10', '1', null, '0.00', '0.00', null, null, '34', 'miniluo', null, '8', '2017-03-15 20:59:47', '0', '2017-03-15 20:59:47', '1', 'Losij.company', null, null, '[]', null);
INSERT INTO `purchase_orderitem` VALUES ('bad08e44-bb4c-42f3-bff0-30eab7d39ea9', 'd160fc9f-336a-4b93-a43a-3ab921c23da6', '0', null, null, null, '1234sdf', null, null, '16', '早餐', '1000.00', null, 'CNY', '11', '1', '直减', '0.00', '0.00', null, null, '34', 'miniluo', null, '8', '2017-03-16 17:39:48', '0', '2017-04-10 15:43:48', '1', 'Losij.company', null, null, '[]', null);
INSERT INTO `purchase_orderitem` VALUES ('bfa48e2f-c4aa-4596-b544-168553500d49', 'edf7f2cd-163a-481a-826c-98f57dabd656', '1703180004', null, null, null, '东风轿车4座', null, null, '128', '轿车', '4000.00', null, 'CNY', '2', '1', '直减', '0.00', '0.00', null, null, '31', '肖永俊', null, '31', '2017-03-18 18:08:06', '0', '2017-03-18 18:08:06', '1', '广州优游电子科技有限公司', null, null, '[\"2017-03-07T00:00:00\",\"2017-03-08T00:00:00\",\"2017-03-09T00:00:00\",\"2017-03-10T00:00:00\",\"2017-03-11T00:00:00\",\"2017-03-22T00:00:00\",\"2017-03-23T00:00:00\"]', '60644375-8bd1-4cd2-bdb1-bf026ee34058');
INSERT INTO `purchase_orderitem` VALUES ('bff21ecb-429d-4cbb-8991-5f4a6aefb03e', 'da5d3147-387d-44e7-96b7-d260647525bf', '26', null, null, null, '酒店-花园酒店-双床房', null, null, '8', '双床房', '200.00', null, 'CNY', '50', '1', '直减', '-5.00', '0.00', null, null, '33', '李政鸿', null, '31', '2017-04-21 21:18:41', '0', '2017-04-21 21:18:41', '1', '广州优游电子科技有限公司', '32', '广州市电子有限公司', '[\"2017-04-19T00:00:00\",\"2017-04-20T00:00:00\",\"2017-04-21T00:00:00\"]', null);
INSERT INTO `purchase_orderitem` VALUES ('c0dd1f31-5fc8-4211-9f21-ad17d9353432', '78fa473a-13fe-4be9-9f2a-fe10cb0f2b68', '48', null, null, null, '自由行-正常diy-234', null, null, '1', '234', '1234.00', null, 'CNY', '50', '1', '直减', '-34.00', '0.00', null, null, '34', 'miniluo', null, '8', '2017-04-12 20:34:34', '0', '2017-04-21 15:34:07', '1', 'Losij.company', null, null, '[\"2001-01-01T00:00:00\"]', null);
INSERT INTO `purchase_orderitem` VALUES ('c8dc55fb-e4ea-45d0-8334-fbedf079ef47', '9959f6d2-dc44-4d5b-ba6f-2f92c6f6d346', '30', null, null, null, '酒店-北戴河刘庄凤霞公寓-双床房', null, null, '8', '双床房', '100.00', null, 'CNY', '30', '1', '直减', '5.00', '0.00', null, null, '33', '李政鸿', null, '31', '2017-04-21 18:06:30', '0', '2017-04-21 20:55:37', '1', '广州优游电子科技有限公司', '9', '肖司机车友会1', '[\"2017-04-13T00:00:00\",\"2017-04-12T00:00:00\",\"2017-04-20T00:00:00\",\"2017-04-19T00:00:00\",\"2017-04-26T00:00:00\",\"2017-04-27T00:00:00\"]', null);
INSERT INTO `purchase_orderitem` VALUES ('d669c37f-50df-4497-a871-44d6b99ce4ae', 'f37d6d35-1b61-4173-8715-b18704bcc4d9', '48', null, null, null, '自由行-正常diy-234', null, null, '1', '234', '1234.00', null, 'CNY', '22', '1', '直减', '22.00', '0.00', null, null, '34', 'miniluo', null, '8', '2017-04-12 18:47:28', '0', '2017-04-12 18:47:28', '1', 'Losij.company', null, null, '[]', null);
INSERT INTO `purchase_orderitem` VALUES ('d66cc950-0ffa-469e-b555-1b633db0c8c8', '390062d5-25e7-44d2-9f21-6279aa2de9ac', '17', null, null, null, '购物点-咀香园饼家(大三巴店)-人头费', null, null, '32', '人头费', '0.00', null, 'CNY', '11', '1', '直减', '0.00', '0.00', null, null, '34', 'miniluo', null, '8', '2017-04-21 15:26:01', '0', '2017-04-21 15:26:01', '1', 'Losij.company', '7', '阿鸿日料公司', '[]', null);
INSERT INTO `purchase_orderitem` VALUES ('d82495dc-4886-45b2-b3d6-8d34901c69ac', 'c00ca574-40f6-49e4-a4a5-2075a614fedf', '0', null, null, null, '1234sdf', null, null, '16', '早餐', '1000.00', null, 'CNY', '5', '1', '直减', '-5.00', '0.00', null, null, '34', 'miniluo', null, '8', '2017-03-16 12:20:31', '0', '2017-03-16 12:20:31', '1', 'Losij.company', null, null, '[]', null);
INSERT INTO `purchase_orderitem` VALUES ('d972de9f-d953-4a65-811a-3bd17048c158', '67fff56e-98a4-4ab0-97dd-344b70a94c9b', '1703180003', null, null, null, '东风轿车4座', null, null, '128', '轿车', '6000.00', null, 'CNY', '5', '1', '直减', '0.00', '0.00', null, null, '31', '肖永俊', null, '31', '2017-03-18 18:09:41', '0', '2017-03-18 18:09:41', '1', '广州优游电子科技有限公司', null, null, '[\"2017-03-14T00:00:00\",\"2017-03-15T00:00:00\",\"2017-03-16T00:00:00\",\"2017-03-17T00:00:00\",\"2017-03-22T00:00:00\",\"2017-03-23T00:00:00\",\"2017-03-24T00:00:00\"]', '95c19bed-0911-48c0-a7f8-6d031d123c65');
INSERT INTO `purchase_orderitem` VALUES ('deb0a82a-ed9b-4f6f-89a1-ee9433824292', '46b2088c-106b-4523-b6aa-1a84cfaff2f1', '1703180003', null, null, null, '花园酒店', null, null, '8', '双床房', '10000.00', null, 'CNY', '5', '1', '直减', '0.00', '0.00', null, null, '31', '肖永俊', null, '31', '2017-03-18 18:03:15', '0', '2017-03-18 18:03:15', '1', '广州优游电子科技有限公司', null, null, '[\"2017-03-08T00:00:00\",\"2017-03-09T00:00:00\",\"2017-03-10T00:00:00\",\"2017-03-15T00:00:00\",\"2017-03-16T00:00:00\",\"2017-03-17T00:00:00\"]', '4ac7b5f8-de90-4fef-99a1-d86dc8c401f8');
INSERT INTO `purchase_orderitem` VALUES ('e04a5fed-0488-11e7-a4a5-bc5ff4424ce6', 'e049c694-0488-11e7-a4a5-bc5ff4424ce6', '27', null, null, null, 'G121(北京南-上海虹桥)', null, null, '256', '二等座', '123412341234.00', null, 'CNY', '10', '1', '直减', '0.00', '1.00', null, null, '34', 'miniluo', null, '8', '2017-03-09 13:25:58', '0', '2017-03-09 13:25:58', '1', 'Losij.company', null, null, '[]', null);
INSERT INTO `purchase_orderitem` VALUES ('e3238e84-49aa-4429-a1b9-09ba7c90d113', '6c51d1ed-6267-44b3-8c23-ae45fcf461e8', '42', null, null, null, '正常diy', null, null, '1', '1234', '12341234.00', null, 'CNY', '2', '1', '直减', '0.00', '1.00', null, null, '34', 'miniluo', null, '8', '2017-03-10 12:19:27', '0', '2017-03-10 12:19:27', '1', 'Losij.company', '7', '阿鸿日料公司', '[]', null);
INSERT INTO `purchase_orderitem` VALUES ('e6a308c4-f0e1-45e6-b05d-e225b2d98477', 'da5d3147-387d-44e7-96b7-d260647525bf', '30', null, null, null, '酒店-北戴河刘庄凤霞公寓-双床房', null, null, '8', '双床房', '100.00', null, 'CNY', '30', '1', '直减', '0.00', '0.00', null, null, '33', '李政鸿', null, '31', '2017-04-20 16:32:26', '0', '2017-04-20 16:32:26', '1', '广州优游电子科技有限公司', '9', '肖司机车友会1', '[\"2017-04-18T00:00:00\",\"2017-04-20T00:00:00\",\"2017-04-21T00:00:00\",\"2017-04-19T00:00:00\",\"2017-04-27T00:00:00\"]', null);
INSERT INTO `purchase_orderitem` VALUES ('f0d35049-6565-480f-8c9e-465ddeb00cf4', 'b5014e68-9565-43d3-8341-f0cbf6c1d07a', '27', null, null, null, 'G121(北京南-上海虹桥)', null, null, '256', '二等座', '123412341234.00', null, 'CNY', '20', '1', '直减', '0.00', '0.00', null, null, '34', 'miniluo', null, '8', '2017-03-11 11:33:17', '0', '2017-03-11 11:33:17', '1', 'Losij.company', null, null, '[]', null);
INSERT INTO `purchase_orderitem` VALUES ('f37470eb-eed6-4cb1-ba91-61432603efb9', 'b5014e68-9565-43d3-8341-f0cbf6c1d07a', '22', null, null, null, '1234sdf', null, null, '16', '早餐', '2333331234.00', null, 'CNY', '20', '1', '直减', '0.00', '0.00', null, null, '34', 'miniluo', null, '8', '2017-03-11 11:33:17', '0', '2017-03-11 11:33:17', '1', 'Losij.company', '7', '阿鸿日料公司', '[]', null);
INSERT INTO `purchase_orderitem` VALUES ('f8696bce-9116-493c-970f-c6ab3ae34058', '11b2bcdf-b26f-4adb-8cd0-08fc6b2b0881', '27', null, null, null, 'G121(北京南-上海虹桥)', null, null, '256', '二等座', '123412341234.00', null, 'CNY', '10', '1', '直减', '0.00', '0.00', null, null, '34', 'miniluo', null, '8', '2017-03-10 19:43:17', '0', '2017-03-10 19:43:17', '1', 'Losij.company', null, null, '[]', null);

-- ----------------------------
-- Table structure for purchase_orderitem_tourist
-- ----------------------------
DROP TABLE IF EXISTS `purchase_orderitem_tourist`;
CREATE TABLE `purchase_orderitem_tourist` (
  `OrderItemId` char(36) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `TouristId` char(36) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  PRIMARY KEY (`OrderItemId`,`TouristId`),
  KEY `OrderItem_Tourists_Target` (`TouristId`),
  CONSTRAINT `OrderItem_Tourists_Source` FOREIGN KEY (`OrderItemId`) REFERENCES `purchase_orderitem` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT `OrderItem_Tourists_Target` FOREIGN KEY (`TouristId`) REFERENCES `purchase_order_tourist` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of purchase_orderitem_tourist
-- ----------------------------

-- ----------------------------
-- Table structure for purchase_order_attachment
-- ----------------------------
DROP TABLE IF EXISTS `purchase_order_attachment`;
CREATE TABLE `purchase_order_attachment` (
  `Id` char(36) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `OrderId` char(36) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `FileName` longtext,
  `DownloadUrl` longtext NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `OrderId` (`OrderId`),
  CONSTRAINT `Order_Attachments` FOREIGN KEY (`OrderId`) REFERENCES `purchase_order` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of purchase_order_attachment
-- ----------------------------

-- ----------------------------
-- Table structure for purchase_order_operationlog
-- ----------------------------
DROP TABLE IF EXISTS `purchase_order_operationlog`;
CREATE TABLE `purchase_order_operationlog` (
  `Id` char(36) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `OrderId` char(36) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `OperationType` int(11) NOT NULL,
  `Message` longtext,
  `OperatedTime` datetime NOT NULL,
  `OperatedUser_Id` bigint(20) NOT NULL,
  `OperatedUser_FullName` longtext,
  `OperatedUser_Phone` longtext,
  `OperatedUser_AgencyId` bigint(20) DEFAULT NULL,
  `OperatedUser_AgencyName` longtext,
  PRIMARY KEY (`Id`),
  KEY `OrderId` (`OrderId`),
  CONSTRAINT `Order_OperationLogs` FOREIGN KEY (`OrderId`) REFERENCES `purchase_order` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of purchase_order_operationlog
-- ----------------------------

-- ----------------------------
-- Table structure for purchase_order_refund
-- ----------------------------
DROP TABLE IF EXISTS `purchase_order_refund`;
CREATE TABLE `purchase_order_refund` (
  `Id` char(36) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `RefundNumber` longtext NOT NULL,
  `RefundMoney` decimal(18,2) NOT NULL,
  `UserCreated_Id` bigint(20) NOT NULL,
  `UserCreated_FullName` longtext,
  `UserCreated_Phone` longtext,
  `UserCreated_AgencyId` bigint(20) DEFAULT NULL,
  `TimeCreated` datetime NOT NULL,
  `Note` longtext,
  `VerificationState` int(11) NOT NULL,
  `RefundBusinessState` int(11) NOT NULL,
  `Order_Id` char(36) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `UserCreated_AgencyName` longtext,
  PRIMARY KEY (`Id`),
  KEY `IX_Refund_Order_Id` (`Order_Id`) USING BTREE,
  CONSTRAINT `FK_Refund_Order_Id` FOREIGN KEY (`Order_Id`) REFERENCES `purchase_order` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of purchase_order_refund
-- ----------------------------
INSERT INTO `purchase_order_refund` VALUES ('0b7150b5-aaf6-43fd-a880-1a15b47e56da', '1703200006', '0.00', '34', 'miniluo', null, '8', '2017-03-20 18:43:28', '3333333333', '2', '8', '621ec11b-5ff2-4b0e-af2e-513ace614137', 'Losij.company');
INSERT INTO `purchase_order_refund` VALUES ('12d2a52c-620a-4469-b3f4-59f1115b766f', '1703210004', '0.00', '34', 'miniluo', null, '8', '2017-03-21 20:48:47', '3333333333', '2', '512', '621ec11b-5ff2-4b0e-af2e-513ace614137', 'Losij.company');
INSERT INTO `purchase_order_refund` VALUES ('3d47d676-9838-41a0-89e9-e6425a849962', '20170420007', '0.00', '34', 'miniluo', null, '8', '2017-04-20 21:18:57', null, '2', '512', '11b2bcdf-b26f-4adb-8cd0-08fc6b2b0881', 'Losij.company');
INSERT INTO `purchase_order_refund` VALUES ('6298372c-0ec6-4547-b36b-dffb8fcec8a1', '20170419001', '33000.00', '34', 'miniluo', null, '8', '2017-04-19 20:17:31', '3333333333', '2', '16', '621ec11b-5ff2-4b0e-af2e-513ace614137', 'Losij.company');
INSERT INTO `purchase_order_refund` VALUES ('641c0362-3c02-484d-8e81-a4b05f6e8997', '1703210005', '0.00', '34', 'miniluo', null, '8', '2017-03-21 20:54:36', '3333333333', '2', '512', '621ec11b-5ff2-4b0e-af2e-513ace614137', 'Losij.company');
INSERT INTO `purchase_order_refund` VALUES ('6ef138bd-1d3a-40d1-9ea0-b8e6decbdf15', '1703210006', '83000.00', '34', 'miniluo', null, '8', '2017-03-21 20:59:53', '3333333333', '2', '512', '621ec11b-5ff2-4b0e-af2e-513ace614137', 'Losij.company');
INSERT INTO `purchase_order_refund` VALUES ('8d1a3f99-7f21-4d4c-ac58-0168bd2c8149', '20170420006', '0.00', '34', 'miniluo', null, '8', '2017-04-20 21:16:21', null, '2', '512', '11b2bcdf-b26f-4adb-8cd0-08fc6b2b0881', 'Losij.company');
INSERT INTO `purchase_order_refund` VALUES ('a2bd2ead-66b2-405f-a3e1-7855049e2d64', '20170420009', '0.00', '34', 'miniluo', null, '8', '2017-04-20 22:51:43', null, '2', '512', '11b2bcdf-b26f-4adb-8cd0-08fc6b2b0881', 'Losij.company');
INSERT INTO `purchase_order_refund` VALUES ('af849185-cd97-463b-8e8f-b66c2e9e8c1f', '20170420008', '0.00', '34', 'miniluo', null, '8', '2017-04-20 21:21:08', null, '2', '512', '11b2bcdf-b26f-4adb-8cd0-08fc6b2b0881', 'Losij.company');
INSERT INTO `purchase_order_refund` VALUES ('c8416517-d234-461a-aab8-047d867d186c', '1703210003', '0.00', '34', 'miniluo', null, '8', '2017-03-21 20:46:56', '3333333333', '2', '512', '621ec11b-5ff2-4b0e-af2e-513ace614137', 'Losij.company');

-- ----------------------------
-- Table structure for purchase_order_refunditem
-- ----------------------------
DROP TABLE IF EXISTS `purchase_order_refunditem`;
CREATE TABLE `purchase_order_refunditem` (
  `Id` char(36) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `RefundId` char(36) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `RefundCount` int(11) NOT NULL,
  `OrderItem_Id` char(36) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `RefundId` (`RefundId`),
  KEY `IX_OrderItem_Id` (`OrderItem_Id`) USING BTREE,
  CONSTRAINT `RefundItem_OrderItem` FOREIGN KEY (`OrderItem_Id`) REFERENCES `purchase_orderitem` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT `Refund_RefundItems` FOREIGN KEY (`RefundId`) REFERENCES `purchase_order_refund` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of purchase_order_refunditem
-- ----------------------------
INSERT INTO `purchase_order_refunditem` VALUES ('017e8321-87de-4ddf-be8f-b4f8c5c2c6e6', 'c8416517-d234-461a-aab8-047d867d186c', '2', '06ea785d-530b-4489-a9b5-eefd7a2f755d');
INSERT INTO `purchase_order_refunditem` VALUES ('423415aa-bc23-4eee-b430-d85e3f5d3060', '6ef138bd-1d3a-40d1-9ea0-b8e6decbdf15', '1', '06ea785d-530b-4489-a9b5-eefd7a2f755d');
INSERT INTO `purchase_order_refunditem` VALUES ('56a05583-ab46-4b7b-87a5-16f99814c30e', '641c0362-3c02-484d-8e81-a4b05f6e8997', '1', '59a41806-ead1-46a5-bd55-2d87f506ba0d');
INSERT INTO `purchase_order_refunditem` VALUES ('668b871f-7042-4964-a1a4-9500ce93faff', 'c8416517-d234-461a-aab8-047d867d186c', '2', '59a41806-ead1-46a5-bd55-2d87f506ba0d');
INSERT INTO `purchase_order_refunditem` VALUES ('6f968efd-039a-467f-96cb-87f201806ad3', '12d2a52c-620a-4469-b3f4-59f1115b766f', '1', '06ea785d-530b-4489-a9b5-eefd7a2f755d');
INSERT INTO `purchase_order_refunditem` VALUES ('afd87b59-366d-4e73-bf5f-7b5f3603f1c0', '0b7150b5-aaf6-43fd-a880-1a15b47e56da', '10', '06ea785d-530b-4489-a9b5-eefd7a2f755d');
INSERT INTO `purchase_order_refunditem` VALUES ('dfc74078-d592-42e0-bf15-9744e1124cd8', '0b7150b5-aaf6-43fd-a880-1a15b47e56da', '10', '59a41806-ead1-46a5-bd55-2d87f506ba0d');
INSERT INTO `purchase_order_refunditem` VALUES ('e1991a3a-66f9-4263-ac7e-c1d06cd2fca1', '641c0362-3c02-484d-8e81-a4b05f6e8997', '1', '06ea785d-530b-4489-a9b5-eefd7a2f755d');
INSERT INTO `purchase_order_refunditem` VALUES ('e51d5649-a3e7-4fed-a2d0-81892df89fbf', '6ef138bd-1d3a-40d1-9ea0-b8e6decbdf15', '1', '59a41806-ead1-46a5-bd55-2d87f506ba0d');
INSERT INTO `purchase_order_refunditem` VALUES ('ec0582b8-992b-4a8f-997e-82e6f95d6233', '12d2a52c-620a-4469-b3f4-59f1115b766f', '1', '59a41806-ead1-46a5-bd55-2d87f506ba0d');

-- ----------------------------
-- Table structure for purchase_order_tourist
-- ----------------------------
DROP TABLE IF EXISTS `purchase_order_tourist`;
CREATE TABLE `purchase_order_tourist` (
  `Id` char(36) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `OrderId` char(36) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `Sex` int(11) NOT NULL,
  `TouristType` int(11) NOT NULL,
  `IdCard` longtext,
  `Passport` longtext,
  `Phone` longtext,
  `Email` longtext,
  `FullName` longtext NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `OrderId` (`OrderId`),
  CONSTRAINT `Order_Tourists` FOREIGN KEY (`OrderId`) REFERENCES `purchase_order` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of purchase_order_tourist
-- ----------------------------
INSERT INTO `purchase_order_tourist` VALUES ('0097e4c1-03f1-4158-982f-a55679b2c299', 'c283f096-67ec-40a1-86ab-6699d52cefe4', '1', '1', '3241234', '12341234', '123412', '341234', '324132');
INSERT INTO `purchase_order_tourist` VALUES ('13f2235a-0483-11e7-a4a5-bc5ff4424ce6', '13eef91d-0483-11e7-a4a5-bc5ff4424ce6', '2', '1', '441781199210108416', 'ED343433', '13456321245', '132343@qq.com', '刘亦菲');
INSERT INTO `purchase_order_tourist` VALUES ('140722c6-0483-11e7-a4a5-bc5ff4424ce6', '13eef91d-0483-11e7-a4a5-bc5ff4424ce6', '2', '1', '441781199210108416', 'ED343433', '13456321245', '132343@qq.com', '刘亦菲');
INSERT INTO `purchase_order_tourist` VALUES ('14bde4f6-4fa6-4d5c-bb6e-d57b91e30d93', '6c51d1ed-6267-44b3-8c23-ae45fcf461e8', '2', '1', '441781199210108416', 'ED343433', '13456321245', '132343@qq.com', '刘亦菲');
INSERT INTO `purchase_order_tourist` VALUES ('14e20c5c-3a0a-4661-861c-e2ebc3822a6c', 'f37d6d35-1b61-4173-8715-b18704bcc4d9', '1', '1', '2341234', '1234', '12341234', '1234', '324132');
INSERT INTO `purchase_order_tourist` VALUES ('216aeba2-e37a-4f1c-9a5e-1debae497a8f', '05db3a53-b8c8-4b6b-af8a-850373f9348d', '2', '1', '441781199210108416', 'ED343433', '13456321245', '132343@qq.com', '刘亦菲');
INSERT INTO `purchase_order_tourist` VALUES ('2ce6ff3f-b042-48c9-b46a-0256830dd238', 'b2e1f441-4fd1-40e4-bc4f-1290dfdc4332', '2', '1', '441781199210108416', 'ED343433', '13456321245', '132343@qq.com', '刘亦菲');
INSERT INTO `purchase_order_tourist` VALUES ('35522257-6286-4e86-a42f-4d2ef96143ce', '46b2088c-106b-4523-b6aa-1a84cfaff2f1', '1', '1', '441781199202108416', 'ED43287', '13570316109', null, '李政宏');
INSERT INTO `purchase_order_tourist` VALUES ('377922ab-9228-44e8-b6df-04d43f185a6c', 'c00ca574-40f6-49e4-a4a5-2075a614fedf', '2', '1', '441781199210108416', 'ED343433', '13456321245', '132343@qq.com', '刘亦菲');
INSERT INTO `purchase_order_tourist` VALUES ('444d5477-0306-4739-87a5-101fa54b322a', '96feee0d-554f-4569-963d-195418d6c6c9', '1', '1', '441781199210108416', 'ED343433', '13456321245', '132343@qq.com', '肖司机');
INSERT INTO `purchase_order_tourist` VALUES ('456c97bd-c09d-4acc-b065-0b9b9353a7ff', 'b224b76f-b3bd-442b-85bd-a185d69359b2', '2', '1', '441781199210108416', 'ED343433', '13456321245', '132343@qq.com', '刘亦菲');
INSERT INTO `purchase_order_tourist` VALUES ('498852b7-f3ef-4fe4-958b-09ef3d21ff18', 'c78f4d7c-10da-4b6c-b068-3e3cd286eaff', '1', '1', '24123412', '341234', '123412', '34123412', '343243');
INSERT INTO `purchase_order_tourist` VALUES ('4c34aa16-f255-4d60-8948-bf5c5a4e64e2', '78fa473a-13fe-4be9-9f2a-fe10cb0f2b68', '1', '1', '1234123', '41234', '21342134', '123412342314', '3双人舞');
INSERT INTO `purchase_order_tourist` VALUES ('4d70d644-cc96-4f35-86b0-cbb536d9667e', 'a31d2da5-8e88-40b2-9a99-08c9800fc83f', '2', '1', '441781199210108416', 'ED343433', '13456321245', '132343@qq.com', '刘亦菲');
INSERT INTO `purchase_order_tourist` VALUES ('52f64b21-d420-454b-8968-11bd118c3060', '67d8cf83-8381-43f8-b7ef-95e10ae3fe9f', '1', '1', '441781199202108415', 'ED22222', '13570316109', null, '李征鸿');
INSERT INTO `purchase_order_tourist` VALUES ('55a5e5f1-a5f1-4766-a604-ff90f489fd14', 'd160fc9f-336a-4b93-a43a-3ab921c23da6', '2', '1', '441781199210108416', 'ED343433', '13456321245', '132343@qq.com', '刘亦菲');
INSERT INTO `purchase_order_tourist` VALUES ('569613a9-ee05-4879-83be-d431edceea61', '11b2bcdf-b26f-4adb-8cd0-08fc6b2b0881', '2', '1', '441781199210108416', 'ED343433', '13456321245', '132343@qq.com', '刘亦菲');
INSERT INTO `purchase_order_tourist` VALUES ('5b995301-066a-4d39-95b0-ae50325c933d', '86f59acb-c545-4f72-9552-b4f96cdf68ce', '1', '1', '341234', '12341234', '12342134', '12341234', '341324');
INSERT INTO `purchase_order_tourist` VALUES ('6d3065f0-f7ce-47fc-be58-04f3c56d06c8', 'a76d2f4a-2b98-44f1-a33f-c72e375f67f0', '2', '1', '441781199210108416', 'ED343433', '13456321245', '132343@qq.com', '刘亦菲');
INSERT INTO `purchase_order_tourist` VALUES ('7c44c8d9-87e1-4ecc-a1dd-8e49b954c419', '67fff56e-98a4-4ab0-97dd-344b70a94c9b', '1', '1', '441781199202108416', 'ED43287', '13570316109', null, '李政宏');
INSERT INTO `purchase_order_tourist` VALUES ('7d960a4f-13f1-471e-804e-3f8807d7a519', 'edf7f2cd-163a-481a-826c-98f57dabd656', '1', '1', '441781199202108416', 'ED43287', '13570316109', null, '李政宏');
INSERT INTO `purchase_order_tourist` VALUES ('841faa8c-e0eb-40d8-8ff1-e6b9739312a2', '71f9fd58-c00f-4c71-9862-efb830047556', '1', '1', '3241234', '12341', '23412341', '234123412', '2341321');
INSERT INTO `purchase_order_tourist` VALUES ('87e8d1ef-8119-4c84-bda6-43802a43bc86', '390062d5-25e7-44d2-9f21-6279aa2de9ac', '1', '1', '1324', '324123', '2341', '123413', '32413');
INSERT INTO `purchase_order_tourist` VALUES ('88816a37-069b-4fcc-9070-48db19a79317', '78fa473a-13fe-4be9-9f2a-fe10cb0f2b68', '1', '1', '1234132', '41234', '12341234', '1234', '3243124');
INSERT INTO `purchase_order_tourist` VALUES ('89359366-7439-4d24-9887-201e3301028a', '04cafd16-1417-48e9-882a-43096c48b782', '2', '1', '441781199210108416', 'ED343433', '13456321245', '132343@qq.com', '刘亦菲');
INSERT INTO `purchase_order_tourist` VALUES ('8b8262e2-0481-11e7-a4a5-bc5ff4424ce6', '8b8144b8-0481-11e7-a4a5-bc5ff4424ce6', '1', '5', '441781199210108416', 'ED343433', '13456321245', '132343@qq.com', '里');
INSERT INTO `purchase_order_tourist` VALUES ('96e62c6b-b6c3-4791-9969-723792a1fc8e', '2949412b-52fa-4aa2-828b-ae02396d17aa', '1', '1', '452345', '523453', '52345', '234523', '4353');
INSERT INTO `purchase_order_tourist` VALUES ('9a8fc1f5-477e-4ea2-8c8b-6c2a103a743e', 'd2b7ba67-70a6-406d-ba5d-a14b4e9e7580', '1', '1', '441781199202108416', 'ED43287', '13570316109', null, '李政宏');
INSERT INTO `purchase_order_tourist` VALUES ('9b01d58e-b52e-4327-9d36-bf647c3e6c5d', '1e95e56c-d290-43e0-8347-c88108d9f0ba', '2', '1', '441781199202108416', 'Ed34132', null, null, '李政宏');
INSERT INTO `purchase_order_tourist` VALUES ('9fe2087a-0492-11e7-a4a5-bc5ff4424ce6', '8b8144b8-0481-11e7-a4a5-bc5ff4424ce6', '2', '1', '441781199210108416', 'ED343433', '13456321245', '132343@qq.com', '刘亦菲');
INSERT INTO `purchase_order_tourist` VALUES ('a3b9aad2-739c-48c6-bd23-e1d753791266', '823269d1-1c2f-446d-8aa1-9a48b480ed67', '2', '1', '441781199210108416', 'ED343433', '13456321245', '132343@qq.com', '刘亦菲');
INSERT INTO `purchase_order_tourist` VALUES ('a4bd33b9-ce93-4c90-8920-4f03bfbca9c9', 'b5014e68-9565-43d3-8341-f0cbf6c1d07a', '1', '1', '441781199210108416', 'ED343433', '13456321245', '132343@qq.com', '刘亦菲');
INSERT INTO `purchase_order_tourist` VALUES ('b1065d2a-9e64-49d2-97b6-c5e04ccfc6dc', '7fda9c85-75d7-4c7a-a380-2ec68eb22152', '2', '1', '441781199210108416', 'ED343433', '13456321245', '132343@qq.com', '刘亦菲');
INSERT INTO `purchase_order_tourist` VALUES ('b35d78bb-8e21-423b-b3f6-df557c32c38f', '68a9d5b0-2c6a-44d4-aab5-a48decf1ed67', '2', '1', '441781199210108416', 'ED343433', '13456321245', '132343@qq.com', '刘亦菲');
INSERT INTO `purchase_order_tourist` VALUES ('b3c237ac-cbca-44c1-b847-bf7ff937b95e', 'b2e1f441-4fd1-40e4-bc4f-1290dfdc4332', '2', '1', '441781199210108416', 'ED343433', '13456321245', '132343@qq.com', '刘亦菲1');
INSERT INTO `purchase_order_tourist` VALUES ('bde2b22b-9389-4a1c-baf7-c196348d3804', 'b5014e68-9565-43d3-8341-f0cbf6c1d07a', '2', '1', '441781199210108416', 'ED343433', '13456321245', '132343@qq.com', '刘亦菲');
INSERT INTO `purchase_order_tourist` VALUES ('be07852e-c532-4cf0-ba33-5959e02210e9', '05db3a53-b8c8-4b6b-af8a-850373f9348d', '2', '1', '441781199210108416', 'ED343433', '13456321245', '132343@qq.com', '刘亦菲');
INSERT INTO `purchase_order_tourist` VALUES ('c33eca0d-4834-431b-bc3b-2be9ab7ebca5', '621ec11b-5ff2-4b0e-af2e-513ace614137', '2', '1', '441781199210108416', 'ED343433', '13456321245', '132343@qq.com', '刘亦菲');
INSERT INTO `purchase_order_tourist` VALUES ('d4256a8e-308b-4862-98c8-72166a1cb09a', 'da5d3147-387d-44e7-96b7-d260647525bf', '1', '1', '41234', '3241234', '132434', '1234', '324324');
INSERT INTO `purchase_order_tourist` VALUES ('e036033c-7f7f-4685-ade3-fe19401a4b6a', 'fd2d2a12-c191-4c2c-86fd-2adc324008b9', '2', '1', '441781199210108416', 'ED343433', '13456321245', '132343@qq.com', '刘亦菲');
INSERT INTO `purchase_order_tourist` VALUES ('e04ae9db-0488-11e7-a4a5-bc5ff4424ce6', 'e049c694-0488-11e7-a4a5-bc5ff4424ce6', '2', '1', '441781199210108416', 'ED343433', '13456321245', '132343@qq.com', '李');
INSERT INTO `purchase_order_tourist` VALUES ('e39ec028-052b-43e0-8999-c3de0c4e405d', '40f98529-3000-4947-8328-a10ec30fd0b1', '1', '1', '341234', '1234123', '41234234', '12341234123', '31423');
INSERT INTO `purchase_order_tourist` VALUES ('e88bee8c-2740-401e-9084-3efe7c7990b9', '78fa473a-13fe-4be9-9f2a-fe10cb0f2b68', '1', '1', '341324', '1241233', '41234', '1234', '地方');
INSERT INTO `purchase_order_tourist` VALUES ('ef22d94f-daee-4fbd-a5ab-d27853b124d1', 'b0c9a82e-7fab-4b79-b801-a6c21176b158', '1', '1', '12341234', '2341234', '123412', '341234', '341234');
INSERT INTO `purchase_order_tourist` VALUES ('f3e6a42f-3717-4cda-b7b0-3ff24c75e14c', '9959f6d2-dc44-4d5b-ba6f-2f92c6f6d346', '1', '1', '412341', '3241', '12341234', '12341234', '13241');
INSERT INTO `purchase_order_tourist` VALUES ('f9a0fba9-ad50-4b84-8444-e8c6f4c7dc90', '11085284-38e0-4a80-8c6b-da29efa7bf3e', '1', '1', '441781199202108416', 'ED43287', '13570316109', null, '李政宏');

-- ----------------------------
-- Table structure for purchase_refund_tourist
-- ----------------------------
DROP TABLE IF EXISTS `purchase_refund_tourist`;
CREATE TABLE `purchase_refund_tourist` (
  `RefundId` char(36) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `TouristId` char(36) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  PRIMARY KEY (`RefundId`,`TouristId`),
  KEY `Refund_Tourists_Target` (`TouristId`),
  CONSTRAINT `Refund_Tourists_Source` FOREIGN KEY (`RefundId`) REFERENCES `purchase_order_refund` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT `Refund_Tourists_Target` FOREIGN KEY (`TouristId`) REFERENCES `purchase_order_tourist` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of purchase_refund_tourist
-- ----------------------------
INSERT INTO `purchase_refund_tourist` VALUES ('3d47d676-9838-41a0-89e9-e6425a849962', '569613a9-ee05-4879-83be-d431edceea61');
INSERT INTO `purchase_refund_tourist` VALUES ('8d1a3f99-7f21-4d4c-ac58-0168bd2c8149', '569613a9-ee05-4879-83be-d431edceea61');
INSERT INTO `purchase_refund_tourist` VALUES ('a2bd2ead-66b2-405f-a3e1-7855049e2d64', '569613a9-ee05-4879-83be-d431edceea61');
INSERT INTO `purchase_refund_tourist` VALUES ('af849185-cd97-463b-8e8f-b66c2e9e8c1f', '569613a9-ee05-4879-83be-d431edceea61');
INSERT INTO `purchase_refund_tourist` VALUES ('641c0362-3c02-484d-8e81-a4b05f6e8997', 'c33eca0d-4834-431b-bc3b-2be9ab7ebca5');
INSERT INTO `purchase_refund_tourist` VALUES ('6ef138bd-1d3a-40d1-9ea0-b8e6decbdf15', 'c33eca0d-4834-431b-bc3b-2be9ab7ebca5');
INSERT INTO `purchase_refund_tourist` VALUES ('c8416517-d234-461a-aab8-047d867d186c', 'c33eca0d-4834-431b-bc3b-2be9ab7ebca5');

-- ----------------------------
-- Table structure for purchase_requirement
-- ----------------------------
DROP TABLE IF EXISTS `purchase_requirement`;
CREATE TABLE `purchase_requirement` (
  `Id` char(36) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL DEFAULT '',
  `RequirementNumber` longtext NOT NULL,
  `ResName` longtext NOT NULL,
  `Note` longtext,
  `TimeCreated` datetime NOT NULL,
  `UserCreated_Id` bigint(20) NOT NULL,
  `UserCreated_FullName` longtext,
  `UserCreated_Phone` longtext,
  `UserCreated_AgencyId` bigint(20) DEFAULT NULL,
  `UserCreated_AgencyName` longtext,
  `RequirementSource` int(11) NOT NULL,
  `BizSourceId` longtext,
  `VerificationState` int(11) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of purchase_requirement
-- ----------------------------
INSERT INTO `purchase_requirement` VALUES ('076b091c-d163-4cc6-85a4-8511e9b3ef67', '1703180003', '花园酒店,东风轿车4座,羌山红农家乐', '333333333333', '2017-03-18 17:27:29', '31', '肖永俊', null, '31', '广州优游电子科技有限公司', '1', null, '2');
INSERT INTO `purchase_requirement` VALUES ('0c1b8562-0bdb-4a17-9a37-c39de1dca83b', '1703180002', '花园酒店', null, '2017-03-18 17:26:36', '31', '肖永俊', null, '31', '广州优游电子科技有限公司', '1', null, '2');
INSERT INTO `purchase_requirement` VALUES ('354f61dd-a225-4f38-a771-876272e75f6c', '201703180001', '花园酒店', '22222222222222222222222222222222222222222222222222222222222222222', '2017-03-18 15:55:47', '31', '肖永俊', null, '31', '广州优游电子科技有限公司', '1', null, '2');
INSERT INTO `purchase_requirement` VALUES ('6637b092-0c1c-43b5-accd-72d938b54859', '1703170003', '白云山大酒店', '哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈', '2017-03-17 15:28:42', '34', 'miniluo', null, '8', 'Losij.company', '1', null, '2');
INSERT INTO `purchase_requirement` VALUES ('7d9dd40e-3393-4719-9ffd-48ae4e5c2742', 'XQ-ON523', '1234sdf,雪山梁,东风越野车请选择,东风越野车请选择,白云山大酒店,咀香园饼家(大三巴店),普兰国际市场', '哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈你你你你你你你你你你你你你你你你你你你咩咩咩咩咩咩咩咩咩咩咩咩咩咩咩咩咩咩吗', '2017-03-15 10:30:42', '34', 'miniluo', null, '8', 'Losij.company', '1', null, '2');
INSERT INTO `purchase_requirement` VALUES ('863cda15-a1ed-4410-a193-911d9bbf3dac', '20170414001', '正常diy', null, '2017-04-14 00:41:11', '34', 'miniluo', null, '8', 'Losij.company', '1', null, '2');
INSERT INTO `purchase_requirement` VALUES ('e3c9c2f4-95ee-493b-99b3-05857a5cfbae', '1703180004', '东风轿车4座', '你你你你你你你你你你你你你你你你你你你', '2017-03-18 18:07:17', '31', '肖永俊', null, '31', '广州优游电子科技有限公司', '1', null, '2');
INSERT INTO `purchase_requirement` VALUES ('e6325d33-56e3-4276-aee3-d6153434dc32', '1703170004', '白云山大酒店', '哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈', '2017-03-17 15:30:25', '34', 'miniluo', null, '8', 'Losij.company', '1', null, '2');

-- ----------------------------
-- Table structure for purchase_requirementitem
-- ----------------------------
DROP TABLE IF EXISTS `purchase_requirementitem`;
CREATE TABLE `purchase_requirementitem` (
  `Id` char(36) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL DEFAULT '',
  `ProductType` int(11) NOT NULL,
  `ResId` bigint(20) NOT NULL,
  `ResName` longtext NOT NULL,
  `StandardName` longtext NOT NULL,
  `Count` int(11) NOT NULL,
  `StartDate` datetime NOT NULL,
  `EndDate` datetime NOT NULL,
  `Requirement_Id` char(36) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL DEFAULT '',
  `UseDates` longtext,
  `DoingCount` int(11) NOT NULL,
  `DoneCount` int(11) NOT NULL,
  `BadCount` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Requirement_Id` (`Requirement_Id`) USING HASH,
  CONSTRAINT `FK_0bb7a76c56234674801caf5601aa3eb3` FOREIGN KEY (`Requirement_Id`) REFERENCES `purchase_requirement` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of purchase_requirementitem
-- ----------------------------
INSERT INTO `purchase_requirementitem` VALUES ('074a61ed-ef26-49d6-88cc-ec1014c0c289', '8', '0', '花园酒店', '单床房', '200', '2017-03-14 00:00:00', '2017-03-30 00:00:00', '0c1b8562-0bdb-4a17-9a37-c39de1dca83b', '[\"2017-03-14T00:00:00\",\"2017-03-15T00:00:00\",\"2017-03-21T00:00:00\",\"2017-03-22T00:00:00\",\"2017-03-28T00:00:00\",\"2017-03-29T00:00:00\",\"2017-03-30T00:00:00\"]', '0', '0', '0');
INSERT INTO `purchase_requirementitem` VALUES ('153f6573-82b9-44af-b6e7-f5e463ccbd02', '16', '0', '1234sdf', '早餐', '20', '2017-03-09 00:00:00', '2017-03-18 00:00:00', '7d9dd40e-3393-4719-9ffd-48ae4e5c2742', '[\"2017-03-09T00:00:00\",\"2017-03-10T00:00:00\",\"2017-03-11T00:00:00\",\"2017-03-12T00:00:00\",\"2017-03-15T00:00:00\",\"2017-03-16T00:00:00\",\"2017-03-17T00:00:00\",\"2017-03-18T00:00:00\"]', '20', '0', '0');
INSERT INTO `purchase_requirementitem` VALUES ('37ff6d13-7167-46de-a58b-39404e3d1785', '8', '0', '花园酒店', '双床房', '10', '2017-03-15 00:00:00', '2017-03-26 00:00:00', '354f61dd-a225-4f38-a771-876272e75f6c', '[\"2017-03-15T00:00:00\",\"2017-03-16T00:00:00\",\"2017-03-17T00:00:00\",\"2017-03-18T00:00:00\",\"2017-03-19T00:00:00\",\"2017-03-22T00:00:00\",\"2017-03-23T00:00:00\",\"2017-03-24T00:00:00\",\"2017-03-25T00:00:00\",\"2017-03-26T00:00:00\"]', '5', '0', '0');
INSERT INTO `purchase_requirementitem` VALUES ('42104f8d-a45f-4d32-87a4-a6ff2e8ab1a5', '8', '0', '白云山大酒店', '双床房', '30', '2017-03-07 00:00:00', '2017-04-05 00:00:00', '7d9dd40e-3393-4719-9ffd-48ae4e5c2742', '[\"2017-03-07T00:00:00\",\"2017-03-08T00:00:00\",\"2017-03-14T00:00:00\",\"2017-03-15T00:00:00\",\"2017-03-21T00:00:00\",\"2017-03-22T00:00:00\",\"2017-03-28T00:00:00\",\"2017-03-29T00:00:00\",\"2017-04-04T00:00:00\",\"2017-04-05T00:00:00\"]', '0', '0', '0');
INSERT INTO `purchase_requirementitem` VALUES ('469b5e51-cd25-4a76-bcd2-47392de6f08d', '8', '0', '白云山大酒店', '双床房', '10', '2017-03-14 00:00:00', '2017-03-17 00:00:00', 'e6325d33-56e3-4276-aee3-d6153434dc32', '[\"2017-03-14T00:00:00\",\"2017-03-15T00:00:00\",\"2017-03-16T00:00:00\",\"2017-03-17T00:00:00\"]', '0', '0', '0');
INSERT INTO `purchase_requirementitem` VALUES ('4ac7b5f8-de90-4fef-99a1-d86dc8c401f8', '8', '0', '花园酒店', '双床房', '10', '2017-03-08 00:00:00', '2017-03-17 00:00:00', '076b091c-d163-4cc6-85a4-8511e9b3ef67', '[\"2017-03-08T00:00:00\",\"2017-03-09T00:00:00\",\"2017-03-10T00:00:00\",\"2017-03-15T00:00:00\",\"2017-03-16T00:00:00\",\"2017-03-17T00:00:00\"]', '5', '0', '0');
INSERT INTO `purchase_requirementitem` VALUES ('578c9d5c-adcc-4e47-9ad4-16be0ed36bbb', '32', '0', '咀香园饼家(大三巴店)', '人头费', '10', '2017-03-06 00:00:00', '2017-03-16 00:00:00', '7d9dd40e-3393-4719-9ffd-48ae4e5c2742', '[\"2017-03-06T00:00:00\",\"2017-03-07T00:00:00\",\"2017-03-08T00:00:00\",\"2017-03-09T00:00:00\",\"2017-03-13T00:00:00\",\"2017-03-14T00:00:00\",\"2017-03-15T00:00:00\",\"2017-03-16T00:00:00\"]', '0', '0', '0');
INSERT INTO `purchase_requirementitem` VALUES ('60644375-8bd1-4cd2-bdb1-bf026ee34058', '128', '0', '东风轿车4座', '轿车', '10', '2017-03-07 00:00:00', '2017-03-23 00:00:00', 'e3c9c2f4-95ee-493b-99b3-05857a5cfbae', '[\"2017-03-07T00:00:00\",\"2017-03-08T00:00:00\",\"2017-03-09T00:00:00\",\"2017-03-10T00:00:00\",\"2017-03-11T00:00:00\",\"2017-03-22T00:00:00\",\"2017-03-23T00:00:00\"]', '2', '0', '0');
INSERT INTO `purchase_requirementitem` VALUES ('6e5b8f15-357b-4669-9ac8-24e2392b60a1', '8', '0', '白云山大酒店', '双床房', '10', '2017-03-06 00:00:00', '2017-03-17 00:00:00', '6637b092-0c1c-43b5-accd-72d938b54859', '[\"2017-03-06T00:00:00\",\"2017-03-07T00:00:00\",\"2017-03-08T00:00:00\",\"2017-03-09T00:00:00\",\"2017-03-10T00:00:00\",\"2017-03-13T00:00:00\",\"2017-03-14T00:00:00\",\"2017-03-15T00:00:00\",\"2017-03-16T00:00:00\",\"2017-03-17T00:00:00\"]', '0', '0', '0');
INSERT INTO `purchase_requirementitem` VALUES ('77ea3750-0d66-499b-84b0-fae95812b438', '16', '0', '羌山红农家乐', '早餐', '20', '2017-03-21 00:00:00', '2017-03-24 00:00:00', '076b091c-d163-4cc6-85a4-8511e9b3ef67', '[\"2017-03-21T00:00:00\",\"2017-03-22T00:00:00\",\"2017-03-23T00:00:00\",\"2017-03-24T00:00:00\"]', '0', '0', '0');
INSERT INTO `purchase_requirementitem` VALUES ('8507f044-5ade-4917-b787-a0cb9a1ae7cb', '1', '48', '正常diy', '234', '2', '2017-03-31 00:00:00', '2017-04-07 00:00:00', '863cda15-a1ed-4410-a193-911d9bbf3dac', '[\"2017-03-31T00:00:00\",\"2017-04-07T00:00:00\"]', '0', '0', '0');
INSERT INTO `purchase_requirementitem` VALUES ('925356ed-463b-4c01-9b54-ead937b1d5c8', '128', '0', '东风越野车请选择', '轿车', '30', '2017-03-15 00:00:00', '2017-03-31 00:00:00', '7d9dd40e-3393-4719-9ffd-48ae4e5c2742', '[\"2017-03-15T00:00:00\",\"2017-03-16T00:00:00\",\"2017-03-17T00:00:00\",\"2017-03-22T00:00:00\",\"2017-03-23T00:00:00\",\"2017-03-24T00:00:00\",\"2017-03-29T00:00:00\",\"2017-03-30T00:00:00\",\"2017-03-31T00:00:00\"]', '0', '0', '0');
INSERT INTO `purchase_requirementitem` VALUES ('95c19bed-0911-48c0-a7f8-6d031d123c65', '128', '0', '东风轿车4座', '轿车', '10', '2017-03-14 00:00:00', '2017-03-24 00:00:00', '076b091c-d163-4cc6-85a4-8511e9b3ef67', '[\"2017-03-14T00:00:00\",\"2017-03-15T00:00:00\",\"2017-03-16T00:00:00\",\"2017-03-17T00:00:00\",\"2017-03-22T00:00:00\",\"2017-03-23T00:00:00\",\"2017-03-24T00:00:00\"]', '5', '0', '0');
INSERT INTO `purchase_requirementitem` VALUES ('b3ae919e-484c-4d07-ad12-ae6f51b99c3c', '32', '0', '普兰国际市场', '人头费', '20', '2017-03-06 00:00:00', '2017-03-18 00:00:00', '7d9dd40e-3393-4719-9ffd-48ae4e5c2742', '[\"2017-03-06T00:00:00\",\"2017-03-07T00:00:00\",\"2017-03-08T00:00:00\",\"2017-03-09T00:00:00\",\"2017-03-10T00:00:00\",\"2017-03-11T00:00:00\",\"2017-03-13T00:00:00\",\"2017-03-14T00:00:00\",\"2017-03-15T00:00:00\",\"2017-03-16T00:00:00\",\"2017-03-17T00:00:00\",\"2017-03-18T00:00:00\"]', '0', '0', '0');
INSERT INTO `purchase_requirementitem` VALUES ('b4dab44b-fe76-4e41-a610-58260e4f3713', '64', '0', '雪山梁', '人头费', '10', '2017-03-15 00:00:00', '2017-03-31 00:00:00', '7d9dd40e-3393-4719-9ffd-48ae4e5c2742', '[\"2017-03-15T00:00:00\",\"2017-03-16T00:00:00\",\"2017-03-17T00:00:00\",\"2017-03-22T00:00:00\",\"2017-03-23T00:00:00\",\"2017-03-24T00:00:00\",\"2017-03-29T00:00:00\",\"2017-03-30T00:00:00\",\"2017-03-31T00:00:00\"]', '0', '0', '0');
INSERT INTO `purchase_requirementitem` VALUES ('e4eda496-00ce-4ca3-96ba-26b41e805157', '128', '0', '东风越野车请选择', '越野车', '10', '2017-03-14 00:00:00', '2017-03-26 00:00:00', '7d9dd40e-3393-4719-9ffd-48ae4e5c2742', '[\"2017-03-14T00:00:00\",\"2017-03-15T00:00:00\",\"2017-03-16T00:00:00\",\"2017-03-17T00:00:00\",\"2017-03-18T00:00:00\",\"2017-03-19T00:00:00\",\"2017-03-21T00:00:00\",\"2017-03-22T00:00:00\",\"2017-03-23T00:00:00\",\"2017-03-24T00:00:00\",\"2017-03-25T00:00:00\",\"2017-03-26T00:00:00\"]', '0', '0', '0');

SET FOREIGN_KEY_CHECKS=1;
