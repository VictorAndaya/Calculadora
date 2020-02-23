using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica5
{
    public partial class Form1 : Form
    {

        public static double resul;
        public static double a, b, c, d, r1, r2;

        public Form1()
        {
            InitializeComponent();
            tabPage1.Parent = null;
            tabPage2.Parent = null;
            tabPage3.Parent = null;
            tabPage4.Parent = null;
            
        }

        private void txta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txta.Clear();
            txtb.Clear();
            txtc.Clear();
            txtd.Clear();
            lblSigP.Text = "?";
            lblRes.Text = "";
            tabPage1.Parent = null;
            tabPage2.Parent = null;
            tabPage3.Parent = null;
            tabPage4.Parent = null;
        }

        private void txtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }



        private void btnSuma_Click_1(object sender, EventArgs e)
        {
            if (txta.Text == "" || txtb.Text == "" || txtc.Text == "" || txtd.Text == "")
            {
                MessageBox.Show("No dejes Campos vacios","Campo Vacio",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                if (tabPage1.Parent == null)
                {
                    // 0 es el index por la primera pestana
                    tabControl1.TabPages.Insert(0, tabPage1);
                    tabPage2.Parent = null;
                    tabPage3.Parent = null;
                    tabPage4.Parent = null;
                }

                a = Convert.ToDouble(txta.Text);
                b = Convert.ToDouble(txtb.Text);
                c = Convert.ToDouble(txtc.Text);
                d = Convert.ToDouble(txtd.Text);

                resul = ((a * d) + (b * c)) / (b * d);
                lblRes.Text = Convert.ToString(resul);
                lblSigP.Text = "+";

                lbl1.Text = a.ToString();
                lbl2.Text = b.ToString();
                lbl3.Text = c.ToString();
                lbl4.Text = d.ToString();

                lbl2a.Text = a.ToString();
                lbl2b.Text = b.ToString();
                lbl2c.Text = c.ToString();
                lbl2d.Text = d.ToString();
                lbl2bx.Text = b.ToString();
                lbl2dx.Text = d.ToString();

                r1 = ((a * d) + (b * c));
                r2 = (b * d);

                lbl3r1.Text = r1.ToString();
                lbl3r2.Text = r2.ToString();
            }
        }

        private void btnResta_Click_1(object sender, EventArgs e)
        {
            if (txta.Text == "" || txtb.Text == "" || txtc.Text == "" || txtd.Text == "")
            {
                MessageBox.Show("No dejes Campos vacios", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (tabPage2.Parent == null)
                {
                    // 0 es el index por la primera pestana
                    tabControl1.TabPages.Insert(0, tabPage2);
                    tabPage1.Parent = null;
                    tabPage3.Parent = null;
                    tabPage4.Parent = null;
                }

                a = Convert.ToDouble(txta.Text);
                b = Convert.ToDouble(txtb.Text);
                c = Convert.ToDouble(txtc.Text);
                d = Convert.ToDouble(txtd.Text);

                resul = ((a * d) - (b * c)) / (b * d);
                lblRes.Text = Convert.ToString(resul);
                lblSigP.Text = "—";

                lblR1.Text = a.ToString();
                lblR2.Text = b.ToString();
                lblR3.Text = c.ToString();
                lblR4.Text = d.ToString();

                lbl2Ra.Text = a.ToString();
                lbl2Rb.Text = b.ToString();
                lbl2Rc.Text = c.ToString();
                lbl2Rd.Text = d.ToString();
                lbl2Rbx.Text = b.ToString();
                lbl2Rdx.Text = d.ToString();

                r1 = ((a * d) - (b * c));
                r2 = (b * d);

                lbl3Rr1.Text = r1.ToString();
                lbl3Rr2.Text = r2.ToString();
            }
        }

        private void btnMul_Click_1(object sender, EventArgs e)
        {
            if (txta.Text == "" || txtb.Text == "" || txtc.Text == "" || txtd.Text == "")
            {
                MessageBox.Show("No dejes Campos vacios", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (tabPage3.Parent == null)
                {
                    // 0 es el index por la primera pestana
                    tabControl1.TabPages.Insert(0, tabPage3);
                    tabPage1.Parent = null;
                    tabPage2.Parent = null;
                    tabPage4.Parent = null;
                }

                a = Convert.ToDouble(txta.Text);
                b = Convert.ToDouble(txtb.Text);
                c = Convert.ToDouble(txtc.Text);
                d = Convert.ToDouble(txtd.Text);

                resul = (a * c) / (b * d);
                lblRes.Text = Convert.ToString(resul);
                lblSigP.Text = "*";

                lblM1.Text = a.ToString();
                lblM2.Text = b.ToString();
                lblM3.Text = c.ToString();
                lblM4.Text = d.ToString();

                lbl2Ma.Text = a.ToString();
                lbl2Mb.Text = b.ToString();
                lbl2Mc.Text = c.ToString();
                lbl2Md.Text = d.ToString();

                r1 = (a * c);
                r2 = (b * d);

                lbl3Mr1.Text = r1.ToString();
                lbl3Mr2.Text = r2.ToString();
            }
        }

        private void btnDiv_Click_1(object sender, EventArgs e)
        {
            if (txta.Text == "" || txtb.Text == "" || txtc.Text == "" || txtd.Text == "")
            {
                MessageBox.Show("No dejes Campos vacios", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (tabPage4.Parent == null)
                {
                    // 0 es el index por la primera pestana
                    tabControl1.TabPages.Insert(0, tabPage4);
                    tabPage1.Parent = null;
                    tabPage2.Parent = null;
                    tabPage3.Parent = null;
                }

                a = Convert.ToDouble(txta.Text);
                b = Convert.ToDouble(txtb.Text);
                c = Convert.ToDouble(txtc.Text);
                d = Convert.ToDouble(txtd.Text);

                resul = (a * d) / (b * c);
                lblRes.Text = Convert.ToString(resul);
                lblSigP.Text = "÷";

                lblD1.Text = a.ToString();
                lblD2.Text = b.ToString();
                lblD3.Text = c.ToString();
                lblD4.Text = d.ToString();

                lbl2Da.Text = a.ToString();
                lbl2Db.Text = b.ToString();
                lbl2Dc.Text = c.ToString();
                lbl2Dd.Text = d.ToString();

                r1 = (a * d);
                r2 = (b * c);

                lbl3Dr1.Text = r1.ToString();
                lbl3Dr2.Text = r2.ToString();
            }
        }
    }
}
