namespace KutuphaneYonetimSistemi
{
    partial class FormIadeEt
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
            groupBoxIadeEt = new GroupBox();
            textBoxKitapId = new Label();
            labelKitapId = new Label();
            labelKitapIdPointer = new Label();
            buttonIadeEt = new Button();
            labelTL = new Label();
            labelGecikmeUcreti = new Label();
            buttonGecikmeBedeli = new Button();
            labelGecikmeBedeli = new Label();
            label1 = new Label();
            labelAlinmaTarihi = new Label();
            groupBoxIadeEt.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxIadeEt
            // 
            groupBoxIadeEt.Controls.Add(labelAlinmaTarihi);
            groupBoxIadeEt.Controls.Add(label1);
            groupBoxIadeEt.Controls.Add(textBoxKitapId);
            groupBoxIadeEt.Controls.Add(labelKitapId);
            groupBoxIadeEt.Controls.Add(labelKitapIdPointer);
            groupBoxIadeEt.Controls.Add(buttonIadeEt);
            groupBoxIadeEt.Controls.Add(labelTL);
            groupBoxIadeEt.Controls.Add(labelGecikmeUcreti);
            groupBoxIadeEt.Controls.Add(buttonGecikmeBedeli);
            groupBoxIadeEt.Controls.Add(labelGecikmeBedeli);
            groupBoxIadeEt.Location = new Point(12, 12);
            groupBoxIadeEt.Name = "groupBoxIadeEt";
            groupBoxIadeEt.Size = new Size(776, 426);
            groupBoxIadeEt.TabIndex = 0;
            groupBoxIadeEt.TabStop = false;
            groupBoxIadeEt.Text = "İade Et";
            // 
            // textBoxKitapId
            // 
            textBoxKitapId.AutoSize = true;
            textBoxKitapId.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxKitapId.Location = new Point(441, 46);
            textBoxKitapId.Name = "textBoxKitapId";
            textBoxKitapId.Size = new Size(23, 26);
            textBoxKitapId.TabIndex = 7;
            textBoxKitapId.Text = "0";
            // 
            // labelKitapId
            // 
            labelKitapId.AutoSize = true;
            labelKitapId.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelKitapId.Location = new Point(441, 101);
            labelKitapId.Name = "labelKitapId";
            labelKitapId.Size = new Size(0, 26);
            labelKitapId.TabIndex = 6;
            // 
            // labelKitapIdPointer
            // 
            labelKitapIdPointer.AutoSize = true;
            labelKitapIdPointer.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelKitapIdPointer.Location = new Point(265, 46);
            labelKitapIdPointer.Name = "labelKitapIdPointer";
            labelKitapIdPointer.Size = new Size(164, 26);
            labelKitapIdPointer.TabIndex = 5;
            labelKitapIdPointer.Text = "Kitap ID           :";
            // 
            // buttonIadeEt
            // 
            buttonIadeEt.Location = new Point(298, 283);
            buttonIadeEt.Name = "buttonIadeEt";
            buttonIadeEt.Size = new Size(183, 39);
            buttonIadeEt.TabIndex = 4;
            buttonIadeEt.Text = "Kitabı İade Et";
            buttonIadeEt.UseVisualStyleBackColor = true;
            buttonIadeEt.Click += buttonIadeEt_Click;
            // 
            // labelTL
            // 
            labelTL.AutoSize = true;
            labelTL.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelTL.Location = new Point(470, 158);
            labelTL.Name = "labelTL";
            labelTL.Size = new Size(39, 26);
            labelTL.TabIndex = 3;
            labelTL.Text = "TL";
            // 
            // labelGecikmeUcreti
            // 
            labelGecikmeUcreti.AutoSize = true;
            labelGecikmeUcreti.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelGecikmeUcreti.Location = new Point(441, 158);
            labelGecikmeUcreti.Name = "labelGecikmeUcreti";
            labelGecikmeUcreti.Size = new Size(23, 26);
            labelGecikmeUcreti.TabIndex = 2;
            labelGecikmeUcreti.Text = "0";
            // 
            // buttonGecikmeBedeli
            // 
            buttonGecikmeBedeli.Location = new Point(298, 214);
            buttonGecikmeBedeli.Name = "buttonGecikmeBedeli";
            buttonGecikmeBedeli.Size = new Size(183, 39);
            buttonGecikmeBedeli.TabIndex = 1;
            buttonGecikmeBedeli.Text = "Gecikme Bedeli Hesapla";
            buttonGecikmeBedeli.UseVisualStyleBackColor = true;
            buttonGecikmeBedeli.Click += buttonGecikmeBedeli_Click;
            // 
            // labelGecikmeBedeli
            // 
            labelGecikmeBedeli.AutoSize = true;
            labelGecikmeBedeli.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelGecikmeBedeli.Location = new Point(265, 158);
            labelGecikmeBedeli.Name = "labelGecikmeBedeli";
            labelGecikmeBedeli.Size = new Size(170, 26);
            labelGecikmeBedeli.TabIndex = 0;
            labelGecikmeBedeli.Text = "Gecikme Bedeli :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(265, 101);
            label1.Name = "label1";
            label1.Size = new Size(164, 26);
            label1.TabIndex = 8;
            label1.Text = "Alınma Tarihi   :";
            // 
            // labelAlinmaTarihi
            // 
            labelAlinmaTarihi.AutoSize = true;
            labelAlinmaTarihi.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelAlinmaTarihi.Location = new Point(441, 101);
            labelAlinmaTarihi.Name = "labelAlinmaTarihi";
            labelAlinmaTarihi.Size = new Size(23, 26);
            labelAlinmaTarihi.TabIndex = 9;
            labelAlinmaTarihi.Text = "0";
            // 
            // FormIadeEt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxIadeEt);
            Name = "FormIadeEt";
            Text = "FormIadeEt";
            groupBoxIadeEt.ResumeLayout(false);
            groupBoxIadeEt.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxIadeEt;
        private Button buttonGecikmeBedeli;
        private Label labelGecikmeBedeli;
        private Label labelGecikmeUcreti;
        private Label labelTL;
        private Button buttonIadeEt;
        private Label labelKitapId;
        private Label labelKitapIdPointer;
        private Label textBoxKitapId;
        private Label labelAlinmaTarihi;
        private Label label1;
    }
}