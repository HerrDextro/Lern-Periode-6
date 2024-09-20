using System.Linq.Expressions;

namespace Calculator_WInform
{
    public partial class Form1 : Form
    {

        string LHO_s; //operands, L meaning left number and R meaning right one
        string RHO_s;
        int LHO; //the numbers (operands) to be converted to int
        int RHO;

        int result; //result of calculation in int
        string resultString; //for displaying the result int as a string
        string selectedOperator; //for showing the program what operator is being used





        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)// "%"
        {
            //no idea what the button even does
        }

        private void button2_Click(object sender, EventArgs e)// "CE" clear enty
        {
            textBox1.Text = string.Empty; //Clears everything in the textbox
            // still needs to clear the operation memory
            // needs to be converted to only clear entry once multiline has been sorted out
        }

        private void button3_Click(object sender, EventArgs e)// "C"
        {
            textBox1.Text = string.Empty; //Clears everything in the textbox
        }

        private void button4_Click(object sender, EventArgs e)// "Backspace"
        {

            if (!string.IsNullOrEmpty(textBox1.Text))
            {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void button5_Click(object sender, EventArgs e)// "1/x"
        {
            //1 divided by whatever number is input
        }

        private void button6_Click(object sender, EventArgs e)// "x sq"
        {

        }

        private void button7_Click(object sender, EventArgs e) // "x√( 0 )"
        {

        }

        private void button8_Click(object sender, EventArgs e)// "/"
        {
            selectedOperator = "/";
            LHO_s = textBox1.Text;
            LHO = Int32.Parse(LHO_s); // Left Hand Operand is stored
            textBox1.Clear();
        }

        private void button9_Click(object sender, EventArgs e)// "7"
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button10_Click(object sender, EventArgs e)// "8"
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button11_Click(object sender, EventArgs e)// "9"
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button12_Click(object sender, EventArgs e)// "*"
        {

        }

        private void button13_Click(object sender, EventArgs e)// "4"
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button14_Click(object sender, EventArgs e)// "5"
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button15_Click(object sender, EventArgs e)// "6"
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button16_Click(object sender, EventArgs e)// "-"
        {

        }

        private void button17_Click(object sender, EventArgs e)// "1"
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button18_Click(object sender, EventArgs e)// "2"
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button19_Click(object sender, EventArgs e)// "3"
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button20_Click(object sender, EventArgs e)// "+"
        {

        }

        private void button21_Click(object sender, EventArgs e)// "neg (-)"
        {

        }

        private void button22_Click(object sender, EventArgs e)// "0"
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button23_Click(object sender, EventArgs e)// "."
        {

        }

        private void button24_Click(object sender, EventArgs e)// "="
        {
            //storing the RHO in int
            RHO_s = textBox1.Text;
            RHO = Int32.Parse(RHO_s); //converting RHO to int
            textBox1.Clear();

            switch (selectedOperator) //switch for the mathematical operations of every button (just the simple ones for now)
            {
                case "/":
                    result = LHO / RHO;                                      
                    break;
                case "*":

                    break;
                case "-":

                    break;
                case "+":

                    break;
                case "=":

                    break;
                default:
                    MessageBox.Show("Please select a valid operation.");
                    return;
            }

            resultString = result.ToString(); 
            textBox1.Text = resultString;  //displaying the result AFTER doing the calculation so it doesnt KEEP showing 0!!!!!!


        }

        private void textBox1_TextChanged(object sender, EventArgs e)//just textbox
        {
            
        }
    }
}

