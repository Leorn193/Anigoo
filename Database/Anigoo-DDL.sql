USE Anigoo

IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Genero')
BEGIN
	CREATE TABLE Genero(
		Id_Genero			INT	IDENTITY		NOT NULL,
		Nm_Genero			VARCHAR(300)		NOT NULL,
		Dt_Criacao			DATETIME			NOT NULL,
		Fl_Ativo			BIT					NOT NULL,
		CONSTRAINT PK_Id_Genero PRIMARY KEY (Id_Genero)
	);
END

IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Anime')
BEGIN
	CREATE TABLE Anime(
		Id_Anime			INT	IDENTITY		NOT NULL,
		Id_Genero			INT					NOT NULL,
		Nm_Anime			VARCHAR(300)		NOT NULL,
		Nm_Autor			VARCHAR(300)		NOT NULL,
		Qt_Episodios		INT					NOT NULL,
		Qt_Temporadas		INT					NOT NULL,
		Vl_Avaliacao		DECIMAL				NOT NULL,
		Qt_AnoEstreia		INT					NOT NULL,
		Dt_Criacao			DATETIME			NOT NULL,
		Fl_Ativo			BIT					NOT NULL,
		CONSTRAINT PK_Id_Anime			PRIMARY KEY (Id_Anime),
		CONSTRAINT FK_Id_AnimeGenero	FOREIGN KEY (Id_Genero) REFERENCES Genero(Id_Genero)
	);
END

IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Streaming')
BEGIN
	CREATE TABLE Streaming(
		Id_Streaming		INT	IDENTITY		NOT NULL,
		Nm_Streaming		VARCHAR(300)		NOT NULL,
		Dt_Criacao			DATETIME			NOT NULL,
		Fl_Ativo			BIT					NOT NULL,
		CONSTRAINT PK_Id_Streaming PRIMARY KEY (Id_Streaming)
	);
END

IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'AnimeStreaming')
BEGIN
	CREATE TABLE AnimeStreaming(
		Id_AnimeStreaming		INT	IDENTITY		NOT NULL,
		Id_Anime				INT					NOT NULL,
		Id_Streaming			INT					NOT NULL,
		Dt_Criacao				DATETIME			NOT NULL,
		Fl_Ativo				BIT					NOT NULL,
		CONSTRAINT PK_Id_AnimeStreaming				PRIMARY KEY (Id_AnimeStreaming),
		CONSTRAINT FK_Id_AnimeStreamingAnime		FOREIGN KEY (Id_Anime)		REFERENCES Anime(Id_Anime),
		CONSTRAINT FK_Id_AnimeStreamingStreaming	FOREIGN KEY (Id_Streaming)	REFERENCES Streaming(Id_Streaming)
	);
END

IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Usuario')
BEGIN
	CREATE TABLE Usuario(
		Id_Usuario		INT	IDENTITY		NOT NULL,
		Nm_Usuario		VARCHAR(300)		NOT NULL,
		Ds_Usuario		VARCHAR(200)		NOT NULL,
		Ds_Senha		VARCHAR(200)		NOT NULL,
		Ds_Telefone		VARCHAR(200)		NOT NULL,
		Ds_Email		VARCHAR(200)		NOT NULL,
		Fl_Premium		BIT					NOT NULL,
		Dt_Criacao		DATETIME			NOT NULL,
		Fl_Ativo		BIT					NOT NULL,
		CONSTRAINT PK_Id_Usuario PRIMARY KEY (Id_Usuario),
	);
END


IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Favorito')
BEGIN
	CREATE TABLE Favorito(
		Id_Favorito		INT	IDENTITY	NOT NULL,
		Id_Anime		INT				NOT NULL,
		Id_Usuario		INT				NOT NULL,
		Dt_Criacao		DATETIME		NOT NULL,
		Fl_Ativo		BIT				NOT NULL,
		CONSTRAINT PK_Id_Favorito			PRIMARY KEY (Id_Favorito),
		CONSTRAINT FK_Id_FavoritoAnime		FOREIGN KEY (Id_Anime)		REFERENCES Anime(Id_Anime),
		CONSTRAINT FK_Id_FavoritoUsuario	FOREIGN KEY (Id_Usuario)	REFERENCES Usuario(Id_Usuario)
	);
END

IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Episodio')
BEGIN
	CREATE TABLE Episodio(
		Id_Episodio				INT	IDENTITY		NOT NULL,
		Id_Anime				INT					NOT NULL,
		Cd_Episodio				INT					NOT NULL,
		Nm_Episodio				VARCHAR(200)		NOT NULL,
		Ds_Sinopse				VARCHAR(MAX)		NOT NULL,
		Cd_Temporada			VARCHAR(10)			NOT NULL,
		Vl_Avaliacao			DECIMAL				NOT NULL,
		Dt_Lancamento			DATE				NOT NULL,
		Dt_Criacao				DATETIME			NOT NULL,
		Fl_Ativo				BIT					NOT NULL,
		CONSTRAINT PK_Id_Episodio		PRIMARY KEY (Id_Episodio),
		CONSTRAINT FK_Id_EpisodioAnime	FOREIGN KEY (Id_Anime) REFERENCES Anime(Id_Anime),
	);
END
