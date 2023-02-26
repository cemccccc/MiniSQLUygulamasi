namespace SQLUygulamasi
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.BtnCalistir = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.BtnSql = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 23);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(681, 183);
			this.dataGridView1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataGridView1);
			this.groupBox1.Location = new System.Drawing.Point(16, 264);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(687, 209);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Sorgu Sonucu";
			// 
			// BtnCalistir
			// 
			this.BtnCalistir.Location = new System.Drawing.Point(533, 36);
			this.BtnCalistir.Name = "BtnCalistir";
			this.BtnCalistir.Size = new System.Drawing.Size(170, 99);
			this.BtnCalistir.TabIndex = 2;
			this.BtnCalistir.Text = "Çalıştır";
			this.BtnCalistir.UseVisualStyleBackColor = true;
			this.BtnCalistir.Click += new System.EventHandler(this.BtnCalistir_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.Location = new System.Drawing.Point(3, 23);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(508, 219);
			this.richTextBox1.TabIndex = 3;
			this.richTextBox1.Text = "";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.richTextBox1);
			this.groupBox2.Location = new System.Drawing.Point(13, 13);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(514, 245);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Sorgu Alanı";
			// 
			// BtnSql
			// 
			this.BtnSql.Location = new System.Drawing.Point(533, 159);
			this.BtnSql.Name = "BtnSql";
			this.BtnSql.Size = new System.Drawing.Size(170, 99);
			this.BtnSql.TabIndex = 2;
			this.BtnSql.Text = "Ekle-Sil-Güncelle";
			this.BtnSql.UseVisualStyleBackColor = true;
			this.BtnSql.Click += new System.EventHandler(this.BtnSql_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(715, 473);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.BtnSql);
			this.Controls.Add(this.BtnCalistir);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "SQL";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button BtnCalistir;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button BtnSql;
	}
}

