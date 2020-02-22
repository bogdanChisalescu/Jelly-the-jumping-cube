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

namespace jelly_the_jumping_cube_1._1
{
    public partial class helper : Form
    {

        string helpercontent;

        public helper()
        {
            InitializeComponent();
        }

        private void helper_Load(object sender, EventArgs e)
        {
            StreamReader reader1 = new StreamReader(@"text1.txt");
            StreamWriter writer1 = new StreamWriter(@"text.txt");

            helpercontent = reader1.ReadLine();
            reader1.Close();
            writer1.WriteLine(int.Parse(helpercontent));
            writer1.Close();
        }
    }
}
