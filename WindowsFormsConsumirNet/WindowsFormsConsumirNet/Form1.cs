using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsConsumirNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient ws = new ServiceReference1.WebService1SoapClient();
            String res = "";
            res=ws.obtenermaterias(textBox1.Text);
            if (res == "") label1.Text = "No hay materias o ci inexistente";
            else
            {
                label1.Text = res.Replace(",", "\n");
            }
        }
    }
}
