USE [LocationVoiture]
GO

/****** Object:  Table [dbo].[Locations]    Script Date: 05/12/2021 21:00:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Locations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[date_debut] [datetime] NOT NULL,
	[date_retour] [datetime] NOT NULL,
	[kilometrage] [int] NOT NULL,
	[Reservation_Id] [int] NOT NULL,
 CONSTRAINT [PK_Locations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Locations]  WITH CHECK ADD  CONSTRAINT [FK_LocationReservation] FOREIGN KEY([Reservation_Id])
REFERENCES [dbo].[Reservations] ([Id])
GO

ALTER TABLE [dbo].[Locations] CHECK CONSTRAINT [FK_LocationReservation]
GO

/*
-- Query: select * from locations
LIMIT 0, 50000

-- Date: 2021-12-05 19:57
*/
INSERT INTO `locations` (`Id`,`date_debut`,`date_retour`,`kilometrage`,`reservationId`) VALUES (1,'05-12-2021','01-01-1990',680,5);
INSERT INTO `locations` (`Id`,`date_debut`,`date_retour`,`kilometrage`,`reservationId`) VALUES (2,'01-01-2022','01-01-1990',550,9);
INSERT INTO `locations` (`Id`,`date_debut`,`date_retour`,`kilometrage`,`reservationId`) VALUES (3,'10-01-2022','01-01-1990',1100,10);
