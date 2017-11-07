namespace CondabUI
{
    partial class CondabClient
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
            this.authorsListbox = new System.Windows.Forms.ListBox();
            this.authorsListboxlabel = new System.Windows.Forms.Label();
            this.itemsListboxlabel = new System.Windows.Forms.Label();
            this.itemsListbox = new System.Windows.Forms.ListBox();
            this.addItemtoCart = new System.Windows.Forms.Button();
            this.CartListBoxLabel = new System.Windows.Forms.Label();
            this.CartListBox = new System.Windows.Forms.ListBox();
            this.removeItemfromCart = new System.Windows.Forms.Button();
            this.purchaseCart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderText
            // 
            this.HeaderText.AutoSize = true;
            this.HeaderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderText.Location = new System.Drawing.Point(26, 24);
            this.HeaderText.Name = "HeaderText";
            this.HeaderText.Size = new System.Drawing.Size(423, 37);
            this.HeaderText.TabIndex = 0;
            this.HeaderText.Text = "Condab Demo Client v0.01";
            // 
            // authorsListbox
            // 
            this.authorsListbox.FormattingEnabled = true;
            this.authorsListbox.Location = new System.Drawing.Point(33, 97);
            this.authorsListbox.Name = "authorsListbox";
            this.authorsListbox.Size = new System.Drawing.Size(193, 485);
            this.authorsListbox.TabIndex = 1;
            this.authorsListbox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // authorsListboxlabel
            // 
            this.authorsListboxlabel.AutoEllipsis = true;
            this.authorsListboxlabel.AutoSize = true;
            this.authorsListboxlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorsListboxlabel.Location = new System.Drawing.Point(30, 81);
            this.authorsListboxlabel.Name = "authorsListboxlabel";
            this.authorsListboxlabel.Size = new System.Drawing.Size(50, 13);
            this.authorsListboxlabel.TabIndex = 2;
            this.authorsListboxlabel.Text = "Authors";
            this.authorsListboxlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // itemsListboxlabel
            // 
            this.itemsListboxlabel.AutoEllipsis = true;
            this.itemsListboxlabel.AutoSize = true;
            this.itemsListboxlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsListboxlabel.Location = new System.Drawing.Point(297, 81);
            this.itemsListboxlabel.Name = "itemsListboxlabel";
            this.itemsListboxlabel.Size = new System.Drawing.Size(101, 13);
            this.itemsListboxlabel.TabIndex = 3;
            this.itemsListboxlabel.Text = "Books By Author";
            // 
            // itemsListbox
            // 
            this.itemsListbox.FormattingEnabled = true;
            this.itemsListbox.Location = new System.Drawing.Point(300, 97);
            this.itemsListbox.Name = "itemsListbox";
            this.itemsListbox.Size = new System.Drawing.Size(193, 420);
            this.itemsListbox.TabIndex = 4;
            // 
            // addItemtoCart
            // 
            this.addItemtoCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemtoCart.Location = new System.Drawing.Point(300, 535);
            this.addItemtoCart.Name = "addItemtoCart";
            this.addItemtoCart.Size = new System.Drawing.Size(193, 58);
            this.addItemtoCart.TabIndex = 5;
            this.addItemtoCart.Text = "Add To Cart ->";
            this.addItemtoCart.UseVisualStyleBackColor = true;
            this.addItemtoCart.Click += new System.EventHandler(this.button1_Click);
            // 
            // CartListBoxLabel
            // 
            this.CartListBoxLabel.AutoEllipsis = true;
            this.CartListBoxLabel.AutoSize = true;
            this.CartListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartListBoxLabel.Location = new System.Drawing.Point(557, 81);
            this.CartListBoxLabel.Name = "CartListBoxLabel";
            this.CartListBoxLabel.Size = new System.Drawing.Size(30, 13);
            this.CartListBoxLabel.TabIndex = 6;
            this.CartListBoxLabel.Text = "Cart";
            // 
            // CartListBox
            // 
            this.CartListBox.FormattingEnabled = true;
            this.CartListBox.Location = new System.Drawing.Point(560, 97);
            this.CartListBox.Name = "CartListBox";
            this.CartListBox.Size = new System.Drawing.Size(300, 420);
            this.CartListBox.TabIndex = 7;
            // 
            // removeItemfromCart
            // 
            this.removeItemfromCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeItemfromCart.Location = new System.Drawing.Point(560, 535);
            this.removeItemfromCart.Name = "removeItemfromCart";
            this.removeItemfromCart.Size = new System.Drawing.Size(300, 58);
            this.removeItemfromCart.TabIndex = 8;
            this.removeItemfromCart.Text = "<- Remove From Cart";
            this.removeItemfromCart.UseVisualStyleBackColor = true;
            // 
            // purchaseCart
            // 
            this.purchaseCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseCart.Location = new System.Drawing.Point(943, 97);
            this.purchaseCart.Name = "purchaseCart";
            this.purchaseCart.Size = new System.Drawing.Size(193, 36);
            this.purchaseCart.TabIndex = 9;
            this.purchaseCart.Text = "Purchase Cart";
            this.purchaseCart.UseVisualStyleBackColor = true;
            // 
            // CondabClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 616);
            this.Controls.Add(this.purchaseCart);
            this.Controls.Add(this.removeItemfromCart);
            this.Controls.Add(this.CartListBox);
            this.Controls.Add(this.CartListBoxLabel);
            this.Controls.Add(this.addItemtoCart);
            this.Controls.Add(this.itemsListbox);
            this.Controls.Add(this.itemsListboxlabel);
            this.Controls.Add(this.authorsListboxlabel);
            this.Controls.Add(this.authorsListbox);
            this.Controls.Add(this.HeaderText);
            this.Name = "CondabClient";
            this.Text = "Condab Client";
            this.Load += new System.EventHandler(this.Condab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderText;
        private System.Windows.Forms.ListBox authorsListbox;
        private System.Windows.Forms.Label authorsListboxlabel;
        private System.Windows.Forms.Label itemsListboxlabel;
        private System.Windows.Forms.ListBox itemsListbox;
        private System.Windows.Forms.Button addItemtoCart;
        private System.Windows.Forms.Label CartListBoxLabel;
        private System.Windows.Forms.ListBox CartListBox;
        private System.Windows.Forms.Button removeItemfromCart;
        private System.Windows.Forms.Button purchaseCart;
    }
}

