using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinmori.Forms
{
    public partial class Main : Form
    {
        private bool isGuest;
        private int languageSelectorIndex;
        public Main(int languageSelectorIndex, bool isGuest)
        {
            InitializeComponent();
            this.isGuest = isGuest;
            this.languageSelectorIndex = languageSelectorIndex;
        }
    }
}
