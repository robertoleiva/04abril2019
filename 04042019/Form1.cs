using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace _04042019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            DriveInfo[] u = DriveInfo.GetDrives();
            foreach (DriveInfo unidad in u)

            
            try
            {
                listBox1.Items.Add(unidad.Name);

            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR DE LECTURA" + ex.Message);

            }
                 



        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //listBox2.Items.Clear();
            String unidades=listBox1.SelectedItem.ToString();
            listBox2.Items.Add(unidades);


        }
    }
}
