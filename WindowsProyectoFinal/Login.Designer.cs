namespace WindowsProyectoFinal
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panLogin1 = new System.Windows.Forms.Panel();
            this.panelUsuarios = new System.Windows.Forms.Panel();
            this.radioInvitado = new System.Windows.Forms.RadioButton();
            this.radioUsuario = new System.Windows.Forms.RadioButton();
            this.radioAdmin = new System.Windows.Forms.RadioButton();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labeluser = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtBoxContra = new System.Windows.Forms.TextBox();
            this.bSalirLogin = new System.Windows.Forms.Button();
            this.bRegreLogin = new System.Windows.Forms.Button();
            this.labelSlogan = new System.Windows.Forms.Label();
            this.panLogin2 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelEslogan = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtBoxUsuario = new System.Windows.Forms.TextBox();
            this.panLogin1.SuspendLayout();
            this.panelUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panLogin2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panLogin1
            // 
            this.panLogin1.AutoScroll = true;
            this.panLogin1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panLogin1.Controls.Add(this.panelUsuarios);
            this.panLogin1.Controls.Add(this.btnUsuarios);
            this.panLogin1.Controls.Add(this.pictureBox1);
            this.panLogin1.Location = new System.Drawing.Point(0, 0);
            this.panLogin1.Name = "panLogin1";
            this.panLogin1.Size = new System.Drawing.Size(196, 767);
            this.panLogin1.TabIndex = 0;
            // 
            // panelUsuarios
            // 
            this.panelUsuarios.Controls.Add(this.radioInvitado);
            this.panelUsuarios.Controls.Add(this.radioUsuario);
            this.panelUsuarios.Controls.Add(this.radioAdmin);
            this.panelUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsuarios.Location = new System.Drawing.Point(0, 245);
            this.panelUsuarios.Name = "panelUsuarios";
            this.panelUsuarios.Size = new System.Drawing.Size(196, 202);
            this.panelUsuarios.TabIndex = 2;
            // 
            // radioInvitado
            // 
            this.radioInvitado.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioInvitado.Font = new System.Drawing.Font("Segoe UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioInvitado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioInvitado.Location = new System.Drawing.Point(0, 100);
            this.radioInvitado.Name = "radioInvitado";
            this.radioInvitado.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.radioInvitado.Size = new System.Drawing.Size(196, 50);
            this.radioInvitado.TabIndex = 2;
            this.radioInvitado.TabStop = true;
            this.radioInvitado.Text = "INVITADO";
            this.radioInvitado.UseVisualStyleBackColor = true;
            // 
            // radioUsuario
            // 
            this.radioUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioUsuario.Font = new System.Drawing.Font("Segoe UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioUsuario.Location = new System.Drawing.Point(0, 50);
            this.radioUsuario.Name = "radioUsuario";
            this.radioUsuario.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.radioUsuario.Size = new System.Drawing.Size(196, 50);
            this.radioUsuario.TabIndex = 1;
            this.radioUsuario.TabStop = true;
            this.radioUsuario.Text = "USUARIO";
            this.radioUsuario.UseVisualStyleBackColor = true;
            // 
            // radioAdmin
            // 
            this.radioAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioAdmin.Font = new System.Drawing.Font("Segoe UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioAdmin.Location = new System.Drawing.Point(0, 0);
            this.radioAdmin.Name = "radioAdmin";
            this.radioAdmin.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.radioAdmin.Size = new System.Drawing.Size(196, 50);
            this.radioAdmin.TabIndex = 0;
            this.radioAdmin.TabStop = true;
            this.radioAdmin.Text = "ADMINISTRADOR";
            this.radioAdmin.UseVisualStyleBackColor = true;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 196);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(196, 49);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Text = "USUARIOS";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxLogin.Controls.Add(this.label1);
            this.groupBoxLogin.Controls.Add(this.labeluser);
            this.groupBoxLogin.Controls.Add(this.pictureBox2);
            this.groupBoxLogin.Controls.Add(this.txtBoxContra);
            this.groupBoxLogin.Controls.Add(this.txtBoxUsuario);
            this.groupBoxLogin.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxLogin.Location = new System.Drawing.Point(279, 125);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(821, 410);
            this.groupBoxLogin.TabIndex = 2;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "BIENVENIDO";
            this.groupBoxLogin.Enter += new System.EventHandler(this.groupBoxLogin_Enter);
            this.groupBoxLogin.Leave += new System.EventHandler(this.txtBoxUsuario_Leave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(185, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 2);
            this.label1.TabIndex = 3;
            // 
            // labeluser
            // 
            this.labeluser.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labeluser.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labeluser.Location = new System.Drawing.Point(191, 226);
            this.labeluser.Name = "labeluser";
            this.labeluser.Size = new System.Drawing.Size(495, 2);
            this.labeluser.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(335, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 145);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // txtBoxContra
            // 
            this.txtBoxContra.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtBoxContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxContra.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxContra.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtBoxContra.Location = new System.Drawing.Point(191, 281);
            this.txtBoxContra.Name = "txtBoxContra";
            this.txtBoxContra.Size = new System.Drawing.Size(489, 31);
            this.txtBoxContra.TabIndex = 1;
            this.txtBoxContra.Text = "CONTRASEÑA";
            this.txtBoxContra.TextChanged += new System.EventHandler(this.txtBoxContra_TextChanged);
            this.txtBoxContra.Enter += new System.EventHandler(this.txtBoxContra_Enter);
            this.txtBoxContra.Leave += new System.EventHandler(this.txtBoxContra_Leave);
            // 
            // bSalirLogin
            // 
            this.bSalirLogin.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSalirLogin.Location = new System.Drawing.Point(733, 640);
            this.bSalirLogin.Name = "bSalirLogin";
            this.bSalirLogin.Size = new System.Drawing.Size(152, 44);
            this.bSalirLogin.TabIndex = 3;
            this.bSalirLogin.Text = "SALIR";
            this.bSalirLogin.UseVisualStyleBackColor = true;
            this.bSalirLogin.Click += new System.EventHandler(this.bSalirLogin_Click);
            this.bSalirLogin.MouseEnter += new System.EventHandler(this.bSalirLogin_Enter);
            this.bSalirLogin.MouseLeave += new System.EventHandler(this.bSalirLogin_Leave);
            // 
            // bRegreLogin
            // 
            this.bRegreLogin.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRegreLogin.Location = new System.Drawing.Point(915, 640);
            this.bRegreLogin.Name = "bRegreLogin";
            this.bRegreLogin.Size = new System.Drawing.Size(153, 44);
            this.bRegreLogin.TabIndex = 4;
            this.bRegreLogin.Text = "REGRESAR";
            this.bRegreLogin.UseVisualStyleBackColor = true;
            this.bRegreLogin.Click += new System.EventHandler(this.bRegreLogin_Click);
            this.bRegreLogin.MouseEnter += new System.EventHandler(this.bRegreLogin_Enter);
            this.bRegreLogin.MouseLeave += new System.EventHandler(this.bRegreLogin_Leave);
            // 
            // labelSlogan
            // 
            this.labelSlogan.AutoSize = true;
            this.labelSlogan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelSlogan.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSlogan.Location = new System.Drawing.Point(3, 17);
            this.labelSlogan.Name = "labelSlogan";
            this.labelSlogan.Size = new System.Drawing.Size(0, 54);
            this.labelSlogan.TabIndex = 0;
            this.labelSlogan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSlogan.Click += new System.EventHandler(this.labelSlogan_Click);
            // 
            // panLogin2
            // 
            this.panLogin2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panLogin2.Controls.Add(this.labelSlogan);
            this.panLogin2.Controls.Add(this.labelEslogan);
            this.panLogin2.Location = new System.Drawing.Point(195, 0);
            this.panLogin2.Name = "panLogin2";
            this.panLogin2.Size = new System.Drawing.Size(979, 104);
            this.panLogin2.TabIndex = 1;
            // 
            // labelEslogan
            // 
            this.labelEslogan.AutoSize = true;
            this.labelEslogan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelEslogan.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEslogan.ForeColor = System.Drawing.SystemColors.Window;
            this.labelEslogan.Location = new System.Drawing.Point(9, 0);
            this.labelEslogan.Name = "labelEslogan";
            this.labelEslogan.Padding = new System.Windows.Forms.Padding(230, 30, 0, 0);
            this.labelEslogan.Size = new System.Drawing.Size(730, 71);
            this.labelEslogan.TabIndex = 1;
            this.labelEslogan.Text = "CALIDAD QUE DEFINE TU ESTILO";
            this.labelEslogan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIngresar.Location = new System.Drawing.Point(546, 558);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(297, 51);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            this.btnIngresar.MouseEnter += new System.EventHandler(this.btnIngresar_MouseEnter);
            this.btnIngresar.MouseLeave += new System.EventHandler(this.btnIngresar_MouseLeave);
            // 
            // txtBoxUsuario
            // 
            this.txtBoxUsuario.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxUsuario.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUsuario.ForeColor = System.Drawing.Color.White;
            this.txtBoxUsuario.Location = new System.Drawing.Point(191, 192);
            this.txtBoxUsuario.Name = "txtBoxUsuario";
            this.txtBoxUsuario.Size = new System.Drawing.Size(489, 31);
            this.txtBoxUsuario.TabIndex = 0;
            this.txtBoxUsuario.Text = "USUARIO";
            this.txtBoxUsuario.TextChanged += new System.EventHandler(this.txtBoxUsuario_TextChanged);
            this.txtBoxUsuario.Enter += new System.EventHandler(this.txtBoxUsuario_Enter);
            this.txtBoxUsuario.Leave += new System.EventHandler(this.txtBoxUsuario_Leave);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1174, 767);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.bRegreLogin);
            this.Controls.Add(this.bSalirLogin);
            this.Controls.Add(this.groupBoxLogin);
            this.Controls.Add(this.panLogin2);
            this.Controls.Add(this.panLogin1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panLogin1.ResumeLayout(false);
            this.panelUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panLogin2.ResumeLayout(false);
            this.panLogin2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panLogin1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.Button bSalirLogin;
        private System.Windows.Forms.Button bRegreLogin;
        private System.Windows.Forms.Label labelSlogan;
        private System.Windows.Forms.FlowLayoutPanel panLogin2;
        private System.Windows.Forms.TextBox txtBoxContra;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeluser;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Panel panelUsuarios;
        private System.Windows.Forms.RadioButton radioAdmin;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.RadioButton radioInvitado;
        private System.Windows.Forms.RadioButton radioUsuario;
        private System.Windows.Forms.Label labelEslogan;
        private System.Windows.Forms.TextBox txtBoxUsuario;
    }
}