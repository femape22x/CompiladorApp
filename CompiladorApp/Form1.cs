using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompiladorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdbDescripcion_CheckedChanged(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabControlDescripcion;
            txtEditorTexto.Text = String.Empty;
            dgvResultado.Rows.Clear();
            txtEditorTexto.Focus();
        }

        private void rdbCompilador_CheckedChanged(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabControlCompilador;
            txtEditorTexto.Text = String.Empty;
            dgvResultado.Rows.Clear();
            txtEditorTexto.Focus();
        }

        private void rdbIntegrantes_Click(object sender, EventArgs e)
        {
            txtEditorTexto.Text = String.Empty;
            dgvResultado.Rows.Clear();
            txtEditorTexto.Focus();
            MessageBox.Show("Desarrollado por:\n" +
                "\n\nFelix De Jesus Marrugo Palomino" +
                "\n\nAlexander Naranjo Gastelbondo" +
                "\n\nVíctor Emanuel Bejarano");
        }

        private void txtEditorTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (!txtEditorTexto.Text.Equals(String.Empty))
                {
                    String declarations = txtEditorTexto.Text;

                    Char[] delimiter = {'*'};
                    String[] ArrayDeclarations = declarations.Split(delimiter);

                    for (int i = 0; i < ArrayDeclarations.Length; i++)
                    {
                        String declaration = ArrayDeclarations[i];

                        String pattern = @"^(DECLARE)[\s]+[A-Z][0-9A-Z_]{0,14}((([\s]*)?[,]([\s]*)?[A-Z][0-9A-Z_]{0,14})+)?[\s]+(CADENA|ENTERO|REAL|FECHA|LOGICO)([\s]*)?[;]";
                        String result = "";

                        Regex Exp = new Regex(pattern);
                        if (Exp.IsMatch(declaration.ToUpper().Trim()))
                        {
                            String Pattern = @"[\s]+(CADENA|ENTERO|REAL|FECHA|LOGICO)([\s]*)?[;][A-Z0-9*/+\-!¡#$%&={}_<>.,;¿?()'[\]@\s]+";
                            Regex EXP = new Regex(Pattern);
                            if (EXP.IsMatch(declaration.ToUpper().Trim()))
                            {
                                result = "El Formato de la declaración contiene mas de lo Necesario.";
                                dgvResultado.Rows.Add(declaration, result);
                            }
                            else
                            {
                                result = "La declaración es Correcta.";
                                dgvResultado.Rows.Add(declaration, result);
                              }
                        }
                        else
                        {
                            String pattern2 = @"^[A-Z0-9*/+\-!¡#$%&={}_<>.;¿?()'[\]@\s]+[\s]+[A-Z][0-9A-Z_]{0,14}((([\s]*)?[,]([\s]*)?[A-Z][0-9A-Z_]{0,14})+)?[\s]+(CADENA|ENTERO|REAL|FECHA|LOGICO)([\s]*)?[;]";
                            String pattern3 = @"^(DECLARE)[\s]+[A-Z0-9*/+\-!¡#$%&={}_<>.;¿?()'[\]@]+((([\s]*)?[,]([\s]*)?[A-Z0-9*/+\-!¡#$%&={}_<>.,;¿?()'[\]@]+)+)?[\s]+(CADENA|ENTERO|REAL|FECHA|LOGICO)([\s]*)?[;]";
                            String pattern4 = @"^(DECLARE)[\s]+[A-Z][0-9A-Z_]{0,14}((([\s]*)?[,]([\s]*)?[A-Z][0-9A-Z_]{0,14})+)?[\s]+[A-Z0-9*/+\-!¡#$%&={}_<>.,;¿?()'[\]@]+([\s]*)?[;]";
                            String pattern5 = @"^(DECLARE)[\s]+[A-Z][0-9A-Z_]{0,14}((([\s]*)?[,]([\s]*)?[A-Z][0-9A-Z_]{0,14})+)?[\s]+(CADENA|ENTERO|REAL|FECHA|LOGICO)([\s]*)?";

                            Regex Exp2 = new Regex(pattern2);
                            Regex Exp3 = new Regex(pattern3);
                            Regex Exp4 = new Regex(pattern4);
                            Regex Exp5 = new Regex(pattern5);

                            if (Exp2.IsMatch(declaration.ToUpper().Trim()))
                            {
                                Regex format = new Regex("DECLARE");
                                if (format.IsMatch(declaration.ToUpper().Trim()))
                                {
                                    result = "El Formato de la declaración es Incorrecto.";
                                    dgvResultado.Rows.Add(declaration, result);
                                }
                                else
                                {
                                    result = "Palabra 'Declare' No existe.";
                                    dgvResultado.Rows.Add(declaration, result);
                                }
                            }
                            else if (Exp3.IsMatch(declaration.ToUpper().Trim()))
                            {
                                result = "El Nombre de la Variable es Invalido.";
                                dgvResultado.Rows.Add(declaration, result);
                            }
                            else if (Exp4.IsMatch(declaration.ToUpper().Trim()))
                            {
                                result = "El Tipo Dato es Invalido.";
                                dgvResultado.Rows.Add(declaration, result);
                            }
                            else if (Exp5.IsMatch(declaration.ToUpper().Trim()))
                            {
                                Regex format = new Regex(";");
                                if (format.IsMatch(declaration.ToUpper().Trim()))
                                {
                                    result = "El Formato de la declaración es Incorrecto.";
                                    dgvResultado.Rows.Add(declaration, result);
                                }
                                else
                                {
                                    result = "Hizo falta el ';'";
                                    dgvResultado.Rows.Add(declaration, result);
                                }
                            }
                            else
                            {
                                result = "El Formato de la declaración es Incorrecto.";
                                dgvResultado.Rows.Add(declaration, result);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("INFORMACIÓN\n\nNo se permite campo Vacio.",
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Hand,
                        MessageBoxDefaultButton.Button1);
                }
                txtEditorTexto.Text = String.Empty;
                txtEditorTexto.Focus();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEditorTexto.Text = String.Empty;
            dgvResultado.Rows.Clear();
            txtEditorTexto.Focus();
        }
    }
}
