using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab14._1
{
    public partial class frmComponents : Form
    {
        private ComponentCollection componentCollection = new ComponentCollection();
        private bool CheckFields()
        {
            
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Будь ласка, введіть назву компонента.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtName.Text.Length > 50)
            {
                MessageBox.Show("Назва не повинна перевищувати 50 символів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSerialNumber.Text))
            {
                MessageBox.Show("Будь ласка, введіть серійний номер.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtSerialNumber.Text.Length > 20)
            {
                MessageBox.Show("Серійний номер не повинен перевищувати 20 символів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string serial = txtSerialNumber.Text;
            if (componentCollection.GetAll().Any(c => c.SerialNumber == serial))
            {
                MessageBox.Show("Компонент із таким серійним номером вже існує.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtManufacturer.Text))
            {
                MessageBox.Show("Будь ласка, введіть назву виробника.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtManufacturer.Text.Length > 50)
            {
                MessageBox.Show("Назва виробника не повинна перевищувати 50 символів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCountry.Text))
            {
                MessageBox.Show("Будь ласка, введіть країну виробника.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtCountry.Text.Length > 50)
            {
                MessageBox.Show("Назва країни не повинна перевищувати 50 символів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!double.TryParse(txtPrice.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double price) || price < 0)
            {
                MessageBox.Show("Поле 'Ціна' має бути числом не менше 0.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public frmComponents()
        {
            InitializeComponent();
        }

        private void UpdateDVG()
        {
            dvgComponents.Rows.Clear();
            foreach (var pC_Component in componentCollection.GetAll())
            {
                dvgComponents.Rows.Add(pC_Component.Name, 
                    pC_Component.SerialNumber, 
                    pC_Component.Manufacturer, 
                    pC_Component.Country, 
                    pC_Component.Price);
            }
        }

        private void UpadateDVG_WithExtraction(string choice)
        {
            if (string.IsNullOrWhiteSpace(choice))
            {
                MessageBox.Show("Введіть назву компонента або країну виробника");
                return;
            }

            var extractedComponents = componentCollection.GetAll().Where(c => c.Name == choice || c.Country == choice).ToList();

            if (extractedComponents.Count == 0)
            {
                MessageBox.Show($"Не знайдено компонент з назвою або країною: {choice}");
                return;
            }

            dvgComponents.Rows.Clear();

            foreach (var component in extractedComponents)
            {
                dvgComponents.Rows.Add(
                    component.Name,
                    component.SerialNumber,
                    component.Manufacturer,
                    component.Country,
                    component.Price);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dvgComponents.Columns.Add("Name", "Назва");
            dvgComponents.Columns.Add("SerialNumber", "Серійний номер");
            dvgComponents.Columns.Add("Manufacturer", "Виробник");
            dvgComponents.Columns.Add("Country", "Країна");
            dvgComponents.Columns.Add("Price", "Ціна");
            int fullWidht = 0;
            for (int i = 0; i < dvgComponents.ColumnCount; i++)
            {
                fullWidht += dvgComponents.Columns[i].Width;
            }
            dvgComponents.Width = fullWidht + dvgComponents.RowHeadersWidth + 2;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                string name = txtName.Text;
                string serialNumber = txtSerialNumber.Text;
                string manufacturer = txtManufacturer.Text;
                string country = txtCountry.Text;
                double price = double.Parse(txtPrice.Text, CultureInfo.InvariantCulture);

                PC_Component component = new PC_Component(name, serialNumber, manufacturer, country, price);
                if (!componentCollection.Add(component))
                {
                    MessageBox.Show("Серійний номер вже існує, введіть новий.");
                    return;
                }

                UpdateDVG();
            }
            else
            {
                MessageBox.Show("Помилка введення");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dvgComponents.Rows.Count > 0)
            {
                if (dvgComponents.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Будь ласка, виберіть компонент для видалення.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string serialNumber = dvgComponents.SelectedRows[0].Cells[1].Value.ToString();

                DialogResult result = MessageBox.Show(
                    $"Ви дійсно бажаєте видалити компонент із серійним номером: {serialNumber}?",
                    "Підтвердження видалення",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    componentCollection.Remove(serialNumber);
                    UpdateDVG();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            var keysToRemove = componentCollection.GetAll().Select(c => c.SerialNumber).ToList();

            foreach (var key in keysToRemove)
            {
                componentCollection.Remove(key);
            }

            UpdateDVG();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (componentCollection.GetAll().Count() == 0)
            {
                MessageBox.Show("Немає компонентів для збереження!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "JSON (*.json)|*.json|XML (*.xml)|*.xml|Binary (*.dat)|*.dat|Txt (*.txt)|*.txt",
                Title = "Збереження файлу"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = saveDialog.FileName;
                    string extension = Path.GetExtension(path).ToLower();

                    switch (extension)
                    {
                        case ".json":
                            FileHelper.SaveToJson(componentCollection, path);
                            break;
                        case ".xml":
                            FileHelper.SaveToXML(componentCollection, path);
                            break;
                        case ".dat":
                            FileHelper.SaveToDat(componentCollection, path);
                            break;
                        case ".txt":
                            FileHelper.SaveToTxt(componentCollection, path);
                            break;
                        default:
                            MessageBox.Show("Невідомий формат файлу.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }

                    MessageBox.Show("Дані збережено успішно!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при збереженні: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog
            {
                Filter = "JSON (*.json)|*.json|XML (*.xml)|*.xml|Binary (*.dat)|*.dat|Text (*.txt)|*.txt",
                Title = "Завантаження файлу"
            };

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = openDialog.FileName;
                    string extension = Path.GetExtension(path).ToLower();
                    ComponentCollection loaded = null;

                    switch (extension)
                    {
                        case ".json":
                            loaded = FileHelper.LoadFromJson(path);
                            break;
                        case ".xml":
                            loaded = FileHelper.LoadFromXML(path);
                            break;
                        case ".dat":
                            loaded = FileHelper.LoadFromDat(path);
                            break;
                        case ".txt":
                            loaded = FileHelper.LoadFromTxt(path);
                            break;
                        default:
                            MessageBox.Show("Невідомий формат файлу.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }
                    UpdateDVG();
                    if (loaded != null)
                    {
                        componentCollection = loaded;
                        UpdateDVG(); 
                        MessageBox.Show("Дані завантажено успішно!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Файл порожній або не містить даних.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при завантаженні: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked ==  true)
            { 
                componentCollection.SortBySerailNumber();
            }
            else
            {
                componentCollection.SortBySerailNumber(false);
            }
            UpdateDVG();
        }

        private void btnExtractByName_Click(object sender, EventArgs e)
        {
            string choice = txtChoice.Text;
            UpadateDVG_WithExtraction(choice);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            UpdateDVG();
        }
    }
}
