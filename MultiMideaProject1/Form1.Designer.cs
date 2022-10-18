namespace MultiMideaProject1
{
    partial class Form1
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
            this.CopyCutPast = new System.Windows.Forms.Button();
            this.Edid = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CopyCutPast
            // 
            this.CopyCutPast.BackColor = System.Drawing.Color.Silver;
            this.CopyCutPast.Location = new System.Drawing.Point(171, 138);
            this.CopyCutPast.Name = "CopyCutPast";
            this.CopyCutPast.Size = new System.Drawing.Size(81, 37);
            this.CopyCutPast.TabIndex = 1;
            this.CopyCutPast.Text = "Copy Cut Past";
            this.CopyCutPast.UseVisualStyleBackColor = false;
            this.CopyCutPast.Click += new System.EventHandler(this.CopyCutPast_Click);
            // 
            // Edid
            // 
            this.Edid.BackColor = System.Drawing.Color.Silver;
            this.Edid.Location = new System.Drawing.Point(84, 138);
            this.Edid.Name = "Edid";
            this.Edid.Size = new System.Drawing.Size(81, 37);
            this.Edid.TabIndex = 3;
            this.Edid.Text = "Edit Photo";
            this.Edid.UseVisualStyleBackColor = false;
            this.Edid.Click += new System.EventHandler(this.Edid_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Silver;
            this.exit.Location = new System.Drawing.Point(352, 233);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(81, 37);
            this.exit.TabIndex = 5;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 375);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Edid);
            this.Controls.Add(this.CopyCutPast);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CopyCutPast;
        private System.Windows.Forms.Button Edid;
        private System.Windows.Forms.Button exit;
    }
}

