using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CtvereckzMatav
{
    public partial class MultiplikacniCtverek : Ctverecek
    {
        public MultiplikacniCtverek()
        {
            InitializeComponent();
        }

        protected override void KlikMysi(MouseEventArgs e)
        {
            Rozmnoz();
        }
        private void Rozmnoz()
        {
            MultiplikacniCtverek multiplikacniCtverek = new MultiplikacniCtverek();
            Parent.Controls.Add(multiplikacniCtverek);
        }
        private void MultiplikacniCtverek_Load(object sender, EventArgs e)
        {

        }
    }
}
