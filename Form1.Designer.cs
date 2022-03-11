namespace WindowsFormsApp2
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
            this.lblRedX = new System.Windows.Forms.Label();
            this.lblRedY = new System.Windows.Forms.Label();
            this.lblRedUzaklik = new System.Windows.Forms.Label();
            this.lblBlueUzaklik = new System.Windows.Forms.Label();
            this.lblBlueY = new System.Windows.Forms.Label();
            this.lblBlueX = new System.Windows.Forms.Label();
            this.lblOrangeUzaklik = new System.Windows.Forms.Label();
            this.lblOrangeY = new System.Windows.Forms.Label();
            this.lblOrangeX = new System.Windows.Forms.Label();
            this.lblGreenUzaklik = new System.Windows.Forms.Label();
            this.lblGreenY = new System.Windows.Forms.Label();
            this.lblGreenX = new System.Windows.Forms.Label();
            this.lblMX = new System.Windows.Forms.Label();
            this.lblMY = new System.Windows.Forms.Label();
            this.txtBoxPointX = new System.Windows.Forms.TextBox();
            this.txtBoxPointY = new System.Windows.Forms.TextBox();
            this.lblPointX = new System.Windows.Forms.Label();
            this.lblPointY = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRedX
            // 
            this.lblRedX.AutoSize = true;
            this.lblRedX.Location = new System.Drawing.Point(134, 760);
            this.lblRedX.Name = "lblRedX";
            this.lblRedX.Size = new System.Drawing.Size(48, 16);
            this.lblRedX.TabIndex = 2;
            this.lblRedX.Text = "RedX=";
            // 
            // lblRedY
            // 
            this.lblRedY.AutoSize = true;
            this.lblRedY.Location = new System.Drawing.Point(133, 787);
            this.lblRedY.Name = "lblRedY";
            this.lblRedY.Size = new System.Drawing.Size(49, 16);
            this.lblRedY.TabIndex = 3;
            this.lblRedY.Text = "RedY=";
            // 
            // lblRedUzaklik
            // 
            this.lblRedUzaklik.AutoSize = true;
            this.lblRedUzaklik.Location = new System.Drawing.Point(134, 813);
            this.lblRedUzaklik.Name = "lblRedUzaklik";
            this.lblRedUzaklik.Size = new System.Drawing.Size(98, 16);
            this.lblRedUzaklik.TabIndex = 4;
            this.lblRedUzaklik.Text = "Sol üst uzaklık=";
            // 
            // lblBlueUzaklik
            // 
            this.lblBlueUzaklik.AutoSize = true;
            this.lblBlueUzaklik.Location = new System.Drawing.Point(303, 813);
            this.lblBlueUzaklik.Name = "lblBlueUzaklik";
            this.lblBlueUzaklik.Size = new System.Drawing.Size(102, 16);
            this.lblBlueUzaklik.TabIndex = 8;
            this.lblBlueUzaklik.Text = "Sağ Üst Uzaklık";
            // 
            // lblBlueY
            // 
            this.lblBlueY.AutoSize = true;
            this.lblBlueY.Location = new System.Drawing.Point(302, 787);
            this.lblBlueY.Name = "lblBlueY";
            this.lblBlueY.Size = new System.Drawing.Size(50, 16);
            this.lblBlueY.TabIndex = 7;
            this.lblBlueY.Text = "BlueY=";
            // 
            // lblBlueX
            // 
            this.lblBlueX.AutoSize = true;
            this.lblBlueX.Location = new System.Drawing.Point(303, 760);
            this.lblBlueX.Name = "lblBlueX";
            this.lblBlueX.Size = new System.Drawing.Size(49, 16);
            this.lblBlueX.TabIndex = 6;
            this.lblBlueX.Text = "BlueX=";
            // 
            // lblOrangeUzaklik
            // 
            this.lblOrangeUzaklik.AutoSize = true;
            this.lblOrangeUzaklik.Location = new System.Drawing.Point(471, 813);
            this.lblOrangeUzaklik.Name = "lblOrangeUzaklik";
            this.lblOrangeUzaklik.Size = new System.Drawing.Size(98, 16);
            this.lblOrangeUzaklik.TabIndex = 11;
            this.lblOrangeUzaklik.Text = "Sol üst uzaklık=";
            // 
            // lblOrangeY
            // 
            this.lblOrangeY.AutoSize = true;
            this.lblOrangeY.Location = new System.Drawing.Point(470, 787);
            this.lblOrangeY.Name = "lblOrangeY";
            this.lblOrangeY.Size = new System.Drawing.Size(68, 16);
            this.lblOrangeY.TabIndex = 10;
            this.lblOrangeY.Text = "OrangeY=";
            // 
            // lblOrangeX
            // 
            this.lblOrangeX.AutoSize = true;
            this.lblOrangeX.Location = new System.Drawing.Point(471, 760);
            this.lblOrangeX.Name = "lblOrangeX";
            this.lblOrangeX.Size = new System.Drawing.Size(67, 16);
            this.lblOrangeX.TabIndex = 9;
            this.lblOrangeX.Text = "OrangeX=";
            // 
            // lblGreenUzaklik
            // 
            this.lblGreenUzaklik.AutoSize = true;
            this.lblGreenUzaklik.Location = new System.Drawing.Point(649, 813);
            this.lblGreenUzaklik.Name = "lblGreenUzaklik";
            this.lblGreenUzaklik.Size = new System.Drawing.Size(99, 16);
            this.lblGreenUzaklik.TabIndex = 14;
            this.lblGreenUzaklik.Text = "Sol Alt Uzaklık=";
            // 
            // lblGreenY
            // 
            this.lblGreenY.AutoSize = true;
            this.lblGreenY.Location = new System.Drawing.Point(648, 787);
            this.lblGreenY.Name = "lblGreenY";
            this.lblGreenY.Size = new System.Drawing.Size(60, 16);
            this.lblGreenY.TabIndex = 13;
            this.lblGreenY.Text = "GreenY=";
            // 
            // lblGreenX
            // 
            this.lblGreenX.AutoSize = true;
            this.lblGreenX.Location = new System.Drawing.Point(649, 760);
            this.lblGreenX.Name = "lblGreenX";
            this.lblGreenX.Size = new System.Drawing.Size(59, 16);
            this.lblGreenX.TabIndex = 12;
            this.lblGreenX.Text = "GreenX=";
            // 
            // lblMX
            // 
            this.lblMX.AutoSize = true;
            this.lblMX.Location = new System.Drawing.Point(22, 760);
            this.lblMX.Name = "lblMX";
            this.lblMX.Size = new System.Drawing.Size(63, 16);
            this.lblMX.TabIndex = 15;
            this.lblMX.Text = "MouseX=";
            // 
            // lblMY
            // 
            this.lblMY.AutoSize = true;
            this.lblMY.Location = new System.Drawing.Point(22, 813);
            this.lblMY.Name = "lblMY";
            this.lblMY.Size = new System.Drawing.Size(64, 16);
            this.lblMY.TabIndex = 16;
            this.lblMY.Text = "MouseY=";
            // 
            // txtBoxPointX
            // 
            this.txtBoxPointX.Location = new System.Drawing.Point(944, 80);
            this.txtBoxPointX.Name = "txtBoxPointX";
            this.txtBoxPointX.Size = new System.Drawing.Size(100, 22);
            this.txtBoxPointX.TabIndex = 17;
            // 
            // txtBoxPointY
            // 
            this.txtBoxPointY.Location = new System.Drawing.Point(944, 117);
            this.txtBoxPointY.Name = "txtBoxPointY";
            this.txtBoxPointY.Size = new System.Drawing.Size(100, 22);
            this.txtBoxPointY.TabIndex = 18;
            // 
            // lblPointX
            // 
            this.lblPointX.AutoSize = true;
            this.lblPointX.Location = new System.Drawing.Point(873, 83);
            this.lblPointX.Name = "lblPointX";
            this.lblPointX.Size = new System.Drawing.Size(64, 16);
            this.lblPointX.TabIndex = 19;
            this.lblPointX.Text = "X değeri=";
            // 
            // lblPointY
            // 
            this.lblPointY.AutoSize = true;
            this.lblPointY.Location = new System.Drawing.Point(873, 120);
            this.lblPointY.Name = "lblPointY";
            this.lblPointY.Size = new System.Drawing.Size(65, 16);
            this.lblPointY.TabIndex = 20;
            this.lblPointY.Text = "Y değeri=";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(944, 156);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 23);
            this.btnCreate.TabIndex = 21;
            this.btnCreate.Text = "Oluştur";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 859);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblPointY);
            this.Controls.Add(this.lblPointX);
            this.Controls.Add(this.txtBoxPointY);
            this.Controls.Add(this.txtBoxPointX);
            this.Controls.Add(this.lblMY);
            this.Controls.Add(this.lblMX);
            this.Controls.Add(this.lblGreenUzaklik);
            this.Controls.Add(this.lblGreenY);
            this.Controls.Add(this.lblGreenX);
            this.Controls.Add(this.lblOrangeUzaklik);
            this.Controls.Add(this.lblOrangeY);
            this.Controls.Add(this.lblOrangeX);
            this.Controls.Add(this.lblBlueUzaklik);
            this.Controls.Add(this.lblBlueY);
            this.Controls.Add(this.lblBlueX);
            this.Controls.Add(this.lblRedUzaklik);
            this.Controls.Add(this.lblRedY);
            this.Controls.Add(this.lblRedX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRedX;
        private System.Windows.Forms.Label lblRedY;
        private System.Windows.Forms.Label lblRedUzaklik;
        private System.Windows.Forms.Label lblBlueUzaklik;
        private System.Windows.Forms.Label lblBlueY;
        private System.Windows.Forms.Label lblBlueX;
        private System.Windows.Forms.Label lblOrangeUzaklik;
        private System.Windows.Forms.Label lblOrangeY;
        private System.Windows.Forms.Label lblOrangeX;
        private System.Windows.Forms.Label lblGreenUzaklik;
        private System.Windows.Forms.Label lblGreenY;
        private System.Windows.Forms.Label lblGreenX;
        private System.Windows.Forms.Label lblMX;
        private System.Windows.Forms.Label lblMY;
        private System.Windows.Forms.TextBox txtBoxPointX;
        private System.Windows.Forms.TextBox txtBoxPointY;
        private System.Windows.Forms.Label lblPointX;
        private System.Windows.Forms.Label lblPointY;
        private System.Windows.Forms.Button btnCreate;
    }
}

