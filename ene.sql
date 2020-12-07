--CREATE DATABASE ene;
IF NOT EXISTS(SELECT * FROM sysobjects WHERE name='ene')
	CREATE DATABASE ene; 
GO;
USE ene;

IF NOT EXISTS(SELECT * FROM sysobjects WHERE name='perfil')
	CREATE TABLE perfil(idperfil INT IDENTITY(1,1) NOT NULL,
		nombrePerfil VARCHAR(20) NOT NULL,
		CONSTRAINT pk_idPerfil PRIMARY KEY(idperfil)
	);
GO

IF NOT EXISTS(SELECT * FROM sysobjects WHERE name='prioridad')
	CREATE TABLE prioridad(idprioridad INT IDENTITY(1,1) NOT NULL,
		nombrePrioridad VARCHAR(20) NOT NULL,
		CONSTRAINT pk_idprioridad PRIMARY KEY(idprioridad)
	);
GO

IF NOT EXISTS(SELECT * FROM sysobjects WHERE name='tipoRequerimiento')
	CREATE TABLE tipoRequerimiento(idtipoRequerimiento INT IDENTITY(1,1) NOT NULL,
		nombre VARCHAR(20) NOT NULL,
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
	CREATE TABLE usuario(idusuario INT IDENTITY(1,1) NOT NULL,
		rut VARCHAR(20) NOT NULL,
		nombres VARCHAR(30) NOT NULL,
		apaterno VARCHAR(30) NOT NULL,
		amaterno VARCHAR(30) NOT NULL,
		clave VARCHAR(255) NOT NULL,
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
--INSERT INTO dbo.perfil(nombrePerfil) VALUES('administrador'),('usuario');
--SELECT * FROM ene.dbo.perfil;

--INSERT INTO dbo.prioridad(nombrePrioridad) VALUES('alta'),('media'),('baja');
--SELECT * FROM ene.dbo.prioridad;

--INSERT INTO dbo.tipoRequerimiento(nombre)
--	VALUES('Base de Datos'), ('Sistemas'), ('Servidores'), ('Contabilidad'), ('Recurso Humano (RRHH)'),
--		('Aranceles'), ('Crear Profesionales'), ('Crear Procedimientos'), ('Crear Usuarios'), ('Redes');
--SELECT * FROM ene.dbo.tipoRequerimiento;

/*-- Eliminamos los procedimientos si es que existen --*/
IF OBJECT_ID('sp_insertProfile') IS NOT NULL
BEGIN
	DROP PROCEDURE sp_insertProfile
END
GO
CREATE PROCEDURE sp_insertProfile
@nombrePerfil AS VARCHAR(20)
AS
BEGIN
	INSERT INTO ene.dbo.perfil(nombrePerfil) 
	VALUES (@nombrePerfil)
END
GO
sp_helptext sp_insertProfile; -- ver la sintaxis del procedimiento almacenado

--sp_insertProfile 'usuario'; -- (administrador, usuario)
SELECT * FROM ene.dbo.perfil;
/*-- Elimina los datos, pero no resetean el orden de los ingresos, empieza el ingreso desde el ultimo numero de registro --*/
--DELETE FROM ene.dbo.perfil;
/*-- Elimina los datos, reseteando el orden de los ingresos. --*/
--DELETE FROM ene.dbo.perfil DBCC CHECKIDENT ('ene.dbo.perfil',RESEED, 0)

SELECT NEWID() AS 'CodeID [MySQL UUID()]'