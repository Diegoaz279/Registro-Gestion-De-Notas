namespace Registro_Gestion_De_Notas
{
    partial class FormCursos
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtgAgregarCurso = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCursoAgregar = new System.Windows.Forms.TextBox();
            this.txtEstudiantesCursoAgregar = new System.Windows.Forms.TextBox();
            this.btnAgregarCurso = new System.Windows.Forms.Button();
            this.btnEstudianteNota = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgregarCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "AGREGAR CURSO";
            // 
            // dtgAgregarCurso
            // 
            this.dtgAgregarCurso.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgAgregarCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAgregarCurso.Location = new System.Drawing.Point(130, 224);
            this.dtgAgregarCurso.Name = "dtgAgregarCurso";
            this.dtgAgregarCurso.ReadOnly = true;
            this.dtgAgregarCurso.RowHeadersWidth = 62;
            this.dtgAgregarCurso.RowTemplate.Height = 28;
            this.dtgAgregarCurso.Size = new System.Drawing.Size(559, 150);
            this.dtgAgregarCurso.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cursos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 522);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Estudiantes por el curso:";
            // 
            // txtCursoAgregar
            // 
            this.txtCursoAgregar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtCursoAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCursoAgregar.Location = new System.Drawing.Point(475, 440);
            this.txtCursoAgregar.Name = "txtCursoAgregar";
            this.txtCursoAgregar.Size = new System.Drawing.Size(214, 30);
            this.txtCursoAgregar.TabIndex = 4;
            // 
            // txtEstudiantesCursoAgregar
            // 
            this.txtEstudiantesCursoAgregar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtEstudiantesCursoAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstudiantesCursoAgregar.Location = new System.Drawing.Point(475, 522);
            this.txtEstudiantesCursoAgregar.Name = "txtEstudiantesCursoAgregar";
            this.txtEstudiantesCursoAgregar.Size = new System.Drawing.Size(214, 30);
            this.txtEstudiantesCursoAgregar.TabIndex = 5;
            // 
            // btnAgregarCurso
            // 
            this.btnAgregarCurso.BackColor = System.Drawing.Color.LightBlue;
            this.btnAgregarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCurso.Location = new System.Drawing.Point(130, 647);
            this.btnAgregarCurso.Name = "btnAgregarCurso";
            this.btnAgregarCurso.Size = new System.Drawing.Size(196, 74);
            this.btnAgregarCurso.TabIndex = 6;
            this.btnAgregarCurso.Text = "AGREGAR";
            this.btnAgregarCurso.UseVisualStyleBackColor = false;
            this.btnAgregarCurso.Click += new System.EventHandler(this.btnAgregarCurso_Click);
            // 
            // btnEstudianteNota
            // 
            this.btnEstudianteNota.BackColor = System.Drawing.Color.LightBlue;
            this.btnEstudianteNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstudianteNota.Location = new System.Drawing.Point(408, 647);
            this.btnEstudianteNota.Name = "btnEstudianteNota";
            this.btnEstudianteNota.Size = new System.Drawing.Size(281, 74);
            this.btnEstudianteNota.TabIndex = 7;
            this.btnEstudianteNota.Text = "ESTUDIANTES Y NOTAS";
            this.btnEstudianteNota.UseVisualStyleBackColor = false;
            // 
            // FormCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(810, 837);
            this.Controls.Add(this.btnEstudianteNota);
            this.Controls.Add(this.btnAgregarCurso);
            this.Controls.Add(this.txtEstudiantesCursoAgregar);
            this.Controls.Add(this.txtCursoAgregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgAgregarCurso);
            this.Controls.Add(this.label1);
            this.Name = "FormCursos";
            this.Text = "FormAgregarCurso";
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgregarCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgAgregarCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCursoAgregar;
        private System.Windows.Forms.TextBox txtEstudiantesCursoAgregar;
        private System.Windows.Forms.Button btnAgregarCurso;
        private System.Windows.Forms.Button btnEstudianteNota;
    }
}

