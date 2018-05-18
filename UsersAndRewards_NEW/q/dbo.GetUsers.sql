
CREATE PROCEDURE GetUsers
As
	SELECT UserId, [FirstName], [LastName], [Birthdate]
		FROM [User]