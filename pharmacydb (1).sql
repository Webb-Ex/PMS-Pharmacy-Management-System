-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 10, 2021 at 02:18 PM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pharmacydb`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `Admin` (IN `ad` NVARCHAR(30), IN `pass` NVARCHAR(20))  begin
insert into admin values (ad,pass);
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `EditArea` (IN `code` NVARCHAR(30), IN `name` NVARCHAR(20))  begin
update area set  Area_Name = name where Area_Code = code;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `EditBill` (IN `B_id` INT, IN `B_Cname` NVARCHAR(30), IN `B_Icode` NVARCHAR(20), IN `B_IQuant` DOUBLE, IN `B_OStatus` VARCHAR(30), IN `B_SDis` DOUBLE, IN `B_STax` DOUBLE, IN `B_TotalAmount` DOUBLE)  begin
update billing set  Customer_id = B_Cname , Item_id = B_Icode, Item_Quatity = B_IQuant,Order_Status = B_OStatus,
Discount = B_SDis, Tax = B_STax , Total_Amount = B_TotalAmount where Bill_id = B_id; 
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `EditCustomer` (IN `C_id` NVARCHAR(30), IN `C_name` NVARCHAR(30), IN `C_address` NVARCHAR(50), IN `C_p1` NVARCHAR(13), IN `C_p2` NVARCHAR(13), IN `C_areaC` NVARCHAR(20), IN `C_SalesID` NVARCHAR(20))  begin
update customer set Name = C_name,Address = C_address,Primary_Phone = C_p1,Secondary_Phone = C_p2,Area_Code = C_areaC,SalesMan_Id = C_SalesID
where Id = C_id;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `EditItems` (IN `I_id` NVARCHAR(20), IN `I_name` NVARCHAR(100), IN `I_code` NVARCHAR(20), IN `I_pack_size` DOUBLE, IN `I_Tprize` DOUBLE, IN `I_Rprize` DOUBLE, IN `I_STax` DOUBLE, IN `I_SDis` DOUBLE, IN `I_Stock` INT, IN `I_SCode` NVARCHAR(15))  begin
update items set Name = I_name,Company_Code = I_code,Pack_size = I_pack_size,Trade_Price = I_Tprize,Retail_Prize = I_Rprize,Sales_Tax = I_STax,Sales_Discount = I_SDis,Stock = I_Stock,Supplier_Code = I_SCode where Id = I_id;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `EditSales` (IN `Sid` NVARCHAR(20), IN `Sname` NVARCHAR(20), IN `SAddress` NVARCHAR(20), IN `Sp1` NVARCHAR(13), IN `Sp2` NVARCHAR(13))  begin
update salesman set  Name = Sname, Address = SAddress ,Primary_Phone = Sp1,
Secondary_Phone = Sp2 where Id = Sid; 
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `EditSupplier` (IN `SCode` NVARCHAR(20), IN `Sname` NVARCHAR(20), IN `SAddress` NVARCHAR(20), IN `Sp1` NVARCHAR(13), IN `Sp2` NVARCHAR(13), IN `SAreaC` NVARCHAR(13))  begin
update supplier set  Name = Sname, Address = SAddress ,Primary_Phone = Sp1,
Secondary_Phone = Sp2,Area_Code=SAreaC where Code = SCode; 
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `InsArea` (IN `code` NVARCHAR(30), IN `name` NVARCHAR(20))  begin
insert into area values (code,name);
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `InsBill` (IN `id` INT, IN `Cname` NVARCHAR(30), IN `Icode` NVARCHAR(20), IN `IQuant` DOUBLE, IN `OStatus` VARCHAR(30), IN `SDis` DOUBLE, IN `STax` DOUBLE, IN `TotalAmount` DOUBLE)  begin
insert into billing values (id,Cname,Ccode,Icode,IQuant,OStatus,SDis,STax,TotalAmount);
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `InsCustomer` (IN `id` NVARCHAR(30), IN `name` NVARCHAR(30), IN `address` NVARCHAR(50), IN `p1` NVARCHAR(13), IN `p2` NVARCHAR(13), IN `areaC` NVARCHAR(20), IN `SalesID` NVARCHAR(20))  begin
insert into customer values (id,name,address,p1,p2,areaC,SalesID);
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `InsItems` (IN `id` NVARCHAR(20), IN `name` NVARCHAR(100), IN `Comp_code` NVARCHAR(20), IN `pack_size` DOUBLE, IN `Tprize` DOUBLE, IN `Rprize` DOUBLE, IN `STax` DOUBLE, IN `SDis` DOUBLE, IN `Stock` INT, IN `SCode` NVARCHAR(15))  begin
insert into items values (id,name,Comp_code,pack_size,Tprize,Rprize,STax,SDis,Stock,SCode);
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `InsSales` (IN `id` NVARCHAR(20), IN `name` NVARCHAR(20), IN `Address` NVARCHAR(20), IN `p1` NVARCHAR(13), IN `p2` NVARCHAR(13))  begin
insert into salesman values (id,name,Address,p1,p2);
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `InsSupplier` (IN `id` NVARCHAR(15), IN `name` NVARCHAR(40), IN `Address` NVARCHAR(20), IN `p1` NVARCHAR(13), IN `p2` NVARCHAR(13), IN `ACode` NVARCHAR(25))  begin
insert into supplier values (id,name,Address,p1,p2,ACode);
end$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `Username` varchar(30) CHARACTER SET utf8 DEFAULT NULL,
  `Password` varchar(20) CHARACTER SET utf8 DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`Username`, `Password`) VALUES
('admin', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `area`
--

CREATE TABLE `area` (
  `Area_Code` varchar(20) CHARACTER SET utf8 NOT NULL,
  `Area_Name` varchar(40) CHARACTER SET utf8 DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `billing`
--

CREATE TABLE `billing` (
  `Bill_id` int(11) DEFAULT NULL,
  `Customer_Id` varchar(30) CHARACTER SET utf8 DEFAULT NULL,
  `Item_Id` varchar(20) CHARACTER SET utf8 DEFAULT NULL,
  `Item_Quantity` double DEFAULT NULL,
  `Order_Status` varchar(30) CHARACTER SET utf8 DEFAULT NULL,
  `Discount` double DEFAULT NULL,
  `Tax` double DEFAULT NULL,
  `Total_Amount` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `Id` varchar(30) CHARACTER SET utf8 NOT NULL,
  `Name` varchar(30) CHARACTER SET utf8 DEFAULT NULL,
  `Address` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `Primary_Phone` varchar(13) CHARACTER SET utf8 DEFAULT NULL,
  `Secondary_Phone` varchar(13) CHARACTER SET utf8 DEFAULT NULL,
  `Area_Code` varchar(25) CHARACTER SET utf8 DEFAULT NULL,
  `SalesMan_Id` varchar(20) CHARACTER SET utf8 DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `items`
--

CREATE TABLE `items` (
  `Id` varchar(20) CHARACTER SET utf8 NOT NULL,
  `Name` varchar(100) CHARACTER SET utf8 DEFAULT NULL,
  `Company_Code` varchar(20) CHARACTER SET utf8 DEFAULT NULL,
  `Pack_size` double DEFAULT NULL,
  `Trade_Prize` double DEFAULT NULL,
  `Retail_Prize` double DEFAULT NULL,
  `Sales_Tax` double DEFAULT NULL,
  `Sales_Discount` double DEFAULT NULL,
  `Stock` int(11) DEFAULT NULL,
  `Supplier_Code` varchar(15) CHARACTER SET utf8 DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `salesman`
--

CREATE TABLE `salesman` (
  `Id` varchar(20) CHARACTER SET utf8 NOT NULL,
  `Name` varchar(20) CHARACTER SET utf8 DEFAULT NULL,
  `Address` varchar(20) CHARACTER SET utf8 DEFAULT NULL,
  `Primary_Phone` varchar(13) CHARACTER SET utf8 DEFAULT NULL,
  `Secondary_Phone` varchar(13) CHARACTER SET utf8 DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE `supplier` (
  `Code` varchar(15) CHARACTER SET utf8 NOT NULL,
  `Name` varchar(40) CHARACTER SET utf8 DEFAULT NULL,
  `Address` varchar(20) CHARACTER SET utf8 DEFAULT NULL,
  `Primary_Phone` varchar(13) CHARACTER SET utf8 DEFAULT NULL,
  `Secondary_Phone` varchar(13) CHARACTER SET utf8 DEFAULT NULL,
  `Area_Code` varchar(25) CHARACTER SET utf8 DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Stand-in structure for view `viewarea`
-- (See below for the actual view)
--
CREATE TABLE `viewarea` (
`Area_Code` varchar(20)
,`Area_Name` varchar(40)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `viewbill`
-- (See below for the actual view)
--
CREATE TABLE `viewbill` (
`Bill_id` int(11)
,`Customer_Id` varchar(30)
,`Item_Id` varchar(20)
,`Item_Quantity` double
,`Order_Status` varchar(30)
,`Discount` double
,`Tax` double
,`Total_Amount` double
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `viewcustomer`
-- (See below for the actual view)
--
CREATE TABLE `viewcustomer` (
`Id` varchar(30)
,`Name` varchar(30)
,`Address` varchar(50)
,`Primary_Phone` varchar(13)
,`Secondary_Phone` varchar(13)
,`Area_Code` varchar(25)
,`SalesMan_Id` varchar(20)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `viewitems`
-- (See below for the actual view)
--
CREATE TABLE `viewitems` (
`Id` varchar(20)
,`Name` varchar(100)
,`Company_Code` varchar(20)
,`Pack_size` double
,`Trade_Prize` double
,`Retail_Prize` double
,`Sales_Tax` double
,`Sales_Discount` double
,`Stock` int(11)
,`Supplier_Code` varchar(15)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `viewsales`
-- (See below for the actual view)
--
CREATE TABLE `viewsales` (
`Id` varchar(20)
,`Name` varchar(20)
,`Address` varchar(20)
,`Primary_Phone` varchar(13)
,`Secondary_Phone` varchar(13)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `viewsupplier`
-- (See below for the actual view)
--
CREATE TABLE `viewsupplier` (
`Code` varchar(15)
,`Name` varchar(40)
,`Address` varchar(20)
,`Primary_Phone` varchar(13)
,`Secondary_Phone` varchar(13)
,`Area_Code` varchar(25)
);

-- --------------------------------------------------------

--
-- Structure for view `viewarea`
--
DROP TABLE IF EXISTS `viewarea`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewarea`  AS  select `area`.`Area_Code` AS `Area_Code`,`area`.`Area_Name` AS `Area_Name` from `area` ;

