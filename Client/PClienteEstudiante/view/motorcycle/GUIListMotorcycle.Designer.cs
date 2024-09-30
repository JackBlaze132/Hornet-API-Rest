namespace PClienteEstudiante.view.motorcycle
{
    partial class GUIListMotorcycle
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridMoto = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lblFilterHelmet = new System.Windows.Forms.Label();
            this.Filter = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.idTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snidTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.absTableColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.forktypeModelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.helmetTableColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.arrivalDateTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFilterABS = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(404, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "List Motorcycle";
            // 
            // dataGridMoto
            // 
            this.dataGridMoto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMoto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTableColumn,
            this.brandTableColumn,
            this.priceTableColumn,
            this.snidTableColumn,
            this.absTableColumn,
            this.forktypeModelColumn,
            this.helmetTableColumn,
            this.arrivalDateTableColumn});
            this.dataGridMoto.Location = new System.Drawing.Point(184, 151);
            this.dataGridMoto.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridMoto.Name = "dataGridMoto";
            this.dataGridMoto.RowHeadersWidth = 51;
            this.dataGridMoto.Size = new System.Drawing.Size(800, 369);
            this.dataGridMoto.TabIndex = 14;
            this.dataGridMoto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMoto_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Busqueda Rápida";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(229, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(755, 22);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.checkedListBox1.Location = new System.Drawing.Point(40, 257);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 55);
            this.checkedListBox1.TabIndex = 17;
            this.checkedListBox1.Visible = false;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // lblFilterHelmet
            // 
            this.lblFilterHelmet.AutoSize = true;
            this.lblFilterHelmet.Location = new System.Drawing.Point(37, 238);
            this.lblFilterHelmet.Name = "lblFilterHelmet";
            this.lblFilterHelmet.Size = new System.Drawing.Size(110, 16);
            this.lblFilterHelmet.TabIndex = 18;
            this.lblFilterHelmet.Text = "¿Helmet Include?";
            this.lblFilterHelmet.Click += new System.EventHandler(this.label3_Click);
            // 
            // Filter
            // 
            this.Filter.Location = new System.Drawing.Point(40, 444);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(120, 30);
            this.Filter.TabIndex = 19;
            this.Filter.Text = "Filter";
            this.Filter.UseVisualStyleBackColor = true;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(448, 537);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(130, 43);
            this.btnList.TabIndex = 20;
            this.btnList.Text = "LIST";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // idTableColumn
            // 
            this.idTableColumn.HeaderText = "Id";
            this.idTableColumn.MinimumWidth = 6;
            this.idTableColumn.Name = "idTableColumn";
            this.idTableColumn.ReadOnly = true;
            this.idTableColumn.Width = 80;
            // 
            // brandTableColumn
            // 
            this.brandTableColumn.HeaderText = "Brand";
            this.brandTableColumn.MinimumWidth = 6;
            this.brandTableColumn.Name = "brandTableColumn";
            this.brandTableColumn.ReadOnly = true;
            // 
            // priceTableColumn
            // 
            this.priceTableColumn.HeaderText = "Price";
            this.priceTableColumn.MinimumWidth = 6;
            this.priceTableColumn.Name = "priceTableColumn";
            this.priceTableColumn.ReadOnly = true;
            // 
            // snidTableColumn
            // 
            this.snidTableColumn.HeaderText = "SNID";
            this.snidTableColumn.MinimumWidth = 6;
            this.snidTableColumn.Name = "snidTableColumn";
            this.snidTableColumn.ReadOnly = true;
            // 
            // absTableColumn
            // 
            this.absTableColumn.HeaderText = "ABS";
            this.absTableColumn.MinimumWidth = 6;
            this.absTableColumn.Name = "absTableColumn";
            this.absTableColumn.ReadOnly = true;
            this.absTableColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.absTableColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.absTableColumn.Width = 80;
            // 
            // forktypeModelColumn
            // 
            this.forktypeModelColumn.HeaderText = "Forktype";
            this.forktypeModelColumn.MinimumWidth = 6;
            this.forktypeModelColumn.Name = "forktypeModelColumn";
            this.forktypeModelColumn.ReadOnly = true;
            // 
            // helmetTableColumn
            // 
            this.helmetTableColumn.HeaderText = "Helmet Included";
            this.helmetTableColumn.MinimumWidth = 6;
            this.helmetTableColumn.Name = "helmetTableColumn";
            this.helmetTableColumn.ReadOnly = true;
            this.helmetTableColumn.Width = 80;
            // 
            // arrivalDateTableColumn
            // 
            this.arrivalDateTableColumn.HeaderText = "Arrival Date";
            this.arrivalDateTableColumn.MinimumWidth = 6;
            this.arrivalDateTableColumn.Name = "arrivalDateTableColumn";
            this.arrivalDateTableColumn.ReadOnly = true;
            // 
            // lblFilterABS
            // 
            this.lblFilterABS.AutoSize = true;
            this.lblFilterABS.Location = new System.Drawing.Point(37, 340);
            this.lblFilterABS.Name = "lblFilterABS";
            this.lblFilterABS.Size = new System.Drawing.Size(94, 16);
            this.lblFilterABS.TabIndex = 22;
            this.lblFilterABS.Text = "¿ABS Include?";
            this.lblFilterABS.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.checkedListBox2.Location = new System.Drawing.Point(40, 359);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(120, 55);
            this.checkedListBox2.TabIndex = 21;
            this.checkedListBox2.Visible = false;
            this.checkedListBox2.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 26);
            this.label3.TabIndex = 23;
            this.label3.Text = "FILTERS";
            // 
            // GUIListMotorcycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 603);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFilterABS);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.lblFilterHelmet);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridMoto);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GUIListMotorcycle";
            this.Text = "List Motorcycle";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridMoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lblFilterHelmet;
        private System.Windows.Forms.Button Filter;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snidTableColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn absTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn forktypeModelColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn helmetTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalDateTableColumn;
        private System.Windows.Forms.Label lblFilterABS;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Label label3;
    }
}