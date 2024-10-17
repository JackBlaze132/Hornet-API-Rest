namespace PClienteEstudiante.view.bodywork
{
    partial class GUIListBodywork
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
            this.dataGridBody = new System.Windows.Forms.DataGridView();
            this.idTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sunroofTableColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBody)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFilters
            // 
            this.lblFilters.AutoSize = true;
            this.lblFilters.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilters.Location = new System.Drawing.Point(209, 98);
            this.lblFilters.Name = "lblFilters";
            this.lblFilters.Size = new System.Drawing.Size(85, 26);
            this.lblFilters.TabIndex = 32;
            this.lblFilters.Text = "FILTERS";
            // 
            // lblFilterABS
            // 
            this.lblFilterABS.AutoSize = true;
            this.lblFilterABS.Location = new System.Drawing.Point(211, 153);
            this.lblFilterABS.Name = "lblFilterABS";
            this.lblFilterABS.Size = new System.Drawing.Size(60, 16);
            this.lblFilterABS.TabIndex = 31;
            this.lblFilterABS.Text = "Sunroof?";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "YES",
            "NOT"});
            this.checkedListBox2.Location = new System.Drawing.Point(214, 172);
            this.checkedListBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(120, 55);
            this.checkedListBox2.TabIndex = 30;
            this.checkedListBox2.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(517, 480);
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
            this.btnFilter.Location = new System.Drawing.Point(214, 257);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(120, 30);
            this.btnFilter.TabIndex = 28;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dataGridBody
            // 
            this.dataGridBody.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridBody.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBody.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTableColumn,
            this.nameTableColumn,
            this.sunroofTableColumn});
            this.dataGridBody.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridBody.Location = new System.Drawing.Point(463, 98);
            this.dataGridBody.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridBody.Name = "dataGridBody";
            this.dataGridBody.RowHeadersWidth = 51;
            this.dataGridBody.Size = new System.Drawing.Size(384, 342);
            this.dataGridBody.TabIndex = 25;
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
            // nameTableColumn
            // 
            this.nameTableColumn.DataPropertyName = "name";
            this.nameTableColumn.HeaderText = "Name";
            this.nameTableColumn.MinimumWidth = 6;
            this.nameTableColumn.Name = "nameTableColumn";
            this.nameTableColumn.ReadOnly = true;
            this.nameTableColumn.Width = 125;
            // 
            // sunroofTableColumn
            // 
            this.sunroofTableColumn.DataPropertyName = "hasSunroof";
            this.sunroofTableColumn.HeaderText = "Sunroof";
            this.sunroofTableColumn.MinimumWidth = 6;
            this.sunroofTableColumn.Name = "sunroofTableColumn";
            this.sunroofTableColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sunroofTableColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sunroofTableColumn.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "List Bodywork";
            // 
            // GUIListBodywork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 590);
            this.Controls.Add(this.lblFilters);
            this.Controls.Add(this.lblFilterABS);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dataGridBody);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GUIListBodywork";
            this.Text = "GUIListBodywork";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBody)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilters;
        private System.Windows.Forms.Label lblFilterABS;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridView dataGridBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameTableColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sunroofTableColumn;
    }
}