namespace WindowsFormsApplication1
{
    partial class insTecniciFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.pswTxt = new System.Windows.Forms.TextBox();
            this.registraBtn = new System.Windows.Forms.Button();
            this.esciBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // userTxt
            // 
            this.userTxt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTxt.Location = new System.Drawing.Point(172, 36);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(161, 26);
            this.userTxt.TabIndex = 2;
            // 
            // pswTxt
            // 
            this.pswTxt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pswTxt.Location = new System.Drawing.Point(172, 82);
            this.pswTxt.Name = "pswTxt";
            this.pswTxt.PasswordChar = '*';
            this.pswTxt.Size = new System.Drawing.Size(161, 26);
            this.pswTxt.TabIndex = 3;
            // 
            // registraBtn
            // 
            this.registraBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registraBtn.Location = new System.Drawing.Point(43, 161);
            this.registraBtn.Name = "registraBtn";
            this.registraBtn.Size = new System.Drawing.Size(136, 32);
            this.registraBtn.TabIndex = 4;
            this.registraBtn.Text = "Registra";
            this.registraBtn.UseVisualStyleBackColor = true;
            this.registraBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // esciBtn
            // 
            this.esciBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esciBtn.Location = new System.Drawing.Point(197, 161);
            this.esciBtn.Name = "esciBtn";
            this.esciBtn.Size = new System.Drawing.Size(136, 32);
            this.esciBtn.TabIndex = 5;
            this.esciBtn.Text = "abbandona";
            this.esciBtn.UseVisualStyleBackColor = true;
            this.esciBtn.Click += new System.EventHandler(this.esciBtn_Click);
            // 
            // insTecniciFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 366);
            this.Controls.Add(this.esciBtn);
            this.Controls.Add(this.registraBtn);
            this.Controls.Add(this.pswTxt);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "insTecniciFrm";
            this.Text = "Inserimento Tecnici";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.insTecniciFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.TextBox pswTxt;
        private System.Windows.Forms.Button registraBtn;
        private System.Windows.Forms.Button esciBtn;
    }
}