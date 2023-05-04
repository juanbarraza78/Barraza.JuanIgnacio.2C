namespace WinFormsApp1
{
    partial class frm_main
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
            gbMaterias = new GroupBox();
            lMateria = new Label();
            cbMateria = new ComboBox();
            btnAsignarAlumno = new Button();
            gbAlumnos = new GroupBox();
            tbNombre = new TextBox();
            tbApellido = new TextBox();
            tbDni = new TextBox();
            lNombre = new Label();
            lApellido = new Label();
            lDni = new Label();
            btnCrearAlumno = new Button();
            lstAlumnosCreados = new ListBox();
            lstAlumnosInscriptosProgra = new ListBox();
            lstAlumnosInscriptosLabo = new ListBox();
            lInscriptosProgra = new Label();
            lInscriptosLabo = new Label();
            gbMaterias.SuspendLayout();
            gbAlumnos.SuspendLayout();
            SuspendLayout();
            // 
            // gbMaterias
            // 
            gbMaterias.Controls.Add(lMateria);
            gbMaterias.Controls.Add(cbMateria);
            gbMaterias.Controls.Add(btnAsignarAlumno);
            gbMaterias.Location = new Point(205, 239);
            gbMaterias.Name = "gbMaterias";
            gbMaterias.Size = new Size(172, 153);
            gbMaterias.TabIndex = 0;
            gbMaterias.TabStop = false;
            gbMaterias.Text = "Asignar materia";
            // 
            // lMateria
            // 
            lMateria.AutoSize = true;
            lMateria.Location = new Point(6, 44);
            lMateria.Name = "lMateria";
            lMateria.Size = new Size(55, 15);
            lMateria.TabIndex = 6;
            lMateria.Text = "MATERIA";
            // 
            // cbMateria
            // 
            cbMateria.FormattingEnabled = true;
            cbMateria.Location = new Point(6, 62);
            cbMateria.Name = "cbMateria";
            cbMateria.Size = new Size(160, 23);
            cbMateria.TabIndex = 5;
            // 
            // btnAsignarAlumno
            // 
            btnAsignarAlumno.BackColor = Color.WhiteSmoke;
            btnAsignarAlumno.Location = new Point(29, 91);
            btnAsignarAlumno.Name = "btnAsignarAlumno";
            btnAsignarAlumno.Size = new Size(113, 56);
            btnAsignarAlumno.TabIndex = 0;
            btnAsignarAlumno.Text = "Asignar al alumno seleccionado";
            btnAsignarAlumno.UseVisualStyleBackColor = false;
            // 
            // gbAlumnos
            // 
            gbAlumnos.Controls.Add(tbNombre);
            gbAlumnos.Controls.Add(tbApellido);
            gbAlumnos.Controls.Add(tbDni);
            gbAlumnos.Controls.Add(lNombre);
            gbAlumnos.Controls.Add(lApellido);
            gbAlumnos.Controls.Add(lDni);
            gbAlumnos.Controls.Add(btnCrearAlumno);
            gbAlumnos.Location = new Point(270, 12);
            gbAlumnos.Name = "gbAlumnos";
            gbAlumnos.Size = new Size(350, 134);
            gbAlumnos.TabIndex = 1;
            gbAlumnos.TabStop = false;
            gbAlumnos.Text = "Alta alumno";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(231, 48);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(100, 23);
            tbNombre.TabIndex = 8;
            // 
            // tbApellido
            // 
            tbApellido.Location = new Point(125, 48);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(100, 23);
            tbApellido.TabIndex = 7;
            // 
            // tbDni
            // 
            tbDni.Location = new Point(19, 48);
            tbDni.Name = "tbDni";
            tbDni.Size = new Size(100, 23);
            tbDni.TabIndex = 6;
            // 
            // lNombre
            // 
            lNombre.AutoSize = true;
            lNombre.Location = new Point(231, 30);
            lNombre.Name = "lNombre";
            lNombre.Size = new Size(59, 15);
            lNombre.TabIndex = 5;
            lNombre.Text = "NOMBRE:";
            // 
            // lApellido
            // 
            lApellido.AutoSize = true;
            lApellido.Location = new Point(125, 30);
            lApellido.Name = "lApellido";
            lApellido.Size = new Size(63, 15);
            lApellido.TabIndex = 4;
            lApellido.Text = "APELLIDO:";
            // 
            // lDni
            // 
            lDni.AutoSize = true;
            lDni.Location = new Point(19, 30);
            lDni.Name = "lDni";
            lDni.Size = new Size(30, 15);
            lDni.TabIndex = 3;
            lDni.Text = "DNI:";
            // 
            // btnCrearAlumno
            // 
            btnCrearAlumno.Location = new Point(117, 102);
            btnCrearAlumno.Name = "btnCrearAlumno";
            btnCrearAlumno.Size = new Size(113, 23);
            btnCrearAlumno.TabIndex = 2;
            btnCrearAlumno.Text = "Crear alumno";
            btnCrearAlumno.UseVisualStyleBackColor = true;
            // 
            // lstAlumnosCreados
            // 
            lstAlumnosCreados.FormattingEnabled = true;
            lstAlumnosCreados.ItemHeight = 15;
            lstAlumnosCreados.Location = new Point(22, 239);
            lstAlumnosCreados.Name = "lstAlumnosCreados";
            lstAlumnosCreados.Size = new Size(164, 244);
            lstAlumnosCreados.TabIndex = 2;
            // 
            // lstAlumnosInscriptosProgra
            // 
            lstAlumnosInscriptosProgra.FormattingEnabled = true;
            lstAlumnosInscriptosProgra.ItemHeight = 15;
            lstAlumnosInscriptosProgra.Location = new Point(579, 241);
            lstAlumnosInscriptosProgra.Name = "lstAlumnosInscriptosProgra";
            lstAlumnosInscriptosProgra.Size = new Size(163, 244);
            lstAlumnosInscriptosProgra.TabIndex = 3;
            // 
            // lstAlumnosInscriptosLabo
            // 
            lstAlumnosInscriptosLabo.FormattingEnabled = true;
            lstAlumnosInscriptosLabo.ItemHeight = 15;
            lstAlumnosInscriptosLabo.Location = new Point(748, 241);
            lstAlumnosInscriptosLabo.Name = "lstAlumnosInscriptosLabo";
            lstAlumnosInscriptosLabo.Size = new Size(163, 244);
            lstAlumnosInscriptosLabo.TabIndex = 4;
            // 
            // lInscriptosProgra
            // 
            lInscriptosProgra.AutoSize = true;
            lInscriptosProgra.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lInscriptosProgra.Location = new Point(579, 218);
            lInscriptosProgra.Name = "lInscriptosProgra";
            lInscriptosProgra.Size = new Size(123, 20);
            lInscriptosProgra.TabIndex = 5;
            lInscriptosProgra.Text = "Inscriptos Progra:";
            // 
            // lInscriptosLabo
            // 
            lInscriptosLabo.AutoSize = true;
            lInscriptosLabo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lInscriptosLabo.Location = new Point(748, 218);
            lInscriptosLabo.Name = "lInscriptosLabo";
            lInscriptosLabo.Size = new Size(112, 20);
            lInscriptosLabo.TabIndex = 6;
            lInscriptosLabo.Text = "Inscriptos Labo:";
            // 
            // frm_main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(923, 497);
            Controls.Add(lInscriptosLabo);
            Controls.Add(lInscriptosProgra);
            Controls.Add(lstAlumnosInscriptosLabo);
            Controls.Add(lstAlumnosInscriptosProgra);
            Controls.Add(lstAlumnosCreados);
            Controls.Add(gbAlumnos);
            Controls.Add(gbMaterias);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inscripciones Alumnos";
            gbMaterias.ResumeLayout(false);
            gbMaterias.PerformLayout();
            gbAlumnos.ResumeLayout(false);
            gbAlumnos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbMaterias;
        private GroupBox gbAlumnos;
        private Label lNombre;
        private Label lApellido;
        private Label lDni;
        private Button btnCrearAlumno;
        private TextBox tbNombre;
        private TextBox tbApellido;
        private TextBox tbDni;
        private ListBox lstAlumnosCreados;
        private ListBox lstAlumnosInscriptosProgra;
        private ListBox lstAlumnosInscriptosLabo;
        private Label lMateria;
        private ComboBox cbMateria;
        private Button btnAsignarAlumno;
        private Label lInscriptosProgra;
        private Label lInscriptosLabo;
    }
}