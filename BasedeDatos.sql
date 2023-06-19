CREATE DATABASE AdminAsp;

GO

USE AdminAsp;

CREATE TABLE Pais (
  PaisId INT IDENTITY(1,1) PRIMARY KEY,
  Nombre VARCHAR(50),
  Descripcion VARCHAR(100),
);

CREATE TABLE Persona (
  PersonaId INT IDENTITY(1,1) PRIMARY KEY,
  PaisId INT,
  Nombre VARCHAR(50),
  Direccion VARCHAR(100) 
  FOREIGN KEY (PaisId) REFERENCES Pais(PaisId) -- Relación con la tabla Cliente
);
