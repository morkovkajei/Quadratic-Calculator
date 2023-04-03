using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AlgebraFuckYou
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            //Переменные
            double x1, x2, a, b, c, D;

            //Получаем данные из TextBox
            //Примечания : b = p , c = q
            a = Convert.ToDouble(textA.Text);
            b = Convert.ToDouble(textB.Text);
            c = Convert.ToDouble(textC.Text);



            //Ищем дискриминант
            D = b*b + (-4 * a * c) ;

            // На основании дискриминанта получаем ответ и выводим его
            if (D < 0)
            {
                // Эта штука просто выводит по центру сколько корней
                label5.Text = "Нет решения . Ни одного ";

                // Это болеее подробное решение дискриминанта
                label7.Text = "D = " + D;
                label8.Text = "D = " + b * b + " + " + (-4 * a * c);
                label9.Text = "D = " + b +"*"+ b + " + " + "(-4 *" +a +  "*" + c+")";

            }
            else if (D == 0) 
            {
                // Эта штука просто выводит по центру сколько корней
                label5.Text = "Есть только одно решение";

                x1 = (-(b) + Math.Sqrt(D)) / (2 * a);
                x2 = (-(b) - Math.Sqrt(D)) / (2 * a);

                // Это у нас более подробное решение по формуле и его вывод
                //label10.Text = "( - (" + b + ")" + "√"+ "D" + "/"+ "(2 *"+ a;
                //label11.Text = "( - (" + b + "-" + ")" + "√" + D + "/"+D + "/" + "(2 *" + a;

                //Это тупой вывод в label
                label1.Text = Convert.ToString("X1:" + x1);
                label2.Text = Convert.ToString("X2:" + x2);

                // Это болеее подробное решение дискриминанта
                label7.Text = "D = " + D;
                label8.Text = "D = " + b * b + " + " + (-4 * a * c);
                label9.Text = "D = " + b + "*" + b + " + " + "(-4 *" + a + "*" + c + ")";

            }
            else
            {
                // Эта штука просто выводит по центру сколько корней
                label5.Text = "Имеется 2 решения";

                x1 = (-(b) + Math.Sqrt(D)) / (2 * a);
                x2 = (-(b) - Math.Sqrt(D)) / (2 * a);

                // Это у нас более подробное решение по формуле и его вывод
                //label10.Text = "( - (" + b + ")" + "√" + "D" + "/" + "(2 *" + a;
                //label11.Text = "( - (" + b + "-" + ")" + "√" + D + "/" + D + "/" + "(2 *" + a;

                //Это тупой вывод в label
                label1.Text = Convert.ToString("X1:" + x1);
                label2.Text = Convert.ToString("X2:" + x2);

                // Это болеее подробное решение дискриминанта
                label7.Text = "D = " + D;
                label8.Text = "D = " + b * b + " + " + (-4 * a * c);
                label9.Text = "D = " + b + "*" + b + " + " + "(-4 *" + a + "*" + c + ")";
            }
            
            
            
            

            

            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
