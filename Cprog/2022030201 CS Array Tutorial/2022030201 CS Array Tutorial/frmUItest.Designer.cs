namespace _2022030201_CS_Array_Tutorial
{
    partial class frmUItest
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
            this.cboCities = new System.Windows.Forms.ComboBox();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtLeft = new System.Windows.Forms.TextBox();
            this.txtRight = new System.Windows.Forms.TextBox();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpConverter = new System.Windows.Forms.TabPage();
            this.tpTest = new System.Windows.Forms.TabPage();
            this.tpMedical = new System.Windows.Forms.TabPage();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoUndefine = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMedicalResult = new System.Windows.Forms.TextBox();
            this.btnMedicalTest = new System.Windows.Forms.Button();
            this.chkSmoking = new System.Windows.Forms.CheckBox();
            this.chkDrink = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabList = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstFile = new System.Windows.Forms.ListBox();
            this.btnLoadFileList = new System.Windows.Forms.Button();
            this.cmdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mspaintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.digitalLogicSimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpConverter.SuspendLayout();
            this.tpTest.SuspendLayout();
            this.tpMedical.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabList.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboCities
            // 
            this.cboCities.FormattingEnabled = true;
            this.cboCities.Location = new System.Drawing.Point(18, 33);
            this.cboCities.Name = "cboCities";
            this.cboCities.Size = new System.Drawing.Size(219, 28);
            this.cboCities.TabIndex = 0;
            this.cboCities.SelectedIndexChanged += new System.EventHandler(this.cboCities_SelectedIndexChanged);
            // 
            // btnAddCity
            // 
            this.btnAddCity.Location = new System.Drawing.Point(15, 58);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(157, 38);
            this.btnAddCity.TabIndex = 1;
            this.btnAddCity.Text = "Add City";
            this.btnAddCity.UseVisualStyleBackColor = true;
            this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(15, 18);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(156, 26);
            this.txtCity.TabIndex = 2;
            // 
            // txtLeft
            // 
            this.txtLeft.Location = new System.Drawing.Point(18, 111);
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.Size = new System.Drawing.Size(99, 26);
            this.txtLeft.TabIndex = 3;
            // 
            // txtRight
            // 
            this.txtRight.Location = new System.Drawing.Point(138, 111);
            this.txtRight.Name = "txtRight";
            this.txtRight.Size = new System.Drawing.Size(99, 26);
            this.txtRight.TabIndex = 4;
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.Location = new System.Drawing.Point(22, 83);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(51, 20);
            this.lblLeft.TabIndex = 5;
            this.lblLeft.Text = "label1";
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.Location = new System.Drawing.Point(134, 83);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(51, 20);
            this.lblRight.TabIndex = 6;
            this.lblRight.Text = "label2";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(18, 162);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(218, 35);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRight);
            this.groupBox1.Controls.Add(this.btnCalculate);
            this.groupBox1.Controls.Add(this.cboCities);
            this.groupBox1.Controls.Add(this.lblRight);
            this.groupBox1.Controls.Add(this.txtLeft);
            this.groupBox1.Controls.Add(this.lblLeft);
            this.groupBox1.Location = new System.Drawing.Point(16, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 213);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unit Converter";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpConverter);
            this.tabControl1.Controls.Add(this.tpTest);
            this.tabControl1.Controls.Add(this.tpMedical);
            this.tabControl1.Controls.Add(this.tabList);
            this.tabControl1.Location = new System.Drawing.Point(12, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(641, 280);
            this.tabControl1.TabIndex = 9;
            // 
            // tpConverter
            // 
            this.tpConverter.Controls.Add(this.groupBox1);
            this.tpConverter.Location = new System.Drawing.Point(4, 29);
            this.tpConverter.Name = "tpConverter";
            this.tpConverter.Padding = new System.Windows.Forms.Padding(3);
            this.tpConverter.Size = new System.Drawing.Size(633, 247);
            this.tpConverter.TabIndex = 0;
            this.tpConverter.Text = "Converter";
            this.tpConverter.UseVisualStyleBackColor = true;
            // 
            // tpTest
            // 
            this.tpTest.Controls.Add(this.txtCity);
            this.tpTest.Controls.Add(this.btnAddCity);
            this.tpTest.Location = new System.Drawing.Point(4, 29);
            this.tpTest.Name = "tpTest";
            this.tpTest.Padding = new System.Windows.Forms.Padding(3);
            this.tpTest.Size = new System.Drawing.Size(633, 247);
            this.tpTest.TabIndex = 1;
            this.tpTest.Text = "Test";
            this.tpTest.UseVisualStyleBackColor = true;
            // 
            // tpMedical
            // 
            this.tpMedical.Controls.Add(this.radioButton2);
            this.tpMedical.Controls.Add(this.radioButton1);
            this.tpMedical.Controls.Add(this.groupBox3);
            this.tpMedical.Controls.Add(this.groupBox2);
            this.tpMedical.Location = new System.Drawing.Point(4, 29);
            this.tpMedical.Name = "tpMedical";
            this.tpMedical.Size = new System.Drawing.Size(633, 247);
            this.tpMedical.TabIndex = 2;
            this.tpMedical.Text = "Medical Checkup";
            this.tpMedical.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(422, 79);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(126, 24);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(422, 33);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(126, 24);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoMale);
            this.groupBox3.Controls.Add(this.rdoFemale);
            this.groupBox3.Controls.Add(this.rdoUndefine);
            this.groupBox3.Location = new System.Drawing.Point(247, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(122, 157);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sex";
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(16, 39);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(68, 24);
            this.rdoMale.TabIndex = 1;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(16, 69);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(87, 24);
            this.rdoFemale.TabIndex = 2;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoUndefine
            // 
            this.rdoUndefine.AutoSize = true;
            this.rdoUndefine.Location = new System.Drawing.Point(16, 99);
            this.rdoUndefine.Name = "rdoUndefine";
            this.rdoUndefine.Size = new System.Drawing.Size(99, 24);
            this.rdoUndefine.TabIndex = 3;
            this.rdoUndefine.TabStop = true;
            this.rdoUndefine.Text = "Undefine";
            this.rdoUndefine.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMedicalResult);
            this.groupBox2.Controls.Add(this.btnMedicalTest);
            this.groupBox2.Controls.Add(this.chkSmoking);
            this.groupBox2.Controls.Add(this.chkDrink);
            this.groupBox2.Location = new System.Drawing.Point(17, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 210);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // txtMedicalResult
            // 
            this.txtMedicalResult.Location = new System.Drawing.Point(21, 114);
            this.txtMedicalResult.Name = "txtMedicalResult";
            this.txtMedicalResult.Size = new System.Drawing.Size(177, 26);
            this.txtMedicalResult.TabIndex = 3;
            // 
            // btnMedicalTest
            // 
            this.btnMedicalTest.Location = new System.Drawing.Point(21, 156);
            this.btnMedicalTest.Name = "btnMedicalTest";
            this.btnMedicalTest.Size = new System.Drawing.Size(178, 43);
            this.btnMedicalTest.TabIndex = 2;
            this.btnMedicalTest.Text = "Medical Test";
            this.btnMedicalTest.UseVisualStyleBackColor = true;
            this.btnMedicalTest.Click += new System.EventHandler(this.btnMedicalTest_Click);
            // 
            // chkSmoking
            // 
            this.chkSmoking.AutoSize = true;
            this.chkSmoking.Location = new System.Drawing.Point(18, 58);
            this.chkSmoking.Name = "chkSmoking";
            this.chkSmoking.Size = new System.Drawing.Size(97, 24);
            this.chkSmoking.TabIndex = 1;
            this.chkSmoking.Text = "Smoking";
            this.chkSmoking.UseVisualStyleBackColor = true;
            // 
            // chkDrink
            // 
            this.chkDrink.AutoSize = true;
            this.chkDrink.Location = new System.Drawing.Point(18, 28);
            this.chkDrink.Name = "chkDrink";
            this.chkDrink.Size = new System.Drawing.Size(93, 24);
            this.chkDrink.TabIndex = 0;
            this.chkDrink.Text = "Drinking";
            this.chkDrink.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(674, 33);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdToolStripMenuItem,
            this.notepadToolStripMenuItem,
            this.mspaintToolStripMenuItem,
            this.digitalLogicSimToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.groupBox4);
            this.tabList.Location = new System.Drawing.Point(4, 29);
            this.tabList.Name = "tabList";
            this.tabList.Size = new System.Drawing.Size(633, 247);
            this.tabList.TabIndex = 3;
            this.tabList.Text = "List";
            this.tabList.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnLoadFileList);
            this.groupBox4.Controls.Add(this.lstFile);
            this.groupBox4.Location = new System.Drawing.Point(18, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(600, 238);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "FileList";
            // 
            // lstFile
            // 
            this.lstFile.FormattingEnabled = true;
            this.lstFile.ItemHeight = 20;
            this.lstFile.Location = new System.Drawing.Point(15, 30);
            this.lstFile.Name = "lstFile";
            this.lstFile.Size = new System.Drawing.Size(430, 184);
            this.lstFile.TabIndex = 0;
            // 
            // btnLoadFileList
            // 
            this.btnLoadFileList.Location = new System.Drawing.Point(461, 33);
            this.btnLoadFileList.Name = "btnLoadFileList";
            this.btnLoadFileList.Size = new System.Drawing.Size(125, 180);
            this.btnLoadFileList.TabIndex = 1;
            this.btnLoadFileList.Text = "Load File List";
            this.btnLoadFileList.UseVisualStyleBackColor = true;
            this.btnLoadFileList.Click += new System.EventHandler(this.btnLoadFileList_Click);
            // 
            // cmdToolStripMenuItem
            // 
            this.cmdToolStripMenuItem.Name = "cmdToolStripMenuItem";
            this.cmdToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.cmdToolStripMenuItem.Text = "cmd";
            this.cmdToolStripMenuItem.Click += new System.EventHandler(this.cmdToolStripMenuItem_Click);
            // 
            // notepadToolStripMenuItem
            // 
            this.notepadToolStripMenuItem.Name = "notepadToolStripMenuItem";
            this.notepadToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.notepadToolStripMenuItem.Text = "notepad";
            this.notepadToolStripMenuItem.Click += new System.EventHandler(this.notepadToolStripMenuItem_Click);
            // 
            // mspaintToolStripMenuItem
            // 
            this.mspaintToolStripMenuItem.Name = "mspaintToolStripMenuItem";
            this.mspaintToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.mspaintToolStripMenuItem.Text = "mspaint";
            this.mspaintToolStripMenuItem.Click += new System.EventHandler(this.mspaintToolStripMenuItem_Click);
            // 
            // digitalLogicSimToolStripMenuItem
            // 
            this.digitalLogicSimToolStripMenuItem.Name = "digitalLogicSimToolStripMenuItem";
            this.digitalLogicSimToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.digitalLogicSimToolStripMenuItem.Text = "Digital Logic Sim";
            this.digitalLogicSimToolStripMenuItem.Click += new System.EventHandler(this.digitalLogicSimToolStripMenuItem_Click);
            // 
            // frmUItest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 339);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmUItest";
            this.Text = "frmUItest";
            this.Load += new System.EventHandler(this.frmUItest_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpConverter.ResumeLayout(false);
            this.tpTest.ResumeLayout(false);
            this.tpTest.PerformLayout();
            this.tpMedical.ResumeLayout(false);
            this.tpMedical.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabList.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCities;
        private System.Windows.Forms.Button btnAddCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtLeft;
        private System.Windows.Forms.TextBox txtRight;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpConverter;
        private System.Windows.Forms.TabPage tpTest;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabPage tpMedical;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkSmoking;
        private System.Windows.Forms.CheckBox chkDrink;
        private System.Windows.Forms.TextBox txtMedicalResult;
        private System.Windows.Forms.Button btnMedicalTest;
        private System.Windows.Forms.RadioButton rdoUndefine;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabPage tabList;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lstFile;
        private System.Windows.Forms.Button btnLoadFileList;
        private System.Windows.Forms.ToolStripMenuItem cmdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notepadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mspaintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem digitalLogicSimToolStripMenuItem;
    }
}