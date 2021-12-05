USE [LocationVoiture]
GO

/****** Object:  Table [dbo].[Clients]    Script Date: 05/12/2021 20:59:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Clients](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[nom] [nvarchar](max) NOT NULL,
	[prenom] [nvarchar](max) NOT NULL,
	[cin] [nvarchar](max) NOT NULL,
	[tel] [nvarchar](max) NOT NULL,
	[login] [nvarchar](max) NOT NULL,
	[password] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO



/*
-- Query: select * from clients
LIMIT 0, 50000

-- Date: 2021-12-05 19:56
*/
INSERT INTO `clients` (`Id`,`nom`,`prenom`,`cin`,`tel`,`login`,`password`) VALUES (1,'Neggaz','Rachad','FA154987','0600606297','rachford','azer1234');
INSERT INTO `clients` (`Id`,`nom`,`prenom`,`cin`,`tel`,`login`,`password`) VALUES (2,'Neggaz','Assim','S457688','0666334455','assim95','hello');
INSERT INTO `clients` (`Id`,`nom`,`prenom`,`cin`,`tel`,`login`,`password`) VALUES (3,'Atya','Anouar','F223356','0667204460','anourat','123456');
INSERT INTO `clients` (`Id`,`nom`,`prenom`,`cin`,`tel`,`login`,`password`) VALUES (4,'Oufkir','Youssef','F567899','0600229944','yousf44','AQWXSZ');
INSERT INTO `clients` (`Id`,`nom`,`prenom`,`cin`,`tel`,`login`,`password`) VALUES (5,'Mhada','Mohamed','FA335577','0667021567','Mido','12345');
INSERT INTO `clients` (`Id`,`nom`,`prenom`,`cin`,`tel`,`login`,`password`) VALUES (6,'Berehab','Karim','FA205477','0666203040','karimo','112233');
