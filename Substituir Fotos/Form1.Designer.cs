namespace Substituir_Fotos
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnOri = new System.Windows.Forms.Button();
            this.camImg = new System.Windows.Forms.TextBox();
            this.camCurso = new System.Windows.Forms.TextBox();
            this.btnDest = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.camImg2 = new System.Windows.Forms.OpenFileDialog();
            this.camCurso2 = new System.Windows.Forms.FolderBrowserDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnOri
            // 
            this.btnOri.Location = new System.Drawing.Point(208, 12);
            this.btnOri.Name = "btnOri";
            this.btnOri.Size = new System.Drawing.Size(75, 23);
            this.btnOri.TabIndex = 0;
            this.btnOri.Text = "Origem";
            this.btnOri.UseVisualStyleBackColor = true;
            this.btnOri.Click += new System.EventHandler(this.btnOri_Click);
            // 
            // camImg
            // 
            this.camImg.AllowDrop = true;
            this.camImg.Location = new System.Drawing.Point(12, 12);
            this.camImg.Name = "camImg";
            this.camImg.Size = new System.Drawing.Size(164, 20);
            this.camImg.TabIndex = 1;
            this.camImg.TextChanged += new System.EventHandler(this.camImg_TextChanged);
            this.camImg.DragEnter += new System.Windows.Forms.DragEventHandler(this.camImg_DragDrop);
            this.camImg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.camImg_MouseDown);
            // 
            // camCurso
            // 
            this.camCurso.AllowDrop = true;
            this.camCurso.Location = new System.Drawing.Point(12, 53);
            this.camCurso.Name = "camCurso";
            this.camCurso.Size = new System.Drawing.Size(164, 20);
            this.camCurso.TabIndex = 2;
            this.camCurso.TextChanged += new System.EventHandler(this.camCurso_TextChanged);
            this.camCurso.DragEnter += new System.Windows.Forms.DragEventHandler(this.camCurso_DragEnter);
            this.camCurso.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.camCurso_MouseDoubleClick);
            // 
            // btnDest
            // 
            this.btnDest.Location = new System.Drawing.Point(208, 50);
            this.btnDest.Name = "btnDest";
            this.btnDest.Size = new System.Drawing.Size(75, 23);
            this.btnDest.TabIndex = 3;
            this.btnDest.Text = "Destino";
            this.btnDest.UseVisualStyleBackColor = true;
            this.btnDest.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(349, 12);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "FAÇA!";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // camImg2
            // 
            this.camImg2.FileName = "Abrir arquivo";
            this.camImg2.Multiselect = true;
            this.camImg2.FileOk += new System.ComponentModel.CancelEventHandler(this.camImg2_FileOk);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(313, 74);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(179, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Desejo jogar em todos os álbuns";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 121);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnDest);
            this.Controls.Add(this.camCurso);
            this.Controls.Add(this.camImg);
            this.Controls.Add(this.btnOri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Substituição!";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOri;
        private System.Windows.Forms.TextBox camImg;
        private System.Windows.Forms.TextBox camCurso;
        private System.Windows.Forms.Button btnDest;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.OpenFileDialog camImg2;
        private System.Windows.Forms.FolderBrowserDialog camCurso2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

