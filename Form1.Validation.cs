using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public partial class Form1
    {
        private bool NewStudentInputIsValidated()
        {
            bool isValid = true;
            CLearErrorStyle();
            StringBuilder errorMessage = new StringBuilder();

            if (string.IsNullOrWhiteSpace(txtNewFirstName.Text))
            {
                txtNewFirstName.BackColor = SystemColors.Info;
                label3.ForeColor = Color.Red;
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtNewLastName.Text))
            {
                txtNewLastName.BackColor = SystemColors.Info;
                label4.ForeColor = Color.Red;
                isValid = false;
            }
            if (!int.TryParse(txtNewAge.Text, out _))
            {
                txtNewAge.BackColor = SystemColors.Info;
                label5.ForeColor = Color.Red;
                errorMessage.AppendLine("* Age must be numeric");
                isValid = false;
            }
            if (checkedListBoxGender.CheckedItems.Count == 0)
            {
                checkedListBoxGender.BackColor = SystemColors.Info;
                label6.ForeColor = Color.Red;
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtNewPhone.Text))
            {
                txtNewPhone.BackColor = SystemColors.Info;
                label7.ForeColor = Color.Red;
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtNewEmail.Text))
            {
                txtNewEmail.BackColor = SystemColors.Info;
                label8.ForeColor = Color.Red;
                isValid = false;
            }
            if (comboBoxClass.SelectedIndex == -1)
            {
                comboBoxClass.BackColor = SystemColors.Info;
                label2Class.ForeColor = Color.Red;
                isValid = false;
            }
            if (comboBox1.SelectedIndex == -1)
            {
                comboBox1.BackColor = SystemColors.Info;
                label2Campus.ForeColor = Color.Red;
                isValid = false;
            }
            if (checkedListBoxExtraMural.CheckedItems.Count == 0)
            {
                checkedListBoxExtraMural.BackColor = SystemColors.Info;
                label2.ForeColor = Color.Red;
                isValid = false;
            }

            if (!isValid)
            {
                txtErrors.Text = "* Please enter the followed required fields" + errorMessage.ToString().Trim();
                txtErrors.ForeColor = Color.Red;
            }
            return isValid;
        }

        private void CLearErrorStyle()
        {
            txtNewFirstName.BackColor = SystemColors.Window;
            txtNewLastName.BackColor = SystemColors.Window;
            txtNewAge.BackColor = SystemColors.Window;
            checkedListBoxGender.BackColor = SystemColors.Window;
            txtNewPhone.BackColor = SystemColors.Window;
            txtNewEmail.BackColor = SystemColors.Window;
            comboBoxClass.BackColor = SystemColors.Window;
            comboBox1.BackColor = SystemColors.Window;
            checkedListBoxExtraMural.BackColor = SystemColors.Window;

            label3.ForeColor = SystemColors.ControlText;
            label4.ForeColor = SystemColors.ControlText;
            label5.ForeColor = SystemColors.ControlText;
            label6.ForeColor = SystemColors.ControlText;
            label7.ForeColor = SystemColors.ControlText;
            label8.ForeColor = SystemColors.ControlText;
            label2Class.ForeColor = SystemColors.ControlText;
            label2Campus.ForeColor = SystemColors.ControlText;
            label2.ForeColor = SystemColors.ControlText;

            txtErrors.Text = string.Empty;



        }

        private void ClearNewStudentForm()
        {
            txtNewFirstName.Text = string.Empty;
            txtNewLastName.Text = string.Empty;
            txtNewAge.Text = string.Empty;
            txtNewPhone.Text = string.Empty;
            txtNewEmail.Text = string.Empty;
            comboBoxClass.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            checkedListBoxGender.SelectedIndex = 0;
            checkedListBoxExtraMural.SelectedIndex = 0;
        }
    }
}
