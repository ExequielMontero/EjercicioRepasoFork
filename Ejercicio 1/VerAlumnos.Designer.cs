namespace Ejercicio_1
{
    partial class VerAlumnos
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
            this.gbOpcion = new System.Windows.Forms.GroupBox();
            this.rbMayorMenor = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.btnVer = new System.Windows.Forms.Button();
            this.lbLista = new System.Windows.Forms.ListBox();
            this.btncerrar = new System.Windows.Forms.Button();
            this.gbOpcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOpcion
            // 
            this.gbOpcion.Controls.Add(this.rbMayorMenor);
            this.gbOpcion.Controls.Add(this.rbTodos);
            this.gbOpcion.Location = new System.Drawing.Point(28, 32);
            this.gbOpcion.Name = "gbOpcion";
            this.gbOpcion.Size = new System.Drawing.Size(200, 77);
            this.gbOpcion.TabIndex = 1;
            this.gbOpcion.TabStop = false;
            this.gbOpcion.Text = "Opciones";
            // 
            // rbMayorMenor
            // 
            this.rbMayorMenor.AutoSize = true;
            this.rbMayorMenor.Location = new System.Drawing.Point(3, 43);
            this.rbMayorMenor.Name = "rbMayorMenor";
            this.rbMayorMenor.Size = new System.Drawing.Size(157, 17);
            this.rbMayorMenor.TabIndex = 1;
            this.rbMayorMenor.Text = "Ver Alumnos Mayor y Menor";
            this.rbMayorMenor.UseVisualStyleBackColor = true;
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(3, 20);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(173, 17);
            this.rbTodos.TabIndex = 0;
            this.rbTodos.Text = "Ver Lista de Todos los Alumnos";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // btnVer
            // 
            this.btnVer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Location = new System.Drawing.Point(253, 50);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(54, 59);
            this.btnVer.TabIndex = 2;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            // 
            // lbLista
            // 
            this.lbLista.FormattingEnabled = true;
            this.lbLista.Location = new System.Drawing.Point(28, 115);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(279, 225);
            this.lbLista.TabIndex = 4;
            this.lbLista.SelectedIndexChanged += new System.EventHandler(this.lbLista_SelectedIndexChanged);
            // 
            // btncerrar
            // 
            this.btncerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncerrar.Location = new System.Drawing.Point(129, 363);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(75, 68);
            this.btncerrar.TabIndex = 5;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            // 
            // VerAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 462);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.lbLista);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.gbOpcion);
            this.Name = "VerAlumnos";
            this.Text = "VerAlumnos";
            this.Load += new System.EventHandler(this.VerAlumnos_Load);
            this.gbOpcion.ResumeLayout(false);
            this.gbOpcion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbOpcion;
        private System.Windows.Forms.Button btnVer;
        public System.Windows.Forms.RadioButton rbTodos;
        public System.Windows.Forms.RadioButton rbMayorMenor;
        public System.Windows.Forms.ListBox lbLista;
        private System.Windows.Forms.Button btncerrar;
    }
}