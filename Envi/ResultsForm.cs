using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Envi
{
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }

        private void Results_Load(object sender, EventArgs e)
        {
            string results = System.IO.File.ReadAllText(@"..\best_results.txt");
            label1.Text = results;
        }
    }
}
