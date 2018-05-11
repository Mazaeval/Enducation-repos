using System.Collections.Generic;
using UsersAndRewards.Shared;

namespace UsersAndRewards.PL.Web.ViewModels
{
	public class UsersAndRewardsViewModel
	{
		public User User { get; set; }

		public List<RewardViewModel> AllRewards { get; set; }

		public static UsersAndRewardsViewModel CreateModel(User user, List<Reward> rewards)
		{
			var model = new UsersAndRewardsViewModel();
			model.User = user;
			model.AllRewards = new List<RewardViewModel>();
			foreach (var r in rewards)
			{
				var isChecked = user == null ? false : user.Rewards.Contains(r);
				var rewardModel = RewardViewModel.ToModel(r, isChecked);
				model.AllRewards.Add(rewardModel);
			}

			return model;
		}
	}
}