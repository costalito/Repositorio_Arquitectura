namespace Metodos_Numericos
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejecutarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eulerMejoradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teoríaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ejecutarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rungeKuttaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teoríaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ejecutarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.newtonRaphsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teoríaToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ejecutarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.NI = new System.Windows.Forms.Label();
            this.X0 = new System.Windows.Forms.Label();
            this.Y0 = new System.Windows.Forms.Label();
            this.H = new System.Windows.Forms.Label();
            this.CNI = new System.Windows.Forms.TextBox();
            this.CX0 = new System.Windows.Forms.TextBox();
            this.CY0 = new System.Windows.Forms.TextBox();
            this.CH = new System.Windows.Forms.TextBox();
            this.Ejecutar_E = new System.Windows.Forms.Button();
            this.M_E = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.eulerToolStripMenuItem,
            this.eulerMejoradoToolStripMenuItem,
            this.rungeKuttaToolStripMenuItem,
            this.newtonRaphsonToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(977, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(71, 28);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // eulerToolStripMenuItem
            // 
            this.eulerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teoríaToolStripMenuItem,
            this.ejecutarToolStripMenuItem});
            this.eulerToolStripMenuItem.Name = "eulerToolStripMenuItem";
            this.eulerToolStripMenuItem.Size = new System.Drawing.Size(69, 28);
            this.eulerToolStripMenuItem.Text = "Euler";
            // 
            // teoríaToolStripMenuItem
            // 
            this.teoríaToolStripMenuItem.Name = "teoríaToolStripMenuItem";
            this.teoríaToolStripMenuItem.Size = new System.Drawing.Size(156, 28);
            this.teoríaToolStripMenuItem.Text = "Teoría";
            // 
            // ejecutarToolStripMenuItem
            // 
            this.ejecutarToolStripMenuItem.Name = "ejecutarToolStripMenuItem";
            this.ejecutarToolStripMenuItem.Size = new System.Drawing.Size(156, 28);
            this.ejecutarToolStripMenuItem.Text = "Ejecutar";
            // 
            // eulerMejoradoToolStripMenuItem
            // 
            this.eulerMejoradoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teoríaToolStripMenuItem1,
            this.ejecutarToolStripMenuItem1});
            this.eulerMejoradoToolStripMenuItem.Name = "eulerMejoradoToolStripMenuItem";
            this.eulerMejoradoToolStripMenuItem.Size = new System.Drawing.Size(157, 28);
            this.eulerMejoradoToolStripMenuItem.Text = "Euler Mejorado";
            // 
            // teoríaToolStripMenuItem1
            // 
            this.teoríaToolStripMenuItem1.Name = "teoríaToolStripMenuItem1";
            this.teoríaToolStripMenuItem1.Size = new System.Drawing.Size(156, 28);
            this.teoríaToolStripMenuItem1.Text = "Teoría";
            // 
            // ejecutarToolStripMenuItem1
            // 
            this.ejecutarToolStripMenuItem1.Name = "ejecutarToolStripMenuItem1";
            this.ejecutarToolStripMenuItem1.Size = new System.Drawing.Size(156, 28);
            this.ejecutarToolStripMenuItem1.Text = "Ejecutar";
            // 
            // rungeKuttaToolStripMenuItem
            // 
            this.rungeKuttaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teoríaToolStripMenuItem2,
            this.ejecutarToolStripMenuItem2});
            this.rungeKuttaToolStripMenuItem.Name = "rungeKuttaToolStripMenuItem";
            this.rungeKuttaToolStripMenuItem.Size = new System.Drawing.Size(132, 28);
            this.rungeKuttaToolStripMenuItem.Text = "Runge Kutta";
            // 
            // teoríaToolStripMenuItem2
            // 
            this.teoríaToolStripMenuItem2.Name = "teoríaToolStripMenuItem2";
            this.teoríaToolStripMenuItem2.Size = new System.Drawing.Size(156, 28);
            this.teoríaToolStripMenuItem2.Text = "Teoría";
            // 
            // ejecutarToolStripMenuItem2
            // 
            this.ejecutarToolStripMenuItem2.Name = "ejecutarToolStripMenuItem2";
            this.ejecutarToolStripMenuItem2.Size = new System.Drawing.Size(156, 28);
            this.ejecutarToolStripMenuItem2.Text = "Ejecutar";
            // 
            // newtonRaphsonToolStripMenuItem
            // 
            this.newtonRaphsonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teoríaToolStripMenuItem3,
            this.ejecutarToolStripMenuItem3});
            this.newtonRaphsonToolStripMenuItem.Name = "newtonRaphsonToolStripMenuItem";
            this.newtonRaphsonToolStripMenuItem.Size = new System.Drawing.Size(173, 28);
            this.newtonRaphsonToolStripMenuItem.Text = "Newton-Raphson";
            // 
            // teoríaToolStripMenuItem3
            // 
            this.teoríaToolStripMenuItem3.Name = "teoríaToolStripMenuItem3";
            this.teoríaToolStripMenuItem3.Size = new System.Drawing.Size(156, 28);
            this.teoríaToolStripMenuItem3.Text = "Teoría";
            // 
            // ejecutarToolStripMenuItem3
            // 
            this.ejecutarToolStripMenuItem3.Name = "ejecutarToolStripMenuItem3";
            this.ejecutarToolStripMenuItem3.Size = new System.Drawing.Size(156, 28);
            this.ejecutarToolStripMenuItem3.Text = "Ejecutar";
            // 
            // NI
            // 
            this.NI.AutoSize = true;
            this.NI.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NI.Location = new System.Drawing.Point(52, 102);
            this.NI.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.NI.Name = "NI";
            this.NI.Size = new System.Drawing.Size(194, 22);
            this.NI.TabIndex = 1;
            this.NI.Text = "Número de iteraciones";
            // 
            // X0
            // 
            this.X0.AutoSize = true;
            this.X0.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X0.Location = new System.Drawing.Point(337, 102);
            this.X0.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.X0.Name = "X0";
            this.X0.Size = new System.Drawing.Size(106, 22);
            this.X0.TabIndex = 2;
            this.X0.Text = "Valor de X0";
            // 
            // Y0
            // 
            this.Y0.AutoSize = true;
            this.Y0.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Y0.Location = new System.Drawing.Point(554, 102);
            this.Y0.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Y0.Name = "Y0";
            this.Y0.Size = new System.Drawing.Size(105, 22);
            this.Y0.TabIndex = 3;
            this.Y0.Text = "Valor de Y0";
            // 
            // H
            // 
            this.H.AutoSize = true;
            this.H.Location = new System.Drawing.Point(760, 102);
            this.H.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(158, 22);
            this.H.TabIndex = 4;
            this.H.Text = "Tamaño de paso h";
            // 
            // CNI
            // 
            this.CNI.Location = new System.Drawing.Point(85, 127);
            this.CNI.Name = "CNI";
            this.CNI.Size = new System.Drawing.Size(100, 29);
            this.CNI.TabIndex = 5;
            this.CNI.TextChanged += new System.EventHandler(this.CNI_TextChanged);
            this.CNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CNI_KeyPress);
            // 
            // CX0
            // 
            this.CX0.Location = new System.Drawing.Point(341, 127);
            this.CX0.Name = "CX0";
            this.CX0.Size = new System.Drawing.Size(100, 29);
            this.CX0.TabIndex = 6;
            this.CX0.TextChanged += new System.EventHandler(this.CX0_TextChanged);
            // 
            // CY0
            // 
            this.CY0.Location = new System.Drawing.Point(558, 127);
            this.CY0.Name = "CY0";
            this.CY0.Size = new System.Drawing.Size(100, 29);
            this.CY0.TabIndex = 7;
            this.CY0.TextChanged += new System.EventHandler(this.CY0_TextChanged);
            // 
            // CH
            // 
            this.CH.Location = new System.Drawing.Point(786, 127);
            this.CH.Name = "CH";
            this.CH.Size = new System.Drawing.Size(100, 29);
            this.CH.TabIndex = 8;
            this.CH.TextChanged += new System.EventHandler(this.CH_TextChanged);
            // 
            // Ejecutar_E
            // 
            this.Ejecutar_E.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Ejecutar_E.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ejecutar_E.ForeColor = System.Drawing.Color.Black;
            this.Ejecutar_E.Location = new System.Drawing.Point(456, 199);
            this.Ejecutar_E.Name = "Ejecutar_E";
            this.Ejecutar_E.Size = new System.Drawing.Size(97, 35);
            this.Ejecutar_E.TabIndex = 9;
            this.Ejecutar_E.Text = "Ejecutar";
            this.Ejecutar_E.UseVisualStyleBackColor = false;
            // 
            // M_E
            // 
            this.M_E.AutoSize = true;
            this.M_E.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M_E.Location = new System.Drawing.Point(351, 45);
            this.M_E.Name = "M_E";
            this.M_E.Size = new System.Drawing.Size(245, 36);
            this.M_E.TabIndex = 10;
            this.M_E.Text = "Método de Euler";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(977, 749);
            this.Controls.Add(this.M_E);
            this.Controls.Add(this.Ejecutar_E);
            this.Controls.Add(this.CH);
            this.Controls.Add(this.CY0);
            this.Controls.Add(this.CX0);
            this.Controls.Add(this.CNI);
            this.Controls.Add(this.H);
            this.Controls.Add(this.Y0);
            this.Controls.Add(this.X0);
            this.Controls.Add(this.NI);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form2";
            this.Text = "Método de Euler";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eulerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eulerMejoradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rungeKuttaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newtonRaphsonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teoríaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejecutarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teoríaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ejecutarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem teoríaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ejecutarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem teoríaToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem ejecutarToolStripMenuItem3;
        private System.Windows.Forms.Label NI;
        private System.Windows.Forms.Label X0;
        private System.Windows.Forms.Label Y0;
        private System.Windows.Forms.Label H;
        private System.Windows.Forms.TextBox CNI;
        private System.Windows.Forms.TextBox CX0;
        private System.Windows.Forms.TextBox CY0;
        private System.Windows.Forms.TextBox CH;
        private System.Windows.Forms.Button Ejecutar_E;
        private System.Windows.Forms.Label M_E;
    }
}