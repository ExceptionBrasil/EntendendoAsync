namespace EntendendooAsync
{
    partial class frm1
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
            this.btnGetData = new System.Windows.Forms.Button();
            this.tBox1 = new System.Windows.Forms.TextBox();
            this.btnAsync = new System.Windows.Forms.Button();
            this.btnParalelo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetData
            // 
            this.btnGetData.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGetData.Font = new System.Drawing.Font("Accidental Presidency", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGetData.Location = new System.Drawing.Point(576, 12);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(212, 40);
            this.btnGetData.TabIndex = 0;
            this.btnGetData.Text = "Processamento Síncrono";
            this.btnGetData.UseVisualStyleBackColor = false;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // tBox1
            // 
            this.tBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.tBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox1.Location = new System.Drawing.Point(12, 66);
            this.tBox1.Margin = new System.Windows.Forms.Padding(3, 10, 10, 3);
            this.tBox1.Multiline = true;
            this.tBox1.Name = "tBox1";
            this.tBox1.Size = new System.Drawing.Size(776, 343);
            this.tBox1.TabIndex = 2;
            // 
            // btnAsync
            // 
            this.btnAsync.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAsync.Font = new System.Drawing.Font("Accidental Presidency", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsync.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAsync.Location = new System.Drawing.Point(285, 12);
            this.btnAsync.Name = "btnAsync";
            this.btnAsync.Size = new System.Drawing.Size(216, 40);
            this.btnAsync.TabIndex = 4;
            this.btnAsync.Text = "Processamento Asíncrono";
            this.btnAsync.UseVisualStyleBackColor = false;
            this.btnAsync.Click += new System.EventHandler(this.btn_clickAsync);
            // 
            // btnParalelo
            // 
            this.btnParalelo.BackColor = System.Drawing.Color.DeepPink;
            this.btnParalelo.Font = new System.Drawing.Font("Accidental Presidency", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParalelo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnParalelo.Location = new System.Drawing.Point(12, 12);
            this.btnParalelo.Name = "btnParalelo";
            this.btnParalelo.Size = new System.Drawing.Size(195, 40);
            this.btnParalelo.TabIndex = 5;
            this.btnParalelo.Text = "Processamento Paralelo";
            this.btnParalelo.UseVisualStyleBackColor = false;
            this.btnParalelo.Click += new System.EventHandler(this.btn_click_Paralelo);
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnParalelo);
            this.Controls.Add(this.btnAsync);
            this.Controls.Add(this.tBox1);
            this.Controls.Add(this.btnGetData);
            this.Name = "frm1";
            this.Text = "Entendendo o Async";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.TextBox tBox1;
        private System.Windows.Forms.Button btnAsync;
        private System.Windows.Forms.Button btnParalelo;
    }
}

