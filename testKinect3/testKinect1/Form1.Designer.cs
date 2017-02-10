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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblXcorr = new System.Windows.Forms.Label();
            this.lblYcorr = new System.Windows.Forms.Label();
            this.cbTracking = new System.Windows.Forms.CheckBox();
            this.lblHorsChamps = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbKinectVideo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbKinectVideo
            // 
            this.pbKinectVideo.Location = new System.Drawing.Point(2, 1);
            this.pbKinectVideo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbKinectVideo.Name = "pbKinectVideo";
            this.pbKinectVideo.Size = new System.Drawing.Size(640, 480);
            this.pbKinectVideo.TabIndex = 0;
            this.pbKinectVideo.TabStop = false;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(22, 28);
            this.lblX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(44, 29);
            this.lblX.TabIndex = 1;
            this.lblX.Text = "X=";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.Location = new System.Drawing.Point(22, 91);
            this.lblY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(43, 29);
            this.lblY.TabIndex = 2;
            this.lblY.Text = "Y=";
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZ.Location = new System.Drawing.Point(22, 155);
            this.lblZ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(41, 29);
            this.lblZ.TabIndex = 3;
            this.lblZ.Text = "Z=";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblZ);
            this.groupBox1.Controls.Add(this.lblX);
            this.groupBox1.Controls.Add(this.lblY);
            this.groupBox1.Location = new System.Drawing.Point(647, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 187);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main droite - Position brute";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblXcorr);
            this.groupBox2.Controls.Add(this.lblYcorr);
            this.groupBox2.Location = new System.Drawing.Point(647, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 187);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Main droite - Position corrigée";
            // 
            // lblXcorr
            // 
            this.lblXcorr.AutoSize = true;
            this.lblXcorr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXcorr.Location = new System.Drawing.Point(23, 49);
            this.lblXcorr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblXcorr.Name = "lblXcorr";
            this.lblXcorr.Size = new System.Drawing.Size(44, 29);
            this.lblXcorr.TabIndex = 1;
            this.lblXcorr.Text = "X=";
            // 
            // lblYcorr
            // 
            this.lblYcorr.AutoSize = true;
            this.lblYcorr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYcorr.Location = new System.Drawing.Point(23, 112);
            this.lblYcorr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYcorr.Name = "lblYcorr";
            this.lblYcorr.Size = new System.Drawing.Size(43, 29);
            this.lblYcorr.TabIndex = 2;
            this.lblYcorr.Text = "Y=";
            // 
            // cbTracking
            // 
            this.cbTracking.AutoSize = true;
            this.cbTracking.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTracking.Location = new System.Drawing.Point(674, 398);
            this.cbTracking.Name = "cbTracking";
            this.cbTracking.Size = new System.Drawing.Size(220, 33);
            this.cbTracking.TabIndex = 6;
            this.cbTracking.Text = "Activer le tracking";
            this.cbTracking.UseVisualStyleBackColor = true;
            // 
            // lblHorsChamps
            // 
            this.lblHorsChamps.AutoSize = true;
            this.lblHorsChamps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHorsChamps.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorsChamps.ForeColor = System.Drawing.Color.Red;
            this.lblHorsChamps.Location = new System.Drawing.Point(668, 445);
            this.lblHorsChamps.Name = "lblHorsChamps";
            this.lblHorsChamps.Size = new System.Drawing.Size(249, 33);
            this.lblHorsChamps.TabIndex = 7;
            this.lblHorsChamps.Text = "HORS CHAMPS !!!";
            this.lblHorsChamps.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 485);
            this.Controls.Add(this.lblHorsChamps);
            this.Controls.Add(this.cbTracking);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbKinectVideo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Kinect - Tracking main droite";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbKinectVideo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbKinectVideo;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblXcorr;
        private System.Windows.Forms.Label lblYcorr;
        private System.Windows.Forms.CheckBox cbTracking;
        private System.Windows.Forms.Label lblHorsChamps;
    }
}

