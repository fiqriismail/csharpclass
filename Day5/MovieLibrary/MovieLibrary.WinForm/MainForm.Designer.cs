namespace MovieLibrary.WinForm
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
            this.MoviesButton = new System.Windows.Forms.Button();
            this.MoviesList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // MoviesButton
            // 
            this.MoviesButton.Location = new System.Drawing.Point(12, 12);
            this.MoviesButton.Name = "MoviesButton";
            this.MoviesButton.Size = new System.Drawing.Size(185, 49);
            this.MoviesButton.TabIndex = 0;
            this.MoviesButton.Text = "Get Movies";
            this.MoviesButton.UseVisualStyleBackColor = true;
            this.MoviesButton.Click += new System.EventHandler(this.MoviesButton_Click);
            // 
            // MoviesList
            // 
            this.MoviesList.FormattingEnabled = true;
            this.MoviesList.ItemHeight = 20;
            this.MoviesList.Location = new System.Drawing.Point(12, 86);
            this.MoviesList.Name = "MoviesList";
            this.MoviesList.Size = new System.Drawing.Size(776, 344);
            this.MoviesList.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MoviesList);
            this.Controls.Add(this.MoviesButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MoviesButton;
        private System.Windows.Forms.ListBox MoviesList;
    }
}

