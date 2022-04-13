
namespace _05._02_Registrate
{
    partial class FrmRegistrate
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
            this.grb_InfoUsuario = new System.Windows.Forms.GroupBox();
            this.nud_Edad = new System.Windows.Forms.NumericUpDown();
            this.lbl_Edad = new System.Windows.Forms.Label();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.tb_Direccion = new System.Windows.Forms.TextBox();
            this.tb_Nombre = new System.Windows.Forms.TextBox();
            this.grb_Genero = new System.Windows.Forms.GroupBox();
            this.rd_No_Binario = new System.Windows.Forms.RadioButton();
            this.rb_Femenino = new System.Windows.Forms.RadioButton();
            this.rb_Masculino = new System.Windows.Forms.RadioButton();
            this.gb_Cursos = new System.Windows.Forms.GroupBox();
            this.chb_Javascript = new System.Windows.Forms.CheckBox();
            this.chb_Cmasmas = new System.Windows.Forms.CheckBox();
            this.chb_Csharp = new System.Windows.Forms.CheckBox();
            this.lsb_Pais = new System.Windows.Forms.ListBox();
            this.lbl_Pais = new System.Windows.Forms.Label();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.grb_InfoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Edad)).BeginInit();
            this.grb_Genero.SuspendLayout();
            this.gb_Cursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_InfoUsuario
            // 
            this.grb_InfoUsuario.Controls.Add(this.nud_Edad);
            this.grb_InfoUsuario.Controls.Add(this.lbl_Edad);
            this.grb_InfoUsuario.Controls.Add(this.lbl_Direccion);
            this.grb_InfoUsuario.Controls.Add(this.lbl_Nombre);
            this.grb_InfoUsuario.Controls.Add(this.tb_Direccion);
            this.grb_InfoUsuario.Controls.Add(this.tb_Nombre);
            this.grb_InfoUsuario.Location = new System.Drawing.Point(23, 12);
            this.grb_InfoUsuario.Name = "grb_InfoUsuario";
            this.grb_InfoUsuario.Size = new System.Drawing.Size(200, 148);
            this.grb_InfoUsuario.TabIndex = 0;
            this.grb_InfoUsuario.TabStop = false;
            this.grb_InfoUsuario.Text = "Detalles del Usuario";
            // 
            // nud_Edad
            // 
            this.nud_Edad.Location = new System.Drawing.Point(74, 103);
            this.nud_Edad.Name = "nud_Edad";
            this.nud_Edad.Size = new System.Drawing.Size(120, 23);
            this.nud_Edad.TabIndex = 1;
            this.nud_Edad.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lbl_Edad
            // 
            this.lbl_Edad.AutoSize = true;
            this.lbl_Edad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Edad.Location = new System.Drawing.Point(6, 105);
            this.lbl_Edad.Name = "lbl_Edad";
            this.lbl_Edad.Size = new System.Drawing.Size(33, 15);
            this.lbl_Edad.TabIndex = 1;
            this.lbl_Edad.Text = "Edad";
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Direccion.Location = new System.Drawing.Point(6, 68);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(60, 15);
            this.lbl_Direccion.TabIndex = 3;
            this.lbl_Direccion.Text = "Direccion";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nombre.Location = new System.Drawing.Point(6, 30);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(53, 15);
            this.lbl_Nombre.TabIndex = 1;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // tb_Direccion
            // 
            this.tb_Direccion.Location = new System.Drawing.Point(74, 60);
            this.tb_Direccion.Name = "tb_Direccion";
            this.tb_Direccion.Size = new System.Drawing.Size(120, 23);
            this.tb_Direccion.TabIndex = 2;
            // 
            // tb_Nombre
            // 
            this.tb_Nombre.Location = new System.Drawing.Point(74, 22);
            this.tb_Nombre.Name = "tb_Nombre";
            this.tb_Nombre.Size = new System.Drawing.Size(120, 23);
            this.tb_Nombre.TabIndex = 1;
            // 
            // grb_Genero
            // 
            this.grb_Genero.Controls.Add(this.rd_No_Binario);
            this.grb_Genero.Controls.Add(this.rb_Femenino);
            this.grb_Genero.Controls.Add(this.rb_Masculino);
            this.grb_Genero.Location = new System.Drawing.Point(284, 12);
            this.grb_Genero.Name = "grb_Genero";
            this.grb_Genero.Size = new System.Drawing.Size(175, 148);
            this.grb_Genero.TabIndex = 1;
            this.grb_Genero.TabStop = false;
            this.grb_Genero.Text = "Genero";
            // 
            // rd_No_Binario
            // 
            this.rd_No_Binario.AutoSize = true;
            this.rd_No_Binario.Location = new System.Drawing.Point(70, 101);
            this.rd_No_Binario.Name = "rd_No_Binario";
            this.rd_No_Binario.Size = new System.Drawing.Size(81, 19);
            this.rd_No_Binario.TabIndex = 2;
            this.rd_No_Binario.TabStop = true;
            this.rd_No_Binario.Text = "No binario";
            this.rd_No_Binario.UseVisualStyleBackColor = true;
            // 
            // rb_Femenino
            // 
            this.rb_Femenino.AutoSize = true;
            this.rb_Femenino.Location = new System.Drawing.Point(70, 66);
            this.rb_Femenino.Name = "rb_Femenino";
            this.rb_Femenino.Size = new System.Drawing.Size(78, 19);
            this.rb_Femenino.TabIndex = 1;
            this.rb_Femenino.TabStop = true;
            this.rb_Femenino.Text = "Femenino";
            this.rb_Femenino.UseVisualStyleBackColor = true;
            // 
            // rb_Masculino
            // 
            this.rb_Masculino.AutoSize = true;
            this.rb_Masculino.Location = new System.Drawing.Point(70, 30);
            this.rb_Masculino.Name = "rb_Masculino";
            this.rb_Masculino.Size = new System.Drawing.Size(80, 19);
            this.rb_Masculino.TabIndex = 0;
            this.rb_Masculino.TabStop = true;
            this.rb_Masculino.Text = "Masculino";
            this.rb_Masculino.UseVisualStyleBackColor = true;
            // 
            // gb_Cursos
            // 
            this.gb_Cursos.Controls.Add(this.chb_Javascript);
            this.gb_Cursos.Controls.Add(this.chb_Cmasmas);
            this.gb_Cursos.Controls.Add(this.chb_Csharp);
            this.gb_Cursos.Location = new System.Drawing.Point(284, 202);
            this.gb_Cursos.Name = "gb_Cursos";
            this.gb_Cursos.Size = new System.Drawing.Size(175, 116);
            this.gb_Cursos.TabIndex = 2;
            this.gb_Cursos.TabStop = false;
            this.gb_Cursos.Text = "Cursos";
            // 
            // chb_Javascript
            // 
            this.chb_Javascript.AutoSize = true;
            this.chb_Javascript.Location = new System.Drawing.Point(65, 85);
            this.chb_Javascript.Name = "chb_Javascript";
            this.chb_Javascript.Size = new System.Drawing.Size(78, 19);
            this.chb_Javascript.TabIndex = 2;
            this.chb_Javascript.Text = "JavaScript";
            this.chb_Javascript.UseVisualStyleBackColor = true;
            // 
            // chb_Cmasmas
            // 
            this.chb_Cmasmas.AutoSize = true;
            this.chb_Cmasmas.Location = new System.Drawing.Point(65, 60);
            this.chb_Cmasmas.Name = "chb_Cmasmas";
            this.chb_Cmasmas.Size = new System.Drawing.Size(50, 19);
            this.chb_Cmasmas.TabIndex = 1;
            this.chb_Cmasmas.Text = "C++";
            this.chb_Cmasmas.UseVisualStyleBackColor = true;
            // 
            // chb_Csharp
            // 
            this.chb_Csharp.AutoSize = true;
            this.chb_Csharp.Location = new System.Drawing.Point(65, 35);
            this.chb_Csharp.Name = "chb_Csharp";
            this.chb_Csharp.Size = new System.Drawing.Size(41, 19);
            this.chb_Csharp.TabIndex = 0;
            this.chb_Csharp.Text = "C#";
            this.chb_Csharp.UseVisualStyleBackColor = true;
            // 
            // lsb_Pais
            // 
            this.lsb_Pais.FormattingEnabled = true;
            this.lsb_Pais.ItemHeight = 15;
            this.lsb_Pais.Items.AddRange(new object[] {
            "Argentina",
            "Chile",
            "Uruguay"});
            this.lsb_Pais.Location = new System.Drawing.Point(29, 224);
            this.lsb_Pais.Name = "lsb_Pais";
            this.lsb_Pais.Size = new System.Drawing.Size(172, 94);
            this.lsb_Pais.TabIndex = 3;
            // 
            // lbl_Pais
            // 
            this.lbl_Pais.AutoSize = true;
            this.lbl_Pais.Location = new System.Drawing.Point(29, 206);
            this.lbl_Pais.Name = "lbl_Pais";
            this.lbl_Pais.Size = new System.Drawing.Size(28, 15);
            this.lbl_Pais.TabIndex = 4;
            this.lbl_Pais.Text = "Pais";
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.Location = new System.Drawing.Point(384, 343);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(75, 23);
            this.btn_Ingresar.TabIndex = 5;
            this.btn_Ingresar.Text = "Ingresar";
            this.btn_Ingresar.UseVisualStyleBackColor = true;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // FrmRegistrate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 378);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.lbl_Pais);
            this.Controls.Add(this.lsb_Pais);
            this.Controls.Add(this.gb_Cursos);
            this.Controls.Add(this.grb_Genero);
            this.Controls.Add(this.grb_InfoUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegistrate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grb_InfoUsuario.ResumeLayout(false);
            this.grb_InfoUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Edad)).EndInit();
            this.grb_Genero.ResumeLayout(false);
            this.grb_Genero.PerformLayout();
            this.gb_Cursos.ResumeLayout(false);
            this.gb_Cursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_InfoUsuario;
        private System.Windows.Forms.NumericUpDown nud_Edad;
        private System.Windows.Forms.Label lbl_Edad;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.TextBox tb_Direccion;
        private System.Windows.Forms.TextBox tb_Nombre;
        private System.Windows.Forms.GroupBox grb_Genero;
        private System.Windows.Forms.RadioButton rd_No_Binario;
        private System.Windows.Forms.RadioButton rb_Femenino;
        private System.Windows.Forms.RadioButton rb_Masculino;
        private System.Windows.Forms.GroupBox gb_Cursos;
        private System.Windows.Forms.CheckBox chb_Javascript;
        private System.Windows.Forms.CheckBox chb_Cmasmas;
        private System.Windows.Forms.CheckBox chb_Csharp;
        private System.Windows.Forms.ListBox lsb_Pais;
        private System.Windows.Forms.Label lbl_Pais;
        private System.Windows.Forms.Button btn_Ingresar;
    }
}

