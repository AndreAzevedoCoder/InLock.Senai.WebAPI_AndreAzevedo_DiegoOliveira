USE InLock_Games_Manha
GO

CREATE PROC SP_ListarTodosUsuarios
AS
	BEGIN
			SELECT	APELIDO			AS 'NICKNAME'
					,EMAIL			AS 'EMAIL'
					,NOME_TIPO		AS 'TIPO DO USU�RIO'
			FROM			TBL_USUARIOS
			INNER JOIN		TBL_TiposUsuario
			ON				TBL_USUARIOS.ID_TipoUsuario = TBL_TiposUsuario.ID_TipoUsuario
	END
GO

CREATE PROC SP_ListarTodosEstudios
AS
	BEGIN
			SELECT	NOME_ESTUDIO AS 'EST�DIO'
			FROM	TBL_ESTUDIOS
	END
GO

CREATE PROC SP_ListarJogosEstudios
AS
	BEGIN
			SELECT	ID_JOGO						AS 'C�DIGO DO JOGO'
					,NOME_JOGO					AS 'NOME DO JOGO'
					,DESCRICAO					AS 'DESCRI��O'
					,DATA_LANCAMENTO			AS 'DATA DE LAN�AMENTO'
					,VALOR						AS 'PRE�O'
					,TBL_JOGOS.ID_ESTUDIO		AS 'C�DIGO DO EST�DIO'
					,TBL_ESTUDIOS.NOME_ESTUDIO	AS 'EST�DIO'
			FROM TBL_JOGOS
			INNER JOIN TBL_ESTUDIOS ON TBL_JOGOS.ID_ESTUDIO = TBL_ESTUDIOS.ID_ESTUDIO
	END
GO

CREATE PROC SP_ListarEstudiosJogos
AS
	BEGIN
			SELECT	NOME_ESTUDIO		AS 'EST�DIO'
					,NOME_JOGO			AS 'JOGO(S) PRODUZIDOS'
			FROM TBL_ESTUDIOS
			LEFT JOIN TBL_JOGOS ON TBL_ESTUDIOS.ID_ESTUDIO = TBL_JOGOS.ID_ESTUDIO
	END
GO

CREATE PROC SP_BuscarPorEmailSenha @Email VARCHAR(255), @Senha VARCHAR(255)
AS
	BEGIN
			SELECT	ID_USUARIO						AS 'C�DIGO DO USU�RIO'
					,APELIDO						AS 'NICKNAME'
					,EMAIL							AS 'EMAIL DO USU�RIO'
					,NOME_TIPO						AS 'TIPO DO USU�RIO'
					,TBL_USUARIOS.ID_TipoUsuario	AS 'C�DIGO DO TIPO'
			FROM TBL_USUARIOS
			INNER JOIN TBL_TiposUsuario ON TBL_USUARIOS.ID_TipoUsuario = TBL_TiposUsuario.ID_TipoUsuario
			WHERE EMAIL = @Email AND SENHA = @Senha
	END
GO

CREATE PROC SP_ListarJogoPorId @Id INT
AS
	BEGIN
			SELECT	NOME_JOGO			AS 'NOME DO JOGO'
					,DESCRICAO			AS 'DESCRI��O'
					,DATA_LANCAMENTO	AS 'DATA DE LAN�AMENTO'
					,VALOR				AS 'PRE�O'
					,NOME_ESTUDIO		AS 'EST�DIO'
			FROM TBL_JOGOS
			INNER JOIN TBL_ESTUDIOS ON TBL_JOGOS.ID_ESTUDIO = TBL_ESTUDIOS.ID_ESTUDIO
			WHERE ID_JOGO = @Id
	END
GO

CREATE PROC SP_ListarEstudioPorId @Id INT
AS
	BEGIN
			SELECT	NOME_ESTUDIO AS 'EST�DIO'
			FROM	TBL_ESTUDIOS
			WHERE ID_ESTUDIO = @Id
	END
GO

CREATE PROC SP_CadastrarJogo @Nome VARCHAR(255), @Descricao TEXT, @Data_Lancamento DATE, @Valor FLOAT, @Id_Estudio INT
AS
	BEGIN
		INSERT INTO TBL_JOGOS (NOME_JOGO, DESCRICAO, DATA_LANCAMENTO, VALOR, ID_ESTUDIO)
		VALUES (@Nome, @Descricao, @Data_Lancamento, @Valor, @Id_Estudio)
	END
GO

 CREATE PROC SP_CadastrarEstudio @Nome VARCHAR(255)
 AS
	BEGIN
			INSERT INTO TBL_ESTUDIOS (NOME_ESTUDIO)
			VALUES (@Nome)
	END
GO