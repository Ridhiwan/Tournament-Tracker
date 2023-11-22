namespace TrackerUI
{
    partial class CreateTeamForm
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
            teamNameValue = new TextBox();
            teamNameLabel = new Label();
            headerLabel = new Label();
            addTeamMemberButton = new Button();
            selectTeamMemberDropDown = new ComboBox();
            selectTeamMemberLabel = new Label();
            addNewMemberGroupBox = new GroupBox();
            firstNameValue = new TextBox();
            firstNameLabel = new Label();
            lastNameValue = new TextBox();
            lastNameLabel = new Label();
            emailValue = new TextBox();
            emailLabel = new Label();
            cellphoneValue = new TextBox();
            cellphoneLabel = new Label();
            createMemberButton = new Button();
            teamMembersListBox = new ListBox();
            deleteSelectedTeamMemberButton = new Button();
            createTeamButton = new Button();
            addNewMemberGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // teamNameValue
            // 
            teamNameValue.Location = new Point(12, 102);
            teamNameValue.Name = "teamNameValue";
            teamNameValue.Size = new Size(263, 23);
            teamNameValue.TabIndex = 13;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new Font("Segoe UI", 15F);
            teamNameLabel.ForeColor = Color.FromArgb(53, 155, 255);
            teamNameLabel.Location = new Point(14, 71);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(114, 28);
            teamNameLabel.TabIndex = 12;
            teamNameLabel.Text = "Team Name";
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 27F);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(7, 13);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(216, 48);
            headerLabel.TabIndex = 11;
            headerLabel.Text = "Create Team";
            // 
            // addTeamMemberButton
            // 
            addTeamMemberButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addTeamMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addTeamMemberButton.FlatStyle = FlatStyle.Flat;
            addTeamMemberButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            addTeamMemberButton.ForeColor = Color.FromArgb(53, 153, 255);
            addTeamMemberButton.Location = new Point(58, 234);
            addTeamMemberButton.Name = "addTeamMemberButton";
            addTeamMemberButton.Size = new Size(151, 36);
            addTeamMemberButton.TabIndex = 19;
            addTeamMemberButton.Text = "Add Member";
            addTeamMemberButton.UseVisualStyleBackColor = true;
            // 
            // selectTeamMemberDropDown
            // 
            selectTeamMemberDropDown.FormattingEnabled = true;
            selectTeamMemberDropDown.Location = new Point(14, 189);
            selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            selectTeamMemberDropDown.Size = new Size(261, 23);
            selectTeamMemberDropDown.TabIndex = 18;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.Font = new Font("Segoe UI", 15F);
            selectTeamMemberLabel.ForeColor = Color.FromArgb(53, 155, 255);
            selectTeamMemberLabel.Location = new Point(12, 156);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(193, 28);
            selectTeamMemberLabel.TabIndex = 17;
            selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // addNewMemberGroupBox
            // 
            addNewMemberGroupBox.Controls.Add(createMemberButton);
            addNewMemberGroupBox.Controls.Add(cellphoneValue);
            addNewMemberGroupBox.Controls.Add(cellphoneLabel);
            addNewMemberGroupBox.Controls.Add(emailValue);
            addNewMemberGroupBox.Controls.Add(emailLabel);
            addNewMemberGroupBox.Controls.Add(lastNameValue);
            addNewMemberGroupBox.Controls.Add(lastNameLabel);
            addNewMemberGroupBox.Controls.Add(firstNameValue);
            addNewMemberGroupBox.Controls.Add(firstNameLabel);
            addNewMemberGroupBox.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addNewMemberGroupBox.ForeColor = Color.FromArgb(52, 153, 255);
            addNewMemberGroupBox.Location = new Point(14, 294);
            addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            addNewMemberGroupBox.Size = new Size(267, 249);
            addNewMemberGroupBox.TabIndex = 20;
            addNewMemberGroupBox.TabStop = false;
            addNewMemberGroupBox.Text = "Add New Member";
            // 
            // firstNameValue
            // 
            firstNameValue.Location = new Point(121, 31);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(140, 33);
            firstNameValue.TabIndex = 10;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 15F);
            firstNameLabel.ForeColor = Color.FromArgb(53, 155, 255);
            firstNameLabel.Location = new Point(6, 33);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(106, 28);
            firstNameLabel.TabIndex = 9;
            firstNameLabel.Text = "First Name";
            // 
            // lastNameValue
            // 
            lastNameValue.Location = new Point(121, 69);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new Size(140, 33);
            lastNameValue.TabIndex = 12;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 15F);
            lastNameLabel.ForeColor = Color.FromArgb(53, 155, 255);
            lastNameLabel.Location = new Point(6, 71);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(103, 28);
            lastNameLabel.TabIndex = 11;
            lastNameLabel.Text = "Last Name";
            lastNameLabel.Click += label1_Click;
            // 
            // emailValue
            // 
            emailValue.Location = new Point(121, 109);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(140, 33);
            emailValue.TabIndex = 14;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 15F);
            emailLabel.ForeColor = Color.FromArgb(53, 155, 255);
            emailLabel.Location = new Point(6, 111);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(59, 28);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email";
            // 
            // cellphoneValue
            // 
            cellphoneValue.Location = new Point(121, 155);
            cellphoneValue.Name = "cellphoneValue";
            cellphoneValue.Size = new Size(140, 33);
            cellphoneValue.TabIndex = 16;
            // 
            // cellphoneLabel
            // 
            cellphoneLabel.AutoSize = true;
            cellphoneLabel.Font = new Font("Segoe UI", 15F);
            cellphoneLabel.ForeColor = Color.FromArgb(53, 155, 255);
            cellphoneLabel.Location = new Point(6, 157);
            cellphoneLabel.Name = "cellphoneLabel";
            cellphoneLabel.Size = new Size(100, 28);
            cellphoneLabel.TabIndex = 15;
            cellphoneLabel.Text = "Cellphone";
            // 
            // createMemberButton
            // 
            createMemberButton.FlatAppearance.BorderColor = Color.Silver;
            createMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createMemberButton.FlatStyle = FlatStyle.Flat;
            createMemberButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            createMemberButton.ForeColor = Color.FromArgb(53, 153, 255);
            createMemberButton.Location = new Point(44, 203);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(151, 33);
            createMemberButton.TabIndex = 21;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.Font = new Font("Segoe UI", 13F);
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.ItemHeight = 23;
            teamMembersListBox.Location = new Point(314, 102);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(269, 441);
            teamMembersListBox.TabIndex = 21;
            // 
            // deleteSelectedTeamMemberButton
            // 
            deleteSelectedTeamMemberButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedTeamMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedTeamMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedTeamMemberButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedTeamMemberButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            deleteSelectedTeamMemberButton.ForeColor = Color.FromArgb(53, 153, 255);
            deleteSelectedTeamMemberButton.Location = new Point(609, 296);
            deleteSelectedTeamMemberButton.Name = "deleteSelectedTeamMemberButton";
            deleteSelectedTeamMemberButton.Size = new Size(109, 53);
            deleteSelectedTeamMemberButton.TabIndex = 25;
            deleteSelectedTeamMemberButton.Text = "Delete Selected";
            deleteSelectedTeamMemberButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            createTeamButton.FlatAppearance.BorderColor = Color.Silver;
            createTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            createTeamButton.ForeColor = Color.FromArgb(53, 153, 255);
            createTeamButton.Location = new Point(231, 573);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(210, 54);
            createTeamButton.TabIndex = 26;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(730, 670);
            Controls.Add(createTeamButton);
            Controls.Add(deleteSelectedTeamMemberButton);
            Controls.Add(teamMembersListBox);
            Controls.Add(addNewMemberGroupBox);
            Controls.Add(addTeamMemberButton);
            Controls.Add(selectTeamMemberDropDown);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(teamNameValue);
            Controls.Add(teamNameLabel);
            Controls.Add(headerLabel);
            Name = "CreateTeamForm";
            Text = "Create Team";
            addNewMemberGroupBox.ResumeLayout(false);
            addNewMemberGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox teamNameValue;
        private Label teamNameLabel;
        private Label headerLabel;
        private Button addTeamMemberButton;
        private ComboBox selectTeamMemberDropDown;
        private Label selectTeamMemberLabel;
        private GroupBox addNewMemberGroupBox;
        private TextBox firstNameValue;
        private Label firstNameLabel;
        private TextBox lastNameValue;
        private Label lastNameLabel;
        private TextBox emailValue;
        private Label emailLabel;
        private TextBox cellphoneValue;
        private Label cellphoneLabel;
        private Button createMemberButton;
        private ListBox teamMembersListBox;
        private Button deleteSelectedTeamMemberButton;
        private Button createTeamButton;
    }
}