-- Create Requests Table
CREATE TABLE dbo.Requests
(
	ID					INT IDENTITY (1,1)	NOT NULL,
	ODL					INT					NOT NULL,
	DOB					DATE				NOT NULL,
	PName				NVARCHAR(128)		NOT NULL,
	PAddress			NVARCHAR(128)		NOT NULL,
	Zip					SYSTEM.Int(32)		NOT NULL,
	County				NVARCHAR(128)		NOT NULL,
	City				NVARCHAR(128)		NULL,
	PState				NVARCHAR(128)		NULL,
	TodaysDate			DATE				NOT NULL

	CONSTRAINT [PK_dbo.Requests] PRIMARY KEY CLUSTERED (ID ASC)
);

INSERT INTO dbo.Requests (ODL, DOB, PName, PAddress, Zip, 
	County, City, PState, TodaysDate) VALUES
	('468932', '1996-12-14', 'Koll Klienstuber', '302 south monmouth ave', '97138', 'Polk', 'Monmouth', 'Oregon', '2017-05-11'),
	('123456', '2000-12-30', 'cole klienstuber', '305 south first street', '97111', 'Yamhill', 'Carlton', 'Oregon', '2017-05-11'),
	('224466', '1800-2-10', 'khole clienstuber', '123 first ave', '97867', 'somewhere', 'monymouth', 'California', '2017-05-11'),
	('763458', '2020-4-14', 'chole klienstuuber', '8008 southwest ave', '97111', 'Polk', 'Monmouth', 'Oregon', '2017-05-11'),
	('346789', '1989-7-19', 'khal cleanstuper', '1902 old street west', '97123', 'clackamas', 'sherwood', 'Oregon', '2017-05-11')
GO