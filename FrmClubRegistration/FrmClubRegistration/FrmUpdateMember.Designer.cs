namespace FrmClubRegistration
{
    partial class FrmUpdateMember
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
            this.lastNameTextB = new System.Windows.Forms.TextBox();
            this.firstNameTextB = new System.Windows.Forms.TextBox();
            this.ageTextB = new System.Windows.Forms.TextBox();
            this.middleNameTextB = new System.Windows.Forms.TextBox();
            this.comboStudentId = new System.Windows.Forms.ComboBox();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.comboProgram = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lastNameTextB
            // 
            this.lastNameTextB.Location = new System.Drawing.Point(32, 122);
            this.lastNameTextB.Name = "lastNameTextB";
            this.lastNameTextB.Size = new System.Drawing.Size(187, 20);
            this.lastNameTextB.TabIndex = 0;
            // 
            // firstNameTextB
            // 
            this.firstNameTextB.Location = new System.Drawing.Point(32, 201);
            this.firstNameTextB.Name = "firstNameTextB";
            this.firstNameTextB.Size = new System.Drawing.Size(187, 20);
            this.firstNameTextB.TabIndex = 1;
            // 
            // ageTextB
            // 
            this.ageTextB.Location = new System.Drawing.Point(32, 339);
            this.ageTextB.Name = "ageTextB";
            this.ageTextB.Size = new System.Drawing.Size(187, 20);
            this.ageTextB.TabIndex = 2;
            // 
            // middleNameTextB
            // 
            this.middleNameTextB.Location = new System.Drawing.Point(32, 270);
            this.middleNameTextB.Name = "middleNameTextB";
            this.middleNameTextB.Size = new System.Drawing.Size(187, 20);
            this.middleNameTextB.TabIndex = 3;
            // 
            // comboStudentId
            // 
            this.comboStudentId.FormattingEnabled = true;
            this.comboStudentId.Location = new System.Drawing.Point(32, 44);
            this.comboStudentId.Name = "comboStudentId";
            this.comboStudentId.Size = new System.Drawing.Size(187, 21);
            this.comboStudentId.TabIndex = 4;
            this.comboStudentId.SelectedIndexChanged += new System.EventHandler(this.comboStudentId_SelectedIndexChanged);
            // 
            // comboGender
            // 
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboGender.Location = new System.Drawing.Point(32, 405);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(187, 21);
            this.comboGender.TabIndex = 5;
            // 
            // comboProgram
            // 
            this.comboProgram.FormattingEnabled = true;
            this.comboProgram.Items.AddRange(new object[] {
            "BS in Information Technology",
            "BS in Information System",
            "BS in Computer Engineering",
            "BS in Computer Science"});
            this.comboProgram.Location = new System.Drawing.Point(32, 476);
            this.comboProgram.Name = "comboProgram";
            this.comboProgram.Size = new System.Drawing.Size(187, 21);
            this.comboProgram.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Middle Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Age:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Gender:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 453);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Program:";
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.confirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.Location = new System.Drawing.Point(70, 519);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(118, 42);
            this.confirmBtn.TabIndex = 14;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // FrmUpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 588);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboProgram);
            this.Controls.Add(this.comboGender);
            this.Controls.Add(this.comboStudentId);
            this.Controls.Add(this.middleNameTextB);
            this.Controls.Add(this.ageTextB);
            this.Controls.Add(this.firstNameTextB);
            this.Controls.Add(this.lastNameTextB);
            this.Name = "FrmUpdateMember";
            this.Text = "FrmUpdateMember";
            this.Load += new System.EventHandler(this.FrmUpdateMember_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastNameTextB;
        private System.Windows.Forms.TextBox firstNameTextB;
        private System.Windows.Forms.TextBox ageTextB;
        private System.Windows.Forms.TextBox middleNameTextB;
        private System.Windows.Forms.ComboBox comboStudentId;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.ComboBox comboProgram;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button confirmBtn;
    }
}