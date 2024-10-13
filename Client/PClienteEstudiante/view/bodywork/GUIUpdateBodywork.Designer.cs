namespace PClienteEstudiante.view.bodywork
{
    partial class GUIUpdateBodywork
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
            this.btnSearchBody = new System.Windows.Forms.Button();
            this.btnUpdateBody = new System.Windows.Forms.Button();
            this.txtNameBody = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdBody = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearchBody
            // 
            this.btnSearchBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBody.Location = new System.Drawing.Point(216, 312);
            this.btnSearchBody.Name = "btnSearchBody";
            this.btnSearchBody.Size = new System.Drawing.Size(162, 57);
            this.btnSearchBody.TabIndex = 32;
            this.btnSearchBody.Text = "Search";
            this.btnSearchBody.UseVisualStyleBackColor = true;
            this.btnSearchBody.Click += new System.EventHandler(this.btnSearchBody_Click);
            // 
            // btnUpdateBody
            // 
            this.btnUpdateBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBody.Location = new System.Drawing.Point(442, 314);
            this.btnUpdateBody.Name = "btnUpdateBody";
            this.btnUpdateBody.Size = new System.Drawing.Size(154, 53);
            this.btnUpdateBody.TabIndex = 31;
            this.btnUpdateBody.Text = "Update";
            this.btnUpdateBody.UseVisualStyleBackColor = true;
            this.btnUpdateBody.Click += new System.EventHandler(this.btnUpdateBody_Click);
            // 
            // txtNameBody
            // 
            this.txtNameBody.Location = new System.Drawing.Point(314, 191);
            this.txtNameBody.Name = "txtNameBody";
            this.txtNameBody.ReadOnly = true;
            this.txtNameBody.Size = new System.Drawing.Size(376, 20);
            this.txtNameBody.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Id Bodywork:";
            // 
            // txtIdBody
            // 
            this.txtIdBody.Location = new System.Drawing.Point(314, 148);
            this.txtIdBody.Name = "txtIdBody";
            this.txtIdBody.Size = new System.Drawing.Size(376, 20);
            this.txtIdBody.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Update Bodywork";
            // 
            // GUIUpdateBodywork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearchBody);
            this.Controls.Add(this.btnUpdateBody);
            this.Controls.Add(this.txtNameBody);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdBody);
            this.Controls.Add(this.label1);
            this.Name = "GUIUpdateBodywork";
            this.Text = "GUIEditBodywork";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchBody;
        private System.Windows.Forms.Button btnUpdateBody;
        private System.Windows.Forms.TextBox txtNameBody;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdBody;
        private System.Windows.Forms.Label label1;
    }
}