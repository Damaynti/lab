namespace lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Services_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cost_subscription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number_of_classes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number_of_visits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Full_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.textBoxEndDate = new System.Windows.Forms.TextBox();
            this.textBoxStartDate = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Name_services = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subscription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(-3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1376, 456);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1368, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Абонемент";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Client_id,
            this.Services_id,
            this.cost_subscription,
            this.Price,
            this.Number_of_classes,
            this.number_of_visits});
            this.dataGridView1.Location = new System.Drawing.Point(-4, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1233, 353);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // Client_id
            // 
            this.Client_id.DataPropertyName = "Client_id";
            this.Client_id.HeaderText = "Клиент";
            this.Client_id.MinimumWidth = 6;
            this.Client_id.Name = "Client_id";
            this.Client_id.Width = 125;
            // 
            // Services_id
            // 
            this.Services_id.DataPropertyName = "Services_id";
            this.Services_id.HeaderText = "Услуга";
            this.Services_id.MinimumWidth = 6;
            this.Services_id.Name = "Services_id";
            this.Services_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Services_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Services_id.Width = 125;
            // 
            // cost_subscription
            // 
            this.cost_subscription.DataPropertyName = "cost_subscription";
            this.cost_subscription.HeaderText = "Цена подписки";
            this.cost_subscription.MinimumWidth = 6;
            this.cost_subscription.Name = "cost_subscription";
            this.cost_subscription.Width = 125;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Оплачено";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Number_of_classes
            // 
            this.Number_of_classes.DataPropertyName = "Number_of_classes";
            this.Number_of_classes.HeaderText = "Количество занятий";
            this.Number_of_classes.MinimumWidth = 6;
            this.Number_of_classes.Name = "Number_of_classes";
            this.Number_of_classes.Width = 125;
            // 
            // number_of_visits
            // 
            this.number_of_visits.DataPropertyName = "number_of_visits";
            this.number_of_visits.HeaderText = "количество посящений";
            this.number_of_visits.MinimumWidth = 6;
            this.number_of_visits.Name = "number_of_visits";
            this.number_of_visits.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1368, 427);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Клиент";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.Full_Name,
            this.gender,
            this.Birthday,
            this.Discount});
            this.dataGridView2.Location = new System.Drawing.Point(6, 70);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1196, 346);
            this.dataGridView2.TabIndex = 0;
            // 
            // number
            // 
            this.number.DataPropertyName = "id";
            this.number.HeaderText = "id";
            this.number.MinimumWidth = 6;
            this.number.Name = "number";
            this.number.Width = 170;
            // 
            // Full_Name
            // 
            this.Full_Name.DataPropertyName = "Full_Name";
            this.Full_Name.HeaderText = "ФИО";
            this.Full_Name.MinimumWidth = 6;
            this.Full_Name.Name = "Full_Name";
            this.Full_Name.Width = 170;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender ";
            this.gender.HeaderText = "пол";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.Width = 170;
            // 
            // Birthday
            // 
            this.Birthday.DataPropertyName = "Birthday";
            this.Birthday.HeaderText = "День рождения";
            this.Birthday.MinimumWidth = 6;
            this.Birthday.Name = "Birthday";
            this.Birthday.Width = 170;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "Скидка";
            this.Discount.MinimumWidth = 6;
            this.Discount.Name = "Discount";
            this.Discount.Width = 170;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.textBoxEndDate);
            this.tabPage3.Controls.Add(this.textBoxStartDate);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1368, 427);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Отчет1";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_services,
            this.Subscription});
            this.dataGridView3.Location = new System.Drawing.Point(22, 102);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1201, 314);
            this.dataGridView3.TabIndex = 3;
            // 
            // textBoxEndDate
            // 
            this.textBoxEndDate.Location = new System.Drawing.Point(82, 61);
            this.textBoxEndDate.Name = "textBoxEndDate";
            this.textBoxEndDate.Size = new System.Drawing.Size(100, 22);
            this.textBoxEndDate.TabIndex = 2;
            // 
            // textBoxStartDate
            // 
            this.textBoxStartDate.Location = new System.Drawing.Point(82, 33);
            this.textBoxStartDate.Name = "textBoxStartDate";
            this.textBoxStartDate.Size = new System.Drawing.Size(100, 22);
            this.textBoxStartDate.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(210, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 37);
            this.button3.TabIndex = 0;
            this.button3.Text = "Выполнить запрос";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBox4);
            this.tabPage4.Controls.Add(this.numericUpDown1);
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1368, 427);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Отчет2";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(43, 40);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(32, 90);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(1203, 286);
            this.dataGridView4.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(209, 40);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 33);
            this.button4.TabIndex = 0;
            this.button4.Text = "выполнить запрос";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(21, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "C";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(39, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(37, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "По";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(22, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(613, 22);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Вывести наименование услуг и количество абониментов с данной услугой в промежуток" +
    "";
            // 
            // Name_services
            // 
            this.Name_services.DataPropertyName = "Name_services";
            this.Name_services.HeaderText = "Услуги";
            this.Name_services.MinimumWidth = 6;
            this.Name_services.Name = "Name_services";
            this.Name_services.Width = 425;
            // 
            // Subscription
            // 
            this.Subscription.DataPropertyName = "numvisits";
            this.Subscription.HeaderText = "количество абониментов";
            this.Subscription.MinimumWidth = 6;
            this.Subscription.Name = "Subscription";
            this.Subscription.Width = 425;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(11, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(495, 22);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Вывести наименнование услуги и количество посящений этих услуг в ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 453);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "lab1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client_id;
        private System.Windows.Forms.DataGridViewComboBoxColumn Services_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost_subscription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number_of_classes;
        private System.Windows.Forms.DataGridViewTextBoxColumn number_of_visits;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxEndDate;
        private System.Windows.Forms.TextBox textBoxStartDate;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Full_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_services;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subscription;
        private System.Windows.Forms.TextBox textBox4;
    }
}

