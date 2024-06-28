/*Минусы решения:
 *   Слабые базовые знания.
 * - Не использовались конфиги, все захардкожено в исходные коды. Включая логин и пароль админа.

   -Не соблюдается стиль, принятый при разработке на языке C#. (Снейк_кейса_быть_не_должно)

-     Данные в БД передаются посредством конкатенации значений в сам запрос. 
Нет понимания параметров запроса.

- Данные в карточку судя по всему поступают из грида напрямую а не запросом. 
Даже в двузвене так делать нельзя. 

Решение:
Использовать конфиги, не хардкодить в исходный код(не прописывать логин и пароль в код)
Узнать про параметры запроса, так как нет понимания
Узнать, как данные из грида поступают по запросу, а не напрямую.
 */



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rosatom
{
    public partial class enterForm : Form
    {
        public enterForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if(this.loginTextBox.Text == "Admin" && this.passTextBox.Text == "Atom05062024$")
            {
                this.Hide();
                mainMenuForm mMF = new mainMenuForm();
                mMF.Show();

            }
            else
            {
                MessageBox.Show("Неверные данные.В доступе отказано ");
            }
        }
    }
}
