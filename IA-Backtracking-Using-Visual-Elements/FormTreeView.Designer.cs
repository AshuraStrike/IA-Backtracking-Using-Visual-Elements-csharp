namespace IA_Backtracking_Using_Visual_Elements
{
    partial class FormTreeView
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
            this.TreeView = new System.Windows.Forms.TreeView();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TreeView
            // 
            this.TreeView.Location = new System.Drawing.Point(13, 13);
            this.TreeView.Name = "TreeView";
            this.TreeView.Size = new System.Drawing.Size(492, 447);
            this.TreeView.TabIndex = 0;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(528, 76);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(102, 50);
            this.ButtonAdd.TabIndex = 1;
            this.ButtonAdd.Text = "Agregar";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // FormTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 472);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.TreeView);
            this.Name = "FormTreeView";
            this.Text = "Arbol De Recubrimiento";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView TreeView;
        private System.Windows.Forms.Button ButtonAdd;
    }
}