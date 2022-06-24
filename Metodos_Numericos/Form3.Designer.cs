namespace Metodos_Numericos
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eulerMejoradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejecutarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rungeKuttaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teoríaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ejecutarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.teoríaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ejecutarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.newtonRaphtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.newtonRaphtonToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(932, 36);
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
            this.teoríaToolStripMenuItem2,
            this.ejecutarToolStripMenuItem2});
            this.eulerToolStripMenuItem.Name = "eulerToolStripMenuItem";
            this.eulerToolStripMenuItem.Size = new System.Drawing.Size(69, 28);
            this.eulerToolStripMenuItem.Text = "Euler";
            // 
            // eulerMejoradoToolStripMenuItem
            // 
            this.eulerMejoradoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teoríaToolStripMenuItem,
            this.ejecutarToolStripMenuItem});
            this.eulerMejoradoToolStripMenuItem.Name = "eulerMejoradoToolStripMenuItem";
            this.eulerMejoradoToolStripMenuItem.Size = new System.Drawing.Size(157, 28);
            this.eulerMejoradoToolStripMenuItem.Text = "Euler Mejorado";
            this.eulerMejoradoToolStripMenuItem.Click += new System.EventHandler(this.eulerMejoradoToolStripMenuItem_Click);
            // 
            // teoríaToolStripMenuItem
            // 
            this.teoríaToolStripMenuItem.Name = "teoríaToolStripMenuItem";
            this.teoríaToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.teoríaToolStripMenuItem.Text = "Teoría";
            // 
            // ejecutarToolStripMenuItem
            // 
            this.ejecutarToolStripMenuItem.Name = "ejecutarToolStripMenuItem";
            this.ejecutarToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.ejecutarToolStripMenuItem.Text = "Ejecutar";
            // 
            // rungeKuttaToolStripMenuItem
            // 
            this.rungeKuttaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teoríaToolStripMenuItem1,
            this.ejecutarToolStripMenuItem1});
            this.rungeKuttaToolStripMenuItem.Name = "rungeKuttaToolStripMenuItem";
            this.rungeKuttaToolStripMenuItem.Size = new System.Drawing.Size(132, 28);
            this.rungeKuttaToolStripMenuItem.Text = "Runge Kutta";
            // 
            // teoríaToolStripMenuItem1
            // 
            this.teoríaToolStripMenuItem1.Name = "teoríaToolStripMenuItem1";
            this.teoríaToolStripMenuItem1.Size = new System.Drawing.Size(180, 28);
            this.teoríaToolStripMenuItem1.Text = "Teoría";
            // 
            // ejecutarToolStripMenuItem1
            // 
            this.ejecutarToolStripMenuItem1.Name = "ejecutarToolStripMenuItem1";
            this.ejecutarToolStripMenuItem1.Size = new System.Drawing.Size(180, 28);
            this.ejecutarToolStripMenuItem1.Text = "Ejecutar";
            // 
            // teoríaToolStripMenuItem2
            // 
            this.teoríaToolStripMenuItem2.Name = "teoríaToolStripMenuItem2";
            this.teoríaToolStripMenuItem2.Size = new System.Drawing.Size(180, 28);
            this.teoríaToolStripMenuItem2.Text = "Teoría";
            // 
            // ejecutarToolStripMenuItem2
            // 
            this.ejecutarToolStripMenuItem2.Name = "ejecutarToolStripMenuItem2";
            this.ejecutarToolStripMenuItem2.Size = new System.Drawing.Size(180, 28);
            this.ejecutarToolStripMenuItem2.Text = "Ejecutar";
            // 
            // newtonRaphtonToolStripMenuItem
            // 
            this.newtonRaphtonToolStripMenuItem.Name = "newtonRaphtonToolStripMenuItem";
            this.newtonRaphtonToolStripMenuItem.Size = new System.Drawing.Size(173, 28);
            this.newtonRaphtonToolStripMenuItem.Text = "Newton-Raphton";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Método de Euler Mejorado";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(152, 123);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(663, 104);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(319, 266);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 147);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(932, 749);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form3";
            this.Text = "Teoría de Euler mejorado";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eulerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eulerMejoradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teoríaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejecutarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rungeKuttaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teoríaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ejecutarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem teoríaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ejecutarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newtonRaphtonToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}