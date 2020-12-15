/*-- Elimina los datos, pero no resetean el orden de los ingresos, empieza el ingreso desde el ultimo numero de registro --*/
--DELETE FROM ene.dbo.perfil;

/*-- Elimina los datos, reseteando el orden de los ingresos. (TRUNCATE) --*/
--DELETE FROM ene.dbo.usuario DBCC CHECKIDENT ('ene.dbo.usuario',RESEED, 0) 

--SELECT NEWID() AS 'CodeID [MySQL UUID()]'

--CREATE DATABASE ene;
--IF NOT EXISTS(SELECT * FROM sysobjects WHERE name='ene')
--	CREATE DATABASE ene; 
--GO;
USE ene;

IF NOT EXISTS(SELECT * FROM sysobjects WHERE name='perfil')
	CREATE TABLE perfil(idperfil INT IDENTITY(1,1) NOT NULL,
		nombrePerfil VARCHAR(20) NOT NULL,
		CONSTRAINT pk_idPerfil PRIMARY KEY(idperfil)
	);
GO

IF NOT EXISTS(SELECT * FROM sysobjects WHERE name='prioridad')
	CREATE TABLE prioridad(idprioridad INT IDENTITY(0,1) NOT NULL,
		nombrePrioridad VARCHAR(20) NOT NULL,
		CONSTRAINT pk_idprioridad PRIMARY KEY(idprioridad)
	);
GO

IF NOT EXISTS(SELECT * FROM sysobjects WHERE name='tipoRequerimiento')
	CREATE TABLE tipoRequerimiento(idtipoRequerimiento INT IDENTITY(0,1) NOT NULL,
		nombre VARCHAR(100) NOT NULL,
		CONSTRAINT pk_idtipoRequerimiento PRIMARY KEY(idtipoRequerimiento)
	);
GO

IF NOT EXISTS(SELECT * FROM sysobjects WHERE name='estado')
	CREATE TABLE estado(idestado INT IDENTITY(1,1) NOT NULL,
		nombreEstado VARCHAR(20) NOT NULL,
		CONSTRAINT pk_idestado PRIMARY KEY(idestado)
	);
GO

IF NOT EXISTS(SELECT * FROM sysobjects WHERE name='usuario')
	CREATE TABLE usuario(idusuario INT IDENTITY(0,1) NOT NULL,
		rut VARCHAR(20) NOT NULL UNIQUE,
		nombres VARCHAR(30) NOT NULL,
		apaterno VARCHAR(30) NOT NULL,
		amaterno VARCHAR(30) NOT NULL,
		clave VARBINARY(MAX) NOT NULL,
		perfil_idperfil INT NOT NULL
		CONSTRAINT pk_idusuario PRIMARY KEY(idusuario),
		CONSTRAINT fk_idperfil FOREIGN KEY(perfil_idperfil) REFERENCES perfil(idperfil)
	);
GO

IF NOT EXISTS(SELECT * FROM sysobjects WHERE name='requerimiento')
	CREATE TABLE requerimiento(idrequerimiento INT IDENTITY(1,1) NOT NULL,
		fechaRequerimiento DATE NOT NULL,
		descripcion VARCHAR(MAX) NOT NULL,
		fechaPlazo DATE NOT NULL,
		prioridad_idprioridad INT NOT NULL,
		usuarioAsignado INT NOT NULL,
		usuarioAsignante INT NOT NULL,
		estado_idestado INT NOT NULL,
		tipoRequerimiento_idtipoRequerimiento INT NOT NULL,
		CONSTRAINT pk_idrequerimiento PRIMARY KEY(idrequerimiento),
		CONSTRAINT fk_idprioridad FOREIGN KEY(prioridad_idprioridad) REFERENCES prioridad(idprioridad),
		CONSTRAINT fk_usuarioAsignado FOREIGN KEY(usuarioAsignado) REFERENCES usuario(idusuario),
		CONSTRAINT fk_usuarioAsignante FOREIGN KEY(usuarioAsignante) REFERENCES usuario(idusuario),
		CONSTRAINT fk_idestado FOREIGN KEY(estado_idestado) REFERENCES estado(idestado),
		CONSTRAINT fk_idtipoRequerimiento FOREIGN KEY(tipoRequerimiento_idtipoRequerimiento) REFERENCES tipoRequerimiento(idtipoRequerimiento)
	);
GO


/*-- Add insert data registrer (NORMAL / PROCEDIMIENTOS ALMACENADOS) --*/
INSERT INTO dbo.perfil(nombrePerfil) VALUES('Administrador'),('Usuario');
SELECT * FROM ene.dbo.perfil;

