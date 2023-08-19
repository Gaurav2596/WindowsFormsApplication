namespace WindowsFormsApp
{
    partial class btnCreateFolder
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtproductid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtproductprice = new System.Windows.Forms.TextBox();
            this.btnwritetofile = new System.Windows.Forms.Button();
            this.btnreload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(301, 41);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(148, 36);
            this.btnCreateFile.TabIndex = 1;
            this.btnCreateFile.Text = "Create File";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product ID";
            // 
            // txtproductid
            // 
            this.txtproductid.Location = new System.Drawing.Point(129, 137);
            this.txtproductid.Name = "txtproductid";
            this.txtproductid.Size = new System.Drawing.Size(180, 22);
            this.txtproductid.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "ProductName";
            // 
            // txtproductname
            // 
            this.txtproductname.Location = new System.Drawing.Point(195, 185);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(200, 22);
            this.txtproductname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "ProductPrice";
            // 
            // txtproductprice
            // 
            this.txtproductprice.Location = new System.Drawing.Point(158, 247);
            this.txtproductprice.Name = "txtproductprice";
            this.txtproductprice.Size = new System.Drawing.Size(250, 22);
            this.txtproductprice.TabIndex = 7;
            // 
            // btnwritetofile
            // 
            this.btnwritetofile.Location = new System.Drawing.Point(140, 325);
            this.btnwritetofile.Name = "btnwritetofile";
            this.btnwritetofile.Size = new System.Drawing.Size(132, 23);
            this.btnwritetofile.TabIndex = 8;
            this.btnwritetofile.Text = "Write to file";
            this.btnwritetofile.UseVisualStyleBackColor = true;
            this.btnwritetofile.Click += new System.EventHandler(this.btnwritetofile_Click);
            // 
            // btnreload
            // 
            this.btnreload.Location = new System.Drawing.Point(301, 325);
            this.btnreload.Name = "btnreload";
            this.btnreload.Size = new System.Drawing.Size(171, 23);
            this.btnreload.TabIndex = 9;
            this.btnreload.Text = "Reload";
            this.btnreload.UseVisualStyleBackColor = true;
            this.btnreload.Click += new System.EventHandler(this.btnreload_Click);
            // 
            // btnCreateFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnreload);
            this.Controls.Add(this.btnwritetofile);
            this.Controls.Add(this.txtproductprice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtproductname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtproductid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.button1);
            this.Name = "btnCreateFolder";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.btnCreateFolder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtproductid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtproductname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtproductprice;
        private System.Windows.Forms.Button btnwritetofile;
        private System.Windows.Forms.Button btnreload;
    }
}