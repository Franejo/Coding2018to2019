using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YEETEDMYSKEETED
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
             List<Button> yeet = new List<Button>() { B1, B2, B3 };
            Random rand = new Random();
            yeet[rand.Next(0, yeet.Count)].Click += (o, e) => CloseProgram();
            
        }    
        void CloseProgram()
        {
            
            Environment.Exit(0);

        }
    }
}