INSERT INTO dbo.prioridad(nombrePrioridad) VALUES('Seleccionar'),('Alta'),('Media'),('Baja');
SELECT * FROM ene.dbo.prioridad;

INSERT INTO dbo.tipoRequerimiento(nombre)
	VALUES('Seleccionar'),('Base de Datos'), ('Sistemas'), ('Servidores'), ('Contabilidad'), ('Redes');
SELECT * FROM ene.dbo.tipoRequerimiento;


INSERT INTO dbo.usuario(rut, nombres, apaterno, amaterno, clave, perfil_idperfil)
	VALUES('18533984K', 'Daniel', 'Gomez', 'Gomez', CONVERT(VARBINARY, 'daniel93'), 2);
INSERT INTO dbo.usuario(rut, nombres, apaterno, amaterno, clave, perfil_idperfil)
	VALUES('79771856', 'Victor', 'Sanchez', 'Hugo', CONVERT(VARBINARY, 'vitoco93'), 1);
INSERT INTO dbo.usuario(rut, nombres, apaterno, amaterno, clave, perfil_idperfil)
	VALUES('11111111', 'PRUEBA', 'PRUEBA', 'PRUEBA', CONVERT(VARBINARY, 'test'), 1);
INSERT INTO dbo.usuario(rut, nombres, apaterno, amaterno, clave, perfil_idperfil)
	VALUES('22222222', 'Informatica', 'Prueba', 'Prueba', CONVERT(VARBINARY, 'test'), 2);
SELECT * FROM ene.dbo.usuario;


SELECT u.idusuario AS "#", u.rut, CONCAT_WS(' ', u.nombres, u.apaterno, u.amaterno) AS "usuario", u.clave, p.nombrePerfil as "perfil"
FROM ene.dbo.usuario u
INNER JOIN ene.dbo.perfil p ON p.idperfil = u.perfil_idperfil
ORDER BY u.nombres ASC;




--CREATE PROCEDURE SesionInit 
--	@rut VARCHAR(20),
--	@clave VARCHAR(MAX),
--	@sms VARCHAR(100) OUT,
--	@idperfil VARCHAR(5) OUT,
--	@idusuario VARCHAR(5) OUT
--AS
--BEGIN
--	DECLARE @a VARCHAR(50)
--	DECLARE @b VARCHAR(50)

--	SET @a = (SELECT u.rut FROM usuario u WHERE u.rut = @rut)
--	SET @b = (SELECT CONVERT(VARCHAR, clave) FROM usuario u WHERE u.rut = @rut)
--	SET @idperfil = (SELECT u.perfil_idperfil FROM usuario u WHERE u.rut = @rut)
--	SET @idusuario = (SELECT u.idusuario FROM usuario u WHERE u.rut = @rut)
	
--	IF (@a=@rut AND @clave=@b)
--		BEGIN
--			SET @sms = (SELECT CONCAT_WS(' ', u.nombres, u.apaterno, u.amaterno) FROM usuario u WHERE u.rut=@rut)
--			PRINT @sms
--		END
--	ELSE
--		BEGIN
--			SET @sms = 'Usuario y contraseña no válido'
--			PRINT @sms
--		END
--END 
--sp_helptext SesionInit 
execute SesionInit '79771856','vitoco93','','','';


--CREATE PROCEDURE ListarPrioridad
--AS
--BEGIN
--	SELECT * FROM prioridad p
--END
execute ListarPrioridad;


--CREATE PROCEDURE TipoRequerimiento
--AS
--BEGIN
--	SELECT * FROM tipoRequerimiento tp
--END
execute TipoRequerimiento;


--CREATE PROCEDURE ListarUsuarios(@idusuario int = null)
--AS
--BEGIN
--	SELECT u.idusuario AS 'id', CONCAT_WS(' ', u.nombres, u.apaterno, u.amaterno) AS 'usuarios', u.rut, u.perfil_idperfil, u.clave
--	FROM usuario u
--	WHERE u.idusuario <> @idusuario
--END
--sp_helptext ListarUsuarios


--CREATE PROCEDURE UpdateStatuRequerimiento (@id int, @mensaje VARCHAR(100) OUT)
--AS
--BEGIN 
--	UPDATE ene.dbo.requerimiento 
--	SET estado_idestado = 2
--	WHERE idrequerimiento = @id
--	SET @mensaje = 'Estado requerimiento modificado con exito'
--END


--CREATE PROCEDURE DeleteRequerimiento (@id int, @mensaje VARCHAR(100) OUT)
--AS
--BEGIN
--	DELETE FROM requerimiento
--	WHERE idrequerimiento = @id
--	SET @mensaje = 'Requerimiento eliminado con exito';
--END


