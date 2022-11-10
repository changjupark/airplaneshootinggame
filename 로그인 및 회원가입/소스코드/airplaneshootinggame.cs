using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class airplaneshoothing : Form
    {
               

        public airplaneshoothing()
        {
                    InitializeComponent();
        }
      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 mainForm2 = new Form2();
            mainForm2.Show();
        }

        private SQLiteConnection conn = null;
        private void Login_button(object sender, EventArgs e)
        {
            conn = new SQLiteConnection("Data Source=C:\\Program Files\\ptu\\airplaneshooting.db;Version=3;");
            conn.Open();

            string id_conn = "Select Count(*) from USERINFO where USERNAME = '" + this.id.Text + "'";

            SQLiteDataAdapter command = new SQLiteDataAdapter(id_conn, conn);
            DataTable dataTable = new DataTable();
            command.Fill(dataTable);
                                    
            
            if (dataTable.Rows[0][0].ToString() == "1")
            {

                string login = "Select Count(*) from USERINFO where USERNAME='" + this.id.Text + "' and PASSWORD='" + this.Password.Text + "'";
                SQLiteDataAdapter command1 = new SQLiteDataAdapter(login, conn);
                DataTable dataTable1 = new DataTable();
                command1.Fill(dataTable1);





                if (dataTable1.Rows[0][0].ToString() == "1")
                {
                    //로그인 성공인 경우
                    this.Hide(); //숨김처리
                    MessageBox.Show(id.Text + "님 환영합니다.");
                    this.Close();

                }

                else
                {
                    //로그인 실패시
                    MessageBox.Show("비밀번호를 확인해주세요");
                }
            }
            else
            {
                MessageBox.Show("존재하지 않는 id입니다 회원가입 후 다시 진행해주세요");
            }
        }
        private void create_user(object sender, EventArgs e)
        {
            Form1 mainForm1 = new Form1();
            mainForm1.Show();
        }

        private void airplaneshoothing_Load(object sender, EventArgs e)
        {

        }

    
    }
}
