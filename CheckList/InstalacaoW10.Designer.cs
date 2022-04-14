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
            this.chkOffice = new System.Windows.Forms.CheckBox();
            this.chkChrome = new System.Windows.Forms.CheckBox();
            this.chkCodec = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.btnInstalar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkOffice
            // 
            this.chkOffice.AutoSize = true;
            this.chkOffice.Location = new System.Drawing.Point(15, 57);
            this.chkOffice.Name = "chkOffice";
            this.chkOffice.Size = new System.Drawing.Size(156, 17);
            this.chkOffice.TabIndex = 0;
            this.chkOffice.Text = "MICROSOFT OFFICE 2013";
            this.chkOffice.UseVisualStyleBackColor = true;
            // 
            // chkChrome
            // 
            this.chkChrome.AutoSize = true;
            this.chkChrome.Location = new System.Drawing.Point(15, 84);
            this.chkChrome.Name = "chkChrome";
            this.chkChrome.Size = new System.Drawing.Size(121, 17);
            this.chkChrome.TabIndex = 1;
            this.chkChrome.Text = "GOOGLE CHROME";
            this.chkChrome.UseVisualStyleBackColor = true;
            // 
            // chkCodec
            // 
            this.chkCodec.AutoSize = true;
            this.chkCodec.Location = new System.Drawing.Point(15, 109);
            this.chkCodec.Name = "chkCodec";
            this.chkCodec.Size = new System.Drawing.Size(99, 17);
            this.chkCodec.TabIndex = 2;
            this.chkCodec.Text = "K-LITE CODEC";
            this.chkCodec.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "WINDOWS 8/10";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(15, 159);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(81, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "ATIVADOR";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(15, 134);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(71, 17);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "WINRAR";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "VOLTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(122, 235);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(89, 17);
            this.checkBox4.TabIndex = 20;
            this.checkBox4.Text = "Instalar todos";
            this.checkBox4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // btnInstalar
            // 
            this.btnInstalar.Location = new System.Drawing.Point(118, 209);
            this.btnInstalar.Name = "btnInstalar";
            this.btnInstalar.Size = new System.Drawing.Size(93, 23);
            this.btnInstalar.TabIndex = 19;
            this.btnInstalar.Text = "INSTALAR";
            this.btnInstalar.UseVisualStyleBackColor = true;
            // 
            // InstalacaoW10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 259);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.btnInstalar);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkCodec);
            this.Controls.Add(this.chkChrome);
            this.Controls.Add(this.chkOffice);
            this.Name = "InstalacaoW10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APPs Win8/10";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkOffice;
        private System.Windows.Forms.CheckBox chkChrome;
        private System.Windows.Forms.CheckBox chkCodec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button btnInstalar;
    }
}

