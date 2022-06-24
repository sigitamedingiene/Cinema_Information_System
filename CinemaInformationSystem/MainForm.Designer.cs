namespace CinemaInformationSystem
{
    partial class MainForm
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
            this.AddNewMovieButton = new System.Windows.Forms.Button();
            this.SellTicketButton = new System.Windows.Forms.Button();
            this.GenerateReportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddNewMovieButton
            // 
            this.AddNewMovieButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddNewMovieButton.Location = new System.Drawing.Point(250, 12);
            this.AddNewMovieButton.Name = "AddNewMovieButton";
            this.AddNewMovieButton.Size = new System.Drawing.Size(232, 23);
            this.AddNewMovieButton.TabIndex = 0;
            this.AddNewMovieButton.Text = "Add new movie";
            this.AddNewMovieButton.UseVisualStyleBackColor = false;
            this.AddNewMovieButton.Click += new System.EventHandler(this.AddNewMovieButton_Click);
            // 
            // SellTicketButton
            // 
            this.SellTicketButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SellTicketButton.Location = new System.Drawing.Point(12, 12);
            this.SellTicketButton.Name = "SellTicketButton";
            this.SellTicketButton.Size = new System.Drawing.Size(232, 23);
            this.SellTicketButton.TabIndex = 1;
            this.SellTicketButton.Text = "Sell ticket";
            this.SellTicketButton.UseVisualStyleBackColor = false;
            // 
            // GenerateReportButton
            // 
            this.GenerateReportButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GenerateReportButton.Location = new System.Drawing.Point(488, 12);
            this.GenerateReportButton.Name = "GenerateReportButton";
            this.GenerateReportButton.Size = new System.Drawing.Size(232, 23);
            this.GenerateReportButton.TabIndex = 2;
            this.GenerateReportButton.Text = "Generate report";
            this.GenerateReportButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GenerateReportButton);
            this.Controls.Add(this.SellTicketButton);
            this.Controls.Add(this.AddNewMovieButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddNewMovieButton;
        private System.Windows.Forms.Button SellTicketButton;
        private System.Windows.Forms.Button GenerateReportButton;
    }
}
