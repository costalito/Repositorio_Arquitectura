namespace Metodos_Numericos
{
    partial class Teoria_Eu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teoria_Eu));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.teoróaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejecutarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Método de Euler";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(149, 124);
            this.textBox1.MaximumSize = new System.Drawing.Size(4, 180);
            this.textBox1.MinimumSize = new System.Drawing.Size(654, 120);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(654, 120);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(337, 264);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 270);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            this.menuStrip1.Size = new System.Drawing.Size(925, 32);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(71, 28);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
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
            this.eulerMejoradoToolStripMenuItem.Click += new System.EventHandler(this.eulerMejoradoToolStripMenuItem_Click);
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
            this.teoróaToolStripMenuItem,
            this.ejecutarToolStripMenuItem3});
            this.newtonRaphsonToolStripMenuItem.Name = "newtonRaphsonToolStripMenuItem";
            this.newtonRaphsonToolStripMenuItem.Size = new System.Drawing.Size(173, 28);
            this.newtonRaphsonToolStripMenuItem.Text = "Newton-Raphson";
            // 
            // teoróaToolStripMenuItem
            // 
            this.teoróaToolStripMenuItem.Name = "teoróaToolStripMenuItem";
            this.teoróaToolStripMenuItem.Size = new System.Drawing.Size(156, 28);
            this.teoróaToolStripMenuItem.Text = "Teoría";
            // 
            // ejecutarToolStripMenuItem3
            // 
            this.ejecutarToolStripMenuItem3.Name = "ejecutarToolStripMenuItem3";
            this.ejecutarToolStripMenuItem3.Size = new System.Drawing.Size(156, 28);
            this.ejecutarToolStripMenuItem3.Text = "Ejecutar";
            // 
            // Teoria_Eu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(925, 546);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Teoria_Eu";
            this.Text = "Teoría de Método de Euler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eulerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teoríaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejecutarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eulerMejoradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teoríaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ejecutarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rungeKuttaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teoríaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ejecutarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem newtonRaphsonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teoróaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejecutarToolStripMenuItem3;
    }
}