USE [SalesDb]
GO

/****** Object:  Table [dbo].[Customer_Tb]    Script Date: 31-01-2026 15:35:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Customer_Tb](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[customer_id] [int] NOT NULL,
	[name] [varchar](100) NOT NULL,
	[phone_no] [varchar](100) NOT NULL,
	[city] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Customer_Tb] PRIMARY KEY CLUSTERED 
(
	[customer_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

