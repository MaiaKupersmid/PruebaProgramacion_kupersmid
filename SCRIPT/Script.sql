USE [GestionAlumnos]
GO
/****** Object:  Table [dbo].[Alumnos]    Script Date: 20/9/2023 09:42:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumnos](
	[Nombre] [varchar](max) NOT NULL,
	[Apellido] [varchar](max) NOT NULL,
	[Legajo] [varchar](max) NOT NULL,
	[Curso] [varchar](50) NOT NULL,
	[Promedio] [int] NULL,
	[Especialidad] [varchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Alumnos] ([Nombre], [Apellido], [Legajo], [Curso], [Promedio], [Especialidad]) VALUES (N'Maia', N'Kup', N's048', N'4IC', 8, N'info')
INSERT [dbo].[Alumnos] ([Nombre], [Apellido], [Legajo], [Curso], [Promedio], [Especialidad]) VALUES (N'Juli', N'Izbi', N'p455', N'4IK', 5, N'constru')
INSERT [dbo].[Alumnos] ([Nombre], [Apellido], [Legajo], [Curso], [Promedio], [Especialidad]) VALUES (N'Emi', N'Arm', N'n488', N'4IM', 6, N'meca')
GO
