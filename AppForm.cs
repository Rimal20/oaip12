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
    public partial class AppForm : Form
    {
        private readonly AppDbContext _context;
        private readonly User _user;
        private AppDbContext context;
        private Class1.User user;

        public App App { get; private set; }


        public AppForm(AppDbContext context, User user)
        {
            InitializeComponent();
            _context = context;
            _user = user;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var app = new App()
            {
                Name = NameTextBox.Text,
                Desc = DescTextBox.Text,
                Status = StatusTextBox.Text,
                UserId = _user.Id,
                Date_start = DateStartTextBox.Text,
                Date_finish = DateFinishTextBox.Text
            };
            _context.Apps.Add(app);
            _context.SaveChanges();

            App = app;
            DialogResult = DialogResult.OK;
        }
    }
}
