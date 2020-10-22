namespace proje_odevi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBarORGNK = new System.Windows.Forms.ProgressBar();
            this.progressBarKAGIT = new System.Windows.Forms.ProgressBar();
            this.progressBarCAM = new System.Windows.Forms.ProgressBar();
            this.progressBarMETAL = new System.Windows.Forms.ProgressBar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonorganik = new System.Windows.Forms.Button();
            this.buttonORGNKBOSALT = new System.Windows.Forms.Button();
            this.buttonKAGIT = new System.Windows.Forms.Button();
            this.buttonKAGITBOSALT = new System.Windows.Forms.Button();
            this.buttonCAM = new System.Windows.Forms.Button();
            this.buttonCAMBOSALT = new System.Windows.Forms.Button();
            this.buttonMETAL = new System.Windows.Forms.Button();
            this.buttonMETALBOSALT = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CIKISBTTN = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Black;
            this.ımageList1.Images.SetKeyName(0, "cambardak.jpg");
            this.ımageList1.Images.SetKeyName(1, "camşişe.jpg");
            this.ımageList1.Images.SetKeyName(2, "cola.jpg");
            this.ımageList1.Images.SetKeyName(3, "dergi.jpg");
            this.ımageList1.Images.SetKeyName(4, "domates.jpg");
            this.ımageList1.Images.SetKeyName(5, "gazete.jpg");
            this.ımageList1.Images.SetKeyName(6, "salatalık.jpg");
            this.ımageList1.Images.SetKeyName(7, "salca.jpg");
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(28, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "YENİ OYUN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(28, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "60";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBarORGNK
            // 
            this.progressBarORGNK.Location = new System.Drawing.Point(22, 227);
            this.progressBarORGNK.Maximum = 1000;
            this.progressBarORGNK.Name = "progressBarORGNK";
            this.progressBarORGNK.Size = new System.Drawing.Size(147, 18);
            this.progressBarORGNK.TabIndex = 3;
            this.progressBarORGNK.Click += new System.EventHandler(this.progressBarORGNK_Click);
            // 
            // progressBarKAGIT
            // 
            this.progressBarKAGIT.Location = new System.Drawing.Point(30, 227);
            this.progressBarKAGIT.Maximum = 1600;
            this.progressBarKAGIT.Name = "progressBarKAGIT";
            this.progressBarKAGIT.Size = new System.Drawing.Size(147, 18);
            this.progressBarKAGIT.TabIndex = 4;
            this.progressBarKAGIT.Click += new System.EventHandler(this.progressBarKAGIT_Click);
            // 
            // progressBarCAM
            // 
            this.progressBarCAM.Location = new System.Drawing.Point(27, 210);
            this.progressBarCAM.Maximum = 3000;
            this.progressBarCAM.Name = "progressBarCAM";
            this.progressBarCAM.Size = new System.Drawing.Size(147, 20);
            this.progressBarCAM.TabIndex = 5;
            this.progressBarCAM.Click += new System.EventHandler(this.progressBarCAM_Click);
            // 
            // progressBarMETAL
            // 
            this.progressBarMETAL.Location = new System.Drawing.Point(30, 210);
            this.progressBarMETAL.Maximum = 3000;
            this.progressBarMETAL.Name = "progressBarMETAL";
            this.progressBarMETAL.Size = new System.Drawing.Size(147, 20);
            this.progressBarMETAL.TabIndex = 6;
            this.progressBarMETAL.Click += new System.EventHandler(this.progressBarMETAL_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(22, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(147, 148);
            this.listBox1.TabIndex = 7;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(30, 43);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(147, 148);
            this.listBox2.TabIndex = 8;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(27, 53);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(147, 132);
            this.listBox3.TabIndex = 9;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 16;
            this.listBox4.Location = new System.Drawing.Point(30, 53);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(147, 148);
            this.listBox4.TabIndex = 10;
            this.listBox4.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "SÜRE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(28, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "PUAN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(28, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 39);
            this.label4.TabIndex = 13;
            this.label4.Text = "0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonorganik
            // 
            this.buttonorganik.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonorganik.Location = new System.Drawing.Point(22, 14);
            this.buttonorganik.Name = "buttonorganik";
            this.buttonorganik.Size = new System.Drawing.Size(147, 23);
            this.buttonorganik.TabIndex = 14;
            this.buttonorganik.Text = "ORGANİK ATIK";
            this.buttonorganik.UseVisualStyleBackColor = true;
            this.buttonorganik.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonORGNKBOSALT
            // 
            this.buttonORGNKBOSALT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonORGNKBOSALT.Location = new System.Drawing.Point(22, 262);
            this.buttonORGNKBOSALT.Name = "buttonORGNKBOSALT";
            this.buttonORGNKBOSALT.Size = new System.Drawing.Size(147, 23);
            this.buttonORGNKBOSALT.TabIndex = 15;
            this.buttonORGNKBOSALT.Text = "BOŞALT";
            this.buttonORGNKBOSALT.UseVisualStyleBackColor = true;
            this.buttonORGNKBOSALT.Click += new System.EventHandler(this.buttonORGNKBOSALT_Click);
            // 
            // buttonKAGIT
            // 
            this.buttonKAGIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKAGIT.Location = new System.Drawing.Point(30, 14);
            this.buttonKAGIT.Name = "buttonKAGIT";
            this.buttonKAGIT.Size = new System.Drawing.Size(147, 23);
            this.buttonKAGIT.TabIndex = 16;
            this.buttonKAGIT.Text = "KAĞIT";
            this.buttonKAGIT.UseVisualStyleBackColor = true;
            this.buttonKAGIT.Click += new System.EventHandler(this.buttonKAGIT_Click);
            // 
            // buttonKAGITBOSALT
            // 
            this.buttonKAGITBOSALT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKAGITBOSALT.Location = new System.Drawing.Point(30, 262);
            this.buttonKAGITBOSALT.Name = "buttonKAGITBOSALT";
            this.buttonKAGITBOSALT.Size = new System.Drawing.Size(147, 23);
            this.buttonKAGITBOSALT.TabIndex = 17;
            this.buttonKAGITBOSALT.Text = "BOŞALT";
            this.buttonKAGITBOSALT.UseVisualStyleBackColor = true;
            this.buttonKAGITBOSALT.Click += new System.EventHandler(this.buttonKAGITBOSALT_Click);
            // 
            // buttonCAM
            // 
            this.buttonCAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCAM.Location = new System.Drawing.Point(27, 21);
            this.buttonCAM.Name = "buttonCAM";
            this.buttonCAM.Size = new System.Drawing.Size(147, 23);
            this.buttonCAM.TabIndex = 18;
            this.buttonCAM.Text = "CAM";
            this.buttonCAM.UseVisualStyleBackColor = true;
            this.buttonCAM.Click += new System.EventHandler(this.buttonCAM_Click);
            // 
            // buttonCAMBOSALT
            // 
            this.buttonCAMBOSALT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCAMBOSALT.Location = new System.Drawing.Point(27, 246);
            this.buttonCAMBOSALT.Name = "buttonCAMBOSALT";
            this.buttonCAMBOSALT.Size = new System.Drawing.Size(147, 23);
            this.buttonCAMBOSALT.TabIndex = 19;
            this.buttonCAMBOSALT.Text = "BOŞALT";
            this.buttonCAMBOSALT.UseVisualStyleBackColor = true;
            this.buttonCAMBOSALT.Click += new System.EventHandler(this.buttonCAMBOSALT_Click);
            // 
            // buttonMETAL
            // 
            this.buttonMETAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonMETAL.Location = new System.Drawing.Point(30, 21);
            this.buttonMETAL.Name = "buttonMETAL";
            this.buttonMETAL.Size = new System.Drawing.Size(147, 23);
            this.buttonMETAL.TabIndex = 20;
            this.buttonMETAL.Text = "METAL";
            this.buttonMETAL.UseVisualStyleBackColor = true;
            this.buttonMETAL.Click += new System.EventHandler(this.buttonMETAL_Click);
            // 
            // buttonMETALBOSALT
            // 
            this.buttonMETALBOSALT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonMETALBOSALT.Location = new System.Drawing.Point(30, 246);
            this.buttonMETALBOSALT.Name = "buttonMETALBOSALT";
            this.buttonMETALBOSALT.Size = new System.Drawing.Size(147, 23);
            this.buttonMETALBOSALT.TabIndex = 21;
            this.buttonMETALBOSALT.Text = "BOŞALT";
            this.buttonMETALBOSALT.UseVisualStyleBackColor = true;
            this.buttonMETALBOSALT.Click += new System.EventHandler(this.buttonMETALBOSALT_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.progressBarORGNK);
            this.groupBox1.Controls.Add(this.buttonorganik);
            this.groupBox1.Controls.Add(this.buttonORGNKBOSALT);
            this.groupBox1.Location = new System.Drawing.Point(261, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 318);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Controls.Add(this.progressBarKAGIT);
            this.groupBox2.Controls.Add(this.buttonKAGIT);
            this.groupBox2.Controls.Add(this.buttonKAGITBOSALT);
            this.groupBox2.Location = new System.Drawing.Point(467, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 318);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Controls.Add(this.listBox3);
            this.groupBox3.Controls.Add(this.progressBarCAM);
            this.groupBox3.Controls.Add(this.buttonCAM);
            this.groupBox3.Controls.Add(this.buttonCAMBOSALT);
            this.groupBox3.Location = new System.Drawing.Point(261, 358);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 292);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox4.Controls.Add(this.progressBarMETAL);
            this.groupBox4.Controls.Add(this.listBox4);
            this.groupBox4.Controls.Add(this.buttonMETAL);
            this.groupBox4.Controls.Add(this.buttonMETALBOSALT);
            this.groupBox4.Location = new System.Drawing.Point(467, 358);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(198, 292);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // CIKISBTTN
            // 
            this.CIKISBTTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CIKISBTTN.Location = new System.Drawing.Point(28, 285);
            this.CIKISBTTN.Name = "CIKISBTTN";
            this.CIKISBTTN.Size = new System.Drawing.Size(165, 59);
            this.CIKISBTTN.TabIndex = 25;
            this.CIKISBTTN.Text = "ÇIKIŞ";
            this.CIKISBTTN.UseVisualStyleBackColor = true;
            this.CIKISBTTN.Click += new System.EventHandler(this.CIKISBTTN_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(243, 256);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            // 
            // label5
            // 
            this.label5.ImageList = this.ımageList1;
            this.label5.Location = new System.Drawing.Point(13, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 227);
            this.label5.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.CIKISBTTN);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Location = new System.Drawing.Point(12, 283);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(243, 367);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(685, 675);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ATIK TOPLAMA OYUNU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBarORGNK;
        private System.Windows.Forms.ProgressBar progressBarKAGIT;
        private System.Windows.Forms.ProgressBar progressBarCAM;
        private System.Windows.Forms.ProgressBar progressBarMETAL;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonorganik;
        private System.Windows.Forms.Button buttonORGNKBOSALT;
        private System.Windows.Forms.Button buttonKAGIT;
        private System.Windows.Forms.Button buttonKAGITBOSALT;
        private System.Windows.Forms.Button buttonCAM;
        private System.Windows.Forms.Button buttonCAMBOSALT;
        private System.Windows.Forms.Button buttonMETAL;
        private System.Windows.Forms.Button buttonMETALBOSALT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button CIKISBTTN;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label5;
    }
}

