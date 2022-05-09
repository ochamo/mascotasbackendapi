DROP DATABASE IF EXISTS HT9_FAW;

CREATE DATABASE HT9_FAW;

USE HT9_FAW;

CREATE TABLE Mascota(
  id INT AUTO_INCREMENT,
  nombre VARCHAR(45),
  fecha_nac DATE,
  raza VARCHAR(45),
  PRIMARY KEY (id)
);

DROP PROCEDURE IF EXISTS SP_GetPets;

CREATE PROCEDURE SP_GetPets()
    BEGIN
        SELECT p.nombre 'Name', p.fecha_nac 'DateOfBirth', p.raza 'Breed' FROM Mascota p;
    END;

DROP PROCEDURE IF EXISTS SP_InsertPet;
CREATE PROCEDURE SP_InsertPet(IN Name VARCHAR(45), DateOfBirth DATE, Breed VARCHAR(45))
    BEGIN
        INSERT INTO Mascota(nombre, fecha_nac, raza) VALUES(Name, DateOfBirth, Breed);
    END;

