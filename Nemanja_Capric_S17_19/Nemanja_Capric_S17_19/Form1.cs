using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using System.Xml.Serialization;

namespace Kolokvijum2_Nemanja_Capric_s17_19
{

    public partial class Desktop : Form
    {
        List<clsDesktop> ListaRacunara = new List<clsDesktop>();
        public Desktop()
        {
            InitializeComponent();
        }


    

        private void button3_Click_1(object sender, EventArgs e)
        {
            clsDesktop s = new clsDesktop();
            try
            {
                s.proizvodjac = textBox6.Text;
                s.model = textBox7.Text;
                s.procesor = comboBox2.Text;
                s.radnaMemorija = Convert.ToInt32(textBox8.Text);
                s.memorija = Convert.ToInt32(textBox10.Text);
                s.cena = Convert.ToInt32(textBox9.Text);

                ListaRacunara.Add(s);
                MessageBox.Show("Uspesan unos!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            string strJson = js.Serialize(ListaRacunara);
            MessageBox.Show("Uspesan unos u JSON!");
        }
    }
}
