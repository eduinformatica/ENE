--CREATE DATABASE ene;
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

IF NOT EXISTS(SELECT * FROM sysobjects WHERE name='tipoRequermiento')
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