--Use [UsersAndRewards]
Go

CREATE PROCEDURE GetUsers
As
	RETURN SELECT UserId, [FirstName], [LastName], [Birthdate]
		FROM [User]
Go

CREATE PROCEDURE GetUserById(@id int)
As
	RETURN SELECT UserId, [FirstName], [LastName], [Birthdate]
		FROM [User]
			WHERE UserId = @id
Go

CREATE PROCEDURE InsertUser(
	@firstName nvarchar(100),
	@lastName nvarchar(100),
	@birthdate datetime)
As
	DECLARE @insertedUsers TABLE (UserId int);
	INSERT INTO [User](FirstName, LastName, Birthdate)
		OUTPUT INSERTED.UserId INTO @insertedUsers(UserId)
			VALUES(@firstName, @lastName, @birthdate)
	RETURN SELECT UserId FROM @insertedUsers

Go

CREATE PROCEDURE DeleteUser(@userId int)
As
	DELETE FROM [User] WHERE UserId = @userId;
Go

CREATE PROCEDURE GetRewards
As
	RETURN SELECT RewardId, [Title], [Description]
		FROM [Rewards]
Go


--public List<User> GetUsers()
--{
--}