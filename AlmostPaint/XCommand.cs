using AlmostPaint.Controls;
using AlmostPaint.Windows;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlmostPaint
{
    public class XCommand
    {
        public XData xData = new XData();
        public PDraw pDraw = null;

        public void SetColor(Color color)
        {
            //if (pDraw.currentFigure == null)
            //    xData.color = color;
            //else
            //    pDraw.currentFigure.Color = color;
            MessageBox.Show("Color Change");
        }

        public void SetLineWidth(int lineWidth)
        {
            //if (pDraw.currentFigure == null)
            //    xData.lineWidth = lineWidth;
            //else
            //    pDraw.currentFigure.LineWidth = lineWidth;
            MessageBox.Show("Width Change");
        }

        public void SetFigureType(int type)
        {
            //switch (type)
            //{
            //    case 1:
            //        xData.type = 1;
            //        break;
            //    case 2:
            //        xData.type = 2;
            //        break;
            //    case 3:
            //        xData.type = 3;
            //        break;
            //    case 4:
            //        xData.type = 4;
            //        break;
            //}
            MessageBox.Show("Type Change");
        }

        public void SetText(string text)
        {
            xData.text = text;
        }
        public void SetTextFont(string font)
        {
            xData.font = font;
        }
        public void SetTextSize(int size)
        {
            xData.sizetext = size;
        }
        public void SetTextColor(Color col)
        {
            xData.textcolor = col;
        }
        public void SetTextAlign(string align)
        {
            switch (align)
            {
                case "Left":
                    xData.textpos = "left";
                    break;
                case "Right":
                    xData.textpos = "right";
                    break;
                case "Up":
                    xData.textpos = "up";
                    break;
                case "Down":
                    xData.textpos = "down";
                    break;
                case "Center":
                    xData.textpos = "center";
                    break;
            }
        }
        public void ThemeChange()
        {
            MessageBox.Show("Theme changed");
        }
        public void LanguageChange()
        {
            MessageBox.Show("Language changed");
        }
        public void SwitchTab()
        {
            MessageBox.Show("Tab switched");
        }
        public void AddNewTab()
        {
            MessageBox.Show("Tab added");
        }
        public void CloseTab()
        {
            MessageBox.Show("Tab closed");
        }
        public void RenameTab()
        {

            RenameForm renameform = new RenameForm();
            renameform.Show();
            MessageBox.Show("Window renamed");
        }
        public void PluginShow()
        {
            MessageBox.Show("Plugin showed");
        }
        public void PluginClosed()
        {
            MessageBox.Show("Plugin closed");
        }

        //public void SetMemento(List<MFigure> list)
        //{
        //    pDraw.SetMemento(list);
        //    pDraw.Invalidate();
        //}

        //public List<MFigure> GetMemento()
        //{
        //    return pDraw.GetMemento();
        //}
        public void SetLang()
        {

        }
    }
}
