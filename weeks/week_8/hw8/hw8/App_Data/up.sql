-- Users table
CREATE TABLE dbo.Artists
(	
	--artist PK as ID
	ArtistID	INT IDENTITY (1,1) NOT NULL,
	--Artist name, city as 128 length char
	ArtistName	NVARCHAR(128) NOT NULL,
	ArtistCity NVARCHAR(128) NOT NULL,
	--Artist Date of birth as Date object
	ArtistDOB	Date NOT NULL,
	-- constraints for a PK
	CONSTRAINT [PK_dbo.Artists] PRIMARY KEY CLUSTERED (ArtistID ASC)
);

CREATE TABLE dbo.ArtWorks
(
	ArtWorkID	INT IDENTITY (1,1) NOT NULL,
	ArtistID INT,
	ArtistName	NVARCHAR(128) NOT NULL,
	Title	NVARCHAR(64) NOT NULL,
	CONSTRAINT [PK_dbo.ArtWorks] PRIMARY KEY CLUSTERED (ArtWorkID ASC),
	CONSTRAINT FK_ArtistID FOREIGN KEY (ArtistID)
	REFERENCES Artists(ArtistID)
);

CREATE TABLE dbo.Genres
(
	--sense Genres is a single column table we dont need to link it to anything VIA a FK 
	--Genre is linked to others because others (classifications) needs to know about it, 
	--but it doesnt need to know about anyone else
	GenreID			INT IDENTITY (1,1) NOT NULL,
	GenreName	NVARCHAR(64) NOT NULL,
	CONSTRAINT [PK_dbo.Genres] PRIMARY KEY CLUSTERED (GenreID ASC)
);


CREATE TABLE dbo.Classifications
(
	--classifications doesnt have much data (only two columns) but all the data it does have is 
	--a FK of other tables so we must reference and add them.
	ClassificationID		INT IDENTITY (1,1) NOT NULL,
	ArtWork		NVARCHAR(64) NOT NULL,
	Genre		NVARCHAR(64) NOT NULL,
	GenreID INT,
	ArtWorkID INT,
	CONSTRAINT [PK_dbo.Classifications] PRIMARY KEY CLUSTERED (ClassificationID ASC),
	--We will add in Genre sense it is used in classifications table so we must have some reference to it
	CONSTRAINT FK_GenreID FOREIGN KEY (GenreID)
	REFERENCES Genres(GenreID),
	--Same as above but with Artwork Table
	CONSTRAINT FK_ArtWorkID FOREIGN KEY (ArtWorkID)
	REFERENCES ArtWorks(ArtWorkID)
);


--Once tables are created insert into them the appropriate data

--Insert into artists table
INSERT INTO dbo.Artists (ArtistName,ArtistCity,ArtistDOB) VALUES 
	('M.C. Escher','Leeuwarden, Netherlands','1898-06-17 00:00:00'),
	('Leonardo Da Vinci','Vinci, Italy','1519-04-02 00:00:00'),
	('HAtip Mehmed Efendi','Unknown','1680-10-18 00:00:00'),
	('Salvador Dali','Leeuwarden, Figueres, Spain','1904-05-11 00:00:00')
GO

--Insert into ArtWorks table
INSERT INTO dbo.ArtWorks (ArtistName,Title) VALUES 
	('M.C. Escher','Circle Limit III'),
	('M.C. Escher','Twon Tree'),
	('Leonardo Da Vinci','Mona Lisa'),
	('Hatip Mehmed Efendi','Ebru'),
	('Salvador Dali','Honey Is Sweeter Than Blood')
GO

--Insert into Classifications table
INSERT INTO dbo.Classifications(Artwork, Genre) VALUES 
	('Circle Limit III','Tesselation'),
    ('Twon Tree','Tesselation'),
	('Twon Tree','Surrealism'),
	('Mona Lisa','Portrait'),
	('Mona Lisa','Renaissance'),
	('The Vitruvian Man','Renaissance'),
	('Ebru','Tesselation'),
	('Honey Is Sweeter Than Blood','Surrealism');
GO

--Insert into Classifications table
INSERT INTO dbo.Genres(GenreName) VALUES 
	('Tesselation'),
    ('Surrealism'),
	('Portrait'),
	('Renaissance');
GO
