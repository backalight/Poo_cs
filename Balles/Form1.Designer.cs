namespace Balles
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBall1 = new Balles.PictureBall();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBall1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBall1
            // 
            this.pictureBall1.Image = global::Balles.Properties.Resources.hypno;
            this.pictureBall1.Location = new System.Drawing.Point(118, 69);
            this.pictureBall1.Name = "pictureBall1";
            this.pictureBall1.Size = new System.Drawing.Size(241, 209);
            this.pictureBall1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBall1.TabIndex = 0;
            this.pictureBall1.TabStop = false;
            this.pictureBall1.VitesseX = 5;
            this.pictureBall1.VitesseY = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBall1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBall1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }





        #endregion

        private PictureBall pictureBall1;
    }
}

