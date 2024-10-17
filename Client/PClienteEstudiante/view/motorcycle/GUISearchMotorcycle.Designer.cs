namespace PClienteEstudiante.view.motorcycle
{
    partial class GUISearchMotorcycle
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
            this.btnSearchMoto = new System.Windows.Forms.Button();
            this.txtIdMoto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSnid = new System.Windows.Forms.TextBox();
            this.txtPriceMoto = new System.Windows.Forms.TextBox();
            this.txtBrandMoto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.datePickerMotorcycle = new System.Windows.Forms.DateTimePicker();
            this.boxHelmet = new System.Windows.Forms.CheckBox();
            this.boxABS = new System.Windows.Forms.CheckBox();
            this.txtFroktype = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Motorcycle";
            // 
            // btnSearchMoto
            // 
            this.btnSearchMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMoto.Location = new System.Drawing.Point(567, 442);
            this.btnSearchMoto.Name = "btnSearchMoto";
            this.btnSearchMoto.Size = new System.Drawing.Size(130, 40);
            this.btnSearchMoto.TabIndex = 15;
            this.btnSearchMoto.Text = "Search";
            this.btnSearchMoto.UseVisualStyleBackColor = true;
            this.btnSearchMoto.Click += new System.EventHandler(this.btnSearchMoto_Click);
            // 
            // txtIdMoto
            // 
            this.txtIdMoto.Location = new System.Drawing.Point(438, 76);
            this.txtIdMoto.Name = "txtIdMoto";
            this.txtIdMoto.Size = new System.Drawing.Size(375, 20);
            this.txtIdMoto.TabIndex = 12;
            this.txtIdMoto.TextChanged += new System.EventHandler(this.txtIdMoto_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Id Moto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(226, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "SNID:";
            // 
            // txtSnid
            // 
            this.txtSnid.Location = new System.Drawing.Point(438, 111);
            this.txtSnid.Name = "txtSnid";
            this.txtSnid.Size = new System.Drawing.Size(375, 20);
            this.txtSnid.TabIndex = 17;
            this.txtSnid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPriceMoto
            // 
            this.txtPriceMoto.Location = new System.Drawing.Point(429, 196);
            this.txtPriceMoto.Name = "txtPriceMoto";
            this.txtPriceMoto.ReadOnly = true;
            this.txtPriceMoto.Size = new System.Drawing.Size(376, 20);
            this.txtPriceMoto.TabIndex = 31;
            // 
            // txtBrandMoto
            // 
            this.txtBrandMoto.Location = new System.Drawing.Point(429, 156);
            this.txtBrandMoto.Name = "txtBrandMoto";
            this.txtBrandMoto.ReadOnly = true;
            this.txtBrandMoto.Size = new System.Drawing.Size(376, 20);
            this.txtBrandMoto.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(226, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(226, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Brand:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(226, 373);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 41;
            this.label9.Text = "Arrival Date";
            // 
            // datePickerMotorcycle
            // 
            this.datePickerMotorcycle.Enabled = false;
            this.datePickerMotorcycle.Location = new System.Drawing.Point(429, 369);
            this.datePickerMotorcycle.Name = "datePickerMotorcycle";
            this.datePickerMotorcycle.Size = new System.Drawing.Size(200, 20);
            this.datePickerMotorcycle.TabIndex = 40;
            // 
            // boxHelmet
            // 
            this.boxHelmet.AutoSize = true;
            this.boxHelmet.Enabled = false;
            this.boxHelmet.Location = new System.Drawing.Point(429, 330);
            this.boxHelmet.Name = "boxHelmet";
            this.boxHelmet.Size = new System.Drawing.Size(15, 14);
            this.boxHelmet.TabIndex = 39;
            this.boxHelmet.UseVisualStyleBackColor = true;
            // 
            // boxABS
            // 
            this.boxABS.AutoSize = true;
            this.boxABS.Enabled = false;
            this.boxABS.Location = new System.Drawing.Point(429, 248);
            this.boxABS.Name = "boxABS";
            this.boxABS.Size = new System.Drawing.Size(15, 14);
            this.boxABS.TabIndex = 38;
            this.boxABS.UseVisualStyleBackColor = true;
            // 
            // txtFroktype
            // 
            this.txtFroktype.Location = new System.Drawing.Point(429, 288);
            this.txtFroktype.Name = "txtFroktype";
            this.txtFroktype.ReadOnly = true;
            this.txtFroktype.Size = new System.Drawing.Size(376, 20);
            this.txtFroktype.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(226, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 16);
            this.label8.TabIndex = 36;
            this.label8.Text = "Does it include a helmet?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(226, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "ForkType:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(226, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Does it have ABS?";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(312, 442);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 40);
            this.btnClear.TabIndex = 54;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // GUISearchMotorcycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 520);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.datePickerMotorcycle);
            this.Controls.Add(this.boxHelmet);
            this.Controls.Add(this.boxABS);
            this.Controls.Add(this.txtFroktype);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPriceMoto);
            this.Controls.Add(this.txtBrandMoto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSnid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearchMoto);
            this.Controls.Add(this.txtIdMoto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GUISearchMotorcycle";
            this.Text = "Search Motorcycle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchMoto;
        private System.Windows.Forms.TextBox txtIdMoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSnid;
        private System.Windows.Forms.TextBox txtPriceMoto;
        private System.Windows.Forms.TextBox txtBrandMoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker datePickerMotorcycle;
        private System.Windows.Forms.CheckBox boxHelmet;
        private System.Windows.Forms.CheckBox boxABS;
        private System.Windows.Forms.TextBox txtFroktype;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
    }
}