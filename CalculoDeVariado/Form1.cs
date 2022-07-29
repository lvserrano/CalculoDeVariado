using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
// System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;

namespace CalculoDeVariado
{
    public partial class Form1 : Form
    {
        public static bool txtBoxMaiorCotaAtivo = true;
        public static bool txtBoxMenorCotaAtivo = false;
        public static bool txtBoxQtdVariacAtivo = false;
        public Form1()
        {
            InitializeComponent();

            txtMaiorCota.LostFocus += new EventHandler(TextBox_LostFocus);
            txtMenorCota.LostFocus += new EventHandler(TextBox_LostFocus);
            txtQtdVariac.LostFocus += new EventHandler(TextBox_LostFocus);
            btn1.Click += new EventHandler(btnClick);
            btn2.Click += new EventHandler(btnClick);
            btn3.Click += new EventHandler(btnClick);
            btn4.Click += new EventHandler(btnClick);
            btn5.Click += new EventHandler(btnClick);
            btn6.Click += new EventHandler(btnClick);
            btn7.Click += new EventHandler(btnClick);
            btn8.Click += new EventHandler(btnClick);
            btn9.Click += new EventHandler(btnClick);
            btn0.Click += new EventHandler(btnClick);
        }
        
        private void btnClick(object sender, EventArgs e)
        {
            string number = (sender as Button).Text;
            if (txtBoxMaiorCotaAtivo)
            {

                txtMaiorCota.Text += number;
               
            }
            else if(txtBoxMenorCotaAtivo)
            {

                txtMenorCota.Text += number;

            } else
            {

                txtQtdVariac.Text += number;
            }
        }
        private void TextBox_LostFocus(object sender, EventArgs e)
        {
            if ((sender as TextBox).Name == "txtMaiorCota")
            {
                txtBoxMaiorCotaAtivo = true;

                txtBoxMenorCotaAtivo = false;
                txtBoxQtdVariacAtivo = false;
            }
            else if ((sender as TextBox).Name == "txtMenorCota")
            {
                txtBoxMenorCotaAtivo = true;

                txtBoxMaiorCotaAtivo = false;
                txtBoxQtdVariacAtivo = false;

            } else
            {
                txtBoxMenorCotaAtivo = false;
                txtBoxMaiorCotaAtivo = false;
                txtBoxQtdVariacAtivo = true;
            }
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Limpando os itens anteriores
            lbResultado.Items.Clear();
            try
            {
                // Verificando se o TextBox está vazio
                if (txtMaiorCota.Text == "")
            {
                MessageBox.Show("DIGITE A MAIOR COTA");
                txtMaiorCota.Focus();
                return;
            }else if (txtMenorCota.Text == "")
            {
                MessageBox.Show("DIGITE A MENOR COTA");
                txtMenorCota.Focus();
                return;
            }else if (txtQtdVariac.Text == "")
            {
                MessageBox.Show("DIGITE A QUANTIDADE DE VARIAÇÕES");
                txtQtdVariac.Focus();
                return;
            }



            float variado, maior = 0, menor = 0, nvar = 0, ferro, n = 1;

            
                maior = float.Parse(txtMaiorCota.Text);
                menor = float.Parse(txtMenorCota.Text);
                nvar = float.Parse(txtQtdVariac.Text);

           // verificar se digitou na ordem certa as cotas;
            if (maior < menor)
                {
                    MessageBox.Show("A MAIOR cota está MENOR que a MENOR cota, o cálculo não poderá ser efetuado!", "AVISO DE ERRO!");
                    txtMaiorCota.Focus();
                    return;
                }

            variado = (maior - menor) / (nvar - 1);
            MessageBox.Show(variado.ToString("000"), "VALOR DO VARIADO");

            for (ferro = maior; ferro >= menor;)
            {
                while (n <= nvar)
                {
                    lbResultado.Items.Add(n.ToString() + "º -" + ferro.ToString("000"));
                    ferro -= variado;
                    n++;
                }
                
            }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "AVISO DE ERRO");
                //Application.ExitThread();
            }

        }


        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtBoxMaiorCotaAtivo)
            {

                txtMaiorCota.Clear();

            }
            else if (txtBoxMenorCotaAtivo)
            {

                txtMenorCota.Clear();

            }
            else
            {

                txtQtdVariac.Clear();
            }
        }

        private PrintDocument document = new PrintDocument();
        private void print()
        {
            //configuração do documento PDF
            var pxPorMm = 72 / 25.2F;
            var pdf = new Document(PageSize.A4, 15 * pxPorMm, 15 * pxPorMm, 15 * pxPorMm, 15 * pxPorMm);
            var nomeArquivo = $"{DateTime.Now.ToString("yyyy.MM.dd.HH.mm.ss")}.pdf";
            var arquivo = new FileStream(nomeArquivo, FileMode.Create);
            var writer = PdfWriter.GetInstance(pdf, arquivo);
            pdf.Open();

            var fonteBase = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);

            //adição do título
            var fonteParagrafo = new iTextSharp.text.Font(fonteBase, 32, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            var titulo = new Paragraph("Cálculo de variado\n\n", fonteParagrafo);
            titulo.Alignment = Element.ALIGN_LEFT;
            pdf.Add(titulo);

            pdf.Close();
            arquivo.Close();

            // abre o PDF no visualizador padrao
            var caminhoPDF = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nomeArquivo);
            if (File.Exists(caminhoPDF))
            {
                Process.Start(new ProcessStartInfo()
                {
                    Arguments = $"/c start {caminhoPDF}",
                    FileName = "cmd.exe",
                    CreateNoWindow = true
                });
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            print();
        }
    }
}
