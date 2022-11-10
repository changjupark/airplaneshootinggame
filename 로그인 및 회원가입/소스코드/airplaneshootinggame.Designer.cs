namespace WindowsFormsApp1
{
    partial class airplaneshoothing
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(airplaneshoothing));
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Login_Click = new System.Windows.Forms.Button();
            this.createuser = new System.Windows.Forms.Button();
            this.DB_connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcom Game";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.id.Location = new System.Drawing.Point(89, 85);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(160, 29);
            this.id.TabIndex = 1;
            this.id.Text = "아이디";
            this.id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Password.Location = new System.Drawing.Point(89, 132);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(160, 29);
            this.Password.TabIndex = 2;
            this.Password.Text = "비밀번호";
            this.Password.UseSystemPasswordChar = true;
            // 
            // Login_Click
            // 
            this.Login_Click.Location = new System.Drawing.Point(264, 85);
            this.Login_Click.Name = "Login_Click";
            this.Login_Click.Size = new System.Drawing.Size(75, 76);
            this.Login_Click.TabIndex = 5;
            this.Login_Click.Text = "로그인";
            this.Login_Click.UseVisualStyleBackColor = true;
            this.Login_Click.Click += new System.EventHandler(this.Login_button);
            // 
            // createuser
            // 
            this.createuser.Location = new System.Drawing.Point(176, 186);
            this.createuser.Name = "createuser";
            this.createuser.Size = new System.Drawing.Size(75, 23);
            this.createuser.TabIndex = 6;
            this.createuser.Text = "회원가입";
            this.createuser.UseVisualStyleBackColor = true;
            this.createuser.Click += new System.EventHandler(this.create_user);
            // 
            // DB_connect
            // 
            this.DB_connect.Location = new System.Drawing.Point(89, 186);
            this.DB_connect.Name = "DB_connect";
            this.DB_connect.Size = new System.Drawing.Size(75, 23);
            this.DB_connect.TabIndex = 7;
            this.DB_connect.Text = "DB연결";
            this.DB_connect.UseVisualStyleBackColor = true;
            this.DB_connect.Click += new System.EventHandler(this.button1_Click);
            // 
            // airplaneshoothing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 243);
            this.Controls.Add(this.DB_connect);
            this.Controls.Add(this.createuser);
            this.Controls.Add(this.Login_Click);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "airplaneshoothing";
            this.Text = "airplane shooting game";
            this.Load += new System.EventHandler(this.airplaneshoothing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Login_Click;
        private System.Windows.Forms.Button createuser;
        private System.Windows.Forms.Button DB_connect;
    }
}

