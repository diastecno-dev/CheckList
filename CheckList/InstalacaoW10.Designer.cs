namespace CheckList
{
    partial class InstalacaoW10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstalacaoW10));
            this.chkOffice = new System.Windows.Forms.CheckBox();
            this.chkNavegador = new System.Windows.Forms.CheckBox();
            this.chkCodec = new System.Windows.Forms.CheckBox();
            this.chkAtivador = new System.Windows.Forms.CheckBox();
            this.chkWinrar = new System.Windows.Forms.CheckBox();
            this.chkInstalarTodos = new System.Windows.Forms.CheckBox();
            this.btnInstalar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorkerInstalacao = new System.ComponentModel.BackgroundWorker();
            this.pbLoadingOffice = new System.Windows.Forms.PictureBox();
            this.pbLoadingWinrar = new System.Windows.Forms.PictureBox();
            this.pbLoadingAtivador = new System.Windows.Forms.PictureBox();
            this.pbLoadingCodec = new System.Windows.Forms.PictureBox();
            this.pbLoadingNavegador = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingOffice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingWinrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingAtivador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingCodec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingNavegador)).BeginInit();
            this.SuspendLayout();
            // 
            // chkOffice
            // 
            this.chkOffice.AutoSize = true;
            this.chkOffice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOffice.Location = new System.Drawing.Point(264, 166);
            this.chkOffice.Name = "chkOffice";
            this.chkOffice.Size = new System.Drawing.Size(372, 35);
            this.chkOffice.TabIndex = 0;
            this.chkOffice.Text = "MICROSOFT OFFICE 2013";
            this.chkOffice.UseVisualStyleBackColor = true;
            this.chkOffice.CheckedChanged += new System.EventHandler(this.chkOffice_CheckedChanged);
            // 
            // chkNavegador
            // 
            this.chkNavegador.AutoSize = true;
            this.chkNavegador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkNavegador.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNavegador.Location = new System.Drawing.Point(264, 210);
            this.chkNavegador.Name = "chkNavegador";
            this.chkNavegador.Size = new System.Drawing.Size(278, 35);
            this.chkNavegador.TabIndex = 1;
            this.chkNavegador.Text = "GOOGLE CHROME";
            this.chkNavegador.UseVisualStyleBackColor = true;
            this.chkNavegador.CheckedChanged += new System.EventHandler(this.chkChrome_CheckedChanged);
            // 
            // chkCodec
            // 
            this.chkCodec.AutoSize = true;
            this.chkCodec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkCodec.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCodec.Location = new System.Drawing.Point(264, 254);
            this.chkCodec.Name = "chkCodec";
            this.chkCodec.Size = new System.Drawing.Size(224, 35);
            this.chkCodec.TabIndex = 2;
            this.chkCodec.Text = "K-LITE CODEC";
            this.chkCodec.UseVisualStyleBackColor = true;
            this.chkCodec.CheckedChanged += new System.EventHandler(this.chkCodec_CheckedChanged);
            // 
            // chkAtivador
            // 
            this.chkAtivador.AutoSize = true;
            this.chkAtivador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAtivador.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAtivador.Location = new System.Drawing.Point(264, 342);
            this.chkAtivador.Name = "chkAtivador";
            this.chkAtivador.Size = new System.Drawing.Size(173, 35);
            this.chkAtivador.TabIndex = 6;
            this.chkAtivador.Text = "ATIVADOR";
            this.chkAtivador.UseVisualStyleBackColor = true;
            this.chkAtivador.CheckedChanged += new System.EventHandler(this.chkAtivador_CheckedChanged);
            // 
            // chkWinrar
            // 
            this.chkWinrar.AutoSize = true;
            this.chkWinrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkWinrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWinrar.Location = new System.Drawing.Point(264, 298);
            this.chkWinrar.Name = "chkWinrar";
            this.chkWinrar.Size = new System.Drawing.Size(144, 35);
            this.chkWinrar.TabIndex = 5;
            this.chkWinrar.Text = "WINRAR";
            this.chkWinrar.UseVisualStyleBackColor = true;
            this.chkWinrar.CheckedChanged += new System.EventHandler(this.ChkWinrar_CheckedChanged);
            // 
            // chkInstalarTodos
            // 
            this.chkInstalarTodos.AutoSize = true;
            this.chkInstalarTodos.Location = new System.Drawing.Point(672, 569);
            this.chkInstalarTodos.Name = "chkInstalarTodos";
            this.chkInstalarTodos.Size = new System.Drawing.Size(89, 17);
            this.chkInstalarTodos.TabIndex = 20;
            this.chkInstalarTodos.Text = "Instalar todos";
            this.chkInstalarTodos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkInstalarTodos.UseVisualStyleBackColor = true;
            this.chkInstalarTodos.CheckedChanged += new System.EventHandler(this.ChkInstalarTodos_CheckedChanged);
            // 
            // btnInstalar
            // 
            this.btnInstalar.Location = new System.Drawing.Point(664, 537);
            this.btnInstalar.Name = "btnInstalar";
            this.btnInstalar.Size = new System.Drawing.Size(103, 25);
            this.btnInstalar.TabIndex = 19;
            this.btnInstalar.Text = "INSTALAR";
            this.btnInstalar.UseVisualStyleBackColor = true;
            this.btnInstalar.Click += new System.EventHandler(this.btnInstalar_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(256, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 84);
            this.label2.TabIndex = 22;
            this.label2.Text = "      WINDOWS 10/11";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundWorkerInstalacao
            // 
            this.backgroundWorkerInstalacao.WorkerReportsProgress = true;
            this.backgroundWorkerInstalacao.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerInstalacao_DoWork);
            this.backgroundWorkerInstalacao.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerInstalacao_RunWorkerCompleted);
            // 
            // pbLoadingOffice
            // 
            this.pbLoadingOffice.Image = ((System.Drawing.Image)(resources.GetObject("pbLoadingOffice.Image")));
            this.pbLoadingOffice.Location = new System.Drawing.Point(628, 173);
            this.pbLoadingOffice.Name = "pbLoadingOffice";
            this.pbLoadingOffice.Size = new System.Drawing.Size(20, 20);
            this.pbLoadingOffice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLoadingOffice.TabIndex = 23;
            this.pbLoadingOffice.TabStop = false;
            this.pbLoadingOffice.Visible = false;
            // 
            // pbLoadingWinrar
            // 
            this.pbLoadingWinrar.Image = ((System.Drawing.Image)(resources.GetObject("pbLoadingWinrar.Image")));
            this.pbLoadingWinrar.Location = new System.Drawing.Point(398, 305);
            this.pbLoadingWinrar.Name = "pbLoadingWinrar";
            this.pbLoadingWinrar.Size = new System.Drawing.Size(20, 20);
            this.pbLoadingWinrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLoadingWinrar.TabIndex = 24;
            this.pbLoadingWinrar.TabStop = false;
            this.pbLoadingWinrar.Visible = false;
            // 
            // pbLoadingAtivador
            // 
            this.pbLoadingAtivador.Image = ((System.Drawing.Image)(resources.GetObject("pbLoadingAtivador.Image")));
            this.pbLoadingAtivador.Location = new System.Drawing.Point(429, 349);
            this.pbLoadingAtivador.Name = "pbLoadingAtivador";
            this.pbLoadingAtivador.Size = new System.Drawing.Size(20, 20);
            this.pbLoadingAtivador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLoadingAtivador.TabIndex = 25;
            this.pbLoadingAtivador.TabStop = false;
            this.pbLoadingAtivador.Visible = false;
            // 
            // pbLoadingCodec
            // 
            this.pbLoadingCodec.Image = ((System.Drawing.Image)(resources.GetObject("pbLoadingCodec.Image")));
            this.pbLoadingCodec.Location = new System.Drawing.Point(480, 261);
            this.pbLoadingCodec.Name = "pbLoadingCodec";
            this.pbLoadingCodec.Size = new System.Drawing.Size(20, 20);
            this.pbLoadingCodec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLoadingCodec.TabIndex = 26;
            this.pbLoadingCodec.TabStop = false;
            this.pbLoadingCodec.Visible = false;
            // 
            // pbLoadingNavegador
            // 
            this.pbLoadingNavegador.Image = ((System.Drawing.Image)(resources.GetObject("pbLoadingNavegador.Image")));
            this.pbLoadingNavegador.Location = new System.Drawing.Point(535, 216);
            this.pbLoadingNavegador.Name = "pbLoadingNavegador";
            this.pbLoadingNavegador.Size = new System.Drawing.Size(20, 20);
            this.pbLoadingNavegador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLoadingNavegador.TabIndex = 27;
            this.pbLoadingNavegador.TabStop = false;
            this.pbLoadingNavegador.Visible = false;
            // 
            // InstalacaoW10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(106F, 106F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(836, 624);
            this.Controls.Add(this.pbLoadingNavegador);
            this.Controls.Add(this.pbLoadingCodec);
            this.Controls.Add(this.pbLoadingAtivador);
            this.Controls.Add(this.pbLoadingWinrar);
            this.Controls.Add(this.pbLoadingOffice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkInstalarTodos);
            this.Controls.Add(this.btnInstalar);
            this.Controls.Add(this.chkAtivador);
            this.Controls.Add(this.chkWinrar);
            this.Controls.Add(this.chkCodec);
            this.Controls.Add(this.chkNavegador);
            this.Controls.Add(this.chkOffice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InstalacaoW10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.InstalacaoW10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingOffice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingWinrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingAtivador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingCodec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingNavegador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkInstalarTodos;
        private System.Windows.Forms.Button btnInstalar;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorkerInstalacao;
        public System.Windows.Forms.PictureBox pbLoadingOffice;
        public System.Windows.Forms.CheckBox chkOffice;
        public System.Windows.Forms.CheckBox chkNavegador;
        public System.Windows.Forms.CheckBox chkCodec;
        public System.Windows.Forms.CheckBox chkAtivador;
        public System.Windows.Forms.CheckBox chkWinrar;
        public System.Windows.Forms.PictureBox pbLoadingWinrar;
        public System.Windows.Forms.PictureBox pbLoadingAtivador;
        public System.Windows.Forms.PictureBox pbLoadingCodec;
        public System.Windows.Forms.PictureBox pbLoadingNavegador;
    }
}

