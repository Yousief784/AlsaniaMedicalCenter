namespace Alsaina
{
    partial class Add_Major
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Major));
            this.txtMajorName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddMajor = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMajorName
            // 
            this.txtMajorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMajorName.Location = new System.Drawing.Point(206, 40);
            this.txtMajorName.Multiline = true;
            this.txtMajorName.Name = "txtMajorName";
            this.txtMajorName.Size = new System.Drawing.Size(191, 27);
            this.txtMajorName.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(100, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Major";
            // 
            // btnAddMajor
            // 
            this.btnAddMajor.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAddMajor.FlatAppearance.BorderSize = 0;
            this.btnAddMajor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.btnAddMajor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnAddMajor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMajor.ForeColor = System.Drawing.Color.White;
            this.btnAddMajor.Location = new System.Drawing.Point(299, 124);
            this.btnAddMajor.Name = "btnAddMajor";
            this.btnAddMajor.Size = new System.Drawing.Size(189, 53);
            this.btnAddMajor.TabIndex = 17;
            this.btnAddMajor.Text = "Add Major";
            this.btnAddMajor.UseVisualStyleBackColor = false;
            this.btnAddMajor.Click += new System.EventHandler(this.btnAddMajor_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Goldenrod;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(29, 129);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(84, 42);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Add_Major
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(548, 215);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddMajor);
            this.Controls.Add(this.txtMajorName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Major";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Major";
            this.Load += new System.EventHandler(this.Add_Major_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMajorName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddMajor;
        private System.Windows.Forms.Button btnBack;
    }
}