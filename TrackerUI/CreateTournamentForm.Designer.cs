namespace TrackerUI
{
    partial class CreateTournamentForm
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
            headerLabel = new Label();
            teamNameValue = new TextBox();
            tournamentNameLabel = new Label();
            teamOneScoreValue = new TextBox();
            entryFeeLabel = new Label();
            roundDropDown = new ComboBox();
            selectTeamLabel = new Label();
            createTeamLinkLabel = new LinkLabel();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            tournamentPlayersListBox = new ListBox();
            tournamentPlayersLabel = new Label();
            deleteSelectedPrizeButton = new Button();
            prizesLabel = new Label();
            prizeListBox = new ListBox();
            deleteSelectedPlayerButton = new Button();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 27F);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(12, 19);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(322, 48);
            headerLabel.TabIndex = 1;
            headerLabel.Text = "Create Tournament";
            // 
            // teamNameValue
            // 
            teamNameValue.Location = new Point(34, 121);
            teamNameValue.Name = "teamNameValue";
            teamNameValue.Size = new Size(242, 36);
            teamNameValue.TabIndex = 10;
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI", 15F);
            tournamentNameLabel.ForeColor = Color.FromArgb(53, 155, 255);
            tournamentNameLabel.Location = new Point(36, 90);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(173, 28);
            tournamentNameLabel.TabIndex = 9;
            tournamentNameLabel.Text = "Tournament Name";
            tournamentNameLabel.Click += teamOneScoreLabel_Click;
            // 
            // teamOneScoreValue
            // 
            teamOneScoreValue.Location = new Point(134, 187);
            teamOneScoreValue.Name = "teamOneScoreValue";
            teamOneScoreValue.Size = new Size(69, 36);
            teamOneScoreValue.TabIndex = 12;
            teamOneScoreValue.Text = "0";
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Font = new Font("Segoe UI", 15F);
            entryFeeLabel.ForeColor = Color.FromArgb(53, 155, 255);
            entryFeeLabel.Location = new Point(36, 191);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(92, 28);
            entryFeeLabel.TabIndex = 11;
            entryFeeLabel.Text = "Entry Fee";
            // 
            // roundDropDown
            // 
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(36, 289);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(247, 38);
            roundDropDown.TabIndex = 14;
            roundDropDown.SelectedIndexChanged += roundDropDown_SelectedIndexChanged;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Segoe UI", 16F);
            selectTeamLabel.ForeColor = Color.FromArgb(53, 155, 255);
            selectTeamLabel.Location = new Point(34, 256);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(129, 30);
            selectTeamLabel.TabIndex = 13;
            selectTeamLabel.Text = "Select Team";
            selectTeamLabel.Click += roundLabel_Click;
            // 
            // createTeamLinkLabel
            // 
            createTeamLinkLabel.AutoSize = true;
            createTeamLinkLabel.Font = new Font("Segoe UI", 10F);
            createTeamLinkLabel.Location = new Point(198, 266);
            createTeamLinkLabel.Name = "createTeamLinkLabel";
            createTeamLinkLabel.Size = new Size(75, 19);
            createTeamLinkLabel.TabIndex = 15;
            createTeamLinkLabel.TabStop = true;
            createTeamLinkLabel.Text = "create new";
            // 
            // addTeamButton
            // 
            addTeamButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            addTeamButton.ForeColor = Color.FromArgb(53, 153, 255);
            addTeamButton.Location = new Point(80, 347);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(154, 40);
            addTeamButton.TabIndex = 16;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            createPrizeButton.ForeColor = Color.FromArgb(53, 153, 255);
            createPrizeButton.Location = new Point(80, 411);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(154, 40);
            createPrizeButton.TabIndex = 17;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayersListBox
            // 
            tournamentPlayersListBox.Font = new Font("Segoe UI", 13F);
            tournamentPlayersListBox.FormattingEnabled = true;
            tournamentPlayersListBox.ItemHeight = 23;
            tournamentPlayersListBox.Location = new Point(382, 121);
            tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            tournamentPlayersListBox.Size = new Size(224, 142);
            tournamentPlayersListBox.TabIndex = 18;
            // 
            // tournamentPlayersLabel
            // 
            tournamentPlayersLabel.AutoSize = true;
            tournamentPlayersLabel.Font = new Font("Segoe UI", 15F);
            tournamentPlayersLabel.ForeColor = Color.FromArgb(53, 155, 255);
            tournamentPlayersLabel.Location = new Point(382, 90);
            tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            tournamentPlayersLabel.Size = new Size(144, 28);
            tournamentPlayersLabel.TabIndex = 19;
            tournamentPlayersLabel.Text = "Teams / Players";
            tournamentPlayersLabel.Click += label1_Click;
            // 
            // deleteSelectedPrizeButton
            // 
            deleteSelectedPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedPrizeButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPrizeButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            deleteSelectedPrizeButton.ForeColor = Color.FromArgb(53, 153, 255);
            deleteSelectedPrizeButton.Location = new Point(621, 377);
            deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            deleteSelectedPrizeButton.Size = new Size(109, 53);
            deleteSelectedPrizeButton.TabIndex = 23;
            deleteSelectedPrizeButton.Text = "Delete Selected";
            deleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // prizesLabel
            // 
            prizesLabel.AutoSize = true;
            prizesLabel.Font = new Font("Segoe UI", 15F);
            prizesLabel.ForeColor = Color.FromArgb(53, 155, 255);
            prizesLabel.Location = new Point(382, 305);
            prizesLabel.Name = "prizesLabel";
            prizesLabel.Size = new Size(62, 28);
            prizesLabel.TabIndex = 22;
            prizesLabel.Text = "Prizes";
            // 
            // prizeListBox
            // 
            prizeListBox.Font = new Font("Segoe UI", 13F);
            prizeListBox.FormattingEnabled = true;
            prizeListBox.ItemHeight = 23;
            prizeListBox.Location = new Point(382, 336);
            prizeListBox.Name = "prizeListBox";
            prizeListBox.Size = new Size(224, 142);
            prizeListBox.TabIndex = 21;
            // 
            // deleteSelectedPlayerButton
            // 
            deleteSelectedPlayerButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedPlayerButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedPlayerButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedPlayerButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPlayerButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            deleteSelectedPlayerButton.ForeColor = Color.FromArgb(53, 153, 255);
            deleteSelectedPlayerButton.Location = new Point(621, 166);
            deleteSelectedPlayerButton.Name = "deleteSelectedPlayerButton";
            deleteSelectedPlayerButton.Size = new Size(109, 53);
            deleteSelectedPlayerButton.TabIndex = 24;
            deleteSelectedPlayerButton.Text = "Delete Selected";
            deleteSelectedPlayerButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            createTournamentButton.ForeColor = Color.FromArgb(53, 153, 255);
            createTournamentButton.Location = new Point(280, 522);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(194, 40);
            createTournamentButton.TabIndex = 25;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(770, 590);
            Controls.Add(createTournamentButton);
            Controls.Add(deleteSelectedPlayerButton);
            Controls.Add(deleteSelectedPrizeButton);
            Controls.Add(prizesLabel);
            Controls.Add(prizeListBox);
            Controls.Add(tournamentPlayersLabel);
            Controls.Add(tournamentPlayersListBox);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(createTeamLinkLabel);
            Controls.Add(roundDropDown);
            Controls.Add(selectTeamLabel);
            Controls.Add(teamOneScoreValue);
            Controls.Add(entryFeeLabel);
            Controls.Add(teamNameValue);
            Controls.Add(tournamentNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(5, 5, 5, 5);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox teamNameValue;
        private Label tournamentNameLabel;
        private TextBox teamOneScoreValue;
        private Label entryFeeLabel;
        private ComboBox roundDropDown;
        private Label selectTeamLabel;
        private LinkLabel createTeamLinkLabel;
        private Button addTeamButton;
        private Button createPrizeButton;
        private ListBox tournamentPlayersListBox;
        private Label tournamentPlayersLabel;
        private Button deleteSelectedPrizeButton;
        private Label prizesLabel;
        private ListBox prizeListBox;
        private Button deleteSelectedPlayerButton;
        private Button createTournamentButton;
    }
}