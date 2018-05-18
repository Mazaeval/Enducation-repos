Use [UsersAndRewards]
Go

CREATE PROCEDURE InsertReward(
	@title nvarchar(100),
	@description nvarchar(200))

As
	DECLARE @insertedRewards TABLE (RewardId int);
	INSERT INTO [Reward](Title, Description)
		OUTPUT INSERTED.RewardId INTO @insertedRewards(RewardId)
			VALUES(@title, @description)
	RETURN SELECT RewardId FROM @insertedRewards
Go

exec GetRewards