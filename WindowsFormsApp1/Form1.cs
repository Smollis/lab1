﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "Свойства и события элемента Button \n" +
                    "Name: Имя элемента управления. \n" +
                    "Text: Текст на кнопке. \n" +
                    "Width: Ширина элемента. \n" +
                    "Size: Определяет размер элемента. \n" +
                    "Image:	Возвращает или задаёт изображение, отображаемое на элементе управления Кнопка.\n" +
                    "... \n" +
                    "Click:	Происходит при щелчке элемента управления. \n" +
                    "DoubleClick: Происходит при двойном щелчке мышью элемента управления Button. \n";

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label3.Text = "Свойства и события элемента Label \n" +
                   "Name: имя элемента, по которому можно обращаться в коде \n" +
                   "Text: Возвращает или задает текст, связанный с этим элементом управления." +
                   "Size: Возвращает или задает высоту и ширину элемента управления. \n" +
                   "Image: Возвращает или задаёт изображение, отображаемое на элементе управления Label. \n" +
                   "Visible: Получает или задает значение, указывающее, отображается ли элемент управления. \n" +
                   "... \n" +
                   "Click: Происходит при щелчке элемента управления. \n" +
                   "DoubleClick: Происходит при двойном щелчке мышью элемента управления Button. \n";
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = "Свойства и события элемента ComboBox \n" +
                    "Name: имя элемента, по которому можно обращаться в коде \n" +
                    "Text: Возвращает или задает текст, связанный с этим элементом управления." +
                    "Size: Возвращает или задает высоту и ширину элемента управления. \n" +
                    "Items:	Хранение элементов списка в ComboBox \n" +
                    "... \n" +
                    "Select: Активирует элемент управления. \n" +
                    "SelectedIndexChanged: Позволяет отследить выбор элемента в списке: \n" +
                    "OnMouseClick(MouseEventArgs): Вызывает событие MouseClick. \n";

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            label3.Text = "Свойства и события элемента TabControl:\n" +
                "Name: имя элемента по которому можно обращаться в коде\n" +
                "Text: Возвращает или задает текст, связанный с этим элементом управления. \n" +
                "Size: Возвращает или задает высоту и ширину элемента управления. \n" +
                "Margin: Возвращает или задает расстояние между элементами управления.\n" +
                "... \n" +
                "Click: происходит при щелчке элемента управления\n" +
                "Selected: происходит после выбора вкладки\n" +
                "Deselceted: просиходит при отмене выбора вкладки в качестве главной\n";
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "TextBox")
            {
                label3.Text = "Свойства и события элемента TextBox \n" +
                    "Name:  имя элемента, по которому можно обращаться в коде \n" +
                    "Text: Возвращает или задает текст, связанный с этим элементом управления. \n" +
                    "Size: Возвращает или задает высоту и ширину элемента управления. \n" +
                    "TextAlign:	Получает или задает выравнивание текста в элементе управления TextBox. \n" +
                    "Multiline:	Определяет поддерживает ли элемент многострочный текст. \n" +
                    "... \n" +
                    "Click:	Происходит при щелчке элемента управления. \n" +
                    "DoubleClick: Происходит при двойном щелчке мышью элемента управления TextBox. \n" +
                    "DoubleClick: Происходит при двойном щелчке мышью элемента управления TextBox. \n" +
                    "TextChanged: Происходит при изменении содержимого текстового окна TextBox. \n";

            }
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Свойства и события элемента CheckBox:\n" +
                "Name: имя элемента по которому можно обращаться в коде\n" +
                "Text: текст на элементе\n" +
                "TextAlign:	Получает или задает выравнивание текста в элементе управления CheckBox.\n" +
                "Image:	Возвращает или задаёт изображение, отображаемое на элементе управления CheckBox.\n" +
                "Checked: Возвращает или задаёт значение, указывающее, находится ли CheckBox во включённом состоянии.\n" +
                "... \n" +
                "Click: Происходит при щелчке элемента управления.\n" +
                "DoubleClick: Происходит при двойном щелчке мышью элемента управления CheckBox.\n" +
                "CheckedChanged: Возникает при переходе RadioButton во включённое состояние.\n";

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0)
            {
                label4.Text = "Свойства и события элемента NumericUpDown:\n" +
                    "Name: имя элемента по которому можно обращаться в коде\n" +
                    "Value: Возвращает или задает значение, присвоенное счетчику.\n" +
                    "Visible: Получает или задает значение, указывающее, отображается ли элемент управления.\n" +
                    "Minimum: Возвращает или задает минимальное допустимое значение для счетчика.\n" +
                    "Maximum: Возвращает или задает максимальное значение для счетчика.\n" +
                     "... \n" +
                    "Click: Происходит при щелчке элемента управления.\n" +
                    "DoubleClick: Происходит при двойном щелчке мышью элемента управления numericUpDown.\n" +
                    "CheckedChanged: Возникает при переходе RadioButton во включённое состояние.\n";
            }
            else { label4.Text = "Свойства и события элементов"; }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label3.Text = "Свойства и события элемента PictureBox:\n" +
                "Name: имя элемента по которому можно обращаться в коде\n" +
                "Image: устанавливает объект типа Image\n" +
                "ImageLocation: устанавливает путь к изображению на диске или в интернете\n" +
                "ErrorImage: изображение, которое отображается, если основное изображение не удалось загрузить в PictureBox\n" +
                 "... \n" +
                "Click: происходит при щелчке элемента управления\n" +
                "KeyPress: Происходит при нажатии клавиши, если элемент управления имеет фокус.\n" +
                "MouseClick: Вызывается при щелчке мышью элемента управления.\n" +
                "Move: происходит при перемещении элмента\n" +
                "Resize: просиходит при изменении размера элемента";
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "MaskedTextBox")
            {
                label3.Text = "Свойства и события элемента MaskedTextBox:\n" +
                    "Name: имя элемента по которому можно обращаться в коде\n" +
                    "Text: текст на элементе\n" +
                    "Font: Возвращает или задает шрифт текста, отображаемого элементом управления.\n" +
                    "Margin: Возвращает или задает расстояние между элементами управления.\n" +
                    "TextAlign: задаёт выравнивание текста в элементе\n" +
                    "... \n" +
                    "Click: происходит при щелчке элемента управления\n" +
                    "MaskInputRejected: происходит, если символ не удовлетворяет условиям маски\n" +
                    "Resize: происиходит при изменении размера элемента";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Свойства и события RadioButton \n" +
                "Name: Возвращает или задает имя элемента управления. \n" +
                "Size: Возвращает или задает высоту и ширину элемента управления. \n" +
                "Text: Возвращает или задает текст, связанный с этим элементом управления. \n" +
                "TextAlign:	Получает или задает выравнивание текста в элементе управления RadioButton. \n" +
                "Checked: Возвращает или задаёт значение, указывающее, находится ли RadioButton во включённом состоянии. \n" +
                "... \n" +
                "Click:	Происходит при щелчке элемента управления. \n" +
                "DoubleClick: Происходит при двойном щелчке мышью элемента управления RadioButton. \n" +
                "CheckedChanged: Возникает при переходе RadioButton во включённое состояние. \n";

        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label3.Text = "Свойства и события элемента MenuStrip:\n" +
                "Name: имя элемента по которому можно обращаться в коде\n" +
                "BackColor: цвет фона элемента\n" +
                "Font: выбор шрифта\n" +
                "ForeColor: цвет для текста\n" +
                "Text: текст на элементе\n" +
                "... \n" +
                "Click: происходит при щелчке элемента управления\n" +
                "DragDrop: вызывается при завершении операции перетаскивания\n" +
                "Enter: происходит при входе в элемент управления\n";

        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {
            label4.Text = "Свойства и события элемента GroupBox\n" +
                "Name: имя элемента по которому можно обращаться в коде\n" +
                "Text: Позволяет установить заголовок формы\n" +
                "BackColor: Цвет фона элемента\n" +
                "Font: Возвращает или задает шрифт текста, отображаемого элементом управления\n" +
                 "... \n" +
                "Click: Происходит при нажатии элемента управления GroupBox.\n" +
                "DoubleClick: Происходит при двойном щелчке элемента управления GroupBox.\n" +
                "Enter: происходит при входе в элемент управления\n";
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = "Свойства и события элемента ListBox\n" +
                "Name: имя элемента по которому можно обращаться в коде\n" +
                "Text: Позволяет установить заголовок формы\n" +
                "Font: Возвращает или задает шрифт текста, отображаемого элементом управления.\n" +
                "Size: Возвращает или задает высоту и ширину элемента управления." +
                 "... \n" +
                "Click: Возникает при щелчке элемента управления ListBox.\n" +
                "Enter: происходит при входе в элемент управления\n" +
                "SelectedIndexChanged: Возникает при изменении выделенного элемента";
        }

        private void dateTimePicker1_DropDown(object sender, EventArgs e)
        {
            label4.Text = "Свойства и события элемента DateTimePicker\n" +
                "Name: имя элемента по которому можно обращаться в коде\n" +
                "Format: определяет формат отображения даты в элементе управления\n" +
                "Text: Позволяет установить заголовок формы\n" +
                "MaxDate: наибольшая дата, которую можно выбрать\n" +
                "Value: определеяте текущее выбранное значение в DateTimePicker\n" +
                 "... \n" +
                 "CloseUp: Происходит при закрытии раскрывающегося календаря.\n" +
                 "DropDown: Происходит при отображении раскрывающегося календаря.\n" +
                 "ValueChanged: происходит при выборе даты\n";
        }


        private void button3_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            label4.Text = "Свойства и события элемента FolderBrowserDialog\n" +
                "Tag: Получает или задает объект, содержащий данные элемента управления.\n" +
                "Site: Получает или задает ISite объекта Component.\n" +
                "SelectedPath: Получает или задает путь, выбранный пользователем.\n" +
                 "... \n" +
                 "Disposed: Возникает при удалении компонента путем вызова метода Dispose().\n" +
                 "HelpRequest: Происходит при нажатии пользователем кнопки Help в диалоговом окне.\n";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            label4.Text = "Свойства и события элемента OpenFileDialog\n" +
                "Tag: Получает или задает объект, содержащий данные элемента управления.\n" +
                "Site: Получает или задает ISite объекта Component.\n" +
                "FileName: Возвращает или задает строку, содержащую имя файла, выбранного в диалоговом окне.\n" +
                "Title: Возвращает или задает заголовок диалогового окна файла.\n" +
                 "... \n" +
                 "FileOk: Происходит при нажатии пользователем кнопки Открыть или Сохранить в диалоговом окне файла.\n" +
                 "Disposed: Возникает при удалении компонента путем вызова метода Dispose().\n" +
                 "HelpRequest: Происходит при нажатии пользователем кнопки Help в диалоговом окне.\n";
        }


        private void button5_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            label4.Text = "Свойства и события элемента SaveFileDialog\n" +
                "Tag: Получает или задает объект, содержащий данные элемента управления.\n" +
                "Site: Получает или задает ISite объекта Component.\n" +
                "FileName: Возвращает или задает строку, содержащую имя файла, выбранного в диалоговом окне.\n" +
                "Title: Возвращает или задает заголовок диалогового окна файла.\n" +
                 "... \n" +
                 "FileOk: Происходит при нажатии пользователем кнопки Открыть или Сохранить в диалоговом окне файла.\n" +
                 "Disposed: Возникает при удалении компонента путем вызова метода Dispose().\n" +
                 "HelpRequest: Происходит при нажатии пользователем кнопки Help в диалоговом окне.\n";
        }

        private void Panel1_Scroll(object sender, ScrollEventArgs e)
        {
            label4.Text = "Свойства и события элемента Panel\n" +
                "Tag: Получает или задает объект, содержащий данные элемента управления.\n" +
                "Site: Получает или задает ISite объекта Component.\n" +
                "Size: Возвращает или задает высоту и ширину элемента управления.\n" +
                "Name: Возвращает или задает имя элемента управления.\n" +
                "Font: Возвращает или задает шрифт текста, отображаемого элементом управления.\n" +
                 "... \n" +
                 "FileOk: Происходит при нажатии пользователем кнопки Открыть или Сохранить в диалоговом окне файла.\n" +
                 "Disposed: Возникает при удалении компонента путем вызова метода Dispose().\n" +
                 "HelpRequest: Происходит при нажатии пользователем кнопки Help в диалоговом окне.\n";
        }

        private void button8_Click(object sender, EventArgs e)
        {
                progressBar1.Show();
                label3.Text = "Свойства и события элемента ProgressBar\n" +
                "Tag: Получает или задает объект, содержащий данные элемента управления.\n" +
                "Site: Получает или задает ISite объекта Component.\n" +
                "Value: Возвращает или задает текущее положение индикатора выполнения.\n" +
                "Maximum: Возвращает или задает наибольшее значение диапазона этого элемента управления.\n" +
                "Minimum: Возвращает или задает наименьшее значение диапазона этого элемента управления.\n" +
                 "... \n" +
                 "Click: Происходит при щелчке элемента управления.\n" +
                 "Enter: Происходит, когда в фокусе оказывается элемент управления ProgressBar..\n" +
                 "MouseClick: Вызывается при щелчке мышью элемента управления.\n";
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label3.Text = "Свойства и события элемента DataGridView\n" +
                "Tag: Получает или задает объект, содержащий данные элемента управления.\n" +
                "Site: Получает или задает ISite объекта Component.\n" +
                "Value: Возвращает или задает текущее положение индикатора выполнения.\n" +
                "Size: Возвращает или задает высоту и ширину элемента управления.\n" +
                "Rows: Позволяет задать строки в элементе\n" +
                 "... \n" +
                 "CellContentClick: Возникает при щелчке по содержимому ячейки\n" +
                 "Scroll: Происходит, когда пользователь прокручивает содержимое элемента\n";
        }

        
    }
}
