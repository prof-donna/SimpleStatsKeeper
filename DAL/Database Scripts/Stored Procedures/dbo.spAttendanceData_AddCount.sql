USE [SimpleStats]
GO

/****** Object: SqlProcedure [dbo].[spAttendanceData_AddCount] Script Date: 2020-04-08 9:24:49 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP PROCEDURE [dbo].[spAttendanceData_AddCount];


GO
CREATE PROCEDURE [dbo].[spAttendanceData_AddCount]
	@Count int,
	@Date DateTime
AS
	INSERT INTO dbo.AttendanceData (Count, Date)
	VALUES (@Count, @Date)
RETURN 0
