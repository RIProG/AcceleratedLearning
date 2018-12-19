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

DECLARE @MyCustomer int=
(
SELECT CutomerId
FROM Customer WHERE FirstName = 'Leonie' AND LastName = 'Köhler'
)
