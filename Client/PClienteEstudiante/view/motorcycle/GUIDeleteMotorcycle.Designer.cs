﻿namespace PClienteEstudiante.view.motorcycle
{
    partial class GUIDeleteMotorcycle
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdMoto = new System.Windows.Forms.TextBox();
            this.dataGridMoto = new System.Windows.Forms.DataGridView();
            this.btnSearchMoto = new System.Windows.Forms.Button();
            this.btnDeleteMoto = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(492, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delete Motorcycle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Moto:";
            // 
            // txtIdMoto
            // 
            this.txtIdMoto.Location = new System.Drawing.Point(537, 117);
            this.txtIdMoto.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdMoto.Name = "txtIdMoto";
            this.txtIdMoto.Size = new System.Drawing.Size(499, 22);
            this.txtIdMoto.TabIndex = 2;
            this.txtIdMoto.TextChanged += new System.EventHandler(this.txtIdMoto_TextChanged);
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
            this.dataGridMoto.Location = new System.Drawing.Point(83, 192);
            this.dataGridMoto.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridMoto.Name = "dataGridMoto";
            this.dataGridMoto.RowHeadersWidth = 51;
            this.dataGridMoto.Size = new System.Drawing.Size(1125, 369);
            this.dataGridMoto.TabIndex = 3;
            this.dataGridMoto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMoto_CellContentClick);
            // 
            // btnSearchMoto
            // 
            this.btnSearchMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMoto.Location = new System.Drawing.Point(347, 596);
            this.btnSearchMoto.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchMoto.Name = "btnSearchMoto";
            this.btnSearchMoto.Size = new System.Drawing.Size(216, 70);
            this.btnSearchMoto.TabIndex = 4;
            this.btnSearchMoto.Text = "Search";
            this.btnSearchMoto.UseVisualStyleBackColor = true;
            this.btnSearchMoto.Click += new System.EventHandler(this.btnSearchMoto_Click);
            // 
            // btnDeleteMoto
            // 
            this.btnDeleteMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMoto.Location = new System.Drawing.Point(729, 596);
            this.btnDeleteMoto.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteMoto.Name = "btnDeleteMoto";
            this.btnDeleteMoto.Size = new System.Drawing.Size(219, 70);
            this.btnDeleteMoto.TabIndex = 5;
            this.btnDeleteMoto.Text = "Delete";
            this.btnDeleteMoto.UseVisualStyleBackColor = true;
            this.btnDeleteMoto.Click += new System.EventHandler(this.btnDeleteMoto_Click);
            // 
            // idTableColumn
            // 
            this.idTableColumn.DataPropertyName = "id";
            this.idTableColumn.HeaderText = "Id";
            this.idTableColumn.MinimumWidth = 6;
            this.idTableColumn.Name = "idTableColumn";
            this.idTableColumn.ReadOnly = true;
            this.idTableColumn.Width = 125;
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
            this.absTableColumn.Width = 125;
            // 
            // forktypeModelColumn
            // 
            this.forktypeModelColumn.DataPropertyName = "forkType";
            this.forktypeModelColumn.HeaderText = "Forktype";
            this.forktypeModelColumn.MinimumWidth = 6;
            this.forktypeModelColumn.Name = "forktypeModelColumn";
            this.forktypeModelColumn.ReadOnly = true;
            this.forktypeModelColumn.Width = 125;
            // 
            // helmetTableColumn
            // 
            this.helmetTableColumn.DataPropertyName = "helmetIncluded";
            this.helmetTableColumn.HeaderText = "Helmet Included";
            this.helmetTableColumn.MinimumWidth = 6;
            this.helmetTableColumn.Name = "helmetTableColumn";
            this.helmetTableColumn.ReadOnly = true;
            this.helmetTableColumn.Width = 125;
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
            // GUIDeleteMotorcycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 704);
            this.Controls.Add(this.btnDeleteMoto);
            this.Controls.Add(this.btnSearchMoto);
            this.Controls.Add(this.dataGridMoto);
            this.Controls.Add(this.txtIdMoto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GUIDeleteMotorcycle";
            this.Text = "Delete Motorcycle";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdMoto;
        private System.Windows.Forms.DataGridView dataGridMoto;
        private System.Windows.Forms.Button btnSearchMoto;
        private System.Windows.Forms.Button btnDeleteMoto;
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