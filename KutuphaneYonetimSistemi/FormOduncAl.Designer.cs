namespace KutuphaneYonetimSistemi
{
    partial class FormOduncAl
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
            groupBoxOduncAl = new GroupBox();
            buttonOduncAl = new Button();
            dateTimePickerTarih = new DateTimePicker();
            textBoxOduncAlan = new TextBox();
            labelAlınanTarih = new Label();
            labelOduncAlan = new Label();
            kitapIDPointer = new Label();
            textBoxKitapID = new TextBox();
            groupBoxOduncAl.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxOduncAl
            // 
            groupBoxOduncAl.Controls.Add(textBoxKitapID);
            groupBoxOduncAl.Controls.Add(kitapIDPointer);
            groupBoxOduncAl.Controls.Add(buttonOduncAl);
            groupBoxOduncAl.Controls.Add(dateTimePickerTarih);
            groupBoxOduncAl.Controls.Add(textBoxOduncAlan);
            groupBoxOduncAl.Controls.Add(labelAlınanTarih);
            groupBoxOduncAl.Controls.Add(labelOduncAlan);
            groupBoxOduncAl.Location = new Point(21, 21);
            groupBoxOduncAl.Name = "groupBoxOduncAl";
            groupBoxOduncAl.Size = new Size(753, 417);
            groupBoxOduncAl.TabIndex = 0;
            groupBoxOduncAl.TabStop = false;
            groupBoxOduncAl.Text = "Ödünç Al";
            // 
            // buttonOduncAl
            // 
            buttonOduncAl.Location = new Point(307, 283);
            buttonOduncAl.Name = "buttonOduncAl";
            buttonOduncAl.Size = new Size(165, 48);
            buttonOduncAl.TabIndex = 5;
            buttonOduncAl.Text = "Kitabı Ödünç Al";
            buttonOduncAl.UseVisualStyleBackColor = true;
            buttonOduncAl.Click += buttonOduncAl_Click;
            // 
            // dateTimePickerTarih
            // 
            dateTimePickerTarih.Location = new Point(317, 157);
            dateTimePickerTarih.Name = "dateTimePickerTarih";
            dateTimePickerTarih.Size = new Size(139, 27);
            dateTimePickerTarih.TabIndex = 4;
            // 
            // textBoxOduncAlan
            // 
            textBoxOduncAlan.Location = new Point(317, 103);
            textBoxOduncAlan.Name = "textBoxOduncAlan";
            textBoxOduncAlan.Size = new Size(139, 27);
            textBoxOduncAlan.TabIndex = 2;
            // 
            // labelAlınanTarih
            // 
            labelAlınanTarih.AutoSize = true;
            labelAlınanTarih.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelAlınanTarih.Location = new Point(175, 158);
            labelAlınanTarih.Name = "labelAlınanTarih";
            labelAlınanTarih.Size = new Size(140, 26);
            labelAlınanTarih.TabIndex = 1;
            labelAlınanTarih.Text = "Alınan Tarih :";
            // 
            // labelOduncAlan
            // 
            labelOduncAlan.AutoSize = true;
            labelOduncAlan.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelOduncAlan.Location = new Point(175, 102);
            labelOduncAlan.Name = "labelOduncAlan";
            labelOduncAlan.Size = new Size(136, 26);
            labelOduncAlan.TabIndex = 0;
            labelOduncAlan.Text = "Ödünç Alan :";
            // 
            // kitapIDPointer
            // 
            kitapIDPointer.AutoSize = true;
            kitapIDPointer.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            kitapIDPointer.Location = new Point(175, 42);
            kitapIDPointer.Name = "kitapIDPointer";
            kitapIDPointer.Size = new Size(134, 26);
            kitapIDPointer.TabIndex = 6;
            kitapIDPointer.Text = "Kitap ID      :";
            // 
            // textBoxKitapID
            // 
            textBoxKitapID.Location = new Point(317, 41);
            textBoxKitapID.Name = "textBoxKitapID";
            textBoxKitapID.Size = new Size(139, 27);
            textBoxKitapID.TabIndex = 7;
            // 
            // FormOduncAl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxOduncAl);
            Name = "FormOduncAl";
            Text = "OduncAl";
            groupBoxOduncAl.ResumeLayout(false);
            groupBoxOduncAl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxOduncAl;
        private Label labelAlınanTarih;
        private Label labelOduncAlan;
        private TextBox textBoxOduncAlan;
        private DateTimePicker dateTimePickerTarih;
        private Button buttonOduncAl;
        private TextBox textBoxKitapID;
        private Label kitapIDPointer;
    }
}