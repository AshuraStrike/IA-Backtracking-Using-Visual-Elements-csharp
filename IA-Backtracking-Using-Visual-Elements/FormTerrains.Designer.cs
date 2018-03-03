namespace IA_Backtracking_Using_Visual_Elements
{
    partial class FormTerrains
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
            this.PreviousButton = new System.Windows.Forms.Button();
            this.ActualGroundLabel = new System.Windows.Forms.Label();
            this.GroundLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.TypeGroundLabel = new System.Windows.Forms.Label();
            this.GroundTypeComboBox = new System.Windows.Forms.ComboBox();
            this.GroundListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // PreviousButton
            // 
            this.PreviousButton.Location = new System.Drawing.Point(211, 374);
            this.PreviousButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(83, 59);
            this.PreviousButton.TabIndex = 13;
            this.PreviousButton.Text = "Anterior";
            this.PreviousButton.UseVisualStyleBackColor = true;
            // 
            // ActualGroundLabel
            // 
            this.ActualGroundLabel.AutoSize = true;
            this.ActualGroundLabel.Location = new System.Drawing.Point(212, 59);
            this.ActualGroundLabel.Name = "ActualGroundLabel";
            this.ActualGroundLabel.Size = new System.Drawing.Size(138, 17);
            this.ActualGroundLabel.TabIndex = 12;
            this.ActualGroundLabel.Text = "Actual Ground Label";
            // 
            // GroundLabel
            // 
            this.GroundLabel.AutoSize = true;
            this.GroundLabel.Location = new System.Drawing.Point(212, 42);
            this.GroundLabel.Name = "GroundLabel";
            this.GroundLabel.Size = new System.Drawing.Size(101, 17);
            this.GroundLabel.TabIndex = 11;
            this.GroundLabel.Text = "Terreno actual";
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(300, 374);
            this.NextButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(83, 59);
            this.NextButton.TabIndex = 10;
            this.NextButton.Text = "Siguiente";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // TypeGroundLabel
            // 
            this.TypeGroundLabel.AutoSize = true;
            this.TypeGroundLabel.Location = new System.Drawing.Point(212, 107);
            this.TypeGroundLabel.Name = "TypeGroundLabel";
            this.TypeGroundLabel.Size = new System.Drawing.Size(146, 17);
            this.TypeGroundLabel.TabIndex = 9;
            this.TypeGroundLabel.Text = "Elija el tipo de terreno";
            // 
            // GroundTypeComboBox
            // 
            this.GroundTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GroundTypeComboBox.FormattingEnabled = true;
            this.GroundTypeComboBox.Items.AddRange(new object[] {
            "Tierra",
            "Agua",
            "Pradera",
            "Bosque",
            "Montaña",
            "Arena",
            "Desierto",
            "Pantano",
            "Rio",
            "Jungla"});
            this.GroundTypeComboBox.Location = new System.Drawing.Point(212, 130);
            this.GroundTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroundTypeComboBox.Name = "GroundTypeComboBox";
            this.GroundTypeComboBox.Size = new System.Drawing.Size(145, 24);
            this.GroundTypeComboBox.TabIndex = 8;
            // 
            // GroundListBox
            // 
            this.GroundListBox.FormattingEnabled = true;
            this.GroundListBox.ItemHeight = 16;
            this.GroundListBox.Location = new System.Drawing.Point(15, 14);
            this.GroundListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroundListBox.Name = "GroundListBox";
            this.GroundListBox.Size = new System.Drawing.Size(172, 420);
            this.GroundListBox.TabIndex = 7;
            // 
            // FormTerrains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 449);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.ActualGroundLabel);
            this.Controls.Add(this.GroundLabel);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.TypeGroundLabel);
            this.Controls.Add(this.GroundTypeComboBox);
            this.Controls.Add(this.GroundListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormTerrains";
            this.Text = "FormTerrains";
            this.Load += new System.EventHandler(this.FormTerrains_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Label ActualGroundLabel;
        private System.Windows.Forms.Label GroundLabel;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label TypeGroundLabel;
        private System.Windows.Forms.ComboBox GroundTypeComboBox;
        private System.Windows.Forms.ListBox GroundListBox;
    }
}