namespace Lab14._1
{
    partial class frmComponents
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
            this.dvgComponents = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExtract = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtChoice = new System.Windows.Forms.TextBox();
            this.btnReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgComponents)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgComponents
            // 
            this.dvgComponents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgComponents.Location = new System.Drawing.Point(438, 28);
            this.dvgComponents.Name = "dvgComponents";
            this.dvgComponents.RowHeadersWidth = 51;
            this.dvgComponents.RowTemplate.Height = 24;
            this.dvgComponents.Size = new System.Drawing.Size(788, 356);
            this.dvgComponents.TabIndex = 0;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.Control;
            this.btnRemove.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemove.Location = new System.Drawing.Point(757, 441);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(198, 31);
            this.btnRemove.TabIndex = 35;
            this.btnRemove.Text = "Видалити компонент";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(32, 290);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(198, 31);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Додати";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(175, 199);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(192, 22);
            this.txtCountry.TabIndex = 31;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(175, 157);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(192, 22);
            this.txtManufacturer.TabIndex = 30;
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(175, 117);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(192, 22);
            this.txtSerialNumber.TabIndex = 29;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(175, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(192, 22);
            this.txtName.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(28, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "Країна:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(28, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "Виробник:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(28, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "Серійний номер:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(28, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Назва:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(28, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Додати компонент:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(175, 241);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(192, 22);
            this.txtPrice.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 21);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ціна:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(757, 492);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(198, 31);
            this.btnClear.TabIndex = 38;
            this.btnClear.Text = "Очистити список";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(474, 442);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(198, 31);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "Записати у файл";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoad.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoad.Location = new System.Drawing.Point(474, 492);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(198, 31);
            this.btnLoad.TabIndex = 40;
            this.btnLoad.Text = "Завантажити з файлу";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(28, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 24);
            this.label7.TabIndex = 43;
            this.label7.Text = "Сорутвання:";
            // 
            // btnExtract
            // 
            this.btnExtract.BackColor = System.Drawing.SystemColors.Control;
            this.btnExtract.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExtract.Location = new System.Drawing.Point(32, 551);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(198, 31);
            this.btnExtract.TabIndex = 45;
            this.btnExtract.Text = "Вибрати";
            this.btnExtract.UseVisualStyleBackColor = false;
            this.btnExtract.Click += new System.EventHandler(this.btnExtractByName_Click);
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.SystemColors.Control;
            this.btnSort.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSort.Location = new System.Drawing.Point(32, 420);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(400, 31);
            this.btnSort.TabIndex = 46;
            this.btnSort.Text = "Сортувати (за серійним номером)";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(470, 403);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 24);
            this.label8.TabIndex = 47;
            this.label8.Text = "Робота з файлами:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(753, 403);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 24);
            this.label9.TabIndex = 48;
            this.label9.Text = "Робота зі списком:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(32, 385);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(127, 20);
            this.checkBox1.TabIndex = 49;
            this.checkBox1.Text = "За зростанням";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(28, 475);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 24);
            this.label10.TabIndex = 50;
            this.label10.Text = "Вибірка даних:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(28, 513);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(244, 21);
            this.label11.TabIndex = 51;
            this.label11.Text = "Вибрати за назвою або країною:";
            // 
            // txtChoice
            // 
            this.txtChoice.Location = new System.Drawing.Point(302, 513);
            this.txtChoice.Name = "txtChoice";
            this.txtChoice.Size = new System.Drawing.Size(143, 22);
            this.txtChoice.TabIndex = 52;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.SystemColors.Control;
            this.btnReload.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReload.Location = new System.Drawing.Point(757, 542);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(198, 31);
            this.btnReload.TabIndex = 53;
            this.btnReload.Text = "Оновити";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // frmComponents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 605);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.txtChoice);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.txtSerialNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dvgComponents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmComponents";
            this.Text = "Лаб 14";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgComponents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgComponents;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtChoice;
        private System.Windows.Forms.Button btnReload;
    }
}

