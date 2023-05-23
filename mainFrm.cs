using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtropatBaseMathCalc
{
    public partial class mainFrm : Form
    {
        public mainFrm()
        {
            InitializeComponent();
        }
    

        private void radRectangle_CheckedChanged(object sender, EventArgs e)
        {
            lblA.Text = "a:";
            lblB.Text = "b:";
            lblC.Text = "c:";
            picBox.Image = new Bitmap(AtropatBaseMathCalc.Properties.Resources.box_calc_r2_removebg_preview_removebg_preview);
            if (radRectangle.Checked && radVolume.Checked)
            {
                lblB.Visible = true;
                txtB.Visible = true;
                lblC.Visible = true;
                txtC.Visible = true;
                
            }
            else if (radRectangle.Checked && !radVolume.Checked)
            {
                lblC.Visible = false;
                txtC.Visible = false;
                lblDescription.Text = "Area = a * b (a,b are sides)\nPerimeter = 2(a + b) (a,b are sides)\nVolume = a * b * c (a,b are sides c is height)";
            }
            txtA.Focus();
        }

        private void radCircle_CheckedChanged(object sender, EventArgs e)
        {
            picBox.Image = new Bitmap(AtropatBaseMathCalc.Properties.Resources.sphere_r2);
            if (radCircle.Checked)
            {
                lblB.Visible = false;
                txtB.Visible = false;
                lblC.Visible = false;
                txtC.Visible = false;
                lblDescription.Text = "Area = (r^2)(3.14) (r is radius)\nPerimeter = (2r)(3.14) (r is radius)\nVolume = (4/3)(r^3)(3.14) (r is radius)";
                lblA.Text = "r:";
            }
            else
            {
                lblB.Visible = true;
                txtB.Visible = true;
            }
            txtA.Focus();
        }

        private void radPeri_CheckedChanged(object sender, EventArgs e)
        {
            if (radPeri.Checked && radTriangle.Checked)
            {
                lblC.Visible = true;
                txtC.Visible = true;
                lblC.Text = "c:";
            }
            else
            {
                lblC.Visible = false;
                txtC.Visible = false;
            }
            txtA.Focus();
        }

        private void radVolume_CheckedChanged(object sender, EventArgs e)
        {
            if (radVolume.Checked && !radCircle.Checked)
            {
                lblC.Visible = true;
                txtC.Visible = true;
            }
            if (radTriangle.Checked)
            {
                lblC.Text = "l:";
            }
            txtA.Focus();
        }

        private void radTriangle_CheckedChanged(object sender, EventArgs e)
        {
            picBox.Image = new Bitmap(AtropatBaseMathCalc.Properties.Resources.triangular_prism_right_removebg_preview_removebg_preview);
            if ((radPeri.Checked && radTriangle.Checked))
            {
                lblC.Visible = true;
                txtC.Visible = true;
                lblC.Text = "c:";
            }
            else if (radTriangle.Checked && radVolume.Checked)
            {
                lblC.Visible = true;
                txtC.Visible = true;
                lblC.Text = "l:";
            }
            if (radTriangle.Checked)
            {
                lblDescription.Text = "Area = (a*b)/2 (a is base, b is height)\nPerimeter = a + b + c (a,b,c are sides)\nVolume = (a*b*c)/2 (a is base, b is height, c is length)";
                lblA.Text = "b:";
                lblB.Text = "h:";
            }
            txtA.Focus();

        }

        private void mainFrm_Load(object sender, EventArgs e)
        {
            radRectangle.Checked = true;
            radArea.Checked = true;
            lblDescription.Text = "Area = a * b (a,b are sides)\nPerimeter = 2(a + b) (a,b are sides)\nVolume = a * b * c (a,b are sides c is height)";
            txtA.Focus();
            
        }

        private void radArea_CheckedChanged(object sender, EventArgs e)
        {
            if (radArea.Checked && !radCircle.Checked)
            {
                lblC.Visible = false;
                txtC.Visible = false;
            }
            txtA.Focus();
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            lblErr.Visible = false;
            result();
           
        }
        bool isTriangle(double a, double b, double c)
        {
            if (!(a + b <= c || a + c <= b || b + c <= a))
            {
                return true;
            }
            return false;


        }
        void result()
        {

            var shape = grBoxShapes.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            var calc = grBoxCalc.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            int x = getRad(shape, calc);
            if (isValid())
            {
                switch (x) // 0 rect, 1 circle, 2 tri
                {
                    case 0:
                        txtRes.Text = calcArea(0).ToString();
                        break;
                    case 1:
                        txtRes.Text = calcPeri(0).ToString();
                        break;
                    case 2:
                        txtRes.Text = calcVolume(0).ToString();
                        break;
                    case 3:
                        txtRes.Text = calcArea(1).ToString();
                        break;
                    case 4:
                        txtRes.Text = calcPeri(1).ToString();
                        break;
                    case 5:
                        txtRes.Text = calcVolume(1).ToString();
                        break;
                    case 6:
                        txtRes.Text = calcArea(2).ToString();
                        break;
                    case 7:
                        if (calcPeri(2) == -1)
                        {
                            txtRes.Text = string.Empty;
                            lblErr.Visible = true;
                            break;
                        }
                        txtRes.Text = calcPeri(2).ToString();
                        break;
                    case 8:
                        txtRes.Text = calcVolume(2).ToString();
                        break;
                    default:
                        break;
                }
                clearAll();
            }
            else
            {
                MessageBox.Show("Please fill a, b, and c boxes with digits.","");
            }
            
        
        }
        private int getRad(RadioButton rb1,RadioButton rb2)
        {
            if (rb1 == radRectangle)
            {
                if (rb2 == radArea)
                {
                    return 0;
                }
                else if (rb2 == radPeri)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            else if (rb1 == radCircle)
            {
                if (rb2 == radArea)
                {
                    return 3;
                }
                else if (rb2 == radPeri)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
            else
            {
                if (rb2 == radArea)
                {
                    return 6;
                }
                else if (rb2 == radPeri)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
            
        }
        private double calcArea(int shape)
        {
            switch (shape)
            {
                case 0:
                    double a = Convert.ToDouble(txtA.Text);
                    double b = Convert.ToDouble(txtB.Text);
                    return a * b;
                    break;
                case 1:
                    double radius = Convert.ToDouble(txtA.Text);
                    return (Math.PI) * (sqrOfNum(radius, 2));
                case 2:
                    double bas = Convert.ToDouble(txtA.Text);
                    double height = Convert.ToDouble(txtB.Text);
                    return (0.5) * (bas * height);
                default:
                    return -1;
                    break;
            }
            
            
        }
        private double calcPeri(int shape)
        {
            switch (shape)
            {
                case 0:
                    double a = Convert.ToDouble(txtA.Text);
                    double b = Convert.ToDouble(txtB.Text);
                    return 2 * (a + b);
                    break;
                case 1:
                    double radius = Convert.ToDouble(txtA.Text);
                    return (Math.PI) * (radius * 2);
                case 2:
                    double s1 = Convert.ToDouble(txtA.Text);
                    double s2 = Convert.ToDouble(txtB.Text);
                    double s3 = Convert.ToDouble(txtC.Text);
                    if (isTriangle(s1,s2,s3))
                    {
                        return (s1 + s2 + s3);
                    }
                    return -1;
                    break;
                default:
                    return -1;
                    break;
            }


        }
        private double calcVolume(int shape)
        {
            switch (shape)
            {
                case 0:
                    double a = Convert.ToDouble(txtA.Text);
                    double b = Convert.ToDouble(txtB.Text);
                    double c = Convert.ToDouble(txtC.Text);
                    return (a * b * c);
                    break;
                case 1:
                    double radius = Convert.ToDouble(txtA.Text);
                    return (Math.PI) * (sqrOfNum(radius, 3)) * (4.0 / 3.0);
                case 2:
                    double bas = Convert.ToDouble(txtA.Text);
                    double height = Convert.ToDouble(txtB.Text);
                    double length = Convert.ToDouble(txtC.Text);
                    return (0.5) * (height * bas * length);
                default:
                    return -1;
                    break;
            }


        }
        private double sqrOfNum(double x,int a)
        {
            double res = 1;
            for (int i = 0; i < a; i++)
            {
                res *= x;
            }

            return res;
        }
        private void clearAll()
        {
            txtA.Text = string.Empty;
            txtB.Text = string.Empty;
            txtC.Text = string.Empty;
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            string st = "0123456789" + (char)8;
            if (e.KeyChar == (char)Keys.Enter)
            {
                result();
            }
            else if (st.IndexOf(e.KeyChar) == -1)
            {
                MessageBox.Show("Please enter digits only","Warning!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            string st = "0123456789" + (char)8;
            if (e.KeyChar == (char)Keys.Enter)
            {
                result();
            }
            else if (st.IndexOf(e.KeyChar) == -1)
            {
                MessageBox.Show("Please enter digits only", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            string st = "0123456789" + (char)8 + (char)Keys.Enter;
            if (e.KeyChar == (char)Keys.Enter)
            {
                result();
            }
            else if (st.IndexOf(e.KeyChar) == -1)
            {
                MessageBox.Show("Please enter digits only", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
            
        }

        private bool isValid()
        {
            if (txtA.Visible == true && txtB.Visible == true && txtC.Visible == true)
            {
                if (txtA.Text != string.Empty && txtB.Text != string.Empty && txtC.Text != string.Empty)
                {
                    return true;
                }
                return false;
            }
            else if (txtA.Visible == true && txtB.Visible == true)
            {
                if (txtA.Text != string.Empty && txtB.Text != string.Empty)
                {
                    return true;
                }
                return false;
            }
            else if (txtA.Visible == true)
            {
                if (txtA.Text != string.Empty)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}
