namespace WindowsFormsApplication1
{
    partial class bonne
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bonne));
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.BunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.BunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuThinButton25 = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.BunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(31, 14);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(417, 44);
            this.bunifuCustomLabel2.TabIndex = 134;
            this.bunifuCustomLabel2.Text = "Bonne de commande";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(752, 120);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(208, 20);
            this.TextBox1.TabIndex = 131;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // BunifuCustomDataGrid1
            // 
            this.BunifuCustomDataGrid1.AllowUserToAddRows = false;
            this.BunifuCustomDataGrid1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.BunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BunifuCustomDataGrid1.DoubleBuffered = true;
            this.BunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.BunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.Red;
            this.BunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.BunifuCustomDataGrid1.Location = new System.Drawing.Point(39, 79);
            this.BunifuCustomDataGrid1.Name = "BunifuCustomDataGrid1";
            this.BunifuCustomDataGrid1.ReadOnly = true;
            this.BunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BunifuCustomDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BunifuCustomDataGrid1.Size = new System.Drawing.Size(699, 614);
            this.BunifuCustomDataGrid1.TabIndex = 130;
            // 
            // BunifuImageButton1
            // 
            this.BunifuImageButton1.BackColor = System.Drawing.SystemColors.Control;
            this.BunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("BunifuImageButton1.Image")));
            this.BunifuImageButton1.ImageActive = null;
            this.BunifuImageButton1.Location = new System.Drawing.Point(966, 120);
            this.BunifuImageButton1.Name = "BunifuImageButton1";
            this.BunifuImageButton1.Size = new System.Drawing.Size(31, 21);
            this.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BunifuImageButton1.TabIndex = 135;
            this.BunifuImageButton1.TabStop = false;
            this.BunifuImageButton1.Zoom = 10;
            // 
            // bunifuThinButton25
            // 
            this.bunifuThinButton25.ActiveBorderThickness = 1;
            this.bunifuThinButton25.ActiveCornerRadius = 20;
            this.bunifuThinButton25.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(52)))), ((int)(((byte)(43)))));
            this.bunifuThinButton25.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton25.ActiveLineColor = System.Drawing.Color.SaddleBrown;
            this.bunifuThinButton25.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton25.BackgroundImage")));
            this.bunifuThinButton25.ButtonText = "Actualise";
            this.bunifuThinButton25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton25.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton25.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton25.IdleBorderThickness = 1;
            this.bunifuThinButton25.IdleCornerRadius = 20;
            this.bunifuThinButton25.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton25.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(52)))), ((int)(((byte)(43)))));
            this.bunifuThinButton25.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(52)))), ((int)(((byte)(43)))));
            this.bunifuThinButton25.Location = new System.Drawing.Point(817, 176);
            this.bunifuThinButton25.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton25.Name = "bunifuThinButton25";
            this.bunifuThinButton25.Size = new System.Drawing.Size(143, 41);
            this.bunifuThinButton25.TabIndex = 133;
            this.bunifuThinButton25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bonne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BunifuImageButton1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuThinButton25);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.BunifuCustomDataGrid1);
            this.Name = "bonne";
            this.Size = new System.Drawing.Size(1002, 701);
            this.Load += new System.EventHandler(this.bonne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Bunifu.Framework.UI.BunifuImageButton BunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        internal Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton25;
        internal System.Windows.Forms.TextBox TextBox1;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid BunifuCustomDataGrid1;
    }
}
