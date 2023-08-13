namespace Tarea2
{
    public partial class Form1 : Form
    {
        float result = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void DetectOperation(string operation, float x, float y)
        {
            Operations op = new();

            if (operation == "+")
            {
                result = op.Add(x, y);
            }
            else if (operation == "-")
            {
                result = op.Substract(x, y);
            }
            else if (operation == "*")
            {
                result = op.Multiply(x, y);
            }
            else if (operation == "/")
            {
                result = op.Divide(x, y);
            }
            else
            {
                MessageBox.Show("Operación no válida");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string operation = tbOperator.Text;
            string valueOne = tbValueOne.Text;
            string valueTwo = tbValueTwo.Text;

            if (valueOne == "" || valueTwo == "" || operation == "")
            {
                MessageBox.Show("Faltan datos");
            }
            else
            {
                float x = float.Parse(valueOne);
                float y = float.Parse(valueTwo);

                DetectOperation(operation, x, y);

                tbResult.Text = result.ToString();
            }
        }
    }
}