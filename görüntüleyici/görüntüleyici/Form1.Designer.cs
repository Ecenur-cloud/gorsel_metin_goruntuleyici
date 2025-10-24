namespace görüntüleyici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            btnklasorac = new ToolStripButton();
            btndosyaac = new ToolStripButton();
            btnkaydet = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            lbldosyaadi = new ToolStripStatusLabel();
            lbldosyabyt = new ToolStripStatusLabel();
            lblresimboyut = new ToolStripStatusLabel();
            statusStrip2 = new StatusStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            geri = new ToolStripButton();
            dikeyaynala = new ToolStripButton();
            yatayaynala = new ToolStripButton();
            solacevir = new ToolStripButton();
            sagacevir = new ToolStripButton();
            tamekran = new ToolStripButton();
            font = new ToolStripButton();
            yazıtipi = new ToolStripButton();
            arkaplan = new ToolStripButton();
            sonraki = new ToolStripButton();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            splitContainer1 = new SplitContainer();
            listBox1 = new ListBox();
            tabControl1 = new TabControl();
            tabmetin = new TabPage();
            textBox1 = new TextBox();
            tabresim = new TabPage();
            pictureBox1 = new PictureBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            openFileDialog1 = new OpenFileDialog();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            statusStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabmetin.SuspendLayout();
            tabresim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnklasorac, btndosyaac, btnkaydet });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(873, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnklasorac
            // 
            btnklasorac.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnklasorac.Image = (Image)resources.GetObject("btnklasorac.Image");
            btnklasorac.ImageTransparentColor = Color.Magenta;
            btnklasorac.Name = "btnklasorac";
            btnklasorac.Size = new Size(23, 22);
            btnklasorac.Text = "Klasöre göz at";
            btnklasorac.Click += btnklasorac_Click;
            // 
            // btndosyaac
            // 
            btndosyaac.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btndosyaac.Image = (Image)resources.GetObject("btndosyaac.Image");
            btndosyaac.ImageTransparentColor = Color.Magenta;
            btndosyaac.Name = "btndosyaac";
            btndosyaac.Size = new Size(23, 22);
            btndosyaac.Text = "toolStripButton2";
            btndosyaac.ToolTipText = "Dosya aç";
            btndosyaac.Click += btndosyaac_Click;
            // 
            // btnkaydet
            // 
            btnkaydet.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnkaydet.Image = (Image)resources.GetObject("btnkaydet.Image");
            btnkaydet.ImageTransparentColor = Color.Magenta;
            btnkaydet.Name = "btnkaydet";
            btnkaydet.Size = new Size(23, 22);
            btnkaydet.Text = "toolStripButton3";
            btnkaydet.ToolTipText = "Kaydet";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lbldosyaadi, lbldosyabyt, lblresimboyut });
            statusStrip1.Location = new Point(0, 440);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(873, 24);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lbldosyaadi
            // 
            lbldosyaadi.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            lbldosyaadi.Name = "lbldosyaadi";
            lbldosyaadi.Size = new Size(826, 19);
            lbldosyaadi.Spring = true;
            lbldosyaadi.Text = "-";
            // 
            // lbldosyabyt
            // 
            lbldosyabyt.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            lbldosyabyt.Name = "lbldosyabyt";
            lbldosyabyt.Size = new Size(16, 19);
            lbldosyabyt.Text = "-";
            // 
            // lblresimboyut
            // 
            lblresimboyut.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            lblresimboyut.Name = "lblresimboyut";
            lblresimboyut.Size = new Size(16, 19);
            lblresimboyut.Text = "-";
            // 
            // statusStrip2
            // 
            statusStrip2.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripStatusLabel1, geri, dikeyaynala, yatayaynala, solacevir, sagacevir, tamekran, font, yazıtipi, arkaplan, sonraki, toolStripStatusLabel2 });
            statusStrip2.Location = new Point(0, 418);
            statusStrip2.Name = "statusStrip2";
            statusStrip2.Size = new Size(873, 22);
            statusStrip2.TabIndex = 2;
            statusStrip2.Text = "statusStrip2";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(85, 20);
            toolStripButton1.Text = "Listeyi temizle";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(256, 17);
            toolStripStatusLabel1.Spring = true;
            // 
            // geri
            // 
            geri.DisplayStyle = ToolStripItemDisplayStyle.Image;
            geri.Image = (Image)resources.GetObject("geri.Image");
            geri.ImageTransparentColor = Color.Magenta;
            geri.Name = "geri";
            geri.Size = new Size(23, 20);
            geri.Text = "toolStripButton1";
            // 
            // dikeyaynala
            // 
            dikeyaynala.DisplayStyle = ToolStripItemDisplayStyle.Image;
            dikeyaynala.Image = (Image)resources.GetObject("dikeyaynala.Image");
            dikeyaynala.ImageTransparentColor = Color.Magenta;
            dikeyaynala.Name = "dikeyaynala";
            dikeyaynala.Size = new Size(23, 20);
            dikeyaynala.Text = "toolStripButton2";
            dikeyaynala.ToolTipText = "Dikey aynala";
            // 
            // yatayaynala
            // 
            yatayaynala.AccessibleDescription = "";
            yatayaynala.DisplayStyle = ToolStripItemDisplayStyle.Image;
            yatayaynala.Image = (Image)resources.GetObject("yatayaynala.Image");
            yatayaynala.ImageTransparentColor = Color.Magenta;
            yatayaynala.Name = "yatayaynala";
            yatayaynala.Size = new Size(23, 20);
            yatayaynala.Text = "toolStripButton3";
            yatayaynala.ToolTipText = "Yatay aynala";
            // 
            // solacevir
            // 
            solacevir.AccessibleDescription = "";
            solacevir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            solacevir.Image = (Image)resources.GetObject("solacevir.Image");
            solacevir.ImageTransparentColor = Color.Magenta;
            solacevir.Name = "solacevir";
            solacevir.Size = new Size(23, 20);
            solacevir.Text = "toolStripButton4";
            solacevir.ToolTipText = "Sola çevir";
            // 
            // sagacevir
            // 
            sagacevir.AccessibleDescription = "";
            sagacevir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            sagacevir.Image = (Image)resources.GetObject("sagacevir.Image");
            sagacevir.ImageTransparentColor = Color.Magenta;
            sagacevir.Name = "sagacevir";
            sagacevir.Size = new Size(23, 20);
            sagacevir.Text = "toolStripButton5";
            sagacevir.ToolTipText = "Sağa çevir";
            // 
            // tamekran
            // 
            tamekran.Checked = true;
            tamekran.CheckOnClick = true;
            tamekran.CheckState = CheckState.Checked;
            tamekran.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tamekran.Image = (Image)resources.GetObject("tamekran.Image");
            tamekran.ImageTransparentColor = Color.Magenta;
            tamekran.Name = "tamekran";
            tamekran.Size = new Size(23, 20);
            tamekran.Text = "toolStripButton6";
            tamekran.ToolTipText = "Tam ekran";
            // 
            // font
            // 
            font.DisplayStyle = ToolStripItemDisplayStyle.Image;
            font.Image = (Image)resources.GetObject("font.Image");
            font.ImageTransparentColor = Color.Magenta;
            font.Name = "font";
            font.Size = new Size(23, 20);
            font.Text = "toolStripButton7";
            font.ToolTipText = "Font";
            // 
            // yazıtipi
            // 
            yazıtipi.DisplayStyle = ToolStripItemDisplayStyle.Image;
            yazıtipi.Image = (Image)resources.GetObject("yazıtipi.Image");
            yazıtipi.ImageTransparentColor = Color.Magenta;
            yazıtipi.Name = "yazıtipi";
            yazıtipi.Size = new Size(23, 20);
            yazıtipi.Text = "toolStripButton8";
            yazıtipi.ToolTipText = "Yazı tipi";
            // 
            // arkaplan
            // 
            arkaplan.DisplayStyle = ToolStripItemDisplayStyle.Image;
            arkaplan.Image = (Image)resources.GetObject("arkaplan.Image");
            arkaplan.ImageTransparentColor = Color.Magenta;
            arkaplan.Name = "arkaplan";
            arkaplan.Size = new Size(23, 20);
            arkaplan.Text = "toolStripButton9";
            arkaplan.ToolTipText = "Arka plan rengi";
            // 
            // sonraki
            // 
            sonraki.DisplayStyle = ToolStripItemDisplayStyle.Image;
            sonraki.Image = (Image)resources.GetObject("sonraki.Image");
            sonraki.ImageTransparentColor = Color.Magenta;
            sonraki.Name = "sonraki";
            sonraki.Size = new Size(23, 20);
            sonraki.Text = "toolStripButton10";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(256, 17);
            toolStripStatusLabel2.Spring = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 25);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(listBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabControl1);
            splitContainer1.Size = new Size(873, 393);
            splitContainer1.SplitterDistance = 195;
            splitContainer1.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(0, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(195, 393);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabmetin);
            tabControl1.Controls.Add(tabresim);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(674, 393);
            tabControl1.TabIndex = 0;
            // 
            // tabmetin
            // 
            tabmetin.Controls.Add(textBox1);
            tabmetin.Location = new Point(4, 24);
            tabmetin.Name = "tabmetin";
            tabmetin.Padding = new Padding(3);
            tabmetin.Size = new Size(666, 365);
            tabmetin.TabIndex = 0;
            tabmetin.Text = "Metin";
            tabmetin.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(660, 359);
            textBox1.TabIndex = 0;
            // 
            // tabresim
            // 
            tabresim.AutoScroll = true;
            tabresim.Controls.Add(pictureBox1);
            tabresim.Location = new Point(4, 24);
            tabresim.Name = "tabresim";
            tabresim.Padding = new Padding(3);
            tabresim.Size = new Size(666, 365);
            tabresim.TabIndex = 1;
            tabresim.Text = "Resim";
            tabresim.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(660, 359);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.SelectedPath = "C:\\Users\\ECENUR\\Downloads";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 464);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip2);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "Form1";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            statusStrip2.ResumeLayout(false);
            statusStrip2.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabmetin.ResumeLayout(false);
            tabmetin.PerformLayout();
            tabresim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnklasorac;
        private ToolStripButton btndosyaac;
        private ToolStripButton btnkaydet;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lbldosyaadi;
        private ToolStripStatusLabel lbldosyabyt;
        private ToolStripStatusLabel lblresimboyut;
        private StatusStrip statusStrip2;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripButton geri;
        private ToolStripButton dikeyaynala;
        private ToolStripButton yatayaynala;
        private ToolStripButton solacevir;
        private ToolStripButton sagacevir;
        private ToolStripButton tamekran;
        private ToolStripButton font;
        private ToolStripButton yazıtipi;
        private ToolStripButton arkaplan;
        private ToolStripButton sonraki;
        private SplitContainer splitContainer1;
        private ListBox listBox1;
        private TabControl tabControl1;
        private TabPage tabmetin;
        private TabPage tabresim;
        private PictureBox pictureBox1;
        private ToolStripButton toolStripButton1;
        private TextBox textBox1;
        private FolderBrowserDialog folderBrowserDialog1;
        private OpenFileDialog openFileDialog1;
    }
}
