namespace ConnectTheDots
{
    partial class GameForm
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

        TwoPlayerGame game;


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TESTLABEL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TESTLABEL
            // 
            this.TESTLABEL.AutoSize = true;
            this.TESTLABEL.Location = new System.Drawing.Point(739, 39);
            this.TESTLABEL.Name = "TESTLABEL";
            this.TESTLABEL.Size = new System.Drawing.Size(46, 17);
            this.TESTLABEL.TabIndex = 0;
            this.TESTLABEL.Text = "label1";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 506);
            this.Controls.Add(this.TESTLABEL);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label TESTLABEL;
    }
}