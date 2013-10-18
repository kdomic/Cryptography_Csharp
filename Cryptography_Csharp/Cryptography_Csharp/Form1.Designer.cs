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
            this.tbOriginal = new System.Windows.Forms.TextBox();
            this.btnOriginalUcitaj = new System.Windows.Forms.Button();
            this.btnOriginalSpremi = new System.Windows.Forms.Button();
            this.gbCrypro = new System.Windows.Forms.GroupBox();
            this.tbCrypto = new System.Windows.Forms.TextBox();
            this.btnCryptoSpremi = new System.Windows.Forms.Button();
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
            this.btnSazetakSpremi = new System.Windows.Forms.Button();
            this.btnSazetakUcitaj = new System.Windows.Forms.Button();
            this.rbSazetakKreiraj = new System.Windows.Forms.RadioButton();
            this.rbSazetakProvjeri = new System.Windows.Forms.RadioButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.sbLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.btnCryptoUcitaj = new System.Windows.Forms.Button();
            this.gbOriginal.SuspendLayout();
            this.gbCrypro.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOriginal
            // 
            this.gbOriginal.Controls.Add(this.tbOriginal);
            this.gbOriginal.Controls.Add(this.btnOriginalUcitaj);
            this.gbOriginal.Controls.Add(this.btnOriginalSpremi);
            this.gbOriginal.Location = new System.Drawing.Point(12, 12);
            this.gbOriginal.Name = "gbOriginal";
            this.gbOriginal.Size = new System.Drawing.Size(480, 593);
            this.gbOriginal.TabIndex = 1;
            this.gbOriginal.TabStop = false;
            this.gbOriginal.Text = "Originalni tekst";
            // 
            // tbOriginal
            // 
            this.tbOriginal.Location = new System.Drawing.Point(6, 16);
            this.tbOriginal.Multiline = true;
            this.tbOriginal.Name = "tbOriginal";
            this.tbOriginal.Size = new System.Drawing.Size(468, 540);
            this.tbOriginal.TabIndex = 2;
            // 
            // btnOriginalUcitaj
            // 
            this.btnOriginalUcitaj.Location = new System.Drawing.Point(6, 562);
            this.btnOriginalUcitaj.Name = "btnOriginalUcitaj";
            this.btnOriginalUcitaj.Size = new System.Drawing.Size(150, 23);
            this.btnOriginalUcitaj.TabIndex = 1;
            this.btnOriginalUcitaj.Text = "Učitaj [ original.txt ]";
            this.btnOriginalUcitaj.UseVisualStyleBackColor = true;
            this.btnOriginalUcitaj.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // btnOriginalSpremi
            // 
            this.btnOriginalSpremi.Location = new System.Drawing.Point(399, 562);
            this.btnOriginalSpremi.Name = "btnOriginalSpremi";
            this.btnOriginalSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnOriginalSpremi.TabIndex = 1;
            this.btnOriginalSpremi.Text = "Spremi";
            this.btnOriginalSpremi.UseVisualStyleBackColor = true;
            this.btnOriginalSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // gbCrypro
            // 
            this.gbCrypro.Controls.Add(this.tbCrypto);
            this.gbCrypro.Controls.Add(this.btnCryptoUcitaj);
            this.gbCrypro.Controls.Add(this.btnCryptoSpremi);
            this.gbCrypro.Location = new System.Drawing.Point(516, 12);
            this.gbCrypro.Name = "gbCrypro";
            this.gbCrypro.Size = new System.Drawing.Size(480, 591);
            this.gbCrypro.TabIndex = 1;
            this.gbCrypro.TabStop = false;
            this.gbCrypro.Text = "Kriptirani tekst";
            // 
            // tbCrypto
            // 
            this.tbCrypto.Location = new System.Drawing.Point(6, 16);
            this.tbCrypto.Multiline = true;
            this.tbCrypto.Name = "tbCrypto";
            this.tbCrypto.Size = new System.Drawing.Size(468, 540);
            this.tbCrypto.TabIndex = 2;
            // 
            // btnCryptoSpremi
            // 
            this.btnCryptoSpremi.Location = new System.Drawing.Point(399, 562);
            this.btnCryptoSpremi.Name = "btnCryptoSpremi";
            this.btnCryptoSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnCryptoSpremi.TabIndex = 1;
            this.btnCryptoSpremi.Text = "Spremi";
            this.btnCryptoSpremi.UseVisualStyleBackColor = true;
            this.btnCryptoSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // tbTajni
            // 
            this.tbTajni.Location = new System.Drawing.Point(83, 611);
            this.tbTajni.Name = "tbTajni";
            this.tbTajni.Size = new System.Drawing.Size(419, 20);
            this.tbTajni.TabIndex = 2;
            // 
            // lblTajni
            // 
            this.lblTajni.AutoSize = true;
            this.lblTajni.Location = new System.Drawing.Point(12, 614);
            this.lblTajni.Name = "lblTajni";
            this.lblTajni.Size = new System.Drawing.Size(55, 13);
            this.lblTajni.TabIndex = 3;
            this.lblTajni.Text = "Tajni ključ";
            // 
            // btnTajniUcitaj
            // 
            this.btnTajniUcitaj.Location = new System.Drawing.Point(517, 609);
            this.btnTajniUcitaj.Name = "btnTajniUcitaj";
            this.btnTajniUcitaj.Size = new System.Drawing.Size(130, 23);
            this.btnTajniUcitaj.TabIndex = 4;
            this.btnTajniUcitaj.Text = "Učitaj [ tajni_kljuc.txt ]";
            this.btnTajniUcitaj.UseVisualStyleBackColor = true;
            this.btnTajniUcitaj.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // btnTajniSpremi
            // 
            this.btnTajniSpremi.Location = new System.Drawing.Point(656, 609);
            this.btnTajniSpremi.Name = "btnTajniSpremi";
            this.btnTajniSpremi.Size = new System.Drawing.Size(145, 23);
            this.btnTajniSpremi.TabIndex = 4;
            this.btnTajniSpremi.Text = "Spremi [ tajni_kljuc.txt ]";
            this.btnTajniSpremi.UseVisualStyleBackColor = true;
            this.btnTajniSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // tbJavni
            // 
            this.tbJavni.Location = new System.Drawing.Point(83, 640);
            this.tbJavni.Name = "tbJavni";
            this.tbJavni.Size = new System.Drawing.Size(419, 20);
            this.tbJavni.TabIndex = 2;
            // 
            // lblJavni
            // 
            this.lblJavni.AutoSize = true;
            this.lblJavni.Location = new System.Drawing.Point(12, 643);
            this.lblJavni.Name = "lblJavni";
            this.lblJavni.Size = new System.Drawing.Size(57, 13);
            this.lblJavni.TabIndex = 3;
            this.lblJavni.Text = "Javni ključ";
            // 
            // btnJavniUcitaj
            // 
            this.btnJavniUcitaj.Location = new System.Drawing.Point(517, 638);
            this.btnJavniUcitaj.Name = "btnJavniUcitaj";
            this.btnJavniUcitaj.Size = new System.Drawing.Size(130, 23);
            this.btnJavniUcitaj.TabIndex = 4;
            this.btnJavniUcitaj.Text = "Učitaj [ javni_kljuc.txt ]";
            this.btnJavniUcitaj.UseVisualStyleBackColor = true;
            this.btnJavniUcitaj.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // btnJavniSpremi
            // 
            this.btnJavniSpremi.Location = new System.Drawing.Point(656, 638);
            this.btnJavniSpremi.Name = "btnJavniSpremi";
            this.btnJavniSpremi.Size = new System.Drawing.Size(145, 23);
            this.btnJavniSpremi.TabIndex = 4;
            this.btnJavniSpremi.Text = "Spremi [ javni_kljuc.txt ]";
            this.btnJavniSpremi.UseVisualStyleBackColor = true;
            this.btnJavniSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // tbPrivatni
            // 
            this.tbPrivatni.Location = new System.Drawing.Point(83, 669);
            this.tbPrivatni.Name = "tbPrivatni";
            this.tbPrivatni.Size = new System.Drawing.Size(419, 20);
            this.tbPrivatni.TabIndex = 2;
            // 
            // lblPrivatni
            // 
            this.lblPrivatni.AutoSize = true;
            this.lblPrivatni.Location = new System.Drawing.Point(12, 672);
            this.lblPrivatni.Name = "lblPrivatni";
            this.lblPrivatni.Size = new System.Drawing.Size(67, 13);
            this.lblPrivatni.TabIndex = 3;
            this.lblPrivatni.Text = "Privatni ključ";
            // 
            // btnPrivatniUcitaj
            // 
            this.btnPrivatniUcitaj.Location = new System.Drawing.Point(517, 667);
            this.btnPrivatniUcitaj.Name = "btnPrivatniUcitaj";
            this.btnPrivatniUcitaj.Size = new System.Drawing.Size(130, 23);
            this.btnPrivatniUcitaj.TabIndex = 4;
            this.btnPrivatniUcitaj.Text = "Učitaj [ privatni_kljuc.txt ]";
            this.btnPrivatniUcitaj.UseVisualStyleBackColor = true;
            this.btnPrivatniUcitaj.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // btnPrivatniSpremi
            // 
            this.btnPrivatniSpremi.Location = new System.Drawing.Point(656, 667);
            this.btnPrivatniSpremi.Name = "btnPrivatniSpremi";
            this.btnPrivatniSpremi.Size = new System.Drawing.Size(145, 23);
            this.btnPrivatniSpremi.TabIndex = 4;
            this.btnPrivatniSpremi.Text = "Spremi [ privatni_kljuc.txt ]";
            this.btnPrivatniSpremi.UseVisualStyleBackColor = true;
            this.btnPrivatniSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // tbSazetak
            // 
            this.tbSazetak.Location = new System.Drawing.Point(83, 696);
            this.tbSazetak.Name = "tbSazetak";
            this.tbSazetak.Size = new System.Drawing.Size(419, 20);
            this.tbSazetak.TabIndex = 2;
            // 
            // lblSazetak
            // 
            this.lblSazetak.AutoSize = true;
            this.lblSazetak.Location = new System.Drawing.Point(15, 698);
            this.lblSazetak.Name = "lblSazetak";
            this.lblSazetak.Size = new System.Drawing.Size(46, 13);
            this.lblSazetak.TabIndex = 3;
            this.lblSazetak.Text = "Sažetak";
            // 
            // rbCrypt
            // 
            this.rbCrypt.AutoSize = true;
            this.rbCrypt.Location = new System.Drawing.Point(813, 619);
            this.rbCrypt.Name = "rbCrypt";
            this.rbCrypt.Size = new System.Drawing.Size(71, 17);
            this.rbCrypt.TabIndex = 5;
            this.rbCrypt.Text = "Kriptiranje";
            this.rbCrypt.UseVisualStyleBackColor = true;
            // 
            // rbDecrypt
            // 
            this.rbDecrypt.AutoSize = true;
            this.rbDecrypt.Location = new System.Drawing.Point(813, 642);
            this.rbDecrypt.Name = "rbDecrypt";
            this.rbDecrypt.Size = new System.Drawing.Size(84, 17);
            this.rbDecrypt.TabIndex = 5;
            this.rbDecrypt.Text = "Dekriptiranje";
            this.rbDecrypt.UseVisualStyleBackColor = true;
            // 
            // btnPokreni
            // 
            this.btnPokreni.Location = new System.Drawing.Point(917, 610);
            this.btnPokreni.Name = "btnPokreni";
            this.btnPokreni.Size = new System.Drawing.Size(76, 104);
            this.btnPokreni.TabIndex = 4;
            this.btnPokreni.Text = "POKRENI";
            this.btnPokreni.UseVisualStyleBackColor = true;
            this.btnPokreni.Click += new System.EventHandler(this.btnPokreni_Click);
            // 
            // btnSazetakSpremi
            // 
            this.btnSazetakSpremi.Location = new System.Drawing.Point(656, 693);
            this.btnSazetakSpremi.Name = "btnSazetakSpremi";
            this.btnSazetakSpremi.Size = new System.Drawing.Size(145, 23);
            this.btnSazetakSpremi.TabIndex = 4;
            this.btnSazetakSpremi.Text = "Spremi [ sazetak.txt ]";
            this.btnSazetakSpremi.UseVisualStyleBackColor = true;
            this.btnSazetakSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnSazetakUcitaj
            // 
            this.btnSazetakUcitaj.Location = new System.Drawing.Point(517, 693);
            this.btnSazetakUcitaj.Name = "btnSazetakUcitaj";
            this.btnSazetakUcitaj.Size = new System.Drawing.Size(130, 23);
            this.btnSazetakUcitaj.TabIndex = 4;
            this.btnSazetakUcitaj.Text = "Učitaj [ sazetak.txt ]";
            this.btnSazetakUcitaj.UseVisualStyleBackColor = true;
            this.btnSazetakUcitaj.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // rbSazetakKreiraj
            // 
            this.rbSazetakKreiraj.AutoSize = true;
            this.rbSazetakKreiraj.Location = new System.Drawing.Point(813, 665);
            this.rbSazetakKreiraj.Name = "rbSazetakKreiraj";
            this.rbSazetakKreiraj.Size = new System.Drawing.Size(94, 17);
            this.rbSazetakKreiraj.TabIndex = 5;
            this.rbSazetakKreiraj.Text = "Kreiraj sažetak";
            this.rbSazetakKreiraj.UseVisualStyleBackColor = true;
            // 
            // rbSazetakProvjeri
            // 
            this.rbSazetakProvjeri.AutoSize = true;
            this.rbSazetakProvjeri.Location = new System.Drawing.Point(813, 688);
            this.rbSazetakProvjeri.Name = "rbSazetakProvjeri";
            this.rbSazetakProvjeri.Size = new System.Drawing.Size(100, 17);
            this.rbSazetakProvjeri.TabIndex = 5;
            this.rbSazetakProvjeri.Text = "Provjeri sažetak";
            this.rbSazetakProvjeri.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbLabel,
            this.sbProgress});
            this.statusStrip.Location = new System.Drawing.Point(0, 721);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip.TabIndex = 6;
            this.statusStrip.Text = "statusStrip1";
            // 
            // sbLabel
            // 
            this.sbLabel.Name = "sbLabel";
            this.sbLabel.Size = new System.Drawing.Size(118, 17);
            this.sbLabel.Text = "toolStripStatusLabel1";
            // 
            // sbProgress
            // 
            this.sbProgress.Name = "sbProgress";
            this.sbProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // btnCryptoUcitaj
            // 
            this.btnCryptoUcitaj.Location = new System.Drawing.Point(6, 562);
            this.btnCryptoUcitaj.Name = "btnCryptoUcitaj";
            this.btnCryptoUcitaj.Size = new System.Drawing.Size(150, 23);
            this.btnCryptoUcitaj.TabIndex = 1;
            this.btnCryptoUcitaj.Text = "Učitaj [ crypto.txt ]";
            this.btnCryptoUcitaj.UseVisualStyleBackColor = true;
            this.btnCryptoUcitaj.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 743);
            this.Controls.Add(this.statusStrip);
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
            this.gbOriginal.PerformLayout();
            this.gbCrypro.ResumeLayout(false);
            this.gbCrypro.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOriginal;
        private System.Windows.Forms.GroupBox gbCrypro;
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
        private System.Windows.Forms.Button btnOriginalUcitaj;
        private System.Windows.Forms.Button btnCryptoSpremi;
        private System.Windows.Forms.Button btnSazetakSpremi;
        private System.Windows.Forms.Button btnSazetakUcitaj;
        private System.Windows.Forms.RadioButton rbSazetakKreiraj;
        private System.Windows.Forms.RadioButton rbSazetakProvjeri;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel sbLabel;
        private System.Windows.Forms.ToolStripProgressBar sbProgress;
        private System.Windows.Forms.TextBox tbOriginal;
        private System.Windows.Forms.TextBox tbCrypto;
        private System.Windows.Forms.Button btnCryptoUcitaj;
    }
}

