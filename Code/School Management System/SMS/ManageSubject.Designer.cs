namespace SMS
{
    partial class ManageSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageSubject));
            this.btnAddSubj = new System.Windows.Forms.Button();
            this.btnDelSubj = new System.Windows.Forms.Button();
            this.btnUpdateSubj = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btnBk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDelSubj = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddSubj
            // 
            this.btnAddSubj.Location = new System.Drawing.Point(168, 19);
            this.btnAddSubj.Name = "btnAddSubj";
            this.btnAddSubj.Size = new System.Drawing.Size(115, 37);
            this.btnAddSubj.TabIndex = 0;
            this.btnAddSubj.Text = "Add Subject";
            this.btnAddSubj.UseVisualStyleBackColor = true;
            this.btnAddSubj.Click += new System.EventHandler(this.btnAddSubj_Click);
            // 
            // btnDelSubj
            // 
            this.btnDelSubj.Location = new System.Drawing.Point(45, 78);
            this.btnDelSubj.Name = "btnDelSubj";
            this.btnDelSubj.Size = new System.Drawing.Size(95, 28);
            this.btnDelSubj.TabIndex = 3;
            this.btnDelSubj.Text = "Delete Subject";
            this.btnDelSubj.UseVisualStyleBackColor = true;
            this.btnDelSubj.Click += new System.EventHandler(this.btnDelSubj_Click);
            // 
            // btnUpdateSubj
            // 
            this.btnUpdateSubj.Location = new System.Drawing.Point(303, 19);
            this.btnUpdateSubj.Name = "btnUpdateSubj";
            this.btnUpdateSubj.Size = new System.Drawing.Size(115, 37);
            this.btnUpdateSubj.TabIndex = 1;
            this.btnUpdateSubj.Text = "Update Subject";
            this.btnUpdateSubj.UseVisualStyleBackColor = true;
            this.btnUpdateSubj.Click += new System.EventHandler(this.btnUpdateSubj_Click);
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(12, 115);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(436, 275);
            this.dgv1.TabIndex = 11;
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
            this.groupBox1.Controls.Add(this.btnUpdateSubj);
            this.groupBox1.Controls.Add(this.btnAddSubj);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 68);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter Subject ID";
            // 
            // txtDelSubj
            // 
            this.txtDelSubj.Location = new System.Drawing.Point(9, 48);
            this.txtDelSubj.Name = "txtDelSubj";
            this.txtDelSubj.Size = new System.Drawing.Size(131, 20);
            this.txtDelSubj.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtDelSubj);
            this.groupBox2.Controls.Add(this.btnDelSubj);
            this.groupBox2.Location = new System.Drawing.Point(454, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 112);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete Subject";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(268, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // ManageSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 402);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.btnBk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageSubject";
            this.Text = "ManageSubject";
            this.Load += new System.EventHandler(this.ManageSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddSubj;
        private System.Windows.Forms.Button btnDelSubj;
        private System.Windows.Forms.Button btnUpdateSubj;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btnBk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDelSubj;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}