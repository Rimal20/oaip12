using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Class1;

namespace oaip12
{
    public partial class Registration : Form
    {
        private readonly AppDbContext _context;
        private readonly User _user;

        public Registration(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        

        private void RegisterButton_Click_Click(object sender, EventArgs e)
        {
            var user = new User
            {
                Email = EmailTextBox.Text,
                Password = PasswordTextBox.Text,
                Name = textBox1.Text
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            MessageBox.Show("Вы успешно зарегистрировались!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
