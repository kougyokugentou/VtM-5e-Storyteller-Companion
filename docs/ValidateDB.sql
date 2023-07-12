/*
Vampire 5e Storyteller Database Schema and data seeding of meta-tables.
Always drops Clan, ClanDiscipline, Discipline, Skill, and Advantage to update to latest values since I don't know EF.
--Author: Kougyoku, 2023

Please view the project readme for licensing info.
*/

--Create DB
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'VtM5eStoryteller')
BEGIN
    CREATE DATABASE VtM5eStoryteller;
END
GO

USE VtM5eStoryteller
GO

--Create tables if they don't already exist.
-- Advantage does not depend on anything.
DROP TABLE IF EXISTS Advantages
CREATE TABLE Advantages
(
	Id			INT				PRIMARY KEY IDENTITY,
	Name		VARCHAR(255),
	Points		INT
);

--Skill table does not depend on anything.
DROP TABLE IF EXISTS Skills
CREATE TABLE Skills
(
	Id		INT				PRIMARY KEY IDENTITY,
	Name	VARCHAR(255)
);

--Specialty does not depend on anything.
--Only create if it does not exist, this is player data.
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Specialties' AND type = 'U')
BEGIN
    CREATE TABLE Specialties
    (
		Id			INT				PRIMARY KEY IDENTITY,
		SpecText	VARCHAR(255)
    );
END

--Clan must be first table or ClanDiscipline will fail
DROP TABLE IF EXISTS Clans
CREATE TABLE Clans
(
	Id			INT				PRIMARY KEY IDENTITY,
	Name		VARCHAR(100),
	Description VARCHAR(MAX),
	Bane		VARCHAR(MAX),
	Compulsion	VARCHAR(MAX),
);
GO

--Discipline must be in place before ClanDiscipline, PlayerDiscipline, and DisciplinePower
DROP TABLE IF EXISTS Disciplines
CREATE TABLE Disciplines
(
	Id			INT				PRIMARY KEY IDENTITY,
	Name		VARCHAR(255),
);
GO

-- ClanDiscipline
DROP TABLE IF EXISTS ClanDisciplines
CREATE TABLE ClanDisciplines
(
	Id				INT		PRIMARY KEY IDENTITY,
	ClanID			INT		FOREIGN KEY REFERENCES Clans(Id),
	DisciplineId	INT		FOREIGN KEY REFERENCES Disciplines(Id)
);
GO

--DisciplinePower, describes all the actual powers of the discipline since
--one level of a discipline usually has two selections.
DROP TABLE IF EXISTS DisciplinePowers
CREATE TABLE DisciplinePowers
(
	Id				INT		PRIMARY KEY IDENTITY,
	DisciplineID	INT		FOREIGN KEY REFERENCES Disciplines(Id),
	Name			VARCHAR(255),
	Level			INT,
	PrereqDisciplineID	INT	NULL FOREIGN KEY REFERENCES DisciplinePowers(Id)
);

--Big Mama -- Character. Nearly everything references it.
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Characters' AND type = 'U')
BEGIN
    CREATE TABLE Characters
    (
		Id			INT				PRIMARY KEY IDENTITY,
		Name		VARCHAR(255),
		Concept		VARCHAR(255),
		Chronicle	VARCHAR(255),

    );
END
