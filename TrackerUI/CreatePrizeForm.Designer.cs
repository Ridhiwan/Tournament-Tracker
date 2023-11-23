namespace TrackerUI
{
    partial class CreatePrizeForm
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
            placeNumberValue = new TextBox();
            placeNumberLabel = new Label();
            placeNameLabel = new Label();
            placeNameValue = new TextBox();
            prizeAmountLabel = new Label();
            prizeAmountValue = new TextBox();
            prizePercentageValue = new TextBox();
            prizePercentageLabel = new Label();
            orLabel = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 27F);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(12, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(210, 48);
            headerLabel.TabIndex = 12;
            headerLabel.Text = "Create Prize";
            // 
            // placeNumberValue
            // 
            placeNumberValue.Font = new Font("Segoe UI", 13F);
            placeNumberValue.Location = new Point(187, 83);
            placeNumberValue.Multiline = true;
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(140, 33);
            placeNumberValue.TabIndex = 14;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new Font("Segoe UI", 15F);
            placeNumberLabel.ForeColor = Color.FromArgb(53, 155, 255);
            placeNumberLabel.Location = new Point(37, 83);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(134, 28);
            placeNumberLabel.TabIndex = 13;
            placeNumberLabel.Text = "Place Number";
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new Font("Segoe UI", 15F);
            placeNameLabel.ForeColor = Color.FromArgb(53, 155, 255);
            placeNameLabel.Location = new Point(37, 140);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(114, 28);
            placeNameLabel.TabIndex = 17;
            placeNameLabel.Text = "Place Name";
            // 
            // placeNameValue
            // 
            placeNameValue.Font = new Font("Segoe UI", 13F);
            placeNameValue.Location = new Point(187, 140);
            placeNameValue.Multiline = true;
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(140, 33);
            placeNameValue.TabIndex = 18;
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Font = new Font("Segoe UI", 15F);
            prizeAmountLabel.ForeColor = Color.FromArgb(53, 155, 255);
            prizeAmountLabel.Location = new Point(37, 201);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(130, 28);
            prizeAmountLabel.TabIndex = 17;
            prizeAmountLabel.Text = "Prize Amount";
            // 
            // prizeAmountValue
            // 
            prizeAmountValue.Font = new Font("Segoe UI", 13F);
            prizeAmountValue.Location = new Point(187, 201);
            prizeAmountValue.Multiline = true;
            prizeAmountValue.Name = "prizeAmountValue";
            prizeAmountValue.Size = new Size(140, 33);
            prizeAmountValue.TabIndex = 18;
            prizeAmountValue.Text = "0";
            // 
            // prizePercentageValue
            // 
            prizePercentageValue.Font = new Font("Segoe UI", 13F);
            prizePercentageValue.Location = new Point(202, 298);
            prizePercentageValue.Multiline = true;
            prizePercentageValue.Name = "prizePercentageValue";
            prizePercentageValue.Size = new Size(125, 33);
            prizePercentageValue.TabIndex = 20;
            prizePercentageValue.Text = "0";
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.Font = new Font("Segoe UI", 15F);
            prizePercentageLabel.ForeColor = Color.FromArgb(53, 155, 255);
            prizePercentageLabel.Location = new Point(37, 298);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new Size(155, 28);
            prizePercentageLabel.TabIndex = 19;
            prizePercentageLabel.Text = "Prize Percentage";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new Font("Segoe UI", 15F);
            orLabel.ForeColor = Color.FromArgb(53, 155, 255);
            orLabel.Location = new Point(122, 253);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(70, 28);
            orLabel.TabIndex = 21;
            orLabel.Text = "- OR - ";
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            createPrizeButton.ForeColor = Color.FromArgb(53, 153, 255);
            createPrizeButton.Location = new Point(73, 385);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(210, 54);
            createPrizeButton.TabIndex = 27;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(356, 478);
            Controls.Add(createPrizeButton);
            Controls.Add(orLabel);
            Controls.Add(prizePercentageValue);
            Controls.Add(prizePercentageLabel);
            Controls.Add(prizeAmountValue);
            Controls.Add(placeNameValue);
            Controls.Add(prizeAmountLabel);
            Controls.Add(placeNameLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(placeNumberLabel);
            Controls.Add(headerLabel);
            Name = "CreatePrizeForm";
            Text = "Create Prize";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox placeNumberValue;
        private Label placeNumberLabel;
        private Label placeNameLabel;
        private TextBox placeNameValue;
        private Label prizeAmountLabel;
        private TextBox prizeAmountValue;
        private TextBox prizePercentageValue;
        private Label prizePercentageLabel;
        private Label orLabel;
        private Button createPrizeButton;
    }
}