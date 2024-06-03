namespace FTP_CLIENT
{
    partial class FtpWindow
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FtpWindow));
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            conButton = new Button();
            console = new TextBox();
            treeView1 = new TreeView();
            imageList1 = new ImageList(components);
            pathLabel = new Label();
            upButton = new Button();
            button3 = new Button();
            button4 = new Button();
            label6 = new Label();
            disButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Server";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(56, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(79, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 21);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 2;
            label2.Text = "Port";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(176, 18);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(36, 23);
            textBox2.TabIndex = 3;
            textBox2.Text = "21";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 21);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 4;
            label3.Text = "User";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(254, 18);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(360, 21);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 6;
            label4.Text = "Password";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(423, 18);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 7;
            textBox4.UseSystemPasswordChar = true;
            // 
            // conButton
            // 
            conButton.Location = new Point(538, 17);
            conButton.Name = "conButton";
            conButton.Size = new Size(75, 23);
            conButton.TabIndex = 8;
            conButton.Text = "Connect";
            conButton.UseVisualStyleBackColor = true;
            conButton.Click += conButton_Click;
            // 
            // console
            // 
            console.BackColor = SystemColors.ControlLightLight;
            console.BorderStyle = BorderStyle.None;
            console.Location = new Point(12, 566);
            console.Multiline = true;
            console.Name = "console";
            console.ReadOnly = true;
            console.ScrollBars = ScrollBars.Vertical;
            console.Size = new Size(610, 162);
            console.TabIndex = 9;
            console.TextChanged += textBox5_TextChanged;
            // 
            // treeView1
            // 
            treeView1.ImageIndex = 0;
            treeView1.ImageList = imageList1;
            treeView1.Location = new Point(12, 109);
            treeView1.Name = "treeView1";
            treeView1.SelectedImageIndex = 0;
            treeView1.Size = new Size(610, 387);
            treeView1.TabIndex = 10;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "directory.jpg");
            imageList1.Images.SetKeyName(1, "file.png");
            // 
            // pathLabel
            // 
            pathLabel.AutoSize = true;
            pathLabel.Location = new Point(12, 509);
            pathLabel.Name = "pathLabel";
            pathLabel.Size = new Size(38, 15);
            pathLabel.TabIndex = 11;
            pathLabel.Text = "PATH:";
            pathLabel.Click += label5_Click;
            // 
            // upButton
            // 
            upButton.Location = new Point(12, 63);
            upButton.Name = "upButton";
            upButton.Size = new Size(94, 23);
            upButton.TabIndex = 12;
            upButton.Text = "Upload...";
            upButton.UseVisualStyleBackColor = true;
            upButton.Click += upButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(112, 63);
            button3.Name = "button3";
            button3.Size = new Size(94, 23);
            button3.TabIndex = 13;
            button3.Text = "Download...";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(212, 63);
            button4.Name = "button4";
            button4.Size = new Size(94, 23);
            button4.TabIndex = 14;
            button4.Text = "Delete...";
            button4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 537);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 15;
            label6.Text = "FILE PATH:";
            // 
            // disButton
            // 
            disButton.Location = new Point(538, 46);
            disButton.Name = "disButton";
            disButton.Size = new Size(75, 23);
            disButton.TabIndex = 16;
            disButton.Text = "Disconnect";
            disButton.UseVisualStyleBackColor = true;
            disButton.Click += disButton_Click;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(312, 59);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 17;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FtpWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 740);
            Controls.Add(button1);
            Controls.Add(disButton);
            Controls.Add(label6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(upButton);
            Controls.Add(pathLabel);
            Controls.Add(treeView1);
            Controls.Add(console);
            Controls.Add(conButton);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FtpWindow";
            Text = "FTP Client";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Button conButton;
        private TextBox console;
        private TreeView treeView1;
        private Label pathLabel;
        private Button upButton;
        private Button button3;
        private Button button4;
        private Label label6;
        private Button disButton;
        private Button button1;
        private ImageList imageList1;
    }
}
