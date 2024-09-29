namespace PClienteEstudiante
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motorcycleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMotorcycleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchMotorcycleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMotorcycleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMotorcycleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listMotorcycleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "HORNET CORSAIR";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.motorcycleToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(593, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // motorcycleToolStripMenuItem
            // 
            this.motorcycleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMotorcycleToolStripMenuItem,
            this.searchMotorcycleToolStripMenuItem,
            this.deleteMotorcycleToolStripMenuItem,
            this.updateMotorcycleToolStripMenuItem,
            this.listMotorcycleToolStripMenuItem});
            this.motorcycleToolStripMenuItem.Name = "motorcycleToolStripMenuItem";
            this.motorcycleToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.motorcycleToolStripMenuItem.Text = "Motorcycle";
            // 
            // addMotorcycleToolStripMenuItem
            // 
            this.addMotorcycleToolStripMenuItem.Name = "addMotorcycleToolStripMenuItem";
            this.addMotorcycleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addMotorcycleToolStripMenuItem.Text = "Add Motorcycle";
            this.addMotorcycleToolStripMenuItem.Click += new System.EventHandler(this.addMotorcycleToolStripMenuItem_Click);
            // 
            // searchMotorcycleToolStripMenuItem
            // 
            this.searchMotorcycleToolStripMenuItem.Name = "searchMotorcycleToolStripMenuItem";
            this.searchMotorcycleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchMotorcycleToolStripMenuItem.Text = "Search Motorcycle";
            this.searchMotorcycleToolStripMenuItem.Click += new System.EventHandler(this.searchMotorcycleToolStripMenuItem_Click);
            // 
            // deleteMotorcycleToolStripMenuItem
            // 
            this.deleteMotorcycleToolStripMenuItem.Name = "deleteMotorcycleToolStripMenuItem";
            this.deleteMotorcycleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteMotorcycleToolStripMenuItem.Text = "Delete Motorcycle";
            this.deleteMotorcycleToolStripMenuItem.Click += new System.EventHandler(this.deleteMotorcycleToolStripMenuItem_Click);
            // 
            // updateMotorcycleToolStripMenuItem
            // 
            this.updateMotorcycleToolStripMenuItem.Name = "updateMotorcycleToolStripMenuItem";
            this.updateMotorcycleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateMotorcycleToolStripMenuItem.Text = "Update Motorcycle";
            this.updateMotorcycleToolStripMenuItem.Click += new System.EventHandler(this.updateMotorcycleToolStripMenuItem_Click);
            // 
            // listMotorcycleToolStripMenuItem
            // 
            this.listMotorcycleToolStripMenuItem.Name = "listMotorcycleToolStripMenuItem";
            this.listMotorcycleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listMotorcycleToolStripMenuItem.Text = "List Motorcycle";
            this.listMotorcycleToolStripMenuItem.Click += new System.EventHandler(this.listMotorcycleToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 354);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente Estudiante";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motorcycleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMotorcycleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchMotorcycleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMotorcycleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMotorcycleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listMotorcycleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
    }
}

