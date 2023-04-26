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

  
    public partial class FormunosNovogStudenta : Form
    {
        public static FormunosNovogStudenta instance;
        private Student student1;
        public FormunosNovogStudenta()
        {
            InitializeComponent();
            instance = this;
        }
        public Student Student1
        {
            get
            {
                return student1;
            }
            set
            {
                student1 = value;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        public class Student
        {
            private string ime, prezime, brojIndeksa, smjer;
            private DateTime datumRodjenja;

            public Student(string ime, string prezime, string brojIndeksa, DateTime datumRodjenja, string smjer)
            {
                this.ime = ime;
                this.prezime = prezime;
                this.brojIndeksa = brojIndeksa;
                this.datumRodjenja = datumRodjenja;
                this.Smjer = smjer;
            }

            public string Ime { get => ime; set => ime = value; }
            public string Prezime { get => prezime; set => prezime = value; }
            public string BrojIndeksa { get => brojIndeksa; set => brojIndeksa = value; }
            public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
            public string Smjer { get => smjer; set => smjer = value; }

            public override string ToString()
            {
                string ispis = ("Ime: " + this.ime + "\tPrezime: " + this.prezime + "\tBroj indeksa: " + this.brojIndeksa + "\tDatum rođenja: " + this.datumRodjenja + "\tSmjer: " + this.smjer);
                return ispis;
            }
        }

        private void buttonSnimi_Click(object sender, EventArgs e)
        {
            Student student = new Student(textBoxIme.Text, textBoxPrezime.Text, textBoxBrojIndeksa.Text, dateTimePickerDatumRodenja.Value, comboBoxSmjer.Text);
            Studenti.instance.listBoxStudenti.Items.Add(student);
        }

        private void buttonOtkazi_Click(object sender, EventArgs e)
        {
            textBoxBrojIndeksa.Clear();
            textBoxIme.Clear();
            textBoxPrezime.Clear();
            this.Close();
        }
    }
}
