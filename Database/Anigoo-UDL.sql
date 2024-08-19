USE Anigoo

SELECT * FROM Genero
SELECT * FROM Streaming
SELECT * FROM Anime
SELECT * FROM AnimeGenero
SELECT * FROM AnimeStreaming
SELECT * FROM Avaliacao
SELECT * FROM Usuario
SELECT * FROM Episodio

/*
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
		('DisneyPlus',		GETDATE(),	1),
		('Funimation',		GETDATE(),	0)

INSERT INTO Anime
VALUES( 'One Piece', 'Eichiiro Oda', 1116, 14, 1997, GETDATE(), 1)

INSERT INTO AnimeGenero
VALUES	( 1, 1, GETDATE(), 1),
		( 1, 2, GETDATE(), 1),
		( 1, 3, GETDATE(), 1),
		( 1, 13, GETDATE(), 1)

INSERT INTO AnimeStreaming
VALUES	( 1, 1, GETDATE(), 1),
		( 1, 2, GETDATE(), 1)

INSERT INTO Usuario
VALUES ( 'Leonardo Ribeiro Nunes', 'Leorn', 'Leo@123', '11933957991', 'leonardo@gmail.com', 1, GETDATE(), 1),
	   ( 'Rafael Limão Lopes de Almeida', 'Littlelemon', 'rafael@123', '11935151562', 'rafael@gmail.com', 1, GETDATE(), 1)

INSERT INTO Avaliacao
VALUES ( 1, 1, 10, GETDATE(), 1),
	   ( 1, 2, 8.5, GETDATE(), 1)

INSERT INTO Episodio
VALUES ( 1, 1, 'Eu Sou Luffy! Aquele Que Será o Rei Dos Piratas!', 'O bando de Alvida saqueia um navio, e acaba encontrando Luffy, que quer conquistar o One Piece e ser o Rei dos Piratas.', 'T1: East Blue', '1999-10-20', GETDATE(), 1)
*/

SELECT Nm_Genero
FROM Anime
JOIN AnimeGenero ON Anime.Id_Anime = AnimeGenero.Id_Anime
JOIN Genero ON AnimeGenero.Id_Genero = Genero.Id_Genero
WHERE Anime.Fl_Ativo = 1

SELECT Nm_Streaming
FROM Anime
JOIN AnimeStreaming ON Anime.Id_Anime = AnimeStreaming.Id_Anime AND AnimeStreaming.Fl_Ativo = 1
JOIN Streaming ON AnimeStreaming.Id_Streaming = Streaming.Id_Streaming AND Streaming.Fl_Ativo = 1
WHERE Anime.Fl_Ativo = 1

SELECT Vl_Avaliacao
FROM Anime
JOIN Avaliacao ON Anime.Id_Anime = Avaliacao.Id_Anime AND Avaliacao.Fl_Ativo = 1
WHERE Anime.Fl_Ativo = 1

SELECT Cd_Temporada,
	   Cd_Episodio,
	   Nm_Episodio
FROM Anime
JOIN Episodio ON Anime.Id_Anime = Episodio.Id_Anime
WHERE Anime.Fl_Ativo = 1
	
