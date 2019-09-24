namespace StudentProject
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
            this.SuspendLayout();
            // 
            // fNText
            // 
            this.fNText.Location = new System.Drawing.Point(61, 90);
            this.fNText.Name = "fNText";
            this.fNText.Size = new System.Drawing.Size(100, 20);
            this.fNText.TabIndex = 0;
            this.fNText.TextChanged += new System.EventHandler(this.FNText_TextChanged);
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(246, 90);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(100, 20);
            this.phoneText.TabIndex = 1;
            this.phoneText.TextChanged += new System.EventHandler(this.PhoneText_TextChanged);
            // 
            // genderText
            // 
            this.genderText.Location = new System.Drawing.Point(426, 90);
            this.genderText.Name = "genderText";
            this.genderText.Size = new System.Drawing.Size(100, 20);
            this.genderText.TabIndex = 2;
            this.genderText.TextChanged += new System.EventHandler(this.GenderText_TextChanged);
            // 
            // fNLabel
            // 
            this.fNLabel.AutoSize = true;
            this.fNLabel.Location = new System.Drawing.Point(78, 48);
            this.fNLabel.Name = "fNLabel";
            this.fNLabel.Size = new System.Drawing.Size(54, 13);
            this.fNLabel.TabIndex = 3;
            this.fNLabel.Text = "Full Name";
            this.fNLabel.Click += new System.EventHandler(this.FNLabel_Click);
            // 
            // phoneExtLabel
            // 
            this.phoneExtLabel.AutoSize = true;
            this.phoneExtLabel.Location = new System.Drawing.Point(243, 48);
            this.phoneExtLabel.Name = "phoneExtLabel";
            this.phoneExtLabel.Size = new System.Drawing.Size(87, 13);
            this.phoneExtLabel.TabIndex = 4;
            this.phoneExtLabel.Text = "Phone Extension";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(452, 48);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(42, 13);
            this.genderLabel.TabIndex = 5;
            this.genderLabel.Text = "Gender";
            // 
            // displayAllBtn
            // 
            this.displayAllBtn.Location = new System.Drawing.Point(230, 204);
            this.displayAllBtn.Name = "displayAllBtn";
            this.displayAllBtn.Size = new System.Drawing.Size(116, 23);
            this.displayAllBtn.TabIndex = 6;
            this.displayAllBtn.Text = "Display All";
            this.displayAllBtn.UseVisualStyleBackColor = true;
            this.displayAllBtn.Click += new System.EventHandler(this.DisplayAllBtn_Click);
            // 
            // displayWomenBtn
            // 
            this.displayWomenBtn.Location = new System.Drawing.Point(230, 254);
            this.displayWomenBtn.Name = "displayWomenBtn";
            this.displayWomenBtn.Size = new System.Drawing.Size(116, 23);
            this.displayWomenBtn.TabIndex = 7;
            this.displayWomenBtn.Text = "Display Women";
            this.displayWomenBtn.UseVisualStyleBackColor = true;
            this.displayWomenBtn.Click += new System.EventHandler(this.DisplayWomenBtn_Click);
            // 
            // displayMenBtn
            // 
            this.displayMenBtn.Location = new System.Drawing.Point(230, 302);
            this.displayMenBtn.Name = "displayMenBtn";
            this.displayMenBtn.Size = new System.Drawing.Size(116, 23);
            this.displayMenBtn.TabIndex = 8;
            this.displayMenBtn.Text = "Display Men";
            this.displayMenBtn.UseVisualStyleBackColor = true;
            this.displayMenBtn.Click += new System.EventHandler(this.DisplayMenBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 386);
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
    }
}

