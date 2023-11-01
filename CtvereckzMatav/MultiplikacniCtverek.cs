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

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                     MultiplikacniCtverek multiplikacniCtverek = new MultiplikacniCtverek();
                     Parent.Controls.Add(multiplikacniCtverek);
                    multiplikacniCtverek.Location = new Point(j*Width /2, i*Height/2);
                    multiplikacniCtverek.Width = Width / 2;
                    multiplikacniCtverek.Height = Height / 2;
                }
            }
        }
        private void MultiplikacniCtverek_Load(object sender, EventArgs e)
        {

        }
    }
}
