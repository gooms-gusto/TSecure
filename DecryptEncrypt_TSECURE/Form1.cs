using System;
using System.Windows.Forms;
namespace DecryptEncrypt_TSECURE
{
    public partial class Form1 : Form
    {

        public lib.Pwd _Pwd =new lib.Pwd();

        public Form1()
        {
            InitializeComponent();
        }

        private void _btnconvert_Click(object sender, EventArgs e)
        {

            //encrypt
            if (_CbFuction.SelectedIndex == 0)
            {
                _txtto.Text = _Pwd.Encryptpwd(_txtfrom.Text);

            } else if (_CbFuction.SelectedIndex == 1)
            {
                _txtto.Text = _Pwd.Decryptpwd(_txtfrom.Text);
            }
        }
    }
}
