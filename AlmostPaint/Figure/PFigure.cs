using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlmostPaint.Figure
{
    public partial class PFigure : UserControl
    {
        private Color _color;
        private int _lineWidth;
        public int _type;

        public Color Color { set { _color = value; Invalidate(); } }
        public int LineWidth { set { _lineWidth = value; Invalidate(); } }
        public int Type { set { _type = value; Invalidate(); } }
        public PFigure()
        {
            InitializeComponent();
        }
    }
}
