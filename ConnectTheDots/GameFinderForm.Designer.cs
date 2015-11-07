namespace ConnectTheDots
{
    partial class GameFinderForm
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
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.beginnerMode = new System.Windows.Forms.RadioButton();
            this.intermediateMode = new System.Windows.Forms.RadioButton();
            this.advancedMode = new System.Windows.Forms.RadioButton();
            this.gameStartButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.settingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Controls.Add(this.advancedMode);
            this.settingsGroupBox.Controls.Add(this.intermediateMode);
            this.settingsGroupBox.Controls.Add(this.beginnerMode);
            this.settingsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsGroupBox.Location = new System.Drawing.Point(13, 13);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(185, 149);
            this.settingsGroupBox.TabIndex = 0;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Settings";
            // 
            // beginnerMode
            // 
            this.beginnerMode.AutoSize = true;
            this.beginnerMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginnerMode.Location = new System.Drawing.Point(6, 37);
            this.beginnerMode.Name = "beginnerMode";
            this.beginnerMode.Size = new System.Drawing.Size(120, 29);
            this.beginnerMode.TabIndex = 0;
            this.beginnerMode.TabStop = true;
            this.beginnerMode.Text = "5x5 Mode";
            this.beginnerMode.UseVisualStyleBackColor = true;
            // 
            // intermediateMode
            // 
            this.intermediateMode.AutoSize = true;
            this.intermediateMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intermediateMode.Location = new System.Drawing.Point(6, 72);
            this.intermediateMode.Name = "intermediateMode";
            this.intermediateMode.Size = new System.Drawing.Size(142, 29);
            this.intermediateMode.TabIndex = 1;
            this.intermediateMode.TabStop = true;
            this.intermediateMode.Text = "10x10 Mode";
            this.intermediateMode.UseVisualStyleBackColor = true;
            // 
            // advancedMode
            // 
            this.advancedMode.AutoSize = true;
            this.advancedMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advancedMode.Location = new System.Drawing.Point(6, 107);
            this.advancedMode.Name = "advancedMode";
            this.advancedMode.Size = new System.Drawing.Size(142, 29);
            this.advancedMode.TabIndex = 2;
            this.advancedMode.TabStop = true;
            this.advancedMode.Text = "15x15 Mode";
            this.advancedMode.UseVisualStyleBackColor = true;
            // 
            // gameStartButton
            // 
            this.gameStartButton.Location = new System.Drawing.Point(243, 74);
            this.gameStartButton.Name = "gameStartButton";
            this.gameStartButton.Size = new System.Drawing.Size(192, 56);
            this.gameStartButton.TabIndex = 2;
            this.gameStartButton.Text = "Start";
            this.gameStartButton.UseVisualStyleBackColor = true;
            this.gameStartButton.Click += new System.EventHandler(this.gameStartButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(255, 160);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(171, 44);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // GameFinderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 329);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.gameStartButton);
            this.Controls.Add(this.settingsGroupBox);
            this.Name = "GameFinderForm";
            this.Text = "GameFinderForm";
            this.settingsGroupBox.ResumeLayout(false);
            this.settingsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox settingsGroupBox;
        private System.Windows.Forms.RadioButton advancedMode;
        private System.Windows.Forms.RadioButton intermediateMode;
        private System.Windows.Forms.RadioButton beginnerMode;
        private System.Windows.Forms.Button gameStartButton;
        private System.Windows.Forms.Button backButton;
    }
}