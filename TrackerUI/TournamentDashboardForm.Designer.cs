namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            loadTournamentDropDown = new ComboBox();
            loadTournamentLabel = new Label();
            loadButton = new Button();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 27F);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(162, 19);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(391, 48);
            headerLabel.TabIndex = 13;
            headerLabel.Text = "Tournament Dashboard";
            // 
            // loadTournamentDropDown
            // 
            loadTournamentDropDown.Font = new Font("Segoe UI", 12F);
            loadTournamentDropDown.FormattingEnabled = true;
            loadTournamentDropDown.ItemHeight = 21;
            loadTournamentDropDown.Location = new Point(227, 117);
            loadTournamentDropDown.Name = "loadTournamentDropDown";
            loadTournamentDropDown.Size = new Size(261, 29);
            loadTournamentDropDown.TabIndex = 20;
            // 
            // loadTournamentLabel
            // 
            loadTournamentLabel.AutoSize = true;
            loadTournamentLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loadTournamentLabel.ForeColor = Color.FromArgb(53, 155, 255);
            loadTournamentLabel.Location = new Point(266, 84);
            loadTournamentLabel.Name = "loadTournamentLabel";
            loadTournamentLabel.Size = new Size(182, 30);
            loadTournamentLabel.TabIndex = 19;
            loadTournamentLabel.Text = "Load Tournament";
            // 
            // loadButton
            // 
            loadButton.FlatAppearance.BorderColor = Color.Silver;
            loadButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            loadButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            loadButton.FlatStyle = FlatStyle.Flat;
            loadButton.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            loadButton.ForeColor = Color.FromArgb(53, 153, 255);
            loadButton.Location = new Point(282, 166);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(151, 36);
            loadButton.TabIndex = 21;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            createTournamentButton.ForeColor = Color.FromArgb(53, 153, 255);
            createTournamentButton.Location = new Point(258, 232);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(199, 55);
            createTournamentButton.TabIndex = 26;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(764, 362);
            Controls.Add(createTournamentButton);
            Controls.Add(loadButton);
            Controls.Add(loadTournamentDropDown);
            Controls.Add(loadTournamentLabel);
            Controls.Add(headerLabel);
            Name = "TournamentDashboardForm";
            Text = "Tournament Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private ComboBox loadTournamentDropDown;
        private Label loadTournamentLabel;
        private Button loadButton;
        private Button createTournamentButton;
    }
}