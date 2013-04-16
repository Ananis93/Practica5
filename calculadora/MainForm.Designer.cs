/*
 * Created by SharpDevelop.
 * User: user
 * Date: 16/04/2013
 * Time: 09:13 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace calculadora
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.num1 = new System.Windows.Forms.MaskedTextBox();
			this.num2 = new System.Windows.Forms.MaskedTextBox();
			this.resultado = new System.Windows.Forms.MaskedTextBox();
			this.sumar = new System.Windows.Forms.Button();
			this.restar = new System.Windows.Forms.Button();
			this.multiplicar = new System.Windows.Forms.Button();
			this.dividir = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(33, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "Número 1";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(33, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 32);
			this.label2.TabIndex = 1;
			this.label2.Text = "Número 2";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(33, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "Resultado";
			// 
			// num1
			// 
			this.num1.Location = new System.Drawing.Point(95, 31);
			this.num1.Name = "num1";
			this.num1.Size = new System.Drawing.Size(115, 20);
			this.num1.TabIndex = 3;
			this.num1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Num1MaskInputRejected);
			// 
			// num2
			// 
			this.num2.Location = new System.Drawing.Point(95, 64);
			this.num2.Name = "num2";
			this.num2.Size = new System.Drawing.Size(115, 20);
			this.num2.TabIndex = 4;
			// 
			// resultado
			// 
			this.resultado.Enabled = false;
			this.resultado.Location = new System.Drawing.Point(95, 96);
			this.resultado.Name = "resultado";
			this.resultado.Size = new System.Drawing.Size(115, 20);
			this.resultado.TabIndex = 5;
			// 
			// sumar
			// 
			this.sumar.Location = new System.Drawing.Point(12, 169);
			this.sumar.Name = "sumar";
			this.sumar.Size = new System.Drawing.Size(72, 30);
			this.sumar.TabIndex = 6;
			this.sumar.Text = "Sumar";
			this.sumar.UseVisualStyleBackColor = true;
			this.sumar.Click += new System.EventHandler(this.SumarClick);
			// 
			// restar
			// 
			this.restar.Location = new System.Drawing.Point(104, 169);
			this.restar.Name = "restar";
			this.restar.Size = new System.Drawing.Size(72, 30);
			this.restar.TabIndex = 7;
			this.restar.Text = "Restar";
			this.restar.UseVisualStyleBackColor = true;
			this.restar.Click += new System.EventHandler(this.restarClick);
			// 
			// multiplicar
			// 
			this.multiplicar.Location = new System.Drawing.Point(198, 169);
			this.multiplicar.Name = "multiplicar";
			this.multiplicar.Size = new System.Drawing.Size(71, 30);
			this.multiplicar.TabIndex = 8;
			this.multiplicar.Text = "Multiplicar";
			this.multiplicar.UseVisualStyleBackColor = true;
			this.multiplicar.Click += new System.EventHandler(this.MultiplicarClick);
			// 
			// dividir
			// 
			this.dividir.Location = new System.Drawing.Point(288, 169);
			this.dividir.Name = "dividir";
			this.dividir.Size = new System.Drawing.Size(72, 29);
			this.dividir.TabIndex = 9;
			this.dividir.Text = "Dividir";
			this.dividir.UseVisualStyleBackColor = true;
			this.dividir.Click += new System.EventHandler(this.DividirClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(372, 219);
			this.Controls.Add(this.dividir);
			this.Controls.Add(this.multiplicar);
			this.Controls.Add(this.restar);
			this.Controls.Add(this.sumar);
			this.Controls.Add(this.resultado);
			this.Controls.Add(this.num2);
			this.Controls.Add(this.num1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "calculadora";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button dividir;
		private System.Windows.Forms.Button multiplicar;
		private System.Windows.Forms.Button restar;
		private System.Windows.Forms.Button sumar;
		private System.Windows.Forms.MaskedTextBox resultado;
		private System.Windows.Forms.MaskedTextBox num2;
		private System.Windows.Forms.MaskedTextBox num1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
