
namespace Test
{
    partial class Display
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer secTimer;
            this.timeNow = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.Label();
            secTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // secTimer
            // 
            secTimer.Enabled = true;
            secTimer.Interval = 1000;
            secTimer.Tick += new System.EventHandler(this.secTimer_Tick);
            // 
            // timeNow
            // 
            this.timeNow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeNow.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeNow.Location = new System.Drawing.Point(0, 0);
            this.timeNow.Name = "timeNow";
            this.timeNow.Size = new System.Drawing.Size(773, 232);
            this.timeNow.TabIndex = 0;
            this.timeNow.Text = "Loading...";
            this.timeNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeNow.Click += new System.EventHandler(this.label1_Click);
            // 
            // Author
            // 
            this.Author.Dock = System.Windows.Forms.DockStyle.Right;
            this.Author.Location = new System.Drawing.Point(669, 0);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(104, 232);
            this.Author.TabIndex = 1;
            this.Author.Text = "Created by chrndu";
            this.Author.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Author.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 232);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.timeNow);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Display";
            this.Text = "試作";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Display_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label timeNow;
        private System.Windows.Forms.Timer secTimer;
        private System.Windows.Forms.Label Author;
    }
}

