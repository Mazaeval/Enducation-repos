using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersAndRewards.Shared
{
    public class RewardViewModel
    {
        public int RewardId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public static RewardViewModel ToModel(Reward reward)
        {
            var model = new RewardViewModel();
            model.RewardId = reward.RewardId;
            model.Title = reward.Title;
            model.Description = reward.Description;

            return model;
        }
    }
}