--CREATE PROCEDURE ListRequest (@idusuario int = null) -- listar requerimientos
--AS
--BEGIN
--	SELECT r.idrequerimiento, tp.idtipoRequerimiento AS 'Tipo de Requerimiento', p.nombrePrioridad 'Prioridad', r.descripcion 'Descripcion',
--		DATEDIFF(DAY, r.fechaRequerimiento, r.fechaPlazo) AS 'Dias de plazo'
--	FROM requerimiento r, tipoRequerimiento tp, prioridad p
--	WHERE r.tipoRequerimiento_idtipoRequerimiento = tp.idtipoRequerimiento
--	AND r.prioridad_idprioridad = p.idprioridad
--	OR r.usuarioAsignante = @idusuario OR r.usuarioAsignado = @idusuario
--END


CREATE PROCEDURE RegistrarRequerimiento ( -- No me deja ejecutar este procedimiento almacenado
	@fechaRequerimiento DATE,
	@usuarioAsignante INT,
	@usuarioAsignado INT,
	@prioridad_idprioridad INT,
	@tipoRequerimiento_idtipoRequerimiento INT,
	@estado INT,
	@descripcion VARCHAR(MAX),
	@sms VARCHAR(100) OUT
)
AS
BEGIN
	INSERT INTO requerimiento
	VALUES(@fechaRequerimiento, @descripcion, null, @prioridad_idprioridad, @usuarioAsignante, @usuarioAsignado,
	@estado, @tipoRequerimiento_idtipoRequerimiento)
	
	IF @prioridad_idprioridad = 1
	BEGIN
		SET @sms = CONVERT(VARCHAR(15),DATEADD(DAY,3,@fechaRequerimiento),3)
		UPDATE requerimiento 
		SET fechaPlazo = CONVERT(date, @sms,3)
		WHERE idrequerimiento = (SELECT isnull(MAX(idrequerimiento),1) FROM requerimiento)
	END
	ELSE IF @prioridad_idprioridad = 2
	BEGIN
		SET @sms = CONVERT(VARCHAR(15),DATEADD(DAY,4,@fechaRequerimiento),3)
		UPDATE requerimiento 
		SET fechaPlazo = CONVERT(date, @sms,3)
		WHERE idrequerimiento = (SELECT isnull(MAX(idrequerimiento),1) FROM requerimiento)
	END
	ELSE IF @prioridad_idprioridad = 3
	BEGIN
		SET @sms = CONVERT(VARCHAR(15),DATEADD(DAY,5,@fechaRequerimiento),3)
		UPDATE requerimiento 
		SET fechaPlazo = CONVERT(date, @sms,3)
		WHERE idrequerimiento = (SELECT isnull(MAX(idrequerimiento),1) FROM requerimiento)
	END
END






-- Para el nacho
CREATE PROCEDURE RegistrarRequerimiento ( -- No me deja ejecutar este procedimiento almacenado
	@fechaRequerimiento DATE,
	@usuarioAsignante INT,
	@usuarioAsignado INT,
	@prioridad_idprioridad INT,
	@tipoRequerimiento_idtipoRequerimiento INT,
	@estado INT,
	@descripcion VARCHAR(MAX),
	@sms VARCHAR(100) OUT
)
AS
BEGIN
	INSERT INTO requerimiento
	VALUES(@fechaRequerimiento, @descripcion, null, @prioridad_idprioridad, @usuarioAsignante, @usuarioAsignado,
	@estado, @tipoRequerimiento_idtipoRequerimiento)
	
	IF @prioridad_idprioridad = 1
	BEGIN
		SET @sms = CONVERT(VARCHAR(15),DATEADD(DAY,3,@fechaRequerimiento),3)
		UPDATE requerimiento 
		SET fechaPlazo = CONVERT(date, @sms,3)
		WHERE idrequerimiento = (SELECT isnull(MAX(idrequerimiento),1) FROM requerimiento)
	END
	ELSE IF @prioridad_idprioridad = 2
	BEGIN
		SET @sms = CONVERT(VARCHAR(15),DATEADD(DAY,4,@fechaRequerimiento),3)
		UPDATE requerimiento 
		SET fechaPlazo = CONVERT(date, @sms,3)
		WHERE idrequerimiento = (SELECT isnull(MAX(idrequerimiento),1) FROM requerimiento)
	END
	ELSE IF @prioridad_idprioridad = 3
	BEGIN
		SET @sms = CONVERT(VARCHAR(15),DATEADD(DAY,5,@fechaRequerimiento),3)
		UPDATE requerimiento 
		SET fechaPlazo = CONVERT(date, @sms,3)
		WHERE idrequerimiento = (SELECT isnull(MAX(idrequerimiento),1) FROM requerimiento)
	END
END