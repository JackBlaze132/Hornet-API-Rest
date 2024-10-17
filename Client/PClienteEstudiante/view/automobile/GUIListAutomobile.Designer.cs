namespace PClienteEstudiante.view.automobile
{
    partial class GUIListAutomobile
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
            this.lblFilters = new System.Windows.Forms.Label();
            this.lblFilterABS = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dataGridAutomobile = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.idTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snidTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.absTableColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bodyworkModelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodyworkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodyworkSunroof = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.arrivalDateTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAutomobile)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFilters
            // 
            this.lblFilters.AutoSize = true;
            this.lblFilters.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilters.Location = new System.Drawing.Point(61, 121);
            this.lblFilters.Name = "lblFilters";
            this.lblFilters.Size = new System.Drawing.Size(85, 26);
            this.lblFilters.TabIndex = 32;
            this.lblFilters.Text = "FILTERS";
            // 
            // lblFilterABS
            // 
            this.lblFilterABS.AutoSize = true;
            this.lblFilterABS.Location = new System.Drawing.Point(52, 181);
            this.lblFilterABS.Name = "lblFilterABS";
            this.lblFilterABS.Size = new System.Drawing.Size(95, 16);
            this.lblFilterABS.TabIndex = 31;
            this.lblFilterABS.Text = "ABS Included?";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "YES",
            "NOT"});
            this.checkedListBox2.Location = new System.Drawing.Point(55, 201);
            this.checkedListBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(120, 38);
            this.checkedListBox2.TabIndex = 30;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(661, 471);
            this.btnList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(131, 43);
            this.btnList.TabIndex = 29;
            this.btnList.Text = "LIST";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(55, 315);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(120, 30);
            this.btnFilter.TabIndex = 28;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dataGridAutomobile
            // 
            this.dataGridAutomobile.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridAutomobile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAutomobile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTableColumn,
            this.brandTableColumn,
            this.priceTableColumn,
            this.snidTableColumn,
            this.absTableColumn,
            this.bodyworkModelColumn,
            this.bodyworkName,
            this.bodyworkSunroof,
            this.arrivalDateTableColumn});
            this.dataGridAutomobile.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridAutomobile.Location = new System.Drawing.Point(200, 105);
            this.dataGridAutomobile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridAutomobile.Name = "dataGridAutomobile";
            this.dataGridAutomobile.RowHeadersWidth = 51;
            this.dataGridAutomobile.Size = new System.Drawing.Size(1097, 342);
            this.dataGridAutomobile.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "List Automobile";
            // 
            // idTableColumn
            // 
            this.idTableColumn.DataPropertyName = "id";
            this.idTableColumn.HeaderText = "Id";
            this.idTableColumn.MinimumWidth = 6;
            this.idTableColumn.Name = "idTableColumn";
            this.idTableColumn.ReadOnly = true;
            this.idTableColumn.Width = 80;
            // 
            // brandTableColumn
            // 
            this.brandTableColumn.DataPropertyName = "brand";
            this.brandTableColumn.HeaderText = "Brand";
            this.brandTableColumn.MinimumWidth = 6;
            this.brandTableColumn.Name = "brandTableColumn";
            this.brandTableColumn.ReadOnly = true;
            this.brandTableColumn.Width = 125;
            // 
            // priceTableColumn
            // 
            this.priceTableColumn.DataPropertyName = "price";
            this.priceTableColumn.HeaderText = "Price";
            this.priceTableColumn.MinimumWidth = 6;
            this.priceTableColumn.Name = "priceTableColumn";
            this.priceTableColumn.ReadOnly = true;
            this.priceTableColumn.Width = 125;
            // 
            // snidTableColumn
            // 
            this.snidTableColumn.DataPropertyName = "snid";
            this.snidTableColumn.HeaderText = "SNID";
            this.snidTableColumn.MinimumWidth = 6;
            this.snidTableColumn.Name = "snidTableColumn";
            this.snidTableColumn.ReadOnly = true;
            this.snidTableColumn.Width = 125;
            // 
            // absTableColumn
            // 
            this.absTableColumn.DataPropertyName = "absBrake";
            this.absTableColumn.HeaderText = "ABS";
            this.absTableColumn.MinimumWidth = 6;
            this.absTableColumn.Name = "absTableColumn";
            this.absTableColumn.ReadOnly = true;
            this.absTableColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.absTableColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.absTableColumn.Width = 80;
            // 
            // bodyworkModelColumn
            // 
            this.bodyworkModelColumn.DataPropertyName = "bodyworkId";
            this.bodyworkModelColumn.HeaderText = "Bodywork Id";
            this.bodyworkModelColumn.MinimumWidth = 6;
            this.bodyworkModelColumn.Name = "bodyworkModelColumn";
            this.bodyworkModelColumn.ReadOnly = true;
            this.bodyworkModelColumn.Width = 125;
            // 
            // bodyworkName
            // 
            this.bodyworkName.DataPropertyName = "bodyworkName";
            this.bodyworkName.HeaderText = "Bodywork Name";
            this.bodyworkName.MinimumWidth = 6;
            this.bodyworkName.Name = "bodyworkName";
            this.bodyworkName.Width = 125;
            // 
            // bodyworkSunroof
            // 
            this.bodyworkSunroof.DataPropertyName = "bodyworkSunroof";
            this.bodyworkSunroof.HeaderText = "Bodywork Sunroof";
            this.bodyworkSunroof.MinimumWidth = 6;
            this.bodyworkSunroof.Name = "bodyworkSunroof";
            this.bodyworkSunroof.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bodyworkSunroof.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.bodyworkSunroof.Width = 125;
            // 
            // arrivalDateTableColumn
            // 
            this.arrivalDateTableColumn.DataPropertyName = "arrivalDate";
            this.arrivalDateTableColumn.HeaderText = "Arrival Date";
            this.arrivalDateTableColumn.MinimumWidth = 6;
            this.arrivalDateTableColumn.Name = "arrivalDateTableColumn";
            this.arrivalDateTableColumn.ReadOnly = true;
            this.arrivalDateTableColumn.Width = 125;
            // 
            // GUIListAutomobile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 620);
            this.Controls.Add(this.lblFilters);
            this.Controls.Add(this.lblFilterABS);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dataGridAutomobile);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GUIListAutomobile";
            this.Text = "List Automobile";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAutomobile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilters;
        private System.Windows.Forms.Label lblFilterABS;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridView dataGridAutomobile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snidTableColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn absTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodyworkModelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodyworkName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bodyworkSunroof;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalDateTableColumn;
    }
}