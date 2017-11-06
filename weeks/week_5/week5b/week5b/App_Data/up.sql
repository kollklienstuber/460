-- Create Requests Table
CREATE TABLE dbo.Requests
(
	ID					INT IDENTITY (1,1)	NOT NULL,
	ODL					INT					NOT NULL,
	DOB					DATE				NOT NULL,
	PName				NVARCHAR(128)		NOT NULL,
	PAddress			NVARCHAR(128)		NOT NULL,
	Zip					NVARCHAR(128)		NOT NULL,
	County				NVARCHAR(128)		NOT NULL,
	City				NVARCHAR(128)		NULL,
	PState				NVARCHAR(128)		NULL,
	TodaysDate			DATE				NOT NULL

	CONSTRAINT [PK_dbo.Requests] PRIMARY KEY CLUSTERED (ID ASC)
);

INSERT INTO dbo.Requests (ODL, DOB, PName, PAddress, Zip, 
	County, City, PState, TodaysDate) VALUES
	('444555', '1996-12-14', 'Koll Klienstuber', '302 south monmouth ave', '97138', 'Polk', 'Monmouth', 'Oregon', '2017-05-11'),
	('444555', '1996-12-14', 'Koll Klienstuber', '302 south monmouth ave', '97138', 'Polk', 'Monmouth', 'Oregon', '2017-05-11'),
	('444555', '1996-12-14', 'Koll Klienstuber', '302 south monmouth ave', '97138', 'Polk', 'Monmouth', 'Oregon', '2017-05-11'),
	('444555', '1996-12-14', 'Koll Klienstuber', '302 south monmouth ave', '97138', 'Polk', 'Monmouth', 'Oregon', '2017-05-11'),
	('444555', '1996-12-14', 'Koll Klienstuber', '302 south monmouth ave', '97138', 'Polk', 'Monmouth', 'Oregon', '2017-05-11')
GO