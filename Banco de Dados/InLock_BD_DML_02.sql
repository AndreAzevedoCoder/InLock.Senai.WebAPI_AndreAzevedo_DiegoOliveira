USE InLock_Games_Manha
GO

INSERT INTO TBL_TiposUsuario (ID_TipoUsuario, NOME_TIPO)
VALUES		(1 , 'Administrador')
			,(2 , 'Cliente')
GO

INSERT INTO TBL_USUARIOS (APELIDO, EMAIL, SENHA, ID_TipoUsuario)
VALUES		('ADM' , 'admin@admin.com' , 'admin' , 1)
			,('Client' , 'cliente@cliente.com' , 'cliente', 2)
GO

INSERT INTO TBL_ESTUDIOS (NOME_ESTUDIO)
VALUES		('Rockstar Studios'),('Blizzard'),('Square Enix')
GO

INSERT INTO TBL_JOGOS (NOME_JOGO, DESCRICAO, DATA_LANCAMENTO, VALOR, ID_ESTUDIO)
VALUES		('Diablo 3' , 'É um jogo que contém bastante ação e é viciante, seja você um novato ou um fã' , '15-05-2001' , 99.00 , 2)
			,('Red Dead Redemption II' , 'Jogo eletrônico de ação-aventura western' , '26-10-2018' , 120.00 , 1)
GO