namespace KutuphaneYonetimSistemi
{
    partial class FormKitapEkle
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
            groupBoxKitapEkle = new GroupBox();
            buttonGuncelle = new Button();
            buttonKitapKaydet = new Button();
            textBoxKitapTurKodu = new TextBox();
            textBoxISBN = new TextBox();
            textBoxYazarAdi = new TextBox();
            textBoxKitapAdi = new TextBox();
            labelKitapTürKoduPointer = new Label();
            labelISBNPointer = new Label();
            labelYazarAdıPointer = new Label();
            labelKitapAdıPointer = new Label();
            labelKitapID = new Label();
            labelKitapIDPointer = new Label();
            groupBoxKitapEkle.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxKitapEkle
            // 
            groupBoxKitapEkle.Controls.Add(buttonGuncelle);
            groupBoxKitapEkle.Controls.Add(buttonKitapKaydet);
            groupBoxKitapEkle.Controls.Add(textBoxKitapTurKodu);
            groupBoxKitapEkle.Controls.Add(textBoxISBN);
            groupBoxKitapEkle.Controls.Add(textBoxYazarAdi);
            groupBoxKitapEkle.Controls.Add(textBoxKitapAdi);
            groupBoxKitapEkle.Controls.Add(labelKitapTürKoduPointer);
            groupBoxKitapEkle.Controls.Add(labelISBNPointer);
            groupBoxKitapEkle.Controls.Add(labelYazarAdıPointer);
            groupBoxKitapEkle.Controls.Add(labelKitapAdıPointer);
            groupBoxKitapEkle.Controls.Add(labelKitapID);
            groupBoxKitapEkle.Controls.Add(labelKitapIDPointer);
            groupBoxKitapEkle.Font = new Font("Times New Roman", 14F);
            groupBoxKitapEkle.Location = new Point(21, 12);
            groupBoxKitapEkle.Name = "groupBoxKitapEkle";
            groupBoxKitapEkle.Size = new Size(753, 426);
            groupBoxKitapEkle.TabIndex = 0;
            groupBoxKitapEkle.TabStop = false;
            groupBoxKitapEkle.Text = "Kitap Ekle / Güncelle";
            // 
            // buttonGuncelle
            // 
            buttonGuncelle.Location = new Point(406, 363);
            buttonGuncelle.Name = "buttonGuncelle";
            buttonGuncelle.Size = new Size(189, 34);
            buttonGuncelle.TabIndex = 11;
            buttonGuncelle.Text = "Kitap Güncelle";
            buttonGuncelle.UseVisualStyleBackColor = true;
            buttonGuncelle.Click += buttonGuncelle_Click;
            // 
            // buttonKitapKaydet
            // 
            buttonKitapKaydet.Location = new Point(172, 363);
            buttonKitapKaydet.Name = "buttonKitapKaydet";
            buttonKitapKaydet.Size = new Size(189, 34);
            buttonKitapKaydet.TabIndex = 10;
            buttonKitapKaydet.Text = "Kitap Ekle";
            buttonKitapKaydet.UseVisualStyleBackColor = true;
            buttonKitapKaydet.Click += buttonKitapKaydet_Click;
            // 
            // textBoxKitapTurKodu
            // 
            textBoxKitapTurKodu.Font = new Font("Times New Roman", 11F);
            textBoxKitapTurKodu.Location = new Point(354, 296);
            textBoxKitapTurKodu.Name = "textBoxKitapTurKodu";
            textBoxKitapTurKodu.Size = new Size(125, 29);
            textBoxKitapTurKodu.TabIndex = 9;
            // 
            // textBoxISBN
            // 
            textBoxISBN.Font = new Font("Times New Roman", 11F);
            textBoxISBN.Location = new Point(354, 242);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(125, 29);
            textBoxISBN.TabIndex = 8;
            // 
            // textBoxYazarAdi
            // 
            textBoxYazarAdi.Font = new Font("Times New Roman", 11F);
            textBoxYazarAdi.Location = new Point(354, 186);
            textBoxYazarAdi.Name = "textBoxYazarAdi";
            textBoxYazarAdi.Size = new Size(125, 29);
            textBoxYazarAdi.TabIndex = 7;
            // 
            // textBoxKitapAdi
            // 
            textBoxKitapAdi.Font = new Font("Times New Roman", 11F);
            textBoxKitapAdi.Location = new Point(354, 131);
            textBoxKitapAdi.Name = "textBoxKitapAdi";
            textBoxKitapAdi.Size = new Size(125, 29);
            textBoxKitapAdi.TabIndex = 6;
            // 
            // labelKitapTürKoduPointer
            // 
            labelKitapTürKoduPointer.AutoSize = true;
            labelKitapTürKoduPointer.Font = new Font("Times New Roman", 14F);
            labelKitapTürKoduPointer.Location = new Point(172, 298);
            labelKitapTürKoduPointer.Name = "labelKitapTürKoduPointer";
            labelKitapTürKoduPointer.Size = new Size(176, 27);
            labelKitapTürKoduPointer.TabIndex = 5;
            labelKitapTürKoduPointer.Text = "Kitap Tür Kodu :";
            // 
            // labelISBNPointer
            // 
            labelISBNPointer.AutoSize = true;
            labelISBNPointer.Font = new Font("Times New Roman", 14F);
            labelISBNPointer.Location = new Point(172, 244);
            labelISBNPointer.Name = "labelISBNPointer";
            labelISBNPointer.Size = new Size(77, 27);
            labelISBNPointer.TabIndex = 4;
            labelISBNPointer.Text = "ISBN :";
            // 
            // labelYazarAdıPointer
            // 
            labelYazarAdıPointer.AutoSize = true;
            labelYazarAdıPointer.Font = new Font("Times New Roman", 14F);
            labelYazarAdıPointer.Location = new Point(172, 188);
            labelYazarAdıPointer.Name = "labelYazarAdıPointer";
            labelYazarAdıPointer.Size = new Size(119, 27);
            labelYazarAdıPointer.TabIndex = 3;
            labelYazarAdıPointer.Text = "Yazar Adı :";
            // 
            // labelKitapAdıPointer
            // 
            labelKitapAdıPointer.AutoSize = true;
            labelKitapAdıPointer.Font = new Font("Times New Roman", 14F);
            labelKitapAdıPointer.Location = new Point(172, 133);
            labelKitapAdıPointer.Name = "labelKitapAdıPointer";
            labelKitapAdıPointer.Size = new Size(117, 27);
            labelKitapAdıPointer.TabIndex = 2;
            labelKitapAdıPointer.Text = "Kitap Adı :";
            // 
            // labelKitapID
            // 
            labelKitapID.AutoSize = true;
            labelKitapID.Font = new Font("Times New Roman", 14F);
            labelKitapID.Location = new Point(354, 74);
            labelKitapID.Name = "labelKitapID";
            labelKitapID.Size = new Size(20, 27);
            labelKitapID.TabIndex = 1;
            labelKitapID.Text = "-";
            // 
            // labelKitapIDPointer
            // 
            labelKitapIDPointer.AutoSize = true;
            labelKitapIDPointer.Font = new Font("Times New Roman", 14F);
            labelKitapIDPointer.Location = new Point(172, 74);
            labelKitapIDPointer.Name = "labelKitapIDPointer";
            labelKitapIDPointer.Size = new Size(108, 27);
            labelKitapIDPointer.TabIndex = 0;
            labelKitapIDPointer.Text = "Kitap ID :";
            // 
            // FormKitapEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxKitapEkle);
            Name = "FormKitapEkle";
            Text = "KitapEkle";
            groupBoxKitapEkle.ResumeLayout(false);
            groupBoxKitapEkle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxKitapEkle;
        private Label labelKitapTürKoduPointer;
        private Label labelISBNPointer;
        private Label labelYazarAdıPointer;
        private Label labelKitapAdıPointer;
        private Label labelKitapID;
        private Label labelKitapIDPointer;
        private TextBox textBoxKitapAdi;
        private TextBox textBoxKitapTurKodu;
        private TextBox textBoxISBN;
        private TextBox textBoxYazarAdi;
        private Button buttonKitapKaydet;
        private Button buttonGuncelle;
    }
}