CREATE DATABASE GestionNotasDB;
GO

USE GestionNotasDB;
GO

CREATE TABLE Cursos (
    Id INT PRIMARY KEY IDENTITY(1,1),
    NombreCurso NVARCHAR(100) NOT NULL,
    CantidadEstudiantes INT NOT NULL
);

CREATE TABLE Estudiantes (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    CursoId INT NOT NULL,
    FOREIGN KEY (CursoId) REFERENCES Cursos(Id)
);

CREATE TABLE Notas (
    Id INT PRIMARY KEY IDENTITY(1,1),
    EstudianteId INT NOT NULL,
    Ingles FLOAT NOT NULL,
    Español FLOAT NOT NULL,
    Frances FLOAT NOT NULL,
    Ruso FLOAT NOT NULL,
    FOREIGN KEY (EstudianteId) REFERENCES Estudiantes(Id)
);