namespace OzIMDB
{
    partial class Form1
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
            this.btnYeniFilm = new System.Windows.Forms.Button();
            this.gBFilmDetay = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gboPuan = new System.Windows.Forms.GroupBox();
            this.rbPuan = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.lblResim = new System.Windows.Forms.Label();
            this.txtFilmAd = new System.Windows.Forms.TextBox();
            this.pboFoto = new System.Windows.Forms.PictureBox();
            this.lblFilmAd = new System.Windows.Forms.Label();
            this.lstFilm = new System.Windows.Forms.ListBox();
            this.gBFilmDetay.SuspendLayout();
            this.gboPuan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYeniFilm
            // 
            this.btnYeniFilm.Location = new System.Drawing.Point(69, 41);
            this.btnYeniFilm.Name = "btnYeniFilm";
            this.btnYeniFilm.Size = new System.Drawing.Size(200, 21);
            this.btnYeniFilm.TabIndex = 0;
            this.btnYeniFilm.Text = "Yeni Film Ekle";
            this.btnYeniFilm.UseVisualStyleBackColor = true;
            this.btnYeniFilm.Click += new System.EventHandler(this.btnYeniFilm_Click);
            // 
            // gBFilmDetay
            // 
            this.gBFilmDetay.Controls.Add(this.txtId);
            this.gBFilmDetay.Controls.Add(this.label1);
            this.gBFilmDetay.Controls.Add(this.btnYeniFilm);
            this.gBFilmDetay.Controls.Add(this.gboPuan);
            this.gBFilmDetay.Controls.Add(this.lblResim);
            this.gBFilmDetay.Controls.Add(this.txtFilmAd);
            this.gBFilmDetay.Controls.Add(this.pboFoto);
            this.gBFilmDetay.Controls.Add(this.lblFilmAd);
            this.gBFilmDetay.Location = new System.Drawing.Point(12, 12);
            this.gBFilmDetay.Name = "gBFilmDetay";
            this.gBFilmDetay.Size = new System.Drawing.Size(275, 316);
            this.gBFilmDetay.TabIndex = 1;
            this.gBFilmDetay.TabStop = false;
            this.gBFilmDetay.Text = "Film Detayları";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(9, 42);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(54, 20);
            this.txtId.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Film No";
            // 
            // gboPuan
            // 
            this.gboPuan.BackColor = System.Drawing.Color.Coral;
            this.gboPuan.Controls.Add(this.rbPuan);
            this.gboPuan.Controls.Add(this.rb5);
            this.gboPuan.Controls.Add(this.rb4);
            this.gboPuan.Controls.Add(this.rb3);
            this.gboPuan.Controls.Add(this.rb2);
            this.gboPuan.Controls.Add(this.rb1);
            this.gboPuan.Location = new System.Drawing.Point(0, 116);
            this.gboPuan.Name = "gboPuan";
            this.gboPuan.Size = new System.Drawing.Size(108, 159);
            this.gboPuan.TabIndex = 10;
            this.gboPuan.TabStop = false;
            this.gboPuan.Text = "Puan";
            // 
            // rbPuan
            // 
            this.rbPuan.AutoSize = true;
            this.rbPuan.Location = new System.Drawing.Point(9, 19);
            this.rbPuan.Name = "rbPuan";
            this.rbPuan.Size = new System.Drawing.Size(80, 17);
            this.rbPuan.TabIndex = 14;
            this.rbPuan.TabStop = true;
            this.rbPuan.Text = "PUAN YOK";
            this.rbPuan.UseVisualStyleBackColor = true;
            this.rbPuan.CheckedChanged += new System.EventHandler(this.rbPuan_CheckedChanged);
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Location = new System.Drawing.Point(9, 134);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(66, 17);
            this.rb5.TabIndex = 13;
            this.rb5.TabStop = true;
            this.rb5.Tag = "5";
            this.rb5.Text = "5-Çok İyi";
            this.rb5.UseVisualStyleBackColor = true;
            this.rb5.CheckedChanged += new System.EventHandler(this.rbPuan_CheckedChanged);
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(9, 111);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(44, 17);
            this.rb4.TabIndex = 12;
            this.rb4.TabStop = true;
            this.rb4.Tag = "4";
            this.rb4.Text = "4-İyi";
            this.rb4.UseVisualStyleBackColor = true;
            this.rb4.CheckedChanged += new System.EventHandler(this.rbPuan_CheckedChanged);
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(9, 88);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(54, 17);
            this.rb3.TabIndex = 11;
            this.rb3.TabStop = true;
            this.rb3.Tag = "3";
            this.rb3.Text = "3-Orta";
            this.rb3.UseVisualStyleBackColor = true;
            this.rb3.CheckedChanged += new System.EventHandler(this.rbPuan_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(9, 65);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(56, 17);
            this.rb2.TabIndex = 10;
            this.rb2.TabStop = true;
            this.rb2.Tag = "2";
            this.rb2.Text = "2-Kötü";
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.CheckedChanged += new System.EventHandler(this.rbPuan_CheckedChanged);
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(9, 42);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(78, 17);
            this.rb1.TabIndex = 9;
            this.rb1.TabStop = true;
            this.rb1.Tag = "1";
            this.rb1.Text = "1-Çok Kötü";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.rbPuan_CheckedChanged);
            // 
            // lblResim
            // 
            this.lblResim.AutoSize = true;
            this.lblResim.Location = new System.Drawing.Point(114, 279);
            this.lblResim.Name = "lblResim";
            this.lblResim.Size = new System.Drawing.Size(159, 13);
            this.lblResim.TabIndex = 9;
            this.lblResim.Text = "(Resmi değiştirmek için tıklayınız)";
            // 
            // txtFilmAd
            // 
            this.txtFilmAd.Location = new System.Drawing.Point(4, 79);
            this.txtFilmAd.Name = "txtFilmAd";
            this.txtFilmAd.Size = new System.Drawing.Size(269, 20);
            this.txtFilmAd.TabIndex = 2;
            this.txtFilmAd.TextChanged += new System.EventHandler(this.txtFilmAd_TextChanged);
            // 
            // pboFoto
            // 
            this.pboFoto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pboFoto.Location = new System.Drawing.Point(114, 116);
            this.pboFoto.Name = "pboFoto";
            this.pboFoto.Size = new System.Drawing.Size(155, 159);
            this.pboFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboFoto.TabIndex = 1;
            this.pboFoto.TabStop = false;
            // 
            // lblFilmAd
            // 
            this.lblFilmAd.AutoSize = true;
            this.lblFilmAd.Location = new System.Drawing.Point(4, 63);
            this.lblFilmAd.Name = "lblFilmAd";
            this.lblFilmAd.Size = new System.Drawing.Size(51, 13);
            this.lblFilmAd.TabIndex = 0;
            this.lblFilmAd.Text = "Filmin Adı";
            // 
            // lstFilm
            // 
            this.lstFilm.BackColor = System.Drawing.Color.Yellow;
            this.lstFilm.DisplayMember = "FilmAd";
            this.lstFilm.FormattingEnabled = true;
            this.lstFilm.Location = new System.Drawing.Point(293, 12);
            this.lstFilm.Name = "lstFilm";
            this.lstFilm.Size = new System.Drawing.Size(288, 316);
            this.lstFilm.TabIndex = 2;
            this.lstFilm.ValueMember = "Id";
            this.lstFilm.SelectedIndexChanged += new System.EventHandler(this.lstFilm_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 333);
            this.Controls.Add(this.lstFilm);
            this.Controls.Add(this.gBFilmDetay);
            this.Name = "Form1";
            this.Text = "Öz IMDB";
            this.gBFilmDetay.ResumeLayout(false);
            this.gBFilmDetay.PerformLayout();
            this.gboPuan.ResumeLayout(false);
            this.gboPuan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYeniFilm;
        private System.Windows.Forms.GroupBox gBFilmDetay;
        private System.Windows.Forms.Label lblResim;
        private System.Windows.Forms.TextBox txtFilmAd;
        private System.Windows.Forms.PictureBox pboFoto;
        private System.Windows.Forms.Label lblFilmAd;
        private System.Windows.Forms.ListBox lstFilm;
        private System.Windows.Forms.GroupBox gboPuan;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbPuan;
    }
}

