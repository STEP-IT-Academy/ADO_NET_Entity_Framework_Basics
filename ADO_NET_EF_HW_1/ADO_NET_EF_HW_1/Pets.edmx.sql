
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/18/2020 16:23:30
-- Generated from EDMX file: C:\Users\kotka\source\repos\WindowsFormsApp_ADO_NET_HW_5\WindowsFormsApp_ADO_NET_HW_5\Pets.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Pets];
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

-- Creating table 'CatSet'
CREATE TABLE [dbo].[CatSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nickname] nvarchar(max)  NOT NULL,
    [Age] int  NOT NULL,
    [Owner_Id] int  NOT NULL
);
GO

-- Creating table 'OwnerSet'
CREATE TABLE [dbo].[OwnerSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Surname] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'CatSet'
ALTER TABLE [dbo].[CatSet]
ADD CONSTRAINT [PK_CatSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'OwnerSet'
ALTER TABLE [dbo].[OwnerSet]
ADD CONSTRAINT [PK_OwnerSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Owner_Id] in table 'CatSet'
ALTER TABLE [dbo].[CatSet]
ADD CONSTRAINT [FK_OwnerCat]
    FOREIGN KEY ([Owner_Id])
    REFERENCES [dbo].[OwnerSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OwnerCat'
CREATE INDEX [IX_FK_OwnerCat]
ON [dbo].[CatSet]
    ([Owner_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- ------------------------------------------------
--
