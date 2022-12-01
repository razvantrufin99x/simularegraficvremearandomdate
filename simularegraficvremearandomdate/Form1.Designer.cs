namespace simularegraficvremearandomdate
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadRandomTempsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawGraphicOfTemperaturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadNewDatasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateGraficToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAllControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.baraHistogramaVerticala1 = new simularegraficvremearandomdate.baraHistogramaVerticala();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.executeToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(618, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // executeToolStripMenuItem
            // 
            this.executeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadRandomTempsToolStripMenuItem,
            this.drawGraphicOfTemperaturesToolStripMenuItem,
            this.loadNewDatasToolStripMenuItem,
            this.updateGraficToolStripMenuItem,
            this.updateAllControlsToolStripMenuItem});
            this.executeToolStripMenuItem.Name = "executeToolStripMenuItem";
            this.executeToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.executeToolStripMenuItem.Text = "Execute";
            // 
            // loadRandomTempsToolStripMenuItem
            // 
            this.loadRandomTempsToolStripMenuItem.Name = "loadRandomTempsToolStripMenuItem";
            this.loadRandomTempsToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.loadRandomTempsToolStripMenuItem.Text = "Load Random Temps";
            this.loadRandomTempsToolStripMenuItem.Click += new System.EventHandler(this.loadRandomTempsToolStripMenuItem_Click);
            // 
            // drawGraphicOfTemperaturesToolStripMenuItem
            // 
            this.drawGraphicOfTemperaturesToolStripMenuItem.Name = "drawGraphicOfTemperaturesToolStripMenuItem";
            this.drawGraphicOfTemperaturesToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.drawGraphicOfTemperaturesToolStripMenuItem.Text = "Draw Graphic of Temperatures";
            this.drawGraphicOfTemperaturesToolStripMenuItem.Click += new System.EventHandler(this.drawGraphicOfTemperaturesToolStripMenuItem_Click);
            // 
            // loadNewDatasToolStripMenuItem
            // 
            this.loadNewDatasToolStripMenuItem.Name = "loadNewDatasToolStripMenuItem";
            this.loadNewDatasToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.loadNewDatasToolStripMenuItem.Text = "Load New Datas";
            this.loadNewDatasToolStripMenuItem.Click += new System.EventHandler(this.loadNewDatasToolStripMenuItem_Click);
            // 
            // updateGraficToolStripMenuItem
            // 
            this.updateGraficToolStripMenuItem.Name = "updateGraficToolStripMenuItem";
            this.updateGraficToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.updateGraficToolStripMenuItem.Text = "Update Grafic";
            this.updateGraficToolStripMenuItem.Click += new System.EventHandler(this.updateGraficToolStripMenuItem_Click);
            // 
            // updateAllControlsToolStripMenuItem
            // 
            this.updateAllControlsToolStripMenuItem.Name = "updateAllControlsToolStripMenuItem";
            this.updateAllControlsToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.updateAllControlsToolStripMenuItem.Text = "UpdateAllControls";
            this.updateAllControlsToolStripMenuItem.Click += new System.EventHandler(this.updateAllControlsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 1);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(23, 23);
            this.textBox1.TabIndex = 2;
            // 
            // baraHistogramaVerticala1
            // 
            this.baraHistogramaVerticala1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.baraHistogramaVerticala1.Location = new System.Drawing.Point(0, 200);
            this.baraHistogramaVerticala1.Name = "baraHistogramaVerticala1";
            this.baraHistogramaVerticala1.Size = new System.Drawing.Size(1024, 1);
            this.baraHistogramaVerticala1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 546);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.baraHistogramaVerticala1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random temperature graphic";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadRandomTempsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawGraphicOfTemperaturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadNewDatasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateGraficToolStripMenuItem;
        private baraHistogramaVerticala baraHistogramaVerticala1;
        private System.Windows.Forms.ToolStripMenuItem updateAllControlsToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
    }
}

