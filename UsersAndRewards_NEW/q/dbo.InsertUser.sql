
CREATE PROCEDURE InsertUser(
	@firstName nvarchar(100),
	@lastName nvarchar(100),
	@birthdate datetime,
	@rewardIds int)
As
	DECLARE @insertedUsers TABLE (UserId int);
	INSERT INTO [User](FirstName, LastName, Birthdate)
		OUTPUT INSERTED.UserId INTO @insertedUsers(UserId)
			VALUES(@firstName, @lastName, @birthdate)
	RETURN SELECT UserId FROM @insertedUsers