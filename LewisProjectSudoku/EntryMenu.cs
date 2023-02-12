using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LewisProjectSudoku
{
    public partial class EntryMenu : Form
    {
        public EntryMenu()
        {
            InitializeComponent();


        }

       

        private void Diff1_Click(object sender, EventArgs e)
        {
          
            lvlOne lvl1 = new lvlOne(); // turns the form into an object
            lvl1.Show(); // Show levelOne
            

        }

        private void Diff2_Click(object sender, EventArgs e)
        {
            lvlTwo lvl2 = new lvlTwo(); 
            lvl2.Show(); 
        }

        private void Diff3_Click(object sender, EventArgs e)
        {
            lvlThree lvl3 = new lvlThree(); 
            lvl3.Show(); 
        }

        private void Diff4_Click(object sender, EventArgs e)
        {
            lvlFour lvl4 = new lvlFour(); 
            lvl4.Show(); 
        }

        private void Diff5_Click(object sender, EventArgs e)
        {
            lvlFive lvl5 = new lvlFive(); 
            lvl5.Show(); 
        }
    }
}
