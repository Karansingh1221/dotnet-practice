USE [SalesDb]
GO

/****** Object:  Table [dbo].[Sales_Person_Master]    Script Date: 31-01-2026 15:36:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Sales_Person_Master](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[sales_person_id] [int] NOT NULL,
	[name] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Sales_Person_Master] PRIMARY KEY CLUSTERED 
(
	[sales_person_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

