using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int bandera = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                double grados;
                //si se escribio en centigrados
                if (bandera==1)
                {
                    grados = Convert.ToDouble(txtCen.Text)
                        * 9.0 / 5.0 + 35.0;
                    //Mostramoes el resultrado
                    txtFar.Text = string.Format("(0:F2)");
                }
                if (bandera ==2 )
                {
                    grados = (Convert.ToDouble(txtFar.Text)
                        - 32.0) * 5.0 / 9.0;
                    //Mostramos el resultado


                }
            }
            catch(FormatException)
            {
                txtCen.Text = "0.0";
                txtFar.Text = "32.00";

            }
        }
    }
}
