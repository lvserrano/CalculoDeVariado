﻿namespace CalculoDeVariado
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
            this.lblMaiorCota = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.ListBox();
            this.txtMaiorCota = new System.Windows.Forms.TextBox();
            this.txtMenorCota = new System.Windows.Forms.TextBox();
            this.lblMenorCota = new System.Windows.Forms.Label();
            this.txtQtdVariac = new System.Windows.Forms.TextBox();
            this.lblQtdVariac = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // lblMaiorCota
            // 
            this.lblMaiorCota.AutoSize = true;
            this.lblMaiorCota.Font = new System.Drawing.Font("Arial", 12.2F, System.Drawing.FontStyle.Bold);
            this.lblMaiorCota.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMaiorCota.Location = new System.Drawing.Point(343, 42);
            this.lblMaiorCota.Name = "lblMaiorCota";
            this.lblMaiorCota.Size = new System.Drawing.Size(118, 24);
            this.lblMaiorCota.TabIndex = 0;
            this.lblMaiorCota.Text = "Maior Cota";
            // 
            // lbResultado
            // 
            this.lbResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.lbResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbResultado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbResultado.FormattingEnabled = true;
            this.lbResultado.ItemHeight = 16;
            this.lbResultado.Location = new System.Drawing.Point(12, 69);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(273, 304);
            this.lbResultado.TabIndex = 1;
            // 
            // txtMaiorCota
            // 
            this.txtMaiorCota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.txtMaiorCota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaiorCota.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaiorCota.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtMaiorCota.Location = new System.Drawing.Point(347, 69);
            this.txtMaiorCota.Name = "txtMaiorCota";
            this.txtMaiorCota.Size = new System.Drawing.Size(232, 43);
            this.txtMaiorCota.TabIndex = 2;
            // 
            // txtMenorCota
            // 
            this.txtMenorCota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.txtMenorCota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMenorCota.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold);
            this.txtMenorCota.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtMenorCota.Location = new System.Drawing.Point(347, 190);
            this.txtMenorCota.Name = "txtMenorCota";
            this.txtMenorCota.Size = new System.Drawing.Size(232, 43);
            this.txtMenorCota.TabIndex = 4;
            // 
            // lblMenorCota
            // 
            this.lblMenorCota.AutoSize = true;
            this.lblMenorCota.Font = new System.Drawing.Font("Arial", 12.2F, System.Drawing.FontStyle.Bold);
            this.lblMenorCota.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMenorCota.Location = new System.Drawing.Point(343, 163);
            this.lblMenorCota.Name = "lblMenorCota";
            this.lblMenorCota.Size = new System.Drawing.Size(126, 24);
            this.lblMenorCota.TabIndex = 3;
            this.lblMenorCota.Text = "Menor Cota";
            // 
            // txtQtdVariac
            // 
            this.txtQtdVariac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.txtQtdVariac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQtdVariac.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold);
            this.txtQtdVariac.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtQtdVariac.Location = new System.Drawing.Point(347, 322);
            this.txtQtdVariac.Name = "txtQtdVariac";
            this.txtQtdVariac.Size = new System.Drawing.Size(232, 43);
            this.txtQtdVariac.TabIndex = 6;
            // 
            // lblQtdVariac
            // 
            this.lblQtdVariac.AutoSize = true;
            this.lblQtdVariac.Font = new System.Drawing.Font("Arial", 12.2F, System.Drawing.FontStyle.Bold);
            this.lblQtdVariac.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblQtdVariac.Location = new System.Drawing.Point(343, 295);
            this.lblQtdVariac.Name = "lblQtdVariac";
            this.lblQtdVariac.Size = new System.Drawing.Size(108, 24);
            this.lblQtdVariac.TabIndex = 5;
            this.lblQtdVariac.Text = "Variações";
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn1.Location = new System.Drawing.Point(611, 42);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(90, 90);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold);
            this.btn2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn2.Location = new System.Drawing.Point(723, 42);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(90, 90);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold);
            this.btn3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn3.Location = new System.Drawing.Point(835, 42);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(90, 90);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold);
            this.btn4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn4.Location = new System.Drawing.Point(948, 42);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(90, 90);
            this.btn4.TabIndex = 10;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold);
            this.btn5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn5.Location = new System.Drawing.Point(1062, 42);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(90, 90);
            this.btn5.TabIndex = 11;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.btn0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold);
            this.btn0.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn0.Location = new System.Drawing.Point(1062, 170);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(90, 90);
            this.btn0.TabIndex = 16;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold);
            this.btn9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn9.Location = new System.Drawing.Point(948, 170);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(90, 90);
            this.btn9.TabIndex = 15;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold);
            this.btn8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn8.Location = new System.Drawing.Point(835, 170);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(90, 90);
            this.btn8.TabIndex = 14;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold);
            this.btn7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn7.Location = new System.Drawing.Point(723, 170);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(90, 90);
            this.btn7.TabIndex = 13;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold);
            this.btn6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn6.Location = new System.Drawing.Point(611, 170);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(90, 90);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Arial", 12.2F, System.Drawing.FontStyle.Bold);
            this.lblResultado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblResultado.Location = new System.Drawing.Point(12, 42);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(112, 24);
            this.lblResultado.TabIndex = 17;
            this.lblResultado.Text = "Resultado";
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDel.Location = new System.Drawing.Point(611, 295);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(541, 90);
            this.btnDel.TabIndex = 18;
            this.btnDel.Text = "DELETAR";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.btnCalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalc.FlatAppearance.BorderSize = 0;
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCalc.Location = new System.Drawing.Point(611, 445);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(541, 90);
            this.btnCalc.TabIndex = 19;
            this.btnCalc.Text = "CALCULAR";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrint.Location = new System.Drawing.Point(12, 445);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(541, 90);
            this.btnPrint.TabIndex = 20;
            this.btnPrint.Text = "IMPRIMIR";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtQtdVariac);
            this.Controls.Add(this.lblQtdVariac);
            this.Controls.Add(this.txtMenorCota);
            this.Controls.Add(this.lblMenorCota);
            this.Controls.Add(this.txtMaiorCota);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.lblMaiorCota);
            this.Name = "Form1";
            this.Text = "Calculadora de Variado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaiorCota;
        private System.Windows.Forms.ListBox lbResultado;
        private System.Windows.Forms.TextBox txtMaiorCota;
        private System.Windows.Forms.TextBox txtMenorCota;
        private System.Windows.Forms.Label lblMenorCota;
        private System.Windows.Forms.Label lblQtdVariac;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.TextBox txtQtdVariac;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

