namespace LetterToBinary
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
            this.btWhite = new System.Windows.Forms.Button();
            this.btBlack = new System.Windows.Forms.Button();
            this.tbOut = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btWhite
            // 
            this.btWhite.Location = new System.Drawing.Point(130, 9);
            this.btWhite.Name = "btWhite";
            this.btWhite.Size = new System.Drawing.Size(144, 25);
            this.btWhite.TabIndex = 0;
            this.btWhite.Text = "All white";
            this.btWhite.UseVisualStyleBackColor = true;
            this.btWhite.Click += new System.EventHandler(this.btWhite_Click);
            // 
            // btBlack
            // 
            this.btBlack.Location = new System.Drawing.Point(130, 40);
            this.btBlack.Name = "btBlack";
            this.btBlack.Size = new System.Drawing.Size(144, 25);
            this.btBlack.TabIndex = 1;
            this.btBlack.Text = "All black";
            this.btBlack.UseVisualStyleBackColor = true;
            this.btBlack.Click += new System.EventHandler(this.btBlack_Click);
            // 
            // tbOut
            // 
            this.tbOut.Location = new System.Drawing.Point(130, 71);
            this.tbOut.Multiline = true;
            this.tbOut.Name = "tbOut";
            this.tbOut.ReadOnly = true;
            this.tbOut.Size = new System.Drawing.Size(144, 76);
            this.tbOut.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "COPY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 188);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbOut);
            this.Controls.Add(this.btBlack);
            this.Controls.Add(this.btWhite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LetterToBinary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btWhite;
        private System.Windows.Forms.Button btBlack;
        private System.Windows.Forms.TextBox tbOut;
        private System.Windows.Forms.Button button1;



    }
}

