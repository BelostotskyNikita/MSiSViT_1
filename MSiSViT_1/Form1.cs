namespace MSiSViT_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Parse_Click_1(object sender, EventArgs e)
        {
            var OperandsParsed = Parser.OperandParse(this.richTextBox1.Text);
            var OperatorsParsed = Parser.OperatorParse(this.richTextBox1.Text);

            this.Label_Dictionary.Text = "Eta = " + (OperandsParsed.Count + OperatorsParsed.Count).ToString();
            this.Label_Length.Text = "N = " + (OperandsParsed.Select(t => t.Item2).Sum() + OperatorsParsed.Select(t => t.Item2).Sum()).ToString();
            this.Label_Volume.Text = "V = " + (OperandsParsed.Select(t => t.Item2).Sum() + OperatorsParsed.Select(t => t.Item2).Sum() *
                Math.Log((OperandsParsed.Count + OperatorsParsed.Count),2)).ToString();

            this.dataGridView1.Rows.Clear();
            this.dataGridView2.Rows.Clear();
            int sum1 = 0; int sum2 = 0; 
            foreach (var operand in OperandsParsed)
            {
                this.dataGridView1.Rows.Add(this.dataGridView1.Rows.Count, operand.Item1, operand.Item2);
                sum1 += operand.Item2;
            }
            this.dataGridView1.Rows.Add(this.dataGridView1.Rows.Count, "Общее кольичество операндов", sum1);
            foreach (var _operator in OperatorsParsed)
            {
                this.dataGridView2.Rows.Add(this.dataGridView2.Rows.Count, _operator.Item1, _operator.Item2);
                sum2+= _operator.Item2;
            }
            this.dataGridView2.Rows.Add(this.dataGridView2.Rows.Count, "Общее кольичество операторов", sum2);
        }

        private void Button_Test_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = File.ReadAllText("test.txt");
            Button_Parse_Click_1(sender, e);
        
        }


    }
}
