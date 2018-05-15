using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsersAndRewards.PL.WinForms.RewardForms
{
    public partial class RewardForm : Form
    {
        public string Title { get; private set; }
        public string Description { get; private set; }

        public RewardForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                DialogResult = DialogResult.None;
            }
        }

        private void Validate(Control ctl, string ctrlValue, string errorMessage, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ctrlValue))
            {
                ctlErrorProviderRewards.SetError(ctl, errorMessage);
                e.Cancel = true;
            }
            else
            {
                ctlErrorProviderRewards.SetError(txtTitle, string.Empty);
                e.Cancel = false;
            }
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            Validate(txtTitle, txtTitle.Text.Trim(), "Title cannot be empty", e);
        }

        private void txtTitle_Validated(object sender, EventArgs e)
        {
            Title = txtTitle.Text.Trim();
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            Validate(txtDescription, txtDescription.Text.Trim(), "Description cannot be empty", e);
        }

        private void txtDescription_Validated(object sender, EventArgs e)
        {
            Description = txtDescription.Text.Trim();
        }


    }
}
