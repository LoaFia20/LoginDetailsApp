namespace LoginDetailsApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.passwordLengthLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.startAgainButton = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.errorMessage = new System.Windows.Forms.Label();
            this.passwordLengthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.errorMessage2 = new System.Windows.Forms.Label();
            this.errorMessage3 = new System.Windows.Forms.Label();
            this.errorMessage4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.passwordLengthNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TitleLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.TitleLabel.Location = new System.Drawing.Point(31, 43);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(329, 18);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Welcome to the Login Details Creation App!";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.firstNameLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.firstNameLabel.Location = new System.Drawing.Point(19, 97);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(122, 18);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "Enter first name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lastNameLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lastNameLabel.Location = new System.Drawing.Point(19, 142);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(123, 18);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Enter last name:";
            // 
            // passwordLengthLabel
            // 
            this.passwordLengthLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordLengthLabel.AutoSize = true;
            this.passwordLengthLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.passwordLengthLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLengthLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.passwordLengthLabel.Location = new System.Drawing.Point(19, 184);
            this.passwordLengthLabel.Name = "passwordLengthLabel";
            this.passwordLengthLabel.Size = new System.Drawing.Size(189, 18);
            this.passwordLengthLabel.TabIndex = 0;
            this.passwordLengthLabel.Text = "Enter length of password:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(157, 95);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(204, 25);
            this.firstNameTextBox.TabIndex = 1;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastnameTextBox.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnameTextBox.Location = new System.Drawing.Point(157, 140);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(204, 25);
            this.lastnameTextBox.TabIndex = 2;
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enterButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.enterButton.Location = new System.Drawing.Point(131, 228);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(127, 40);
            this.enterButton.TabIndex = 4;
            this.enterButton.Text = "enter details";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.usernameLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.usernameLabel.Location = new System.Drawing.Point(68, 293);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(86, 18);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.passwordLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.passwordLabel.Location = new System.Drawing.Point(68, 333);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(79, 18);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "Password:";
            // 
            // startAgainButton
            // 
            this.startAgainButton.BackColor = System.Drawing.Color.NavajoWhite;
            this.startAgainButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startAgainButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startAgainButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.startAgainButton.Location = new System.Drawing.Point(198, 228);
            this.startAgainButton.Name = "startAgainButton";
            this.startAgainButton.Size = new System.Drawing.Size(127, 40);
            this.startAgainButton.TabIndex = 5;
            this.startAgainButton.Text = "start again";
            this.startAgainButton.UseVisualStyleBackColor = false;
            this.startAgainButton.Click += new System.EventHandler(this.startAgainButton_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.InfoLabel.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.InfoLabel.Location = new System.Drawing.Point(48, 368);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(287, 21);
            this.InfoLabel.TabIndex = 5;
            this.InfoLabel.Text = "* Make sure to store this information in a secure place *";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameBox
            // 
            this.usernameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameBox.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.Location = new System.Drawing.Point(170, 292);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(137, 25);
            this.usernameBox.TabIndex = 3;
            this.usernameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordBox
            // 
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordBox.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(170, 330);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(137, 25);
            this.passwordBox.TabIndex = 3;
            this.passwordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // errorMessage
            // 
            this.errorMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorMessage.AutoSize = true;
            this.errorMessage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.errorMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.errorMessage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.errorMessage.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessage.ForeColor = System.Drawing.Color.IndianRed;
            this.errorMessage.Location = new System.Drawing.Point(76, 289);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Padding = new System.Windows.Forms.Padding(10);
            this.errorMessage.Size = new System.Drawing.Size(232, 40);
            this.errorMessage.TabIndex = 5;
            this.errorMessage.Text = "The \'first name\' box is empty";
            this.errorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLengthNumericUpDown
            // 
            this.passwordLengthNumericUpDown.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLengthNumericUpDown.Location = new System.Drawing.Point(225, 183);
            this.passwordLengthNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.passwordLengthNumericUpDown.Name = "passwordLengthNumericUpDown";
            this.passwordLengthNumericUpDown.Size = new System.Drawing.Size(136, 25);
            this.passwordLengthNumericUpDown.TabIndex = 3;
            // 
            // errorMessage2
            // 
            this.errorMessage2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorMessage2.AutoSize = true;
            this.errorMessage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.errorMessage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.errorMessage2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.errorMessage2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessage2.ForeColor = System.Drawing.Color.IndianRed;
            this.errorMessage2.Location = new System.Drawing.Point(97, 289);
            this.errorMessage2.Name = "errorMessage2";
            this.errorMessage2.Padding = new System.Windows.Forms.Padding(10);
            this.errorMessage2.Size = new System.Drawing.Size(200, 58);
            this.errorMessage2.TabIndex = 5;
            this.errorMessage2.Text = "The length of password \r\nis too short";
            this.errorMessage2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorMessage3
            // 
            this.errorMessage3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorMessage3.AutoSize = true;
            this.errorMessage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.errorMessage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.errorMessage3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.errorMessage3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessage3.ForeColor = System.Drawing.Color.IndianRed;
            this.errorMessage3.Location = new System.Drawing.Point(76, 289);
            this.errorMessage3.Name = "errorMessage3";
            this.errorMessage3.Padding = new System.Windows.Forms.Padding(10);
            this.errorMessage3.Size = new System.Drawing.Size(233, 40);
            this.errorMessage3.TabIndex = 5;
            this.errorMessage3.Text = "The \'last name\' box is empty";
            this.errorMessage3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorMessage4
            // 
            this.errorMessage4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorMessage4.AutoSize = true;
            this.errorMessage4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.errorMessage4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.errorMessage4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.errorMessage4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessage4.ForeColor = System.Drawing.Color.IndianRed;
            this.errorMessage4.Location = new System.Drawing.Point(88, 289);
            this.errorMessage4.Name = "errorMessage4";
            this.errorMessage4.Padding = new System.Windows.Forms.Padding(10);
            this.errorMessage4.Size = new System.Drawing.Size(209, 40);
            this.errorMessage4.TabIndex = 5;
            this.errorMessage4.Text = "The textboxes are empty";
            this.errorMessage4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 50000;
            this.toolTip1.InitialDelay = 50;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 50;
            this.toolTip1.ToolTipTitle = "Length information:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.passwordLengthNumericUpDown);
            this.Controls.Add(this.errorMessage2);
            this.Controls.Add(this.errorMessage4);
            this.Controls.Add(this.errorMessage3);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.startAgainButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.lastnameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.passwordLengthLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 450);
            this.MinimumSize = new System.Drawing.Size(400, 450);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Details Creation App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passwordLengthNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label passwordLengthLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button startAgainButton;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.NumericUpDown passwordLengthNumericUpDown;
        private System.Windows.Forms.Label errorMessage2;
        private System.Windows.Forms.Label errorMessage3;
        private System.Windows.Forms.Label errorMessage4;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

