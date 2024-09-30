namespace PClienteEstudiante.view.motorcycle
{
    partial class GUIUpdateMotorcycle
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
            this.btnUpdateMoto = new System.Windows.Forms.Button();
            this.btnSearchMoto = new System.Windows.Forms.Button();
            this.dataGridMoto = new System.Windows.Forms.DataGridView();
            this.txtIdMoto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snidTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.absTableColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.forktypeModelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.helmetTableColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.arrivalDateTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Motorcycle";
            // 
            // btnUpdateMoto
            // 
            this.btnUpdateMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMoto.Location = new System.Drawing.Point(555, 464);
            this.btnUpdateMoto.Name = "btnUpdateMoto";
            this.btnUpdateMoto.Size = new System.Drawing.Size(164, 57);
            this.btnUpdateMoto.TabIndex = 10;
            this.btnUpdateMoto.Text = "Update";
            this.btnUpdateMoto.UseVisualStyleBackColor = true;
            this.btnUpdateMoto.Click += new System.EventHandler(this.btnUpdateMoto_Click);
            // 
            // btnSearchMoto
            // 
            this.btnSearchMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMoto.Location = new System.Drawing.Point(268, 464);
            this.btnSearchMoto.Name = "btnSearchMoto";
            this.btnSearchMoto.Size = new System.Drawing.Size(162, 57);
            this.btnSearchMoto.TabIndex = 9;
            this.btnSearchMoto.Text = "Search";
            this.btnSearchMoto.UseVisualStyleBackColor = true;
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
            this.dataGridMoto.Location = new System.Drawing.Point(70, 136);
            this.dataGridMoto.Name = "dataGridMoto";
            this.dataGridMoto.Size = new System.Drawing.Size(844, 300);
            this.dataGridMoto.TabIndex = 8;
            // 
            // txtIdMoto
            // 
            this.txtIdMoto.Location = new System.Drawing.Point(411, 75);
            this.txtIdMoto.Name = "txtIdMoto";
            this.txtIdMoto.Size = new System.Drawing.Size(375, 20);
            this.txtIdMoto.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Id Moto:";
            // 
            // idTableColumn
            // 
            this.idTableColumn.HeaderText = "Id";
            this.idTableColumn.Name = "idTableColumn";
            this.idTableColumn.ReadOnly = true;
            // 
            // brandTableColumn
            // 
            this.brandTableColumn.HeaderText = "Brand";
            this.brandTableColumn.Name = "brandTableColumn";
            this.brandTableColumn.ReadOnly = true;
            // 
            // priceTableColumn
            // 
            this.priceTableColumn.HeaderText = "Price";
            this.priceTableColumn.Name = "priceTableColumn";
            this.priceTableColumn.ReadOnly = true;
            // 
            // snidTableColumn
            // 
            this.snidTableColumn.HeaderText = "SNID";
            this.snidTableColumn.Name = "snidTableColumn";
            this.snidTableColumn.ReadOnly = true;
            // 
            // absTableColumn
            // 
            this.absTableColumn.HeaderText = "ABS";
            this.absTableColumn.Name = "absTableColumn";
            this.absTableColumn.ReadOnly = true;
            this.absTableColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.absTableColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // forktypeModelColumn
            // 
            this.forktypeModelColumn.HeaderText = "Forktype";
            this.forktypeModelColumn.Name = "forktypeModelColumn";
            this.forktypeModelColumn.ReadOnly = true;
            // 
            // helmetTableColumn
            // 
            this.helmetTableColumn.HeaderText = "Helmet Included";
            this.helmetTableColumn.Name = "helmetTableColumn";
            this.helmetTableColumn.ReadOnly = true;
            // 
            // arrivalDateTableColumn
            // 
            this.arrivalDateTableColumn.HeaderText = "Arrival Date";
            this.arrivalDateTableColumn.Name = "arrivalDateTableColumn";
            this.arrivalDateTableColumn.ReadOnly = true;
            // 
            // GUIUpdateMotorcycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 596);
            this.Controls.Add(this.btnUpdateMoto);
            this.Controls.Add(this.btnSearchMoto);
            this.Controls.Add(this.dataGridMoto);
            this.Controls.Add(this.txtIdMoto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GUIUpdateMotorcycle";
            this.Text = "Update Motorcycle";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateMoto;
        private System.Windows.Forms.Button btnSearchMoto;
        private System.Windows.Forms.DataGridView dataGridMoto;
        private System.Windows.Forms.TextBox txtIdMoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snidTableColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn absTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn forktypeModelColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn helmetTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalDateTableColumn;
    }
}