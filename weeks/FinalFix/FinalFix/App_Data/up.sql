CREATE TABLE dbo.Buyers
(
BuyerID INT IDENTITY (1,1) NOT NULL,
BuyerName	NVARCHAR(128) NOT NULL,

CONSTRAINT[PK_dbo.Buyer] PRIMARY KEY CLUSTERED (BuyerID ASC)
);


CREATE TABLE dbo.Sellers
(
SellerID INT IDENTITY (1,1) NOT NULL,
SellerName	NVARCHAR(128) NOT NULL,

CONSTRAINT[PK_dbo.Seller] PRIMARY KEY CLUSTERED (SellerID ASC)
);


CREATE TABLE dbo.Items
(
ItemID INT IDENTITY (1,1) NOT NULL,
ItemName	NVARCHAR(128) NOT NULL,
ItemDescription NVARCHAR (128) NOT NULL,

SellerID INT,
CONSTRAINT[PK_dbo.Item] PRIMARY KEY CLUSTERED (ItemID ASC),
CONSTRAINT FK_SellerID FOREIGN KEY (SellerID)
REFERENCES Sellers(SellerID)
);


CREATE TABLE dbo.Bids
(
BidID INT IDENTITY (1,1) NOT NULL,
ItemID	INT,
BuyerID INT,
TimeOfBid datetime NOT NULL,
PriceOfItem DECIMAL NOT NULL,

CONSTRAINT[PK_dbo.Bid] PRIMARY KEY CLUSTERED (BidID ASC),


CONSTRAINT FK_ItemID FOREIGN KEY (ItemID)
REFERENCES Items(ItemID),


CONSTRAINT FK_BuyerID FOREIGN KEY (BuyerID)
REFERENCES Buyers(BuyerID)
);


INSERT INTO dbo.Buyers (BuyerName) VALUES 
	('Jane Stone'),
	('Tom McMasters'),
	('Otto Vanderwall');
GO


INSERT INTO dbo.Sellers (SellerName) VALUES 
	('Gayle Hardy'),
	('Lyle Banks'),
	('Pearl Greene');
GO


INSERT INTO dbo.Items (ItemName, ItemDescription, SellerID) VALUES 
	('Abraham Lincoln Hammer', 'A bench mallet fashioned from a broken rail-splitting maul in 1829 and owned by Abraham Lincoln', '3'),
	('Albert Eisteins Telescope', 'A brass telescope owned by Albert Einstein in Germany, circa 1927', '1'),
	('Bob Dylan Love Poems', 'Five versions of an original unpublished, handwritten, love poem by Bob Dylan', '2');
GO


INSERT INTO dbo.Bids(ItemID, BuyerID, PriceOfItem, TimeOfBid) VALUES 
	('1','3', '250000', '2017-12-04 09:04:22'),
	('2','1', '95000','2017-12-04 08:44:03');
GO