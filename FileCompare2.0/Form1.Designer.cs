﻿namespace FileCompare2._0
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageGetFiles = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelCompare = new System.Windows.Forms.Label();
            this.progressBarCompare = new System.Windows.Forms.ProgressBar();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButtonFast = new System.Windows.Forms.RadioButton();
            this.radioButtonMedium = new System.Windows.Forms.RadioButton();
            this.radioButtonSlow = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonGetFiles = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageStudents = new System.Windows.Forms.TabPage();
            this.listBoxDisplayStudents = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageCompare = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonOpenDiffForm = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labelFileFromS2 = new System.Windows.Forms.Label();
            this.labelFileFromS1 = new System.Windows.Forms.Label();
            this.labelStudent2 = new System.Windows.Forms.Label();
            this.labelStudent1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonCompareRefresh = new System.Windows.Forms.Button();
            this.checkBoxCompShowAll = new System.Windows.Forms.CheckBox();
            this.checkBoxCompETC = new System.Windows.Forms.CheckBox();
            this.checkBoxCompCSS = new System.Windows.Forms.CheckBox();
            this.checkBoxCompHTML = new System.Windows.Forms.CheckBox();
            this.numericUpDownComparisons = new System.Windows.Forms.NumericUpDown();
            this.checkBoxShowX = new System.Windows.Forms.CheckBox();
            this.listBoxComparisons = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageGetFiles.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageStudents.SuspendLayout();
            this.tabPageCompare.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownComparisons)).BeginInit();
            this.tabPageAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageGetFiles);
            this.tabControl1.Controls.Add(this.tabPageStudents);
            this.tabControl1.Controls.Add(this.tabPageCompare);
            this.tabControl1.Controls.Add(this.tabPageAbout);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageGetFiles
            // 
            this.tabPageGetFiles.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageGetFiles.Controls.Add(this.groupBox3);
            this.tabPageGetFiles.Controls.Add(this.groupBox2);
            this.tabPageGetFiles.Controls.Add(this.groupBox1);
            this.tabPageGetFiles.Controls.Add(this.label2);
            this.tabPageGetFiles.Location = new System.Drawing.Point(4, 29);
            this.tabPageGetFiles.Name = "tabPageGetFiles";
            this.tabPageGetFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGetFiles.Size = new System.Drawing.Size(768, 393);
            this.tabPageGetFiles.TabIndex = 0;
            this.tabPageGetFiles.Text = "Get Files";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBoxOutput);
            this.groupBox3.Location = new System.Drawing.Point(9, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(753, 163);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output";
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Location = new System.Drawing.Point(9, 19);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.Size = new System.Drawing.Size(738, 138);
            this.richTextBoxOutput.TabIndex = 0;
            this.richTextBoxOutput.Text = "Errors or messages will be shown here.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelCompare);
            this.groupBox2.Controls.Add(this.progressBarCompare);
            this.groupBox2.Controls.Add(this.buttonCompare);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(360, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 172);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Comparison";
            // 
            // labelCompare
            // 
            this.labelCompare.AutoSize = true;
            this.labelCompare.Location = new System.Drawing.Point(361, 126);
            this.labelCompare.Name = "labelCompare";
            this.labelCompare.Size = new System.Drawing.Size(0, 20);
            this.labelCompare.TabIndex = 6;
            // 
            // progressBarCompare
            // 
            this.progressBarCompare.Location = new System.Drawing.Point(6, 145);
            this.progressBarCompare.Name = "progressBarCompare";
            this.progressBarCompare.Size = new System.Drawing.Size(390, 23);
            this.progressBarCompare.TabIndex = 5;
            // 
            // buttonCompare
            // 
            this.buttonCompare.Location = new System.Drawing.Point(7, 116);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(172, 23);
            this.buttonCompare.TabIndex = 4;
            this.buttonCompare.Text = "Start Comparison";
            this.buttonCompare.UseVisualStyleBackColor = true;
            this.buttonCompare.Click += new System.EventHandler(this.buttonCompare_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButtonFast);
            this.groupBox4.Controls.Add(this.radioButtonMedium);
            this.groupBox4.Controls.Add(this.radioButtonSlow);
            this.groupBox4.Location = new System.Drawing.Point(7, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(172, 90);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Comparison Level";
            // 
            // radioButtonFast
            // 
            this.radioButtonFast.AutoSize = true;
            this.radioButtonFast.Location = new System.Drawing.Point(7, 66);
            this.radioButtonFast.Name = "radioButtonFast";
            this.radioButtonFast.Size = new System.Drawing.Size(205, 24);
            this.radioButtonFast.TabIndex = 2;
            this.radioButtonFast.Text = "Fast - Massive amount";
            this.radioButtonFast.UseVisualStyleBackColor = true;
            // 
            // radioButtonMedium
            // 
            this.radioButtonMedium.AutoSize = true;
            this.radioButtonMedium.Location = new System.Drawing.Point(7, 43);
            this.radioButtonMedium.Name = "radioButtonMedium";
            this.radioButtonMedium.Size = new System.Drawing.Size(214, 24);
            this.radioButtonMedium.TabIndex = 1;
            this.radioButtonMedium.Text = "Medium - Large Amount";
            this.radioButtonMedium.UseVisualStyleBackColor = true;
            // 
            // radioButtonSlow
            // 
            this.radioButtonSlow.AutoSize = true;
            this.radioButtonSlow.Checked = true;
            this.radioButtonSlow.Location = new System.Drawing.Point(7, 20);
            this.radioButtonSlow.Name = "radioButtonSlow";
            this.radioButtonSlow.Size = new System.Drawing.Size(209, 24);
            this.radioButtonSlow.TabIndex = 0;
            this.radioButtonSlow.TabStop = true;
            this.radioButtonSlow.Text = "Slow - Average Amount";
            this.radioButtonSlow.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonGetFiles);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxFilePath);
            this.groupBox1.Location = new System.Drawing.Point(9, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 172);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files";
            // 
            // buttonGetFiles
            // 
            this.buttonGetFiles.Location = new System.Drawing.Point(82, 73);
            this.buttonGetFiles.Name = "buttonGetFiles";
            this.buttonGetFiles.Size = new System.Drawing.Size(126, 23);
            this.buttonGetFiles.TabIndex = 3;
            this.buttonGetFiles.Text = "Get Files";
            this.buttonGetFiles.UseVisualStyleBackColor = true;
            this.buttonGetFiles.Click += new System.EventHandler(this.buttonGetFiles_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "File Location:";
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(82, 35);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(231, 26);
            this.textBoxFilePath.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 47);
            this.label2.TabIndex = 2;
            this.label2.Text = "Get Files";
            // 
            // tabPageStudents
            // 
            this.tabPageStudents.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageStudents.Controls.Add(this.listBoxDisplayStudents);
            this.tabPageStudents.Controls.Add(this.label1);
            this.tabPageStudents.Location = new System.Drawing.Point(4, 29);
            this.tabPageStudents.Name = "tabPageStudents";
            this.tabPageStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudents.Size = new System.Drawing.Size(768, 393);
            this.tabPageStudents.TabIndex = 1;
            this.tabPageStudents.Text = "Students";
            // 
            // listBoxDisplayStudents
            // 
            this.listBoxDisplayStudents.FormattingEnabled = true;
            this.listBoxDisplayStudents.ItemHeight = 20;
            this.listBoxDisplayStudents.Location = new System.Drawing.Point(9, 52);
            this.listBoxDisplayStudents.Name = "listBoxDisplayStudents";
            this.listBoxDisplayStudents.Size = new System.Drawing.Size(264, 324);
            this.listBoxDisplayStudents.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Students";
            // 
            // tabPageCompare
            // 
            this.tabPageCompare.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageCompare.Controls.Add(this.groupBox6);
            this.tabPageCompare.Controls.Add(this.groupBox5);
            this.tabPageCompare.Controls.Add(this.listBoxComparisons);
            this.tabPageCompare.Controls.Add(this.label4);
            this.tabPageCompare.Location = new System.Drawing.Point(4, 29);
            this.tabPageCompare.Name = "tabPageCompare";
            this.tabPageCompare.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCompare.Size = new System.Drawing.Size(768, 393);
            this.tabPageCompare.TabIndex = 2;
            this.tabPageCompare.Text = "Comparisons";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonOpenDiffForm);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.labelFileFromS2);
            this.groupBox6.Controls.Add(this.labelFileFromS1);
            this.groupBox6.Controls.Add(this.labelStudent2);
            this.groupBox6.Controls.Add(this.labelStudent1);
            this.groupBox6.Location = new System.Drawing.Point(485, 52);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(277, 192);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Selected Comparison";
            // 
            // buttonOpenDiffForm
            // 
            this.buttonOpenDiffForm.Location = new System.Drawing.Point(6, 151);
            this.buttonOpenDiffForm.Name = "buttonOpenDiffForm";
            this.buttonOpenDiffForm.Size = new System.Drawing.Size(100, 23);
            this.buttonOpenDiffForm.TabIndex = 5;
            this.buttonOpenDiffForm.Text = "Open Diff Form";
            this.buttonOpenDiffForm.UseVisualStyleBackColor = true;
            this.buttonOpenDiffForm.Click += new System.EventHandler(this.buttonOpenDiffForm_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Data:";
            // 
            // labelFileFromS2
            // 
            this.labelFileFromS2.AutoSize = true;
            this.labelFileFromS2.Location = new System.Drawing.Point(6, 88);
            this.labelFileFromS2.Name = "labelFileFromS2";
            this.labelFileFromS2.Size = new System.Drawing.Size(105, 20);
            this.labelFileFromS2.TabIndex = 3;
            this.labelFileFromS2.Text = "File from S2:";
            // 
            // labelFileFromS1
            // 
            this.labelFileFromS1.AutoSize = true;
            this.labelFileFromS1.Location = new System.Drawing.Point(6, 65);
            this.labelFileFromS1.Name = "labelFileFromS1";
            this.labelFileFromS1.Size = new System.Drawing.Size(105, 20);
            this.labelFileFromS1.TabIndex = 2;
            this.labelFileFromS1.Text = "File from S1:";
            // 
            // labelStudent2
            // 
            this.labelStudent2.AutoSize = true;
            this.labelStudent2.Location = new System.Drawing.Point(6, 42);
            this.labelStudent2.Name = "labelStudent2";
            this.labelStudent2.Size = new System.Drawing.Size(90, 20);
            this.labelStudent2.TabIndex = 1;
            this.labelStudent2.Text = "Student 2: ";
            // 
            // labelStudent1
            // 
            this.labelStudent1.AutoSize = true;
            this.labelStudent1.Location = new System.Drawing.Point(6, 20);
            this.labelStudent1.Name = "labelStudent1";
            this.labelStudent1.Size = new System.Drawing.Size(90, 20);
            this.labelStudent1.TabIndex = 0;
            this.labelStudent1.Text = "Student 1: ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonCompareRefresh);
            this.groupBox5.Controls.Add(this.checkBoxCompShowAll);
            this.groupBox5.Controls.Add(this.checkBoxCompETC);
            this.groupBox5.Controls.Add(this.checkBoxCompCSS);
            this.groupBox5.Controls.Add(this.checkBoxCompHTML);
            this.groupBox5.Controls.Add(this.numericUpDownComparisons);
            this.groupBox5.Controls.Add(this.checkBoxShowX);
            this.groupBox5.Location = new System.Drawing.Point(279, 52);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 192);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Display Options";
            // 
            // buttonCompareRefresh
            // 
            this.buttonCompareRefresh.Location = new System.Drawing.Point(6, 151);
            this.buttonCompareRefresh.Name = "buttonCompareRefresh";
            this.buttonCompareRefresh.Size = new System.Drawing.Size(100, 23);
            this.buttonCompareRefresh.TabIndex = 6;
            this.buttonCompareRefresh.Text = "Refresh List";
            this.buttonCompareRefresh.UseVisualStyleBackColor = true;
            this.buttonCompareRefresh.Click += new System.EventHandler(this.buttonCompareRefresh_Click);
            // 
            // checkBoxCompShowAll
            // 
            this.checkBoxCompShowAll.AutoSize = true;
            this.checkBoxCompShowAll.Checked = true;
            this.checkBoxCompShowAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCompShowAll.Location = new System.Drawing.Point(6, 87);
            this.checkBoxCompShowAll.Name = "checkBoxCompShowAll";
            this.checkBoxCompShowAll.Size = new System.Drawing.Size(100, 24);
            this.checkBoxCompShowAll.TabIndex = 5;
            this.checkBoxCompShowAll.Text = "Show All";
            this.checkBoxCompShowAll.UseVisualStyleBackColor = true;
            // 
            // checkBoxCompETC
            // 
            this.checkBoxCompETC.AutoSize = true;
            this.checkBoxCompETC.Location = new System.Drawing.Point(6, 64);
            this.checkBoxCompETC.Name = "checkBoxCompETC";
            this.checkBoxCompETC.Size = new System.Drawing.Size(126, 24);
            this.checkBoxCompETC.TabIndex = 4;
            this.checkBoxCompETC.Text = "Include ETC";
            this.checkBoxCompETC.UseVisualStyleBackColor = true;
            // 
            // checkBoxCompCSS
            // 
            this.checkBoxCompCSS.AutoSize = true;
            this.checkBoxCompCSS.Checked = true;
            this.checkBoxCompCSS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCompCSS.Location = new System.Drawing.Point(6, 41);
            this.checkBoxCompCSS.Name = "checkBoxCompCSS";
            this.checkBoxCompCSS.Size = new System.Drawing.Size(127, 24);
            this.checkBoxCompCSS.TabIndex = 3;
            this.checkBoxCompCSS.Text = "Include CSS";
            this.checkBoxCompCSS.UseVisualStyleBackColor = true;
            // 
            // checkBoxCompHTML
            // 
            this.checkBoxCompHTML.AutoSize = true;
            this.checkBoxCompHTML.Checked = true;
            this.checkBoxCompHTML.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCompHTML.Location = new System.Drawing.Point(6, 19);
            this.checkBoxCompHTML.Name = "checkBoxCompHTML";
            this.checkBoxCompHTML.Size = new System.Drawing.Size(140, 24);
            this.checkBoxCompHTML.TabIndex = 2;
            this.checkBoxCompHTML.Text = "Include HTML";
            this.checkBoxCompHTML.UseVisualStyleBackColor = true;
            // 
            // numericUpDownComparisons
            // 
            this.numericUpDownComparisons.Location = new System.Drawing.Point(77, 109);
            this.numericUpDownComparisons.Name = "numericUpDownComparisons";
            this.numericUpDownComparisons.Size = new System.Drawing.Size(45, 26);
            this.numericUpDownComparisons.TabIndex = 1;
            this.numericUpDownComparisons.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // checkBoxShowX
            // 
            this.checkBoxShowX.AutoSize = true;
            this.checkBoxShowX.Location = new System.Drawing.Point(6, 110);
            this.checkBoxShowX.Name = "checkBoxShowX";
            this.checkBoxShowX.Size = new System.Drawing.Size(293, 24);
            this.checkBoxShowX.TabIndex = 0;
            this.checkBoxShowX.Text = "Show Top                 Comparisons";
            this.checkBoxShowX.UseVisualStyleBackColor = true;
            // 
            // listBoxComparisons
            // 
            this.listBoxComparisons.FormattingEnabled = true;
            this.listBoxComparisons.ItemHeight = 20;
            this.listBoxComparisons.Location = new System.Drawing.Point(9, 52);
            this.listBoxComparisons.Name = "listBoxComparisons";
            this.listBoxComparisons.Size = new System.Drawing.Size(264, 324);
            this.listBoxComparisons.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 47);
            this.label4.TabIndex = 2;
            this.label4.Text = "Comparisons";
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageAbout.Controls.Add(this.label10);
            this.tabPageAbout.Controls.Add(this.label9);
            this.tabPageAbout.Controls.Add(this.label8);
            this.tabPageAbout.Controls.Add(this.label6);
            this.tabPageAbout.Controls.Add(this.label5);
            this.tabPageAbout.Location = new System.Drawing.Point(4, 29);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAbout.Size = new System.Drawing.Size(768, 393);
            this.tabPageAbout.TabIndex = 3;
            this.tabPageAbout.Text = "About";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(455, 80);
            this.label10.TabIndex = 7;
            this.label10.Text = "This program was made to help instructors compare\r\n files that their student subm" +
    "it. It was built to be used \r\n for html/css projects.\r\n DO NOT DISTRIBUTE WITHOU" +
    "T AUTHOR PERMISSION.\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Last Edit: 5/15/2019";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Author: Preston Duffield";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Version: 2.0.1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 47);
            this.label5.TabIndex = 3;
            this.label5.Text = "About";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "File Compare 2";
            this.tabControl1.ResumeLayout(false);
            this.tabPageGetFiles.ResumeLayout(false);
            this.tabPageGetFiles.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageStudents.ResumeLayout(false);
            this.tabPageStudents.PerformLayout();
            this.tabPageCompare.ResumeLayout(false);
            this.tabPageCompare.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownComparisons)).EndInit();
            this.tabPageAbout.ResumeLayout(false);
            this.tabPageAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageGetFiles;
        private System.Windows.Forms.TabPage tabPageStudents;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonGetFiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.ListBox listBoxDisplayStudents;
        private System.Windows.Forms.Button buttonCompare;
        private System.Windows.Forms.TabPage tabPageCompare;
        private System.Windows.Forms.ListBox listBoxComparisons;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBarCompare;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButtonFast;
        private System.Windows.Forms.RadioButton radioButtonMedium;
        private System.Windows.Forms.RadioButton radioButtonSlow;
        private System.Windows.Forms.Label labelCompare;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label labelStudent2;
        private System.Windows.Forms.Label labelStudent1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBoxCompCSS;
        private System.Windows.Forms.CheckBox checkBoxCompHTML;
        private System.Windows.Forms.NumericUpDown numericUpDownComparisons;
        private System.Windows.Forms.CheckBox checkBoxShowX;
        private System.Windows.Forms.CheckBox checkBoxCompETC;
        private System.Windows.Forms.Label labelFileFromS2;
        private System.Windows.Forms.Label labelFileFromS1;
        private System.Windows.Forms.Button buttonCompareRefresh;
        private System.Windows.Forms.CheckBox checkBoxCompShowAll;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonOpenDiffForm;
        private System.Windows.Forms.TabPage tabPageAbout;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

