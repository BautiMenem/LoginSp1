namespace WindowsFormsApp2
{
    partial class frmComparacion
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
            this.btnComparar = new System.Windows.Forms.Button();
            this.txtUno = new System.Windows.Forms.TextBox();
            this.mrcOpcion = new System.Windows.Forms.GroupBox();
            this.optMayor = new System.Windows.Forms.RadioButton();
            this.optMenor = new System.Windows.Forms.RadioButton();
            this.optIgual = new System.Windows.Forms.RadioButton();
            this.optDesigual = new System.Windows.Forms.RadioButton();
            this.txtDos = new System.Windows.Forms.TextBox();
            this.mrcOpcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnComparar
            // 
            this.btnComparar.Location = new System.Drawing.Point(267, 293);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(75, 23);
            this.btnComparar.TabIndex = 0;
            this.btnComparar.Text = "Comparar";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // txtUno
            // 
            this.txtUno.Location = new System.Drawing.Point(176, 81);
            this.txtUno.Name = "txtUno";
            this.txtUno.Size = new System.Drawing.Size(95, 20);
            this.txtUno.TabIndex = 1;
            // 
            // mrcOpcion
            // 
            this.mrcOpcion.Controls.Add(this.optDesigual);
            this.mrcOpcion.Controls.Add(this.optIgual);
            this.mrcOpcion.Controls.Add(this.optMenor);
            this.mrcOpcion.Controls.Add(this.optMayor);
            this.mrcOpcion.Location = new System.Drawing.Point(176, 156);
            this.mrcOpcion.Name = "mrcOpcion";
            this.mrcOpcion.Size = new System.Drawing.Size(271, 100);
            this.mrcOpcion.TabIndex = 2;
            this.mrcOpcion.TabStop = false;
            this.mrcOpcion.Text = "Opción";
            // 
            // optMayor
            // 
            this.optMayor.AutoSize = true;
            this.optMayor.Location = new System.Drawing.Point(19, 20);
            this.optMayor.Name = "optMayor";
            this.optMayor.Size = new System.Drawing.Size(54, 17);
            this.optMayor.TabIndex = 0;
            this.optMayor.TabStop = true;
            this.optMayor.Text = "Mayor";
            this.optMayor.UseVisualStyleBackColor = true;
            // 
            // optMenor
            // 
            this.optMenor.AutoSize = true;
            this.optMenor.Location = new System.Drawing.Point(19, 58);
            this.optMenor.Name = "optMenor";
            this.optMenor.Size = new System.Drawing.Size(55, 17);
            this.optMenor.TabIndex = 1;
            this.optMenor.TabStop = true;
            this.optMenor.Text = "Menor";
            this.optMenor.UseVisualStyleBackColor = true;
            // 
            // optIgual
            // 
            this.optIgual.AutoSize = true;
            this.optIgual.Location = new System.Drawing.Point(171, 19);
            this.optIgual.Name = "optIgual";
            this.optIgual.Size = new System.Drawing.Size(48, 17);
            this.optIgual.TabIndex = 2;
            this.optIgual.TabStop = true;
            this.optIgual.Text = "Igual";
            this.optIgual.UseVisualStyleBackColor = true;
            // 
            // optDesigual
            // 
            this.optDesigual.AutoSize = true;
            this.optDesigual.Location = new System.Drawing.Point(171, 58);
            this.optDesigual.Name = "optDesigual";
            this.optDesigual.Size = new System.Drawing.Size(66, 17);
            this.optDesigual.TabIndex = 3;
            this.optDesigual.TabStop = true;
            this.optDesigual.Text = "Desigual";
            this.optDesigual.UseVisualStyleBackColor = true;
            // 
            // txtDos
            // 
            this.txtDos.Location = new System.Drawing.Point(347, 81);
            this.txtDos.Name = "txtDos";
            this.txtDos.Size = new System.Drawing.Size(100, 20);
            this.txtDos.TabIndex = 3;
            // 
            // frmComparacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 367);
            this.Controls.Add(this.txtDos);
            this.Controls.Add(this.mrcOpcion);
            this.Controls.Add(this.txtUno);
            this.Controls.Add(this.btnComparar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmComparacion";
            this.Text = "Comparación";
            this.mrcOpcion.ResumeLayout(false);
            this.mrcOpcion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.TextBox txtUno;
        private System.Windows.Forms.GroupBox mrcOpcion;
        private System.Windows.Forms.RadioButton optDesigual;
        private System.Windows.Forms.RadioButton optIgual;
        private System.Windows.Forms.RadioButton optMenor;
        private System.Windows.Forms.RadioButton optMayor;
        private System.Windows.Forms.TextBox txtDos;
    }
}