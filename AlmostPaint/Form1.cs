﻿using AlmostPaint.Figure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlmostPaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            XCommand xCommand = new XCommand();
            List<PFigure> pFigures = new List<PFigure>();

            pMenu1.xCommand = xCommand;

        }
        
    }
}
