namespace Cryptography_Csharp
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
            this.gbOriginal = new System.Windows.Forms.GroupBox();
            this.gbCrypro = new System.Windows.Forms.GroupBox();
            this.tbCrypto = new System.Windows.Forms.RichTextBox();
            this.tbOriginal = new System.Windows.Forms.RichTextBox();
            this.tbTajni = new System.Windows.Forms.TextBox();
            this.lblTajni = new System.Windows.Forms.Label();
            this.btnTajniUcitaj = new System.Windows.Forms.Button();
            this.btnTajniSpremi = new System.Windows.Forms.Button();
            this.tbJavni = new System.Windows.Forms.TextBox();
            this.lblJavni = new System.Windows.Forms.Label();
            this.btnJavniUcitaj = new System.Windows.Forms.Button();
            this.btnJavniSpremi = new System.Windows.Forms.Button();
            this.tbPrivatni = new System.Windows.Forms.TextBox();
            this.lblPrivatni = new System.Windows.Forms.Label();
            this.btnPrivatniUcitaj = new System.Windows.Forms.Button();
            this.btnPrivatniSpremi = new System.Windows.Forms.Button();
            this.tbSazetak = new System.Windows.Forms.TextBox();
            this.lblSazetak = new System.Windows.Forms.Label();
            this.rbCrypt = new System.Windows.Forms.RadioButton();
            this.rbDecrypt = new System.Windows.Forms.RadioButton();
            this.btnPokreni = new System.Windows.Forms.Button();
            this.btnOriginalSpremi = new System.Windows.Forms.Button();
            this.btnCryptoSpremi = new System.Windows.Forms.Button();
            this.btnOriginalOtvori = new System.Windows.Forms.Button();
            this.btnSazetakSpremi = new System.Windows.Forms.Button();
            this.btnSazetakUcitaj = new System.Windows.Forms.Button();
            this.rbSazetakKreiraj = new System.Windows.Forms.RadioButton();
            this.rbSazetakProvjeri = new System.Windows.Forms.RadioButton();
            this.gbOriginal.SuspendLayout();
            this.gbCrypro.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOriginal
            // 
            this.gbOriginal.Controls.Add(this.btnOriginalOtvori);
            this.gbOriginal.Controls.Add(this.tbOriginal);
            this.gbOriginal.Controls.Add(this.btnOriginalSpremi);
            this.gbOriginal.Location = new System.Drawing.Point(12, 12);
            this.gbOriginal.Name = "gbOriginal";
            this.gbOriginal.Size = new System.Drawing.Size(480, 600);
            this.gbOriginal.TabIndex = 1;
            this.gbOriginal.TabStop = false;
            this.gbOriginal.Text = "Originalni dokument";
            // 
            // gbCrypro
            // 
            this.gbCrypro.Controls.Add(this.btnCryptoSpremi);
            this.gbCrypro.Controls.Add(this.tbCrypto);
            this.gbCrypro.Location = new System.Drawing.Point(516, 12);
            this.gbCrypro.Name = "gbCrypro";
            this.gbCrypro.Size = new System.Drawing.Size(480, 600);
            this.gbCrypro.TabIndex = 1;
            this.gbCrypro.TabStop = false;
            this.gbCrypro.Text = "Kriptirani / dekriptirani dokument";
            // 
            // tbCrypto
            // 
            this.tbCrypto.AcceptsTab = true;
            this.tbCrypto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCrypto.Location = new System.Drawing.Point(6, 16);
            this.tbCrypto.Name = "tbCrypto";
            this.tbCrypto.Size = new System.Drawing.Size(468, 549);
            this.tbCrypto.TabIndex = 2;
            this.tbCrypto.Text = "";
            // 
            // tbOriginal
            // 
            this.tbOriginal.AcceptsTab = true;
            this.tbOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOriginal.Location = new System.Drawing.Point(6, 16);
            this.tbOriginal.Name = "tbOriginal";
            this.tbOriginal.Size = new System.Drawing.Size(468, 549);
            this.tbOriginal.TabIndex = 1;
            this.tbOriginal.Text = "";
            // 
            // tbTajni
            // 
            this.tbTajni.Location = new System.Drawing.Point(83, 628);
            this.tbTajni.Name = "tbTajni";
            this.tbTajni.Size = new System.Drawing.Size(419, 20);
            this.tbTajni.TabIndex = 2;
            // 
            // lblTajni
            // 
            this.lblTajni.AutoSize = true;
            this.lblTajni.Location = new System.Drawing.Point(12, 631);
            this.lblTajni.Name = "lblTajni";
            this.lblTajni.Size = new System.Drawing.Size(55, 13);
            this.lblTajni.TabIndex = 3;
            this.lblTajni.Text = "Tajni ključ";
            // 
            // btnTajniUcitaj
            // 
            this.btnTajniUcitaj.Location = new System.Drawing.Point(517, 626);
            this.btnTajniUcitaj.Name = "btnTajniUcitaj";
            this.btnTajniUcitaj.Size = new System.Drawing.Size(130, 23);
            this.btnTajniUcitaj.TabIndex = 4;
            this.btnTajniUcitaj.Text = "Učitaj [ tajni_kljuc.txt ]";
            this.btnTajniUcitaj.UseVisualStyleBackColor = true;
            // 
            // btnTajniSpremi
            // 
            this.btnTajniSpremi.Location = new System.Drawing.Point(656, 626);
            this.btnTajniSpremi.Name = "btnTajniSpremi";
            this.btnTajniSpremi.Size = new System.Drawing.Size(145, 23);
            this.btnTajniSpremi.TabIndex = 4;
            this.btnTajniSpremi.Text = "Spremi [ tajni_kljuc.txt ]";
            this.btnTajniSpremi.UseVisualStyleBackColor = true;
            // 
            // tbJavni
            // 
            this.tbJavni.Location = new System.Drawing.Point(83, 657);
            this.tbJavni.Name = "tbJavni";
            this.tbJavni.Size = new System.Drawing.Size(419, 20);
            this.tbJavni.TabIndex = 2;
            // 
            // lblJavni
            // 
            this.lblJavni.AutoSize = true;
            this.lblJavni.Location = new System.Drawing.Point(12, 660);
            this.lblJavni.Name = "lblJavni";
            this.lblJavni.Size = new System.Drawing.Size(57, 13);
            this.lblJavni.TabIndex = 3;
            this.lblJavni.Text = "Javni ključ";
            // 
            // btnJavniUcitaj
            // 
            this.btnJavniUcitaj.Location = new System.Drawing.Point(517, 655);
            this.btnJavniUcitaj.Name = "btnJavniUcitaj";
            this.btnJavniUcitaj.Size = new System.Drawing.Size(130, 23);
            this.btnJavniUcitaj.TabIndex = 4;
            this.btnJavniUcitaj.Text = "Učitaj [ javni_kljuc.txt ]";
            this.btnJavniUcitaj.UseVisualStyleBackColor = true;
            // 
            // btnJavniSpremi
            // 
            this.btnJavniSpremi.Location = new System.Drawing.Point(656, 655);
            this.btnJavniSpremi.Name = "btnJavniSpremi";
            this.btnJavniSpremi.Size = new System.Drawing.Size(145, 23);
            this.btnJavniSpremi.TabIndex = 4;
            this.btnJavniSpremi.Text = "Spremi [ javni_kljuc.txt ]";
            this.btnJavniSpremi.UseVisualStyleBackColor = true;
            // 
            // tbPrivatni
            // 
            this.tbPrivatni.Location = new System.Drawing.Point(83, 686);
            this.tbPrivatni.Name = "tbPrivatni";
            this.tbPrivatni.Size = new System.Drawing.Size(419, 20);
            this.tbPrivatni.TabIndex = 2;
            // 
            // lblPrivatni
            // 
            this.lblPrivatni.AutoSize = true;
            this.lblPrivatni.Location = new System.Drawing.Point(12, 689);
            this.lblPrivatni.Name = "lblPrivatni";
            this.lblPrivatni.Size = new System.Drawing.Size(67, 13);
            this.lblPrivatni.TabIndex = 3;
            this.lblPrivatni.Text = "Privatni ključ";
            // 
            // btnPrivatniUcitaj
            // 
            this.btnPrivatniUcitaj.Location = new System.Drawing.Point(517, 684);
            this.btnPrivatniUcitaj.Name = "btnPrivatniUcitaj";
            this.btnPrivatniUcitaj.Size = new System.Drawing.Size(130, 23);
            this.btnPrivatniUcitaj.TabIndex = 4;
            this.btnPrivatniUcitaj.Text = "Učitaj [ privatni_kljuc.txt ]";
            this.btnPrivatniUcitaj.UseVisualStyleBackColor = true;
            // 
            // btnPrivatniSpremi
            // 
            this.btnPrivatniSpremi.Location = new System.Drawing.Point(656, 684);
            this.btnPrivatniSpremi.Name = "btnPrivatniSpremi";
            this.btnPrivatniSpremi.Size = new System.Drawing.Size(145, 23);
            this.btnPrivatniSpremi.TabIndex = 4;
            this.btnPrivatniSpremi.Text = "Spremi [ privatni_kljuc.txt ]";
            this.btnPrivatniSpremi.UseVisualStyleBackColor = true;
            // 
            // tbSazetak
            // 
            this.tbSazetak.Location = new System.Drawing.Point(80, 712);
            this.tbSazetak.Name = "tbSazetak";
            this.tbSazetak.Size = new System.Drawing.Size(419, 20);
            this.tbSazetak.TabIndex = 2;
            // 
            // lblSazetak
            // 
            this.lblSazetak.AutoSize = true;
            this.lblSazetak.Location = new System.Drawing.Point(12, 715);
            this.lblSazetak.Name = "lblSazetak";
            this.lblSazetak.Size = new System.Drawing.Size(46, 13);
            this.lblSazetak.TabIndex = 3;
            this.lblSazetak.Text = "Sažetak";
            // 
            // rbCrypt
            // 
            this.rbCrypt.AutoSize = true;
            this.rbCrypt.Location = new System.Drawing.Point(813, 636);
            this.rbCrypt.Name = "rbCrypt";
            this.rbCrypt.Size = new System.Drawing.Size(71, 17);
            this.rbCrypt.TabIndex = 5;
            this.rbCrypt.Text = "Kriptiranje";
            this.rbCrypt.UseVisualStyleBackColor = true;
            this.rbCrypt.CheckedChanged += new System.EventHandler(this.rbCrypt_CheckedChanged);
            // 
            // rbDecrypt
            // 
            this.rbDecrypt.AutoSize = true;
            this.rbDecrypt.Location = new System.Drawing.Point(813, 659);
            this.rbDecrypt.Name = "rbDecrypt";
            this.rbDecrypt.Size = new System.Drawing.Size(84, 17);
            this.rbDecrypt.TabIndex = 5;
            this.rbDecrypt.Text = "Dekriptiranje";
            this.rbDecrypt.UseVisualStyleBackColor = true;
            this.rbDecrypt.CheckedChanged += new System.EventHandler(this.rbDecrypt_CheckedChanged);
            // 
            // btnPokreni
            // 
            this.btnPokreni.Location = new System.Drawing.Point(917, 627);
            this.btnPokreni.Name = "btnPokreni";
            this.btnPokreni.Size = new System.Drawing.Size(76, 104);
            this.btnPokreni.TabIndex = 4;
            this.btnPokreni.Text = "POKRENI";
            this.btnPokreni.UseVisualStyleBackColor = true;
            // 
            // btnOriginalSpremi
            // 
            this.btnOriginalSpremi.Location = new System.Drawing.Point(399, 571);
            this.btnOriginalSpremi.Name = "btnOriginalSpremi";
            this.btnOriginalSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnOriginalSpremi.TabIndex = 1;
            this.btnOriginalSpremi.Text = "Spremi";
            this.btnOriginalSpremi.UseVisualStyleBackColor = true;
            // 
            // btnCryptoSpremi
            // 
            this.btnCryptoSpremi.Location = new System.Drawing.Point(399, 571);
            this.btnCryptoSpremi.Name = "btnCryptoSpremi";
            this.btnCryptoSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnCryptoSpremi.TabIndex = 1;
            this.btnCryptoSpremi.Text = "Spremi";
            this.btnCryptoSpremi.UseVisualStyleBackColor = true;
            // 
            // btnOriginalOtvori
            // 
            this.btnOriginalOtvori.Location = new System.Drawing.Point(318, 571);
            this.btnOriginalOtvori.Name = "btnOriginalOtvori";
            this.btnOriginalOtvori.Size = new System.Drawing.Size(75, 23);
            this.btnOriginalOtvori.TabIndex = 1;
            this.btnOriginalOtvori.Text = "Otvori";
            this.btnOriginalOtvori.UseVisualStyleBackColor = true;
            // 
            // btnSazetakSpremi
            // 
            this.btnSazetakSpremi.Location = new System.Drawing.Point(656, 710);
            this.btnSazetakSpremi.Name = "btnSazetakSpremi";
            this.btnSazetakSpremi.Size = new System.Drawing.Size(145, 23);
            this.btnSazetakSpremi.TabIndex = 4;
            this.btnSazetakSpremi.Text = "Spremi [ sazetak.txt ]";
            this.btnSazetakSpremi.UseVisualStyleBackColor = true;
            // 
            // btnSazetakUcitaj
            // 
            this.btnSazetakUcitaj.Location = new System.Drawing.Point(517, 710);
            this.btnSazetakUcitaj.Name = "btnSazetakUcitaj";
            this.btnSazetakUcitaj.Size = new System.Drawing.Size(130, 23);
            this.btnSazetakUcitaj.TabIndex = 4;
            this.btnSazetakUcitaj.Text = "Učitaj [ sazetak.txt ]";
            this.btnSazetakUcitaj.UseVisualStyleBackColor = true;
            // 
            // rbSazetakKreiraj
            // 
            this.rbSazetakKreiraj.AutoSize = true;
            this.rbSazetakKreiraj.Location = new System.Drawing.Point(813, 682);
            this.rbSazetakKreiraj.Name = "rbSazetakKreiraj";
            this.rbSazetakKreiraj.Size = new System.Drawing.Size(94, 17);
            this.rbSazetakKreiraj.TabIndex = 5;
            this.rbSazetakKreiraj.Text = "Kreiraj sažetak";
            this.rbSazetakKreiraj.UseVisualStyleBackColor = true;
            this.rbSazetakKreiraj.CheckedChanged += new System.EventHandler(this.rbDecrypt_CheckedChanged);
            // 
            // rbSazetakProvjeri
            // 
            this.rbSazetakProvjeri.AutoSize = true;
            this.rbSazetakProvjeri.Location = new System.Drawing.Point(813, 705);
            this.rbSazetakProvjeri.Name = "rbSazetakProvjeri";
            this.rbSazetakProvjeri.Size = new System.Drawing.Size(100, 17);
            this.rbSazetakProvjeri.TabIndex = 5;
            this.rbSazetakProvjeri.Text = "Provjeri sažetak";
            this.rbSazetakProvjeri.UseVisualStyleBackColor = true;
            this.rbSazetakProvjeri.CheckedChanged += new System.EventHandler(this.rbDecrypt_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 743);
            this.Controls.Add(this.rbSazetakProvjeri);
            this.Controls.Add(this.rbSazetakKreiraj);
            this.Controls.Add(this.btnPokreni);
            this.Controls.Add(this.rbDecrypt);
            this.Controls.Add(this.rbCrypt);
            this.Controls.Add(this.btnSazetakSpremi);
            this.Controls.Add(this.btnPrivatniSpremi);
            this.Controls.Add(this.btnSazetakUcitaj);
            this.Controls.Add(this.btnPrivatniUcitaj);
            this.Controls.Add(this.btnJavniSpremi);
            this.Controls.Add(this.btnJavniUcitaj);
            this.Controls.Add(this.lblSazetak);
            this.Controls.Add(this.lblPrivatni);
            this.Controls.Add(this.btnTajniSpremi);
            this.Controls.Add(this.lblJavni);
            this.Controls.Add(this.tbSazetak);
            this.Controls.Add(this.tbPrivatni);
            this.Controls.Add(this.btnTajniUcitaj);
            this.Controls.Add(this.tbJavni);
            this.Controls.Add(this.lblTajni);
            this.Controls.Add(this.tbTajni);
            this.Controls.Add(this.gbCrypro);
            this.Controls.Add(this.gbOriginal);
            this.MaximumSize = new System.Drawing.Size(1024, 781);
            this.MinimumSize = new System.Drawing.Size(1024, 781);
            this.Name = "Form1";
            this.Text = "Cryptography";
            this.gbOriginal.ResumeLayout(false);
            this.gbCrypro.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOriginal;
        private System.Windows.Forms.RichTextBox tbCrypto;
        private System.Windows.Forms.GroupBox gbCrypro;
        private System.Windows.Forms.RichTextBox tbOriginal;
        private System.Windows.Forms.TextBox tbTajni;
        private System.Windows.Forms.Label lblTajni;
        private System.Windows.Forms.Button btnTajniUcitaj;
        private System.Windows.Forms.Button btnTajniSpremi;
        private System.Windows.Forms.TextBox tbJavni;
        private System.Windows.Forms.Label lblJavni;
        private System.Windows.Forms.Button btnJavniUcitaj;
        private System.Windows.Forms.Button btnJavniSpremi;
        private System.Windows.Forms.TextBox tbPrivatni;
        private System.Windows.Forms.Label lblPrivatni;
        private System.Windows.Forms.Button btnPrivatniUcitaj;
        private System.Windows.Forms.Button btnPrivatniSpremi;
        private System.Windows.Forms.TextBox tbSazetak;
        private System.Windows.Forms.Label lblSazetak;
        private System.Windows.Forms.RadioButton rbCrypt;
        private System.Windows.Forms.RadioButton rbDecrypt;
        private System.Windows.Forms.Button btnPokreni;
        private System.Windows.Forms.Button btnOriginalSpremi;
        private System.Windows.Forms.Button btnOriginalOtvori;
        private System.Windows.Forms.Button btnCryptoSpremi;
        private System.Windows.Forms.Button btnSazetakSpremi;
        private System.Windows.Forms.Button btnSazetakUcitaj;
        private System.Windows.Forms.RadioButton rbSazetakKreiraj;
        private System.Windows.Forms.RadioButton rbSazetakProvjeri;
    }
}

