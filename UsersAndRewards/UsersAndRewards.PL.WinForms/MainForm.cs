using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UsersAndRewards.PL.WinForms.UserForms;
using UsersAndRewards.PL.WinForms.RewardForms;
using UsersAndRewards.Shared;

namespace UsersAndRewards.PL.WinForms
{
	public partial class MainForm : Form
	{
		private ILogic logic;

		public MainForm(ILogic logic)
		{
			InitializeComponent();
			this.logic = logic;
		}

		private void btnAddUser_Click(object sender, EventArgs e)
		{
			AddUser();
		}

		private void btnAddReward_Click(object sender, EventArgs e)
		{
            AddReward();
		}

		private void btnAddUserContextMenu_Click(object sender, EventArgs e)
		{
			AddUser();
		}

		private void AddUser()
		{
			var userForm = new UserForm();
			if (userForm.ShowDialog() == DialogResult.OK)
			{
				var name = userForm.FirstName;
				var last = userForm.LastName;
				var user = new User();
				user.FirstName = name;
				user.LastName = last;
				user.Rewards = logic.GetRewards();
				// initialization
				logic.AddUser(user);
				UpdateUsersGrid();
			}
		}

        private void AddReward()
        {
            var rewardForm = new RewardForm();
            if (rewardForm.ShowDialog() == DialogResult.OK)
            {
                var title = rewardForm.Title;
                var description = rewardForm.Description;
                var reward = new Reward();
                reward.Title = title;
                reward.Description = description;
                logic.AddReward(reward);
                UpdateRewardsGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
		{
			var res = MessageBox.Show(
				"Are you sure?",
				"Warning",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);
			if (res == DialogResult.Yes)
			{
				// remove user
			}
		}

		private void UpdateUsersGrid()
		{
			var users = logic.GetUsersViewModel();
			ctlUsers.DataSource = users;
			ctlUsers.Refresh();
		}

        private void UpdateRewardsGrid()
        {
            var rewards = logic.GetRewardsViewModel();
            ctlRewards.DataSource = rewards;
            ctlRewards.Refresh();
        }
    }
}
