
namespace CryptConnectionString
{
    partial class Config_CryptView
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.ofd_Config = new System.Windows.Forms.OpenFileDialog();
            this.TxtConfigFileName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnShowExample = new System.Windows.Forms.Button();
            this.BtnEncrypt = new System.Windows.Forms.Button();
            this.BtnOpenFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtConfigFileName
            // 
            this.TxtConfigFileName.BackColor = System.Drawing.Color.White;
            this.TxtConfigFileName.Enabled = false;
            this.TxtConfigFileName.Location = new System.Drawing.Point(91, 8);
            this.TxtConfigFileName.Name = "TxtConfigFileName";
            this.TxtConfigFileName.ReadOnly = true;
            this.TxtConfigFileName.Size = new System.Drawing.Size(192, 21);
            this.TxtConfigFileName.TabIndex = 0;
            this.TxtConfigFileName.TextChanged += new System.EventHandler(this.TxtConfigFileName_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.BtnShowExample);
            this.panel1.Controls.Add(this.BtnEncrypt);
            this.panel1.Controls.Add(this.BtnOpenFile);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtConfigFileName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 96);
            this.panel1.TabIndex = 1;
            // 
            // BtnShowExample
            // 
            this.BtnShowExample.Location = new System.Drawing.Point(18, 65);
            this.BtnShowExample.Name = "BtnShowExample";
            this.BtnShowExample.Size = new System.Drawing.Size(300, 23);
            this.BtnShowExample.TabIndex = 5;
            this.BtnShowExample.Text = "Show Example";
            this.BtnShowExample.UseVisualStyleBackColor = true;
            this.BtnShowExample.Click += new System.EventHandler(this.BtnShowExample_Click);
            // 
            // BtnEncrypt
            // 
            this.BtnEncrypt.Enabled = false;
            this.BtnEncrypt.Location = new System.Drawing.Point(18, 36);
            this.BtnEncrypt.Name = "BtnEncrypt";
            this.BtnEncrypt.Size = new System.Drawing.Size(300, 23);
            this.BtnEncrypt.TabIndex = 3;
            this.BtnEncrypt.Text = "Encrypt Config";
            this.BtnEncrypt.UseVisualStyleBackColor = true;
            this.BtnEncrypt.Click += new System.EventHandler(this.BtnEncrypt_Click);
            // 
            // BtnOpenFile
            // 
            this.BtnOpenFile.Location = new System.Drawing.Point(289, 7);
            this.BtnOpenFile.Name = "BtnOpenFile";
            this.BtnOpenFile.Size = new System.Drawing.Size(29, 23);
            this.BtnOpenFile.TabIndex = 2;
            this.BtnOpenFile.Text = "...";
            this.BtnOpenFile.UseVisualStyleBackColor = true;
            this.BtnOpenFile.Click += new System.EventHandler(this.BtnOpenFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Config File";
            // 
            // Config_CryptView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 120);
            this.Controls.Add(this.panel1);
            this.Name = "Config_CryptView";
            this.Text = "Config File Crypt";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofd_Config;
        private System.Windows.Forms.TextBox TxtConfigFileName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnOpenFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEncrypt;
        private System.Windows.Forms.Button BtnShowExample;
    }
}

