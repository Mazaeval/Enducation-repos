using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersAndRewards.Shared;

namespace UsersAndRewards.PL.WinForms.UserForms
{
    public partial class UserForm : Form
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public List<Reward> CheckedRewards { get; private set; } = new List<Reward>();
        private List<Reward> AllRewards { get; set; }



        public UserForm(User user, List<Reward> allRewards)
        {
            AllRewards = allRewards;
            InitializeComponent();
            foreach (var a in allRewards)
            {
                var hasReward = user != null && user.Rewards.Contains(a);
                ctlCheckedListBoxRewards.Items.Add(a.Title, hasReward);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            foreach (var checkedReward in ctlCheckedListBoxRewards.CheckedItems)
            {
                var r = AllRewards.FirstOrDefault(i => i.Title.Equals((string)checkedReward));
                if (r != null)
                    CheckedRewards.Add(r);
            }

            if (!ValidateChildren())
            {
                DialogResult = DialogResult.None;
            }
            BirthDate = ctlBirthdate.Value;
        }

        private void Validate(Control ctl, string ctrlValue, string errorMessage, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ctrlValue))
            {
                ctlErrorProvider.SetError(ctl, errorMessage);
                e.Cancel = true;
            }
            else
            {
                ctlErrorProvider.SetError(txtFirstName, string.Empty);
                e.Cancel = false;
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            Validate(txtFirstName, txtFirstName.Text.Trim(), "Name cannot be empty", e);
        }

        private void txtFirstName_Validated(object sender, EventArgs e)
        {
            FirstName = txtFirstName.Text.Trim();
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            Validate(txtLastName, txtLastName.Text.Trim(), "Last Name cannot be empty", e);
        }

        private void txtLastName_Validated(object sender, EventArgs e)
        {
            LastName = txtLastName.Text.Trim();
        }

        private void ctlCheckedListBoxRewards_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
