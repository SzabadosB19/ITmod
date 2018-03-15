CREATE TABLE [dbo].[Felhasznalo] (
    [Id]              INT           IDENTITY (1, 1) NOT NULL,
    [Nev]             NVARCHAR (50) NOT NULL,
    [Email]           NVARCHAR (50) NOT NULL,
    [Cim]             NVARCHAR (50) NOT NULL,
    [Jelszo]          NVARCHAR (50) NOT NULL,
    [Telefonszam]     NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

