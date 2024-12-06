namespace KutuphaneYonetimSistemi
{
    partial class FormKitaplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKitaplar));
            buttonKitapEkle = new Button();
            label1 = new Label();
            buttonIadeEt = new Button();
            buttonOduncAl = new Button();
            groupBox1 = new GroupBox();
            dataGridViewKitaplar = new DataGridView();
            buttonReload = new Button();
            textBoxAra = new TextBox();
            labelKitapArama = new Label();
            buttonAra = new Button();
            buttonKitapSil = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKitaplar).BeginInit();
            SuspendLayout();
            // 
            // buttonKitapEkle
            // 
            buttonKitapEkle.Location = new Point(412, 202);
            buttonKitapEkle.Name = "buttonKitapEkle";
            buttonKitapEkle.Size = new Size(144, 48);
            buttonKitapEkle.TabIndex = 1;
            buttonKitapEkle.Text = "Kitap Ekle / Güncelle";
            buttonKitapEkle.UseVisualStyleBackColor = true;
            buttonKitapEkle.Click += buttonKitapEkle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(165, 19);
            label1.Name = "label1";
            label1.Size = new Size(470, 128);
            label1.TabIndex = 2;
            label1.Text = "Kütüphane Yönetim Sistemine hoşgeldiniz.\r\n\r\nLütfen yapmak istediğiniz işlemi seçiniz.\r\n\r\n";
            // 
            // buttonIadeEt
            // 
            buttonIadeEt.Location = new Point(245, 202);
            buttonIadeEt.Name = "buttonIadeEt";
            buttonIadeEt.Size = new Size(144, 48);
            buttonIadeEt.TabIndex = 3;
            buttonIadeEt.Text = "İade Et";
            buttonIadeEt.UseVisualStyleBackColor = true;
            buttonIadeEt.Click += buttonIadeEt_Click;
            // 
            // buttonOduncAl
            // 
            buttonOduncAl.Location = new Point(82, 202);
            buttonOduncAl.Name = "buttonOduncAl";
            buttonOduncAl.Size = new Size(144, 48);
            buttonOduncAl.TabIndex = 4;
            buttonOduncAl.Text = "Ödünç Al";
            buttonOduncAl.UseVisualStyleBackColor = true;
            buttonOduncAl.Click += buttonOduncAl_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewKitaplar);
            groupBox1.Location = new Point(22, 256);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(766, 182);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kitaplar";
            // 
            // dataGridViewKitaplar
            // 
            dataGridViewKitaplar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewKitaplar.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKitaplar.Dock = DockStyle.Fill;
            dataGridViewKitaplar.Location = new Point(3, 23);
            dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            dataGridViewKitaplar.RowHeadersWidth = 51;
            dataGridViewKitaplar.Size = new Size(760, 156);
            dataGridViewKitaplar.TabIndex = 0;
            dataGridViewKitaplar.CellClick += dataGridViewKitaplar_CellClick;
            // 
            // buttonReload
            // 
            buttonReload.Location = new Point(691, 24);
            buttonReload.Name = "buttonReload";
            buttonReload.Size = new Size(94, 29);
            buttonReload.TabIndex = 6;
            buttonReload.Text = "Yenile";
            buttonReload.UseVisualStyleBackColor = true;
            buttonReload.Click += buttonReload_Click;
            // 
            // textBoxAra
            // 
            textBoxAra.Location = new Point(339, 137);
            textBoxAra.Name = "textBoxAra";
            textBoxAra.Size = new Size(125, 27);
            textBoxAra.TabIndex = 7;
            // 
            // labelKitapArama
            // 
            labelKitapArama.AutoSize = true;
            labelKitapArama.Location = new Point(222, 140);
            labelKitapArama.Name = "labelKitapArama";
            labelKitapArama.Size = new Size(99, 20);
            labelKitapArama.TabIndex = 8;
            labelKitapArama.Text = "Kitap Arama :";
            // 
            // buttonAra
            // 
            buttonAra.Location = new Point(491, 126);
            buttonAra.Name = "buttonAra";
            buttonAra.Size = new Size(144, 48);
            buttonAra.TabIndex = 9;
            buttonAra.Text = "Ara";
            buttonAra.UseVisualStyleBackColor = true;
            buttonAra.Click += buttonAra_Click;
            // 
            // buttonKitapSil
            // 
            buttonKitapSil.Location = new Point(573, 202);
            buttonKitapSil.Name = "buttonKitapSil";
            buttonKitapSil.Size = new Size(144, 48);
            buttonKitapSil.TabIndex = 10;
            buttonKitapSil.Text = "Kitap Sil";
            buttonKitapSil.UseVisualStyleBackColor = true;
            buttonKitapSil.Click += buttonKitapSil_Click;
            // 
            // FormKitaplar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonKitapSil);
            Controls.Add(buttonAra);
            Controls.Add(labelKitapArama);
            Controls.Add(textBoxAra);
            Controls.Add(buttonReload);
            Controls.Add(groupBox1);
            Controls.Add(buttonOduncAl);
            Controls.Add(buttonIadeEt);
            Controls.Add(label1);
            Controls.Add(buttonKitapEkle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormKitaplar";
            Text = "Kütüphane Ana Menü";
            FormClosed += FormKitaplar_FormClosed;
            Load += FormKitaplar_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewKitaplar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonKitapEkle;
        private Label label1;
        private Button buttonIadeEt;
        private Button buttonOduncAl;
        private GroupBox groupBox1;
        private DataGridView dataGridViewKitaplar;
        private Button buttonReload;
        private TextBox textBoxAra;
        private Label labelKitapArama;
        private Button buttonAra;
        private Button buttonKitapSil;
    }
}