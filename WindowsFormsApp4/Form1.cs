using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedElementInfo();
            buttonRemove_Enabled();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxElements.Items.Add("Первый элемент");
            listBoxElements.Items.Add("Второй элемент");
            listBoxElements.Items.Add("Третий элемент");
            listBoxElements.Items.Add("Другой элемент");
            listBoxElements.Items.Add("N-элемент");

            UpdateSelectedElementInfo();
        }

        private void UpdateSelectedElementInfo()
        {
            if(listBoxElements.SelectedIndex == -1)
            {
                textBoxInfoSelectedItem.Text = "Не выбран ни один элемент";
                return;
            }
            string selectedItem = (string)listBoxElements.SelectedItem;
            textBoxInfoSelectedItem.Text = "Выбран элемент списка: " + selectedItem;
        }

        private void buttonAddElement_Click(object sender, EventArgs e)
        {
            string newItem = textBoxNewItem.Text;
            listBoxElements.Items.Add(newItem);
            Addlog("Добавлен элемент " + newItem);
            ClearTextBox();

            buttonRemove_Enabled();
            buttonClearList_Enabled();
        }

        private void buttonAddElement_Enabled()
        {
            buttonAddElement.Enabled = textBoxNewItem.Text != "" &&
                textBoxNewItem.ForeColor != Color.LightGray;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if(listBoxElements.SelectedItems != null)
            {
                listBoxElements.Items.Remove(listBoxElements.SelectedItem);
                Addlog("Удалён элемент " + listBoxElements.SelectedItems);
            }
            buttonRemove_Enabled();
            buttonClearList_Enabled();
        }

        private void buttonRemove_Enabled()
        {
            buttonRemove.Enabled = listBoxElements.Items.Count > 0 &&
                listBoxElements.SelectedItems != null;
        }

        private void buttonClearList_Click(object sender, EventArgs e)
        {
            listBoxElements.Items.Clear();
            buttonRemove_Enabled();
            buttonClearList_Enabled();
            Addlog("Список полностью очищен");
        }

        private void buttonClearList_Enabled()
        {
            buttonClearList.Enabled = listBoxElements.Items.Count > 0;
        }

        private void Addlog(string logMessage)
        {
            textBoxLog.Text += logMessage + "\r\n";
        }
        private void ClearTextBox()
        {
            textBoxNewItem.ForeColor = Color.LightGray;
            textBoxNewItem.Text = "Введите элемент для добавления";

        }

        private void textBoxNewItem_MouseEnter(object sender, EventArgs e)
        {
            if(textBoxNewItem.ForeColor == Color.LightGray)
            {
                textBoxNewItem.Text = "";
                textBoxNewItem.ForeColor = SystemColors.WindowText;
            }
        }

        private void textBoxNewItem_MouseLeave(object sender, EventArgs e)
        {
            if(textBoxNewItem.Text == "")
            {
                ClearTextBox();
            }
        }

        private void textBoxNewItem_TextChanged(object sender, EventArgs e)
        {
            buttonAddElement_Enabled();
            buttonRemove_Enabled();
        }

        private void buttonClearLog_Click(object sender, EventArgs e)
        {
            textBoxLog.Text = "";
        }
    }
}
