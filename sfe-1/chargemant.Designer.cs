namespace WindowsFormsApplication1
{
    partial class chargemant
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chargemant));
            this.Label1 = new System.Windows.Forms.Label();
            this.BunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(250, 103);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(308, 33);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "s\'il vous plaît ,patiantez ...";
            // 
            // BunifuCustomLabel1
            // 
            this.BunifuCustomLabel1.AutoSize = true;
            this.BunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.BunifuCustomLabel1.Location = new System.Drawing.Point(3, 10);
            this.BunifuCustomLabel1.Name = "BunifuCustomLabel1";
            this.BunifuCustomLabel1.Size = new System.Drawing.Size(508, 78);
            this.BunifuCustomLabel1.TabIndex = 4;
            this.BunifuCustomLabel1.Text = "Chargemant ...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(324, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(566, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // BunifuCircleProgressbar1
            // 
            this.BunifuCircleProgressbar1.animated = true;
            this.BunifuCircleProgressbar1.animationIterval = 30;
            this.BunifuCircleProgressbar1.animationSpeed = 45;
            this.BunifuCircleProgressbar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(52)))), ((int)(((byte)(43)))));
            this.BunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BunifuCircleProgressbar1.BackgroundImage")));
            this.BunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.BunifuCircleProgressbar1.ForeColor = System.Drawing.Color.SeaGreen;
            this.BunifuCircleProgressbar1.LabelVisible = false;
            this.BunifuCircleProgressbar1.LineProgressThickness = 8;
            this.BunifuCircleProgressbar1.LineThickness = 5;
            this.BunifuCircleProgressbar1.Location = new System.Drawing.Point(554, 428);
            this.BunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.BunifuCircleProgressbar1.MaxValue = 100;
            this.BunifuCircleProgressbar1.Name = "BunifuCircleProgressbar1";
            this.BunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.GhostWhite;
            this.BunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.Red;
            this.BunifuCircleProgressbar1.Size = new System.Drawing.Size(109, 109);
            this.BunifuCircleProgressbar1.TabIndex = 7;
            this.BunifuCircleProgressbar1.Value = 60;
            // 
            // chargemant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(52)))), ((int)(((byte)(43)))));
            this.Controls.Add(this.BunifuCircleProgressbar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.BunifuCustomLabel1);
            this.Name = "chargemant";
            this.Size = new System.Drawing.Size(1207, 705);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal Bunifu.Framework.UI.BunifuCustomLabel BunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal Bunifu.Framework.UI.BunifuCircleProgressbar BunifuCircleProgressbar1;
    }
}