-- --------------------------------------------------------

--
-- Structure for view `viewbill`
--
DROP TABLE IF EXISTS `viewbill`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewbill`  AS  select `billing`.`Bill_id` AS `Bill_id`,`billing`.`Customer_Id` AS `Customer_Id`,`billing`.`Item_Id` AS `Item_Id`,`billing`.`Item_Quantity` AS `Item_Quantity`,`billing`.`Order_Status` AS `Order_Status`,`billing`.`Discount` AS `Discount`,`billing`.`Tax` AS `Tax`,`billing`.`Total_Amount` AS `Total_Amount` from `billing` ;

-- --------------------------------------------------------

--
-- Structure for view `viewcustomer`
--
DROP TABLE IF EXISTS `viewcustomer`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewcustomer`  AS  select `customer`.`Id` AS `Id`,`customer`.`Name` AS `Name`,`customer`.`Address` AS `Address`,`customer`.`Primary_Phone` AS `Primary_Phone`,`customer`.`Secondary_Phone` AS `Secondary_Phone`,`customer`.`Area_Code` AS `Area_Code`,`customer`.`SalesMan_Id` AS `SalesMan_Id` from `customer` ;

-- --------------------------------------------------------

--
-- Structure for view `viewitems`
--
DROP TABLE IF EXISTS `viewitems`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewitems`  AS  select `items`.`Id` AS `Id`,`items`.`Name` AS `Name`,`items`.`Company_Code` AS `Company_Code`,`items`.`Pack_size` AS `Pack_size`,`items`.`Trade_Prize` AS `Trade_Prize`,`items`.`Retail_Prize` AS `Retail_Prize`,`items`.`Sales_Tax` AS `Sales_Tax`,`items`.`Sales_Discount` AS `Sales_Discount`,`items`.`Stock` AS `Stock`,`items`.`Supplier_Code` AS `Supplier_Code` from `items` ;

-- --------------------------------------------------------

--
-- Structure for view `viewsales`
--
DROP TABLE IF EXISTS `viewsales`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewsales`  AS  select `salesman`.`Id` AS `Id`,`salesman`.`Name` AS `Name`,`salesman`.`Address` AS `Address`,`salesman`.`Primary_Phone` AS `Primary_Phone`,`salesman`.`Secondary_Phone` AS `Secondary_Phone` from `salesman` ;

