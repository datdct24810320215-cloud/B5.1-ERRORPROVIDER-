namespace B5._1_ERRORPROVIDER_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Clear previous errors
            epCheck.Clear();

            bool valid = true;

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                epCheck.SetError(txtUsername, "Username is required.");
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                epCheck.SetError(txtPassword, "Password is required.");
                valid = false;
            }

            if (txtPassword.Text != txtConfirm.Text)
            {
                epCheck.SetError(txtConfirm, "Passwords do not match.");
                valid = false;
            }

            // Age check
            DateTime dob = dtpDOB.Value.Date;
            DateTime today = DateTime.Today;
            int age = today.Year - dob.Year;
            if (dob > today.AddYears(-age)) age--;
            if (age < 18)
            {
                epCheck.SetError(dtpDOB, "You must be at least 18 years old.");
                valid = false;
            }

            if (!chkAgree.Checked)
            {
                epCheck.SetError(chkAgree, "You must agree to the terms of service.");
                valid = false;
            }

            if (valid)
            {
                MessageBox.Show("Registration successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            epCheck.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirm.Clear();
            dtpDOB.Value = DateTime.Today.AddYears(-18);
            rbMale.Checked = false;
            rbFemale.Checked = false;
            chkAgree.Checked = false;
        }
    }
}
