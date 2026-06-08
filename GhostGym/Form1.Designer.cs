namespace GhostGym
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            comboBox1 = new ComboBox();
            label1 = new Label();
            comboBox2 = new ComboBox();
            label2 = new Label();
            visTimer1 = new System.Windows.Forms.Timer(components);
            visTimer2 = new System.Windows.Forms.Timer(components);
            visTimer3 = new System.Windows.Forms.Timer(components);
            visLabel = new Label();
            totalLabel = new Label();
            label5 = new Label();
            label6 = new Label();
            photoButton = new Button();
            accuracyLabel = new Label();
            checkGoodBox = new PictureBox();
            checkBadBox = new PictureBox();
            visEntrySelector = new NumericUpDown();
            totalEntrySelector = new NumericUpDown();
            photoTimer = new System.Windows.Forms.Timer(components);
            photoCooldown = new System.Windows.Forms.Timer(components);
            randomCheckBox = new CheckBox();
            randOffsetCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)checkGoodBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)checkBadBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)visEntrySelector).BeginInit();
            ((System.ComponentModel.ISupportInitialize)totalEntrySelector).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(81, 303);
            button1.Name = "button1";
            button1.Size = new Size(122, 46);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ghost;
            pictureBox1.Location = new Point(176, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 268);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "x2", "x1.5", "x1", "x0.75", "x0.5", "x0.25", "x0.1" });
            comboBox1.Location = new Point(199, 389);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 392);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "Speed";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Normal", "Phantom", "Oni", "Deogen" });
            comboBox2.Location = new Point(199, 433);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 4;
            comboBox2.SelectionChangeCommitted += comboBox2_SelectionChangeCommitted;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 436);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 5;
            label2.Text = "Ghost";
            // 
            // visTimer1
            // 
            visTimer1.Tick += visTimer1_Tick;
            // 
            // visTimer2
            // 
            visTimer2.Tick += visTimer2_Tick;
            // 
            // visTimer3
            // 
            visTimer3.Tick += visTimer3_Tick;
            // 
            // visLabel
            // 
            visLabel.AutoSize = true;
            visLabel.Location = new Point(190, 494);
            visLabel.Name = "visLabel";
            visLabel.Size = new Size(13, 15);
            visLabel.TabIndex = 6;
            visLabel.Text = "0";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new Point(252, 494);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(13, 15);
            totalLabel.TabIndex = 7;
            totalLabel.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(176, 479);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 8;
            label5.Text = "Vis Entry";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(231, 479);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 9;
            label6.Text = "Total Entry";
            // 
            // photoButton
            // 
            photoButton.Location = new Point(263, 303);
            photoButton.Name = "photoButton";
            photoButton.Size = new Size(122, 46);
            photoButton.TabIndex = 10;
            photoButton.Text = "Take Photo";
            photoButton.UseVisualStyleBackColor = true;
            photoButton.Click += photoButton_Click;
            photoButton.MouseDown += photoButton_MouseDown;
            photoButton.MouseUp += photoButton_MouseUp;
            // 
            // accuracyLabel
            // 
            accuracyLabel.AutoSize = true;
            accuracyLabel.Location = new Point(231, 352);
            accuracyLabel.Name = "accuracyLabel";
            accuracyLabel.Size = new Size(194, 15);
            accuracyLabel.TabIndex = 11;
            accuracyLabel.Text = "Successful: 0; Total: 0; Accuracy: 0%";
            // 
            // checkGoodBox
            // 
            checkGoodBox.Image = (Image)resources.GetObject("checkGoodBox.Image");
            checkGoodBox.Location = new Point(391, 299);
            checkGoodBox.Name = "checkGoodBox";
            checkGoodBox.Size = new Size(49, 50);
            checkGoodBox.SizeMode = PictureBoxSizeMode.StretchImage;
            checkGoodBox.TabIndex = 12;
            checkGoodBox.TabStop = false;
            // 
            // checkBadBox
            // 
            checkBadBox.Image = (Image)resources.GetObject("checkBadBox.Image");
            checkBadBox.Location = new Point(391, 299);
            checkBadBox.Name = "checkBadBox";
            checkBadBox.Size = new Size(49, 50);
            checkBadBox.SizeMode = PictureBoxSizeMode.StretchImage;
            checkBadBox.TabIndex = 13;
            checkBadBox.TabStop = false;
            // 
            // visEntrySelector
            // 
            visEntrySelector.Location = new Point(176, 512);
            visEntrySelector.Name = "visEntrySelector";
            visEntrySelector.Size = new Size(42, 23);
            visEntrySelector.TabIndex = 14;
            visEntrySelector.ValueChanged += visEntrySelector_ValueChanged;
            // 
            // totalEntrySelector
            // 
            totalEntrySelector.Location = new Point(240, 512);
            totalEntrySelector.Name = "totalEntrySelector";
            totalEntrySelector.Size = new Size(42, 23);
            totalEntrySelector.TabIndex = 15;
            totalEntrySelector.ValueChanged += totalEntrySelector_ValueChanged;
            // 
            // photoTimer
            // 
            photoTimer.Interval = 300;
            photoTimer.Tick += photoTimer_Tick;
            // 
            // photoCooldown
            // 
            photoCooldown.Interval = 500;
            photoCooldown.Tick += photoCooldown_Tick;
            // 
            // randomCheckBox
            // 
            randomCheckBox.AutoSize = true;
            randomCheckBox.Location = new Point(47, 512);
            randomCheckBox.Name = "randomCheckBox";
            randomCheckBox.Size = new Size(71, 19);
            randomCheckBox.TabIndex = 16;
            randomCheckBox.Text = "Random";
            randomCheckBox.UseVisualStyleBackColor = true;
            randomCheckBox.CheckedChanged += randomCheckBox_CheckedChanged;
            // 
            // randOffsetCheckBox
            // 
            randOffsetCheckBox.AutoSize = true;
            randOffsetCheckBox.Location = new Point(334, 512);
            randOffsetCheckBox.Name = "randOffsetCheckBox";
            randOffsetCheckBox.Size = new Size(106, 19);
            randOffsetCheckBox.TabIndex = 17;
            randOffsetCheckBox.Text = "Random Offset";
            randOffsetCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 562);
            Controls.Add(randOffsetCheckBox);
            Controls.Add(randomCheckBox);
            Controls.Add(totalEntrySelector);
            Controls.Add(visEntrySelector);
            Controls.Add(checkBadBox);
            Controls.Add(checkGoodBox);
            Controls.Add(accuracyLabel);
            Controls.Add(photoButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(totalLabel);
            Controls.Add(visLabel);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ghost Blinking Gym Tier I";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)checkGoodBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)checkBadBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)visEntrySelector).EndInit();
            ((System.ComponentModel.ISupportInitialize)totalEntrySelector).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private ComboBox comboBox1;
        private Label label1;
        private ComboBox comboBox2;
        private Label label2;
        private System.Windows.Forms.Timer visTimer1;
        private System.Windows.Forms.Timer visTimer2;
        private System.Windows.Forms.Timer visTimer3;
        private Label visLabel;
        private Label totalLabel;
        private Label label5;
        private Label label6;
        private Button photoButton;
        private Label accuracyLabel;
        private PictureBox checkGoodBox;
        private PictureBox checkBadBox;
        private NumericUpDown visEntrySelector;
        private NumericUpDown totalEntrySelector;
        private System.Windows.Forms.Timer photoTimer;
        private System.Windows.Forms.Timer photoCooldown;
        private CheckBox randomCheckBox;
        private CheckBox randOffsetCheckBox;
    }
}
