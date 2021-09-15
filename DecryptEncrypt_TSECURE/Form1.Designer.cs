namespace DecryptEncrypt_TSECURE
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
            this._btnconvert = new System.Windows.Forms.Button();
            this._txtfrom = new System.Windows.Forms.TextBox();
            this._txtto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._CbFuction = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // _btnconvert
            // 
            this._btnconvert.Location = new System.Drawing.Point(113, 163);
            this._btnconvert.Name = "_btnconvert";
            this._btnconvert.Size = new System.Drawing.Size(144, 37);
            this._btnconvert.TabIndex = 0;
            this._btnconvert.Text = "convert";
            this._btnconvert.UseVisualStyleBackColor = true;
            this._btnconvert.Click += new System.EventHandler(this._btnconvert_Click);
            // 
            // _txtfrom
            // 
            this._txtfrom.Location = new System.Drawing.Point(113, 74);
            this._txtfrom.Name = "_txtfrom";
            this._txtfrom.Size = new System.Drawing.Size(177, 20);
            this._txtfrom.TabIndex = 1;
            // 
            // _txtto
            // 
            this._txtto.Location = new System.Drawing.Point(113, 120);
            this._txtto.Name = "_txtto";
            this._txtto.Size = new System.Drawing.Size(177, 20);
            this._txtto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "FROM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "TO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "FUNCTION";
            // 
            // _CbFuction
            // 
            this._CbFuction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._CbFuction.FormattingEnabled = true;
            this._CbFuction.Items.AddRange(new object[] {
            "ENCRYPT",
            "DECRYPT"});
            this._CbFuction.Location = new System.Drawing.Point(112, 22);
            this._CbFuction.Name = "_CbFuction";
            this._CbFuction.Size = new System.Drawing.Size(141, 21);
            this._CbFuction.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 250);
            this.Controls.Add(this._CbFuction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtto);
            this.Controls.Add(this._txtfrom);
            this.Controls.Add(this._btnconvert);
            this.Name = "Form1";
            this.Text = "Encyript/Decrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnconvert;
        private System.Windows.Forms.TextBox _txtfrom;
        private System.Windows.Forms.TextBox _txtto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox _CbFuction;
    }
}

