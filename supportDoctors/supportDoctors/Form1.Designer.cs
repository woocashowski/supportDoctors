
namespace supportDoctors
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.errorLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.signUpButton = new System.Windows.Forms.Button();
            this.signinButton = new System.Windows.Forms.Button();
            this.workerCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.errorLabel.Location = new System.Drawing.Point(406, 220);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(29, 13);
            this.errorLabel.TabIndex = 13;
            this.errorLabel.Text = "Error";
            this.errorLabel.Visible = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(248, 165);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 12;
            this.passwordLabel.Text = "Password";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(245, 106);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(33, 13);
            this.loginLabel.TabIndex = 11;
            this.loginLabel.Text = "Login";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(312, 159);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(244, 20);
            this.PasswordBox.TabIndex = 10;
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(312, 103);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(244, 20);
            this.loginBox.TabIndex = 9;
            // 
            // signUpButton
            // 
            this.signUpButton.Location = new System.Drawing.Point(391, 325);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(75, 23);
            this.signUpButton.TabIndex = 8;
            this.signUpButton.Text = "Sign up";
            this.signUpButton.UseVisualStyleBackColor = true;
            // 
            // signinButton
            // 
            this.signinButton.Location = new System.Drawing.Point(391, 296);
            this.signinButton.Name = "signinButton";
            this.signinButton.Size = new System.Drawing.Size(75, 23);
            this.signinButton.TabIndex = 7;
            this.signinButton.Text = "Sign in";
            this.signinButton.UseVisualStyleBackColor = true;
            this.signinButton.Click += new System.EventHandler(this.signinButton_Click);
            // 
            // workerCheckBox
            // 
            this.workerCheckBox.AutoSize = true;
            this.workerCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.workerCheckBox.Location = new System.Drawing.Point(391, 253);
            this.workerCheckBox.Name = "workerCheckBox";
            this.workerCheckBox.Size = new System.Drawing.Size(61, 17);
            this.workerCheckBox.TabIndex = 14;
            this.workerCheckBox.Text = "Worker";
            this.workerCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.workerCheckBox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.signinButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Button signinButton;
        private System.Windows.Forms.CheckBox workerCheckBox;
    }
}

