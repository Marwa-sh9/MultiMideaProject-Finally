namespace MultiMideaProject1
{
    partial class EditPhoto
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
            this.ComboColor = new System.Windows.Forms.ComboBox();
            this.Add = new System.Windows.Forms.Button();
            this.Write = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mirror = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Rev = new System.Windows.Forms.Button();
            this.ResizeB = new System.Windows.Forms.Button();
            this.resizeH = new System.Windows.Forms.NumericUpDown();
            this.resizeW = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Left_Rotate1 = new System.Windows.Forms.Button();
            this.Right_Rotate1 = new System.Windows.Forms.Button();
            this.Save_To_Device = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.radioBmp = new System.Windows.Forms.RadioButton();
            this.radiogif = new System.Windows.Forms.RadioButton();
            this.radiopng = new System.Windows.Forms.RadioButton();
            this.radio = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.saveText = new System.Windows.Forms.Button();
            this.Copy1 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.dgvImages = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSaveToDB = new System.Windows.Forms.Button();
            this.ShowAllImages = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.combine = new System.Windows.Forms.Button();
            this.image2 = new System.Windows.Forms.Button();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizeH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizeW)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboColor
            // 
            this.ComboColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboColor.FormattingEnabled = true;
            this.ComboColor.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "Gray",
            "Black",
            "White",
            "Magenta",
            "Cyan",
            "Yellow",
            "Nigative",
            "Normal"});
            this.ComboColor.Location = new System.Drawing.Point(12, 112);
            this.ComboColor.Name = "ComboColor";
            this.ComboColor.Size = new System.Drawing.Size(121, 21);
            this.ComboColor.TabIndex = 1;
            this.ComboColor.Text = "Color";
            this.ComboColor.SelectedIndexChanged += new System.EventHandler(this.ComboColor_SelectedIndexChanged);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.DarkGray;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.Red;
            this.Add.Location = new System.Drawing.Point(9, 12);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(134, 30);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add Photo1";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Write
            // 
            this.Write.BackColor = System.Drawing.Color.DarkGray;
            this.Write.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Write.ForeColor = System.Drawing.Color.Navy;
            this.Write.Location = new System.Drawing.Point(261, 65);
            this.Write.Name = "Write";
            this.Write.Size = new System.Drawing.Size(80, 31);
            this.Write.TabIndex = 4;
            this.Write.Text = "To Write";
            this.Write.UseVisualStyleBackColor = false;
            this.Write.Click += new System.EventHandler(this.Write_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(128, 68);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 28);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // mirror
            // 
            this.mirror.BackColor = System.Drawing.Color.DarkGray;
            this.mirror.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mirror.ForeColor = System.Drawing.Color.Navy;
            this.mirror.Location = new System.Drawing.Point(24, 149);
            this.mirror.Name = "mirror";
            this.mirror.Size = new System.Drawing.Size(100, 23);
            this.mirror.TabIndex = 6;
            this.mirror.Text = "Mirror";
            this.mirror.UseVisualStyleBackColor = false;
            this.mirror.Click += new System.EventHandler(this.mirror_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkGray;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(25, 333);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 41);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(517, 123);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(265, 260);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // Rev
            // 
            this.Rev.BackColor = System.Drawing.Color.DarkGray;
            this.Rev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rev.ForeColor = System.Drawing.Color.Navy;
            this.Rev.Location = new System.Drawing.Point(24, 178);
            this.Rev.Name = "Rev";
            this.Rev.Size = new System.Drawing.Size(100, 24);
            this.Rev.TabIndex = 10;
            this.Rev.Text = "Reverse";
            this.Rev.UseVisualStyleBackColor = false;
            this.Rev.Click += new System.EventHandler(this.Rev_Click);
            // 
            // ResizeB
            // 
            this.ResizeB.BackColor = System.Drawing.Color.DarkGray;
            this.ResizeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResizeB.ForeColor = System.Drawing.Color.Navy;
            this.ResizeB.Location = new System.Drawing.Point(12, 36);
            this.ResizeB.Name = "ResizeB";
            this.ResizeB.Size = new System.Drawing.Size(97, 23);
            this.ResizeB.TabIndex = 14;
            this.ResizeB.Text = "Resize";
            this.ResizeB.UseVisualStyleBackColor = false;
            this.ResizeB.Click += new System.EventHandler(this.ResizeB_Click);
            // 
            // resizeH
            // 
            this.resizeH.Location = new System.Drawing.Point(58, 3);
            this.resizeH.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.resizeH.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.resizeH.Name = "resizeH";
            this.resizeH.Size = new System.Drawing.Size(51, 20);
            this.resizeH.TabIndex = 15;
            this.resizeH.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // resizeW
            // 
            this.resizeW.Location = new System.Drawing.Point(3, 3);
            this.resizeW.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.resizeW.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.resizeW.Name = "resizeW";
            this.resizeW.Size = new System.Drawing.Size(52, 20);
            this.resizeW.TabIndex = 16;
            this.resizeW.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.resizeW);
            this.panel1.Controls.Add(this.ResizeB);
            this.panel1.Controls.Add(this.resizeH);
            this.panel1.Location = new System.Drawing.Point(4, 380);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 68);
            this.panel1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(3, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(139, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 283);
            this.panel2.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(41, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown_1);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove_1);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp_1);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(205, 388);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(262, 45);
            this.trackBar1.TabIndex = 19;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(257, 419);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.RightToLeftLayout = true;
            this.trackBar2.Size = new System.Drawing.Size(210, 45);
            this.trackBar2.TabIndex = 8;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(141, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Zoom:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(141, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Transparency:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Left_Rotate1
            // 
            this.Left_Rotate1.BackColor = System.Drawing.Color.DarkGray;
            this.Left_Rotate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Left_Rotate1.ForeColor = System.Drawing.Color.Navy;
            this.Left_Rotate1.Location = new System.Drawing.Point(25, 240);
            this.Left_Rotate1.Name = "Left_Rotate1";
            this.Left_Rotate1.Size = new System.Drawing.Size(99, 25);
            this.Left_Rotate1.TabIndex = 24;
            this.Left_Rotate1.Text = "Left_Rotate";
            this.Left_Rotate1.UseVisualStyleBackColor = false;
            this.Left_Rotate1.Click += new System.EventHandler(this.Left_Rotate1_Click);
            // 
            // Right_Rotate1
            // 
            this.Right_Rotate1.BackColor = System.Drawing.Color.DarkGray;
            this.Right_Rotate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Right_Rotate1.ForeColor = System.Drawing.Color.Navy;
            this.Right_Rotate1.Location = new System.Drawing.Point(25, 208);
            this.Right_Rotate1.Name = "Right_Rotate1";
            this.Right_Rotate1.Size = new System.Drawing.Size(99, 26);
            this.Right_Rotate1.TabIndex = 23;
            this.Right_Rotate1.Text = "Right_Rotate";
            this.Right_Rotate1.UseVisualStyleBackColor = false;
            this.Right_Rotate1.Click += new System.EventHandler(this.Right_Rotate1_Click);
            // 
            // Save_To_Device
            // 
            this.Save_To_Device.BackColor = System.Drawing.Color.DarkGray;
            this.Save_To_Device.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_To_Device.ForeColor = System.Drawing.Color.Navy;
            this.Save_To_Device.Location = new System.Drawing.Point(6, 120);
            this.Save_To_Device.Name = "Save_To_Device";
            this.Save_To_Device.Size = new System.Drawing.Size(119, 23);
            this.Save_To_Device.TabIndex = 25;
            this.Save_To_Device.Text = "Save To Device";
            this.Save_To_Device.UseVisualStyleBackColor = false;
            this.Save_To_Device.Click += new System.EventHandler(this.Save_To_Device_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(4, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "choose format:";
            // 
            // radioBmp
            // 
            this.radioBmp.AutoSize = true;
            this.radioBmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBmp.ForeColor = System.Drawing.Color.Red;
            this.radioBmp.Location = new System.Drawing.Point(12, 97);
            this.radioBmp.Name = "radioBmp";
            this.radioBmp.Size = new System.Drawing.Size(54, 20);
            this.radioBmp.TabIndex = 29;
            this.radioBmp.TabStop = true;
            this.radioBmp.Text = "Bmp";
            this.radioBmp.UseVisualStyleBackColor = true;
            // 
            // radiogif
            // 
            this.radiogif.AutoSize = true;
            this.radiogif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiogif.ForeColor = System.Drawing.Color.Red;
            this.radiogif.Location = new System.Drawing.Point(12, 74);
            this.radiogif.Name = "radiogif";
            this.radiogif.Size = new System.Drawing.Size(42, 20);
            this.radiogif.TabIndex = 28;
            this.radiogif.TabStop = true;
            this.radiogif.Text = "Gif";
            this.radiogif.UseVisualStyleBackColor = true;
            // 
            // radiopng
            // 
            this.radiopng.AutoSize = true;
            this.radiopng.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiopng.ForeColor = System.Drawing.Color.Red;
            this.radiopng.Location = new System.Drawing.Point(12, 51);
            this.radiopng.Name = "radiopng";
            this.radiopng.Size = new System.Drawing.Size(49, 20);
            this.radiopng.TabIndex = 27;
            this.radiopng.TabStop = true;
            this.radiopng.Text = "png";
            this.radiopng.UseVisualStyleBackColor = true;
            // 
            // radio
            // 
            this.radio.AutoSize = true;
            this.radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio.ForeColor = System.Drawing.Color.Red;
            this.radio.Location = new System.Drawing.Point(12, 28);
            this.radio.Name = "radio";
            this.radio.Size = new System.Drawing.Size(53, 20);
            this.radio.TabIndex = 26;
            this.radio.TabStop = true;
            this.radio.Text = "jpeg";
            this.radio.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.Save_To_Device);
            this.panel3.Controls.Add(this.radioBmp);
            this.panel3.Controls.Add(this.radio);
            this.panel3.Controls.Add(this.radiogif);
            this.panel3.Controls.Add(this.radiopng);
            this.panel3.Location = new System.Drawing.Point(4, 454);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(129, 158);
            this.panel3.TabIndex = 31;
            // 
            // saveText
            // 
            this.saveText.BackColor = System.Drawing.Color.DarkGray;
            this.saveText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveText.ForeColor = System.Drawing.Color.Navy;
            this.saveText.Location = new System.Drawing.Point(347, 65);
            this.saveText.Name = "saveText";
            this.saveText.Size = new System.Drawing.Size(135, 31);
            this.saveText.TabIndex = 32;
            this.saveText.Text = "Save With Text";
            this.saveText.UseVisualStyleBackColor = false;
            this.saveText.Click += new System.EventHandler(this.saveText_Click);
            // 
            // Copy1
            // 
            this.Copy1.BackColor = System.Drawing.Color.DarkGray;
            this.Copy1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copy1.ForeColor = System.Drawing.Color.Navy;
            this.Copy1.Location = new System.Drawing.Point(25, 271);
            this.Copy1.Name = "Copy1";
            this.Copy1.Size = new System.Drawing.Size(100, 24);
            this.Copy1.TabIndex = 33;
            this.Copy1.Text = "Copy";
            this.Copy1.UseVisualStyleBackColor = false;
            this.Copy1.Click += new System.EventHandler(this.Copy1_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.DarkGray;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.Red;
            this.exit.Location = new System.Drawing.Point(687, 5);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(81, 37);
            this.exit.TabIndex = 34;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // dgvImages
            // 
            this.dgvImages.AllowUserToAddRows = false;
            this.dgvImages.AllowUserToDeleteRows = false;
            this.dgvImages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImages.Location = new System.Drawing.Point(517, 400);
            this.dgvImages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvImages.Name = "dgvImages";
            this.dgvImages.ReadOnly = true;
            this.dgvImages.RowHeadersWidth = 51;
            this.dgvImages.RowTemplate.Height = 30;
            this.dgvImages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImages.Size = new System.Drawing.Size(265, 163);
            this.dgvImages.TabIndex = 3;
            this.dgvImages.Visible = false;
            this.dgvImages.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImages_CellClick);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(294, 574);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(119, 20);
            this.txtName.TabIndex = 37;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Navy;
            this.lblName.Location = new System.Drawing.Point(136, 573);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(158, 18);
            this.lblName.TabIndex = 38;
            this.lblName.Text = "Rename The Image:";
            // 
            // btnSaveToDB
            // 
            this.btnSaveToDB.BackColor = System.Drawing.Color.DarkGray;
            this.btnSaveToDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveToDB.ForeColor = System.Drawing.Color.Navy;
            this.btnSaveToDB.Location = new System.Drawing.Point(145, 594);
            this.btnSaveToDB.Name = "btnSaveToDB";
            this.btnSaveToDB.Size = new System.Drawing.Size(135, 32);
            this.btnSaveToDB.TabIndex = 39;
            this.btnSaveToDB.Text = "Save To DB";
            this.btnSaveToDB.UseVisualStyleBackColor = false;
            this.btnSaveToDB.Click += new System.EventHandler(this.btnSaveToDB_Click);
            // 
            // ShowAllImages
            // 
            this.ShowAllImages.BackColor = System.Drawing.Color.DarkGray;
            this.ShowAllImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAllImages.ForeColor = System.Drawing.Color.Navy;
            this.ShowAllImages.Location = new System.Drawing.Point(144, 505);
            this.ShowAllImages.Name = "ShowAllImages";
            this.ShowAllImages.Size = new System.Drawing.Size(135, 32);
            this.ShowAllImages.TabIndex = 40;
            this.ShowAllImages.Text = "Show All Images";
            this.ShowAllImages.UseVisualStyleBackColor = false;
            this.ShowAllImages.Click += new System.EventHandler(this.ShowAllImages_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(294, 541);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(119, 20);
            this.txtSearch.TabIndex = 41;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Navy;
            this.lblSearch.Location = new System.Drawing.Point(228, 541);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(66, 18);
            this.lblSearch.TabIndex = 42;
            this.lblSearch.Text = "Search:";
            // 
            // combine
            // 
            this.combine.BackColor = System.Drawing.Color.DarkGray;
            this.combine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combine.ForeColor = System.Drawing.Color.Navy;
            this.combine.Location = new System.Drawing.Point(25, 301);
            this.combine.Name = "combine";
            this.combine.Size = new System.Drawing.Size(99, 26);
            this.combine.TabIndex = 43;
            this.combine.Text = "Combine";
            this.combine.UseVisualStyleBackColor = false;
            this.combine.Click += new System.EventHandler(this.combine_Click);
            // 
            // image2
            // 
            this.image2.BackColor = System.Drawing.Color.DarkGray;
            this.image2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.image2.ForeColor = System.Drawing.Color.Red;
            this.image2.Location = new System.Drawing.Point(157, 12);
            this.image2.Name = "image2";
            this.image2.Size = new System.Drawing.Size(98, 30);
            this.image2.TabIndex = 44;
            this.image2.Text = "Photo2";
            this.image2.UseVisualStyleBackColor = false;
            this.image2.Click += new System.EventHandler(this.image2_Click);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(257, 454);
            this.trackBar3.Maximum = 255;
            this.trackBar3.Minimum = 10;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(210, 45);
            this.trackBar3.TabIndex = 45;
            this.trackBar3.Value = 10;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(142, 459);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 18);
            this.label5.TabIndex = 46;
            this.label5.Text = "Comb Trans:";
            // 
            // EditPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(789, 635);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.image2);
            this.Controls.Add(this.combine);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.ShowAllImages);
            this.Controls.Add(this.btnSaveToDB);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dgvImages);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Copy1);
            this.Controls.Add(this.saveText);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Left_Rotate1);
            this.Controls.Add(this.Right_Rotate1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Rev);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.mirror);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Write);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.ComboColor);
            this.Name = "EditPhoto";
            this.Text = "Edit Photo";
            this.Load += new System.EventHandler(this.EditPhoto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizeH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizeW)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ComboColor;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Write;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button mirror;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Rev;
        private System.Windows.Forms.Button ResizeB;
        private System.Windows.Forms.NumericUpDown resizeH;
        private System.Windows.Forms.NumericUpDown resizeW;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Left_Rotate1;
        private System.Windows.Forms.Button Right_Rotate1;
        private System.Windows.Forms.Button Save_To_Device;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioBmp;
        private System.Windows.Forms.RadioButton radiogif;
        private System.Windows.Forms.RadioButton radiopng;
        private System.Windows.Forms.RadioButton radio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button saveText;
        private System.Windows.Forms.Button Copy1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.DataGridView dgvImages;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSaveToDB;
        private System.Windows.Forms.Button ShowAllImages;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button combine;
        private System.Windows.Forms.Button image2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label label5;
    }
}