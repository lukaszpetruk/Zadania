using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace Cwiczenie7
{
    class Elephant
    {
        public int EarSize;
        public string Name;

        public void WhoAmI()
        {
            MessageBox.Show("Moje uszy maja " + EarSize + " centymetrow szerokości.", Name + " mówi...");
        }
    }
}
