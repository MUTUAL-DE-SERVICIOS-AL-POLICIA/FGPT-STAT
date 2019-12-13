namespace stat
{
    partial class Form1
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
						this.Generar = new System.Windows.Forms.Button();
						this.dataGridView1 = new System.Windows.Forms.DataGridView();
						((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
						this.SuspendLayout();
						// 
						// Generar
						// 
						this.Generar.Location = new System.Drawing.Point(41, 79);
						this.Generar.Margin = new System.Windows.Forms.Padding(2);
						this.Generar.Name = "Generar";
						this.Generar.Size = new System.Drawing.Size(56, 24);
						this.Generar.TabIndex = 0;
						this.Generar.Text = "Generar";
						this.Generar.UseVisualStyleBackColor = true;
						this.Generar.Click += new System.EventHandler(this.Button1_Click);
						// 
						// dataGridView1
						// 
						this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
						this.dataGridView1.Location = new System.Drawing.Point(41, 127);
						this.dataGridView1.Name = "dataGridView1";
						this.dataGridView1.Size = new System.Drawing.Size(1020, 317);
						this.dataGridView1.TabIndex = 1;
						// 
						// Form1
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.ClientSize = new System.Drawing.Size(1086, 456);
						this.Controls.Add(this.dataGridView1);
						this.Controls.Add(this.Generar);
						this.Margin = new System.Windows.Forms.Padding(2);
						this.Name = "Form1";
						this.Text = "Stat";
						this.Load += new System.EventHandler(this.Form1_Load);
						((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
						this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Generar;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}

