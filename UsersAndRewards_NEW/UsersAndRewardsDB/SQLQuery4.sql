Use [UsersAndRewards]
Create table [User] (UserId INT IDENTITY(1,1) PRIMARY KEY,
					FirstName char (100), 
					LastName char (100), 
					Birthdate datetime
					);
Go
Create table [Reward] (RewardId int IDENTITY(1,1) PRIMARY KEY, 
						Title char (100), 
						[Description] char (200),
						UserId int FOREIGN KEY REFERENCES [User](UserId)
						);
Go