using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kadeka
{
    public partial class PasswordForm : Form
    {
        Color bgcolor = Color.FromArgb(242, 237, 215);
        Color fgcolor = Color.FromArgb(117, 81, 57);
        Color midcolor = Color.FromArgb(148, 103, 73);
        public PasswordForm()
        {
            InitializeComponent();
            this.BackColor = bgcolor;
            passwordButton.ForeColor = fgcolor;
            String password = passwordButton.Text;
            if (password == "admin")
            {
                this.Hide();
            }
        }

        private void passwordButton_MouseEnter(object sender, EventArgs e)
        {
            passwordButton.BackColor = midcolor;
        }

        private void passwordButton_MouseLeave(object sender, EventArgs e)
        {
            passwordButton.BackColor = fgcolor;
        } 
    }
}
