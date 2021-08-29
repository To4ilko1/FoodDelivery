namespace WindowsFormsApplication3
{
    partial class MainWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.clients = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.adress = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.status_cmbx = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.food_box = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.price_tbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.add_food = new System.Windows.Forms.Button();
            this.comment_food = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comment_zakaza = new System.Windows.Forms.TextBox();
            this.workers = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.prev = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.load_button = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.new_but = new System.Windows.Forms.Button();
            this.settings_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Клиент";
            // 
            // clients
            // 
            this.clients.FormattingEnabled = true;
            this.clients.Location = new System.Drawing.Point(62, 12);
            this.clients.Name = "clients";
            this.clients.Size = new System.Drawing.Size(121, 21);
            this.clients.TabIndex = 1;
            this.clients.SelectedIndexChanged += new System.EventHandler(this.clients_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "d.MM.yyyy HH:m";
            this.dateTimePicker1.Location = new System.Drawing.Point(290, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(171, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Время доставки:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(193, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Адрес доставки:";
            // 
            // adress
            // 
            this.adress.Location = new System.Drawing.Point(290, 12);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(171, 20);
            this.adress.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.status_cmbx);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(15, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 245);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ваш заказ:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(8, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(748, 172);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название блюда";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Цена блюда";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Количество (шт.)";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Комментарий к блюду";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "К оплате: ";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Изменить";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Удалить";
            this.Column7.Name = "Column7";
            // 
            // status_cmbx
            // 
            this.status_cmbx.FormattingEnabled = true;
            this.status_cmbx.Location = new System.Drawing.Point(213, 214);
            this.status_cmbx.Name = "status_cmbx";
            this.status_cmbx.Size = new System.Drawing.Size(121, 21);
            this.status_cmbx.TabIndex = 9;
            this.status_cmbx.SelectedIndexChanged += new System.EventHandler(this.status_cmbx_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Статус заказа:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(62, 214);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(56, 20);
            this.textBox4.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Итого:";
            // 
            // food_box
            // 
            this.food_box.FormattingEnabled = true;
            this.food_box.Location = new System.Drawing.Point(136, 18);
            this.food_box.Name = "food_box";
            this.food_box.Size = new System.Drawing.Size(121, 21);
            this.food_box.TabIndex = 4;
            this.food_box.SelectedIndexChanged += new System.EventHandler(this.food_box_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.price_tbx);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.add_food);
            this.groupBox2.Controls.Add(this.comment_food);
            this.groupBox2.Controls.Add(this.food_box);
            this.groupBox2.Location = new System.Drawing.Point(15, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 113);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавление нового блюда:";
            // 
            // price_tbx
            // 
            this.price_tbx.Location = new System.Drawing.Point(136, 75);
            this.price_tbx.Name = "price_tbx";
            this.price_tbx.Size = new System.Drawing.Size(121, 20);
            this.price_tbx.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Цена блюда:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(272, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Выберите количество:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Добавьте блюдо:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(399, 18);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(37, 20);
            this.numericUpDown1.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Комментарий к блюду:";
            // 
            // add_food
            // 
            this.add_food.Location = new System.Drawing.Point(361, 72);
            this.add_food.Name = "add_food";
            this.add_food.Size = new System.Drawing.Size(75, 23);
            this.add_food.TabIndex = 6;
            this.add_food.Text = "Добавить";
            this.add_food.UseVisualStyleBackColor = true;
            this.add_food.Click += new System.EventHandler(this.button2_Click);
            // 
            // comment_food
            // 
            this.comment_food.Location = new System.Drawing.Point(136, 47);
            this.comment_food.Name = "comment_food";
            this.comment_food.Size = new System.Drawing.Size(121, 20);
            this.comment_food.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Комментарий к заказу:";
            // 
            // comment_zakaza
            // 
            this.comment_zakaza.Location = new System.Drawing.Point(151, 483);
            this.comment_zakaza.Name = "comment_zakaza";
            this.comment_zakaza.Size = new System.Drawing.Size(224, 20);
            this.comment_zakaza.TabIndex = 12;
            // 
            // workers
            // 
            this.workers.FormattingEnabled = true;
            this.workers.Location = new System.Drawing.Point(62, 36);
            this.workers.Name = "workers";
            this.workers.Size = new System.Drawing.Size(121, 21);
            this.workers.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Курьер";
            // 
            // prev
            // 
            this.prev.Location = new System.Drawing.Point(12, 540);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(75, 23);
            this.prev.TabIndex = 16;
            this.prev.Text = "<<";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(702, 540);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 17;
            this.next.Text = ">>";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(534, 12);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 23);
            this.del.TabIndex = 18;
            this.del.Text = "Удалить";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // load_button
            // 
            this.load_button.Location = new System.Drawing.Point(615, 12);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(75, 23);
            this.load_button.TabIndex = 19;
            this.load_button.Text = "Загрузить";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(585, 99);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(134, 31);
            this.save.TabIndex = 20;
            this.save.Text = "Сохранить изменения";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // new_but
            // 
            this.new_but.Location = new System.Drawing.Point(585, 62);
            this.new_but.Name = "new_but";
            this.new_but.Size = new System.Drawing.Size(134, 31);
            this.new_but.TabIndex = 21;
            this.new_but.Text = "Добавить заказ";
            this.new_but.UseVisualStyleBackColor = true;
            this.new_but.Click += new System.EventHandler(this.new_but_Click);
            // 
            // settings_btn
            // 
            this.settings_btn.Location = new System.Drawing.Point(696, 12);
            this.settings_btn.Name = "settings_btn";
            this.settings_btn.Size = new System.Drawing.Size(75, 23);
            this.settings_btn.TabIndex = 22;
            this.settings_btn.Text = "Настройки";
            this.settings_btn.UseVisualStyleBackColor = true;
            this.settings_btn.Click += new System.EventHandler(this.settings_btn_Click);
            // 
            // Repair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 584);
            this.Controls.Add(this.settings_btn);
            this.Controls.Add(this.new_but);
            this.Controls.Add(this.save);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.del);
            this.Controls.Add(this.next);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.workers);
            this.Controls.Add(this.comment_zakaza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.clients);
            this.Controls.Add(this.label1);
            this.Name = "Repair";
            this.Text = "Оформление заказа.";
            this.Load += new System.EventHandler(this.Repair_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox clients;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox adress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox food_box;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button add_food;
        private System.Windows.Forms.TextBox comment_food;
        private System.Windows.Forms.ComboBox status_cmbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox price_tbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox comment_zakaza;
        private System.Windows.Forms.ComboBox workers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button new_but;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
        private System.Windows.Forms.Button settings_btn;
    }
}

