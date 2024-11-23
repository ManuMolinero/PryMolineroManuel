namespace PryMolineroManuel
{
    partial class FrmActividades
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
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnCargarActividades = new System.Windows.Forms.Button();
            this.treeViewUsuarios = new System.Windows.Forms.TreeView();
            this.txtCargarActividades = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(393, 18);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 0;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(160, 18);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(161, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Por favor, seleccione una fecha:";
            // 
            // btnCargarActividades
            // 
            this.btnCargarActividades.Location = new System.Drawing.Point(163, 41);
            this.btnCargarActividades.Name = "btnCargarActividades";
            this.btnCargarActividades.Size = new System.Drawing.Size(221, 26);
            this.btnCargarActividades.TabIndex = 2;
            this.btnCargarActividades.Text = "Cargar Actividades";
            this.btnCargarActividades.UseVisualStyleBackColor = true;
            this.btnCargarActividades.Click += new System.EventHandler(this.btnCargarActividades_Click);
            // 
            // treeViewUsuarios
            // 
            this.treeViewUsuarios.Location = new System.Drawing.Point(12, 73);
            this.treeViewUsuarios.Name = "treeViewUsuarios";
            this.treeViewUsuarios.Size = new System.Drawing.Size(776, 338);
            this.treeViewUsuarios.TabIndex = 3;
            // 
            // txtCargarActividades
            // 
            this.txtCargarActividades.Location = new System.Drawing.Point(403, 44);
            this.txtCargarActividades.Multiline = true;
            this.txtCargarActividades.Name = "txtCargarActividades";
            this.txtCargarActividades.Size = new System.Drawing.Size(190, 23);
            this.txtCargarActividades.TabIndex = 4;
            // 
            // FrmActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCargarActividades);
            this.Controls.Add(this.treeViewUsuarios);
            this.Controls.Add(this.btnCargarActividades);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFechaInicio);
            this.Name = "FrmActividades";
            this.Text = "FrmActividades";
            this.Load += new System.EventHandler(this.FrmActividades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnCargarActividades;
        private System.Windows.Forms.TreeView treeViewUsuarios;
        private System.Windows.Forms.TextBox txtCargarActividades;
    }
}