using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradientEditor
{
    public partial class Form1 : Form
    {
        List<Wedge> wedges = new List<Wedge>();
        Random rand = new Random();
        int idy = 0;

        public Form1()
        {
            InitializeComponent();

            tbPos.Maximum = this.Width;
        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            if (wedges.Count > 0)
            {
                tbPos.Value = (int)(.5F * tbPos.Maximum);
                wedges.Insert(idy+1, new Wedge(wedges[idy].Color, .5F));
                cbWedge.Items.Insert(idy+1, String.Format("{0}_{1}", rand.Next(), rand.Next()));
                idy++;
            }
            else
            {
                idy = 0;
                wedges.Add(new Wedge(Color.Black, 0));
                wedges.Add(new Wedge(Color.White, 1));
                cbWedge.Items.Add(String.Format("{0}_{1}", rand.Next(), rand.Next()));
                cbWedge.Items.Add(String.Format("{0}_{1}", rand.Next(), rand.Next()));
            }
            gPanel.Invalidate();
        }
        private void bDel_Click(object sender, EventArgs e)
        {
            if (wedges.Count > 0)
            {
                idy = 0;
                wedges.RemoveAt(idy);
                cbWedge.Items.RemoveAt(idy);
                gPanel.Invalidate();
            }
        }

        private void tbR_Scroll(object sender, EventArgs e)
        {
            if (wedges.Count > 0)
            {
                Wedge w = wedges[idy];
                w.Color = Color.FromArgb(tbR.Value, w.Color.G, w.Color.B);
                wedges[idy] = w;
                gPanel.Invalidate();
            }
        }
        private void tbG_Scroll(object sender, EventArgs e)
        {
            if (wedges.Count > 0)
            {
                Wedge w = wedges[idy];
                w.Color = Color.FromArgb(w.Color.R, tbG.Value, w.Color.B);
                wedges[idy] = w;
                gPanel.Invalidate();
            }
        }
        private void tbB_Scroll(object sender, EventArgs e)
        {
            if (wedges.Count > 0)
            {
                Wedge w = wedges[idy];
                w.Color = Color.FromArgb(w.Color.R, w.Color.G, tbB.Value);
                wedges[idy] = w;
                gPanel.Invalidate();
            }
        }

        private void tbPos_Scroll(object sender, EventArgs e)
        {
            if (wedges.Count > 0)
            {
                //if (wedges[idy].IDX == 1 || wedges[idy].IDX == 0) return;
                Wedge w = wedges[idy];
                w.IDX = tbPos.Value / (float)tbPos.Maximum;
                wedges[idy] = w;
                gPanel.Invalidate();
            }
        }

        private void cbWedge_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbWedge.SelectedIndex >= 0 && wedges.Count > 0)
            {
                Wedge w = wedges[idy];
                idy = cbWedge.SelectedIndex;
                tbPos.Value = (int)(w.IDX * this.Width);
                tbR.Value = w.Color.R;
                tbG.Value = w.Color.G;
                tbB.Value = w.Color.B;
            }
        }
        private void cbOr_SelectedIndexChanged(object sender, EventArgs e)
        {
            gPanel.Invalidate();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            tbPos.Maximum = this.Width;
        }

        private void gPanel_Paint(object sender, PaintEventArgs e)
        {
            String text = "";
            try
            {
                LinearGradientBrush linGrBrush;
                text += "LinearGradientBrush lineBrush;\n\n";
                switch (cbOr.SelectedIndex)
                {
                    case 1:
                        linGrBrush = new LinearGradientBrush(
                            new Rectangle(0, 0, gPanel.Width - 1, gPanel.Height - 1), 
                            Color.Transparent, Color.Transparent, 
                            LinearGradientMode.Horizontal);
                        text += "lineBrush = new LinearGradientBrush(\n\tnew Rectangle(0, 0, gPanel.Width - 1, gPanel.Height - 1),\n\tColor.Transparent, Color.Transparent,\n\tLinearGradientMode.Horizontal);\n";
                        break;
                    default:
                        linGrBrush = new LinearGradientBrush(
                            new Rectangle(0, 0, gPanel.Width - 1, gPanel.Height - 1), 
                            Color.Transparent, Color.Transparent, 
                            LinearGradientMode.Vertical);
                        text += "lineBrush = new LinearGradientBrush(\n\tnew Rectangle(0, 0, gPanel.Width - 1, gPanel.Height - 1),\n\tColor.Transparent, Color.Transparent,\n\tLinearGradientMode.Verticle);\n";
                        break;
                }

                System.Drawing.Drawing2D.ColorBlend blend = new System.Drawing.Drawing2D.ColorBlend();
                text += "\nSystem.Drawing.Drawing2D.ColorBlend blend = new System.Drawing.Drawing2D.ColorBlend();\n\n";

                text += "float[] pos = new float[] { ";
                List<float> pos = new List<float>();
                List<Color> col = new List<Color>();
                for (int i = 0; i < wedges.Count; i++)
                {
                    pos.Add(wedges[i].IDX);
                    text += String.Format("{0}F, ", wedges[i].IDX);
                }
                text += "};\nColor[] col = new Color[] { ";
                for (int i = 0; i < wedges.Count; i++)
                {
                    col.Add(wedges[i].Color);
                    text += String.Format("\n\tColor.FromArgb({0}, {1}, {2}), ", wedges[i].Color.R, wedges[i].Color.G, wedges[i].Color.B);
                }
                blend.Colors = col.ToArray();
                blend.Positions = pos.ToArray();

                linGrBrush.InterpolationColors = blend;
                text += "};\n\nblend.Colors = col;\nblend.Positions = pos;\nlineBrush.InterpolationColors = blend;";
                rtbCode.Text = text;

                //Create a Blend object and assign it to linGrBrush.
                //Blend blend = new Blend();
                //blend.Positions = pos.ToArray();
                //linGrBrush.Blend = blend;
                //linGrBrush.
                //linGrBrush.LinearColors = col.ToArray();

                e.Graphics.FillRectangle(linGrBrush, 0, 0, gPanel.Width - 1, gPanel.Height - 1);
            }
            catch { }
        }

        private void tbR_ValueChanged(object sender, EventArgs e)
        {
            lR.Text = tbR.Value.ToString();
        }
        private void tbG_ValueChanged(object sender, EventArgs e)
        {
            lG.Text = tbG.Value.ToString();
        }
        private void tbB_ValueChanged(object sender, EventArgs e)
        {
            lB.Text = tbB.Value.ToString();
        }
    }

    public struct Wedge
    {
        public Color Color;
        public float IDX;

        public Wedge(Color clr, float idx)
        {
            Color = clr;
            IDX = idx;
        }
    }
}
