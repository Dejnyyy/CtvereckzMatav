﻿using System;
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
    public abstract partial class Ctverecek : UserControl
    {
        protected Ctverecek()
        {
            InitializeComponent();
        }

        protected void Ctverecek_MouseClick(object sender, MouseEventArgs e)
        {
            KlikMysi(e);
        }
        protected abstract void KlikMysi(MouseEventArgs e);
        
    }
}
