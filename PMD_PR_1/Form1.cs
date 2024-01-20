using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * ЗАДАНИЕ
 * Разместите в окне поле ввода (TextBox) и две кнопки (Button) с надписями:
 * «блокировать», «разблокировать». Создайте обработчики события нажатия на кнопки,
 * которые будут делать активным или неактивным поле ввода. Создайте обработчик
 * события нажатия кнопки мышки в окне (MouseDown), который будет устанавливать
 * цвет формы и делать невидимыми все элементы.
 */

namespace PMD_PR_1
{
    public partial class Form1 : Form
    {
        // Объявим элементы формы
        TextBox tbx;
        Button btnUnblock;
        Button btnBlock;

        public Form1()
        {
            InitializeComponent();
            start();
        }

        private void start()
        {
            // метод добавляет элементы на форму и привязывает методы обработки событий
            // Инициализация элементов формы:
            tbx = new TextBox();
            btnUnblock = new Button();
            btnBlock = new Button();

            // Свойства текстового поля:
            tbx.Location = new Point(10, 10);
            tbx.Size = new Size(250, 20);
            this.Controls.Add(tbx);

            // Свойства кнопки "Блокировать":
            btnBlock.Location = new Point(10, 50);
            btnBlock.Size = new Size(250, 40);
            btnBlock.Text = "Блокировать";
            btnBlock.Click += btnClickEvent;
            this.Controls.Add(btnBlock);

            // Свойства кнопки "Разблокировать2:
            btnUnblock.Location = new Point(10, 90);
            btnUnblock.Size = new Size(250, 40);
            btnUnblock.Text = "Разблокировать";
            btnUnblock.Click += btnClickEvent;
            this.Controls.Add(btnUnblock);

            // Привязка метода при нажатии на поле формы:
            this.MouseDown += mouseDownEvent;
        }

        private void btnClickEvent(object sender, EventArgs e)
        {
            // Метод обработки события нажатия на кнопку (мне кажется луюше использовать свойство Enabled):
            Button b = (Button)sender;
            tbx.Enabled = (b.Text == "Разблокировать");
        }

        private void mouseDownEvent(object sender, EventArgs e)
        {
            // Метод обработки события нажатия на форму:
            this.BackColor = Color.Green;
            foreach (Control c in this.Controls)
                c.Visible = false;
        }

    }
}
