namespace prueba2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.a = new System.Windows.Forms.CheckBox();
            this.b = new System.Windows.Forms.CheckBox();
            this.c = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(384, 114);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(38, 21);
            this.a.TabIndex = 0;
            this.a.Text = "a";
            this.a.UseVisualStyleBackColor = true;
            this.a.CheckedChanged += new System.EventHandler(this.a_CheckedChanged);
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(384, 163);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(38, 21);
            this.b.TabIndex = 1;
            this.b.Text = "b";
            this.b.UseVisualStyleBackColor = true;
            this.b.CheckedChanged += new System.EventHandler(this.b_CheckedChanged);
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(384, 207);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(37, 21);
            this.c.TabIndex = 2;
            this.c.Text = "c";
            this.c.UseVisualStyleBackColor = true;
            this.c.CheckedChanged += new System.EventHandler(this.c_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 445);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox a;
        private System.Windows.Forms.CheckBox b;
        private System.Windows.Forms.CheckBox c;
        private System.Windows.Forms.Label label1;
    }
}

