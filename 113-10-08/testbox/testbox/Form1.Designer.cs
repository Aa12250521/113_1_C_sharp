namespace testbox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btncomfirm = new Button();
            txtfirstname = new TextBox();
            txtlastname = new TextBox();
            LBL = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 24F);
            label1.Location = new Point(126, 86);
            label1.Name = "label1";
            label1.Size = new Size(212, 41);
            label1.TabIndex = 0;
            label1.Text = "FRIST NAME:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 24F);
            label2.Location = new Point(126, 181);
            label2.Name = "label2";
            label2.Size = new Size(179, 41);
            label2.TabIndex = 1;
            label2.Text = "Last name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 24F);
            label3.Location = new Point(126, 273);
            label3.Name = "label3";
            label3.Size = new Size(164, 41);
            label3.TabIndex = 2;
            label3.Text = "full name:";
            // 
            // btncomfirm
            // 
            btncomfirm.Location = new Point(336, 338);
            btncomfirm.Name = "btncomfirm";
            btncomfirm.Size = new Size(160, 88);
            btncomfirm.TabIndex = 3;
            btncomfirm.Text = "confirm";
            btncomfirm.UseVisualStyleBackColor = true;
            btncomfirm.Click += btncomfirm_Click;
            // 
            // txtfirstname
            // 
            txtfirstname.Font = new Font("Microsoft JhengHei UI", 24F);
            txtfirstname.Location = new Point(336, 83);
            txtfirstname.Name = "txtfirstname";
            txtfirstname.Size = new Size(339, 48);
            txtfirstname.TabIndex = 4;
            txtfirstname.TextChanged += txtfirstname_TextChanged;
            // 
            // txtlastname
            // 
            txtlastname.Font = new Font("Microsoft JhengHei UI", 24F);
            txtlastname.Location = new Point(336, 181);
            txtlastname.Name = "txtlastname";
            txtlastname.Size = new Size(339, 48);
            txtlastname.TabIndex = 5;
            // 
            // LBL
            // 
            LBL.AutoSize = true;
            LBL.Font = new Font("Microsoft JhengHei UI", 24F);
            LBL.Location = new Point(336, 273);
            LBL.Name = "LBL";
            LBL.Size = new Size(109, 41);
            LBL.TabIndex = 6;
            LBL.Text = "label4";
            LBL.Click += LBL_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LBL);
            Controls.Add(txtlastname);
            Controls.Add(txtfirstname);
            Controls.Add(btncomfirm);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btncomfirm;
        private TextBox txtfirstname;
        private TextBox txtlastname;
        private Label LBL;
    }
}
