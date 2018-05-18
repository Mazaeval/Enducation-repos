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
            ctlRewards.AutoGenerateColumns = false;
            UpdateUsersGrid();
            UpdateRewardsGrid();
        }

		private void btnAddUser_Click(object sender, EventArgs e)
		{
			AddUser();
		}

		private void btnAddReward_Click(object sender, EventArgs e)
		{
            AddReward();
		}



		private void AddUser()
		{
			var userForm = new UserForm(null, logic.GetRewards());
			if (userForm.ShowDialog() == DialogResult.OK)
			{
				var name = userForm.FirstName;
				var last = userForm.LastName;
                var birth = userForm.BirthDate;
				var user = new User();
				user.FirstName = name;
				user.LastName = last;
                user.Birthdate = birth;
				user.Rewards = userForm.CheckedRewards;
				// initialization
				logic.AddUser(user);
				UpdateUsersGrid();
			}
		}

        private void EditUser()
        {
            var currentUser = new User();
            int currentId = Convert.ToInt32(ctlUsers["Id", ctlUsers.CurrentRow.Index].Value.ToString());
            currentUser = logic.GetUserById(currentId);
            var userForm = new UserForm(currentUser, logic.GetRewards());
            if (userForm.ShowDialog() == DialogResult.OK)
            {
                var name = userForm.FirstName;
                var last = userForm.LastName;
                var birth = userForm.BirthDate;
                var user = new User();
                user.FirstName = name;
                user.LastName = last;
                user.Birthdate = birth;
                user.UserId = currentUser.UserId;
                user.Rewards = userForm.CheckedRewards;
                // initialization
                logic.UpdateUser(user);
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
                logic.DeleteUser(Convert.ToInt32(ctlUsers["Id", ctlUsers.CurrentRow.Index].Value.ToString()));
			}
            UpdateUsersGrid();

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

        private void ctlUsers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddReward();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show(
            "Are you sure?",
            "Warning",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                logic.DeleteReward(Convert.ToInt32(ctlRewards["IdReward", ctlRewards.CurrentRow.Index].Value.ToString()));
            }
            UpdateRewardsGrid();
        }

        private void ctlRewards_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUsersEdit_Click(object sender, EventArgs e)
        {
            EditUser();
        }
    }
}
