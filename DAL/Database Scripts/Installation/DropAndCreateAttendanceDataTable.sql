USE [SimpleStats]
GO

/****** Object: Table [dbo].[AttendanceData] Script Date: 2020-04-08 7:54:30 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[AttendanceData];


GO
CREATE TABLE [dbo].[AttendanceData] (
    [Id]    INT      IDENTITY (1, 1) NOT NULL,
    [Count] INT      NOT NULL,
    [Date]  DATETIME NOT NULL
);


