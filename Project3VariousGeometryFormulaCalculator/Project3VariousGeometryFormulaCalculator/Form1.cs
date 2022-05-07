using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3VariousGeometryFormulaCalculator
{
    public partial class FormGeometryCalculator : Form
    {
        public FormGeometryCalculator()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            //Not used
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            radioButtonRectangle.Checked = false;
            radioButtonSquare.Checked = false;
            radioButtonRhombus.Checked = false;
            radioButtonTriangle.Checked = false;
            radioButtonTrapezoid.Checked = false;
            radioButtonCircle.Checked = false;
            radioButtonParallelogram.Checked = false;
            radioButtonKite.Checked = false;
            radioButtonPolygon.Checked = false;
            radioButtonArea.Checked = false;
            radioButtonPerimeter.Checked = false;
            radioButtonAreaPerimeter.Checked = false;
            pictureBoxRectangle.Hide();
            pictureBoxFormulaRectangle.Hide();
            pictureBoxSquare.Hide();
            pictureBoxFormulaSquare.Hide();
            pictureBoxRhombus.Hide();
            pictureBoxFormulaRhombus.Hide();
            pictureBoxTriangle.Hide();
            pictureBoxFormulaTriangle.Hide();
            pictureBoxTrapezoid.Hide();
            pictureBoxFormulaTrapezoid2.Hide();
            pictureBoxCircle.Hide();
            pictureBoxFormulaCircle.Hide();
            pictureBoxParallelogram.Hide();
            pictureBoxFormulaParallelogram.Hide();
            pictureBoxKite.Hide();
            pictureBoxFormulaKite.Hide();
            pictureBoxPolygon.Hide();
            pictureBoxFormulaPolygon.Hide();
            groupBoxInputData.Hide();
            buttonAnswer.Hide();
            buttonCalculate.Show();
            textBoxDisplayInputA.Text = "";
            textBoxDisplayInputB.Text = "";
            textBoxDisplayInputC.Text = "";
            textBoxDisplayInputD.Text = "";
            textBoxDisplayInputE.Text = "";
            labelDisplayResult.Text = "";
        }

        private void buttonCalculate_Click_1(object sender, EventArgs e)
        {
            if (radioButtonRectangle.Checked == true && radioButtonArea.Checked == false && radioButtonPerimeter.Checked == false && radioButtonAreaPerimeter.Checked == false)
            {
                MessageBox.Show("No selection for area and perimeter!", "No Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (radioButtonSquare.Checked == true && radioButtonArea.Checked == false && radioButtonPerimeter.Checked == false && radioButtonAreaPerimeter.Checked == false)
            {
                MessageBox.Show("No selection for area and perimeter!", "No Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (radioButtonRhombus.Checked == true && radioButtonArea.Checked == false && radioButtonPerimeter.Checked == false && radioButtonAreaPerimeter.Checked == false)
            {
                MessageBox.Show("No selection for area and perimeter!", "No Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (radioButtonTriangle.Checked == true && radioButtonArea.Checked == false && radioButtonPerimeter.Checked == false && radioButtonAreaPerimeter.Checked == false)
            {
                MessageBox.Show("No selection for area and perimeter!", "No Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (radioButtonTrapezoid.Checked == true && radioButtonArea.Checked == false && radioButtonPerimeter.Checked == false && radioButtonAreaPerimeter.Checked == false)
            {
                MessageBox.Show("No selection for area and perimeter!", "No Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (radioButtonCircle.Checked == true && radioButtonArea.Checked == false && radioButtonPerimeter.Checked == false && radioButtonAreaPerimeter.Checked == false)
            {
                MessageBox.Show("No selection for area and perimeter!", "No Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (radioButtonParallelogram.Checked == true && radioButtonArea.Checked == false && radioButtonPerimeter.Checked == false && radioButtonAreaPerimeter.Checked == false)
            {
                MessageBox.Show("No selection for area and perimeter!", "No Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (radioButtonKite.Checked == true && radioButtonArea.Checked == false && radioButtonPerimeter.Checked == false && radioButtonAreaPerimeter.Checked == false)
            {
                MessageBox.Show("No selection for area and perimeter!", "No Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (radioButtonPolygon.Checked == true && radioButtonArea.Checked == false && radioButtonPerimeter.Checked == false && radioButtonAreaPerimeter.Checked == false)
            {
                MessageBox.Show("No selection for area and perimeter!", "No Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (radioButtonArea.Checked == true && radioButtonRectangle.Checked == false && radioButtonSquare.Checked == false && radioButtonRhombus.Checked == false && radioButtonTriangle.Checked == false && radioButtonTrapezoid.Checked == false && radioButtonCircle.Checked == false && radioButtonParallelogram.Checked == false && radioButtonKite.Checked == false && radioButtonPolygon.Checked == false)
            {
                MessageBox.Show("Shape is not selected!", "No Selection Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (radioButtonPerimeter.Checked == true && radioButtonRectangle.Checked == false && radioButtonSquare.Checked == false && radioButtonRhombus.Checked == false && radioButtonTriangle.Checked == false && radioButtonTrapezoid.Checked == false && radioButtonCircle.Checked == false && radioButtonParallelogram.Checked == false && radioButtonKite.Checked == false && radioButtonPolygon.Checked == false)
            {
                MessageBox.Show("Shape is not selected!", "No Selection Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (radioButtonAreaPerimeter.Checked == true && radioButtonRectangle.Checked == false && radioButtonSquare.Checked == false && radioButtonRhombus.Checked == false && radioButtonTriangle.Checked == false && radioButtonTrapezoid.Checked == false && radioButtonCircle.Checked == false && radioButtonParallelogram.Checked == false && radioButtonKite.Checked == false && radioButtonPolygon.Checked == false)
            {
                MessageBox.Show("Shape is not selected!", "No Selection Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (radioButtonRectangle.Checked == true && radioButtonArea.Checked == true)
            {
                buttonCalculate.Hide();
                buttonAnswer.Show();
                pictureBoxRectangle.Show();
                pictureBoxFormulaRectangle.Show();
                groupBoxInputData.Show();
                labelInputA.Show();
                labelInputB.Show();
                textBoxDisplayInputA.Show();
                textBoxDisplayInputB.Show();               
            }
            else if (radioButtonRectangle.Checked == true && radioButtonPerimeter.Checked == true)
            {
                buttonCalculate.Hide();
                buttonAnswer.Show();
                pictureBoxRectangle.Show();
                pictureBoxFormulaRectangle.Show();
                groupBoxInputData.Show();
                labelInputA.Show();
                labelInputB.Show();
                textBoxDisplayInputA.Show();
                textBoxDisplayInputB.Show();
            }
            else if(radioButtonRectangle.Checked == true && radioButtonAreaPerimeter.Checked == true)
            {
                buttonCalculate.Hide();
                buttonAnswer.Show();
                pictureBoxRectangle.Show();
                pictureBoxFormulaRectangle.Show();
                groupBoxInputData.Show();
                labelInputA.Show();
                labelInputB.Show();
                textBoxDisplayInputA.Show();
                textBoxDisplayInputB.Show();
            }
            else if (radioButtonSquare.Checked == true && radioButtonArea.Checked == true)
            {
                buttonCalculate.Hide();
                buttonAnswer.Show();
                pictureBoxSquare.Show();
                pictureBoxFormulaSquare.Show();
                groupBoxInputData.Show();
                labelInputA.Show();
                labelInputB.Show();
                textBoxDisplayInputA.Show();
                textBoxDisplayInputB.Show();
            }
            else if (radioButtonSquare.Checked == true && radioButtonPerimeter.Checked == true)
            {
                buttonCalculate.Hide();
                buttonAnswer.Show();
                pictureBoxSquare.Show();
                pictureBoxFormulaSquare.Show();
                groupBoxInputData.Show();
                labelInputA.Show();
                labelInputB.Show();
                textBoxDisplayInputA.Show();
                textBoxDisplayInputB.Show();
            }
            else if (radioButtonSquare.Checked == true && radioButtonAreaPerimeter.Checked == true)
            {
                buttonCalculate.Hide();
                buttonAnswer.Show();
                pictureBoxSquare.Show();
                pictureBoxFormulaSquare.Show();
                groupBoxInputData.Show();
                labelInputA.Show();
                labelInputB.Show();
                textBoxDisplayInputA.Show();
                textBoxDisplayInputB.Show();
            }
            else if (radioButtonRhombus.Checked == true && radioButtonArea.Checked == true)
            {
                buttonCalculate.Hide();
                buttonAnswer.Show();
                pictureBoxRhombus.Show();
                pictureBoxFormulaRhombus.Show();
                groupBoxInputData.Show();
                labelInputA.Show();
                labelInputB.Show();
                textBoxDisplayInputA.Show();
                textBoxDisplayInputB.Show();
            }
            else if (radioButtonRhombus.Checked == true && radioButtonPerimeter.Checked == true)
            {
                buttonCalculate.Hide();
                buttonAnswer.Show();
                pictureBoxRhombus.Show();
                pictureBoxFormulaRhombus.Show();
                groupBoxInputData.Show();
                labelInputC.Show();
                textBoxDisplayInputC.Show();
            }
            else if (radioButtonRhombus.Checked == true && radioButtonAreaPerimeter.Checked == true)
            {
                buttonCalculate.Hide();
                buttonAnswer.Show();
                pictureBoxRhombus.Show();
                pictureBoxFormulaRhombus.Show();
                groupBoxInputData.Show();
                labelInputC.Show();
                textBoxDisplayInputC.Show();
                labelInputA.Show();
                labelInputB.Show();
                textBoxDisplayInputA.Show();
                textBoxDisplayInputB.Show();
            }
            else if (radioButtonTriangle.Checked == true && radioButtonArea.Checked == true)
            {
                buttonCalculate.Hide();
                buttonAnswer.Show();
                pictureBoxTriangle.Show();
                pictureBoxFormulaTriangle.Show();
                groupBoxInputData.Show();
                labelInputA.Show();
                labelInputB.Show();
                textBoxDisplayInputA.Show();
                textBoxDisplayInputB.Show();
            }
            else if (radioButtonTriangle.Checked == true && radioButtonPerimeter.Checked == true)
            {
                buttonCalculate.Hide();
                buttonAnswer.Show();
                pictureBoxTriangle.Show();
                pictureBoxFormulaTriangle.Show();
                groupBoxInputData.Show();
                labelInputC.Show();
                labelInputB.Show();
                labelInputD.Show();
                textBoxDisplayInputC.Show();
                textBoxDisplayInputD.Show();
                textBoxDisplayInputB.Show();
            }
            else if (radioButtonTriangle.Checked == true && radioButtonAreaPerimeter.Checked == true)
            {
                buttonCalculate.Hide();
                buttonAnswer.Show();
                pictureBoxTriangle.Show();
                pictureBoxFormulaTriangle.Show();
                groupBoxInputData.Show();
                labelInputC.Show();
                textBoxDisplayInputC.Show();
                labelInputA.Show();
                labelInputC.Show();
                labelInputB.Show();
                labelInputD.Show();
                textBoxDisplayInputA.Show();
                textBoxDisplayInputB.Show();
                textBoxDisplayInputC.Show();
                textBoxDisplayInputD.Show();
            }
            else if (radioButtonTrapezoid.Checked == true && radioButtonArea.Checked == true)
            {
                buttonCalculate.Hide();
                buttonAnswer.Show();
                pictureBoxTrapezoid.Show();
                pictureBoxFormulaTrapezoid2.Show();
                groupBoxInputData.Show();
                labelInputA.Show();
                labelInputB.Show();
                labelInputC.Show();
                textBoxDisplayInputA.Show();
                textBoxDisplayInputB.Show();
                textBoxDisplayInputC.Show();
            }
            else if (radioButtonTrapezoid.Checked == true && radioButtonPerimeter.Checked == true)
            {
                buttonCalculate.Hide();
                buttonAnswer.Show();
                pictureBoxTrapezoid.Show();
                pictureBoxFormulaTrapezoid2.Show();
                groupBoxInputData.Show();
                labelInputA.Show();
                labelInputB.Show();
                labelInputD.Show();
                labelInputE.Show();
                textBoxDisplayInputD.Show();
                textBoxDisplayInputB.Show();
                textBoxDisplayInputA.Show();
                textBoxDisplayInputE.Show();
            }
            else if (radioButtonTrapezoid.Checked == true && radioButtonAreaPerimeter.Checked == true)
            {
                buttonCalculate.Hide();
                buttonAnswer.Show();
                pictureBoxTrapezoid.Show();
                pictureBoxFormulaTrapezoid2.Show();
                groupBoxInputData.Show();
                labelInputC.Show();
                textBoxDisplayInputC.Show();
                labelInputA.Show();
                labelInputC.Show();
                labelInputB.Show();
                labelInputD.Show();
                labelInputE.Show();
                textBoxDisplayInputA.Show();
                textBoxDisplayInputB.Show();
                textBoxDisplayInputC.Show();
                textBoxDisplayInputD.Show();
                textBoxDisplayInputE.Show();
            }
            else if (radioButtonCircle.Checked == true && radioButtonArea.Checked == true)
            {
                buttonCalculate.Hide();
                buttonAnswer.Show();
                pictureBoxCircle.Show();
                pictureBoxFormulaCircle.Show();
                groupBoxInputData.Show();
                labelInputA.Show();
                textBoxDisplayInputA.Show();
            }
            else if (radioButtonCircle.Checked == true && radioButtonPerimeter.Checked == true)
            {
                buttonCalculate.Hide();
                buttonAnswer.Show();
                pictureBoxCircle.Show();
                pictureBoxFormulaCircle.Show();
                groupBoxInputData.Show();
                labelInputA.Show();
                textBoxDisplayInputA.Show();
            }
            else if (radioButtonCircle.Checked == true && radioButtonAreaPerimeter.Checked == true)
            {
                buttonCalculate.Hide();
                buttonAnswer.Show();
                pictureBoxCircle.Show();
                pictureBoxFormulaCircle.Show();
                groupBoxInputData.Show();
                labelInputA.Show();
                textBoxDisplayInputA.Show();
            }
            else if (radioButtonParallelogram.Checked == true && radioButtonArea.Checked == true)
            {
                buttonCalculate.Hide();
                buttonAnswer.Show();
                pictureBoxParallelogram.Show();
                pictureBoxFormulaParallelogram.Show();
                groupBoxInputData.Show();
                labelInputA.Show();
                labelInputB.Show();
                textBoxDisplayInputA.Show();
                textBoxDisplayInputB.Show();
            }
            else if (radioButtonParallelogram.Checked == true && radioButtonPerimeter.Checked == true)
            {
                buttonCalculate.Hide();
                buttonAnswer.Show();
                pictureBoxParallelogram.Show();
                pictureBoxFormulaParallelogram.Show();
                groupBoxInputData.Show();
                labelInputB.Show();
                labelInputC.Show();
                textBoxDisplayInputB.Show();
                textBoxDisplayInputC.Show();
            }
            else if (radioButtonParallelogram.Checked == true && radioButtonAreaPerimeter.Checked == true)
            {
                buttonCalculate.Hide();
                buttonAnswer.Show();
                pictureBoxParallelogram.Show();
                pictureBoxFormulaParallelogram.Show();
                groupBoxInputData.Show();
                labelInputA.Show();
                labelInputB.Show();
                labelInputC.Show();
                textBoxDisplayInputC.Show();
                textBoxDisplayInputB.Show();
                textBoxDisplayInputA.Show();
            }
            else if (radioButtonKite.Checked == true && radioButtonArea.Checked == true)
            {
                buttonCalculate.Hide();
                buttonAnswer.Show();
                pictureBoxKite.Show();
                pictureBoxFormulaKite.Show();
                groupBoxInputData.Show();
                labelInputA.Show();
                labelInputB.Show();
                textBoxDisplayInputA.Show();
                textBoxDisplayInputB.Show();
            }
            else if (radioButtonKite.Checked == true && radioButtonPerimeter.Checked == true)
            {
                buttonCalculate.Hide();
                buttonAnswer.Show();
                pictureBoxKite.Show();
                pictureBoxFormulaKite.Show();
                groupBoxInputData.Show();
                labelInputD.Show();
                labelInputC.Show();
                textBoxDisplayInputD.Show();
                textBoxDisplayInputC.Show();
            }
            else if (radioButtonKite.Checked == true && radioButtonAreaPerimeter.Checked == true)
            {
                buttonCalculate.Hide();
                buttonAnswer.Show();
                pictureBoxKite.Show();
                pictureBoxFormulaKite.Show();
                groupBoxInputData.Show();
                labelInputA.Show();
                labelInputB.Show();
                labelInputC.Show();
                labelInputD.Show();
                textBoxDisplayInputC.Show();
                textBoxDisplayInputB.Show();
                textBoxDisplayInputA.Show();
                textBoxDisplayInputD.Show();
            }
            else if (radioButtonPolygon.Checked == true && radioButtonArea.Checked == true)
            {
                buttonCalculate.Hide();
                buttonAnswer.Show();
                pictureBoxPolygon.Show();
                pictureBoxFormulaPolygon.Show();
                groupBoxInputData.Show();
                labelInputA.Show();
                labelInputB.Show();
                labelInputC.Show();
                textBoxDisplayInputA.Show();
                textBoxDisplayInputB.Show();
                textBoxDisplayInputC.Show();
            }
            else if (radioButtonPolygon.Checked == true && radioButtonPerimeter.Checked == true)
            {
                buttonCalculate.Hide();
                buttonAnswer.Show();
                pictureBoxPolygon.Show();
                pictureBoxFormulaPolygon.Show();
                groupBoxInputData.Show();
                labelInputA.Show();
                labelInputB.Show();
                labelInputC.Show();
                textBoxDisplayInputA.Show();
                textBoxDisplayInputB.Show();
                textBoxDisplayInputC.Show();
            }
            else if (radioButtonPolygon.Checked == true && radioButtonAreaPerimeter.Checked == true)
            {
                buttonCalculate.Hide();
                buttonAnswer.Show();
                pictureBoxPolygon.Show();
                pictureBoxFormulaPolygon.Show();
                groupBoxInputData.Show();
                labelInputA.Show();
                labelInputB.Show();
                labelInputC.Show();
                textBoxDisplayInputA.Show();
                textBoxDisplayInputB.Show();
                textBoxDisplayInputC.Show();
            }

        }

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            if (radioButtonRectangle.Checked == true && radioButtonArea.Checked == true)
            {
                double VarAreaA = 0, VarAreaB = 0;
                try
                {
                    VarAreaA = Convert.ToDouble(textBoxDisplayInputA.Text);
                }
                catch
                {
                    MessageBox.Show("The [input A] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input A", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    VarAreaB = Convert.ToDouble(textBoxDisplayInputB.Text);
                }
                catch
                {
                    MessageBox.Show("The [input B] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input B", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (VarAreaA != 0 && VarAreaB != 0)
                {
                    double VarArea = VarAreaA * VarAreaB;
                    labelDisplayResult.Text = "The result of the calculation for the area of a rectangle is " + VarArea;
                }
            }
            else if (radioButtonRectangle.Checked == true && radioButtonPerimeter.Checked == true)
            {
                double VarPerimeterA = 0;
                double VarPerimeterB = 0;
                try
                {
                    VarPerimeterA = Convert.ToDouble(textBoxDisplayInputA.Text);
                }
                catch
                {
                    MessageBox.Show("The [input A] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input A", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    VarPerimeterB = Convert.ToDouble(textBoxDisplayInputB.Text);
                }
                catch
                {
                    MessageBox.Show("The [input B] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input B", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (VarPerimeterA != 0 && VarPerimeterB != 0)
                {
                    double VarPerimeter = (VarPerimeterA * 2) + (VarPerimeterB * 2);
                    labelDisplayResult.Text = "The result of the calculation for the perimeter of a rectangle is " + VarPerimeter;
                }
            }
            else if (radioButtonRectangle.Checked == true && radioButtonAreaPerimeter.Checked == true)
            {
                double VarAreaA = 0, VarAreaB = 0;
                try
                {
                    VarAreaA = Convert.ToDouble(textBoxDisplayInputA.Text);
                }
                catch
                {
                    MessageBox.Show("The [input A] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input A", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    VarAreaB = Convert.ToDouble(textBoxDisplayInputB.Text);
                }
                catch
                {
                    MessageBox.Show("The [input B] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input B", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                double VarPerimeterA = 0;
                double VarPerimeterB = 0;
                try
                {
                    VarPerimeterA = Convert.ToDouble(textBoxDisplayInputA.Text);
                }
                catch
                {
                    MessageBox.Show("The [input A] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input A", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    VarPerimeterB = Convert.ToDouble(textBoxDisplayInputB.Text);
                }
                catch
                {
                    MessageBox.Show("The [input B] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input B", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (VarAreaA != 0 && VarAreaB != 0 && VarPerimeterA != 0 && VarPerimeterB != 0)
                {
                    double VarArea = VarAreaA * VarAreaB;
                    double VarPerimeter = (VarPerimeterA * 2) + (VarPerimeterB * 2);
                    labelDisplayResult.Text = "The result of the calculation for the area of a rectangle is " + VarArea + " and its perimeter is " + VarPerimeter;
                }

            }
            else if (radioButtonSquare.Checked == true && radioButtonArea.Checked == true)
            {
                double VarAreaA = 0, VarAreaB = 0;
                try
                {
                    VarAreaA = Convert.ToDouble(textBoxDisplayInputA.Text);
                }
                catch
                {
                    MessageBox.Show("The [input A] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input A", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    VarAreaB = Convert.ToDouble(textBoxDisplayInputB.Text);
                }
                catch
                {
                    MessageBox.Show("The [input B] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input B", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (VarAreaA != 0 && VarAreaB != 0)
                {
                    double VarArea = VarAreaA * VarAreaB;
                    labelDisplayResult.Text = "The result of the calculation for the area of a Square is " + VarArea;
                }

            }
            else if (radioButtonSquare.Checked == true && radioButtonPerimeter.Checked == true)
            {
                double VarPerimeterA = 0;
                double VarPerimeterB = 0;
                try
                {
                    VarPerimeterA = Convert.ToDouble(textBoxDisplayInputA.Text);
                }
                catch
                {
                    MessageBox.Show("The [input A] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input A", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    VarPerimeterB = Convert.ToDouble(textBoxDisplayInputB.Text);
                }
                catch
                {
                    MessageBox.Show("The [input B] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input B", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (VarPerimeterA != 0 && VarPerimeterB != 0)
                {
                    double VarPerimeter = (VarPerimeterA * 2) + (VarPerimeterB * 2);
                    labelDisplayResult.Text = "The result of the calculation for the perimeter of a Square is " + VarPerimeter;
                }
            }
            else if (radioButtonSquare.Checked == true && radioButtonAreaPerimeter.Checked == true)
            {
                double VarAreaA = 0, VarAreaB = 0;
                try
                {
                    VarAreaA = Convert.ToDouble(textBoxDisplayInputA.Text);
                }
                catch
                {
                    MessageBox.Show("The [input A] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input A", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    VarAreaB = Convert.ToDouble(textBoxDisplayInputB.Text);
                }
                catch
                {
                    MessageBox.Show("The [input B] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input B", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                double VarPerimeterA = 0;
                double VarPerimeterB = 0;
                try
                {
                    VarPerimeterA = Convert.ToDouble(textBoxDisplayInputA.Text);
                }
                catch
                {
                    MessageBox.Show("The [input A] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input A", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    VarPerimeterB = Convert.ToDouble(textBoxDisplayInputB.Text);
                }
                catch
                {
                    MessageBox.Show("The [input B] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input B", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (VarAreaA != 0 && VarAreaB != 0 && VarPerimeterA != 0 && VarPerimeterB != 0)
                {
                    double VarArea = VarAreaA * VarAreaB;
                    double VarPerimeter = (VarPerimeterA * 2) + (VarPerimeterB * 2);
                    labelDisplayResult.Text = "The result of the calculation for the area of a Square is " + VarArea + " and its perimeter is " + VarPerimeter;
                }
            }
            else if (radioButtonRhombus.Checked == true && radioButtonArea.Checked == true)
            {
                double VarAreaA = 0;
                double VarAreaB = 0;
                try
                {
                    VarAreaA = Convert.ToDouble(textBoxDisplayInputA.Text);
                }
                catch
                {
                    MessageBox.Show("The [input A] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input A", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    VarAreaB = Convert.ToDouble(textBoxDisplayInputB.Text);
                }
                catch
                {
                    MessageBox.Show("The [input B] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input B", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (VarAreaA != 0 && VarAreaB != 0)
                {
                    double VarArea = (VarAreaA * VarAreaB) / 2;
                    labelDisplayResult.Text = "The result of the calculation for the area of a Rhombus is " + VarArea;
                }

            }
            else if (radioButtonRhombus.Checked == true && radioButtonPerimeter.Checked == true)
            {
                double VarPerimeterC = 0;
                try
                {
                    VarPerimeterC = Convert.ToDouble(textBoxDisplayInputC.Text);
                }
                catch
                {
                    MessageBox.Show("The [input c] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input c", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (VarPerimeterC != 0)
                {
                    double VarPerimeter = VarPerimeterC * 2;
                    labelDisplayResult.Text = "The result of the calculation for the perimeter of a Rhombus is " + VarPerimeter;
                }

            }
            else if (radioButtonRhombus.Checked == true && radioButtonAreaPerimeter.Checked == true)
            {
                double VarAreaA = 0;
                double VarAreaB = 0;
                try
                {
                    VarAreaA = Convert.ToDouble(textBoxDisplayInputA.Text);
                }
                catch
                {
                    MessageBox.Show("The [input A] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input A", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    VarAreaB = Convert.ToDouble(textBoxDisplayInputB.Text);
                }
                catch
                {
                    MessageBox.Show("The [input B] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input B", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                double VarPerimeterC = 0;
                try
                {
                    VarPerimeterC = Convert.ToDouble(textBoxDisplayInputC.Text);
                }
                catch
                {
                    MessageBox.Show("The [input c] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input c", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (VarAreaA != 0 && VarAreaB != 0 && VarPerimeterC != 0)
                {
                    double VarArea = (VarAreaA * VarAreaB) / 2;
                    double VarPerimeter = VarPerimeterC * 2;
                    labelDisplayResult.Text = "The result of the calculation for the area of a Rhombus is " + VarArea + " and its perimeter is " + VarPerimeter;
                }

            }
            else if (radioButtonTriangle.Checked == true && radioButtonArea.Checked == true)
            {
                double VarAreaA = 0;
                double VarAreaB = 0;
                try
                {
                    VarAreaA = Convert.ToDouble(textBoxDisplayInputA.Text);
                }
                catch
                {
                    MessageBox.Show("The [input A] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input A", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    VarAreaB = Convert.ToDouble(textBoxDisplayInputB.Text);
                }
                catch
                {
                    MessageBox.Show("The [input B] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input B", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (VarAreaA != 0 && VarAreaB != 0)
                {
                    double VarArea = (VarAreaA * VarAreaB) / 2;
                    labelDisplayResult.Text = "The result of the calculation for the area of a Triangle is " + VarArea;
                }

            }
            else if (radioButtonTriangle.Checked == true && radioButtonPerimeter.Checked == true)
            {
                double VarPerimeterA = 0;
                double VarPerimeterB = 0;
                double VarPerimeterC = 0;
                try
                {
                    VarPerimeterA = Convert.ToDouble(textBoxDisplayInputA.Text);
                }
                catch
                {
                    MessageBox.Show("The [input A] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input A", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    VarPerimeterB = Convert.ToDouble(textBoxDisplayInputB.Text);
                }
                catch
                {
                    MessageBox.Show("The [input B] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input B", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    VarPerimeterC = Convert.ToDouble(textBoxDisplayInputC.Text);
                }
                catch
                {
                    MessageBox.Show("The [input c] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input c", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (VarPerimeterA != 0 && VarPerimeterB != 0 && VarPerimeterC != 0)
                {
                    double VarPerimeter = VarPerimeterC + VarPerimeterA + VarPerimeterB;
                    labelDisplayResult.Text = "The result of the calculation for the perimeter of a Triangle is " + VarPerimeter;
                }

            }
            else if (radioButtonTriangle.Checked == true && radioButtonAreaPerimeter.Checked == true)
            {
                double VarAreaA = 0;
                double VarAreaB = 0;
                try
                {
                    VarAreaA = Convert.ToDouble(textBoxDisplayInputA.Text);
                }
                catch
                {
                    MessageBox.Show("The [input A] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input A", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    VarAreaB = Convert.ToDouble(textBoxDisplayInputB.Text);
                }
                catch
                {
                    MessageBox.Show("The [input B] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input B", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                double VarPerimeterA = 0;
                double VarPerimeterB = 0;
                double VarPerimeterC = 0;
                try
                {
                    VarPerimeterA = Convert.ToDouble(textBoxDisplayInputA.Text);
                }
                catch
                {
                    MessageBox.Show("The [input A] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input A", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    VarPerimeterB = Convert.ToDouble(textBoxDisplayInputB.Text);
                }
                catch
                {
                    MessageBox.Show("The [input B] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input B", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    VarPerimeterC = Convert.ToDouble(textBoxDisplayInputC.Text);
                }
                catch
                {
                    MessageBox.Show("The [input c] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input c", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (VarAreaA != 0 && VarAreaB != 0 && VarPerimeterA != 0 && VarPerimeterB != 0 && VarPerimeterC != 0)
                {
                    double VarArea = (VarAreaA * VarAreaB) / 2;
                    double VarPerimeter = VarPerimeterC + VarPerimeterA + VarPerimeterB;
                    labelDisplayResult.Text = "The result of the calculation for the area of a Triangle is " + VarArea + " and its perimeter is " + VarPerimeter;
                }

            }
            else if (radioButtonTrapezoid.Checked == true && radioButtonArea.Checked == true)
            {
                double VarAreaA = 0;
                double VarAreaB = 0;
                double VarAreaC = 0;
                try
                {
                    VarAreaA = Convert.ToDouble(textBoxDisplayInputA.Text);
                }
                catch 
                {
                    MessageBox.Show("The [input A] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input A", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    VarAreaB = Convert.ToDouble(textBoxDisplayInputB.Text);
                }
                catch
                {
                    MessageBox.Show("The [input B] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input B", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    VarAreaC = Convert.ToDouble(textBoxDisplayInputC.Text);
                }
                catch
                {
                    MessageBox.Show("The [input c] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input c", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }              
                if (VarAreaA != 0 && VarAreaB != 0 && VarAreaC != 0)
                {
                    double VarArea = ((VarAreaA + VarAreaB) * VarAreaC) / 2;
                    labelDisplayResult.Text = "The result of the calculation for the area of a Trapezoid is " + VarArea;
                }
                
            }
            else if (radioButtonTrapezoid.Checked == true && radioButtonPerimeter.Checked == true)
            {
                double VarPerimeterA = 0;
                double VarPerimeterB = 0;
                double VarPerimeterE = 0;
                double VarPerimeterD = 0;
                try
                {
                    VarPerimeterA = Convert.ToDouble(textBoxDisplayInputA.Text);
                }
                catch
                {
                    MessageBox.Show("The [input A] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input A", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    VarPerimeterB = Convert.ToDouble(textBoxDisplayInputB.Text);
                }
                catch
                {
                    MessageBox.Show("The [input B] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input B", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    VarPerimeterE = Convert.ToDouble(textBoxDisplayInputE.Text);
                }
                catch
                {
                    MessageBox.Show("The [input E] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input E", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    VarPerimeterD = Convert.ToDouble(textBoxDisplayInputD.Text);
                }
                catch
                {
                    MessageBox.Show("The [input D] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input D", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (VarPerimeterA != 0 && VarPerimeterB != 0 && VarPerimeterD != 0 && VarPerimeterE != 0)
                {
                    double VarPerimeter = VarPerimeterA + VarPerimeterB + VarPerimeterE + VarPerimeterD;
                    labelDisplayResult.Text = "The result of the calculation for the perimeter of a Trapezoid is " + VarPerimeter;
                }
                
            }
            else if (radioButtonTrapezoid.Checked == true && radioButtonAreaPerimeter.Checked == true)
            {
                double VarAreaA = 0;
                double VarAreaB = 0;
                double VarAreaC = 0;
                try
                {
                    VarAreaA = Convert.ToDouble(textBoxDisplayInputA.Text);
                }
                catch
                {
                    MessageBox.Show("The [input A] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input A", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    VarAreaB = Convert.ToDouble(textBoxDisplayInputB.Text);
                }
                catch
                {
                    MessageBox.Show("The [input B] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input B", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    VarAreaC = Convert.ToDouble(textBoxDisplayInputC.Text);
                }
                catch
                {
                    MessageBox.Show("The [input c] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input c", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                double VarPerimeterA = 0;
                double VarPerimeterB = 0;
                double VarPerimeterE = 0;
                double VarPerimeterD = 0;
                try
                {
                    VarPerimeterA = Convert.ToDouble(textBoxDisplayInputA.Text);
                }
                catch
                {
                    MessageBox.Show("The [input A] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input A", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    VarPerimeterB = Convert.ToDouble(textBoxDisplayInputB.Text);
                }
                catch
                {
                    MessageBox.Show("The [input B] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input B", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    VarPerimeterE = Convert.ToDouble(textBoxDisplayInputE.Text);
                }
                catch
                {
                    MessageBox.Show("The [input c] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input c", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    VarPerimeterD = Convert.ToDouble(textBoxDisplayInputD.Text);
                }
                catch
                {
                    MessageBox.Show("The [input D] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input D", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (VarAreaA != 0 && VarAreaB != 0 && VarAreaC != 0 && VarPerimeterA != 0 && VarPerimeterB != 0 && VarPerimeterD != 0 && VarPerimeterE != 0)
                {
                    double VarArea = ((VarAreaA + VarAreaB) * VarAreaC) / 2;
                    double VarPerimeter = VarPerimeterA + VarPerimeterB + VarPerimeterE + VarPerimeterD;
                    labelDisplayResult.Text = "The result of the calculation for the area of a Trapezoid is " + VarArea + " and its perimeter is " + VarPerimeter;
                }

            }
            else if (radioButtonCircle.Checked == true && radioButtonArea.Checked == true)
            {
                double VarAreaA = 0;
                try
                {
                    VarAreaA = Convert.ToDouble(textBoxDisplayInputA.Text);
                }
                catch
                {
                    MessageBox.Show("The [input A] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input A", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (VarAreaA != 0)
                {
                    double VarPI = 3.14;
                    double VarArea = VarPI * (VarAreaA * VarAreaA);
                    labelDisplayResult.Text = "The result of the calculation for the area of a Circle is " + VarArea;
                }

            }
            else if (radioButtonCircle.Checked == true && radioButtonPerimeter.Checked == true)
            {
                double VarPerimeterA = 0;
                try
                {
                    VarPerimeterA = Convert.ToDouble(textBoxDisplayInputA.Text);
                }
                catch
                {
                    MessageBox.Show("The [input A] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input A", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (VarPerimeterA != 0)
                {
                    double VarPI = 3.14;
                    double VarPerimeter = VarPerimeterA * 2 * VarPI;
                    labelDisplayResult.Text = "The result of the calculation for the perimeter of a Circle is " + VarPerimeter;
                }

            }
            else if (radioButtonCircle.Checked == true && radioButtonAreaPerimeter.Checked == true)
            {
                double VarAreaA = 0;
                try
                {
                    VarAreaA = Convert.ToDouble(textBoxDisplayInputA.Text);
                }
                catch
                {
                    MessageBox.Show("The [input A] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input A", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                double VarPerimeterA = 0;
                try
                {
                    VarPerimeterA = Convert.ToDouble(textBoxDisplayInputA.Text);
                }
                catch
                {
                    MessageBox.Show("The [input A] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input A", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (VarAreaA != 0 && VarPerimeterA != 0)
                {
                    double VarPI = 3.14;
                    double VarArea = VarPI * (VarAreaA * VarAreaA);
                    double VarPerimeter = VarPerimeterA * 2 * VarPI;
                    labelDisplayResult.Text = "The result of the calculation for the area of a Circle is " + VarArea + " and its perimeter is " + VarPerimeter;
                }

            }
            else if (radioButtonParallelogram.Checked == true && radioButtonArea.Checked == true)
            {
                double VarAreaA = 0;
                double VarAreaB = 0;
                try
                {
                    VarAreaA = Convert.ToDouble(textBoxDisplayInputA.Text);
                }
                catch
                {
                    MessageBox.Show("The [input A] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input A", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    VarAreaB = Convert.ToDouble(textBoxDisplayInputB.Text);
                }
                catch
                {
                    MessageBox.Show("The [input B] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input B", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (VarAreaA != 0 && VarAreaB != 0)
                {
                    double VarArea = (VarAreaA * VarAreaB);
                    labelDisplayResult.Text = "The result of the calculation for the area of a Parallelogram is " + VarArea;
                }
                
            }
            else if (radioButtonParallelogram.Checked == true && radioButtonPerimeter.Checked == true)
            {
                double VarPerimeterC = 0;
                double VarPerimeterB = 0;
                try
                {
                    VarPerimeterC = Convert.ToDouble(textBoxDisplayInputC.Text);
                }
                catch
                {
                    MessageBox.Show("The [input c] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input c", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    VarPerimeterB = Convert.ToDouble(textBoxDisplayInputB.Text);
                }
                catch
                {
                    MessageBox.Show("The [input D] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input D", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (VarPerimeterB != 0 && VarPerimeterC != 0)
                {
                    double VarPerimeter = 2 * (VarPerimeterB + 2) * VarPerimeterC;
                    labelDisplayResult.Text = "The result of the calculation for the perimeter of a Parallelogram is " + VarPerimeter;
                }
                
            }
            else if (radioButtonParallelogram.Checked == true && radioButtonAreaPerimeter.Checked == true)
            {
                double VarAreaA = 0;
                double VarAreaB = 0;
                try
                {
                    VarAreaA = Convert.ToDouble(textBoxDisplayInputA.Text);
                }
                catch
                {
                    MessageBox.Show("The [input A] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input A", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    VarAreaB = Convert.ToDouble(textBoxDisplayInputB.Text);
                }
                catch
                {
                    MessageBox.Show("The [input B] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input B", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               

                double VarPerimeterC = 0;
                double VarPerimeterB = 0;
                try
                {
                    VarPerimeterC = Convert.ToDouble(textBoxDisplayInputC.Text);
                }
                catch
                {
                    MessageBox.Show("The [input c] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input c", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    VarPerimeterB = Convert.ToDouble(textBoxDisplayInputB.Text);
                }
                catch
                {
                    MessageBox.Show("The [input D] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input D", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (VarAreaA != 0 && VarAreaB != 0 && VarPerimeterB != 0 && VarPerimeterC != 0)
                {
                    double VarArea = (VarAreaA * VarAreaB);
                    double VarPerimeter = 2 * (VarPerimeterB + 2) * VarPerimeterC;
                    labelDisplayResult.Text = "The result of the calculation for the area of a Parallelogram is " + VarArea + " and its perimeter is " + VarPerimeter;
                }
                
            }
            else if (radioButtonKite.Checked == true && radioButtonArea.Checked == true)
            {
                double VarAreaA = 0;
                double VarAreaB = 0;
                try
                {
                    VarAreaA = Convert.ToDouble(textBoxDisplayInputA.Text);
                }
                catch
                {
                    MessageBox.Show("The [input A] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input A", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    VarAreaB = Convert.ToDouble(textBoxDisplayInputB.Text);
                }
                catch
                {
                    MessageBox.Show("The [input B] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input B", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (VarAreaA != 0 && VarAreaB != 0)
                {
                    double VarArea = (VarAreaA * VarAreaB) / 2;
                    labelDisplayResult.Text = "The result of the calculation for the area of a Kite is " + VarArea;
                }
            
            }
            else if (radioButtonKite.Checked == true && radioButtonPerimeter.Checked == true)
            {
                double VarPerimeterC = 0;
                double VarPerimeterD = 0;
                try
                {
                    VarPerimeterC = Convert.ToDouble(textBoxDisplayInputC.Text);
                }
                catch
                {
                    MessageBox.Show("The [input c] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input c", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    VarPerimeterD = Convert.ToDouble(textBoxDisplayInputD.Text);
                }
                catch
                {
                    MessageBox.Show("The [input D] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input D", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (VarPerimeterC != 0 && VarPerimeterD != 0)
                {
                    double VarPerimeter = 2 * (VarPerimeterC + 2) * VarPerimeterD;
                    labelDisplayResult.Text = "The result of the calculation for the perimeter of a Kite is " + VarPerimeter;
                }
                
            }
            else if (radioButtonKite.Checked == true && radioButtonAreaPerimeter.Checked == true)
            {
                double VarAreaA = 0;
                double VarAreaB = 0;
                try
                {
                    VarAreaA = Convert.ToDouble(textBoxDisplayInputA.Text);
                }
                catch
                {
                    MessageBox.Show("The [input A] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input A", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    VarAreaB = Convert.ToDouble(textBoxDisplayInputB.Text);
                }
                catch
                {
                    MessageBox.Show("The [input B] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input B", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                double VarPerimeterC = 0;
                double VarPerimeterD = 0;
                try
                {
                    VarPerimeterC = Convert.ToDouble(textBoxDisplayInputC.Text);
                }
                catch
                {
                    MessageBox.Show("The [input c] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input c", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    VarPerimeterD = Convert.ToDouble(textBoxDisplayInputD.Text);
                }
                catch
                {
                    MessageBox.Show("The [input D] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input D", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (VarAreaA != 0 && VarAreaB != 0 && VarPerimeterC != 0 && VarPerimeterD != 0)
                {
                    double VarArea = (VarAreaA * VarAreaB) / 2;
                    double VarPerimeter = 2 * (VarPerimeterC + 2) * VarPerimeterD;
                    labelDisplayResult.Text = "The result of the calculation for the area of a Kite is " + VarArea + " and its perimeter is " + VarPerimeter;
                }
                
            }
            else if (radioButtonPolygon.Checked == true && radioButtonArea.Checked == true)
            {
                double VarAreaA = 0;
                double VarAreaB = 0;
                double VarAreaC = 0;
                try
                {
                    VarAreaA = Convert.ToDouble(textBoxDisplayInputA.Text);
                }
                catch
                {
                    MessageBox.Show("The [input A] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input A", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    VarAreaB = Convert.ToDouble(textBoxDisplayInputB.Text);
                }
                catch
                {
                    MessageBox.Show("The [input B] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input B", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    VarAreaC = Convert.ToDouble(textBoxDisplayInputC.Text);
                }
                catch
                {
                    MessageBox.Show("The [input c] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input c", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (VarAreaA != 0 && VarAreaB != 0 && VarAreaC != 0)
                {
                    double VarArea = ((VarAreaA * VarAreaC) * VarAreaB) / 2;
                    labelDisplayResult.Text = "The result of the calculation for the area of a Polygon is " + VarArea;
                }

            }
            else if (radioButtonPolygon.Checked == true && radioButtonPerimeter.Checked == true)
            {
                double VarPerimeterC = 0;
                double VarPerimeterA = 0;
                try
                {
                    VarPerimeterC = Convert.ToDouble(textBoxDisplayInputC.Text);
                }
                catch
                {
                    MessageBox.Show("The [input c] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input c", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    VarPerimeterA = Convert.ToDouble(textBoxDisplayInputA.Text);
                }
                catch
                {
                    MessageBox.Show("The [input A] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input A", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                double VarPerimeter = VarPerimeterA * VarPerimeterC;
                labelDisplayResult.Text = "The result of the calculation for the perimeter of a Polygon is " + VarPerimeter;
            }
            else if (radioButtonPolygon.Checked == true && radioButtonAreaPerimeter.Checked == true)
            {
                double VarAreaA = 0;
                double VarAreaB = 0;
                double VarAreaC = 0;
                try
                {
                    VarAreaA = Convert.ToDouble(textBoxDisplayInputA.Text);
                }
                catch
                {
                    MessageBox.Show("The [input A] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input A", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    VarAreaB = Convert.ToDouble(textBoxDisplayInputB.Text);
                }
                catch
                {
                    MessageBox.Show("The [input B] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input B", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    VarAreaC = Convert.ToDouble(textBoxDisplayInputC.Text);
                }
                catch
                {
                    MessageBox.Show("The [input c] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input c", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                double VarPerimeterC = 0;
                double VarPerimeterA = 0;
                try
                {
                    VarPerimeterC = Convert.ToDouble(textBoxDisplayInputC.Text);
                }
                catch
                {
                    MessageBox.Show("The [input c] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input c", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    VarPerimeterA = Convert.ToDouble(textBoxDisplayInputA.Text);
                }
                catch
                {
                    MessageBox.Show("The [input A] field may not be empty! It must also contain a valid data type. No alphanumeric characters are allowed!", "Validation Error - Input A", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (VarAreaA != 0 && VarAreaB != 0 && VarAreaC != 0 && VarPerimeterC != 0 && VarPerimeterA != 0)
                {
                    double VarArea = ((VarAreaA * VarAreaC) * VarAreaB) / 2;
                    double VarPerimeter = VarPerimeterA * VarPerimeterC;
                    labelDisplayResult.Text = "The result of the calculation for the area of a Polygon is " + VarArea + " and its perimeter is " + VarPerimeter;
                }
                
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonRectangle_CheckedChanged(object sender, EventArgs e)
        {
        //Not use

        }
    }
}
