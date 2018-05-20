﻿using System;
using System.Collections.Generic;
using System.Linq;
using UsersAndRewards.DAL.DataLayer;
using UsersAndRewards.Shared;

namespace UsersAndRewards.BL.Logic
{
	public class Logic : ILogic
	{
		private IData data;
		public Logic()
		{
			data = new SqlData();
		}
		public void AddReward(Reward reward)
		{
			// logic
			data.AddReward(reward);
		}

		public void AddUser(User user)
		{
			// logic
			data.AddUser(user);
		}

		public void DeleteReward(int rewardId)
		{
			data.DeleteReward(rewardId);
		}

		public void DeleteUser(int userId)
		{
            data.DeleteUser(userId);
		}

		public Reward GetRewardById(int rewardId)
		{
			throw new NotImplementedException();
		}

		public List<Reward> GetRewards()
		{
			// logic
			return data.GetRewards();
		}

		public User GetUserById(int userId)
		{
            return data.GetUserById(userId);
        }

		public List<User> GetUsers()
		{
			// logic
			return data.GetUsers();
		}

		public List<UserViewModel> GetUsersViewModel()
		{
			// logic
			var users =  GetUsers();
			var usersModels = users.Select(u => UserViewModel.ToModel(u));
			// var usersModels = users.Select(UserViewModel.ToModel);
			return usersModels.ToList();
		}

        public List<RewardViewModel> GetRewardsViewModel()
        {
            // logic
            var rewards = GetRewards();
            var rewardsModels = rewards.Select(u => RewardViewModel.ToModel(u));
            // var usersModels = users.Select(UserViewModel.ToModel);
            return rewardsModels.ToList();
        }

        public void UpdateReward(Reward reward)
		{
			throw new NotImplementedException();
		}

		public void UpdateUser(User user)
		{
			data.UpdateUser(user);
		}
	}
}
