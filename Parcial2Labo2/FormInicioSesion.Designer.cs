
namespace Parcial2Labo2
{
    partial class FormInicioSesion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicioSesion));
            this.imgn_inicio = new System.Windows.Forms.PictureBox();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_registrarse = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.PictureBox();
            this.lbl_MsgError = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Invitado = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.img_SonidoDesactivado = new System.Windows.Forms.PictureBox();
            this.img_SonidoActivo = new System.Windows.Forms.PictureBox();
            this.btn_AutoComplete = new System.Windows.Forms.Button();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgn_inicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Salir)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_SonidoDesactivado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_SonidoActivo)).BeginInit();
            this.SuspendLayout();
            // 
            // imgn_inicio
            // 
            this.imgn_inicio.BackColor = System.Drawing.Color.Black;
            this.imgn_inicio.Image = ((System.Drawing.Image)(resources.GetObject("imgn_inicio.Image")));
            this.imgn_inicio.Location = new System.Drawing.Point(12, -68);
            this.imgn_inicio.Name = "imgn_inicio";
            this.imgn_inicio.Size = new System.Drawing.Size(1145, 462);
            this.imgn_inicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgn_inicio.TabIndex = 0;
            this.imgn_inicio.TabStop = false;
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.BackColor = System.Drawing.Color.Black;
            this.txt_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Usuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_Usuario.ForeColor = System.Drawing.Color.White;
            this.txt_Usuario.Location = new System.Drawing.Point(12, 14);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.PlaceholderText = "Username";
            this.txt_Usuario.Size = new System.Drawing.Size(264, 23);
            this.txt_Usuario.TabIndex = 1;
            // 
            // txt_Pass
            // 
            this.txt_Pass.AccessibleDescription = "";
            this.txt_Pass.AccessibleName = "";
            this.txt_Pass.BackColor = System.Drawing.Color.Black;
            this.txt_Pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Pass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_Pass.ForeColor = System.Drawing.Color.White;
            this.txt_Pass.Location = new System.Drawing.Point(12, 52);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.PlaceholderText = "Password";
            this.txt_Pass.Size = new System.Drawing.Size(264, 23);
            this.txt_Pass.TabIndex = 2;
            this.txt_Pass.Tag = "PASS";
            this.txt_Pass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "DRK GENERALA";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "INICIAR SESION";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(12, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "No tenes una cuenta? create una gratis! clickeando....";
            // 
            // btn_registrarse
            // 
            this.btn_registrarse.AutoSize = true;
            this.btn_registrarse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registrarse.ForeColor = System.Drawing.Color.Red;
            this.btn_registrarse.Location = new System.Drawing.Point(294, 289);
            this.btn_registrarse.Name = "btn_registrarse";
            this.btn_registrarse.Size = new System.Drawing.Size(64, 15);
            this.btn_registrarse.TabIndex = 7;
            this.btn_registrarse.Text = "Registrarse";
            this.btn_registrarse.Click += new System.EventHandler(this.btn_registrarse_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.Location = new System.Drawing.Point(871, 12);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(51, 50);
            this.btn_Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Salir.TabIndex = 8;
            this.btn_Salir.TabStop = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // lbl_MsgError
            // 
            this.lbl_MsgError.AutoSize = true;
            this.lbl_MsgError.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MsgError.ForeColor = System.Drawing.Color.Red;
            this.lbl_MsgError.Location = new System.Drawing.Point(42, 78);
            this.lbl_MsgError.Name = "lbl_MsgError";
            this.lbl_MsgError.Size = new System.Drawing.Size(195, 15);
            this.lbl_MsgError.TabIndex = 9;
            this.lbl_MsgError.Text = "Debes completar todos los campos ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btn_Invitado);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbl_MsgError);
            this.panel1.Controls.Add(this.txt_Usuario);
            this.panel1.Controls.Add(this.txt_Pass);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 187);
            this.panel1.TabIndex = 10;
            // 
            // btn_Invitado
            // 
            this.btn_Invitado.BackColor = System.Drawing.Color.Maroon;
            this.btn_Invitado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Invitado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Invitado.ForeColor = System.Drawing.Color.White;
            this.btn_Invitado.Location = new System.Drawing.Point(66, 148);
            this.btn_Invitado.Name = "btn_Invitado";
            this.btn_Invitado.Size = new System.Drawing.Size(148, 25);
            this.btn_Invitado.TabIndex = 12;
            this.btn_Invitado.Text = "JUGAR COMO INVITADO";
            this.btn_Invitado.UseVisualStyleBackColor = false;
            this.btn_Invitado.Click += new System.EventHandler(this.btn_Invitado_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-217, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(590, 791);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(773, 192);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(252, 371);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-173, 192);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(531, 367);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // img_SonidoDesactivado
            // 
            this.img_SonidoDesactivado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_SonidoDesactivado.Image = ((System.Drawing.Image)(resources.GetObject("img_SonidoDesactivado.Image")));
            this.img_SonidoDesactivado.Location = new System.Drawing.Point(867, 82);
            this.img_SonidoDesactivado.Name = "img_SonidoDesactivado";
            this.img_SonidoDesactivado.Size = new System.Drawing.Size(55, 55);
            this.img_SonidoDesactivado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_SonidoDesactivado.TabIndex = 13;
            this.img_SonidoDesactivado.TabStop = false;
            this.img_SonidoDesactivado.Click += new System.EventHandler(this.img_SonidoDesactivado_Click);
            // 
            // img_SonidoActivo
            // 
            this.img_SonidoActivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_SonidoActivo.Image = ((System.Drawing.Image)(resources.GetObject("img_SonidoActivo.Image")));
            this.img_SonidoActivo.Location = new System.Drawing.Point(846, 68);
            this.img_SonidoActivo.Name = "img_SonidoActivo";
            this.img_SonidoActivo.Size = new System.Drawing.Size(99, 87);
            this.img_SonidoActivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_SonidoActivo.TabIndex = 14;
            this.img_SonidoActivo.TabStop = false;
            this.img_SonidoActivo.Click += new System.EventHandler(this.img_SonidoActivo_Click);
            // 
            // btn_AutoComplete
            // 
            this.btn_AutoComplete.BackColor = System.Drawing.Color.Maroon;
            this.btn_AutoComplete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AutoComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AutoComplete.ForeColor = System.Drawing.Color.White;
            this.btn_AutoComplete.Location = new System.Drawing.Point(93, 255);
            this.btn_AutoComplete.Name = "btn_AutoComplete";
            this.btn_AutoComplete.Size = new System.Drawing.Size(115, 24);
            this.btn_AutoComplete.TabIndex = 13;
            this.btn_AutoComplete.Text = "AUTOCOMPLETAR";
            this.btn_AutoComplete.UseVisualStyleBackColor = false;
            this.btn_AutoComplete.Click += new System.EventHandler(this.btn_AutoComplete_Click);
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Fecha.Location = new System.Drawing.Point(12, 41);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(208, 15);
            this.lbl_Fecha.TabIndex = 13;
            this.lbl_Fecha.Text = "Jugar a la generala nunca fue tan facil!";
            // 
            // FormInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(934, 349);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.btn_AutoComplete);
            this.Controls.Add(this.img_SonidoActivo);
            this.Controls.Add(this.img_SonidoDesactivado);
            this.Controls.Add(this.btn_registrarse);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imgn_inicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInicioSesion";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INICIO DE SESION DRK";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgn_inicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Salir)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_SonidoDesactivado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_SonidoActivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgn_inicio;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label btn_registrarse;
        private System.Windows.Forms.PictureBox btn_Salir;
        private System.Windows.Forms.Label lbl_MsgError;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox img_SonidoDesactivado;
        private System.Windows.Forms.PictureBox img_SonidoActivo;
        private System.Windows.Forms.Button btn_Invitado;
        private System.Windows.Forms.Button btn_AutoComplete;
        private System.Windows.Forms.Label lbl_Fecha;
    }
}

