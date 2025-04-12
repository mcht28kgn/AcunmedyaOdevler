namespace WindowsFormArabaBilgiFormu
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
            txtMarka = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtModel = new TextBox();
            label3 = new Label();
            txtRenk = new TextBox();
            label4 = new Label();
            txtKapiSayisi = new TextBox();
            label5 = new Label();
            txtPencereSayisi = new TextBox();
            label6 = new Label();
            txtYakit = new TextBox();
            btnGoster = new Button();
            SuspendLayout();
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(153, 24);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(100, 23);
            txtMarka.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 32);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Marka:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 88);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 3;
            label2.Text = "Model:";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(153, 80);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(100, 23);
            txtModel.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 144);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 5;
            label3.Text = "Renk:";
            // 
            // txtRenk
            // 
            txtRenk.Location = new Point(153, 136);
            txtRenk.Name = "txtRenk";
            txtRenk.Size = new Size(100, 23);
            txtRenk.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 200);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 7;
            label4.Text = "Kapı Sayısı:";
            // 
            // txtKapiSayisi
            // 
            txtKapiSayisi.Location = new Point(153, 192);
            txtKapiSayisi.Name = "txtKapiSayisi";
            txtKapiSayisi.Size = new Size(100, 23);
            txtKapiSayisi.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 259);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 9;
            label5.Text = "Pencere Sayısı:";
            // 
            // txtPencereSayisi
            // 
            txtPencereSayisi.Location = new Point(153, 251);
            txtPencereSayisi.Name = "txtPencereSayisi";
            txtPencereSayisi.Size = new Size(100, 23);
            txtPencereSayisi.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 312);
            label6.Name = "label6";
            label6.Size = new Size(131, 15);
            label6.TabIndex = 11;
            label6.Text = "100 Km'de Yaktığı Yakıt:";
            // 
            // txtYakit
            // 
            txtYakit.Location = new Point(153, 304);
            txtYakit.Name = "txtYakit";
            txtYakit.Size = new Size(100, 23);
            txtYakit.TabIndex = 10;
            // 
            // btnGoster
            // 
            btnGoster.Location = new Point(153, 355);
            btnGoster.Name = "btnGoster";
            btnGoster.Size = new Size(100, 32);
            btnGoster.TabIndex = 12;
            btnGoster.Text = "Bilgileri Göster";
            btnGoster.UseVisualStyleBackColor = true;
            btnGoster.Click += btnGoster_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGoster);
            Controls.Add(label6);
            Controls.Add(txtYakit);
            Controls.Add(label5);
            Controls.Add(txtPencereSayisi);
            Controls.Add(label4);
            Controls.Add(txtKapiSayisi);
            Controls.Add(label3);
            Controls.Add(txtRenk);
            Controls.Add(label2);
            Controls.Add(txtModel);
            Controls.Add(label1);
            Controls.Add(txtMarka);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMarka;
        private Label label1;
        private Label label2;
        private TextBox txtModel;
        private Label label3;
        private TextBox txtRenk;
        private Label label4;
        private TextBox txtKapiSayisi;
        private Label label5;
        private TextBox txtPencereSayisi;
        private Label label6;
        private TextBox txtYakit;
        private Button btnGoster;
    }
}
