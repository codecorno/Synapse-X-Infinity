using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using sxlib;
using sxlib.Specialized;
using System.Windows.Forms;

namespace Synapse_X_Infinity
{
    class SynxF
    {
        public static SxLibWinForms Lib;

        // Credits to @github.com/ct201158
        public static OpenFileDialog OpenFile = new OpenFileDialog
        {
            Filter = "Script Files (*.lua, *.txt) | *.lua;*.txt",
            FilterIndex = 1,
            RestoreDirectory = true,
            Title = "Synapse X Infinity - Open File"
        };

        // Credits to @github.com/ct201158
        public static OpenFileDialog ExecuteFile = new OpenFileDialog
        {
            Filter = "Script Files (*.lua, *.txt) | *.lua;*.txt",
            FilterIndex = 1,
            RestoreDirectory = true,
            Title = "Synapse X Infinity - Execute File"
        };

        // Credits to @github.com/ct201158
        public static SaveFileDialog SaveFile = new SaveFileDialog()
        {
            Filter = "Script Files (*.lua) | *.lua",
            FilterIndex = 1,
            RestoreDirectory = true,
            Title = "Synapse X Infinity - Save FIle"
        };
    }
}
