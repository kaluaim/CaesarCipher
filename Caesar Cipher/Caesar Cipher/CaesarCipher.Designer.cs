namespace Caesar_Cipher
{
    partial class CaesarCipher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaesarCipher));
            this.btnEnc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radoNOSps = new System.Windows.Forms.RadioButton();
            this.radoSps = new System.Windows.Forms.RadioButton();
            this.comboBoxEnc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtaPlan = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radoBest = new System.Windows.Forms.RadioButton();
            this.radoAll = new System.Windows.Forms.RadioButton();
            this.radoKey = new System.Windows.Forms.RadioButton();
            this.comboBoxDec = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDec = new System.Windows.Forms.Button();
            this.txtaCiph = new System.Windows.Forms.TextBox();
            this.txtaOut = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnc
            // 
            this.btnEnc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEnc.Location = new System.Drawing.Point(523, 148);
            this.btnEnc.Name = "btnEnc";
            this.btnEnc.Size = new System.Drawing.Size(152, 23);
            this.btnEnc.TabIndex = 0;
            this.btnEnc.Text = "Encrypt";
            this.btnEnc.UseVisualStyleBackColor = true;
            this.btnEnc.Click += new System.EventHandler(this.btnEnc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.comboBoxEnc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtaPlan);
            this.groupBox1.Controls.Add(this.btnEnc);
            this.groupBox1.Location = new System.Drawing.Point(12, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 177);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encryption";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox4.Controls.Add(this.radoNOSps);
            this.groupBox4.Controls.Add(this.radoSps);
            this.groupBox4.Location = new System.Drawing.Point(523, 39);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(152, 67);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Spaces";
            // 
            // radoNOSps
            // 
            this.radoNOSps.AutoSize = true;
            this.radoNOSps.Location = new System.Drawing.Point(7, 44);
            this.radoNOSps.Name = "radoNOSps";
            this.radoNOSps.Size = new System.Drawing.Size(80, 17);
            this.radoNOSps.TabIndex = 1;
            this.radoNOSps.Text = "NO Spaces";
            this.radoNOSps.UseVisualStyleBackColor = true;
            // 
            // radoSps
            // 
            this.radoSps.AutoSize = true;
            this.radoSps.Checked = true;
            this.radoSps.Location = new System.Drawing.Point(7, 20);
            this.radoSps.Name = "radoSps";
            this.radoSps.Size = new System.Drawing.Size(61, 17);
            this.radoSps.TabIndex = 0;
            this.radoSps.TabStop = true;
            this.radoSps.Text = "Spaces";
            this.radoSps.UseVisualStyleBackColor = true;
            // 
            // comboBoxEnc
            // 
            this.comboBoxEnc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBoxEnc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEnc.FormattingEnabled = true;
            this.comboBoxEnc.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25"});
            this.comboBoxEnc.Location = new System.Drawing.Point(554, 121);
            this.comboBoxEnc.Name = "comboBoxEnc";
            this.comboBoxEnc.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEnc.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(523, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Plaintext";
            // 
            // txtaPlan
            // 
            this.txtaPlan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtaPlan.Location = new System.Drawing.Point(7, 39);
            this.txtaPlan.Multiline = true;
            this.txtaPlan.Name = "txtaPlan";
            this.txtaPlan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtaPlan.Size = new System.Drawing.Size(510, 132);
            this.txtaPlan.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.comboBoxDec);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnDec);
            this.groupBox2.Controls.Add(this.txtaCiph);
            this.groupBox2.Location = new System.Drawing.Point(12, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(681, 177);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Decryption";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox3.Controls.Add(this.radoBest);
            this.groupBox3.Controls.Add(this.radoAll);
            this.groupBox3.Controls.Add(this.radoKey);
            this.groupBox3.Location = new System.Drawing.Point(523, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(152, 92);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // radoBest
            // 
            this.radoBest.AutoSize = true;
            this.radoBest.Location = new System.Drawing.Point(7, 68);
            this.radoBest.Name = "radoBest";
            this.radoBest.Size = new System.Drawing.Size(46, 17);
            this.radoBest.TabIndex = 2;
            this.radoBest.TabStop = true;
            this.radoBest.Text = "Best";
            this.radoBest.UseVisualStyleBackColor = true;
            this.radoBest.CheckedChanged += new System.EventHandler(this.radoBest_CheckedChanged);
            // 
            // radoAll
            // 
            this.radoAll.AutoSize = true;
            this.radoAll.Location = new System.Drawing.Point(7, 44);
            this.radoAll.Name = "radoAll";
            this.radoAll.Size = new System.Drawing.Size(36, 17);
            this.radoAll.TabIndex = 1;
            this.radoAll.TabStop = true;
            this.radoAll.Text = "All";
            this.radoAll.UseVisualStyleBackColor = true;
            this.radoAll.CheckedChanged += new System.EventHandler(this.radoAll_CheckedChanged);
            // 
            // radoKey
            // 
            this.radoKey.AutoSize = true;
            this.radoKey.Checked = true;
            this.radoKey.Location = new System.Drawing.Point(7, 20);
            this.radoKey.Name = "radoKey";
            this.radoKey.Size = new System.Drawing.Size(67, 17);
            this.radoKey.TabIndex = 0;
            this.radoKey.TabStop = true;
            this.radoKey.Text = "With key";
            this.radoKey.UseVisualStyleBackColor = true;
            this.radoKey.CheckedChanged += new System.EventHandler(this.radoKey_CheckedChanged);
            // 
            // comboBoxDec
            // 
            this.comboBoxDec.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBoxDec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDec.FormattingEnabled = true;
            this.comboBoxDec.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25"});
            this.comboBoxDec.Location = new System.Drawing.Point(554, 121);
            this.comboBoxDec.Name = "comboBoxDec";
            this.comboBoxDec.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDec.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(523, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ciphertext";
            // 
            // btnDec
            // 
            this.btnDec.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDec.Location = new System.Drawing.Point(523, 148);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(152, 23);
            this.btnDec.TabIndex = 3;
            this.btnDec.Text = "Decrypt";
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // txtaCiph
            // 
            this.txtaCiph.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtaCiph.Location = new System.Drawing.Point(6, 39);
            this.txtaCiph.Multiline = true;
            this.txtaCiph.Name = "txtaCiph";
            this.txtaCiph.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtaCiph.Size = new System.Drawing.Size(510, 132);
            this.txtaCiph.TabIndex = 2;
            // 
            // txtaOut
            // 
            this.txtaOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtaOut.BackColor = System.Drawing.Color.Black;
            this.txtaOut.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaOut.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtaOut.Location = new System.Drawing.Point(13, 493);
            this.txtaOut.Multiline = true;
            this.txtaOut.Name = "txtaOut";
            this.txtaOut.ReadOnly = true;
            this.txtaOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtaOut.Size = new System.Drawing.Size(680, 188);
            this.txtaOut.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(705, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAllToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.clearAllToolStripMenuItem.Text = "Clear All";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ver. 0.0.1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Caesar_Cipher.Properties.Resources.caesar_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 100);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(60, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "NOTE!! ONLY use english alphabet letters.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CaesarCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 693);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtaOut);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CaesarCipher";
            this.Text = "CaesarCipher";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtaOut;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox comboBoxEnc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtaPlan;
        private System.Windows.Forms.Button btnDec;
        private System.Windows.Forms.TextBox txtaCiph;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxDec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radoBest;
        private System.Windows.Forms.RadioButton radoAll;
        private System.Windows.Forms.RadioButton radoKey;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radoNOSps;
        private System.Windows.Forms.RadioButton radoSps;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

