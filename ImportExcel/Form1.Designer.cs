namespace ImportExcel
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
            this.txtBoxPath = new System.Windows.Forms.TextBox();
            this.btnPick = new System.Windows.Forms.Button();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtbox_codeEAN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxPath
            // 
            this.txtBoxPath.Location = new System.Drawing.Point(31, 28);
            this.txtBoxPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBoxPath.Multiline = true;
            this.txtBoxPath.Name = "txtBoxPath";
            this.txtBoxPath.Size = new System.Drawing.Size(406, 23);
            this.txtBoxPath.TabIndex = 0;
            // 
            // btnPick
            // 
            this.btnPick.Location = new System.Drawing.Point(445, 26);
            this.btnPick.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(70, 25);
            this.btnPick.TabIndex = 1;
            this.btnPick.Text = "Wybierz";
            this.btnPick.UseVisualStyleBackColor = true;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            // 
            // ListBox
            // 
            this.ListBox.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 16;
            this.ListBox.Location = new System.Drawing.Point(32, 139);
            this.ListBox.MultiColumn = true;
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(483, 100);
            this.ListBox.TabIndex = 2;
            this.ListBox.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(444, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 22);
            this.button1.TabIndex = 3;
            this.button1.Text = "+";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbox_codeEAN
            // 
            this.txtbox_codeEAN.Location = new System.Drawing.Point(32, 111);
            this.txtbox_codeEAN.Name = "txtbox_codeEAN";
            this.txtbox_codeEAN.Size = new System.Drawing.Size(406, 22);
            this.txtbox_codeEAN.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Scieżka do pliku";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Filtruj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(549, 322);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_codeEAN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.btnPick);
            this.Controls.Add(this.txtBoxPath);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Import";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxPath;
        private System.Windows.Forms.Button btnPick;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtbox_codeEAN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

