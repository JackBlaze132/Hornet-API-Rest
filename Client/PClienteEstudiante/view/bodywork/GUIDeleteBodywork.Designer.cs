namespace PClienteEstudiante.view.bodywork
{
    partial class GUIDeleteBodywork
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
            this.btnDeleteBody = new System.Windows.Forms.Button();
            this.txtNameBody = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdBody = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchBody = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDeleteBody
            // 
            this.btnDeleteBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBody.Location = new System.Drawing.Point(442, 308);
            this.btnDeleteBody.Name = "btnDeleteBody";
            this.btnDeleteBody.Size = new System.Drawing.Size(154, 53);
            this.btnDeleteBody.TabIndex = 24;
            this.btnDeleteBody.Text = "Delete";
            this.btnDeleteBody.UseVisualStyleBackColor = true;
            this.btnDeleteBody.Click += new System.EventHandler(this.btnDeleteBody_Click);
            // 
            // txtNameBody
            // 
            this.txtNameBody.Location = new System.Drawing.Point(314, 185);
            this.txtNameBody.Name = "txtNameBody";
            this.txtNameBody.ReadOnly = true;
            this.txtNameBody.Size = new System.Drawing.Size(376, 20);
            this.txtNameBody.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Id Bodywork:";
            // 
            // txtIdBody
            // 
            this.txtIdBody.Location = new System.Drawing.Point(314, 142);
            this.txtIdBody.Name = "txtIdBody";
            this.txtIdBody.Size = new System.Drawing.Size(376, 20);
            this.txtIdBody.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Delete Bodywork";
            // 
            // btnSearchBody
            // 
            this.btnSearchBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBody.Location = new System.Drawing.Point(216, 306);
            this.btnSearchBody.Name = "btnSearchBody";
            this.btnSearchBody.Size = new System.Drawing.Size(162, 57);
            this.btnSearchBody.TabIndex = 25;
            this.btnSearchBody.Text = "Search";
            this.btnSearchBody.UseVisualStyleBackColor = true;
            this.btnSearchBody.Click += new System.EventHandler(this.btnSearchBody_Click);
            // 
            // GUIDeleteBodywork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearchBody);
            this.Controls.Add(this.btnDeleteBody);
            this.Controls.Add(this.txtNameBody);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdBody);
            this.Controls.Add(this.label1);
            this.Name = "GUIDeleteBodywork";
            this.Text = "Delete Bodywork";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteBody;
        private System.Windows.Forms.TextBox txtNameBody;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchBody;
    }
}