CREATE PROCEDURE [dbo].[uspUser_CheckLoginDetails]
(
	@Username nvarchar(50)
	,@Password nvarchar(50)
)
AS
	BEGIN

		DECLARE @IsLoginCorrect BIT
		SET @IsLoginCorrect = 0

		IF EXISTS (SELECT '#' FROM [dbo].[Users] WHERE [Username] = @Username AND [Password] = @Password)
			BEGIN
				SET @IsLoginCorrect = 1
			END
		SELECT @IsLoginCorrect AS '@IsLoginCorrect'


	END
