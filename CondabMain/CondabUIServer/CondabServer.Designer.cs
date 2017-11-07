namespace CondabUIServer
{
    partial class CondabServer
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
            this.HeaderText = new System.Windows.Forms.Label();
            this.ServerAddress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fileUpload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderText
            // 
            this.HeaderText.AutoSize = true;
            this.HeaderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderText.Location = new System.Drawing.Point(27, 21);
            this.HeaderText.Name = "HeaderText";
            this.HeaderText.Size = new System.Drawing.Size(434, 37);
            this.HeaderText.TabIndex = 1;
            this.HeaderText.Text = "Condab Demo Server v0.01";
            // 
            // ServerAddress
            // 
            this.ServerAddress.AutoSize = true;
            this.ServerAddress.Location = new System.Drawing.Point(31, 74);
            this.ServerAddress.Name = "ServerAddress";
            this.ServerAddress.Size = new System.Drawing.Size(79, 13);
            this.ServerAddress.TabIndex = 2;
            this.ServerAddress.Text = "Server Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Server Balance";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fileUpload
            // 
            this.fileUpload.Location = new System.Drawing.Point(34, 127);
            this.fileUpload.Name = "fileUpload";
            this.fileUpload.Size = new System.Drawing.Size(141, 46);
            this.fileUpload.TabIndex = 4;
            this.fileUpload.Text = "Upload File";
            this.fileUpload.UseVisualStyleBackColor = true;
            // 
            // CondabServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 616);
            this.Controls.Add(this.fileUpload);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServerAddress);
            this.Controls.Add(this.HeaderText);
            this.Name = "CondabServer";
            this.Text = "Condab Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderText;
        private System.Windows.Forms.Label ServerAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fileUpload;
    }
}

