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
            this.GroundButton = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonCharacter = new System.Windows.Forms.Button();
            this.labelCurrentXY = new System.Windows.Forms.Label();
            this.labelSelectedX = new System.Windows.Forms.Label();
            this.labelSelectedY = new System.Windows.Forms.Label();
            this.buttonFinalCoord = new System.Windows.Forms.Button();
            this.buttonInitialCord = new System.Windows.Forms.Button();
            this.ButtonTree = new System.Windows.Forms.Button();
            this.checkBoxBacktracking = new System.Windows.Forms.CheckBox();
            this.checkBoxAStar = new System.Windows.Forms.CheckBox();
            this.checkBoxRepeat = new System.Windows.Forms.CheckBox();
            this.labelExpantionOrder = new System.Windows.Forms.Label();
            this.listBoxExpantionOrder = new System.Windows.Forms.ListBox();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.labelResoult = new System.Windows.Forms.Label();
            this.labelSteps = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelMap
            // 
            this.panelMap.BackColor = System.Drawing.Color.White;
            this.panelMap.Location = new System.Drawing.Point(44, 73);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(480, 480);
            this.panelMap.TabIndex = 0;
            this.panelMap.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMap_Paint);
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
            this.buttonExamine.TabStop = false;
            this.buttonExamine.Text = "Examinar";
            this.buttonExamine.UseVisualStyleBackColor = true;
            this.buttonExamine.Click += new System.EventHandler(this.buttonExamine_Click);
            this.buttonExamine.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.FormMain_PreviewKeyDown);
            // 
            // GroundButton
            // 
            this.GroundButton.Location = new System.Drawing.Point(587, 73);
            this.GroundButton.Margin = new System.Windows.Forms.Padding(2);
            this.GroundButton.Name = "GroundButton";
            this.GroundButton.Size = new System.Drawing.Size(100, 34);
            this.GroundButton.TabIndex = 3;
            this.GroundButton.TabStop = false;
            this.GroundButton.Text = "Terrenos";
            this.GroundButton.UseVisualStyleBackColor = true;
            this.GroundButton.Click += new System.EventHandler(this.GroundButton_Click);
            this.GroundButton.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.FormMain_PreviewKeyDown);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(587, 488);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(100, 34);
            this.buttonPlay.TabIndex = 4;
            this.buttonPlay.TabStop = false;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            this.buttonPlay.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.FormMain_PreviewKeyDown);
            // 
            // buttonCharacter
            // 
            this.buttonCharacter.Enabled = false;
            this.buttonCharacter.Location = new System.Drawing.Point(587, 112);
            this.buttonCharacter.Name = "buttonCharacter";
            this.buttonCharacter.Size = new System.Drawing.Size(100, 34);
            this.buttonCharacter.TabIndex = 5;
            this.buttonCharacter.TabStop = false;
            this.buttonCharacter.Text = "Character";
            this.buttonCharacter.UseVisualStyleBackColor = true;
            this.buttonCharacter.Click += new System.EventHandler(this.buttonCharacter_Click);
            this.buttonCharacter.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.FormMain_PreviewKeyDown);
            // 
            // labelCurrentXY
            // 
            this.labelCurrentXY.AutoSize = true;
            this.labelCurrentXY.Location = new System.Drawing.Point(575, 162);
            this.labelCurrentXY.Name = "labelCurrentXY";
            this.labelCurrentXY.Size = new System.Drawing.Size(87, 13);
            this.labelCurrentXY.TabIndex = 9;
            this.labelCurrentXY.Text = "Posición elegida:";
            // 
            // labelSelectedX
            // 
            this.labelSelectedX.AutoSize = true;
            this.labelSelectedX.Location = new System.Drawing.Point(668, 162);
            this.labelSelectedX.Name = "labelSelectedX";
            this.labelSelectedX.Size = new System.Drawing.Size(14, 13);
            this.labelSelectedX.TabIndex = 10;
            this.labelSelectedX.Text = "A";
            // 
            // labelSelectedY
            // 
            this.labelSelectedY.AutoSize = true;
            this.labelSelectedY.Location = new System.Drawing.Point(681, 162);
            this.labelSelectedY.Name = "labelSelectedY";
            this.labelSelectedY.Size = new System.Drawing.Size(13, 13);
            this.labelSelectedY.TabIndex = 11;
            this.labelSelectedY.Text = "0";
            // 
            // buttonFinalCoord
            // 
            this.buttonFinalCoord.Enabled = false;
            this.buttonFinalCoord.Location = new System.Drawing.Point(639, 193);
            this.buttonFinalCoord.Name = "buttonFinalCoord";
            this.buttonFinalCoord.Size = new System.Drawing.Size(75, 34);
            this.buttonFinalCoord.TabIndex = 12;
            this.buttonFinalCoord.TabStop = false;
            this.buttonFinalCoord.Text = "Coordenada final";
            this.buttonFinalCoord.UseVisualStyleBackColor = true;
            this.buttonFinalCoord.Click += new System.EventHandler(this.buttonFinalCoord_Click);
            // 
            // buttonInitialCord
            // 
            this.buttonInitialCord.Enabled = false;
            this.buttonInitialCord.Location = new System.Drawing.Point(562, 193);
            this.buttonInitialCord.Name = "buttonInitialCord";
            this.buttonInitialCord.Size = new System.Drawing.Size(75, 34);
            this.buttonInitialCord.TabIndex = 13;
            this.buttonInitialCord.TabStop = false;
            this.buttonInitialCord.Text = "Coordenada inicial";
            this.buttonInitialCord.UseVisualStyleBackColor = true;
            this.buttonInitialCord.Click += new System.EventHandler(this.buttonInitialCord_Click);
            // 
            // ButtonTree
            // 
            this.ButtonTree.Location = new System.Drawing.Point(587, 547);
            this.ButtonTree.Name = "ButtonTree";
            this.ButtonTree.Size = new System.Drawing.Size(100, 34);
            this.ButtonTree.TabIndex = 14;
            this.ButtonTree.TabStop = false;
            this.ButtonTree.Text = "Arbol";
            this.ButtonTree.UseVisualStyleBackColor = true;
            this.ButtonTree.Click += new System.EventHandler(this.ButtonTree_Click);
            // 
            // checkBoxBacktracking
            // 
            this.checkBoxBacktracking.AutoSize = true;
            this.checkBoxBacktracking.Location = new System.Drawing.Point(587, 384);
            this.checkBoxBacktracking.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxBacktracking.Name = "checkBoxBacktracking";
            this.checkBoxBacktracking.Size = new System.Drawing.Size(89, 17);
            this.checkBoxBacktracking.TabIndex = 15;
            this.checkBoxBacktracking.Text = "Backtracking";
            this.checkBoxBacktracking.UseVisualStyleBackColor = true;
            this.checkBoxBacktracking.CheckedChanged += new System.EventHandler(this.checkBoxBacktracking_CheckedChanged);
            // 
            // checkBoxAStar
            // 
            this.checkBoxAStar.AutoSize = true;
            this.checkBoxAStar.Location = new System.Drawing.Point(587, 405);
            this.checkBoxAStar.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxAStar.Name = "checkBoxAStar";
            this.checkBoxAStar.Size = new System.Drawing.Size(37, 17);
            this.checkBoxAStar.TabIndex = 16;
            this.checkBoxAStar.Text = "A*";
            this.checkBoxAStar.UseVisualStyleBackColor = true;
            this.checkBoxAStar.CheckedChanged += new System.EventHandler(this.checkBoxAStar_CheckedChanged);
            // 
            // checkBoxRepeat
            // 
            this.checkBoxRepeat.AutoSize = true;
            this.checkBoxRepeat.Location = new System.Drawing.Point(587, 455);
            this.checkBoxRepeat.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxRepeat.Name = "checkBoxRepeat";
            this.checkBoxRepeat.Size = new System.Drawing.Size(94, 17);
            this.checkBoxRepeat.TabIndex = 17;
            this.checkBoxRepeat.Text = "Repetir Nodos";
            this.checkBoxRepeat.UseVisualStyleBackColor = true;
            // 
            // labelExpantionOrder
            // 
            this.labelExpantionOrder.AutoSize = true;
            this.labelExpantionOrder.Location = new System.Drawing.Point(559, 244);
            this.labelExpantionOrder.Name = "labelExpantionOrder";
            this.labelExpantionOrder.Size = new System.Drawing.Size(105, 13);
            this.labelExpantionOrder.TabIndex = 33;
            this.labelExpantionOrder.Text = "Orden de expansión:";
            // 
            // listBoxExpantionOrder
            // 
            this.listBoxExpantionOrder.FormattingEnabled = true;
            this.listBoxExpantionOrder.Location = new System.Drawing.Point(562, 260);
            this.listBoxExpantionOrder.Name = "listBoxExpantionOrder";
            this.listBoxExpantionOrder.Size = new System.Drawing.Size(112, 108);
            this.listBoxExpantionOrder.TabIndex = 32;
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(680, 343);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(40, 23);
            this.buttonDown.TabIndex = 31;
            this.buttonDown.TabStop = false;
            this.buttonDown.Text = "Bajar";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(680, 314);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(40, 23);
            this.buttonUp.TabIndex = 30;
            this.buttonUp.TabStop = false;
            this.buttonUp.Text = "Subir";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // labelResoult
            // 
            this.labelResoult.AutoSize = true;
            this.labelResoult.Location = new System.Drawing.Point(41, 568);
            this.labelResoult.Name = "labelResoult";
            this.labelResoult.Size = new System.Drawing.Size(58, 13);
            this.labelResoult.TabIndex = 34;
            this.labelResoult.Text = "Resultado:";
            // 
            // labelSteps
            // 
            this.labelSteps.AutoSize = true;
            this.labelSteps.Location = new System.Drawing.Point(105, 568);
            this.labelSteps.Name = "labelSteps";
            this.labelSteps.Size = new System.Drawing.Size(34, 13);
            this.labelSteps.TabIndex = 35;
            this.labelSteps.Text = "Steps";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 609);
            this.Controls.Add(this.labelSteps);
            this.Controls.Add(this.labelResoult);
            this.Controls.Add(this.labelExpantionOrder);
            this.Controls.Add(this.listBoxExpantionOrder);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.checkBoxRepeat);
            this.Controls.Add(this.checkBoxAStar);
            this.Controls.Add(this.checkBoxBacktracking);
            this.Controls.Add(this.ButtonTree);
            this.Controls.Add(this.buttonInitialCord);
            this.Controls.Add(this.buttonFinalCoord);
            this.Controls.Add(this.labelSelectedY);
            this.Controls.Add(this.labelSelectedX);
            this.Controls.Add(this.labelCurrentXY);
            this.Controls.Add(this.buttonCharacter);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.GroundButton);
            this.Controls.Add(this.buttonExamine);
            this.Controls.Add(this.labelRoute);
            this.Controls.Add(this.panelMap);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagina Principal";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormMain_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.FormMain_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMap;
        private System.Windows.Forms.Label labelRoute;
        private System.Windows.Forms.Button buttonExamine;
        private System.Windows.Forms.Button GroundButton;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonCharacter;
        private System.Windows.Forms.Label labelCurrentXY;
        private System.Windows.Forms.Label labelSelectedX;
        private System.Windows.Forms.Label labelSelectedY;
        private System.Windows.Forms.Button buttonFinalCoord;
        private System.Windows.Forms.Button buttonInitialCord;
        private System.Windows.Forms.Button ButtonTree;
        private System.Windows.Forms.CheckBox checkBoxBacktracking;
        private System.Windows.Forms.CheckBox checkBoxAStar;
        private System.Windows.Forms.CheckBox checkBoxRepeat;
        private System.Windows.Forms.Label labelExpantionOrder;
        private System.Windows.Forms.ListBox listBoxExpantionOrder;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Label labelResoult;
        private System.Windows.Forms.Label labelSteps;
    }
}

