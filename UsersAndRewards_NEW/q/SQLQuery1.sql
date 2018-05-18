CREATE PROCEDURE DeleteReward(@rewardId int)
As
	DELETE FROM [Reward] WHERE RewardId = @rewardId;