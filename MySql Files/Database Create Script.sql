-- CREATE DATABASE TCGStore;

USE TCGStore;
DROP TABLE OrderItems;
DROP TABLE `Order`;
DROP TABLE OrderStatus;
DROP TABLE ShippingOptions;
DROP TABLE Inventory;
DROP TABLE Quality;
DROP TABLE Card;
DROP TABLE SealedProduct;
DROP TABLE `Set`;
DROP TABLE Game;

CREATE TABLE Game (
	GameID INT NOT NULL auto_increment,
	GameName VARCHAR(30) NOT NULL,
	
    PRIMARY KEY(GameID)
);

CREATE TABLE `Set` (
	SetID INT NOT NULL auto_increment,
	SetCode VARCHAR(10) NOT NULL,
	GameID INT NOT NULL,
	SetName varchar(200) NOT NULL,	
	ReleaseDate DATE NOT NULL,
    
    PRIMARY KEY (SetID),
    FOREIGN KEY (GameID) REFERENCES Game(GameID)
);

CREATE TABLE SealedProduct (
	SealedProductID INT NOT NULL auto_increment,
	SetID INT NOT NULL,
	SealedProductName VARCHAR(150) NOT NULL,
	Price DECIMAL(15,2) NOT NULL,
    
    PRIMARY KEY (SealedProductID),
    FOREIGN KEY(SetID) REFERENCES `Set`(SetID)
);

CREATE TABLE Card (
	CardID INT NOT NULL auto_increment,
	SetID INT NOT NULL,
	CardCodeInSet VARCHAR(10) NOT NULL,
	CardName VARCHAR(75) NOT NULL,
	Rarity VARCHAR(75) NOT NULL,
	Price DECIMAL(15,2) NOT NULL,
	ElementalType VARCHAR(25) NULL,
	SubType VARCHAR(25) NULL,
	SuperType VARCHAR(25) NULL,
	PictureLink VARCHAR(250) NULL,
	PictureSmallLink VARCHAR(250) NULL,
	APIImageID VARCHAR(15) NULL,
    
    PRIMARY KEY (CardID),
    FOREIGN KEY (SetID) REFERENCES `Set`(SetID)
);

CREATE TABLE Quality (
	QualityID INT NOT NULL auto_increment,
	PercentageDiscount DECIMAL(5,2) NOT NULL,
	QualityName VARCHAR(25) NOT NULL,
	QualityShortName VARCHAR(2) NOT NULL,
    
    PRIMARY KEY (QualityID)
);

CREATE TABLE Inventory (
	InventoryID INT NOT NULL auto_increment,
	CardID INT NULL,
	SealedProductID INT NULL,
	Quantity INT NOT NULL,
	QualityID INT NOT NULL,
	FirstEdition BIT NULL,
    
    PRIMARY KEY (InventoryID),
    FOREIGN KEY(CardID) REFERENCES Card(CardID),
    FOREIGN KEY(QualityID) REFERENCES Quality(QualityID)
);

CREATE TABLE ShippingOptions
(
	ShippingID INT NOT NULL,
	ShippingName VARCHAR(30) NOT NULL,
    
    PRIMARY KEY (ShippingID)
);

CREATE TABLE OrderStatus
(
	StatusID INT NOT NULL,
	StatusName VARCHAR(15) NOT NULL,
    
    PRIMARY KEY (StatusID)
);

CREATE TABLE `Order` (
	OrderID INT NOT NULL auto_increment,
	ShippingID INT NOT NULL,
	StatusID INT NOT NULL,
	ShippingAddress VARCHAR(50) NOT NULL,
	PostalCode VARCHAR(7) NULL,
	City VARCHAR(40) NULL,
	Province VARCHAR(25) NULL,
	ShippingPrice DECIMAL(15,2) NULL,
	SaleDate DATE NOT NULL,
	UpdatedBy VARCHAR(20) NULL,
	SubTotal DECIMAL(15,2) NOT NULL,
	PST DECIMAL(15,2) NULL,
	HST DECIMAL(15,2) NULL,
	GST DECIMAL(15,2) NULL,
	Total DECIMAL(15,2) NOT NULL,
    
    PRIMARY KEY (OrderID),
    FOREIGN KEY (ShippingID) REFERENCES ShippingOptions(ShippingID),
    FOREIGN KEY (StatusID) REFERENCES OrderStatus(StatusID),
    CHECK (PostalCode LIKE '[A-Z][0-9][A-Z] [0-9][A-Z][0-9]')
);

CREATE TABLE OrderItems(
	OrderItemID INT NOT NULL auto_increment,
	OrderID INT NOT NULL,
	InventoryID INT NULL,
	OrderQuantity INT NOT NULL,
	OrderItemPrice DECIMAL(15,2) NOT NULL,
    
    PRIMARY KEY (OrderItemID),
    FOREIGN KEY(OrderID) REFERENCES `Order`(OrderID),
    FOREIGN KEY(InventoryID) REFERENCES Inventory(InventoryID)
);

