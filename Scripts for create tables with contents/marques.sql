USE [LocationVoiture]
GO

/****** Object:  Table [dbo].[Marques]    Script Date: 05/12/2021 20:54:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Marques](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[libelle] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Marques] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/*
-- Query: select * from marques
LIMIT 0, 50000

-- Date: 2021-12-05 19:53
*/
INSERT INTO `marques` (`Id`,`libelle`) VALUES (1,'Kia');
INSERT INTO `marques` (`Id`,`libelle`) VALUES (2,'Dacia');
INSERT INTO `marques` (`Id`,`libelle`) VALUES (3,'Hyundai');
INSERT INTO `marques` (`Id`,`libelle`) VALUES (4,'Peugeot');
INSERT INTO `marques` (`Id`,`libelle`) VALUES (5,'Range Rover');
INSERT INTO `marques` (`Id`,`libelle`) VALUES (6,'VW');
INSERT INTO `marques` (`Id`,`libelle`) VALUES (7,'Mercedes');
