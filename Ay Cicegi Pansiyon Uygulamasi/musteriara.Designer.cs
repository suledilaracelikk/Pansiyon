
namespace Ay_Cicegi_Pansiyon_Uygulamasi
{
    partial class musteriara
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.musteriid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soyadi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cinsiyet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.odano = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ucret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.giristarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cikistarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnkaydet);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.txtadi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(852, 520);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "musteri bilgiler";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(375, 460);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 54);
            this.button2.TabIndex = 43;
            this.button2.Text = "GERI DON";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label11.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gold;
            this.label11.Location = new System.Drawing.Point(810, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 25);
            this.label11.TabIndex = 57;
            this.label11.Text = "0";
            this.label11.Visible = false;
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.Color.Black;
            this.btnkaydet.Font = new System.Drawing.Font("Myanmar Text", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkaydet.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnkaydet.Location = new System.Drawing.Point(531, 101);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(121, 38);
            this.btnkaydet.TabIndex = 54;
            this.btnkaydet.Text = "ARA";
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click_1);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.musteriid,
            this.adi,
            this.soyadi,
            this.cinsiyet,
            this.telefon,
            this.mail,
            this.tc,
            this.odano,
            this.ucret,
            this.giristarihi,
            this.cikistarihi});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 278);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(846, 176);
            this.listView1.TabIndex = 42;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // musteriid
            // 
            this.musteriid.Text = "musteriid";
            // 
            // adi
            // 
            this.adi.Text = "adi";
            this.adi.Width = 72;
            // 
            // soyadi
            // 
            this.soyadi.Text = "soyadi";
            this.soyadi.Width = 85;
            // 
            // cinsiyet
            // 
            this.cinsiyet.Text = "cinsiyet";
            this.cinsiyet.Width = 81;
            // 
            // telefon
            // 
            this.telefon.Text = "telefon";
            this.telefon.Width = 93;
            // 
            // mail
            // 
            this.mail.Text = "mail";
            this.mail.Width = 80;
            // 
            // tc
            // 
            this.tc.Text = "tc";
            this.tc.Width = 65;
            // 
            // odano
            // 
            this.odano.Text = "odano";
            this.odano.Width = 79;
            // 
            // ucret
            // 
            this.ucret.Text = "ucret";
            this.ucret.Width = 59;
            // 
            // giristarihi
            // 
            this.giristarihi.Text = "giristarihi";
            this.giristarihi.Width = 98;
            // 
            // cikistarihi
            // 
            this.cikistarihi.Text = "cikistarihi";
            this.cikistarihi.Width = 70;
            // 
            // txtadi
            // 
            this.txtadi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtadi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadi.ForeColor = System.Drawing.SystemColors.Info;
            this.txtadi.Location = new System.Drawing.Point(221, 110);
            this.txtadi.Name = "txtadi";
            this.txtadi.Size = new System.Drawing.Size(199, 29);
            this.txtadi.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(39, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Aranan isim:";
            // 
            // musteriara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(876, 515);
            this.Controls.Add(this.groupBox1);
            this.Name = "musteriara";
            this.Text = "musteriara";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader musteriid;
        private System.Windows.Forms.ColumnHeader adi;
        private System.Windows.Forms.ColumnHeader soyadi;
        private System.Windows.Forms.ColumnHeader cinsiyet;
        private System.Windows.Forms.ColumnHeader telefon;
        private System.Windows.Forms.ColumnHeader mail;
        private System.Windows.Forms.ColumnHeader tc;
        private System.Windows.Forms.ColumnHeader odano;
        private System.Windows.Forms.ColumnHeader ucret;
        private System.Windows.Forms.ColumnHeader giristarihi;
        private System.Windows.Forms.ColumnHeader cikistarihi;
    }
}