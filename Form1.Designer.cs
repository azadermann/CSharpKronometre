namespace CSharpKronometre
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BaslatButton = new System.Windows.Forms.Button();
            this.AraZamanButton = new System.Windows.Forms.Button();
            this.DurdurButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SıfırlaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BaslatButton
            // 
            this.BaslatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BaslatButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BaslatButton.Location = new System.Drawing.Point(48, 41);
            this.BaslatButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BaslatButton.Name = "BaslatButton";
            this.BaslatButton.Size = new System.Drawing.Size(112, 35);
            this.BaslatButton.TabIndex = 0;
            this.BaslatButton.Text = "Başlat";
            this.BaslatButton.UseVisualStyleBackColor = true;
            this.BaslatButton.Click += new System.EventHandler(this.BaslatButton_Click);
            // 
            // AraZamanButton
            // 
            this.AraZamanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AraZamanButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AraZamanButton.Location = new System.Drawing.Point(168, 41);
            this.AraZamanButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AraZamanButton.Name = "AraZamanButton";
            this.AraZamanButton.Size = new System.Drawing.Size(112, 35);
            this.AraZamanButton.TabIndex = 1;
            this.AraZamanButton.Text = "Ara Zaman";
            this.AraZamanButton.UseVisualStyleBackColor = true;
            this.AraZamanButton.Click += new System.EventHandler(this.AraZamanButton_Click);
            // 
            // DurdurButton
            // 
            this.DurdurButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DurdurButton.ForeColor = System.Drawing.Color.Red;
            this.DurdurButton.Location = new System.Drawing.Point(288, 41);
            this.DurdurButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DurdurButton.Name = "DurdurButton";
            this.DurdurButton.Size = new System.Drawing.Size(112, 35);
            this.DurdurButton.TabIndex = 2;
            this.DurdurButton.Text = "Durdur";
            this.DurdurButton.UseVisualStyleBackColor = true;
            this.DurdurButton.Click += new System.EventHandler(this.DurdurButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Süre : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "0";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(48, 143);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(359, 264);
            this.listBox1.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SıfırlaButton
            // 
            this.SıfırlaButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SıfırlaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SıfırlaButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.SıfırlaButton.Location = new System.Drawing.Point(165, 424);
            this.SıfırlaButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SıfırlaButton.Name = "SıfırlaButton";
            this.SıfırlaButton.Size = new System.Drawing.Size(112, 35);
            this.SıfırlaButton.TabIndex = 6;
            this.SıfırlaButton.Text = "Sıfırla";
            this.SıfırlaButton.UseVisualStyleBackColor = false;
            this.SıfırlaButton.Click += new System.EventHandler(this.SıfırlaButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(464, 487);
            this.Controls.Add(this.SıfırlaButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DurdurButton);
            this.Controls.Add(this.AraZamanButton);
            this.Controls.Add(this.BaslatButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Kronometre";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BaslatButton;
        private System.Windows.Forms.Button AraZamanButton;
        private System.Windows.Forms.Button DurdurButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button SıfırlaButton;
    }
}

