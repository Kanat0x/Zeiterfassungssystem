
namespace swt
{
    partial class loginWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.eingabeName = new System.Windows.Forms.TextBox();
            this.eingabePassword = new System.Windows.Forms.TextBox();
            this.anmeldeButton = new System.Windows.Forms.Button();
            this.beendenButton = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // eingabeName
            // 
            this.eingabeName.Location = new System.Drawing.Point(223, 253);
            this.eingabeName.Margin = new System.Windows.Forms.Padding(2);
            this.eingabeName.Name = "eingabeName";
            this.eingabeName.Size = new System.Drawing.Size(155, 20);
            this.eingabeName.TabIndex = 1;
            this.eingabeName.TextChanged += new System.EventHandler(this.eingabeName_TextChanged);
            // 
            // eingabePassword
            // 
            this.eingabePassword.Location = new System.Drawing.Point(223, 283);
            this.eingabePassword.Margin = new System.Windows.Forms.Padding(2);
            this.eingabePassword.Name = "eingabePassword";
            this.eingabePassword.Size = new System.Drawing.Size(155, 20);
            this.eingabePassword.TabIndex = 2;
            this.eingabePassword.UseSystemPasswordChar = true;
            // 
            // anmeldeButton
            // 
            this.anmeldeButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.anmeldeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anmeldeButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anmeldeButton.ForeColor = System.Drawing.Color.White;
            this.anmeldeButton.Location = new System.Drawing.Point(250, 331);
            this.anmeldeButton.Margin = new System.Windows.Forms.Padding(2);
            this.anmeldeButton.Name = "anmeldeButton";
            this.anmeldeButton.Size = new System.Drawing.Size(95, 25);
            this.anmeldeButton.TabIndex = 5;
            this.anmeldeButton.Text = "Anmelden";
            this.anmeldeButton.UseVisualStyleBackColor = false;
            this.anmeldeButton.Click += new System.EventHandler(this.anmeldeButton_Click);
            // 
            // beendenButton
            // 
            this.beendenButton.AutoSize = true;
            this.beendenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beendenButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beendenButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.beendenButton.Location = new System.Drawing.Point(261, 366);
            this.beendenButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.beendenButton.Name = "beendenButton";
            this.beendenButton.Size = new System.Drawing.Size(72, 19);
            this.beendenButton.TabIndex = 6;
            this.beendenButton.Text = "Beenden";
            this.beendenButton.Click += new System.EventHandler(this.beendenButton_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::swt.Properties.Resources._102643;
            this.pictureBox3.Location = new System.Drawing.Point(205, 281);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(15, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::swt.Properties.Resources.Unbenannt_2;
            this.pictureBox2.Location = new System.Drawing.Point(205, 255);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(13, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::swt.Properties.Resources.swtLOGO;
            this.pictureBox1.Location = new System.Drawing.Point(233, 46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // loginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 455);
            this.Controls.Add(this.beendenButton);
            this.Controls.Add(this.anmeldeButton);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.eingabePassword);
            this.Controls.Add(this.eingabeName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "loginWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.loginWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox eingabeName;
        private System.Windows.Forms.TextBox eingabePassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button anmeldeButton;
        private System.Windows.Forms.Label beendenButton;
    }
}

