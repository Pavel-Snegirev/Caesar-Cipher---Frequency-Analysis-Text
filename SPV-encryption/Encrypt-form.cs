using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPV_encryption
{
    public partial class Encrypt_form : Form
    {
        public Encrypt_form()
        {
            InitializeComponent();
        }

        string s = ""; // строка выбора шифрования и дешифрования
        string result;  // строка результат шифрования и дешифрования
        uint key; // величина сдвига шифрования(ключь)выбрал имеенно uint так как диапазон числа начинается с 0, стобы не делать доп.проверку на ключ ниже 0.

        
        private void button1_Click(object sender, EventArgs e)  // кнопка очистки формы
        {

            result = ""; //возвращает пустое значение пересменной при очистки форм ввода, иначе данные храняться в памяти и выводятся с последующим результатом.
            richTextBox1.Clear(); //очищает введеные данные для шифрования/дешифрования
            richTextBox2.Clear(); // очищает результат шифрования/дешифрования
            textBox1.Clear();
        }

        private void richTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (char.IsLetter(c))
            {
                e.Handled = true;
            }
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) //ввод данных для шифрования и дешифрования
        {
            s = Convert.ToString(richTextBox1.Text); // вводимые данные коныертируюся в строчные символы
        }


               

        private void textBox1_TextChanged(object sender, EventArgs e) //ввод данных ключа
        {
            while (!uint.TryParse(textBox1.Text, out key))
            {
                textBox1.Clear(); // очищает текст бокс при неправильном вводе.
                break;

            }

            if (key > 32)  //Если величина сдвига больше длины алфавита кирилицы
                key = key % 32;
        }
            
           
       

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) // при вводе ключа в текстбокс запретил на работу клавиши удаления
        {
            if (e.KeyChar == (char)Keys.Back)
                e.Handled = true;
           
        }
                                 

        private void button2_Click(object sender, EventArgs e) // кнопка шифрования, запускает цикл шифроваения
        {
           
            
            for (int i = 0; i < s.Length; i++)//Цикл по каждому символу строки
            {
                
                if (((int)(s[i]) < 1040) || ((int)(s[i]) > 1103)) //Если ввод не кириллица
                result += s[i]; //добавляет пробелы в текст

                if ((Convert.ToInt16(s[i]) >= 1072) && (Convert.ToInt16(s[i]) <= 1103))   //Если буква является строчной
                {
                   
                    if (Convert.ToInt16(s[i]) + key > 1103)    //Если буква, после сдвига выходит за пределы алфавита
                                                               
                        result += Convert.ToChar(Convert.ToInt16(s[i]) + key - 32); //Добавление в строку результатов символ

                    else //Если буква может быть сдвинута в пределах алфавита
                       
                        result += Convert.ToChar(Convert.ToInt16(s[i]) + key);  //Если буква является прописной
                }
               
                if ((Convert.ToInt16(s[i]) >= 1040) && (Convert.ToInt16(s[i]) <= 1071))  //Если буква является прописной
                {
                    
                    if (Convert.ToInt16(s[i]) + key > 1071)  //Если буква, после сдвига выходит за пределы алфавита
                                                             
                        result += Convert.ToChar(Convert.ToInt16(s[i]) + key - 32); //Добавление в строку результатов символ

                    else  //Если буква может быть сдвинута в пределах алфавита
                        
                        result += Convert.ToChar(Convert.ToInt16(s[i]) + key); //Добавление в строку результатов символ
                }
            }
            richTextBox2.Text = Convert.ToString(result);

        }

       

        private void button3_Click(object sender, EventArgs e) // кнопка дешифрования
        {
            for (int i = 0; i < s.Length; i++)
            {
               if (Convert.ToInt16(s[i]) == 32) 
                    result += ' '; // добавляет символ пробела
               
                if ((Convert.ToInt16(s[i]) >= 1072) && (Convert.ToInt16(s[i]) <= 1103))   //Если буква является строчной
                {
                    
                    if (Convert.ToInt16(s[i]) - key < 1072)  //Если буква, после сдвига выходит за пределы алфавита
                                                          
                        result += Convert.ToChar(Convert.ToInt16(s[i]) - key + 32);     //Добавление в строку результатов символ

                    else  //Если буква может быть сдвинута в пределах алфавита
                      
                        result += Convert.ToChar(Convert.ToInt16(s[i]) - key);    //Добавление в строку результатов символ
                }
                //Если буква является прописной
                if ((Convert.ToInt16(s[i]) >= 1040) && (Convert.ToInt16(s[i]) <= 1071))  //Если буква является прописной
                {
                   
                    if (Convert.ToInt16(s[i]) - key < 1040)   //Если буква, после сдвига выходит за пределы алфавита
                                                             
                        result += Convert.ToChar(Convert.ToInt16(s[i]) - key + 32); //Добавление в строку результатов символ

                    else//Если буква может быть сдвинута в пределах алфавита
                       
                        result += Convert.ToChar(Convert.ToInt16(s[i]) - key); //Добавление в строку результатов символ
                }
            }
            richTextBox2.Text = Convert.ToString(result);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            this.Visible = false;
        }
    }
}
