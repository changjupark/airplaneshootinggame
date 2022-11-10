using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Deployment.Internal.CodeSigning;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        
        private void user_id2_TextChanged(object sender, EventArgs e)
        {

        }
        private SQLiteConnection conn = null;
        private void complte_Click(object sender, EventArgs e)
        {
            conn = new SQLiteConnection("Data Source=C:\\Program Files\\ptu\\airplaneshooting.db;Version=3;");
            conn.Open();

            string id = "Select Count(*) from USERINFO where USERNAME='" + user_id2.Text + "'";

            SQLiteDataAdapter command = new SQLiteDataAdapter(id, conn);
            DataTable dataTable = new DataTable();
            command.Fill(dataTable);
                      
            
            
            if (dataTable.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("아이디가 중복되었습니다 다른 아이디를 입력해주세요");
                
                
            }
            else
            {
                MessageBox.Show("아이디가 중복되어있지 않습니다. 계속 진행해주세요");
                
                
            }

        }

        private void success_Click(object sender, EventArgs e)
        {
            
            if (user_id.Text.Length >= 1)
            {
                if (user_id2.Text.Length >= 1)
                {
                    conn = new SQLiteConnection("Data Source=C:\\Program Files\\ptu\\airplaneshooting.db;Version=3;");
                    conn.Open();

                    string id = "Select Count(*) from USERINFO where USERNAME='" + user_id2.Text + "'";

                    SQLiteDataAdapter command = new SQLiteDataAdapter(id, conn);
                    DataTable dataTable = new DataTable();
                    command.Fill(dataTable);




                    if (dataTable.Rows[0][0].ToString() == "1")
                    {
                        MessageBox.Show("아이디가 중복되었습니다 다른 아이디를 입력해주세요");
                    }

                    else
                    {
                        if (password.Text.Length >= 1)
                        {
                            if (password.Text == passwordcontiune.Text)
                            {


                                string rogin = "INSERT INTO [USERINFO] ([USERNAME], [PASSWORD], [USERREALNAME]) VALUES ('" + user_id2.Text + "', '" + password.Text + "','" + user_id.Text + "');";

                                SQLiteCommand command1 = new SQLiteCommand(rogin, conn);
                                command1.ExecuteNonQuery();
                                MessageBox.Show("회원가입이 완료되었습니다.");
                                //회원가입 성공인 경우
                                this.Hide(); //숨김처리
                            }
                            else
                            {
                                MessageBox.Show("비밀번호와 비밀번호 확인이 다릅니다 확인 후 다시 시도해주세요.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("비밀번호 칸이 비어있습니다. 확인 후 다시 시도해주세요.");
                        }

                    }
                }
                else
                {
                    MessageBox.Show("아이디칸이 비어있습니다. 확인 후 다시 시도해주세요.");
                }



                }
                else
                {
                    MessageBox.Show("이름칸이 비어있습니다. 확인 후 다시 시도해주세요");
                }

            }
        }
    }



    


