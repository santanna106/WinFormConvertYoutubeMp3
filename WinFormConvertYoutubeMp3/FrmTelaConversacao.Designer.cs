namespace WinFormConvertYoutubeMp3
{
    partial class FrmTelaConversacao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbUrl = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblUrl = new System.Windows.Forms.Label();
            this.btnSelecaoPasta = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txbPastaDestino = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbUrl
            // 
            this.txbUrl.Location = new System.Drawing.Point(119, 53);
            this.txbUrl.Margin = new System.Windows.Forms.Padding(2);
            this.txbUrl.Name = "txbUrl";
            this.txbUrl.Size = new System.Drawing.Size(322, 20);
            this.txbUrl.TabIndex = 0;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(194, 200);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(2);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(106, 40);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Converter";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(87, 55);
            this.lblUrl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(21, 13);
            this.lblUrl.TabIndex = 2;
            this.lblUrl.Text = "url:";
            // 
            // btnSelecaoPasta
            // 
            this.btnSelecaoPasta.Location = new System.Drawing.Point(90, 90);
            this.btnSelecaoPasta.Name = "btnSelecaoPasta";
            this.btnSelecaoPasta.Size = new System.Drawing.Size(23, 23);
            this.btnSelecaoPasta.TabIndex = 3;
            this.btnSelecaoPasta.Text = "...";
            this.btnSelecaoPasta.UseVisualStyleBackColor = true;
            this.btnSelecaoPasta.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txbPastaDestino
            // 
            this.txbPastaDestino.Location = new System.Drawing.Point(119, 90);
            this.txbPastaDestino.Name = "txbPastaDestino";
            this.txbPastaDestino.Size = new System.Drawing.Size(322, 20);
            this.txbPastaDestino.TabIndex = 4;
            // 
            // FrmTelaConversacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.txbPastaDestino);
            this.Controls.Add(this.btnSelecaoPasta);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txbUrl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmTelaConversacao";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbUrl;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Button btnSelecaoPasta;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txbPastaDestino;
    }
}

