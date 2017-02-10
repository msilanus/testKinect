namespace testKinect1
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
            this.pbKinectVideo = new System.Windows.Forms.PictureBox();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblZ = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbKinectVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbKinectVideo
            // 
            this.pbKinectVideo.Location = new System.Drawing.Point(12, 81);
            this.pbKinectVideo.Name = "pbKinectVideo";
            this.pbKinectVideo.Size = new System.Drawing.Size(1208, 492);
            this.pbKinectVideo.TabIndex = 0;
            this.pbKinectVideo.TabStop = false;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(53, 32);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(25, 17);
            this.lblX.TabIndex = 1;
            this.lblX.Text = "X=";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(433, 32);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(25, 17);
            this.lblY.TabIndex = 2;
            this.lblY.Text = "Y=";
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Location = new System.Drawing.Point(763, 32);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(25, 17);
            this.lblZ.TabIndex = 3;
            this.lblZ.Text = "Z=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 621);
            this.Controls.Add(this.lblZ);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.pbKinectVideo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbKinectVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbKinectVideo;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblZ;
    }
}

