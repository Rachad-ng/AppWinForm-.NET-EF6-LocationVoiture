
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/03/2021 19:49:27
-- Generated from EDMX file: C:\Users\Rachad\source\repos\LocationV2\LocationV2\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [LocationVoiture];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Agences'
CREATE TABLE [dbo].[Agences] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [rs] nvarchar(max)  NOT NULL,
    [ville] nvarchar(max)  NOT NULL,
    [tel] nvarchar(max)  NOT NULL,
    [login] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Reservations'
CREATE TABLE [dbo].[Reservations] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [date_debut] datetime  NOT NULL,
    [date_fin] datetime  NOT NULL,
    [valid] tinyint  NOT NULL,
    [VoitureId] int  NOT NULL,
    [ClientId] int  NOT NULL
);
GO

-- Creating table 'Marques'
CREATE TABLE [dbo].[Marques] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [libelle] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Locations'
CREATE TABLE [dbo].[Locations] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [date_debut] datetime  NOT NULL,
    [date_retour] datetime  NOT NULL,
    [kilometrage] int  NOT NULL,
    [Reservation_Id] int  NOT NULL
);
GO

-- Creating table 'Clients'
CREATE TABLE [dbo].[Clients] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nom] nvarchar(max)  NOT NULL,
    [prenom] nvarchar(max)  NOT NULL,
    [cin] nvarchar(max)  NOT NULL,
    [tel] nvarchar(max)  NOT NULL,
    [login] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Voitures'
CREATE TABLE [dbo].[Voitures] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [matricule] nvarchar(max)  NOT NULL,
    [prix_jour] int  NOT NULL,
    [AgenceId] int  NOT NULL,
    [SerieId] int  NOT NULL
);
GO

-- Creating table 'Series'
CREATE TABLE [dbo].[Series] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [libelle] nvarchar(max)  NOT NULL,
    [MarqueId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Agences'
ALTER TABLE [dbo].[Agences]
ADD CONSTRAINT [PK_Agences]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Reservations'
ALTER TABLE [dbo].[Reservations]
ADD CONSTRAINT [PK_Reservations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Marques'
ALTER TABLE [dbo].[Marques]
ADD CONSTRAINT [PK_Marques]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Locations'
ALTER TABLE [dbo].[Locations]
ADD CONSTRAINT [PK_Locations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Clients'
ALTER TABLE [dbo].[Clients]
ADD CONSTRAINT [PK_Clients]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Voitures'
ALTER TABLE [dbo].[Voitures]
ADD CONSTRAINT [PK_Voitures]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Series'
ALTER TABLE [dbo].[Series]
ADD CONSTRAINT [PK_Series]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [AgenceId] in table 'Voitures'
ALTER TABLE [dbo].[Voitures]
ADD CONSTRAINT [FK_AgenceVoiture]
    FOREIGN KEY ([AgenceId])
    REFERENCES [dbo].[Agences]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AgenceVoiture'
CREATE INDEX [IX_FK_AgenceVoiture]
ON [dbo].[Voitures]
    ([AgenceId]);
GO

-- Creating foreign key on [SerieId] in table 'Voitures'
ALTER TABLE [dbo].[Voitures]
ADD CONSTRAINT [FK_VoitureSerie]
    FOREIGN KEY ([SerieId])
    REFERENCES [dbo].[Series]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VoitureSerie'
CREATE INDEX [IX_FK_VoitureSerie]
ON [dbo].[Voitures]
    ([SerieId]);
GO

-- Creating foreign key on [MarqueId] in table 'Series'
ALTER TABLE [dbo].[Series]
ADD CONSTRAINT [FK_SerieMarque]
    FOREIGN KEY ([MarqueId])
    REFERENCES [dbo].[Marques]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SerieMarque'
CREATE INDEX [IX_FK_SerieMarque]
ON [dbo].[Series]
    ([MarqueId]);
GO

-- Creating foreign key on [VoitureId] in table 'Reservations'
ALTER TABLE [dbo].[Reservations]
ADD CONSTRAINT [FK_ReservationVoiture]
    FOREIGN KEY ([VoitureId])
    REFERENCES [dbo].[Voitures]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ReservationVoiture'
CREATE INDEX [IX_FK_ReservationVoiture]
ON [dbo].[Reservations]
    ([VoitureId]);
GO

-- Creating foreign key on [Reservation_Id] in table 'Locations'
ALTER TABLE [dbo].[Locations]
ADD CONSTRAINT [FK_LocationReservation]
    FOREIGN KEY ([Reservation_Id])
    REFERENCES [dbo].[Reservations]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LocationReservation'
CREATE INDEX [IX_FK_LocationReservation]
ON [dbo].[Locations]
    ([Reservation_Id]);
GO

-- Creating foreign key on [ClientId] in table 'Reservations'
ALTER TABLE [dbo].[Reservations]
ADD CONSTRAINT [FK_ReservationClient]
    FOREIGN KEY ([ClientId])
    REFERENCES [dbo].[Clients]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ReservationClient'
CREATE INDEX [IX_FK_ReservationClient]
ON [dbo].[Reservations]
    ([ClientId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------