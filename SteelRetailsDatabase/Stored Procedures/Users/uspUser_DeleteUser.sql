CREATE PROCEDURE [dbo].[uspUser_DeleteUser]
    @Id INT
AS
BEGIN
    DELETE FROM Users WHERE Id = @Id;
END;
