### Create Product Table

#### Code Block


~~~~sql
CREATE TABLE `Products` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL,
  `Barcode` varchar(50) NOT NULL,
  `Description` varchar(250) NOT NULL,
  `Rate` decimal(18,2) NOT NULL,
  `AddedOn` datetime NOT NULL,
  `ModifiedOn` datetime DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci
~~~~