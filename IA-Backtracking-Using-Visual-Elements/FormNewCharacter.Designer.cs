namespace IA_Backtracking_Using_Visual_Elements
{
    partial class FormNewCharacter
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
            this.ListBoxTerrain = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.ComboBoxImage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckBoxNA = new System.Windows.Forms.CheckBox();
            this.pictureBoxCharacter = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBoxTerrain
            // 
            this.ListBoxTerrain.FormattingEnabled = true;
            this.ListBoxTerrain.Location = new System.Drawing.Point(10, 152);
            this.ListBoxTerrain.Margin = new System.Windows.Forms.Padding(2);
            this.ListBoxTerrain.Name = "ListBoxTerrain";
            this.ListBoxTerrain.Size = new System.Drawing.Size(116, 173);
            this.ListBoxTerrain.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ingrese el costo del movimiento";
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(157, 191);
            this.textBoxCost.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(100, 20);
            this.textBoxCost.TabIndex = 19;
            this.textBoxCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCost_KeyPress);
            // 
            // ButtonNext
            // 
            this.ButtonNext.Location = new System.Drawing.Point(238, 258);
            this.ButtonNext.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(71, 42);
            this.ButtonNext.TabIndex = 20;
            this.ButtonNext.Text = "Siguiente";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // ComboBoxImage
            // 
            this.ComboBoxImage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxImage.FormattingEnabled = true;
            this.ComboBoxImage.Items.AddRange(new object[] {
            "Humano",
            "Tejon",
            "Pez",
            "Lobo"});
            this.ComboBoxImage.Location = new System.Drawing.Point(157, 42);
            this.ComboBoxImage.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBoxImage.Name = "ComboBoxImage";
            this.ComboBoxImage.Size = new System.Drawing.Size(92, 21);
            this.ComboBoxImage.TabIndex = 22;
            this.ComboBoxImage.SelectedIndexChanged += new System.EventHandler(this.ComboBoxImage_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Elija imagen";
            // 
            // CheckBoxNA
            // 
            this.CheckBoxNA.AutoSize = true;
            this.CheckBoxNA.Location = new System.Drawing.Point(157, 214);
            this.CheckBoxNA.Margin = new System.Windows.Forms.Padding(2);
            this.CheckBoxNA.Name = "CheckBoxNA";
            this.CheckBoxNA.Size = new System.Drawing.Size(46, 17);
            this.CheckBoxNA.TabIndex = 24;
            this.CheckBoxNA.Text = "N/A";
            this.CheckBoxNA.UseVisualStyleBackColor = true;
            this.CheckBoxNA.CheckedChanged += new System.EventHandler(this.CheckBoxNA_CheckedChanged);
            // 
            // pictureBoxCharacter
            // 
            this.pictureBoxCharacter.Location = new System.Drawing.Point(10, 11);
            this.pictureBoxCharacter.Name = "pictureBoxCharacter";
            this.pictureBoxCharacter.Size = new System.Drawing.Size(128, 128);
            this.pictureBoxCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCharacter.TabIndex = 15;
            this.pictureBoxCharacter.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormNewCharacter
            // 
            this.AcceptButton = this.ButtonNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 344);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CheckBoxNA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBoxImage);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListBoxTerrain);
            this.Controls.Add(this.pictureBoxCharacter);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormNewCharacter";
            this.Text = "Crear Personaje";
            this.Load += new System.EventHandler(this.FormNewCharacter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCharacter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCharacter;
        private System.Windows.Forms.ListBox ListBoxTerrain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.ComboBox ComboBoxImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CheckBoxNA;
        private System.Windows.Forms.Button button1;
    }
}