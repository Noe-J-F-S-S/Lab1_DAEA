namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMessage = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.chkMayor = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnMessage
            // 
            this.btnMessage.BackColor = System.Drawing.Color.Tomato;
            this.btnMessage.Location = new System.Drawing.Point(264, 393);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(175, 45);
            this.btnMessage.TabIndex = 0;
            this.btnMessage.Text = "Haz click aqui";
            this.btnMessage.UseVisualStyleBackColor = false;
            this.btnMessage.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(285, 130);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 1;
            // 
            // chkMayor
            // 
            this.chkMayor.AutoSize = true;
            this.chkMayor.Location = new System.Drawing.Point(319, 186);
            this.chkMayor.Name = "chkMayor";
            this.chkMayor.Size = new System.Drawing.Size(67, 17);
            this.chkMayor.TabIndex = 2;
            this.chkMayor.Text = "EsMayor";
            this.chkMayor.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkMayor);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btnMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.CheckBox chkMayor;


        
    }
}

