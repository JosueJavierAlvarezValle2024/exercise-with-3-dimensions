namespace exercise_with_3_dimensions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ShowArrangements()
        {
            
            int[] array1D = { 5, 4, 3, 2, 1 };

            
            int[,] array2D = { { 1, 3, 3 }, { 4, 5, 5 }, { 9, 8, 9 } };

            
            int[,,] array3D = { { { 3, 6 }, { 2, 4 } }, { { 4, 8 }, { 1, 2 } } };

            
            textBox1.AppendText("Array 1D:\r\n");
            for (int i = 0; i < array1D.Length; i++)
            {
                textBox1.AppendText(array1D[i].ToString() + " ");
            }
            textBox1.AppendText("\r\n\r\n");

            
            textBox1.AppendText("Array 2D:\r\n");
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    textBox1.AppendText(array2D[i, j].ToString() + " ");
                }
                textBox1.AppendText("\r\n");
            }
            textBox1.AppendText("\r\n");

            
            textBox1.AppendText("Array 3D:\r\n");
            for (int i = 0; i < array3D.GetLength(0); i++)
            {
                for (int j = 0; j < array3D.GetLength(1); j++)
                {
                    for (int k = 0; k < array3D.GetLength(2); k++)
                    {
                        textBox1.AppendText(array3D[i, j, k].ToString() + " ");
                    }
                    textBox1.AppendText("\r\n");
                }
                textBox1.AppendText("\r\n");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowArrangements();
        }

        

    }
}

