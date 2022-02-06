using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuGame
{
    class Case : Button
    {

        public int value { get; set; }
        public bool plein { get; set; }
        public int x { get; set; }
        public int y { get; set; }

        public void Vide()
        {
            this.Text = string.Empty;
            this.plein = false;
        }

    }
}

