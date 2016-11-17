namespace Window
{
    partial class Login
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
            this.uName = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pWord = new DevExpress.XtraEditors.TextEdit();
            this.txtValid = new DevExpress.XtraEditors.TextEdit();
            this.LblValid = new System.Windows.Forms.Label();
            this.SaveLogin = new DevExpress.XtraEditors.SimpleButton();
            this.LblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pWord.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValid.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // uName
            // 
            this.uName.Location = new System.Drawing.Point(85, 22);
            this.uName.Name = "uName";
            this.uName.Size = new System.Drawing.Size(237, 20);
            this.uName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "用户密码：";
            // 
            // pWord
            // 
            this.pWord.Location = new System.Drawing.Point(85, 56);
            this.pWord.Name = "pWord";
            this.pWord.Size = new System.Drawing.Size(237, 20);
            this.pWord.TabIndex = 4;
            // 
            // txtValid
            // 
            this.txtValid.Location = new System.Drawing.Point(85, 91);
            this.txtValid.Name = "txtValid";
            this.txtValid.Size = new System.Drawing.Size(237, 20);
            this.txtValid.TabIndex = 5;
            // 
            // LblValid
            // 
            this.LblValid.AutoSize = true;
            this.LblValid.Location = new System.Drawing.Point(18, 94);
            this.LblValid.Name = "LblValid";
            this.LblValid.Size = new System.Drawing.Size(47, 14);
            this.LblValid.TabIndex = 6;
            this.LblValid.Text = "LblValid";
            // 
            // SaveLogin
            // 
            this.SaveLogin.Location = new System.Drawing.Point(15, 117);
            this.SaveLogin.Name = "SaveLogin";
            this.SaveLogin.Size = new System.Drawing.Size(307, 38);
            this.SaveLogin.TabIndex = 7;
            this.SaveLogin.Text = "Login";
            this.SaveLogin.Click += new System.EventHandler(this.SaveLogin_Click);
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.Location = new System.Drawing.Point(18, 171);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(28, 14);
            this.LblError.TabIndex = 8;
            this.LblError.Text = "123";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 194);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.SaveLogin);
            this.Controls.Add(this.LblValid);
            this.Controls.Add(this.txtValid);
            this.Controls.Add(this.pWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uName);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.uName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pWord.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValid.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit uName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit pWord;
        private DevExpress.XtraEditors.TextEdit txtValid;
        private System.Windows.Forms.Label LblValid;
        private DevExpress.XtraEditors.SimpleButton SaveLogin;
        private System.Windows.Forms.Label LblError;
    }
}