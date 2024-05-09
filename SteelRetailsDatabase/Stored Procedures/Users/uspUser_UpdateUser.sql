CREATE PROCEDURE [dbo].[uspUser_UpdateUser]
    @Id INT,
    @Username NVARCHAR(50),
    @Password NVARCHAR(50)
AS
BEGIN
    UPDATE Users 
    SET Username = @Username, Password = @Password
    WHERE Id = @Id;
END;
