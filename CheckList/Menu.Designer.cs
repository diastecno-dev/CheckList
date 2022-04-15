namespace CheckList
{
    partial class Menu
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
            this.btnW7 = new System.Windows.Forms.Button();
            this.btnW10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnW7
            // 
            this.btnW7.Location = new System.Drawing.Point(110, 153);
            this.btnW7.Name = "btnW7";
            this.btnW7.Size = new System.Drawing.Size(196, 120);
            this.btnW7.TabIndex = 0;
            this.btnW7.Text = "WINDOWS 7";
            this.btnW7.UseVisualStyleBackColor = true;
            this.btnW7.Click += new System.EventHandler(this.btnW7_Click);
            // 
            // btnW10
            // 
            this.btnW10.Location = new System.Drawing.Point(390, 153);
            this.btnW10.Name = "btnW10";
            this.btnW10.Size = new System.Drawing.Size(196, 120);
            this.btnW10.TabIndex = 1;
            this.btnW10.Text = "WINDOWS 8/10";
            this.btnW10.UseVisualStyleBackColor = true;
            this.btnW10.Click += new System.EventHandler(this.btnW10_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnW10);
            this.Controls.Add(this.btnW7);
            this.IsMdiContainer = true;
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnW7;
        private System.Windows.Forms.Button btnW10;
    }
}