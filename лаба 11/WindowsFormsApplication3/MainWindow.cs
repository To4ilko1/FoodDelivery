using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Persons persons;
        Foods foods;
        Orders orders;
        Options options = new Options();
        Option option = new Option(Options.GetLine());
        int currentID;
        

        private void fillForm(Order order) // Заполнение формы заказом
        {
            currentID = order.ID;
            if (order.time != Convert.ToDateTime("01.01.0001 00:00:00"))
            {
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.Value = order.time;
            }
            if (order.client != null) clients.SelectedIndex = clients.FindStringExact(order.client.FIO);
            clients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            if (order.worker != null) workers.SelectedIndex = workers.FindStringExact(order.worker.FIO);
            workers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            if (order.adress != null) adress.Text = Convert.ToString(order.adress);
            if (order.comment != null) comment_zakaza.Text = Convert.ToString(order.comment);
            this.Text = "Заказ №" + Convert.ToString(order.ID);
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = 50;
            if (order.status == 0) status_cmbx.SelectedItem = "Принят";
            if (order.status == 1) status_cmbx.SelectedItem = "Готовится";
            if (order.status == 2) status_cmbx.SelectedItem = "У курьера";
            if (order.status == 3) status_cmbx.SelectedItem = "Доставлен";
            if (order.status == 4) status_cmbx.SelectedItem = "Отменён";
            status_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            dataGridView1.Rows.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.Rows.RemoveAt(i);
            }
            for (int i = 0; i < order.foods1.Count; i++)
            {
                Food temp2 = foods.findByID(order.foods1[i].ID);
                dataGridView1.Rows.Add(temp2.name, order.foods1[i].price, order.foods1[i].kol, order.foods1[i].comment_f, order.foods1[i].kol * order.foods1[i].price);
            }
            int sumprice = 0;
            for (int i = 0; i < order.foods1.Count; i++)
            {

                if (order.foods1[i].name != null) food_box.SelectedIndex = food_box.FindStringExact(order.foods1[i].name);
                if (order.foods1[i].comment_f != null) comment_food.Text = order.foods1[i].comment_f;
                if (order.foods1[i].kol != 0) numericUpDown1.Value = order.foods1[i].kol;
                if (order.foods1[i].price != 0) price_tbx.Text = Convert.ToString(order.foods1[i].price);
                if (order.foods1[i].price * order.foods1[i].kol != 0) sumprice = sumprice+ (order.foods1[i].price * order.foods1[i].kol);
            }
            textBox4.Text = Convert.ToString(sumprice);
        }
        private void LoadAll()
        {
            status_cmbx.Items.Add("Принят");
            status_cmbx.Items.Add("Готовится");
            status_cmbx.Items.Add("У курьера");
            status_cmbx.Items.Add("Доставлен");
            status_cmbx.Items.Add("Отменён");
            status_cmbx.SelectedIndex = 0;
            status_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            persons = new Persons();
            foods = new Foods();
            orders = new Orders(persons, foods);
            buildComboBox(clients, 0);
            buildComboBox(workers, 1);
            buildFoodBox();
            string ror = Convert.ToString(DateTime.Today);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            int id = orders.getMaxID();  // Получаем максимальный идентификатор заказа в списке
            Order order;
            if (id == 0) // Если номер - 0, то заказов в списке нет, показываем пустой на экране
            {
                id++;
                order = new Order(id); // Создаем новый заказ с id=1               
                orders.addOrder(order); // Добавляем заказ к глобальному массиву
            }
            else
            {
                order = orders.findByID(id); // Если заказы в списке есть, то ищем последний заказ
            }
            fillForm(order);
            foreach (Control c in this.Controls)
            {
                c.Enabled = true;
            }
            load_button.Enabled = false;
        }
        private void buildFoodBox() 
        {
            foreach (Food n in foods.getFood()) 
            {
                food_box.Items.Add(n.name);
            }
            food_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }
        private void buildComboBox(ComboBox cmb, byte type) // Формируем выпадающие списки клиентов и работников
        {
            foreach (Person p in persons.getPersonsList(type)) // Функция persons.getPersonsList(type) возвращает список или клиентов, или работников в зависимости от типа.
            {
                cmb.Items.Add(p.FIO);
            }
        }
        private void delete_Empty()
        {
            if (!CanIClose())
            {
                if (dataGridView1.Rows[0].Cells[0].Value == null)
                {

                    Order r = orders.findByID(currentID);
                    Order next = orders.getNext(currentID);
                    if (next.ID == currentID)
                    {
                        next = orders.getPrev(currentID);
                        if (next.ID == currentID)
                        {
                            int ID = orders.getMaxID() + 1;
                            next = new Order(ID);
                            orders.addOrder(next);
                        }
                    }
                    orders.delOrder(r);
                    fillForm(next);
                }
            }
        }
        private void saveThisForm() // Сохраняем все, что есть сейчас на форме
        {
            delete_Empty();
            Order b = orders.findByID(currentID); // Ищем из списка тот заказ, который показывается на форме
            b.client = persons.findByFIO(clients.GetItemText(clients.SelectedItem));
            b.worker = persons.findByFIO(workers.GetItemText(workers.SelectedItem));
            b.adress = adress.Text;
            b.comment = comment_zakaza.Text;
            b.time = dateTimePicker1.Value;
            b.status = status_cmbx.SelectedIndex;
            b.foods1.Clear();
            for (int j = 0; j < dataGridView1.Rows.Count - 1; j++)
            {
                Food temp1 = foods.findByName(Convert.ToString(dataGridView1.Rows[j].Cells[0].Value));
                int t = temp1.ID;
                Food temp = new Food(t, (int)dataGridView1.Rows[j].Cells[1].Value, (int)dataGridView1.Rows[j].Cells[2].Value, Convert.ToString(dataGridView1.Rows[j].Cells[3].Value));//должен передавать ID
                b.foods1.Add(temp);

            }
            // иначе сообщение об ошибке
            orders.ReplaceOrder(b);
        }
        private bool CanIClose()
        {
            if (dataGridView1.RowCount >= 2) return true;
            MessageBox.Show("Нет данных, заказ будет удален.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return false;
        }
        private void next_Click(object sender, EventArgs e)
        {
         
            saveThisForm();
            Order b = orders.getNext(currentID);
            fillForm(b);
        }
        private void prev_Click(object sender, EventArgs e)
        {
          
            saveThisForm();
            Order r = orders.getPrev(currentID);
            fillForm(r);
        }
        private void new_but_Click(object sender, EventArgs e)
        {
            if (CanIClose())
            {
                saveThisForm();
                int ID = orders.getMaxID() + 1;
                Order b = new Order(ID);
                orders.addOrder(b);
                clients.SelectedIndex = 0;
                workers.SelectedIndex = 0;
                status_cmbx.SelectedIndex = 0;
                fillForm(b);
                comment_zakaza.Text = "";
                comment_food.Text = "";
                food_box.SelectedIndex = 0;
                numericUpDown1.Value = 1;
                textBox4.Text = "";
                Food temp1 = foods.findByID(1);
                price_tbx.Text = Convert.ToString(temp1.price);
                options.GetDate();
                DateTime d1 = DateTime.Now;
                DateTime d2 = d1.AddHours(options.OptionsList[0].stndrt_time);
                dateTimePicker1.Value = d2;         
                workers.Text = options.OptionsList[0].stndrt_worker.FIO;
            }
        }
        private void del_Click(object sender, EventArgs e)
        {
            Order order = orders.findByID(currentID);
            Order next = orders.getNext(currentID);
            if (next.ID == currentID)
            {
                next = orders.getPrev(currentID);
                if (next.ID == currentID)
                {
                    int ID = orders.getMaxID() + 1;
                    next = new Order(ID);
                    orders.addOrder(next);
                }
            }
            orders.delOrder(order);
            fillForm(next);
        }
        private void save_Click(object sender, EventArgs e)
        {
            if (CanIClose())
            {
                saveThisForm();
                foods.saveFoods();
                orders.saveOrders();
                persons.savePersons();
            }
        }

        public int sum;
        public int price;
        private void button2_Click(object sender, EventArgs e)
        {
            sum = 0;
            string hava = Convert.ToString(food_box.SelectedItem);
            Food temp1 = foods.findByName(hava);
            string commentor = comment_food.Text;
            if (price_tbx.Text != "")
            {
                price = Int32.Parse(price_tbx.Text);
            }
            else
            {
                price = temp1.price;
            }
            int kolvo = (int)numericUpDown1.Value;
            int her = kolvo * price;
            dataGridView1.Rows.Add(hava, price, kolvo, commentor, her);
            comment_food.Text = "";
            numericUpDown1.Value = 1;
            List<int> temp = new List<int>();
            food_box.SelectedIndex = 0;
            price_tbx.Text = Convert.ToString(foods.findByID(food_box.SelectedIndex+1).price);
            for (int j = 0; j < dataGridView1.Rows.Count; j++)
            {
                if (dataGridView1.Rows[j].Cells[4].Value != null)
                {
                    sum = sum + (int)dataGridView1.Rows[j].Cells[4].Value;
                }
            }
            textBox4.Text = Convert.ToString(sum);
        }
        private void food_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            string hava = Convert.ToString(food_box.SelectedItem);
            Food temp1 = foods.findByName(hava);
            price_tbx.Text = Convert.ToString(temp1.price);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ind = dataGridView1.SelectedCells[0].RowIndex;
            int ind1 = dataGridView1.SelectedCells[0].ColumnIndex;
            if (ind1 == 5)
            {
                string hava = Convert.ToString(food_box.SelectedItem);
                Food temp1 = foods.findByName(hava);
                string commentor = comment_food.Text;
                int price = Int32.Parse(price_tbx.Text);
                int kolvo = (int)numericUpDown1.Value;
                int her = kolvo * price;
                if (ind == dataGridView1.Rows.Count - 1)
                {
                    dataGridView1.Rows.Add(hava, price, kolvo, commentor, her);
                }
                else
                {
                    dataGridView1.Rows[ind].Cells[0].Value = hava;
                    dataGridView1.Rows[ind].Cells[1].Value = price;
                    dataGridView1.Rows[ind].Cells[2].Value = kolvo;
                    dataGridView1.Rows[ind].Cells[3].Value = commentor;
                    dataGridView1.Rows[ind].Cells[4].Value = her;
                }
                sum = 0;
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    if (dataGridView1.Rows[j].Cells[4].Value != null)
                    {
                        sum = sum + (int)dataGridView1.Rows[j].Cells[4].Value;
                    }
                }
                textBox4.Text = Convert.ToString(sum);
            }
            if (ind1 == 6)
            {
                sum = 0;
                int ind2 = dataGridView1.SelectedCells[0].RowIndex;
                if (dataGridView1.Rows.Count == 1)
                {
                    dataGridView1.Rows.Clear();
                }
                if ((ind2 == dataGridView1.Rows.Count - 1) && (dataGridView1.Rows[ind2].Cells[0].Value == null))
                {
                    MessageBox.Show("Вы не можете удалить пустую строку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    dataGridView1.Rows.RemoveAt(ind2);
                }
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    if (dataGridView1.Rows[j].Cells[4].Value != null)
                    {
                        sum = sum + (int)dataGridView1.Rows[j].Cells[4].Value;
                    }
                }
                textBox4.Text = Convert.ToString(sum);
            }//НЕПРАВИЛЬНОЕ УДАЛЕНИЕ
        }
        private void status_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (status_cmbx.SelectedIndex == 0)
            {
                workers.Enabled = true;
                clients.Enabled = true;
                dateTimePicker1.Enabled = true;
                numericUpDown1.Enabled = true;
                food_box.Enabled = true;
                add_food.Enabled = true;
                adress.Enabled = true;
                comment_food.Enabled = true;
                price_tbx.Enabled = true;
                comment_zakaza.Enabled = true;
                textBox4.Enabled = true;
            }
            if (status_cmbx.SelectedIndex == 1)
            {
                workers.Enabled = true;
                clients.Enabled = false;
                dateTimePicker1.Enabled = true;
                numericUpDown1.Enabled = true;
                food_box.Enabled = true;
                add_food.Enabled = true;
                adress.Enabled = true;
                comment_food.Enabled = true;
                price_tbx.Enabled = true;
                comment_zakaza.Enabled = true;
                textBox4.Enabled = true;
            }
            if (status_cmbx.SelectedIndex == 2)
            {
                workers.Enabled = false;
                clients.Enabled = false;
                dateTimePicker1.Enabled = true;
                numericUpDown1.Enabled = false;
                food_box.Enabled = false;
                add_food.Enabled = false;
                adress.Enabled = true;
                comment_food.Enabled = false;
                price_tbx.Enabled = false;
                comment_zakaza.Enabled = true;
                textBox4.Enabled = false;
            }
             if (status_cmbx.SelectedIndex == 3)
            {
                workers.Enabled = false;
                clients.Enabled = false;
                dateTimePicker1.Enabled = true;
                numericUpDown1.Enabled = false;
                food_box.Enabled = false;
                add_food.Enabled = false;
                adress.Enabled = false;
                comment_food.Enabled = false;
                price_tbx.Enabled = false;
                comment_zakaza.Enabled = false;
                textBox4.Enabled = false;
            }
            if (status_cmbx.SelectedIndex == 4)
            {
                workers.Enabled = false;
                clients.Enabled = false;
                dateTimePicker1.Enabled = false;
                numericUpDown1.Enabled = false;
                food_box.Enabled = false;
                add_food.Enabled = false;
                adress.Enabled = false;
                comment_food.Enabled = false;
                price_tbx.Enabled = false;
                comment_zakaza.Enabled = false;
                textBox4.Enabled = false;
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].ReadOnly = true;
                }
            }
        }
        private void load_button_Click(object sender, EventArgs e)
        {
            LoadAll();
        }
        private void Repair_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = false;
            }
            load_button.Enabled = true;

        }
        private void clients_SelectedIndexChanged(object sender, EventArgs e)
        {
            adress.Text = persons.findByFIO(clients.SelectedItem.ToString()).adress;
        }
        private void settings_btn_Click(object sender, EventArgs e)
        {
            settings s = new settings();
            s.Owner = this;
            s.Show();
        }
    }
}
   
