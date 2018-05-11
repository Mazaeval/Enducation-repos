using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsersAndRewards.PL.WinForms.UserForms
{
	public partial class UserForm : Form
	{
		public string FirstName { get; private set; }
		public string LastName { get; private set; }


		public UserForm()
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
	}
}