-- --------------------------------------------------------

--
-- Structure for view `viewsupplier`
--
DROP TABLE IF EXISTS `viewsupplier`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewsupplier`  AS  select `supplier`.`Code` AS `Code`,`supplier`.`Name` AS `Name`,`supplier`.`Address` AS `Address`,`supplier`.`Primary_Phone` AS `Primary_Phone`,`supplier`.`Secondary_Phone` AS `Secondary_Phone`,`supplier`.`Area_Code` AS `Area_Code` from `supplier` ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `area`
--
ALTER TABLE `area`
  ADD PRIMARY KEY (`Area_Code`);

--
-- Indexes for table `billing`
--
ALTER TABLE `billing`
  ADD KEY `Customer_Id` (`Customer_Id`),
  ADD KEY `Item_Id` (`Item_Id`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `Area_Code` (`Area_Code`),
  ADD KEY `SalesMan_Id` (`SalesMan_Id`);

--
-- Indexes for table `items`
--
ALTER TABLE `items`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `Supplier_Code` (`Supplier_Code`);

--
-- Indexes for table `salesman`
--
ALTER TABLE `salesman`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`Code`),
  ADD KEY `Area_Code` (`Area_Code`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `billing`
--
ALTER TABLE `billing`
  ADD CONSTRAINT `billing_ibfk_1` FOREIGN KEY (`Customer_Id`) REFERENCES `customer` (`Id`),
  ADD CONSTRAINT `billing_ibfk_2` FOREIGN KEY (`Item_Id`) REFERENCES `items` (`Id`);

--
-- Constraints for table `customer`
--
ALTER TABLE `customer`
  ADD CONSTRAINT `customer_ibfk_1` FOREIGN KEY (`Area_Code`) REFERENCES `area` (`Area_Code`),
  ADD CONSTRAINT `customer_ibfk_2` FOREIGN KEY (`SalesMan_Id`) REFERENCES `salesman` (`Id`);

--
-- Constraints for table `items`
--
ALTER TABLE `items`
  ADD CONSTRAINT `items_ibfk_1` FOREIGN KEY (`Supplier_Code`) REFERENCES `supplier` (`Code`);

--
-- Constraints for table `supplier`
--
ALTER TABLE `supplier`
  ADD CONSTRAINT `supplier_ibfk_1` FOREIGN KEY (`Area_Code`) REFERENCES `area` (`Area_Code`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
