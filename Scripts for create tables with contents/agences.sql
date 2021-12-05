USE [LocationVoiture]
GO

/****** Object:  Table [dbo].[Agences]    Script Date: 05/12/2021 20:57:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Agences](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[rs] [nvarchar](max) NOT NULL,
	[ville] [nvarchar](max) NOT NULL,
	[tel] [nvarchar](max) NOT NULL,
	[login] [nvarchar](max) NOT NULL,
	[password] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Agences] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO



/*
-- Query: select * from agences
LIMIT 0, 50000

-- Date: 2021-12-05 19:55
*/
INSERT INTO `agences` (`Id`,`RS`,`ville`,`tel`,`login`,`password`) VALUES (1,'TopCar','Berkane','0600606297','rachad','root');
INSERT INTO `agences` (`Id`,`RS`,`ville`,`tel`,`login`,`password`) VALUES (3,'Bachiri','Berkane','0666446099','hassan86','123456');
INSERT INTO `agences` (`Id`,`RS`,`ville`,`tel`,`login`,`password`) VALUES (4,'FastCar','Rabat','0662669021','med-opt','azerty');
INSERT INTO `agences` (`Id`,`RS`,`ville`,`tel`,`login`,`password`) VALUES (5,'Hanae','Rabat','0661335078','hanae','1234');
INSERT INTO `agences` (`Id`,`RS`,`ville`,`tel`,`login`,`password`) VALUES (6,'TheBest','Rabat','0666702575','aminox','0000');
INSERT INTO `agences` (`Id`,`RS`,`ville`,`tel`,`login`,`password`) VALUES (7,'El Wifa9','Casa','065667032','ahmed','0000');
INSERT INTO `agences` (`Id`,`RS`,`ville`,`tel`,`login`,`password`) VALUES (8,'11 Janver','Casa','0661258890','ossama','1234');
INSERT INTO `agences` (`Id`,`RS`,`ville`,`tel`,`login`,`password`) VALUES (9,'El Massira','Casa','0664778022','casawi','admin');
INSERT INTO `agences` (`Id`,`RS`,`ville`,`tel`,`login`,`password`) VALUES (10,'El Massira','Berkane','0666709233','berkane49','12345');
