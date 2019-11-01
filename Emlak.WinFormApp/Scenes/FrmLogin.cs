using Emlak.DataAccess.Abstract;
using Emlak.DataAccess.Concrete.TextDb;
using Emlak.Models;
using Emlak.WinFormApp.Helpers;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emlak.WinFormApp.Scenes
{
    public partial class FrmLogin : MetroForm
    {

        IUserDal userOperations;

        public FrmLogin()
        {
            InitializeComponent();
            string document_path = Application.StartupPath + "/user.txt";
            userOperations = new TDUserDal(document_path);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length > 0 && txtPassword.Text.Length > 0)
            {
                User user = new User(txtUsername.Text, txtPassword.Text);
                bool status = userOperations.Login(user);
                if (status == true)
                {
                    var singletonUser = SingletonUser.CreateAsSingleton();
                    singletonUser.WriteUsername(txtUsername.Text);

                    FrmMain frmMain = new FrmMain();
                    frmMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz.");
            }
        }
    }
}
