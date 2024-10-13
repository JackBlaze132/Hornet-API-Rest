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
            this.SuspendLayout();
            // 
            // btnAddBody
            // 
            this.btnAddBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBody.Location = new System.Drawing.Point(255, 261);
            this.btnAddBody.Name = "btnAddBody";
            this.btnAddBody.Size = new System.Drawing.Size(154, 53);
            this.btnAddBody.TabIndex = 18;
            this.btnAddBody.Text = "Add";
            this.btnAddBody.UseVisualStyleBackColor = true;
            this.btnAddBody.Click += new System.EventHandler(this.btnAddMoto_Click);
            // 
            // txtNameBody
            // 
            this.txtNameBody.Location = new System.Drawing.Point(255, 124);
            this.txtNameBody.Name = "txtNameBody";
            this.txtNameBody.Size = new System.Drawing.Size(376, 20);
            this.txtNameBody.TabIndex = 17;
            this.txtNameBody.TextChanged += new System.EventHandler(this.txtNameBody_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Id Bodywork:";
            // 
            // txtIdBody
            // 
            this.txtIdBody.Location = new System.Drawing.Point(255, 81);
            this.txtIdBody.Name = "txtIdBody";
            this.txtIdBody.Size = new System.Drawing.Size(376, 20);
            this.txtIdBody.TabIndex = 14;
            this.txtIdBody.TextChanged += new System.EventHandler(this.txtIdBody_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Add Bodywork";
            // 
            // GUIAddBodywork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 344);
            this.Controls.Add(this.btnAddBody);
            this.Controls.Add(this.txtNameBody);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdBody);
            this.Controls.Add(this.label1);
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
    }
}