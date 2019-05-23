namespace OOP_FileWriting_Example {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.rbTxt = new System.Windows.Forms.RadioButton();
            this.rbJson = new System.Windows.Forms.RadioButton();
            this.btnWrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(12, 12);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(183, 22);
            this.txtFilter.TabIndex = 0;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(201, 12);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "Filtrele";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lbProducts
            // 
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.ItemHeight = 16;
            this.lbProducts.Location = new System.Drawing.Point(12, 76);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(264, 212);
            this.lbProducts.TabIndex = 2;
            // 
            // rbTxt
            // 
            this.rbTxt.AutoSize = true;
            this.rbTxt.Checked = true;
            this.rbTxt.Location = new System.Drawing.Point(61, 307);
            this.rbTxt.Name = "rbTxt";
            this.rbTxt.Size = new System.Drawing.Size(47, 21);
            this.rbTxt.TabIndex = 3;
            this.rbTxt.TabStop = true;
            this.rbTxt.Text = ".txt";
            this.rbTxt.UseVisualStyleBackColor = true;
            // 
            // rbJson
            // 
            this.rbJson.AutoSize = true;
            this.rbJson.Location = new System.Drawing.Point(152, 307);
            this.rbJson.Name = "rbJson";
            this.rbJson.Size = new System.Drawing.Size(59, 21);
            this.rbJson.TabIndex = 4;
            this.rbJson.Text = ".json";
            this.rbJson.UseVisualStyleBackColor = true;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(82, 367);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(129, 23);
            this.btnWrite.TabIndex = 5;
            this.btnWrite.Text = "Yaz";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 529);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.rbJson);
            this.Controls.Add(this.rbTxt);
            this.Controls.Add(this.lbProducts);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.txtFilter);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.RadioButton rbTxt;
        private System.Windows.Forms.RadioButton rbJson;
        private System.Windows.Forms.Button btnWrite;
    }
}