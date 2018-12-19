use Chinook

--SELECT * FROM Artist

--SELECT * FROM Artist
--ORDER BY Name

--SELECT TOP 10 * FROM Artist
--ORDER BY ArtistId, Name

--SELECT * FROM Artist
--WHERE Name LIKE 'Academy%';

--SELECT * From Album
--WHERE Title LIKE '_ar%';

--SELECT * From Album
--WHERE Title LIKE '[a,e,i,o,u,y,å,ä,ö]%';

--SELECT Name, Title FROM Album, Artist

--(INNER) JOIN: Returns records that have matching values in both tables
--LEFT (OUTER) JOIN: Return all records from the left table, and the matched records from the right table
--RIGHT (OUTER) JOIN: Return all records from the right table, and the matched records from the left table
--FULL (OUTER) JOIN: Return all records when there is a match in either left or right table

--SELECT TOP 10 Artist.Name, COUNT(*) AS NumberOfAlbums 
--FROM Album
--JOIN Artist ON Album.ArtistId = Artist.ArtistId
--GROUP BY Artist.Name
--ORDER BY NumberOfAlbums DESC;

--SELECT DISTINCT Album.Title AS AlbumTitle, Genre.Name AS Genre
--FROM Album, Genre, Track
--WHERE Album.AlbumId = Track.AlbumId AND Track.GenreId = Genre.GenreId AND (Genre.Name = 'Blues' OR Genre.Name = 'Jazz');

--SELECT DISTINCT Album.Title AS AlbumTitle, Genre.Name AS Genre
--FROM Album
--JOIN Track ON Track.AlbumId = Album.AlbumId
--JOIN Genre ON Genre.GenreId = Track.GenreId
--WHERE Genre.GenreId = 2 OR Genre.GenreId = 6

--ALTER TABLE Track
--ADD TrackNr Int;

--SELECT Track.TrackNr As TrackNr, Track.Name AS TrackName FROM Album
--JOIN Track ON Track.AlbumId = Album.AlbumId
--WHERE Album.AlbumId = 4

--UPDATE Track
--SET Track.TrackNr = 1 WHERE Track.TrackId = 15
--UPDATE Track
--SET Track.TrackNr = 2 WHERE Track.TrackId = 16
--UPDATE Track
--SET Track.TrackNr = 3 WHERE Track.TrackId = 17
--UPDATE Track
--SET Track.TrackNr = 4 WHERE Track.TrackId = 18
--UPDATE Track
--SET Track.TrackNr = 5 WHERE Track.TrackId = 19
--UPDATE Track
--SET Track.TrackNr = 6 WHERE Track.TrackId = 20
--UPDATE Track
--SET Track.TrackNr = 7 WHERE Track.TrackId = 21
--UPDATE Track
--SET Track.TrackNr = 8 WHERE Track.TrackId = 22

--SELECT Genre.Name As Genre, COUNT(*) AS NumberOfTracks
--FROM Track
--JOIN Genre ON Track.GenreId = Genre.GenreId
--GROUP BY Genre.Name
--HAVING COUNT(*) > 100
--ORDER BY NumberOfTracks DESC

--DECLARE @MyCustomer int = 
--(
--    SELECT CustomerId 
--    FROM Customer 
--    WHERE FirstName='Leonie' AND LastName='Köhler'
--)

--SELECT cast(InvoiceDate AS date) 
--FROM Invoice 
--WHERE CustomerId=@MyCustomer

--SELECT Customer.FirstName AS CustomerFirstName, Customer.LastName AS CustomerLastName, Employee.FirstName AS EmployeeFirstName, Employee.LastName AS EmployeeLastName
--INTO #CustomerWithSupport
--FROM Customer, Employee
--WHERE Customer.SupportRepId = Employee.EmployeeId

--SELECT Employee.FirstName + Employee.LastName AS EmployeeName, Employee2.FirstName + Employee2.LastName AS BossName
--FROM Employee
--JOIN Employee AS Employee2
--ON Employee2.EmployeeId = Employee.ReportsTo


--select max(datalength(YourColumn)) from YourTable 

--SELECT MAX(DATALENGTH(Email)) FROM Customer

--select top 1 with ties
--   len(Email) AS LongestMail
--from Customer
--order by len(Email) desc

--select top 1 with ties Name,(Milliseconds/(1000*60)) AS Minutes
--from Track
--order by (Milliseconds) desc

--Select year(InvoiceDate) as year, sum(total) as Sum
--From Invoice
--Group by year(InvoiceDate)
--Order by year desc

--Select Distinct top 1 Playlist.Name As Name, sum(Track.Milliseconds/(1000.0*3600.0)) As LengthInHours
--From Playlist
--JOIN PlaylistTrack On PlaylistTrack.PlaylistId = Playlist.PlaylistId
--JOIN Track On Track.TrackId = PlaylistTrack.TrackId
--Group by PlaylistTrack.PlaylistId, PlayList.Name
--Order by LengthInHours DESC

--SELECT Employee.FirstName + ' ' + Employee.LastName AS EmployeeName, Employee3.FirstName + ' ' +  Employee3.LastName AS BossesBossName
--FROM Employee
--JOIN Employee AS Employee2
--ON Employee2.EmployeeId = Employee.ReportsTo
--JOIN Employee AS Employee3
--ON Employee3.EmployeeId = Employee2.ReportsTo

--CREATE TABLE AlbumReview (
--    AlbumId int,
--    AlbumReview varchar(300),
--);

--INSERT INTO AlbumReview (AlbumId, AlbumReview)
--VALUES (16, 'Tunga grejer med Ozzy')

--UPDATE AlbumReview
--SET AlbumReview = 'Tunga grejer med Ozzy'
--WHERE AlbumID = 16

--ALTER TABLE Customer
--ADD UNIQUE (Email);

--Nedanstående funkar ej då email-kolumnen gjorts unik.
--INSERT INTO Customer (FirstName, LastName, Email)
--VALUES ('Rikard', 'Isaksson','luisg@embraer.com.br')

--BACKUP DATABASE Chinook
--TO DISK = 'C:\Temp\testDB.bak';

--ALTER TABLE PlayListTrack
--DROP CONSTRAINT FK_PlaylistTrackPlaylistId

--DELETE FROM Playlist;

--RESTORE DATABASE Chinook 
--FROM DISK = 'C:\Temp\testDB.bak';


--BEGIN TRANSACTION
--INSERT INTO Artist (Name)
--VALUES ('Tyskarna från Lund'),('S.P.O.C.K.'), ('Apoptygma Berzerk'), ('Depeche Mode'), ('De/Vision')

--ROLLBACK

--SELECT Artist.Name AS Artist, COUNT(DISTINCT PlayList.Name) AS NumberOfAppearances FROM Artist
--FULL JOIN Album ON Artist.ArtistId = Album.ArtistId
--FULL JOIN Track ON Track.AlbumId = Album.AlbumId
--FULL JOIN PlaylistTrack ON PlaylistTrack.TrackId = Track.TrackId
--FULL JOIN Playlist ON Playlist.PlaylistId = PlaylistTrack.PlaylistId
--GROUP BY Artist.Name
--ORDER BY NumberOfAppearances DESC