using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string folderPath = "C:\\Program Files\\ptu";
            DirectoryInfo di = new DirectoryInfo(folderPath);

            if (di.Exists == false)
            {
                di.Create();
                MessageBox.Show("데이터베이스 폴더를 생성하였습니다.");
                string dbPath = "C:\\Program Files\\ptu\\airplaneshooting.db";
                FileInfo db = new FileInfo(dbPath);
                if (db.Exists == false)
                {
                    SQLiteConnection.CreateFile(dbPath);
                    MessageBox.Show("데이터 베이스를 생성하였습니다.");
                }
                else
                {
                    MessageBox.Show("데이터 베이스가 생성되어있습니다.");
                }
            
            }
            else
            {
                string dbPath = "C:\\Program Files\\ptu\\airplaneshooting.db";
                FileInfo db = new FileInfo(dbPath);
                if (db.Exists == false)
                {
                    SQLiteConnection.CreateFile(dbPath);
                    MessageBox.Show("데이터 베이스를 생성하였습니다.");
                }
                else
                {
                    MessageBox.Show("데이터 베이스가 생성되어있습니다.");
                }
            }
            
        }
        private SQLiteConnection conn = null;

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SQLiteConnection("Data Source=C:\\Program Files\\ptu\\airplaneshooting.db;Version=3;");
            conn.Open();
            if (conn != null)
            {
                MessageBox.Show("DB가 연결되었습니다.");
            }
            else
            {
                MessageBox.Show("DB 연결을 실패하였습니다.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "CREATE TABLE if not exists USERINFO ([USERNAME] VARCHAR (50) PRIMARY KEY NOT NULL, [PASSWORD] VARCHAR (50) NOT NULL, [USERREALNAME] TEXT NULL);";
            SQLiteCommand command = new SQLiteCommand(sql, conn);
            command.ExecuteNonQuery();
            if (command != null)
            {
                MessageBox.Show("테이블을 생성하였습니다.");
            }
                        
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
