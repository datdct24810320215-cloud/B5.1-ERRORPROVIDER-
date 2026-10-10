namespace B5._1_ERRORPROVIDER_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.groupPersonal = new System.Windows.Forms.GroupBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.groupExtra = new System.Windows.Forms.GroupBox();
            this.chkAgree = new System.Windows.Forms.CheckBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.lblDob = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.epCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            // 
            // groupPersonal
            // 
            this.groupPersonal.SuspendLayout();
            this.groupExtra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).BeginInit();
            this.SuspendLayout();
            this.groupPersonal.Controls.Add(this.lblConfirm);
            this.groupPersonal.Controls.Add(this.lblPassword);
            this.groupPersonal.Controls.Add(this.lblUsername);
            this.groupPersonal.Controls.Add(this.txtConfirm);
            this.groupPersonal.Controls.Add(this.txtPassword);
            this.groupPersonal.Controls.Add(this.txtUsername);
            this.groupPersonal.Location = new System.Drawing.Point(12, 12);
            this.groupPersonal.Name = "groupPersonal";
            this.groupPersonal.Size = new System.Drawing.Size(360, 140);
            this.groupPersonal.TabIndex = 0;
            this.groupPersonal.TabStop = false;
            this.groupPersonal.Text = "Personal Information";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(16, 28);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 15);
            this.lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(120, 25);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(220, 23);
            this.txtUsername.TabIndex = 0;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(16, 60);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(63, 15);
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(120, 57);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(220, 23);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Location = new System.Drawing.Point(16, 95);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(98, 15);
            this.lblConfirm.Text = "Confirm Password:";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(120, 92);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(220, 23);
            this.txtConfirm.TabIndex = 2;
            this.txtConfirm.UseSystemPasswordChar = true;
            // 
            // groupExtra
            // 
            this.groupExtra.Controls.Add(this.chkAgree);
            this.groupExtra.Controls.Add(this.rbFemale);
            this.groupExtra.Controls.Add(this.rbMale);
            this.groupExtra.Controls.Add(this.lblDob);
            this.groupExtra.Controls.Add(this.dtpDOB);
            this.groupExtra.Location = new System.Drawing.Point(12, 160);
            this.groupExtra.Name = "groupExtra";
            this.groupExtra.Size = new System.Drawing.Size(360, 130);
            this.groupExtra.TabIndex = 1;
            this.groupExtra.TabStop = false;
            this.groupExtra.Text = "Additional Information";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Location = new System.Drawing.Point(16, 28);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(73, 15);
            this.lblDob.Text = "Date of Birth:";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(120, 24);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(220, 23);
            this.dtpDOB.TabIndex = 3;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(120, 58);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(51, 19);
            this.rbMale.TabIndex = 4;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(190, 58);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(63, 19);
            this.rbFemale.TabIndex = 5;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // chkAgree
            // 
            this.chkAgree.AutoSize = true;
            this.chkAgree.Location = new System.Drawing.Point(16, 94);
            this.chkAgree.Name = "chkAgree";
            this.chkAgree.Size = new System.Drawing.Size(193, 19);
            this.chkAgree.TabIndex = 6;
            this.chkAgree.Text = "I agree to the terms of service";
            this.chkAgree.UseVisualStyleBackColor = true;
            // 
            // epCheck
            // 
            this.epCheck.ContainerControl = this;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(400, 40);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(120, 35);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(400, 100);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 35);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 311);
            this.Controls.Add(this.groupPersonal);
            this.Controls.Add(this.groupExtra);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnReset);
            this.Name = "Form1";
            this.Text = "Registration - ErrorProvider Example";
            this.groupPersonal.ResumeLayout(false);
            this.groupPersonal.PerformLayout();
            this.groupExtra.ResumeLayout(false);
            this.groupExtra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupPersonal;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.GroupBox groupExtra;
        private System.Windows.Forms.CheckBox chkAgree;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ErrorProvider epCheck;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnReset;
    }
}
