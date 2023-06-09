CREATE DATABASE organizador_tareas
GO
USE [organizador_tareas]
GO
/****** Object:  Table [dbo].[Relacion_Tareas]    Script Date: 06/04/2023 22:18:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Relacion_Tareas](
	[id_tarea_padre] [int] NOT NULL,
	[id_tarea_hija] [int] NOT NULL,
 CONSTRAINT [PK_Relacion_Tareas] PRIMARY KEY CLUSTERED 
(
	[id_tarea_padre] ASC,
	[id_tarea_hija] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tarea]    Script Date: 06/04/2023 22:18:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tarea](
	[nombre] [varchar](500) NULL,
	[fecha_vencimiento] [datetime] NULL,
	[completado] [tinyint] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Relacion_Tareas]  WITH CHECK ADD  CONSTRAINT [FK_Relacion_Tareas_Tarea] FOREIGN KEY([id_tarea_hija])
REFERENCES [dbo].[Tarea] ([id])
GO
ALTER TABLE [dbo].[Relacion_Tareas] CHECK CONSTRAINT [FK_Relacion_Tareas_Tarea]
GO
ALTER TABLE [dbo].[Relacion_Tareas]  WITH CHECK ADD  CONSTRAINT [FK_Relacion_Tareas_Tarea1] FOREIGN KEY([id_tarea_padre])
REFERENCES [dbo].[Tarea] ([id])
GO
ALTER TABLE [dbo].[Relacion_Tareas] CHECK CONSTRAINT [FK_Relacion_Tareas_Tarea1]
GO
