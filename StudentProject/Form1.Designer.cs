﻿namespace StudentProject
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
            this.fNText = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.genderText = new System.Windows.Forms.TextBox();
            this.fNLabel = new System.Windows.Forms.Label();
            this.phoneExtLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.displayAllBtn = new System.Windows.Forms.Button();
            this.displayWomenBtn = new System.Windows.Forms.Button();
            this.displayMenBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.removeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fNText
            // 
            this.fNText.Location = new System.Drawing.Point(38, 89);
            this.fNText.Name = "fNText";
            this.fNText.Size = new System.Drawing.Size(70, 20);
            this.fNText.TabIndex = 0;
            this.fNText.TextChanged += new System.EventHandler(this.FNText_TextChanged);
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(246, 89);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(100, 20);
            this.phoneText.TabIndex = 1;
            this.phoneText.TextChanged += new System.EventHandler(this.PhoneText_TextChanged);
            // 
            // genderText
            // 
            this.genderText.Location = new System.Drawing.Point(410, 89);
            this.genderText.Name = "genderText";
            this.genderText.Size = new System.Drawing.Size(100, 20);
            this.genderText.TabIndex = 2;
            this.genderText.TextChanged += new System.EventHandler(this.GenderText_TextChanged);
            // 
            // fNLabel
            // 
            this.fNLabel.AutoSize = true;
            this.fNLabel.Location = new System.Drawing.Point(35, 47);
            this.fNLabel.Name = "fNLabel";
            this.fNLabel.Size = new System.Drawing.Size(57, 13);
            this.fNLabel.TabIndex = 3;
            this.fNLabel.Text = "First Name";
            this.fNLabel.Click += new System.EventHandler(this.FNLabel_Click);
            // 
            // phoneExtLabel
            // 
            this.phoneExtLabel.AutoSize = true;
            this.phoneExtLabel.Location = new System.Drawing.Point(243, 47);
            this.phoneExtLabel.Name = "phoneExtLabel";
            this.phoneExtLabel.Size = new System.Drawing.Size(87, 13);
            this.phoneExtLabel.TabIndex = 4;
            this.phoneExtLabel.Text = "Phone Extension";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(439, 47);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(42, 13);
            this.genderLabel.TabIndex = 5;
            this.genderLabel.Text = "Gender";
            // 
            // displayAllBtn
            // 
            this.displayAllBtn.Location = new System.Drawing.Point(426, 226);
            this.displayAllBtn.Name = "displayAllBtn";
            this.displayAllBtn.Size = new System.Drawing.Size(116, 23);
            this.displayAllBtn.TabIndex = 6;
            this.displayAllBtn.Text = "Display All";
            this.displayAllBtn.UseVisualStyleBackColor = true;
            this.displayAllBtn.Click += new System.EventHandler(this.DisplayAllBtn_Click);
            // 
            // displayWomenBtn
            // 
            this.displayWomenBtn.Location = new System.Drawing.Point(426, 275);
            this.displayWomenBtn.Name = "displayWomenBtn";
            this.displayWomenBtn.Size = new System.Drawing.Size(116, 23);
            this.displayWomenBtn.TabIndex = 7;
            this.displayWomenBtn.Text = "Display Women";
            this.displayWomenBtn.UseVisualStyleBackColor = true;
            this.displayWomenBtn.Click += new System.EventHandler(this.DisplayWomenBtn_Click);
            // 
            // displayMenBtn
            // 
            this.displayMenBtn.Location = new System.Drawing.Point(426, 321);
            this.displayMenBtn.Name = "displayMenBtn";
            this.displayMenBtn.Size = new System.Drawing.Size(116, 23);
            this.displayMenBtn.TabIndex = 8;
            this.displayMenBtn.Text = "Display Men";
            this.displayMenBtn.UseVisualStyleBackColor = true;
            this.displayMenBtn.Click += new System.EventHandler(this.DisplayMenBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(317, 157);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 9;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // prevBtn
            // 
            this.prevBtn.Location = new System.Drawing.Point(181, 157);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(75, 23);
            this.prevBtn.TabIndex = 10;
            this.prevBtn.Text = "Previous";
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.PrevBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 196);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(350, 134);
            this.listBox1.TabIndex = 11;
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(435, 186);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 23);
            this.removeBtn.TabIndex = 12;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Last Name";
            // 
            // lName
            // 
            this.lName.Location = new System.Drawing.Point(131, 89);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(100, 20);
            this.lName.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 386);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.displayMenBtn);
            this.Controls.Add(this.displayWomenBtn);
            this.Controls.Add(this.displayAllBtn);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.phoneExtLabel);
            this.Controls.Add(this.fNLabel);
            this.Controls.Add(this.genderText);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.fNText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fNText;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.TextBox genderText;
        private System.Windows.Forms.Label fNLabel;
        private System.Windows.Forms.Label phoneExtLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Button displayAllBtn;
        private System.Windows.Forms.Button displayWomenBtn;
        private System.Windows.Forms.Button displayMenBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lName;
    }
}

