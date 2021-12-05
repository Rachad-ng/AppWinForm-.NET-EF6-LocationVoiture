USE [LocationVoiture]
GO

/****** Object:  Table [dbo].[Voitures]    Script Date: 05/12/2021 20:57:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Voitures](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[matricule] [nvarchar](max) NOT NULL,
	[prix_jour] [int] NOT NULL,
	[AgenceId] [int] NOT NULL,
	[SerieId] [int] NOT NULL,
 CONSTRAINT [PK_Voitures] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Voitures]  WITH CHECK ADD  CONSTRAINT [FK_AgenceVoiture] FOREIGN KEY([AgenceId])
REFERENCES [dbo].[Agences] ([Id])
GO

ALTER TABLE [dbo].[Voitures] CHECK CONSTRAINT [FK_AgenceVoiture]
GO

ALTER TABLE [dbo].[Voitures]  WITH CHECK ADD  CONSTRAINT [FK_VoitureSerie] FOREIGN KEY([SerieId])
REFERENCES [dbo].[Series] ([Id])
GO

ALTER TABLE [dbo].[Voitures] CHECK CONSTRAINT [FK_VoitureSerie]
GO



/*
-- Query: select * from voitures
LIMIT 0, 50000

-- Date: 2021-12-05 19:56
*/
INSERT INTO `voitures` (`Id`,`matricule`,`prix_jour`,`serieId`,`agenceId`) VALUES (2,'40320-A-49',400,14,1);
INSERT INTO `voitures` (`Id`,`matricule`,`prix_jour`,`serieId`,`agenceId`) VALUES (3,'50356-A-49',600,5,1);
INSERT INTO `voitures` (`Id`,`matricule`,`prix_jour`,`serieId`,`agenceId`) VALUES (4,'48290-A-49',300,9,1);
INSERT INTO `voitures` (`Id`,`matricule`,`prix_jour`,`serieId`,`agenceId`) VALUES (5,'50375-A-49',1000,23,1);
INSERT INTO `voitures` (`Id`,`matricule`,`prix_jour`,`serieId`,`agenceId`) VALUES (7,'40930-A-49',700,27,1);
