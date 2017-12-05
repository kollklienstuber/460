-- Users Buyer
CREATE TABLE dbo.Buyers
(	
	--Buyer PK as ID
	BuyerID	INT IDENTITY (1,1) NOT NULL,
	--Buyer name
	BuyerName	NVARCHAR(64) NOT NULL,
	
	-- constraints for a PK
	CONSTRAINT [PK_dbo.Buyers] PRIMARY KEY CLUSTERED (BuyerID ASC)
);

CREATE TABLE dbo.Sellers
(
	SellerID	INT IDENTITY (1,1) NOT NULL,
	SellerName NVARCHAR(64) NOT NULL,
	
	-- constraints for a PK
	CONSTRAINT [PK_dbo.Sellers] PRIMARY KEY CLUSTERED (SellerID ASC)
);

CREATE TABLE dbo.Items
(
	--sense Genres is a single column table we dont need to link it to anything VIA a FK 
	--Genre is linked to others because others (classifications) needs to know about it, 
	--but it doesnt need to know about anyone else
	ItemID			INT IDENTITY (1,1) NOT NULL,
	ItemName		NVARCHAR(64) NOT NULL,
	ItemDescription	NVARCHAR(128) NOT NULL,
	SellerID INT,


	CONSTRAINT [PK_dbo.Items] PRIMARY KEY CLUSTERED (ItemID ASC),

	-- add in seller as a FK
	CONSTRAINT FK_SellerID FOREIGN KEY (SellerID)
	REFERENCES Sellers(SellerID),

);


CREATE TABLE dbo.Bidss
(
BidID INT IDENTITY (1,1) NOT NULL,
BuyerID INT,
ItemID	INT,
BidPrice DECIMAL NOT NULL,
TimeOfBid datetime NOT NULL,
CONSTRAINT[PK_dbo.Bid] PRIMARY KEY CLUSTERED (BidID ASC),
CONSTRAINT FK_ItemID FOREIGN KEY (ItemID)
REFERENCES Item(ItemID),
CONSTRAINT FK_BuyerID FOREIGN KEY (BuyerID)
REFERENCES Buyer(BuyerID)
);



--Once tables are created insert into them the appropriate data

--Insert into artists table
INSERT INTO dbo.Buyers (BuyerName) VALUES 
	('Jane Stone'),
	('Tom McMasters'),
	('Otto Vanderwall');
GO

--Insert into ArtWorks table
INSERT INTO dbo.Sellers (SellerName) VALUES 
('Gayle Hardy'),
('Lyle Banks'),
('Pearl Greene');
GO

--Insert into Classifications table
INSERT INTO dbo.Items(ItemName, ItemDescription) VALUES 
('Abraham Lincoln Hammer'    ,'A bench mallet fashioned from a broken rail-splitting maul in 1829 and owned by Abraham Lincoln'),
('Albert Einsteins Telescope','A brass telescope owned by Albert Einstein in Germany, circa 1927'),
('Bob Dylan Love Poems'      ,'Five versions of an original unpublished, handwritten, love poem by Bob Dylan');
GO

--Insert into Classifications table
INSERT INTO dbo.Bids(ItemID, BidPrice, TimeOfBid) VALUES 
(1001,250000,'2017-12-04 09:04:22'),
(1003,95000 ,'2017-12-04 08:44:03');
GO


