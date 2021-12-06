using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayListFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        ArrayList L1 = new ArrayList();

        private void btn_Add_Click(object sender, EventArgs e)
        {
         L1.Add(txt_item.Text);
            listbox_list.Items.Add(txt_item.Text);
        }

        private void btn_List_Click(object sender, EventArgs e)
        {
            listboxTemizke();
        }
        private void listboxTemizke()
        {
            listbox_list.Items.Clear();
            foreach (object item in L1)
            {
                listbox_list.Items.Add(item);
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (listbox_list.SelectedItem!=null)
            {
                L1.Remove(listbox_list.SelectedItem);


            }
            else
            {
                L1.Remove(txt_item.Text);

            }
            listboxTemizke();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
          

            try
            {
                int secilenİndex = listbox_list.SelectedIndex;
                L1[secilenİndex] = txt_item.Text;
                listboxTemizke();
            }
            catch
            {

                MessageBox.Show("Düzenlemek istediğiniz değeri seçmediniz!");
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            listboxTemizke();
            bool kontrol = L1.Contains(txt_item.Text);
            if (kontrol)
            {
                int eleman = L1.IndexOf(txt_item.Text);
                MessageBox.Show($"Aradağınız değer dizinin {eleman+1}. elemanıdır");
            }
            else
            {
                MessageBox.Show("Aradağınız değer yok!");
            }


        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
