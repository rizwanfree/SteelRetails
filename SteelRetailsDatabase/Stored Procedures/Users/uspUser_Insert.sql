CREATE PROCEDURE [dbo].[uspUser_InsertUser]
    @Id int,
    @Username NVARCHAR(50),
    @Password NVARCHAR(50)
AS
BEGIN
    INSERT INTO Users (Username, Password)
    VALUES (@Username, @Password);
END;
