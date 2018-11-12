namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonEsporta = new System.Windows.Forms.Button();
            this.buttonInserisci = new System.Windows.Forms.Button();
            this.buttonImporta = new System.Windows.Forms.Button();
            this.listValoriArray = new System.Windows.Forms.ListBox();
            this.textBoxValori = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonEsporta
            // 
            this.buttonEsporta.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEsporta.Location = new System.Drawing.Point(465, 195);
            this.buttonEsporta.Name = "buttonEsporta";
            this.buttonEsporta.Size = new System.Drawing.Size(75, 37);
            this.buttonEsporta.TabIndex = 0;
            this.buttonEsporta.Text = "Esporta";
            this.buttonEsporta.UseVisualStyleBackColor = true;
            // 
            // buttonInserisci
            // 
            this.buttonInserisci.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInserisci.Location = new System.Drawing.Point(47, 195);
            this.buttonInserisci.Name = "buttonInserisci";
            this.buttonInserisci.Size = new System.Drawing.Size(102, 37);
            this.buttonInserisci.TabIndex = 1;
            this.buttonInserisci.Text = "Inserisci";
            this.buttonInserisci.UseVisualStyleBackColor = true;
            
            // 
            // buttonImporta
            // 
            this.buttonImporta.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImporta.Location = new System.Drawing.Point(246, 195);
            this.buttonImporta.Name = "buttonImporta";
            this.buttonImporta.Size = new System.Drawing.Size(102, 37);
            this.buttonImporta.TabIndex = 2;
            this.buttonImporta.Text = "Importa";
            this.buttonImporta.UseVisualStyleBackColor = true;
            
            // 
            // listValoriArray
            // 
            this.listValoriArray.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listValoriArray.FormattingEnabled = true;
            this.listValoriArray.ItemHeight = 23;
            this.listValoriArray.Location = new System.Drawing.Point(209, 24);
            this.listValoriArray.Name = "listValoriArray";
            this.listValoriArray.Size = new System.Drawing.Size(159, 73);
            this.listValoriArray.TabIndex = 3;
            // 
            // textBoxValori
            // 
            this.textBoxValori.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValori.Location = new System.Drawing.Point(190, 129);
            this.textBoxValori.Name = "textBoxValori";
            this.textBoxValori.Size = new System.Drawing.Size(187, 30);
            this.textBoxValori.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 262);
            this.Controls.Add(this.textBoxValori);
            this.Controls.Add(this.listValoriArray);
            this.Controls.Add(this.buttonImporta);
            this.Controls.Add(this.buttonInserisci);
            this.Controls.Add(this.buttonEsporta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEsporta;
        private System.Windows.Forms.Button buttonInserisci;
        private System.Windows.Forms.Button buttonImporta;
        private System.Windows.Forms.ListBox listValoriArray;
        private System.Windows.Forms.TextBox textBoxValori;
    }
}

