namespace Alsaina
{
    partial class MainDoctorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDoctorForm));
            this.label1 = new System.Windows.Forms.Label();
            this.comboPatientNames = new System.Windows.Forms.ComboBox();
            this.showPatientInformation = new System.Windows.Forms.Button();
            this.headGender = new System.Windows.Forms.Label();
            this.headAge = new System.Windows.Forms.Label();
            this.headName = new System.Windows.Forms.Label();
            this.showName = new System.Windows.Forms.Label();
            this.showAge = new System.Windows.Forms.Label();
            this.showGender = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtReport = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.daysOfWeek = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboHour = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(58, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "Patient";
            // 
            // comboPatientNames
            // 
            this.comboPatientNames.FormattingEnabled = true;
            this.comboPatientNames.Location = new System.Drawing.Point(200, 42);
            this.comboPatientNames.Name = "comboPatientNames";
            this.comboPatientNames.Size = new System.Drawing.Size(261, 24);
            this.comboPatientNames.TabIndex = 27;
            // 
            // showPatientInformation
            // 
            this.showPatientInformation.BackColor = System.Drawing.Color.Goldenrod;
            this.showPatientInformation.FlatAppearance.BorderSize = 0;
            this.showPatientInformation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.showPatientInformation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.showPatientInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPatientInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPatientInformation.ForeColor = System.Drawing.Color.White;
            this.showPatientInformation.Location = new System.Drawing.Point(488, 32);
            this.showPatientInformation.Name = "showPatientInformation";
            this.showPatientInformation.Size = new System.Drawing.Size(336, 42);
            this.showPatientInformation.TabIndex = 28;
            this.showPatientInformation.Text = "Show Patient Information";
            this.showPatientInformation.UseVisualStyleBackColor = false;
            this.showPatientInformation.Click += new System.EventHandler(this.showPatientInformation_Click);
            // 
            // headGender
            // 
            this.headGender.AutoSize = true;
            this.headGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.headGender.ForeColor = System.Drawing.Color.Goldenrod;
            this.headGender.Location = new System.Drawing.Point(617, 101);
            this.headGender.Name = "headGender";
            this.headGender.Size = new System.Drawing.Size(83, 25);
            this.headGender.TabIndex = 35;
            this.headGender.Text = "Gender";
            this.headGender.Visible = false;
            // 
            // headAge
            // 
            this.headAge.AutoSize = true;
            this.headAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.headAge.ForeColor = System.Drawing.Color.Goldenrod;
            this.headAge.Location = new System.Drawing.Point(367, 101);
            this.headAge.Name = "headAge";
            this.headAge.Size = new System.Drawing.Size(51, 25);
            this.headAge.TabIndex = 34;
            this.headAge.Text = "Age";
            this.headAge.Visible = false;
            // 
            // headName
            // 
            this.headName.AutoSize = true;
            this.headName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.headName.ForeColor = System.Drawing.Color.Goldenrod;
            this.headName.Location = new System.Drawing.Point(97, 101);
            this.headName.Name = "headName";
            this.headName.Size = new System.Drawing.Size(68, 25);
            this.headName.TabIndex = 33;
            this.headName.Text = "Name";
            this.headName.Visible = false;
            // 
            // showName
            // 
            this.showName.AutoSize = true;
            this.showName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.showName.ForeColor = System.Drawing.Color.White;
            this.showName.Location = new System.Drawing.Point(97, 156);
            this.showName.Name = "showName";
            this.showName.Size = new System.Drawing.Size(0, 25);
            this.showName.TabIndex = 36;
            // 
            // showAge
            // 
            this.showAge.AutoSize = true;
            this.showAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.showAge.ForeColor = System.Drawing.Color.White;
            this.showAge.Location = new System.Drawing.Point(367, 156);
            this.showAge.Name = "showAge";
            this.showAge.Size = new System.Drawing.Size(0, 25);
            this.showAge.TabIndex = 37;
            // 
            // showGender
            // 
            this.showGender.AutoSize = true;
            this.showGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.showGender.ForeColor = System.Drawing.Color.White;
            this.showGender.Location = new System.Drawing.Point(632, 156);
            this.showGender.Name = "showGender";
            this.showGender.Size = new System.Drawing.Size(0, 25);
            this.showGender.TabIndex = 38;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Goldenrod;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(63, 437);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(162, 42);
            this.btnLogOut.TabIndex = 39;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Goldenrod;
            this.label8.Location = new System.Drawing.Point(71, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 29);
            this.label8.TabIndex = 40;
            this.label8.Text = "Report";
            // 
            // txtReport
            // 
            this.txtReport.Location = new System.Drawing.Point(92, 249);
            this.txtReport.MaxLength = 2000;
            this.txtReport.Multiline = true;
            this.txtReport.Name = "txtReport";
            this.txtReport.Size = new System.Drawing.Size(459, 155);
            this.txtReport.TabIndex = 41;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.Goldenrod;
            this.submit.FlatAppearance.BorderSize = 0;
            this.submit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.submit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.Color.White;
            this.submit.Location = new System.Drawing.Point(622, 437);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(162, 42);
            this.submit.TabIndex = 42;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(573, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 29);
            this.label2.TabIndex = 43;
            this.label2.Text = "Next Date";
            // 
            // daysOfWeek
            // 
            this.daysOfWeek.FormattingEnabled = true;
            this.daysOfWeek.Location = new System.Drawing.Point(669, 270);
            this.daysOfWeek.Name = "daysOfWeek";
            this.daysOfWeek.Size = new System.Drawing.Size(155, 24);
            this.daysOfWeek.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(573, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "Day";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(573, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 47;
            this.label4.Text = "Hour";
            // 
            // comboHour
            // 
            this.comboHour.FormattingEnabled = true;
            this.comboHour.Location = new System.Drawing.Point(669, 345);
            this.comboHour.Name = "comboHour";
            this.comboHour.Size = new System.Drawing.Size(155, 24);
            this.comboHour.TabIndex = 46;
            // 
            // MainDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(860, 508);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboHour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.daysOfWeek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.txtReport);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.showGender);
            this.Controls.Add(this.showAge);
            this.Controls.Add(this.showName);
            this.Controls.Add(this.headGender);
            this.Controls.Add(this.headAge);
            this.Controls.Add(this.headName);
            this.Controls.Add(this.showPatientInformation);
            this.Controls.Add(this.comboPatientNames);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainDoctorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainDoctorForm";
            this.Load += new System.EventHandler(this.MainDoctorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboPatientNames;
        private System.Windows.Forms.Button showPatientInformation;
        private System.Windows.Forms.Label headGender;
        private System.Windows.Forms.Label headAge;
        private System.Windows.Forms.Label headName;
        private System.Windows.Forms.Label showName;
        private System.Windows.Forms.Label showAge;
        private System.Windows.Forms.Label showGender;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtReport;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox daysOfWeek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboHour;
    }
}