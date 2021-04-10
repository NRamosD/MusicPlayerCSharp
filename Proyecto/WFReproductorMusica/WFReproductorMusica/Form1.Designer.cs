namespace WFReproductorMusica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelContent = new System.Windows.Forms.Panel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.gbVentanas = new System.Windows.Forms.GroupBox();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.rbMusic = new System.Windows.Forms.RadioButton();
            this.rbVideo = new System.Windows.Forms.RadioButton();
            this.PanelContent.SuspendLayout();
            this.gbVentanas.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelContent
            // 
            this.PanelContent.Controls.Add(this.contentPanel);
            this.PanelContent.Controls.Add(this.gbVentanas);
            this.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContent.Location = new System.Drawing.Point(0, 0);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(731, 495);
            this.PanelContent.TabIndex = 1;
            // 
            // contentPanel
            // 
            this.contentPanel.AutoSize = true;
            this.contentPanel.BackColor = System.Drawing.Color.Black;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(731, 439);
            this.contentPanel.TabIndex = 1;
            // 
            // gbVentanas
            // 
            this.gbVentanas.BackColor = System.Drawing.Color.Black;
            this.gbVentanas.Controls.Add(this.btnAyuda);
            this.gbVentanas.Controls.Add(this.rbMusic);
            this.gbVentanas.Controls.Add(this.rbVideo);
            this.gbVentanas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbVentanas.ForeColor = System.Drawing.Color.Black;
            this.gbVentanas.Location = new System.Drawing.Point(0, 439);
            this.gbVentanas.Name = "gbVentanas";
            this.gbVentanas.Size = new System.Drawing.Size(731, 56);
            this.gbVentanas.TabIndex = 3;
            this.gbVentanas.TabStop = false;
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackgroundImage = global::WFReproductorMusica.Properties.Resources.help_question_1566;
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAyuda.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Location = new System.Drawing.Point(696, 16);
            this.btnAyuda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(32, 37);
            this.btnAyuda.TabIndex = 3;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // rbMusic
            // 
            this.rbMusic.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbMusic.AutoSize = true;
            this.rbMusic.FlatAppearance.BorderSize = 0;
            this.rbMusic.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbMusic.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.rbMusic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMusic.ForeColor = System.Drawing.Color.White;
            this.rbMusic.Location = new System.Drawing.Point(18, 16);
            this.rbMusic.Name = "rbMusic";
            this.rbMusic.Size = new System.Drawing.Size(69, 30);
            this.rbMusic.TabIndex = 1;
            this.rbMusic.Text = "Música";
            this.rbMusic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbMusic.UseVisualStyleBackColor = true;
            this.rbMusic.CheckedChanged += new System.EventHandler(this.rbMusic_CheckedChanged_1);
            // 
            // rbVideo
            // 
            this.rbVideo.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbVideo.AutoSize = true;
            this.rbVideo.FlatAppearance.BorderSize = 0;
            this.rbVideo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbVideo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVideo.ForeColor = System.Drawing.Color.White;
            this.rbVideo.Location = new System.Drawing.Point(128, 17);
            this.rbVideo.Name = "rbVideo";
            this.rbVideo.Size = new System.Drawing.Size(60, 30);
            this.rbVideo.TabIndex = 2;
            this.rbVideo.TabStop = true;
            this.rbVideo.Text = "Video";
            this.rbVideo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbVideo.UseVisualStyleBackColor = true;
            this.rbVideo.CheckedChanged += new System.EventHandler(this.rbVideo_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 495);
            this.Controls.Add(this.PanelContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyMedia Player";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelContent.ResumeLayout(false);
            this.PanelContent.PerformLayout();
            this.gbVentanas.ResumeLayout(false);
            this.gbVentanas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelContent;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.RadioButton rbVideo;
        private System.Windows.Forms.GroupBox gbVentanas;
        private System.Windows.Forms.RadioButton rbMusic;
        private System.Windows.Forms.Button btnAyuda;
    }
}

