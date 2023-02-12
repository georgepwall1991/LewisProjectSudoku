using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LewisProjectSudoku
{
    public partial class lvlOne : Form
    {
        public lvlOne()
        {
            InitializeComponent();
        }
        //initialising my variables (the inputs from the drop down boxes)
        int intUser1A;
        int intuser5A;
        int intuser7A;
        int intuser9A;
        int intuser2B;
        int intuser3B;
        int intuser4B;
        int intuser7B;
        int intuser3C;
        int intuser5C;
        int intuser6C;
        int intuser8C;
        int intuser1D;
        int intuser5D;
        int intuser7D;
        int intuser1E;
        int intuser2E;
        int intuser6E;
        int intuser7E;
        int intuser9E;
        int intuser1F;
        int intuser5F;
        int intuser6F;
        int intuser8F;
        int intuser2G;
        int intuser3G;
        int intuser4G;
        int intuser9G;
        int intuser4H;
        int intuser7H;
        int intuser8H;
        int intuser9H;
        int intuser2I;
        int intuser3I;
        int intuser4I;
        int intuser6I;


        private void BoxA1_SelectedIndexChanged(object sender, EventArgs e)
        {

            var intUser1A = BoxA1.SelectedItem; // the input from this box is stored as inA1



        }

        private void BoxA5_SelectedIndexChanged(object sender, EventArgs e)
        {
            var intUser5A = BoxA5.SelectedItem;
            //MessageBox.Show(intUser5A.ToString()); // print to show the value was stored correctly
        }

        private void BoxA7_SelectedIndexChanged(object sender, EventArgs e)
        {
            var intUser7A = BoxA7.SelectedItem;
        }

        private void BoxA9_SelectedIndexChanged(object sender, EventArgs e)
        {
            var intUser9A = BoxA9.SelectedItem;
        }

        private void BoxB2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var intUser2B = BoxB2.SelectedItem;
        }

        private void BoxB3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var intUser3B = BoxB3.SelectedItem;
        }

        private void BoxB4_SelectedIndexChanged(object sender, EventArgs e)
        {
            var intUser4B = BoxB4.SelectedItem;
        }

        private void BoxB7_SelectedIndexChanged(object sender, EventArgs e)
        {
            var intUserB7 = BoxB7.SelectedItem;
        }










    }
}

