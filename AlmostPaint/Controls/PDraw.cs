using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlmostPaint.Figure;

namespace AlmostPaint.Controls
{
    public partial class PDraw : UserControl
    {
        private XCommand _xCommand = null;
        //public XCommand XCommand { set { _xCommand = value; ctxMenu1.xCommand = _xCommand; } }

        public List<PFigure> pFigures = null;
        public PFigure currentFigure = null;

        private PFigure newFigure = null;
        private Point clickPoint;
        public PDraw()
        {
            InitializeComponent();
        }
    }
}
