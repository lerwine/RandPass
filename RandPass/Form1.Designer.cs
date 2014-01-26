namespace RandPass
{
    partial class RandPassForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandPassForm));
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.copyToClipboardButton = new System.Windows.Forms.Button();
            this.buttonsImageList = new System.Windows.Forms.ImageList(this.components);
            this.regenerateButton = new System.Windows.Forms.Button();
            this.minPassLenUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxPassLenUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maxDigitsUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxCapsUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxSpecUpDown = new System.Windows.Forms.NumericUpDown();
            this.passwordTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.minPassLenUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPassLenUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxDigitsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxCapsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSpecUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(227)))), ((int)(((byte)(224)))));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Location = new System.Drawing.Point(154, 13);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.ReadOnly = true;
            this.passwordTextBox.Size = new System.Drawing.Size(196, 20);
            this.passwordTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Minimum Password Length:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(9, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Maximum Password Length:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // copyToClipboardButton
            // 
            this.copyToClipboardButton.BackColor = System.Drawing.Color.Transparent;
            this.copyToClipboardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.copyToClipboardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyToClipboardButton.FlatAppearance.BorderSize = 0;
            this.copyToClipboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyToClipboardButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(161)))), ((int)(((byte)(153)))));
            this.copyToClipboardButton.ImageIndex = 0;
            this.copyToClipboardButton.ImageList = this.buttonsImageList;
            this.copyToClipboardButton.Location = new System.Drawing.Point(224, 39);
            this.copyToClipboardButton.Margin = new System.Windows.Forms.Padding(0);
            this.copyToClipboardButton.Name = "copyToClipboardButton";
            this.copyToClipboardButton.Size = new System.Drawing.Size(126, 23);
            this.copyToClipboardButton.TabIndex = 5;
            this.copyToClipboardButton.UseVisualStyleBackColor = false;
            this.copyToClipboardButton.MouseLeave += new System.EventHandler(this.copyToClipboardButton_MouseLeave);
            this.copyToClipboardButton.Click += new System.EventHandler(this.copyToClipboardButton_Click);
            this.copyToClipboardButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.copyToClipboardButton_MouseDown);
            this.copyToClipboardButton.MouseEnter += new System.EventHandler(this.copyToClipboardButton_MouseEnter);
            this.copyToClipboardButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.copyToClipboardButton_MouseUp);
            // 
            // buttonsImageList
            // 
            this.buttonsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("buttonsImageList.ImageStream")));
            this.buttonsImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.buttonsImageList.Images.SetKeyName(0, "CopyToClipboardUp.jpg");
            this.buttonsImageList.Images.SetKeyName(1, "CopyToClipboardHover.jpg");
            this.buttonsImageList.Images.SetKeyName(2, "CopyToClipboardDown.jpg");
            this.buttonsImageList.Images.SetKeyName(3, "RegneratePasswordUp.jpg");
            this.buttonsImageList.Images.SetKeyName(4, "RegneratePasswordHover.jpg");
            this.buttonsImageList.Images.SetKeyName(5, "RegneratePasswordDown.jpg");
            // 
            // regenerateButton
            // 
            this.regenerateButton.BackColor = System.Drawing.Color.Transparent;
            this.regenerateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.regenerateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regenerateButton.FlatAppearance.BorderSize = 0;
            this.regenerateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regenerateButton.ForeColor = System.Drawing.Color.Black;
            this.regenerateButton.ImageIndex = 3;
            this.regenerateButton.ImageList = this.buttonsImageList;
            this.regenerateButton.Location = new System.Drawing.Point(224, 142);
            this.regenerateButton.Margin = new System.Windows.Forms.Padding(0);
            this.regenerateButton.Name = "regenerateButton";
            this.regenerateButton.Size = new System.Drawing.Size(125, 23);
            this.regenerateButton.TabIndex = 6;
            this.regenerateButton.UseVisualStyleBackColor = false;
            this.regenerateButton.MouseLeave += new System.EventHandler(this.regenerateButton_MouseLeave);
            this.regenerateButton.Click += new System.EventHandler(this.regenerateButton_Click);
            this.regenerateButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.regenerateButton_MouseDown);
            this.regenerateButton.MouseEnter += new System.EventHandler(this.regenerateButton_MouseEnter);
            this.regenerateButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.regenerateButton_MouseUp);
            // 
            // minPassLenUpDown
            // 
            this.minPassLenUpDown.BackColor = System.Drawing.Color.White;
            this.minPassLenUpDown.ForeColor = System.Drawing.Color.Black;
            this.minPassLenUpDown.Location = new System.Drawing.Point(154, 42);
            this.minPassLenUpDown.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.minPassLenUpDown.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.minPassLenUpDown.Name = "minPassLenUpDown";
            this.minPassLenUpDown.Size = new System.Drawing.Size(64, 20);
            this.minPassLenUpDown.TabIndex = 7;
            this.minPassLenUpDown.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.minPassLenUpDown.ValueChanged += new System.EventHandler(this.minPassLenUpDown_ValueChanged);
            // 
            // maxPassLenUpDown
            // 
            this.maxPassLenUpDown.BackColor = System.Drawing.Color.White;
            this.maxPassLenUpDown.ForeColor = System.Drawing.Color.Black;
            this.maxPassLenUpDown.Location = new System.Drawing.Point(154, 67);
            this.maxPassLenUpDown.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.maxPassLenUpDown.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.maxPassLenUpDown.Name = "maxPassLenUpDown";
            this.maxPassLenUpDown.Size = new System.Drawing.Size(64, 20);
            this.maxPassLenUpDown.TabIndex = 8;
            this.maxPassLenUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.maxPassLenUpDown.ValueChanged += new System.EventHandler(this.maxPassLenUpDown_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(89, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Max Digits:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(90, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Max Caps:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(50, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Max Special Chars:";
            // 
            // maxDigitsUpDown
            // 
            this.maxDigitsUpDown.BackColor = System.Drawing.Color.White;
            this.maxDigitsUpDown.ForeColor = System.Drawing.Color.Black;
            this.maxDigitsUpDown.Location = new System.Drawing.Point(154, 93);
            this.maxDigitsUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.maxDigitsUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxDigitsUpDown.Name = "maxDigitsUpDown";
            this.maxDigitsUpDown.Size = new System.Drawing.Size(64, 20);
            this.maxDigitsUpDown.TabIndex = 12;
            this.maxDigitsUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // maxCapsUpDown
            // 
            this.maxCapsUpDown.BackColor = System.Drawing.Color.White;
            this.maxCapsUpDown.ForeColor = System.Drawing.Color.Black;
            this.maxCapsUpDown.Location = new System.Drawing.Point(154, 119);
            this.maxCapsUpDown.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.maxCapsUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxCapsUpDown.Name = "maxCapsUpDown";
            this.maxCapsUpDown.Size = new System.Drawing.Size(64, 20);
            this.maxCapsUpDown.TabIndex = 13;
            this.maxCapsUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // maxSpecUpDown
            // 
            this.maxSpecUpDown.BackColor = System.Drawing.Color.White;
            this.maxSpecUpDown.ForeColor = System.Drawing.Color.Black;
            this.maxSpecUpDown.Location = new System.Drawing.Point(154, 145);
            this.maxSpecUpDown.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.maxSpecUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxSpecUpDown.Name = "maxSpecUpDown";
            this.maxSpecUpDown.Size = new System.Drawing.Size(64, 20);
            this.maxSpecUpDown.TabIndex = 14;
            this.maxSpecUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // passwordTypeComboBox
            // 
            this.passwordTypeComboBox.BackColor = System.Drawing.Color.White;
            this.passwordTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.passwordTypeComboBox.ForeColor = System.Drawing.Color.Black;
            this.passwordTypeComboBox.FormattingEnabled = true;
            this.passwordTypeComboBox.Items.AddRange(new object[] {
            "Strong",
            "Alpha-Numeric",
            "Phone Keys",
            "Digits"});
            this.passwordTypeComboBox.Location = new System.Drawing.Point(224, 92);
            this.passwordTypeComboBox.Name = "passwordTypeComboBox";
            this.passwordTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.passwordTypeComboBox.TabIndex = 15;
            this.passwordTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.passwordTypeComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(224, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Password Type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(67, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "New Password:";
            // 
            // RandPassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::RandPass.Properties.Resources.ComboLock;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(362, 177);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.passwordTypeComboBox);
            this.Controls.Add(this.maxSpecUpDown);
            this.Controls.Add(this.maxCapsUpDown);
            this.Controls.Add(this.maxDigitsUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maxPassLenUpDown);
            this.Controls.Add(this.minPassLenUpDown);
            this.Controls.Add(this.regenerateButton);
            this.Controls.Add(this.copyToClipboardButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTextBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RandPassForm";
            this.Text = "Random Password Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minPassLenUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPassLenUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxDigitsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxCapsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSpecUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button copyToClipboardButton;
        private System.Windows.Forms.Button regenerateButton;
        private System.Windows.Forms.NumericUpDown minPassLenUpDown;
        private System.Windows.Forms.NumericUpDown maxPassLenUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown maxDigitsUpDown;
        private System.Windows.Forms.NumericUpDown maxCapsUpDown;
        private System.Windows.Forms.NumericUpDown maxSpecUpDown;
        private System.Windows.Forms.ComboBox passwordTypeComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ImageList buttonsImageList;
    }
}

