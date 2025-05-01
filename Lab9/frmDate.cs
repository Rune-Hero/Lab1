using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9
{
    public partial class frmDate : Form
    {
        private MyDate myDate;

        public frmDate()
        {
            InitializeComponent();
        }

        private void btnSetDate_Click(object sender, EventArgs e)
        {
            try
            {
               
                bool hasDay = !string.IsNullOrWhiteSpace(txtDay.Text);
                bool hasMonth = !string.IsNullOrWhiteSpace(txtMonth.Text);
                bool hasYear = !string.IsNullOrWhiteSpace(txtYear.Text);

                if (hasDay && hasMonth && hasYear)
                {
                    int d = int.Parse(txtDay.Text);
                    int m = int.Parse(txtMonth.Text);
                    int y = int.Parse(txtYear.Text);
                    myDate = new MyDate(d, m, y);
                    
                }
                else if (hasDay && hasMonth)
                {
                    int d = int.Parse(txtDay.Text);
                    int m = int.Parse(txtMonth.Text);
                    myDate = new MyDate(d, m);
                    MessageBox.Show("Поле рік не встановлено, встановлено поточну дату.");
                }
                else if (hasDay)
                {
                    int d = int.Parse(txtDay.Text);
                    myDate = new MyDate(d);
                    MessageBox.Show("Поля: місяць, рік не встановлено, встановлено поточну дату.");
                }
                else
                {
                    myDate = new MyDate();
                    MessageBox.Show("Усі поля порожні, встановлено поточну дату.");
                }

                txtDate.Text = myDate.ToString();
                string countDays = Convert.ToString(myDate.CountDays);
                txtCountDays.Text = countDays.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка");
            }
        }

        private void btnAddDate_Click(object sender, EventArgs e)
        {
            try
            {
                if (myDate == null)
                {
                    MessageBox.Show("Спочатку встановіть дату.");
                    return;
                }

                int addDays = 0;
                int addMonths = 0;
                int addYears = 0;

                if (!string.IsNullOrWhiteSpace(txtAddDays.Text))
                    addDays = int.Parse(txtAddDays.Text);

                if (!string.IsNullOrWhiteSpace(txtAddMonths.Text))
                    addMonths = int.Parse(txtAddMonths.Text); 

                if (!string.IsNullOrWhiteSpace(txtAddYears.Text))
                    addYears = int.Parse(txtAddYears.Text);

                myDate.AddYears(addYears);
                myDate.AddMonths(addMonths);
                myDate.AddDays(addDays);

                txtDate.Text = myDate.ToString();

                txtAddDays.Clear();
                txtAddMonths.Clear();
                txtAddYears.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDate.Clear();
        }
    }
    
}
