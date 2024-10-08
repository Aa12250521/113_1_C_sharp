namespace toturial2_5
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
            pitfront = new PictureBox();
            pitback = new PictureBox();
            btnshowfrom = new Button();
            btnshowback = new Button();
            btnexit = new Button();
            ((System.ComponentModel.ISupportInitialize)pitfront).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pitback).BeginInit();
            SuspendLayout();
            // 
            // pitfront
            // 
            pitfront.Image = Properties.Resources.Ace_Spades;
            pitfront.Location = new Point(501, 41);
            pitfront.Name = "pitfront";
            pitfront.Size = new Size(178, 252);
            pitfront.SizeMode = PictureBoxSizeMode.Zoom;
            pitfront.TabIndex = 0;
            pitfront.TabStop = false;
            pitfront.Visible = false;
            // 
            // pitback
            // 
            pitback.Image = Properties.Resources.Backface_Blue;
            pitback.Location = new Point(92, 41);
            pitback.Name = "pitback";
            pitback.Size = new Size(178, 252);
            pitback.SizeMode = PictureBoxSizeMode.Zoom;
            pitback.TabIndex = 1;
            pitback.TabStop = false;
            pitback.Visible = false;
            pitback.Click += pitback_Click;
            // 
            // btnshowfrom
            // 
            btnshowfrom.Location = new Point(498, 327);
            btnshowfrom.Name = "btnshowfrom";
            btnshowfrom.Size = new Size(181, 79);
            btnshowfrom.TabIndex = 2;
            btnshowfrom.Text = "正面";
            btnshowfrom.UseVisualStyleBackColor = true;
            // 
            // btnshowback
            // 
            btnshowback.Location = new Point(92, 327);
            btnshowback.Name = "btnshowback";
            btnshowback.Size = new Size(181, 79);
            btnshowback.TabIndex = 3;
            btnshowback.Text = "背面";
            btnshowback.UseVisualStyleBackColor = true;
            btnshowback.Click += btnshowback_Click;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(293, 470);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(180, 87);
            btnexit.TabIndex = 4;
            btnexit.Text = "離開";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 597);
            Controls.Add(btnexit);
            Controls.Add(btnshowback);
            Controls.Add(btnshowfrom);
            Controls.Add(pitback);
            Controls.Add(pitfront);
            Font = new Font("Microsoft JhengHei UI", 9F);
            Name = "Form1";
            Text = "翻牌";
            ((System.ComponentModel.ISupportInitialize)pitfront).EndInit();
            ((System.ComponentModel.ISupportInitialize)pitback).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pitfront;
        private PictureBox pitback;
        private Button btnshowfrom;
        private Button btnshowback;
        private Button btnexit;
    }
}
