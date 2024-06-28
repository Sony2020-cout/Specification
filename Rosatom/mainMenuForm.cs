/*Минусы решения:
 *   
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
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rosatom
{
    public partial class mainMenuForm : Form
    {
        string path = @"Data Source=DESKTOP-3JHJRRT\SQLEXPRESS;Initial Catalog=Rosatom;Integrated Security=True;TrustServerCertificate=True";//@"Data Source=DESKTOP-3JHJRRT\SQLEXPRESS;Initial Catalog=Rosatom;Integrated Security=True;User ID=DESKTOP-3JHJRRT\NIKA;Password= "
        SqlConnection con;
        SqlCommand cmd;
        DataTable dt;
        int ID;
        int SPEC_ID;//Snake_Case быть не должно
        string user = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

        public mainMenuForm()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            display_Doc();//Snake_Case быть не должно
            display_Spec();//Snake_Case быть не должно
        }
        public void display_Doc()//Snake_Case быть не должно
        {
            try
            {
                dt = new DataTable();
                con.Open();
                SqlDataAdapter adpt = new SqlDataAdapter("select * from Master_Doc", con); //Узнать, как данные из грида поступают по запросу, а не напрямую.
                adpt.Fill(dt);
                docDGV.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void display_Spec()//Snake_Case быть не должно
        {
            try
            {
                dt = new DataTable();
                con.Open();
                SqlDataAdapter adpt = new SqlDataAdapter("select * from Detail_Spec", con);
                adpt.Fill(dt);
                specDGW.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void mainMenuForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rosatomDataSet1.Master_Doc". При необходимости она может быть перемещена или удалена.
            this.master_DocTableAdapter.Fill(this.rosatomDataSet.Master_Doc);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rosatomDataSet2.Detail_Spec". При необходимости она может быть перемещена или удалена.
            this.detail_SpecTableAdapter.Fill(this.rosatomDataSet.Detail_Spec);
            /*// TODO: данная строка кода позволяет загрузить данные в таблицу "rosatomDataSet2.Detail". При необходимости она может быть перемещена или удалена.
            this.detailTableAdapter.Fill(this.rosatomDataSet2.Detail);*/
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rosatomDataSet2.Logs". При необходимости она может быть перемещена или удалена.
            this.logsTableAdapter.Fill(this.rosatomDataSet.Logs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rosatomDataSet.Detail". При необходимости она может быть перемещена или удалена.
           
        }
        public void display_default_Doc()//Snake_Case быть не должно
        {
            specIdTB.Text = "Введите номер спец-ии";
            numDocTB.Text = "Введите номер";
            dateDocTB.Text = "Введите дату";
            noteDocRTB.Text = "Введите примечание";
        }

        public void display_default_Spec()//Snake_Case быть не должно
        {
            nameSpecTB.Text = "Введите наименование";
            costSpecTB.Text = "Введите сумму";
            SpecId1TB.Text = "Введите номер спец-ии";
        }



        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void numDocTB_Click(object sender, EventArgs e)
        {
            numDocTB.Text = "";
        }

        private void dateDocTB_Click(object sender, EventArgs e)
        {
            dateDocTB.Text = "";
        }

       

        private void noteDocRTB_Click(object sender, EventArgs e)
        {
            noteDocRTB.Text = "";
        }

        private void nameSpecTB_Click(object sender, EventArgs e)
        {
            nameSpecTB.Text = "";
        }

        private void costSpecTB_Click(object sender, EventArgs e)
        {
            costSpecTB.Text = "";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            enterForm entForm = new enterForm();
            entForm.Show();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            string multiLine = "Добро пожаловать в программу Расчета документов по спецификации."+ "\n" +
                               "Даное программное обеспечение позволяет занести документы с суммой, " + "\n" +
                               "прилагаемой в спецификации. " + "\n" +
                               "Для начала работы необходимо добавить спецификацию " + "\n" +
                               "в соответствующую таблицу слева, занеся номер спецификации и сумму" +  
                               " и нажать на кнопку Добавить.Для удаления нажать на кнопку Удалить , для редактирование нажать на соотв. кнопку. " + "\n" + 
                               "После добавления спецификации необходимо нажать на ячейку с суммой, которая" + "\n" +
                               "указана в таблице Спецификация. " + "\n" +
                               "Для добавления документа(таблица справа) соответственно ввести номер документа, дату, примечание и нажать на кнопку Добавить." + "\n" +
                               "После добавления документа в поле сумма документа таблицы автоматически отобразится сумма из спецификации" + "\n" +
                               "Желаем с удовольствием воспользоваться нашей программой и хорошего Вам дня!";
            MessageBox.Show(multiLine);
        }
        void logAdd(string Person, string Action, string Note)
        {
            
            logsTableAdapter.InsertQuery(Person, Action, DateTime.Now);
        }

        private void button1_Click(object sender, EventArgs e)//Snake_Case быть не должно
        {
            //выгрузка отчета по ошибкам логгированияв приложении в формате Excel
            dataGridView3.SelectAll();
            DataObject copydata = dataGridView3.GetClipboardContent();
            if (copydata != null) Clipboard.SetDataObject(copydata);
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlapp.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook xlWBook;
            Microsoft.Office.Interop.Excel.Worksheet xlsheet;
            object misseddata = System.Reflection.Missing.Value;
            xlWBook = xlapp.Workbooks.Add(misseddata);
            xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
            xlr.Select();
            xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

        }

        private void insertSpecButton_Click(object sender, EventArgs e)
        {
            if (nameSpecTB.Text == "" || costSpecTB.Text == "" || SpecId1TB.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните обязательные поля");
            }
            else
            {
                try
                {
                    con.Open();
                   /* cmd = new SqlCommand("insert into Detail_Spec(name, expanse, spec_id)" +
                        "values('" + nameSpecTB.Text + "'," +
                        "'" + costSpecTB.Text + "', " +
                        "'" + SpecId1TB.Text + "')",con);
                    cmd.ExecuteNonQuery();*/
                    con.Close();
                    MessageBox.Show("Добавлена спецификация");
                    display_Spec();
                    display_default_Spec();

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    this.logAdd(user, "Error", "Time");
                }
            }

        }

        private void editSpecButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
               /* cmd = new SqlCommand("update Detail_Spec set name = '" + nameSpecTB.Text + "'," +
                    "expanse = '" + costSpecTB.Text + "'," +
                    "spec_id = '" + SpecId1TB.Text + "'", con);
                cmd.ExecuteNonQuery();*/
                con.Close();
                MessageBox.Show("Данные спецификации обновлены");
                display_Spec();
                display_default_Spec();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.logAdd(user, "Error", "Time");
            }

        }

        private void deleteSpecButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
               /* cmd = new SqlCommand("delete from Detail_Spec where id = '" + ID + "'", con);
                cmd.ExecuteNonQuery();*/
                con.Close();
                MessageBox.Show("Спецификация удалена");
                display_Spec();
                display_default_Spec();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.logAdd(user, "Error", "Time");
            }
        }

        private void insertDocButton_Click(object sender, EventArgs e)
        {
            if(specIdTB.Text == "" || numDocTB.Text == "" || dateDocTB.Text == "" || noteDocRTB.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните обязательные поля");
            }
            else
            {
                try
                {
                    con.Open();
                   /* cmd = new SqlCommand("insert into Master_Doc(SPEC_ID, " +
                        "number, " +
                        "createdAt,note) values('" + specIdTB.Text + "', " +
                        "'" + numDocTB.Text + "', '" + noteDocRTB.Text + "')", con);
                    SqlCommand cmd1 = new SqlCommand("insert into Master_Doc(amount) " +
                        "values(sum(amount) from Detail_Spec where spec_id = '"+ SPEC_ID +"')",con);//подсчет суммы документа на основе спецификаций
                    cmd1.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();*/
                    con.Close();
                    MessageBox.Show("Документ добавлен");
                    display_Doc();
                    display_default_Doc();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    this.logAdd(user, "Error", "Time");
                }
            }
            
        }

        private void deleteDocButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
               /* cmd = new SqlCommand("delete from Master_Doc where SPEC_ID = '" + SPEC_ID + "'", con);
                SqlCommand cmd2 = new SqlCommand("delete from Detail_Spec where id = '" + ID + "'", con);//удаление из Detail_Spec всех спецификааций с уникальным spec_id
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();*/
                con.Close();
                MessageBox.Show("Документ удалён");
                display_Doc();
                display_default_Doc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.logAdd(user, "Error", "Time");
            }
        }

        private void specDGW_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(specDGW.Rows[e.RowIndex].Cells[0].Value.ToString());
            nameSpecTB.Text = specDGW.Rows[e.RowIndex].Cells[1].Value.ToString();
            costSpecTB.Text = specDGW.Rows[e.RowIndex].Cells[2].Value.ToString();
            SpecId1TB.Text = specDGW.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void docDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SPEC_ID = int.Parse(docDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            specIdTB.Text = docDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            numDocTB.Text = docDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            dateDocTB.Text = docDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            amountTB.Text = docDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            noteDocRTB.Text = docDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
