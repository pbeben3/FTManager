USE [FTManager]
GO
/****** Object:  Table [dbo].[Club]    Script Date: 08.07.2024 16:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Club](
	[ClubId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](20) NOT NULL,
	[Headquarters] [varchar](20) NOT NULL,
	[DateOfFoundation] [date] NOT NULL,
 CONSTRAINT [PK_Club] PRIMARY KEY CLUSTERED 
(
	[ClubId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Equipment]    Script Date: 08.07.2024 16:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Equipment](
	[ClubId] [int] NOT NULL,
	[EquipmentId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](20) NOT NULL,
	[Condition] [varchar](20) NOT NULL,
	[Quantity] [int] NOT NULL,
	[DateOfPurchase] [date] NOT NULL,
 CONSTRAINT [PK_Equipment] PRIMARY KEY CLUSTERED 
(
	[EquipmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Managers]    Script Date: 08.07.2024 16:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Managers](
	[UserId] [int] NOT NULL,
	[Name] [varchar](20) NOT NULL,
	[Surname] [varchar](20) NOT NULL,
	[Nationality] [varchar](20) NOT NULL,
	[Age] [int] NOT NULL,
	[HireDate] [date] NOT NULL,
 CONSTRAINT [PK_Managers] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MatchesPlayed]    Script Date: 08.07.2024 16:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MatchesPlayed](
	[ClubId] [int] NOT NULL,
	[Matchid] [int] IDENTITY(1,1) NOT NULL,
	[MatchDate] [date] NOT NULL,
	[Opponent] [varchar](20) NOT NULL,
	[Place] [varchar](20) NOT NULL,
	[Score] [int] NOT NULL,
	[OpponentScore] [int] NOT NULL,
 CONSTRAINT [PK_MatchesPlayed] PRIMARY KEY CLUSTERED 
(
	[Matchid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Players]    Script Date: 08.07.2024 16:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Players](
	[UserId] [int] NOT NULL,
	[Name] [varchar](20) NOT NULL,
	[Surname] [varchar](20) NOT NULL,
	[Age] [int] NOT NULL,
	[Nationality] [varchar](20) NOT NULL,
	[Position] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Players] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TrainingSessions]    Script Date: 08.07.2024 16:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrainingSessions](
	[ClubId] [int] NOT NULL,
	[SessionId] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NOT NULL,
	[HourOfBeggining] [varchar](5) NOT NULL,
	[HourOfEnd] [varchar](5) NOT NULL,
 CONSTRAINT [PK_TrainingSessions] PRIMARY KEY CLUSTERED 
(
	[SessionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UpcomingMatches]    Script Date: 08.07.2024 16:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UpcomingMatches](
	[ClubId] [int] NOT NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NOT NULL,
	[Place] [varchar](20) NOT NULL,
	[Opponent] [varchar](20) NOT NULL,
 CONSTRAINT [PK_UpcomingMatches] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 08.07.2024 16:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ClubId] [int] NOT NULL,
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](15) NOT NULL,
	[Password] [varchar](15) NOT NULL,
	[Role] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Equipment]  WITH CHECK ADD  CONSTRAINT [FK_Equipment_Club] FOREIGN KEY([ClubId])
REFERENCES [dbo].[Club] ([ClubId])
GO
ALTER TABLE [dbo].[Equipment] CHECK CONSTRAINT [FK_Equipment_Club]
GO
ALTER TABLE [dbo].[Managers]  WITH CHECK ADD  CONSTRAINT [FK_Managers_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Managers] CHECK CONSTRAINT [FK_Managers_Users]
GO
ALTER TABLE [dbo].[MatchesPlayed]  WITH CHECK ADD  CONSTRAINT [FK_MatchesPlayed_Club] FOREIGN KEY([ClubId])
REFERENCES [dbo].[Club] ([ClubId])
GO
ALTER TABLE [dbo].[MatchesPlayed] CHECK CONSTRAINT [FK_MatchesPlayed_Club]
GO
ALTER TABLE [dbo].[Players]  WITH CHECK ADD  CONSTRAINT [FK_Players_Users1] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Players] CHECK CONSTRAINT [FK_Players_Users1]
GO
ALTER TABLE [dbo].[TrainingSessions]  WITH CHECK ADD  CONSTRAINT [FK_TrainingSessions_Club] FOREIGN KEY([ClubId])
REFERENCES [dbo].[Club] ([ClubId])
GO
ALTER TABLE [dbo].[TrainingSessions] CHECK CONSTRAINT [FK_TrainingSessions_Club]
GO
ALTER TABLE [dbo].[UpcomingMatches]  WITH CHECK ADD  CONSTRAINT [FK_UpcomingMatches_Club] FOREIGN KEY([ClubId])
REFERENCES [dbo].[Club] ([ClubId])
GO
ALTER TABLE [dbo].[UpcomingMatches] CHECK CONSTRAINT [FK_UpcomingMatches_Club]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Club] FOREIGN KEY([ClubId])
REFERENCES [dbo].[Club] ([ClubId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Club]
GO
