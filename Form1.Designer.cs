namespace Fufrus_Simulator
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.btn1 = new System.Windows.Forms.Button();
			this.txtNull = new System.Windows.Forms.TextBox();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.Ações = new System.Windows.Forms.TabPage();
			this.btn3 = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCoin1 = new System.Windows.Forms.Label();
			this.progressBar3 = new System.Windows.Forms.ProgressBar();
			this.progressBar2 = new System.Windows.Forms.ProgressBar();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.txtTitulo = new System.Windows.Forms.Label();
			this.txtMoney = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.tabControl.SuspendLayout();
			this.Ações.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn1
			// 
			this.btn1.Location = new System.Drawing.Point(28, 29);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(153, 46);
			this.btn1.TabIndex = 0;
			this.btn1.Text = "Faltar da Caminhada";
			this.btn1.UseCompatibleTextRendering = true;
			this.btn1.UseVisualStyleBackColor = true;
			this.btn1.Click += new System.EventHandler(this.btn1_Click_1);
			// 
			// txtNull
			// 
			this.txtNull.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.txtNull.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.txtNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNull.ForeColor = System.Drawing.Color.White;
			this.txtNull.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txtNull.Location = new System.Drawing.Point(12, 137);
			this.txtNull.Name = "txtNull";
			this.txtNull.Size = new System.Drawing.Size(875, 62);
			this.txtNull.TabIndex = 1;
			this.txtNull.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.Ações);
			this.tabControl.Controls.Add(this.tabPage2);
			this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl.Location = new System.Drawing.Point(12, 205);
			this.tabControl.MaximumSize = new System.Drawing.Size(875, 492);
			this.tabControl.MinimumSize = new System.Drawing.Size(875, 492);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(875, 492);
			this.tabControl.TabIndex = 2;
			this.tabControl.Tag = "";
			// 
			// Ações
			// 
			this.Ações.Controls.Add(this.btn3);
			this.Ações.Controls.Add(this.btn2);
			this.Ações.Controls.Add(this.label1);
			this.Ações.Controls.Add(this.txtCoin1);
			this.Ações.Controls.Add(this.progressBar3);
			this.Ações.Controls.Add(this.progressBar2);
			this.Ações.Controls.Add(this.progressBar1);
			this.Ações.Controls.Add(this.btn1);
			this.Ações.Location = new System.Drawing.Point(4, 33);
			this.Ações.Name = "Ações";
			this.Ações.Padding = new System.Windows.Forms.Padding(3);
			this.Ações.Size = new System.Drawing.Size(867, 455);
			this.Ações.TabIndex = 0;
			this.Ações.Text = "Ações";
			this.Ações.UseVisualStyleBackColor = true;
			// 
			// btn3
			// 
			this.btn3.Location = new System.Drawing.Point(28, 235);
			this.btn3.Name = "btn3";
			this.btn3.Size = new System.Drawing.Size(153, 46);
			this.btn3.TabIndex = 3;
			this.btn3.Text = "Roubar Beijos";
			this.btn3.UseVisualStyleBackColor = true;
			this.btn3.Click += new System.EventHandler(this.btn3_Click);
			// 
			// btn2
			// 
			this.btn2.Location = new System.Drawing.Point(28, 124);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(153, 46);
			this.btn2.TabIndex = 3;
			this.btn2.Text = "Roubar Beijos";
			this.btn2.UseVisualStyleBackColor = true;
			this.btn2.Click += new System.EventHandler(this.btn2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(765, 135);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "10$";
			// 
			// txtCoin1
			// 
			this.txtCoin1.AutoSize = true;
			this.txtCoin1.Location = new System.Drawing.Point(765, 40);
			this.txtCoin1.Name = "txtCoin1";
			this.txtCoin1.Size = new System.Drawing.Size(43, 24);
			this.txtCoin1.TabIndex = 2;
			this.txtCoin1.Text = "10$";
			// 
			// progressBar3
			// 
			this.progressBar3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.progressBar3.Location = new System.Drawing.Point(229, 235);
			this.progressBar3.Name = "progressBar3";
			this.progressBar3.Size = new System.Drawing.Size(494, 46);
			this.progressBar3.Step = 1;
			this.progressBar3.TabIndex = 1;
			// 
			// progressBar2
			// 
			this.progressBar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.progressBar2.Location = new System.Drawing.Point(229, 124);
			this.progressBar2.Name = "progressBar2";
			this.progressBar2.Size = new System.Drawing.Size(494, 46);
			this.progressBar2.Step = 1;
			this.progressBar2.TabIndex = 1;
			// 
			// progressBar1
			// 
			this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.progressBar1.Location = new System.Drawing.Point(229, 29);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(494, 46);
			this.progressBar1.Step = 1;
			this.progressBar1.TabIndex = 1;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 33);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(867, 455);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Lojinha";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// txtTitulo
			// 
			this.txtTitulo.AutoSize = true;
			this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTitulo.Location = new System.Drawing.Point(249, 52);
			this.txtTitulo.Name = "txtTitulo";
			this.txtTitulo.Size = new System.Drawing.Size(401, 55);
			this.txtTitulo.TabIndex = 3;
			this.txtTitulo.Text = "Frufus Simulator!!";
			this.txtTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtMoney
			// 
			this.txtMoney.AutoSize = true;
			this.txtMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.txtMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMoney.ForeColor = System.Drawing.Color.White;
			this.txtMoney.Location = new System.Drawing.Point(423, 140);
			this.txtMoney.Name = "txtMoney";
			this.txtMoney.Size = new System.Drawing.Size(52, 55);
			this.txtMoney.TabIndex = 4;
			this.txtMoney.Text = "$";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(899, 709);
			this.Controls.Add(this.txtMoney);
			this.Controls.Add(this.txtTitulo);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.txtNull);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(915, 748);
			this.MinimumSize = new System.Drawing.Size(915, 748);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl.ResumeLayout(false);
			this.Ações.ResumeLayout(false);
			this.Ações.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.TextBox txtNull;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage Ações;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label txtTitulo;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label txtCoin1;
		private System.Windows.Forms.Label txtMoney;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ProgressBar progressBar2;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.ProgressBar progressBar3;
	}
}

