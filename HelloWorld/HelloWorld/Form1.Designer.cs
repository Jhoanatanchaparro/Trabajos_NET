namespace HelloWorld
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
			this.btnClickThis = new System.Windows.Forms.Button();
			this.lblHelloWorld = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnClickThis
			// 
			this.btnClickThis.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnClickThis.ForeColor = System.Drawing.Color.Red;
			this.btnClickThis.Location = new System.Drawing.Point(345, 178);
			this.btnClickThis.Name = "btnClickThis";
			this.btnClickThis.Size = new System.Drawing.Size(178, 50);
			this.btnClickThis.TabIndex = 0;
			this.btnClickThis.Text = "Click this";
			this.btnClickThis.UseVisualStyleBackColor = false;
			this.btnClickThis.Click += new System.EventHandler(this.btnClickThis_Click);
			// 
			// lblHelloWorld
			// 
			this.lblHelloWorld.Location = new System.Drawing.Point(342, 255);
			this.lblHelloWorld.Name = "lblHelloWorld";
			this.lblHelloWorld.Size = new System.Drawing.Size(181, 58);
			this.lblHelloWorld.TabIndex = 1;
			this.lblHelloWorld.Text = "label1";
			this.lblHelloWorld.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblHelloWorld.Click += new System.EventHandler(this.lblHelloWorld_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblHelloWorld);
			this.Controls.Add(this.btnClickThis);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClickThis;
        private System.Windows.Forms.Label lblHelloWorld;
    }
}

