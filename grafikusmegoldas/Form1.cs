using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
using System.IO;

namespace grafikusmegoldas
{
    public partial class Form1 : Form
    {
        List<Fuvar> fuvarok = new List<Fuvar>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btnKilépés_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            foreach (var sor in File.ReadAllLines("fuvar.csv").Skip(1))
            {
                fuvarok.Add(new Fuvar(sor));

            }
            listBox1.DataSource = fuvarok;
            listBox1.DisplayMember = "TaxiId";

           // listBox1Update();

         }
        private void listBox1Update()
            {
                listBox1.Items.Clear();
                foreach (var f in fuvarok)
                {
                    listBox1.Items.Add(f);
                }
                listBox1.DisplayMember = "TaxiId";
            }

        private void btnSort_Click(object sender, EventArgs e)
        {
            fuvarok= fuvarok.OrderBy(x => x.TaxiId).ToList();
            listBox1.DataSource = fuvarok;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTaxiID.Text = ((Fuvar)listBox1.SelectedItem).TaxiId.ToString();
        }
    }
   
        


}

 