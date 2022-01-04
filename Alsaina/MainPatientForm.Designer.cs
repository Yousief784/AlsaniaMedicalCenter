namespace Alsaina
{
    partial class MainPatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPatientForm));
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.lblYourAppointment = new System.Windows.Forms.Label();
            this.lblAppointmentHour = new System.Windows.Forms.Label();
            this.lblAppointmentDay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(60, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 31);
            this.label1.TabIndex = 26;
            this.label1.Text = "Welcome";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(248, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 29);
            this.lblName.TabIndex = 27;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Goldenrod;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(432, 197);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(162, 42);
            this.btnPrint.TabIndex = 40;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            this.btnLogOut.Location = new System.Drawing.Point(64, 197);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(162, 42);
            this.btnLogOut.TabIndex = 41;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.White;
            this.lblText.Location = new System.Drawing.Point(316, 123);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(331, 29);
            this.lblText.TabIndex = 42;
            this.lblText.Text = "You Can\'t Print Report Now";
            this.lblText.Visible = false;
            // 
            // lblYourAppointment
            // 
            this.lblYourAppointment.AutoSize = true;
            this.lblYourAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblYourAppointment.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblYourAppointment.Location = new System.Drawing.Point(71, 101);
            this.lblYourAppointment.Name = "lblYourAppointment";
            this.lblYourAppointment.Size = new System.Drawing.Size(184, 25);
            this.lblYourAppointment.TabIndex = 44;
            this.lblYourAppointment.Text = "Your Appointment";
            this.lblYourAppointment.Visible = false;
            // 
            // lblAppointmentHour
            // 
            this.lblAppointmentHour.AutoSize = true;
            this.lblAppointmentHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentHour.ForeColor = System.Drawing.Color.White;
            this.lblAppointmentHour.Location = new System.Drawing.Point(222, 138);
            this.lblAppointmentHour.Name = "lblAppointmentHour";
            this.lblAppointmentHour.Size = new System.Drawing.Size(0, 29);
            this.lblAppointmentHour.TabIndex = 45;
            // 
            // lblAppointmentDay
            // 
            this.lblAppointmentDay.AutoSize = true;
            this.lblAppointmentDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentDay.ForeColor = System.Drawing.Color.White;
            this.lblAppointmentDay.Location = new System.Drawing.Point(62, 138);
            this.lblAppointmentDay.Name = "lblAppointmentDay";
            this.lblAppointmentDay.Size = new System.Drawing.Size(0, 29);
            this.lblAppointmentDay.TabIndex = 46;
            // 
            // MainPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(686, 293);
            this.Controls.Add(this.lblAppointmentDay);
            this.Controls.Add(this.lblAppointmentHour);
            this.Controls.Add(this.lblYourAppointment);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPatientForm";
            this.Load += new System.EventHandler(this.MainPatientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblYourAppointment;
        private System.Windows.Forms.Label lblAppointmentHour;
        private System.Windows.Forms.Label lblAppointmentDay;
    }
}