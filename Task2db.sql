USE [task2]
GO
/****** Object:  Table [dbo].[tblTask2Data]    Script Date: 2022/11/07 23:28:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTask2Data](
	[Temperature] [int] NULL,
	[humidity] [int] NULL,
	[Weight] [decimal](18, 0) NULL,
	[Width] [decimal](18, 0) NULL,
	[Length] [decimal](18, 0) NULL,
	[Depth] [decimal](18, 0) NULL,
	[Time] [datetime] NULL,
	[Checked] [bit] NULL,
	[Name] [text] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_tblTask2Data] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
