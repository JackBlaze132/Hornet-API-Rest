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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lblFilterHelmet = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
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
            this.lblFilters = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMoto)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.dataGridMoto.Location = new System.Drawing.Point(269, 105);
            this.dataGridMoto.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridMoto.Name = "dataGridMoto";
            this.dataGridMoto.RowHeadersWidth = 51;
            this.dataGridMoto.Size = new System.Drawing.Size(727, 342);
            this.dataGridMoto.TabIndex = 14;
            this.dataGridMoto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMoto_CellContentClick);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "YES",
            "NOT"});
            this.checkedListBox1.Location = new System.Drawing.Point(37, 184);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 55);
            this.checkedListBox1.TabIndex = 17;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // lblFilterHelmet
            // 
            this.lblFilterHelmet.AutoSize = true;
            this.lblFilterHelmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterHelmet.Location = new System.Drawing.Point(34, 165);
            this.lblFilterHelmet.Name = "lblFilterHelmet";
            this.lblFilterHelmet.Size = new System.Drawing.Size(111, 16);
            this.lblFilterHelmet.TabIndex = 18;
            this.lblFilterHelmet.Text = "Helmet Included?";
            this.lblFilterHelmet.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(37, 371);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(120, 30);
            this.btnFilter.TabIndex = 19;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(440, 473);
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
            this.lblFilterABS.Location = new System.Drawing.Point(34, 267);
            this.lblFilterABS.Name = "lblFilterABS";
            this.lblFilterABS.Size = new System.Drawing.Size(95, 16);
            this.lblFilterABS.TabIndex = 22;
            this.lblFilterABS.Text = "ABS Included?";
            this.lblFilterABS.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "YES",
            "NOT"});
            this.checkedListBox2.Location = new System.Drawing.Point(37, 286);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(120, 55);
            this.checkedListBox2.TabIndex = 21;
            this.checkedListBox2.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // lblFilters
            // 
            this.lblFilters.AutoSize = true;
            this.lblFilters.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilters.Location = new System.Drawing.Point(43, 124);
            this.lblFilters.Name = "lblFilters";
            this.lblFilters.Size = new System.Drawing.Size(85, 26);
            this.lblFilters.TabIndex = 23;
            this.lblFilters.Text = "FILTERS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(37, 416);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(11, 35);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(103, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(11, 62);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(103, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // GUIListMotorcycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 530);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFilters);
            this.Controls.Add(this.lblFilterABS);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.lblFilterHelmet);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.dataGridMoto);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GUIListMotorcycle";
            this.Text = "List Motorcycle";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridMoto;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lblFilterHelmet;
        private System.Windows.Forms.Button btnFilter;
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
        private System.Windows.Forms.Label lblFilters;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}