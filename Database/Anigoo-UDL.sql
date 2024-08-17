USE Anigoo

SELECT * FROM GENERO
SELECT * FROM Streaming

INSERT INTO Genero
VALUES	('Ação',				GETDATE(),	1),
		('Aventura',			GETDATE(),	1),
		('Fantasia',			GETDATE(),	1),
		('Comedia',				GETDATE(),	1),
		('Drama',				GETDATE(),	1),
		('Romance',				GETDATE(),	1),
		('Esportes',			GETDATE(),	1),
		('Música',				GETDATE(),	1),
		('Suspense',			GETDATE(),	1),
		('Ficção Científica',	GETDATE(),	1),
		('Seinen',				GETDATE(),	1),
		('Shoujo',				GETDATE(),	1),
		('Shounen',				GETDATE(),	1),
		('Sobrenatural',		GETDATE(),	1)

INSERT INTO Streaming
VALUES	('Crunchyroll',		GETDATE(),	1),
		('Netflix',			GETDATE(),	1),
		('PrimeVideo',		GETDATE(),	1),
		('DisneyPlus',		GETDATE(),	1)