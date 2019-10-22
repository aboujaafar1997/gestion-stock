namespace WindowsFormsApplication1
{
    partial class principale
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principale));
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuProgressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.PictureBox10 = new System.Windows.Forms.PictureBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox4 = new System.Windows.Forms.PictureBox();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.chargemant1 = new WindowsFormsApplication1.chargemant();
            this.top_bare1 = new WindowsFormsApplication1.top_bare();
            this.left_brare1 = new WindowsFormsApplication1.left_brare();
            this.client1 = new WindowsFormsApplication1.client();
            this.commande1 = new WindowsFormsApplication1.commande();
            this.produit1 = new WindowsFormsApplication1.produit();
            this.fournisseur1 = new WindowsFormsApplication1.fournisseur();
            this.facture1 = new WindowsFormsApplication1.facture();
            this.bonne1 = new WindowsFormsApplication1.bonne();
            this.commandefournisseur1 = new WindowsFormsApplication1.commandefournisseur();
            this.user1 = new WindowsFormsApplication1.user();
            this.parametre1 = new WindowsFormsApplication1.Parametre();
            this.historique1 = new WindowsFormsApplication1.historique();
            this.statistique1 = new WindowsFormsApplication1.Statistique();
            this.catalogue1 = new WindowsFormsApplication1.catalogue();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.bunifuTransition1.SetDecoration(this.Label3, BunifuAnimatorNS.DecorationType.None);
            this.Label3.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Lime;
            this.Label3.Location = new System.Drawing.Point(732, 17);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(72, 36);
            this.Label3.TabIndex = 28;
            this.Label3.Text = "user";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.bunifuTransition1.SetDecoration(this.Label2, BunifuAnimatorNS.DecorationType.None);
            this.Label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(188, 2);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(424, 36);
            this.Label2.TabIndex = 26;
            this.Label2.Text = "Systeme Dari aménagement";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(1102, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 39;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.client1);
            this.panel1.Controls.Add(this.commande1);
            this.panel1.Controls.Add(this.produit1);
            this.panel1.Controls.Add(this.fournisseur1);
            this.panel1.Controls.Add(this.facture1);
            this.panel1.Controls.Add(this.bonne1);
            this.panel1.Controls.Add(this.commandefournisseur1);
            this.panel1.Controls.Add(this.user1);
            this.panel1.Controls.Add(this.parametre1);
            this.panel1.Controls.Add(this.historique1);
            this.panel1.Controls.Add(this.statistique1);
            this.panel1.Controls.Add(this.catalogue1);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel1.Location = new System.Drawing.Point(129, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 786);
            this.panel1.TabIndex = 33;
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(52)))), ((int)(((byte)(43)))));
            this.bunifuProgressBar1.BorderRadius = 20;
            this.bunifuTransition1.SetDecoration(this.bunifuProgressBar1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuProgressBar1.Location = new System.Drawing.Point(399, 590);
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressColor = System.Drawing.Color.White;
            this.bunifuProgressBar1.Size = new System.Drawing.Size(410, 10);
            this.bunifuProgressBar1.TabIndex = 41;
            this.bunifuProgressBar1.Value = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 60;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            this.bunifuTransition1.Interval = 50;
            this.bunifuTransition1.MaxAnimationTime = 500;
            this.bunifuTransition1.TimeStep = 0.01F;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(752, 1);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(25, 19);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 42;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1060, 1);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(47, 40);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 38;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 50;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // PictureBox10
            // 
            this.PictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTransition1.SetDecoration(this.PictureBox10, BunifuAnimatorNS.DecorationType.None);
            this.PictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox10.Image")));
            this.PictureBox10.Location = new System.Drawing.Point(1175, 5);
            this.PictureBox10.Name = "PictureBox10";
            this.PictureBox10.Size = new System.Drawing.Size(32, 34);
            this.PictureBox10.TabIndex = 35;
            this.PictureBox10.TabStop = false;
            this.PictureBox10.Click += new System.EventHandler(this.PictureBox10_Click);
            // 
            // PictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.PictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(1018, 5);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(36, 34);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 30;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(978, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // PictureBox4
            // 
            this.bunifuTransition1.SetDecoration(this.PictureBox4, BunifuAnimatorNS.DecorationType.None);
            this.PictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox4.Image")));
            this.PictureBox4.Location = new System.Drawing.Point(1213, 5);
            this.PictureBox4.Name = "PictureBox4";
            this.PictureBox4.Size = new System.Drawing.Size(32, 32);
            this.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox4.TabIndex = 27;
            this.PictureBox4.TabStop = false;
            this.PictureBox4.Click += new System.EventHandler(this.PictureBox4_Click);
            // 
            // PictureBox3
            // 
            this.bunifuTransition1.SetDecoration(this.PictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox3.Image")));
            this.PictureBox3.Location = new System.Drawing.Point(1252, 5);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(32, 32);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox3.TabIndex = 8;
            this.PictureBox3.TabStop = false;
            this.PictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // chargemant1
            // 
            this.chargemant1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(52)))), ((int)(((byte)(43)))));
            this.bunifuTransition1.SetDecoration(this.chargemant1, BunifuAnimatorNS.DecorationType.None);
            this.chargemant1.Location = new System.Drawing.Point(0, -5);
            this.chargemant1.Name = "chargemant1";
            this.chargemant1.Size = new System.Drawing.Size(1331, 854);
            this.chargemant1.TabIndex = 45;
            // 
            // top_bare1
            // 
            this.top_bare1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bunifuTransition1.SetDecoration(this.top_bare1, BunifuAnimatorNS.DecorationType.None);
            this.top_bare1.ForeColor = System.Drawing.Color.White;
            this.top_bare1.Location = new System.Drawing.Point(175, -1);
            this.top_bare1.Name = "top_bare1";
            this.top_bare1.Size = new System.Drawing.Size(1130, 834);
            this.top_bare1.TabIndex = 44;
            // 
            // left_brare1
            // 
            this.left_brare1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(52)))), ((int)(((byte)(43)))));
            this.bunifuTransition1.SetDecoration(this.left_brare1, BunifuAnimatorNS.DecorationType.None);
            this.left_brare1.Location = new System.Drawing.Point(0, -5);
            this.left_brare1.Name = "left_brare1";
            this.left_brare1.Size = new System.Drawing.Size(175, 839);
            this.left_brare1.TabIndex = 34;
            // 
            // client1
            // 
            this.bunifuTransition1.SetDecoration(this.client1, BunifuAnimatorNS.DecorationType.None);
            this.client1.Location = new System.Drawing.Point(63, 12);
            this.client1.Name = "client1";
            this.client1.Size = new System.Drawing.Size(1114, 836);
            this.client1.TabIndex = 42;
            // 
            // commande1
            // 
            this.commande1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuTransition1.SetDecoration(this.commande1, BunifuAnimatorNS.DecorationType.None);
            this.commande1.Location = new System.Drawing.Point(67, 28);
            this.commande1.Name = "commande1";
            this.commande1.Size = new System.Drawing.Size(1212, 836);
            this.commande1.TabIndex = 41;
            // 
            // produit1
            // 
            this.bunifuTransition1.SetDecoration(this.produit1, BunifuAnimatorNS.DecorationType.None);
            this.produit1.Location = new System.Drawing.Point(67, 26);
            this.produit1.Name = "produit1";
            this.produit1.Size = new System.Drawing.Size(1135, 773);
            this.produit1.TabIndex = 40;
            // 
            // fournisseur1
            // 
            this.bunifuTransition1.SetDecoration(this.fournisseur1, BunifuAnimatorNS.DecorationType.None);
            this.fournisseur1.Location = new System.Drawing.Point(67, 26);
            this.fournisseur1.Name = "fournisseur1";
            this.fournisseur1.Size = new System.Drawing.Size(1172, 725);
            this.fournisseur1.TabIndex = 39;
            // 
            // facture1
            // 
            this.bunifuTransition1.SetDecoration(this.facture1, BunifuAnimatorNS.DecorationType.None);
            this.facture1.Location = new System.Drawing.Point(67, 26);
            this.facture1.Name = "facture1";
            this.facture1.Size = new System.Drawing.Size(1195, 760);
            this.facture1.TabIndex = 38;
            // 
            // bonne1
            // 
            this.bunifuTransition1.SetDecoration(this.bonne1, BunifuAnimatorNS.DecorationType.None);
            this.bonne1.Location = new System.Drawing.Point(55, 6);
            this.bonne1.Name = "bonne1";
            this.bonne1.Size = new System.Drawing.Size(1198, 903);
            this.bonne1.TabIndex = 37;
            // 
            // commandefournisseur1
            // 
            this.bunifuTransition1.SetDecoration(this.commandefournisseur1, BunifuAnimatorNS.DecorationType.None);
            this.commandefournisseur1.Location = new System.Drawing.Point(56, 16);
            this.commandefournisseur1.Name = "commandefournisseur1";
            this.commandefournisseur1.Size = new System.Drawing.Size(1182, 826);
            this.commandefournisseur1.TabIndex = 36;
            // 
            // user1
            // 
            this.bunifuTransition1.SetDecoration(this.user1, BunifuAnimatorNS.DecorationType.None);
            this.user1.Location = new System.Drawing.Point(67, 16);
            this.user1.Name = "user1";
            this.user1.Size = new System.Drawing.Size(1171, 783);
            this.user1.TabIndex = 35;
            // 
            // parametre1
            // 
            this.bunifuTransition1.SetDecoration(this.parametre1, BunifuAnimatorNS.DecorationType.None);
            this.parametre1.Location = new System.Drawing.Point(35, 5);
            this.parametre1.Name = "parametre1";
            this.parametre1.Size = new System.Drawing.Size(1167, 726);
            this.parametre1.TabIndex = 34;
            // 
            // historique1
            // 
            this.bunifuTransition1.SetDecoration(this.historique1, BunifuAnimatorNS.DecorationType.None);
            this.historique1.Location = new System.Drawing.Point(55, 0);
            this.historique1.Name = "historique1";
            this.historique1.Size = new System.Drawing.Size(1349, 864);
            this.historique1.TabIndex = 33;
            // 
            // statistique1
            // 
            this.statistique1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuTransition1.SetDecoration(this.statistique1, BunifuAnimatorNS.DecorationType.None);
            this.statistique1.Location = new System.Drawing.Point(55, 3);
            this.statistique1.Name = "statistique1";
            this.statistique1.Size = new System.Drawing.Size(1183, 839);
            this.statistique1.TabIndex = 32;
            // 
            // catalogue1
            // 
            this.catalogue1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuTransition1.SetDecoration(this.catalogue1, BunifuAnimatorNS.DecorationType.None);
            this.catalogue1.Location = new System.Drawing.Point(55, 5);
            this.catalogue1.Name = "catalogue1";
            this.catalogue1.Size = new System.Drawing.Size(1147, 965);
            this.catalogue1.TabIndex = 31;
            // 
            // principale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 818);
            this.ControlBox = false;
            this.Controls.Add(this.chargemant1);
            this.Controls.Add(this.top_bare1);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuProgressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.PictureBox10);
            this.Controls.Add(this.left_brare1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.PictureBox4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.PictureBox3);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "principale";
            this.ShowIcon = false;
            this.Text = "principale";
            this.Load += new System.EventHandler(this.principale_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.PictureBox PictureBox3;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.PictureBox PictureBox4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.PictureBox pictureBox2;
        private left_brare left_brare1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        internal System.Windows.Forms.PictureBox PictureBox10;
        public System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        public System.Windows.Forms.Panel panel1;
        public commande commande1;
        public produit produit1;
        public fournisseur fournisseur1;
        public facture facture1;
        public bonne bonne1;
        public commandefournisseur commandefournisseur1;
        public user user1;
        public Parametre parametre1;
        public historique historique1;
        public Statistique statistique1;
        public catalogue catalogue1;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
        public System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public client client1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private chargemant chargemant1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        public top_bare top_bare1;
    }
}