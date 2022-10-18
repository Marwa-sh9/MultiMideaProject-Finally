namespace MultiMideaProject1
{
    partial class CopyPast
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.Button();
            this.AddPic = new System.Windows.Forms.Button();
            this.CutPast = new System.Windows.Forms.Button();
            this.Copy = new System.Windows.Forms.Button();
            this.Merge1 = new System.Windows.Forms.Button();
            this.pic2 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(30, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(30, 295);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(276, 166);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(377, 77);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(276, 166);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(628, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 4;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // AddPic
            // 
            this.AddPic.Location = new System.Drawing.Point(156, 31);
            this.AddPic.Name = "AddPic";
            this.AddPic.Size = new System.Drawing.Size(81, 23);
            this.AddPic.TabIndex = 5;
            this.AddPic.Text = "Add Photo1";
            this.AddPic.UseVisualStyleBackColor = true;
            this.AddPic.Click += new System.EventHandler(this.AddPic_Click);
            // 
            // CutPast
            // 
            this.CutPast.Location = new System.Drawing.Point(30, 249);
            this.CutPast.Name = "CutPast";
            this.CutPast.Size = new System.Drawing.Size(84, 40);
            this.CutPast.TabIndex = 6;
            this.CutPast.Text = "Cut/Past";
            this.CutPast.UseVisualStyleBackColor = true;
            this.CutPast.Click += new System.EventHandler(this.CutPast_Click);
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(30, 31);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(84, 40);
            this.Copy.TabIndex = 7;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Merge1
            // 
            this.Merge1.Location = new System.Drawing.Point(277, 254);
            this.Merge1.Name = "Merge1";
            this.Merge1.Size = new System.Drawing.Size(77, 35);
            this.Merge1.TabIndex = 8;
            this.Merge1.Text = "Merge";
            this.Merge1.UseVisualStyleBackColor = true;
            this.Merge1.Click += new System.EventHandler(this.Merge1_Click);
            // 
            // pic2
            // 
            this.pic2.Location = new System.Drawing.Point(392, 31);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(81, 23);
            this.pic2.TabIndex = 9;
            this.pic2.Text = "Add Photo2";
            this.pic2.UseVisualStyleBackColor = true;
            this.pic2.Click += new System.EventHandler(this.pic2_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(346, 329);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(279, 45);
            this.trackBar1.TabIndex = 10;
            // 
            // CopyPast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 511);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.Merge1);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.CutPast);
            this.Controls.Add(this.AddPic);
            this.Controls.Add(this.back);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CopyPast";
            this.Text = "CopyPast";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button AddPic;
        private System.Windows.Forms.Button CutPast;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button Merge1;
        private System.Windows.Forms.Button pic2;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}