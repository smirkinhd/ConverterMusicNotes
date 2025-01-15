namespace AudioDecoder
{
    partial class MainForm
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
            this.selectAudioBtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.downloadTracksBtn = new System.Windows.Forms.Button();
            this.downloadMidiesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectAudioBtn
            // 
            this.selectAudioBtn.Location = new System.Drawing.Point(246, 46);
            this.selectAudioBtn.Name = "selectAudioBtn";
            this.selectAudioBtn.Size = new System.Drawing.Size(134, 39);
            this.selectAudioBtn.TabIndex = 0;
            this.selectAudioBtn.Text = "Выбрать аудио";
            this.selectAudioBtn.UseVisualStyleBackColor = true;
            this.selectAudioBtn.Click += new System.EventHandler(this.selectAudioBtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(62, 108);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(494, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // downloadTracksBtn
            // 
            this.downloadTracksBtn.Location = new System.Drawing.Point(62, 167);
            this.downloadTracksBtn.Name = "downloadTracksBtn";
            this.downloadTracksBtn.Size = new System.Drawing.Size(149, 33);
            this.downloadTracksBtn.TabIndex = 2;
            this.downloadTracksBtn.Text = "Скачать дорожки";
            this.downloadTracksBtn.UseVisualStyleBackColor = true;
            this.downloadTracksBtn.Click += new System.EventHandler(this.downloadTracksBtn_Click);
            // 
            // downloadMidiesBtn
            // 
            this.downloadMidiesBtn.Location = new System.Drawing.Point(407, 167);
            this.downloadMidiesBtn.Name = "downloadMidiesBtn";
            this.downloadMidiesBtn.Size = new System.Drawing.Size(149, 33);
            this.downloadMidiesBtn.TabIndex = 3;
            this.downloadMidiesBtn.Text = "Скачать табулатуры";
            this.downloadMidiesBtn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 271);
            this.Controls.Add(this.downloadMidiesBtn);
            this.Controls.Add(this.downloadTracksBtn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.selectAudioBtn);
            this.Name = "MainForm";
            this.Text = "Декодер аудио в музыкальные ноты";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button selectAudioBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button downloadTracksBtn;
        private System.Windows.Forms.Button downloadMidiesBtn;
    }
}

