namespace IA_Backtracking_Using_Visual_Elements
{
    partial class FormMain
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
            this.panelMap = new System.Windows.Forms.Panel();
            this.labelRoute = new System.Windows.Forms.Label();
            this.buttonExamine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelMap
            // 
            this.panelMap.BackColor = System.Drawing.Color.White;
            this.panelMap.Location = new System.Drawing.Point(44, 73);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(480, 480);
            this.panelMap.TabIndex = 0;
            this.panelMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelMap_MouseClick);
            // 
            // labelRoute
            // 
            this.labelRoute.AutoSize = true;
            this.labelRoute.Location = new System.Drawing.Point(93, 17);
            this.labelRoute.Name = "labelRoute";
            this.labelRoute.Size = new System.Drawing.Size(56, 13);
            this.labelRoute.TabIndex = 0;
            this.labelRoute.Text = "LabelRuta";
            // 
            // buttonExamine
            // 
            this.buttonExamine.Location = new System.Drawing.Point(12, 12);
            this.buttonExamine.Name = "buttonExamine";
            this.buttonExamine.Size = new System.Drawing.Size(75, 23);
            this.buttonExamine.TabIndex = 1;
            this.buttonExamine.Text = "Examinar";
            this.buttonExamine.UseVisualStyleBackColor = true;
            this.buttonExamine.Click += new System.EventHandler(this.buttonExamine_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 622);
            this.Controls.Add(this.buttonExamine);
            this.Controls.Add(this.labelRoute);
            this.Controls.Add(this.panelMap);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMap;
        private System.Windows.Forms.Label labelRoute;
        private System.Windows.Forms.Button buttonExamine;
    }
}

