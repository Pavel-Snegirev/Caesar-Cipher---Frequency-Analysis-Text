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
    public partial class frequency_analysis_form : Form
    {
        public frequency_analysis_form()
        {
            InitializeComponent();

        }

        



         private void button2_Click(object sender, EventArgs e) // кнопкой произвожу очистку поля ввода
             {
         richTextBox1.Clear(); 
         string textAnalisys = "";
           }

        private void button1_Click(object sender, EventArgs e) //кнопка Проищвести частотный анализ текста
        {

            string textAnalisys = Convert.ToString(richTextBox1.Text); // переменная для записи данных вводимых с рич.текс.бокс
            ListAnalysisForm ListAnalisys = new ListAnalysisForm(); // объявляем класс о наличии формы, создаем класс в конструкторе, присвоили переменной значение формы
            ListAnalisys.Show();// открываем форму результата частотного анализа
            this.Visible = false;
            string stext;
            int textenter;
            textenter = 10;
            int sizetext, psizetext, i;
            float percent;
            int[] A = new int[76];
            for (i = 0; i < 76; i++)
            {
                A[i] = 0;
            }

            ListAnalisys.label1.Text = "А"; //обрашаемся к публичному label, в дизайнере я изменил значение лейбей с приватного на публичный,это сделал если форма загрузиться не коррекно
            ListAnalisys.label2.Text = "Б";  // 
            ListAnalisys.label3.Text = "В";
            ListAnalisys.label4.Text = "Г";
            ListAnalisys.label5.Text = "Д";
            ListAnalisys.label6.Text = "Е";
            ListAnalisys.label7.Text = "Ё";
            ListAnalisys.label8.Text = "Ж";
            ListAnalisys.label9.Text = "З";
            ListAnalisys.label10.Text = "И";
            ListAnalisys.label11.Text = "Й";
            ListAnalisys.label12.Text = "К";
            ListAnalisys.label13.Text = "Л";
            ListAnalisys.label14.Text = "М";
            ListAnalisys.label15.Text = "Н";
            ListAnalisys.label16.Text = "О";
            ListAnalisys.label17.Text = "П";
            ListAnalisys.label18.Text = "Р";
            ListAnalisys.label19.Text = "С";
            ListAnalisys.label20.Text = "Т";
            ListAnalisys.label21.Text = "У";
            ListAnalisys.label22.Text = "ф";
            ListAnalisys.label23.Text = "Х";
            ListAnalisys.label24.Text = "Ц";
            ListAnalisys.label25.Text = "Ч";
            ListAnalisys.label26.Text = "Ш";
            ListAnalisys.label27.Text = "Щ";
            ListAnalisys.label28.Text = "Ъ";
            ListAnalisys.label29.Text = "Ы";
            ListAnalisys.label30.Text = "Ь";
            ListAnalisys.label31.Text = "Э";
            ListAnalisys.label32.Text = "Ю";
            ListAnalisys.label33.Text = "Я";
            ListAnalisys.label34.Text = ".";
            ListAnalisys.label35.Text = ",";
            ListAnalisys.label36.Text = "-";
            ListAnalisys.label37.Text = "A";
            ListAnalisys.label38.Text = "B";
            ListAnalisys.label39.Text = "C";
            ListAnalisys.label40.Text = "D";
            ListAnalisys.label41.Text = "E";
            ListAnalisys.label42.Text = "F";
            ListAnalisys.label43.Text = "G";
            ListAnalisys.label44.Text = "H";
            ListAnalisys.label45.Text = "I";
            ListAnalisys.label46.Text = "J";
            ListAnalisys.label47.Text = "K";
            ListAnalisys.label48.Text = "L";
            ListAnalisys.label49.Text = "M";
            ListAnalisys.label50.Text = "N";
            ListAnalisys.label51.Text = "O";
            ListAnalisys.label52.Text = "P";
            ListAnalisys.label53.Text = "Q";
            ListAnalisys.label54.Text = "R";
            ListAnalisys.label55.Text = "S";
            ListAnalisys.label56.Text = "T";
            ListAnalisys.label57.Text = "U";
            ListAnalisys.label58.Text = "V";
            ListAnalisys.label59.Text = "W";
            ListAnalisys.label60.Text = "X";
            ListAnalisys.label61.Text = "Y";
            ListAnalisys.label62.Text = "Z";
            ListAnalisys.label63.Text = "~";
            ListAnalisys.label64.Text = "¬";
            ListAnalisys.label65.Text = "¶";
            ListAnalisys.label66.Text = "1";
            ListAnalisys.label67.Text = "2";
            ListAnalisys.label68.Text = "3";
            ListAnalisys.label69.Text = "4";
            ListAnalisys.label70.Text = "5";
            ListAnalisys.label71.Text = "6";
            ListAnalisys.label72.Text = "7";
            ListAnalisys.label73.Text = "8";
            ListAnalisys.label74.Text = "9";
            ListAnalisys.label75.Text = "0";

            ListAnalisys.label80.Text = " ";
            

            stext = richTextBox1.Text; // занушу в переменную вводимые данные в поле ввода
            sizetext = stext.Length;

            if ((sizetext) > 0)  // подситываю чистоту  ентеров и пробелов
            {
                percent = 0;

                
                for (i = 0; i < sizetext; i++)
                {
                    textenter = stext[i];
                    if (textenter == 10)
                    {
                        A[65] = A[65] + 1;
                        percent = A[65] * 100 / sizetext;
                        ListAnalisys.label65.Text = "¶  " + A[65] + "   " + percent + "%";
                    }
                    if (textenter == 32)
                    {
                        A[64] = A[64] + 1;
                        percent = A[64] * 100 / sizetext;
                        ListAnalisys.label64.Text = "¬  " + A[64] + "   " + percent + "%";
                    }
                }


                psizetext = sizetext - A[65] - A[64];
                i = stext[sizetext - 1];
                ListAnalisys.label80.Text = psizetext + " ";
               

                if (psizetext > 0)  // произвожу подсчет совпадений букв, цифр, символов
                {
                    for (i = 0; i < sizetext; i++)
                    {
                        switch (stext[i])
                        {

                            case 'А':
                                A[1] = A[1] + 1;
                                break;
                            case 'а':
                                A[1] = A[1] + 1;
                                break;
                            case 'Б':
                                A[2] = A[2] + 1;
                                break;
                            case 'б':
                                A[2] = A[2] + 1;
                                break;
                            case 'В':
                                A[3] = A[3] + 1;
                                break;
                            case 'в':
                                A[3] = A[3] + 1;
                                break;
                            case 'Г':
                                A[4] = A[4] + 1;
                                break;
                            case 'г':
                                A[4] = A[4] + 1;
                                break;
                            case 'Д':
                                A[5] = A[5] + 1;
                                break;
                            case 'д':
                                A[5] = A[5] + 1;
                                break;
                            case 'Е':
                                A[6] = A[6] + 1;
                                break;
                            case 'е':
                                A[6] = A[6] + 1;
                                break;
                            case 'Ё':
                                A[7] = A[7] + 1;
                                break;
                            case 'ё':
                                A[7] = A[7] + 1;
                                break;
                            case 'Ж':
                                A[8] = A[8] + 1;
                                break;
                            case 'ж':
                                A[8] = A[8] + 1;
                                break;
                            case 'З':
                                A[9] = A[9] + 1;
                                break;
                            case 'з':
                                A[9] = A[9] + 1;
                                break;
                            case 'И':
                                A[10] = A[10] + 1;
                                break;
                            case 'и':
                                A[10] = A[10] + 1;
                                break;
                            case 'Й':
                                A[11] = A[11] + 1;
                                break;
                            case 'й':
                                A[11] = A[11] + 1;
                                break;
                            case 'К':
                                A[12] = A[12] + 1;
                                break;
                            case 'к':
                                A[12] = A[12] + 1;
                                break;
                            case 'Л':
                                A[13] = A[13] + 1;
                                break;
                            case 'л':
                                A[13] = A[13] + 1;
                                break;
                            case 'М':
                                A[14] = A[14] + 1;
                                break;
                            case 'м':
                                A[14] = A[14] + 1;
                                break;
                            case 'Н':
                                A[15] = A[15] + 1;
                                break;
                            case 'н':
                                A[15] = A[15] + 1;
                                break;
                            case 'О':
                                A[16] = A[16] + 1;
                                break;
                            case 'о':
                                A[16] = A[16] + 1;
                                break;
                            case 'П':
                                A[17] = A[17] + 1;
                                break;
                            case 'п':
                                A[17] = A[17] + 1;
                                break;
                            case 'Р':
                                A[18] = A[18] + 1;
                                break;
                            case 'р':
                                A[18] = A[18] + 1;
                                break;
                            case 'С':
                                A[19] = A[19] + 1;
                                break;
                            case 'с':
                                A[19] = A[19] + 1;
                                break;
                            case 'Т':
                                A[20] = A[20] + 1;
                                break;
                            case 'т':
                                A[20] = A[20] + 1;
                                break;
                            case 'У':
                                A[21] = A[21] + 1;
                                break;
                            case 'у':
                                A[21] = A[21] + 1;
                                break;
                            case 'Ф':
                                A[22] = A[22] + 1;
                                break;
                            case 'ф':
                                A[22] = A[22] + 1;
                                break;
                            case 'Х':
                                A[23] = A[23] + 1;
                                break;
                            case 'х':
                                A[23] = A[23] + 1;
                                break;
                            case 'Ц':
                                A[24] = A[24] + 1;
                                break;
                            case 'ц':
                                A[24] = A[24] + 1;
                                break;
                            case 'Ч':
                                A[25] = A[25] + 1;
                                break;
                            case 'ч':
                                A[25] = A[25] + 1;
                                break;
                            case 'Ш':
                                A[26] = A[26] + 1;
                                break;
                            case 'ш':
                                A[26] = A[26] + 1;
                                break;
                            case 'Щ':
                                A[27] = A[27] + 1;
                                break;
                            case 'щ':
                                A[27] = A[27] + 1;
                                break;
                            case 'Ъ':
                                A[28] = A[28] + 1;
                                break;
                            case 'ъ':
                                A[28] = A[28] + 1;
                                break;
                            case 'Ы':
                                A[29] = A[29] + 1;
                                break;
                            case 'ы':
                                A[29] = A[29] + 1;
                                break;
                            case 'Ь':
                                A[30] = A[30] + 1;
                                break;
                            case 'ь':
                                A[30] = A[30] + 1;
                                break;
                            case 'Э':
                                A[31] = A[31] + 1;
                                break;
                            case 'э':
                                A[31] = A[31] + 1;
                                break;
                            case 'Ю':
                                A[32] = A[32] + 1;
                                break;
                            case 'ю':
                                A[32] = A[32] + 1;
                                break;
                            case 'Я':
                                A[33] = A[33] + 1;
                                break;
                            case 'я':
                                A[33] = A[33] + 1;
                                break;
                            case '.':
                                A[34] = A[34] + 1;
                                break;
                            case ',':
                                A[35] = A[35] + 1;
                                break;
                            case '-':
                                A[36] = A[36] + 1;
                                break;
                            case 'A':
                                A[37] = A[37] + 1;
                                break;
                            case 'a':
                                A[37] = A[37] + 1;
                                break;
                            case 'B':
                                A[38] = A[38] + 1;
                                break;
                            case 'b':
                                A[38] = A[38] + 1;
                                break;
                            case 'C':
                                A[39] = A[39] + 1;
                                break;
                            case 'c':
                                A[39] = A[39] + 1;
                                break;
                            case 'D':
                                A[40] = A[40] + 1;
                                break;
                            case 'd':
                                A[40] = A[40] + 1;
                                break;
                            case 'E':
                                A[41] = A[41] + 1;
                                break;
                            case 'e':
                                A[41] = A[41] + 1;
                                break;
                            case 'F':
                                A[42] = A[42] + 1;
                                break;
                            case 'f':
                                A[42] = A[42] + 1;
                                break;
                            case 'G':
                                A[43] = A[43] + 1;
                                break;
                            case 'g':
                                A[43] = A[43] + 1;
                                break;
                            case 'H':
                                A[44] = A[44] + 1;
                                break;
                            case 'h':
                                A[44] = A[44] + 1;
                                break;
                            case 'I':
                                A[45] = A[45] + 1;
                                break;
                            case 'i':
                                A[45] = A[45] + 1;
                                break;
                            case 'J':
                                A[46] = A[46] + 1;
                                break;
                            case 'j':
                                A[46] = A[46] + 1;
                                break;
                            case 'K':
                                A[47] = A[47] + 1;
                                break;
                            case 'k':
                                A[47] = A[47] + 1;
                                break;
                            case 'L':
                                A[48] = A[48] + 1;
                                break;
                            case 'l':
                                A[48] = A[48] + 1;
                                break;
                            case 'M':
                                A[49] = A[49] + 1;
                                break;
                            case 'm':
                                A[49] = A[49] + 1;
                                break;
                            case 'N':
                                A[50] = A[50] + 1;
                                break;
                            case 'n':
                                A[50] = A[50] + 1;
                                break;
                            case 'O':
                                A[51] = A[51] + 1;
                                break;
                            case 'o':
                                A[51] = A[51] + 1;
                                break;
                            case 'P':
                                A[52] = A[52] + 1;
                                break;
                            case 'p':
                                A[52] = A[52] + 1;
                                break;
                            case 'Q':
                                A[53] = A[53] + 1;
                                break;
                            case 'q':
                                A[53] = A[53] + 1;
                                break;
                            case 'R':
                                A[54] = A[54] + 1;
                                break;
                            case 'r':
                                A[54] = A[54] + 1;
                                break;
                            case 'S':
                                A[55] = A[55] + 1;
                                break;
                            case 's':
                                A[55] = A[55] + 1;
                                break;
                            case 'T':
                                A[56] = A[56] + 1;
                                break;
                            case 't':
                                A[56] = A[56] + 1;
                                break;
                            case 'U':
                                A[57] = A[57] + 1;
                                break;
                            case 'u':
                                A[57] = A[57] + 1;
                                break;
                            case 'V':
                                A[58] = A[58] + 1;
                                break;
                            case 'v':
                                A[58] = A[58] + 1;
                                break;
                            case 'W':
                                A[59] = A[59] + 1;
                                break;
                            case 'w':
                                A[59] = A[59] + 1;
                                break;
                            case 'X':
                                A[60] = A[60] + 1;
                                break;
                            case 'x':
                                A[60] = A[60] + 1;
                                break;
                            case 'Y':
                                A[61] = A[61] + 1;
                                break;
                            case 'y':
                                A[61] = A[61] + 1;
                                break;
                            case 'Z':
                                A[62] = A[62] + 1;
                                break;
                            case 'z':
                                A[62] = A[62] + 1;
                                break;
                            case '1':
                                A[66] = A[66] + 1;
                                break;
                            case '2':
                                A[67] = A[67] + 1;
                                break;
                            case '3':
                                A[68] = A[68] + 1;
                                break;
                            case '4':
                                A[69] = A[69] + 1;
                                break;
                            case '5':
                                A[70] = A[70] + 1;
                                break;
                            case '6':
                                A[71] = A[71] + 1;
                                break;
                            case '7':
                                A[72] = A[72] + 1;
                                break;
                            case '8':
                                A[73] = A[73] + 1;
                                break;
                            case '9':
                                A[74] = A[74] + 1;
                                break;
                            case '0':
                                A[75] = A[75] + 1;
                                break;

                            default:
                                A[63] = A[63] + 1;//содержит ентеры и пробелы 
                                break;
                        }
                    }

                    if (checkBox1.Checked)
                    {
                        psizetext = sizetext - A[65] - A[64]; //пробелы
                    }
                    else
                    {
                        psizetext = sizetext - A[63];//- A[65] - A[64] //ентеры
                    }

                    i = stext[sizetext - 1];
                    ListAnalisys.label80.Text = psizetext + " ";
                    

                    if (A[1] > 0)  // вывожу в лейбз на другой форме значения совпадений плюч записанные данные по процентам 
                    {
                        percent = A[1] * 100 / psizetext;
                        ListAnalisys.label1.Text = "А  " + A[1] + "  " + percent + "%";
                    }

                    if (A[2] > 0)
                    {
                        percent = A[2] * 100 / psizetext;
                        ListAnalisys.label2.Text = "Б  " + A[2] + "  " + percent + "%";
                    }
                    if (A[3] > 0)
                    {
                        percent = A[3] * 100 / psizetext;
                        ListAnalisys.label3.Text = "В  " + A[3] + "   " + percent + "%";
                    }

                    if (A[4] > 0)
                    {
                        percent = A[4] * 100 / psizetext;
                        ListAnalisys.label4.Text = "Г  " + A[4] + "   " + percent + "%";
                    }

                    if (A[5] > 0)
                    {
                        percent = A[5] * 100 / psizetext;
                        ListAnalisys.label5.Text = "Д  " + A[5] + "   " + percent + "%";
                    }

                    if (A[6] > 0)
                    {
                        percent = A[6] * 100 / psizetext;
                        ListAnalisys.label6.Text = "Е  " + A[6] + "   " + percent + "%";
                    }

                    if (A[7] > 0)
                    {
                        percent = A[7] * 100 / psizetext;
                        ListAnalisys.label7.Text = "Ё  " + A[7] + "   " + percent + "%";
                    }

                    if (A[8] > 0)
                    {
                        percent = A[8] * 100 / psizetext;
                        ListAnalisys.label8.Text = "Ж  " + A[8] + "   " + percent + "%";
                    }

                    if (A[9] > 0)
                    {
                        percent = A[9] * 100 / psizetext;
                        ListAnalisys.label9.Text = "З  " + A[9] + "   " + percent + "%";
                    }

                    if (A[10] > 0)
                    {
                        percent = A[10] * 100 / psizetext;
                        ListAnalisys.label10.Text = "И  " + A[10] + "   " + percent + "%";
                    }

                    if (A[11] > 0)
                    {
                        percent = A[11] * 100 / psizetext;
                        ListAnalisys.label11.Text = "Й  " + A[11] + "   " + percent + "%";
                    }

                    if (A[12] > 0)
                    {
                        percent = A[12] * 100 / psizetext;
                        ListAnalisys.label12.Text = "К  " + A[12] + "   " + percent + "%";
                    }

                    if (A[13] > 0)
                    {
                        percent = A[13] * 100 / psizetext;
                        ListAnalisys.label13.Text = "Л  " + A[13] + "   " + percent + "%";
                    }

                    if (A[14] > 0)
                    {
                        percent = A[14] * 100 / psizetext;
                        ListAnalisys.label14.Text = "М  " + A[14] + "   " + percent + "%";
                    }

                    if (A[15] > 0)
                    {
                        percent = A[15] * 100 / psizetext;
                        ListAnalisys.label15.Text = "Н  " + A[15] + "   " + percent + "%";
                    }

                    if (A[16] > 0)
                    {
                        percent = A[16] * 100 / psizetext;
                        ListAnalisys.label16.Text = "О  " + A[16] + "   " + percent + "%";
                    }

                    if (A[17] > 0)
                    {
                        percent = A[17] * 100 / psizetext;
                        ListAnalisys.label17.Text = "П  " + A[17] + "   " + percent + "%";
                    }

                    if (A[18] > 0)
                    {
                        percent = A[18] * 100 / psizetext;
                        ListAnalisys.label18.Text = "Р  " + A[18] + "   " + percent + "%";
                    }

                    if (A[19] > 0)
                    {
                        percent = A[19] * 100 / psizetext;
                        ListAnalisys.label19.Text = "С  " + A[19] + "   " + percent + "%";
                    }

                    if (A[20] > 0)
                    {
                        percent = A[20] * 100 / psizetext;
                        ListAnalisys.label20.Text = "Т  " + A[20] + "   " + percent + "%";
                    }

                    if (A[21] > 0)
                    {
                        percent = A[21] * 100 / psizetext;
                        ListAnalisys.label21.Text = "У  " + A[21] + "   " + percent + "%";
                    }

                    if (A[22] > 0)
                    {
                        percent = A[22] * 100 / psizetext;
                        ListAnalisys.label22.Text = "Ф  " + A[22] + "   " + percent + "%";
                    }

                    if (A[23] > 0)
                    {
                        percent = A[23] * 100 / psizetext;
                        ListAnalisys.label23.Text = "Х  " + A[23] + "   " + percent + "%";
                    }

                    if (A[24] > 0)
                    {
                        percent = A[24] * 100 / psizetext;
                        ListAnalisys.label24.Text = "Ц  " + A[24] + "   " + percent + "%";
                    }

                    if (A[25] > 0)
                    {
                        percent = A[25] * 100 / psizetext;
                        ListAnalisys.label25.Text = "Ч  " + A[25] + "   " + percent + "%";
                    }

                    if (A[26] > 0)
                    {
                        percent = A[26] * 100 / psizetext;
                        ListAnalisys.label26.Text = "Ш  " + A[26] + "   " + percent + "%";
                    }

                    if (A[27] > 0)
                    {
                        percent = A[27] * 100 / psizetext;
                        ListAnalisys.label27.Text = "Щ  " + A[27] + "   " + percent + "%";
                    }

                    if (A[28] > 0)
                    {
                        percent = A[28] * 100 / psizetext;
                        ListAnalisys.label28.Text = "Ъ  " + A[28] + "   " + percent + "%";
                    }
                    if (A[29] > 0)
                    {
                        percent = A[29] * 100 / psizetext;
                        ListAnalisys.label29.Text = "Ы  " + A[29] + "   " + percent + "%";
                    }

                    if (A[30] > 0)
                    {
                        percent = A[30] * 100 / psizetext;
                        ListAnalisys.label30.Text = "Ь  " + A[30] + "   " + percent + "%";
                    }

                    if (A[31] > 0)
                    {
                        percent = A[31] * 100 / psizetext;
                        ListAnalisys.label31.Text = "Э  " + A[31] + "   " + percent + "%";
                    }

                    if (A[32] > 0)
                    {
                        percent = A[32] * 100 / psizetext;
                        ListAnalisys.label32.Text = "Ю  " + A[32] + "   " + percent + "%";
                    }

                    if (A[33] > 0)
                    {
                        percent = A[33] * 100 / psizetext;
                        ListAnalisys.label33.Text = "Я  " + A[33] + "   " + percent + "%";
                    }

                    if (A[34] > 0)
                    {
                        percent = A[34] * 100 / psizetext;
                        ListAnalisys.label34.Text = ".  " + A[34] + "   " + percent + "%";
                    }

                    if (A[35] > 0)
                    {
                        percent = A[35] * 100 / psizetext;
                        ListAnalisys.label35.Text = ",  " + A[35] + "   " + percent + "%";
                    }

                    if (A[36] > 0)
                    {
                        percent = A[36] * 100 / psizetext;
                        ListAnalisys.label36.Text = "-  " + A[36] + "   " + percent + "%";
                    }

                    if (A[37] > 0)
                    {
                        percent = A[37] * 100 / psizetext;
                        ListAnalisys.label37.Text = "A   " + A[37] + "   " + percent + "%";
                    }

                    if (A[38] > 0)
                    {
                        percent = A[38] * 100 / psizetext;
                        ListAnalisys.label38.Text = "B  " + A[38] + "   " + percent + "%";
                    }

                    if (A[39] > 0)
                    {
                        percent = A[39] * 100 / psizetext;
                        ListAnalisys.label39.Text = "C  " + A[39] + "   " + percent + "%";
                    }

                    if (A[40] > 0)
                    {
                        percent = A[40] * 100 / psizetext;
                        ListAnalisys.label40.Text = "D  " + A[40] + "   " + percent + "%";
                    }

                    if (A[41] > 0)
                    {
                        percent = A[41] * 100 / psizetext;
                        ListAnalisys.label41.Text = "E  " + A[41] + "   " + percent + "%";
                    }

                    if (A[42] > 0)
                    {
                        percent = A[42] * 100 / psizetext;
                        ListAnalisys.label42.Text = "F  " + A[42] + "   " + percent + "%";
                    }

                    if (A[43] > 0)
                    {
                        percent = A[43] * 100 / psizetext;
                        ListAnalisys.label43.Text = "G  " + A[43] + "   " + percent + "%";
                    }

                    if (A[44] > 0)
                    {
                        percent = A[44] * 100 / psizetext;
                        ListAnalisys.label44.Text = "H  " + A[44] + "   " + percent + "%";
                    }

                    if (A[45] > 0)
                    {
                        percent = A[45] * 100 / psizetext;
                        ListAnalisys.label45.Text = "I  " + A[45] + "   " + percent + "%";
                    }

                    if (A[46] > 0)
                    {
                        percent = A[46] * 100 / psizetext;
                        ListAnalisys.label46.Text = "J  " + A[46] + "   " + percent + "%";
                    }

                    if (A[47] > 0)
                    {
                        percent = A[47] * 100 / psizetext;
                        ListAnalisys.label47.Text = "K  " + A[47] + "   " + percent + "%";
                    }

                    if (A[48] > 0)
                    {
                        percent = A[48] * 100 / psizetext;
                        ListAnalisys.label48.Text = "L  " + A[48] + "   " + percent + "%";
                    }

                    if (A[49] > 0)
                    {
                        percent = A[49] * 100 / psizetext;
                        ListAnalisys.label49.Text = "M  " + A[49] + "   " + percent + "%";
                    }

                    if (A[50] > 0)
                    {
                        percent = A[50] * 100 / psizetext;
                        ListAnalisys.label50.Text = "N  " + A[50] + "   " + percent + "%";
                    }

                    if (A[51] > 0)
                    {
                        percent = A[51] * 100 / psizetext;
                        ListAnalisys.label51.Text = "O  " + A[51] + "   " + percent + "%";
                    }

                    if (A[52] > 0)
                    {
                        percent = A[52] * 100 / psizetext;
                        ListAnalisys.label52.Text = "P  " + A[52] + "   " + percent + "%";
                    }

                    if (A[53] > 0)
                    {
                        percent = A[53] * 100 / psizetext;
                        ListAnalisys.label53.Text = "Q  " + A[53] + "   " + percent + "%";
                    }

                    if (A[54] > 0)
                    {
                        percent = A[54] * 100 / psizetext;
                        ListAnalisys.label54.Text = "R  " + A[54] + "   " + percent + "%";
                    }

                    if (A[55] > 0)
                    {
                        percent = A[55] * 100 / psizetext;
                        ListAnalisys.label55.Text = "S  " + A[55] + "   " + percent + "%";
                    }

                    if (A[56] > 0)
                    {
                        percent = A[56] * 100 / psizetext;
                        ListAnalisys.label56.Text = "T  " + A[56] + "   " + percent + "%";
                    }

                    if (A[57] > 0)
                    {
                        percent = A[57] * 100 / psizetext;
                        ListAnalisys.label57.Text = "U  " + A[57] + "   " + percent + "%";
                    }

                    if (A[58] > 0)
                    {
                        percent = A[58] * 100 / psizetext;
                        ListAnalisys.label58.Text = "V  " + A[58] + "   " + percent + "%";
                    }

                    if (A[59] > 0)
                    {
                        percent = A[59] * 100 / psizetext;
                        ListAnalisys.label59.Text = "W  " + A[59] + "   " + percent + "%";
                    }

                    if (A[60] > 0)
                    {
                        percent = A[60] * 100 / psizetext;
                        ListAnalisys.label60.Text = "X  " + A[60] + "   " + percent + "%";
                    }

                    if (A[61] > 0)
                    {
                        percent = A[61] * 100 / psizetext;
                        ListAnalisys.label61.Text = "Y  " + A[61] + "   " + percent + "%";
                    }

                    if (A[62] > 0)
                    {
                        percent = A[62] * 100 / psizetext;
                        ListAnalisys.label62.Text = "Z  " + A[62] + "   " + percent + "%";
                    }

                    if (A[66] > 0)
                    {
                        percent = A[66] * 100 / psizetext;
                        ListAnalisys.label66.Text = "1  " + A[66] + "   " + percent + "%";
                    }

                    if (A[67] > 0)
                    {
                        percent = A[67] * 100 / psizetext;
                        ListAnalisys.label67.Text = "2  " + A[67] + "   " + percent + "%";
                    }

                    if (A[68] > 0)
                    {
                        percent = A[68] * 100 / psizetext;
                        ListAnalisys.label68.Text = "3  " + A[68] + "   " + percent + "%";
                    }

                    if (A[69] > 0)
                    {
                        percent = A[69] * 100 / psizetext;
                        ListAnalisys.label69.Text = "4  " + A[69] + "   " + percent + "%";
                    }

                    if (A[70] > 0)
                    {
                        percent = A[70] * 100 / psizetext;
                        ListAnalisys.label70.Text = "5  " + A[70] + "   " + percent + "%";
                    }

                    if (A[71] > 0)
                    {
                        percent = A[71] * 100 / psizetext;
                        ListAnalisys.label71.Text = "6  " + A[71] + "   " + percent + "%";
                    }

                    if (A[72] > 0)
                    {
                        percent = A[72] * 100 / psizetext;
                        ListAnalisys.label72.Text = "7  " + A[72] + "   " + percent + "%";
                    }

                    if (A[73] > 0)
                    {
                        percent = A[73] * 100 / psizetext;
                        ListAnalisys.label73.Text = "8  " + A[73] + "   " + percent + "%";
                    }

                    if (A[74] > 0)
                    {
                        percent = A[74] * 100 / psizetext;
                        ListAnalisys.label74.Text = "9  " + A[74] + "   " + percent + "%";
                    }

                    if (A[75] > 0)
                    {
                        percent = A[75] * 100 / psizetext;
                        ListAnalisys.label75.Text = "0  " + A[75] + "   " + percent + "%";
                    }

                    if (A[63] > 0)
                    {
                        A[63] = A[63] - A[64] - A[65];
                        int anotherpsizetext = sizetext - A[65] - A[64];
                        percent = A[63] * 100 / anotherpsizetext;
                        ListAnalisys.label63.Text = "~  " + A[63] + "   " + percent + "%";
                    }
                }



            }

            
        }

        private void button3_Click(object sender, EventArgs e) //возвращаемся к выбору задания
        {
            Form2 fr = new Form2();
            fr.Show();
            this.Visible = false;
        }
    }
}
