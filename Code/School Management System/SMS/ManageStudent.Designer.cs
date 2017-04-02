namespace SMS
{
    partial class ManageStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStudent));
            this.btnAddStd = new System.Windows.Forms.Button();
            this.btnDelStd = new System.Windows.Forms.Button();
            this.btnUpdateStd = new System.Windows.Forms.Button();
            this.btnBk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.txtDelStd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddStd
            // 
            this.btnAddStd.Location = new System.Drawing.Point(168, 19);
            this.btnAddStd.Name = "btnAddStd";
            this.btnAddStd.Size = new System.Drawing.Size(115, 37);
            this.btnAddStd.TabIndex = 0;
            this.btnAddStd.Text = "Add Student";
            this.btnAddStd.UseVisualStyleBackColor = true;
            this.btnAddStd.Click += new System.EventHandler(this.btnAddStd_Click);
            // 
            // btnDelStd
            // 
            this.btnDelStd.Location = new System.Drawing.Point(44, 77);
            this.btnDelStd.Name = "btnDelStd";
            this.btnDelStd.Size = new System.Drawing.Size(95, 28);
            this.btnDelStd.TabIndex = 4;
            this.btnDelStd.Text = "Delete Student";
            this.btnDelStd.UseVisualStyleBackColor = true;
            this.btnDelStd.Click += new System.EventHandler(this.btnDelStd_Click);
            // 
            // btnUpdateStd
            // 
            this.btnUpdateStd.Location = new System.Drawing.Point(303, 19);
            this.btnUpdateStd.Name = "btnUpdateStd";
            this.btnUpdateStd.Size = new System.Drawing.Size(115, 37);
            this.btnUpdateStd.TabIndex = 1;
            this.btnUpdateStd.Text = "Update Student";
            this.btnUpdateStd.UseVisualStyleBackColor = true;
            this.btnUpdateStd.Click += new System.EventHandler(this.btnUpdateStd_Click);
            // 
            // btnBk
            // 
            this.btnBk.Location = new System.Drawing.Point(12, 12);
            this.btnBk.Name = "btnBk";
            this.btnBk.Size = new System.Drawing.Size(75, 23);
            this.btnBk.TabIndex = 5;
            this.btnBk.Text = "Back";
            this.btnBk.UseVisualStyleBackColor = true;
            this.btnBk.Click += new System.EventHandler(this.btnBk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdateStd);
            this.groupBox1.Controls.Add(this.btnAddStd);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 68);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(12, 115);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(436, 275);
            this.dgv1.TabIndex = 5;
            // 
            // txtDelStd
            // 
            this.txtDelStd.Location = new System.Drawing.Point(8, 51);
            this.txtDelStd.Name = "txtDelStd";
            this.txtDelStd.Size = new System.Drawing.Size(131, 20);
            this.txtDelStd.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter Student ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtDelStd);
            this.groupBox2.Controls.Add(this.btnDelStd);
            this.groupBox2.Location = new System.Drawing.Point(454, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 121);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete Student";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(266, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // ManageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 402);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.btnBk);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageStudent";
            this.Text = "ManageStudent";
            this.Load += new System.EventHandler(this.ManageStudent_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddStd;
        private System.Windows.Forms.Button btnDelStd;
        private System.Windows.Forms.Button btnUpdateStd;
        private System.Windows.Forms.Button btnBk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.TextBox txtDelStd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}