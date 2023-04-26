using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VjezbaViseFormi
{
    public partial class Studenti : Form
    {
        public static Studenti instance;
        public Studenti()
        {
            InitializeComponent();
            instance = this;
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            FormunosNovogStudenta form = new FormunosNovogStudenta();
            form.ShowDialog();
        }

        private void buttonObrisiSve_Click(object sender, EventArgs e)
        {
            listBoxStudenti.Items.Clear();
        }

        private void buttonObrisiStudenta_Click(object sender, EventArgs e)
        {
            listBoxStudenti.Items.RemoveAt(listBoxStudenti.SelectedIndex);
        }
    }
}
