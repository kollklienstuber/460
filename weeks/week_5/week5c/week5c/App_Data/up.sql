CREATE TABLE dbo.Forms
(
	ID			INT IDENTITY (1,1) NOT NULL,
	FirstName	NVARCHAR(64) NOT NULL,
	LastName	NVARCHAR(128) NOT NULL,
	DOB			DateTime NOT NULL,
	NewAddress		NVARCHAR(128) NOT NULL,
	City		NVARCHAR(128) NOT NULL,
	NewState	NVARCHAR(64) NOT NULL,
	Zip			INT NOT NULL,
	County		NVARCHAR(128) NOT NULL,
	CONSTRAINT [PK_dbo.Forms] PRIMARY KEY CLUSTERED (ID ASC)
);

INSERT INTO dbo.Forms (FirstName, LastName, DOB, NewAddress, City, NewState, Zip, County) VALUES 
	('Koll','Klienstuber','2002-10-22 00:00:00','302 south monmouth ave','Monmouth','Oregon','97361', 'Polk'),
	('Cole','klieenstuper','1996-02-14 00:00:00','305 south first street','Carlton','Oregon','97111', 'Yamhill'),
	('khols','clienstuber','1898-11-13 00:00:00','6500 Ne hwy 240','Yamhill','Oregon','97148', 'Yamhill'),
	('Other','Name','1787-10-10 00:00:00','1800 penn ave','someTown','Colarado','97678', 'Yellow'),
	('Kholl','klienenstuberger','1867-05-04 00:00:00','12345 north first ave','salem','Oregon','89876', 'Washington'),
	('ceaser','theChimp','2001-07-06 00:00:00','76543 banks ave','Banks','Oregon','87656', 'Clackamas')
GO