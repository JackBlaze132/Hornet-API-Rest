namespace PClienteEstudiante.view.automobile
{
    partial class GUISearchAutomobile
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
            this.comboBoxBodyAuto = new System.Windows.Forms.ComboBox();
            this.txtSnidAuto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.datePickerAuto = new System.Windows.Forms.DateTimePicker();
            this.boxABS = new System.Windows.Forms.CheckBox();
            this.btnSearchAutomobile = new System.Windows.Forms.Button();
            this.txtPriceAuto = new System.Windows.Forms.TextBox();
            this.txtBrandAuto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdAuto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxBodyAuto
            // 
            this.comboBoxBodyAuto.Enabled = false;
            this.comboBoxBodyAuto.FormattingEnabled = true;
            this.comboBoxBodyAuto.Location = new System.Drawing.Point(314, 265);
            this.comboBoxBodyAuto.Name = "comboBoxBodyAuto";
            this.comboBoxBodyAuto.Size = new System.Drawing.Size(172, 21);
            this.comboBoxBodyAuto.TabIndex = 52;
            // 
            // txtSnidAuto
            // 
            this.txtSnidAuto.Location = new System.Drawing.Point(314, 108);
            this.txtSnidAuto.Name = "txtSnidAuto";
            this.txtSnidAuto.Size = new System.Drawing.Size(376, 20);
            this.txtSnidAuto.TabIndex = 51;
            this.txtSnidAuto.TextChanged += new System.EventHandler(this.txtSnidAuto_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(111, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 50;
            this.label9.Text = "Arrival Date";
            // 
            // datePickerAuto
            // 
            this.datePickerAuto.CustomFormat = " ";
            this.datePickerAuto.Enabled = false;
            this.datePickerAuto.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerAuto.Location = new System.Drawing.Point(314, 306);
            this.datePickerAuto.Name = "datePickerAuto";
            this.datePickerAuto.Size = new System.Drawing.Size(200, 20);
            this.datePickerAuto.TabIndex = 49;
            this.datePickerAuto.ValueChanged += new System.EventHandler(this.datePickerAuto_ValueChanged);
            // 
            // boxABS
            // 
            this.boxABS.AutoSize = true;
            this.boxABS.Enabled = false;
            this.boxABS.Location = new System.Drawing.Point(314, 226);
            this.boxABS.Name = "boxABS";
            this.boxABS.Size = new System.Drawing.Size(15, 14);
            this.boxABS.TabIndex = 48;
            this.boxABS.UseVisualStyleBackColor = true;
            // 
            // btnSearchAutomobile
            // 
            this.btnSearchAutomobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAutomobile.Location = new System.Drawing.Point(302, 397);
            this.btnSearchAutomobile.Name = "btnSearchAutomobile";
            this.btnSearchAutomobile.Size = new System.Drawing.Size(154, 53);
            this.btnSearchAutomobile.TabIndex = 47;
            this.btnSearchAutomobile.Text = "Search";
            this.btnSearchAutomobile.UseVisualStyleBackColor = true;
            this.btnSearchAutomobile.Click += new System.EventHandler(this.btnSearchAutomobile_Click);
            // 
            // txtPriceAuto
            // 
            this.txtPriceAuto.Location = new System.Drawing.Point(314, 194);
            this.txtPriceAuto.Name = "txtPriceAuto";
            this.txtPriceAuto.ReadOnly = true;
            this.txtPriceAuto.Size = new System.Drawing.Size(376, 20);
            this.txtPriceAuto.TabIndex = 46;
            // 
            // txtBrandAuto
            // 
            this.txtBrandAuto.Location = new System.Drawing.Point(314, 154);
            this.txtBrandAuto.Name = "txtBrandAuto";
            this.txtBrandAuto.ReadOnly = true;
            this.txtBrandAuto.Size = new System.Drawing.Size(376, 20);
            this.txtBrandAuto.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(111, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 44;
            this.label7.Text = "Bodywork:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(111, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 16);
            this.label6.TabIndex = 43;
            this.label6.Text = "Does it have ABS?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(111, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "SNID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Brand:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Id Auto:";
            // 
            // txtIdAuto
            // 
            this.txtIdAuto.Location = new System.Drawing.Point(314, 68);
            this.txtIdAuto.Name = "txtIdAuto";
            this.txtIdAuto.Size = new System.Drawing.Size(376, 20);
            this.txtIdAuto.TabIndex = 38;
            this.txtIdAuto.TextChanged += new System.EventHandler(this.txtIdAuto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "Search Automobile";
            // 
            // GUISearchAutomobile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 496);
            this.Controls.Add(this.comboBoxBodyAuto);
            this.Controls.Add(this.txtSnidAuto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.datePickerAuto);
            this.Controls.Add(this.boxABS);
            this.Controls.Add(this.btnSearchAutomobile);
            this.Controls.Add(this.txtPriceAuto);
            this.Controls.Add(this.txtBrandAuto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdAuto);
            this.Controls.Add(this.label1);
            this.Name = "GUISearchAutomobile";
            this.Text = "Search Automobile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxBodyAuto;
        private System.Windows.Forms.TextBox txtSnidAuto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker datePickerAuto;
        private System.Windows.Forms.CheckBox boxABS;
        private System.Windows.Forms.Button btnSearchAutomobile;
        private System.Windows.Forms.TextBox txtPriceAuto;
        private System.Windows.Forms.TextBox txtBrandAuto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdAuto;
        private System.Windows.Forms.Label label1;
    }
}