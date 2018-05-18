using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersAndRewards.Shared;

namespace UsersAndRewards.DAL.DataLayer
{
	public class InMemoryData : IData
	{
		private List<User> users;

		private List<Reward> rewards;

		public InMemoryData()
		{
			users = new List<User>();
			rewards = new List<Reward>();
		}

        public void AddReward(Reward reward)
        {
            var maxId = 0;
            var ids = rewards.Select(u => u.RewardId);
            if (ids.Count() != 0)
            {
                maxId = ids.Max();
            }

            reward.RewardId = maxId + 1;
            rewards.Add(reward);
        }

        public void AddUser(User user)
		{
			var maxId = 0;
			var ids = users.Select(u => u.UserId);
			if (ids.Count() != 0)
			{
				maxId = ids.Max();
			}

			user.UserId = maxId + 1;
			users.Add(user);
		}



        public void DeleteReward(int rewardId)
		{
               rewards.RemoveAll(x => x.RewardId == rewardId);
        }

		public void DeleteUser(int userId)
		{
                users.RemoveAll(x => x.UserId == userId);
        }

		public Reward GetRewardById(int rewardId)
		{
			throw new NotImplementedException();
		}

		public List<Reward> GetRewards()
		{
			return rewards;
		}

		public User GetUserById(int userId)
		{
            return users.FirstOrDefault(p => p.UserId.Equals(userId));
		}

		public List<User> GetUsers()
		{
			return users;
		}

		public void UpdateReward(Reward reward)
		{
			throw new NotImplementedException();
		}

		public void UpdateUser(User user)
		{
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].UserId == user.UserId) users[i] = user;
            }
        }
	}
}
