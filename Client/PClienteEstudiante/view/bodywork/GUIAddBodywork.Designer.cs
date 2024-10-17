namespace PClienteEstudiante.view.bodywork
{
    partial class GUIAddBodywork
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
            this.btnAddBody = new System.Windows.Forms.Button();
            this.txtNameBody = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdBody = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxSunroof = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddBody
            // 
            this.btnAddBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBody.Location = new System.Drawing.Point(340, 321);
            this.btnAddBody.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddBody.Name = "btnAddBody";
            this.btnAddBody.Size = new System.Drawing.Size(205, 65);
            this.btnAddBody.TabIndex = 18;
            this.btnAddBody.Text = "Add";
            this.btnAddBody.UseVisualStyleBackColor = true;
            this.btnAddBody.Click += new System.EventHandler(this.btnAddMoto_Click);
            // 
            // txtNameBody
            // 
            this.txtNameBody.Location = new System.Drawing.Point(340, 153);
            this.txtNameBody.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNameBody.Name = "txtNameBody";
            this.txtNameBody.Size = new System.Drawing.Size(500, 22);
            this.txtNameBody.TabIndex = 17;
            this.txtNameBody.TextChanged += new System.EventHandler(this.txtNameBody_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Id Bodywork:";
            // 
            // txtIdBody
            // 
            this.txtIdBody.Location = new System.Drawing.Point(340, 100);
            this.txtIdBody.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdBody.Name = "txtIdBody";
            this.txtIdBody.Size = new System.Drawing.Size(500, 22);
            this.txtIdBody.TabIndex = 14;
            this.txtIdBody.TextChanged += new System.EventHandler(this.txtIdBody_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Add Bodywork";
            // 
            // boxSunroof
            // 
            this.boxSunroof.AutoSize = true;
            this.boxSunroof.Location = new System.Drawing.Point(339, 205);
            this.boxSunroof.Margin = new System.Windows.Forms.Padding(4);
            this.boxSunroof.Name = "boxSunroof";
            this.boxSunroof.Size = new System.Drawing.Size(18, 17);
            this.boxSunroof.TabIndex = 20;
            this.boxSunroof.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(69, 207);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Does it have a Sunroof?";
            // 
            // GUIAddBodywork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 423);
            this.Controls.Add(this.boxSunroof);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAddBody);
            this.Controls.Add(this.txtNameBody);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdBody);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GUIAddBodywork";
            this.Text = "Add Bodywork";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddBody;
        private System.Windows.Forms.TextBox txtNameBody;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox boxSunroof;
        private System.Windows.Forms.Label label6;
    }
}