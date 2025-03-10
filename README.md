USE [Graph]
GO
CREATE PROCEDURE SP_FILTERED
@Department NVARCHAR(100)
AS
BEGIN
   SELECT * FROM Employees WHERE Department = "HR"
END

--ALTER TABLE Employees
--ADD Department NVARCHAR(100)

--CREATE TABLE Employees (
		
--		id  INT  IDENTITY(1,1) PRIMARY KEY ,
--		name NVARCHAR(50),
--		email NVARCHAR(50) UNIQUE,
--		Department NVARCHAR,
--		CreatedAt TIMESTAMP,
--)

--CREATE PROCEDURE SP_ALLEMPLOYEE
--AS
--BEGIN
-- SELECT * FROM Employees;
--END

--CREATE PROCEDURE SP_DELETEBYIDEMPLOYEE
--@id INT 
--AS
--BEGIN
-- DELETE  FROM  Employees WHERE id = @id
--END



--CREATE PROCEDURE SP_UPDATEEMPLOYEE
--@NAME NVARCHAR,
--@email NVARCHAR,
--@Department NVARCHAR,
--@id INT 
--AS
--BEGIN
-- UPDATE Employees SET name = @NAME, email = @email , Department = @Department WHERE id = @id
--END

--CREATE PROCEDURE SP_INSERTEMPLOYEE
--@NAME NVARCHAR(50),
--@email NVARCHAR(50),
--@Department NVARCHAR
--AS
--BEGIN
--INSERT INTO Employees (name,email,Department) VALUES (@NAME,@email,@Department)
--END

USE [Graph]
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTEMPLOYEE]    Script Date: 3/9/2025 11:52:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SP_INSERTEMPLOYEE]
@NAME NVARCHAR(50),
@email NVARCHAR(50),
@Department NVARCHAR (100)
AS
BEGIN
INSERT INTO Employees (name,email,Department) VALUES (@NAME,@email,@Department)
END
