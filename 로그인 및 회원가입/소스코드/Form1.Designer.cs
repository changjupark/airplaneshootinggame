namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.complte = new System.Windows.Forms.Button();
            this.user_id2 = new System.Windows.Forms.TextBox();
            this.user_id = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.passwordcontiune = new System.Windows.Forms.TextBox();
            this.success = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // complte
            // 
            this.complte.Location = new System.Drawing.Point(295, 129);
            this.complte.Name = "complte";
            this.complte.Size = new System.Drawing.Size(75, 23);
            this.complte.TabIndex = 0;
            this.complte.Text = "중복확인";
            this.complte.UseVisualStyleBackColor = true;
            this.complte.Click += new System.EventHandler(this.complte_Click);
            // 
            // user_id2
            // 
            this.user_id2.Location = new System.Drawing.Point(146, 129);
            this.user_id2.Name = "user_id2";
            this.user_id2.Size = new System.Drawing.Size(124, 21);
            this.user_id2.TabIndex = 1;
            this.user_id2.TextChanged += new System.EventHandler(this.user_id2_TextChanged);
            // 
            // user_id
            // 
            this.user_id.Location = new System.Drawing.Point(146, 82);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(124, 21);
            this.user_id.TabIndex = 2;
            this.user_id.TextChanged += new System.EventHandler(this.user_id2_TextChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(146, 184);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(124, 21);
            this.password.TabIndex = 3;
            this.password.UseSystemPasswordChar = true;
            // 
            // passwordcontiune
            // 
            this.passwordcontiune.Location = new System.Drawing.Point(146, 240);
            this.passwordcontiune.Name = "passwordcontiune";
            this.passwordcontiune.Size = new System.Drawing.Size(124, 21);
            this.passwordcontiune.TabIndex = 4;
            this.passwordcontiune.UseSystemPasswordChar = true;
            // 
            // success
            // 
            this.success.Location = new System.Drawing.Point(168, 334);
            this.success.Name = "success";
            this.success.Size = new System.Drawing.Size(75, 23);
            this.success.TabIndex = 5;
            this.success.Text = "완료";
            this.success.UseVisualStyleBackColor = true;
            this.success.Click += new System.EventHandler(this.success_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "아이디";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "비밀번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "비밀번호 확인";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(163, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "회원가입";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 532);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.success);
            this.Controls.Add(this.passwordcontiune);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user_id);
            this.Controls.Add(this.user_id2);
            this.Controls.Add(this.complte);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "회원가입(airplane shooting game)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button complte;
        private System.Windows.Forms.TextBox user_id2;
        private System.Windows.Forms.TextBox user_id;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox passwordcontiune;
        private System.Windows.Forms.Button success;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}