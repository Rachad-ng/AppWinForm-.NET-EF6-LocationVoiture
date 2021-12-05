USE [LocationVoiture]
GO

/****** Object:  Table [dbo].[Reservations]    Script Date: 05/12/2021 20:59:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Reservations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[date_debut] [datetime] NOT NULL,
	[date_fin] [datetime] NOT NULL,
	[valid] [tinyint] NOT NULL,
	[VoitureId] [int] NOT NULL,
	[ClientId] [int] NOT NULL,
 CONSTRAINT [PK_Reservations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Reservations]  WITH CHECK ADD  CONSTRAINT [FK_ReservationClient] FOREIGN KEY([ClientId])
REFERENCES [dbo].[Clients] ([Id])
GO

ALTER TABLE [dbo].[Reservations] CHECK CONSTRAINT [FK_ReservationClient]
GO

ALTER TABLE [dbo].[Reservations]  WITH CHECK ADD  CONSTRAINT [FK_ReservationVoiture] FOREIGN KEY([VoitureId])
REFERENCES [dbo].[Voitures] ([Id])
GO

ALTER TABLE [dbo].[Reservations] CHECK CONSTRAINT [FK_ReservationVoiture]
GO



/*
-- Query: select * from reservations
LIMIT 0, 50000

-- Date: 2021-12-05 19:57
*/
INSERT INTO `reservations` (`Id`,`date_debut`,`date_fin`,`valid`,`voitureId`,`clientId`) VALUES (1,'01-11-2021','10-11-2021',0,2,1);
INSERT INTO `reservations` (`Id`,`date_debut`,`date_fin`,`valid`,`voitureId`,`clientId`) VALUES (2,'14-11-2021','19-11-2021',0,4,2);
INSERT INTO `reservations` (`Id`,`date_debut`,`date_fin`,`valid`,`voitureId`,`clientId`) VALUES (3,'15-11-2021','22-11-2021',0,2,3);
INSERT INTO `reservations` (`Id`,`date_debut`,`date_fin`,`valid`,`voitureId`,`clientId`) VALUES (4,'10-11-2021','10-12-2021',0,3,2);
INSERT INTO `reservations` (`Id`,`date_debut`,`date_fin`,`valid`,`voitureId`,`clientId`) VALUES (5,'05-12-2021','20-12-2021',1,5,1);
INSERT INTO `reservations` (`Id`,`date_debut`,`date_fin`,`valid`,`voitureId`,`clientId`) VALUES (9,'01-01-2022','08-01-2022',1,5,2);
INSERT INTO `reservations` (`Id`,`date_debut`,`date_fin`,`valid`,`voitureId`,`clientId`) VALUES (10,'10-01-2022','20-01-2022',1,5,3);
INSERT INTO `reservations` (`Id`,`date_debut`,`date_fin`,`valid`,`voitureId`,`clientId`) VALUES (11,'25-01-2022','05-02-2022',1,5,4);
INSERT INTO `reservations` (`Id`,`date_debut`,`date_fin`,`valid`,`voitureId`,`clientId`) VALUES (12,'12-02-2022','20-02-2022',0,5,5);
