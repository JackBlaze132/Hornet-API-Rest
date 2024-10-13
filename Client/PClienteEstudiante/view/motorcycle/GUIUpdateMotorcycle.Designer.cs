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
            this.txtModelMotorcycle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.datePickerMotorcycle = new System.Windows.Forms.DateTimePicker();
            this.boxHelmet = new System.Windows.Forms.CheckBox();
            this.boxABS = new System.Windows.Forms.CheckBox();
            this.btnUpdateMoto = new System.Windows.Forms.Button();
            this.txtFroktype = new System.Windows.Forms.TextBox();
            this.txtPriceMoto = new System.Windows.Forms.TextBox();
            this.txtBrandMoto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdMoto = new System.Windows.Forms.TextBox();
            this.btnSearchMoto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Motorcycle";
            // 
            // txtModelMotorcycle
            // 
            this.txtModelMotorcycle.Location = new System.Drawing.Point(326, 199);
            this.txtModelMotorcycle.Name = "txtModelMotorcycle";
            this.txtModelMotorcycle.ReadOnly = true;
            this.txtModelMotorcycle.Size = new System.Drawing.Size(376, 20);
            this.txtModelMotorcycle.TabIndex = 34;
            this.txtModelMotorcycle.TextChanged += new System.EventHandler(this.txtModelMotorcycle_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(123, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "Arrival Date";
            // 
            // datePickerMotorcycle
            // 
            this.datePickerMotorcycle.Enabled = false;
            this.datePickerMotorcycle.Location = new System.Drawing.Point(326, 359);
            this.datePickerMotorcycle.Name = "datePickerMotorcycle";
            this.datePickerMotorcycle.Size = new System.Drawing.Size(200, 20);
            this.datePickerMotorcycle.TabIndex = 32;
            this.datePickerMotorcycle.ValueChanged += new System.EventHandler(this.datePickerMotorcycle_ValueChanged);
            // 
            // boxHelmet
            // 
            this.boxHelmet.AutoSize = true;
            this.boxHelmet.Enabled = false;
            this.boxHelmet.Location = new System.Drawing.Point(326, 320);
            this.boxHelmet.Name = "boxHelmet";
            this.boxHelmet.Size = new System.Drawing.Size(15, 14);
            this.boxHelmet.TabIndex = 31;
            this.boxHelmet.UseVisualStyleBackColor = true;
            this.boxHelmet.CheckedChanged += new System.EventHandler(this.boxHelmet_CheckedChanged);
            // 
            // boxABS
            // 
            this.boxABS.AutoSize = true;
            this.boxABS.Enabled = false;
            this.boxABS.Location = new System.Drawing.Point(326, 238);
            this.boxABS.Name = "boxABS";
            this.boxABS.Size = new System.Drawing.Size(15, 14);
            this.boxABS.TabIndex = 30;
            this.boxABS.UseVisualStyleBackColor = true;
            this.boxABS.CheckedChanged += new System.EventHandler(this.boxABS_CheckedChanged);
            // 
            // btnUpdateMoto
            // 
            this.btnUpdateMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMoto.Location = new System.Drawing.Point(522, 426);
            this.btnUpdateMoto.Name = "btnUpdateMoto";
            this.btnUpdateMoto.Size = new System.Drawing.Size(154, 53);
            this.btnUpdateMoto.TabIndex = 29;
            this.btnUpdateMoto.Text = "Update";
            this.btnUpdateMoto.UseVisualStyleBackColor = true;
            this.btnUpdateMoto.Click += new System.EventHandler(this.btnSaveMoto_Click);
            // 
            // txtFroktype
            // 
            this.txtFroktype.Location = new System.Drawing.Point(326, 278);
            this.txtFroktype.Name = "txtFroktype";
            this.txtFroktype.ReadOnly = true;
            this.txtFroktype.Size = new System.Drawing.Size(376, 20);
            this.txtFroktype.TabIndex = 28;
            this.txtFroktype.TextChanged += new System.EventHandler(this.txtFroktype_TextChanged);
            // 
            // txtPriceMoto
            // 
            this.txtPriceMoto.Location = new System.Drawing.Point(326, 163);
            this.txtPriceMoto.Name = "txtPriceMoto";
            this.txtPriceMoto.ReadOnly = true;
            this.txtPriceMoto.Size = new System.Drawing.Size(376, 20);
            this.txtPriceMoto.TabIndex = 27;
            this.txtPriceMoto.TextChanged += new System.EventHandler(this.txtPriceMoto_TextChanged);
            // 
            // txtBrandMoto
            // 
            this.txtBrandMoto.Location = new System.Drawing.Point(326, 123);
            this.txtBrandMoto.Name = "txtBrandMoto";
            this.txtBrandMoto.ReadOnly = true;
            this.txtBrandMoto.Size = new System.Drawing.Size(376, 20);
            this.txtBrandMoto.TabIndex = 26;
            this.txtBrandMoto.TextChanged += new System.EventHandler(this.txtBrandMoto_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(123, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Does it include a helmet?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(123, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "ForkType:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(123, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Does it have ABS?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(123, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "SNID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Brand:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Id Moto:";
            // 
            // txtIdMoto
            // 
            this.txtIdMoto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtIdMoto.Cursor = System.Windows.Forms.Cursors.No;
            this.txtIdMoto.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtIdMoto.Location = new System.Drawing.Point(326, 80);
            this.txtIdMoto.Name = "txtIdMoto";
            this.txtIdMoto.Size = new System.Drawing.Size(376, 20);
            this.txtIdMoto.TabIndex = 18;
            this.txtIdMoto.TextChanged += new System.EventHandler(this.txtIdMoto_TextChanged);
            // 
            // btnSearchMoto
            // 
            this.btnSearchMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMoto.Location = new System.Drawing.Point(179, 422);
            this.btnSearchMoto.Name = "btnSearchMoto";
            this.btnSearchMoto.Size = new System.Drawing.Size(162, 57);
            this.btnSearchMoto.TabIndex = 35;
            this.btnSearchMoto.Text = "Search";
            this.btnSearchMoto.UseVisualStyleBackColor = true;
            this.btnSearchMoto.Click += new System.EventHandler(this.btnSearchMoto_Click);
            // 
            // GUIUpdateMotorcycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 542);
            this.Controls.Add(this.btnSearchMoto);
            this.Controls.Add(this.txtModelMotorcycle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.datePickerMotorcycle);
            this.Controls.Add(this.boxHelmet);
            this.Controls.Add(this.boxABS);
            this.Controls.Add(this.btnUpdateMoto);
            this.Controls.Add(this.txtFroktype);
            this.Controls.Add(this.txtPriceMoto);
            this.Controls.Add(this.txtBrandMoto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdMoto);
            this.Controls.Add(this.label1);
            this.Name = "GUIUpdateMotorcycle";
            this.Text = "Update Motorcycle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModelMotorcycle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker datePickerMotorcycle;
        private System.Windows.Forms.CheckBox boxHelmet;
        private System.Windows.Forms.CheckBox boxABS;
        private System.Windows.Forms.Button btnUpdateMoto;
        private System.Windows.Forms.TextBox txtFroktype;
        private System.Windows.Forms.TextBox txtPriceMoto;
        private System.Windows.Forms.TextBox txtBrandMoto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdMoto;
        private System.Windows.Forms.Button btnSearchMoto;
    }
}