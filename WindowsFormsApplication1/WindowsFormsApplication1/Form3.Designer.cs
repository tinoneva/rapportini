namespace WindowsFormsApplication1
{
    partial class frmPagamenti
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
            this.pagamentiDgv = new System.Windows.Forms.DataGridView();
            this.codiceTxt = new System.Windows.Forms.TextBox();
            this.descrizioneTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentiDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // pagamentiDgv
            // 
            this.pagamentiDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pagamentiDgv.Location = new System.Drawing.Point(280, 12);
            this.pagamentiDgv.Name = "pagamentiDgv";
            this.pagamentiDgv.Size = new System.Drawing.Size(260, 297);
            this.pagamentiDgv.TabIndex = 0;
            this.pagamentiDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pagamentiDgv_CellContentClick);
            // 
            // codiceTxt
            // 
            this.codiceTxt.Location = new System.Drawing.Point(118, 12);
            this.codiceTxt.Name = "codiceTxt";
            this.codiceTxt.Size = new System.Drawing.Size(137, 20);
            this.codiceTxt.TabIndex = 1;
            // 
            // descrizioneTxt
            // 
            this.descrizioneTxt.Location = new System.Drawing.Point(118, 56);
            this.descrizioneTxt.Name = "descrizioneTxt";
            this.descrizioneTxt.Size = new System.Drawing.Size(137, 20);
            this.descrizioneTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Codice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descrizione";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Registra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Abbandona";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmPagamenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 366);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descrizioneTxt);
            this.Controls.Add(this.codiceTxt);
            this.Controls.Add(this.pagamentiDgv);
            this.Name = "frmPagamenti";
            this.Text = "Gestione Rapportini - archivio pagamenti";
            this.Load += new System.EventHandler(this.frmPagamenti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pagamentiDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView pagamentiDgv;
        private System.Windows.Forms.TextBox codiceTxt;
        private System.Windows.Forms.TextBox descrizioneTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}