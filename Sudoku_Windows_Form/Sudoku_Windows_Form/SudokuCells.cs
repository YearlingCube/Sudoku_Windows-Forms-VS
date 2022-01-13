using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku_Windows_Form
{
    class SudokuCells : Button
    {
        public int Value { get; set; }
        public bool isLocked { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    public void Clear()
    {
        this.Text = string.Empty;
        this.isLocked = false;
    }
    }
}
