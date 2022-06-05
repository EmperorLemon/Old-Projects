using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect_Four
{
    public partial class ConnectFour : Form
    {
        public int rows = 6;
        public int columns = 7;

        public int[,] matrix;


        // Row = 6, Column = 7, Size = 42
        public ConnectFour()
        {
            InitializeComponent();

            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns; y++)
                {
                    matrix = new int[x,y];
                }
            }
        }
    }
}
