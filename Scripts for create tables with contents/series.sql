USE [LocationVoiture]
GO

/****** Object:  Table [dbo].[Series]    Script Date: 05/12/2021 20:56:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Series](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[libelle] [nvarchar](max) NOT NULL,
	[MarqueId] [int] NOT NULL,
 CONSTRAINT [PK_Series] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Series]  WITH CHECK ADD  CONSTRAINT [FK_SerieMarque] FOREIGN KEY([MarqueId])
REFERENCES [dbo].[Marques] ([Id])
GO

ALTER TABLE [dbo].[Series] CHECK CONSTRAINT [FK_SerieMarque]
GO



/*
-- Query: select * from series
LIMIT 0, 50000

-- Date: 2021-12-05 19:55
*/
INSERT INTO `series` (`Id`,`libelle`,`marqueId`) VALUES (1,'Picanto',1);
INSERT INTO `series` (`Id`,`libelle`,`marqueId`) VALUES (2,'Rio',1);
INSERT INTO `series` (`Id`,`libelle`,`marqueId`) VALUES (3,'Sorento',1);
INSERT INTO `series` (`Id`,`libelle`,`marqueId`) VALUES (4,'Xceed',1);
INSERT INTO `series` (`Id`,`libelle`,`marqueId`) VALUES (5,'Sportage',1);
INSERT INTO `series` (`Id`,`libelle`,`marqueId`) VALUES (6,'Logan',2);
INSERT INTO `series` (`Id`,`libelle`,`marqueId`) VALUES (7,'Lodgy',2);
INSERT INTO `series` (`Id`,`libelle`,`marqueId`) VALUES (8,'Duster',2);
INSERT INTO `series` (`Id`,`libelle`,`marqueId`) VALUES (9,'Stepway',2);
INSERT INTO `series` (`Id`,`libelle`,`marqueId`) VALUES (10,'Sandero',2);
INSERT INTO `series` (`Id`,`libelle`,`marqueId`) VALUES (11,'I10',3);
INSERT INTO `series` (`Id`,`libelle`,`marqueId`) VALUES (12,'I20',3);
INSERT INTO `series` (`Id`,`libelle`,`marqueId`) VALUES (13,'I30',3);
INSERT INTO `series` (`Id`,`libelle`,`marqueId`) VALUES (14,'Accent',3);
INSERT INTO `series` (`Id`,`libelle`,`marqueId`) VALUES (15,'Tucson',3);
INSERT INTO `series` (`Id`,`libelle`,`marqueId`) VALUES (16,'208',4);
INSERT INTO `series` (`Id`,`libelle`,`marqueId`) VALUES (17,'308',4);
INSERT INTO `series` (`Id`,`libelle`,`marqueId`) VALUES (18,'508',4);
INSERT INTO `series` (`Id`,`libelle`,`marqueId`) VALUES (19,'2008',4);
INSERT INTO `series` (`Id`,`libelle`,`marqueId`) VALUES (20,'3008',4);
INSERT INTO `series` (`Id`,`libelle`,`marqueId`) VALUES (21,'Evoque',5);
INSERT INTO `series` (`Id`,`libelle`,`marqueId`) VALUES (22,'Discovry',5);
INSERT INTO `series` (`Id`,`libelle`,`marqueId`) VALUES (23,'Velar',5);
INSERT INTO `series` (`Id`,`libelle`,`marqueId`) VALUES (24,'Sport',5);
INSERT INTO `series` (`Id`,`libelle`,`marqueId`) VALUES (25,'Vogue',5);
INSERT INTO `series` (`Id`,`libelle`,`marqueId`) VALUES (26,'Polo',6);
INSERT INTO `series` (`Id`,`libelle`,`marqueId`) VALUES (27,'Golf8',6);
INSERT INTO `series` (`Id`,`libelle`,`marqueId`) VALUES (28,'Passat',6);
INSERT INTO `series` (`Id`,`libelle`,`marqueId`) VALUES (29,'Tiguan',6);
INSERT INTO `series` (`Id`,`libelle`,`marqueId`) VALUES (30,'Touareg',6);
INSERT INTO `series` (`Id`,`libelle`,`marqueId`) VALUES (31,'A220',7);
INSERT INTO `series` (`Id`,`libelle`,`marqueId`) VALUES (32,'C220',7);
INSERT INTO `series` (`Id`,`libelle`,`marqueId`) VALUES (33,'E350',7);
INSERT INTO `series` (`Id`,`libelle`,`marqueId`) VALUES (34,'GLE400 Coupe',7);
INSERT INTO `series` (`Id`,`libelle`,`marqueId`) VALUES (35,'S400',7);
