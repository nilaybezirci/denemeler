using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrixİşlemleri
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string fileName = "matrix.txt";
            string path = Path.Combine(Environment.CurrentDirectory, fileName);
            StreamReader rw = new StreamReader(path);
            string satir = "";
            while ((satir=rw.ReadLine())!=null)
            {
                rtxbMatrix.Text += satir + "\n";
            }
            rw.Close();
        }

      
    }
}
