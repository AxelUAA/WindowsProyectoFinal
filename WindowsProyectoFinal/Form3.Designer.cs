namespace WindowsProyectoFinal
{
    partial class Stock
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
            this.buttonMaq1 = new System.Windows.Forms.Button();
            this.buttonMaq2 = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMaq1
            // 
            this.buttonMaq1.BackColor = System.Drawing.Color.Transparent;
            this.buttonMaq1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMaq1.ForeColor = System.Drawing.Color.Transparent;
            this.buttonMaq1.Location = new System.Drawing.Point(48, 111);
            this.buttonMaq1.Name = "buttonMaq1";
            this.buttonMaq1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonMaq1.Size = new System.Drawing.Size(142, 191);
            this.buttonMaq1.TabIndex = 0;
            this.buttonMaq1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMaq1.UseVisualStyleBackColor = false;
            // 
            // buttonMaq2
            // 
            this.buttonMaq2.BackColor = System.Drawing.Color.Transparent;
            this.buttonMaq2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMaq2.ForeColor = System.Drawing.Color.Transparent;
            this.buttonMaq2.Location = new System.Drawing.Point(224, 111);
            this.buttonMaq2.Name = "buttonMaq2";
            this.buttonMaq2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonMaq2.Size = new System.Drawing.Size(129, 191);
            this.buttonMaq2.TabIndex = 1;
            this.buttonMaq2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMaq2.UseVisualStyleBackColor = false;
            this.buttonMaq2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.Transparent;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button.ForeColor = System.Drawing.Color.Transparent;
            this.button.Location = new System.Drawing.Point(450, 102);
            this.button.Name = "button";
            this.button.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button.Size = new System.Drawing.Size(211, 212);
            this.button.TabIndex = 2;
            this.button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button.UseVisualStyleBackColor = false;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsProyectoFinal.Properties.Resources.Screenshot_2024_11_27_113419;
            this.ClientSize = new System.Drawing.Size(1103, 621);
            this.Controls.Add(this.button);
            this.Controls.Add(this.buttonMaq2);
            this.Controls.Add(this.buttonMaq1);
            this.Name = "Stock";
            this.Text = "Stock";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMaq1;
        private System.Windows.Forms.Button buttonMaq2;
        private System.Windows.Forms.Button button;
    }
}