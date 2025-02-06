namespace Registro_Gestion_De_Notas.VIEW
{
    partial class FormVistaDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVistaDatos));
            this.btnAtrasVer = new System.Windows.Forms.Button();
            this.dtgVerCurso = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVerCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtrasVer
            // 
            this.btnAtrasVer.BackColor = System.Drawing.Color.LightBlue;
            this.btnAtrasVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtrasVer.Location = new System.Drawing.Point(536, 640);
            this.btnAtrasVer.Name = "btnAtrasVer";
            this.btnAtrasVer.Size = new System.Drawing.Size(237, 74);
            this.btnAtrasVer.TabIndex = 14;
            this.btnAtrasVer.Text = "ATRAS";
            this.btnAtrasVer.UseVisualStyleBackColor = false;
            this.btnAtrasVer.Click += new System.EventHandler(this.btnAtrasVer_Click);
            // 
            // dtgVerCurso
            // 
            this.dtgVerCurso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgVerCurso.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtgVerCurso.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgVerCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVerCurso.Location = new System.Drawing.Point(143, 198);
            this.dtgVerCurso.Name = "dtgVerCurso";
            this.dtgVerCurso.ReadOnly = true;
            this.dtgVerCurso.RowHeadersWidth = 62;
            this.dtgVerCurso.RowTemplate.Height = 28;
            this.dtgVerCurso.Size = new System.Drawing.Size(1050, 387);
            this.dtgVerCurso.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(529, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "VER LOS CURSOS";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1303, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(34, 32);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormVistaDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(1349, 782);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAtrasVer);
            this.Controls.Add(this.dtgVerCurso);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVistaDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVistaDatos";
            this.Load += new System.EventHandler(this.FormVistaDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVerCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAtrasVer;
        private System.Windows.Forms.DataGridView dtgVerCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnCerrar;
    }
}