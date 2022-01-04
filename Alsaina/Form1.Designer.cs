namespace Alsaina
{
    partial class toLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(toLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLoginReception = new System.Windows.Forms.Button();
            this.btnLoginDoctor = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLoginPatient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnLoginReception
            // 
            this.btnLoginReception.BackColor = System.Drawing.Color.Goldenrod;
            this.btnLoginReception.FlatAppearance.BorderSize = 0;
            this.btnLoginReception.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.btnLoginReception.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnLoginReception.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginReception.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginReception.ForeColor = System.Drawing.Color.White;
            this.btnLoginReception.Location = new System.Drawing.Point(343, 71);
            this.btnLoginReception.Name = "btnLoginReception";
            this.btnLoginReception.Size = new System.Drawing.Size(311, 60);
            this.btnLoginReception.TabIndex = 1;
            this.btnLoginReception.Text = "Login as A Resptionist";
            this.btnLoginReception.UseVisualStyleBackColor = false;
            this.btnLoginReception.Click += new System.EventHandler(this.btnLoginReception_Click);
            // 
            // btnLoginDoctor
            // 
            this.btnLoginDoctor.BackColor = System.Drawing.Color.Goldenrod;
            this.btnLoginDoctor.FlatAppearance.BorderSize = 0;
            this.btnLoginDoctor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.btnLoginDoctor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnLoginDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginDoctor.ForeColor = System.Drawing.Color.White;
            this.btnLoginDoctor.Location = new System.Drawing.Point(343, 154);
            this.btnLoginDoctor.Name = "btnLoginDoctor";
            this.btnLoginDoctor.Size = new System.Drawing.Size(311, 60);
            this.btnLoginDoctor.TabIndex = 2;
            this.btnLoginDoctor.Text = "Login as A Doctor";
            this.btnLoginDoctor.UseVisualStyleBackColor = false;
            this.btnLoginDoctor.Click += new System.EventHandler(this.btnLoginDoctor_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Goldenrod;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(58, 325);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 42);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLoginPatient
            // 
            this.btnLoginPatient.BackColor = System.Drawing.Color.Goldenrod;
            this.btnLoginPatient.FlatAppearance.BorderSize = 0;
            this.btnLoginPatient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.btnLoginPatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnLoginPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginPatient.ForeColor = System.Drawing.Color.White;
            this.btnLoginPatient.Location = new System.Drawing.Point(343, 240);
            this.btnLoginPatient.Name = "btnLoginPatient";
            this.btnLoginPatient.Size = new System.Drawing.Size(311, 60);
            this.btnLoginPatient.TabIndex = 15;
            this.btnLoginPatient.Text = "Login as A Patient";
            this.btnLoginPatient.UseVisualStyleBackColor = false;
            this.btnLoginPatient.Click += new System.EventHandler(this.btnLoginPatient_Click);
            // 
            // toLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(686, 403);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLoginDoctor);
            this.Controls.Add(this.btnLoginPatient);
            this.Controls.Add(this.btnLoginReception);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "toLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALSANIA MEDICAL CENTER";
            this.Load += new System.EventHandler(this.toLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLoginReception;
        private System.Windows.Forms.Button btnLoginDoctor;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLoginPatient;
    }
}

