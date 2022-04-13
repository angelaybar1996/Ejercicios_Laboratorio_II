
namespace _05._01_Hola_Windows_Forms
{
    partial class FrmIngreso
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
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.tb_Nombre = new System.Windows.Forms.TextBox();
            this.tb_Apellido = new System.Windows.Forms.TextBox();
            this.btn_saludar = new System.Windows.Forms.Button();
            this.cmb_Materias = new System.Windows.Forms.ComboBox();
            this.lbl_Materias = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Name.Location = new System.Drawing.Point(110, 46);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(53, 15);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Nombre";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Apellido.Location = new System.Drawing.Point(377, 46);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(52, 15);
            this.lbl_Apellido.TabIndex = 1;
            this.lbl_Apellido.Text = "Apellido";
            // 
            // tb_Nombre
            // 
            this.tb_Nombre.Location = new System.Drawing.Point(110, 76);
            this.tb_Nombre.Name = "tb_Nombre";
            this.tb_Nombre.PlaceholderText = "Ingrese Nombre";
            this.tb_Nombre.Size = new System.Drawing.Size(136, 23);
            this.tb_Nombre.TabIndex = 2;
            // 
            // tb_Apellido
            // 
            this.tb_Apellido.Location = new System.Drawing.Point(377, 76);
            this.tb_Apellido.Name = "tb_Apellido";
            this.tb_Apellido.PlaceholderText = "Ingrese apellido";
            this.tb_Apellido.Size = new System.Drawing.Size(123, 23);
            this.tb_Apellido.TabIndex = 3;
            // 
            // btn_saludar
            // 
            this.btn_saludar.Location = new System.Drawing.Point(501, 172);
            this.btn_saludar.Name = "btn_saludar";
            this.btn_saludar.Size = new System.Drawing.Size(134, 35);
            this.btn_saludar.TabIndex = 4;
            this.btn_saludar.Text = "Saludar";
            this.btn_saludar.UseVisualStyleBackColor = true;
            this.btn_saludar.Click += new System.EventHandler(this.btn_saludar_Click);
            // 
            // cmb_Materias
            // 
            this.cmb_Materias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Materias.FormattingEnabled = true;
            this.cmb_Materias.Items.AddRange(new object[] {
            "Ingles I",
            "Laboratorio I",
            "Programacion I",
            "Sistemas de procesamiento de datos",
            "Matematicas",
            "Ingles II",
            "Laboratorio II",
            "Programacion II",
            "Arquitectura y Sistemas Operativos",
            "Metodologia de la investigacion",
            "Estadisticas"});
            this.cmb_Materias.Location = new System.Drawing.Point(110, 147);
            this.cmb_Materias.Name = "cmb_Materias";
            this.cmb_Materias.Size = new System.Drawing.Size(213, 23);
            this.cmb_Materias.TabIndex = 5;
            // 
            // lbl_Materias
            // 
            this.lbl_Materias.AutoSize = true;
            this.lbl_Materias.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Materias.Location = new System.Drawing.Point(110, 119);
            this.lbl_Materias.Name = "lbl_Materias";
            this.lbl_Materias.Size = new System.Drawing.Size(97, 15);
            this.lbl_Materias.TabIndex = 6;
            this.lbl_Materias.Text = "Materia favorita";
            // 
            // FrmIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 219);
            this.Controls.Add(this.lbl_Materias);
            this.Controls.Add(this.cmb_Materias);
            this.Controls.Add(this.btn_saludar);
            this.Controls.Add(this.tb_Apellido);
            this.Controls.Add(this.tb_Nombre);
            this.Controls.Add(this.lbl_Apellido);
            this.Controls.Add(this.lbl_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmIngreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "¡Hola,WindowsForm!";
            this.Load += new System.EventHandler(this.FrmIngreso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.TextBox tb_Nombre;
        private System.Windows.Forms.TextBox tb_Apellido;
        private System.Windows.Forms.Button btn_saludar;
        private System.Windows.Forms.ComboBox cmb_Materias;
        private System.Windows.Forms.Label lbl_Materias;
    }
}

