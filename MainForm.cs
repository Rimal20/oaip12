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
    public partial class MainForm : Form
    {
        private readonly AppDbContext _context;
        private readonly User _user;

        public MainForm(AppDbContext context, User user)
        {
            InitializeComponent();

            _context = context;
            _user = user;

            _user.Apps = _context.Apps.Where(b => b.UserId == _user.Id).ToList();


            Text = $"Библиотека пользователя {_user.Name}";

            AppsDataGridView.AutoGenerateColumns = true;
            AppsDataGridView.DataSource = _user.Apps;

        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            var AppForm = new AppForm(_context, _user);
            if (AppForm.ShowDialog() == DialogResult.OK)
            {
                _user.Apps.Add(AppForm.App);
                _context.SaveChanges();

                AppsDataGridView.DataSource = null;
                AppsDataGridView.DataSource = _user.Apps;
            }
        }

        private void DeleteBookButton_Click_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    var selectedRow = AppsDataGridView.SelectedRows[0];
                    var book = (App)selectedRow.DataBoundItem;
                    

                    App delBook = _context.Apps.FirstOrDefault(o => o.Id == book.Id);

                    _context.Apps.Remove(delBook);
                    _context.SaveChanges();

                    AppsDataGridView.DataSource = null;
                    AppsDataGridView.DataSource = _user.Apps = _context.Apps.Where(b => b.UserId == _user.Id).ToList();
                    _context.SaveChanges();
                    //update();
                }
                catch
                {
                    MessageBox.Show("Выберите правильное место для удаления");
                }
                //DataGridViewRow row = AppsDataGridView.SelectedRows[0];
                //int id = Convert.ToInt32(row.Cells["idDataGridViewTextBoxColumn"].Value);
                //var bookToRemove = _context.Apps.FirstOrDefault(b => b.Id == id);
                //_context.Apps.Remove(bookToRemove);
                //_context.SaveChanges();
                //update();
            }
    }

        //private void update()
        //{
        //    List<App> booksWithUserId = _context.Apps.Where(b => b.UserId == _user.Id).ToList();
        //    AppsDataGridView.DataSource = booksWithUserId;
        //}

        //private void ExitButton_Click_Click(object sender, EventArgs e)
        //{
        //    Close();
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        var selectedRow = AppsDataGridView.SelectedRows[0];
        //        var sal = (App)selectedRow.DataBoundItem;
        //        App lev = _context.Apps.FirstOrDefault(u => u.Id == sal.Id);

        //        if (lev != null) lev.Status = textBox1.Text;
        //        //label1.Text = comboBox1.SelectedItem.ToString();
        //        _context.SaveChanges();
        //        AppsDataGridView.DataSource = null;
        //        AppsDataGridView.DataSource = _user.Apps;
        //    }
        //    catch (Exception ex) { MessageBox.Show("Выберите строчку!"); }
        //}

        private void ExitButton_Click_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                var selectedRow = AppsDataGridView.SelectedRows[0];
                var sal = (App)selectedRow.DataBoundItem;
                App lev = _context.Apps.FirstOrDefault(u => u.Id == sal.Id);

                if (lev != null) lev.Status = textBox1.Text;
                //label1.Text = comboBox1.SelectedItem.ToString();
                _context.SaveChanges();
                AppsDataGridView.DataSource = null;
                AppsDataGridView.DataSource = _user.Apps;
            }
            catch (Exception ex) { MessageBox.Show("Выберите строчку!"); }
        }
    }
    } 
