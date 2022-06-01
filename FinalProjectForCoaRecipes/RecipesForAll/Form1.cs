using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipesForAll
{
   
    public partial class Form1 : Form
    {
        // Deserts, Breakfast, MainDish, Vegetarian, Appetisers
        //
        String[] Name1 = new String[100];
        String[] Ingredients = new String[100];
        String[] Recipe = new String[100];
        int i;
        public Form1()
        {
            InitializeComponent();
            checkedListBox4.SetItemCheckState(0, CheckState.Checked);
            int i = 0;
            SqlConnection conn = new SqlConnection("Server=.\\SQLEXPRESS;Database=Recipes;Integrated Security=true");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Name, Ingredients, Recipe FROM Appetisers", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Name1[i] = reader.GetString(0);
                Ingredients[i] = reader.GetString(1);
                Recipe[i] = reader.GetString(2);
                i++;
            }
            reader.Close();
            cmd = new SqlCommand("SELECT Name, Ingredients, Recipe FROM Breakfast", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Name1[i] = reader.GetString(0);
                Ingredients[i] = reader.GetString(1);
                Recipe[i] = reader.GetString(2);
                i++;
            }
            reader.Close();
            cmd = new SqlCommand("SELECT Name, Ingredients, Recipe FROM Deserts", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Name1[i] = reader.GetString(0);
                Ingredients[i] = reader.GetString(1);
                Recipe[i] = reader.GetString(2);
                i++;
            }
            reader.Close();
            cmd = new SqlCommand("SELECT Name, Ingredients, Recipe FROM MainDish", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Name1[i] = reader.GetString(0);
                Ingredients[i] = reader.GetString(1);
                Recipe[i] = reader.GetString(2);
                i++;
            }
            reader.Close();
            cmd = new SqlCommand("SELECT Name, Ingredients, Recipe FROM Vegetarian", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Name1[i] = reader.GetString(0);
                Ingredients[i] = reader.GetString(1);
                Recipe[i] = reader.GetString(2);
                i++;
            }
            reader.Close();
            conn.Close();
            this.i = i;
            listView1.Items.Clear();
            ListViewItem item;
            for (int k = 0; k < this.i; k++)
            {
                item = new ListViewItem(Name1[k]);
                item.SubItems.Add(Ingredients[k]);
                listView1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            SqlConnection conn = new SqlConnection("Server=.\\SQLEXPRESS;Database=Recipes;Integrated Security=true");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Name, Ingredients, Recipe FROM Appetisers", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Name1[i] = reader.GetString(0);
                Ingredients[i] = reader.GetString(1);
                Recipe[i] = reader.GetString(2);
                i++;
            }
            reader.Close();
            cmd = new SqlCommand("SELECT Name, Ingredients, Recipe FROM Breakfast", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Name1[i] = reader.GetString(0);
                Ingredients[i] = reader.GetString(1);
                Recipe[i] = reader.GetString(2);
                i++;
            }
            reader.Close();
            cmd = new SqlCommand("SELECT Name, Ingredients, Recipe FROM Deserts", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Name1[i] = reader.GetString(0);
                Ingredients[i] = reader.GetString(1);
                Recipe[i] = reader.GetString(2);
                i++;
            }
            reader.Close();
            cmd = new SqlCommand("SELECT Name, Ingredients, Recipe FROM MainDish", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Name1[i] = reader.GetString(0);
                Ingredients[i] = reader.GetString(1);
                Recipe[i] = reader.GetString(2);
                i++;
            }
            reader.Close();
            cmd = new SqlCommand("SELECT Name, Ingredients, Recipe FROM Vegetarian", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Name1[i] = reader.GetString(0);
                Ingredients[i] = reader.GetString(1);
                Recipe[i] = reader.GetString(2);
                i++;
            }
            reader.Close();
            conn.Close();
            this.i = i;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ListViewItem item;
            bool viable = true;
            for(int i = 0; i < this.i; i++)
            {
                if (checkedListBox4.GetItemChecked(0)) viable = false;
                if (checkedListBox4.GetItemChecked(1)) viable = true;
                if (checkedListBox1.GetItemChecked(0) && checkedListBox4.GetItemChecked(0)) if (Ingredients[i].Contains("Chicken")) viable = true;
                if (checkedListBox1.GetItemChecked(1) && checkedListBox4.GetItemChecked(0)) if (Ingredients[i].Contains("Ham")) viable = true;
                if (checkedListBox1.GetItemChecked(2) && checkedListBox4.GetItemChecked(0)) if (Ingredients[i].Contains("Pork")) viable = true;
                if (checkedListBox1.GetItemChecked(3) && checkedListBox4.GetItemChecked(0)) if (Ingredients[i].Contains("Beef")) viable = true;
                if (checkedListBox1.GetItemChecked(4) && checkedListBox4.GetItemChecked(0)) if (Ingredients[i].Contains("Sausage")) viable = true;
                if (checkedListBox1.GetItemChecked(5) && checkedListBox4.GetItemChecked(0)) if (Ingredients[i].Contains("Cheese")) viable = true;
                if (checkedListBox2.GetItemChecked(0) && checkedListBox4.GetItemChecked(0)) if (Ingredients[i].Contains("Onion")) viable = true;
                if (checkedListBox2.GetItemChecked(1) && checkedListBox4.GetItemChecked(0)) if (Ingredients[i].Contains("Tomatoes")) viable = true;
                if (checkedListBox2.GetItemChecked(2) && checkedListBox4.GetItemChecked(0)) if (Ingredients[i].Contains("Mushroom")) viable = true;
                if (checkedListBox2.GetItemChecked(3) && checkedListBox4.GetItemChecked(0)) if (Ingredients[i].Contains("Garlic")) viable = true;
                if (checkedListBox2.GetItemChecked(4) && checkedListBox4.GetItemChecked(0)) if (Ingredients[i].Contains("Bread")) viable = true;
                if (checkedListBox2.GetItemChecked(5) && checkedListBox4.GetItemChecked(0)) if (Ingredients[i].Contains("Eggs")) viable = true;
                if (checkedListBox3.GetItemChecked(0) && checkedListBox4.GetItemChecked(0)) if (Ingredients[i].Contains("Milk")) viable = true;
                if (checkedListBox3.GetItemChecked(1) && checkedListBox4.GetItemChecked(0)) if (Ingredients[i].Contains("Chilli")) viable = true;
                if (checkedListBox3.GetItemChecked(2) && checkedListBox4.GetItemChecked(0)) if (Ingredients[i].Contains("Cinnamon")) viable = true;
                if (checkedListBox3.GetItemChecked(3) && checkedListBox4.GetItemChecked(0)) if (Ingredients[i].Contains("Ginger")) viable = true;
                if (checkedListBox3.GetItemChecked(4) && checkedListBox4.GetItemChecked(0)) if (Ingredients[i].Contains("Vanilla")) viable = true;
                if (checkedListBox3.GetItemChecked(5) && checkedListBox4.GetItemChecked(0)) if (Ingredients[i].Contains("Lemon")) viable = true;
                if (checkedListBox1.GetItemChecked(0) && checkedListBox4.GetItemChecked(1)) if (Ingredients[i].Contains("Chicken")) viable = false;
                if (checkedListBox1.GetItemChecked(1) && checkedListBox4.GetItemChecked(1)) if (Ingredients[i].Contains("Ham")) viable = false;
                if (checkedListBox1.GetItemChecked(2) && checkedListBox4.GetItemChecked(1)) if (Ingredients[i].Contains("Pork")) viable = false;
                if (checkedListBox1.GetItemChecked(3) && checkedListBox4.GetItemChecked(1)) if (Ingredients[i].Contains("Beef")) viable = false;
                if (checkedListBox1.GetItemChecked(4) && checkedListBox4.GetItemChecked(1)) if (Ingredients[i].Contains("Sausage")) viable = false;
                if (checkedListBox1.GetItemChecked(5) && checkedListBox4.GetItemChecked(1)) if (Ingredients[i].Contains("Cheese")) viable = false;
                if (checkedListBox2.GetItemChecked(0) && checkedListBox4.GetItemChecked(1)) if (Ingredients[i].Contains("Onion")) viable = false;
                if (checkedListBox2.GetItemChecked(1) && checkedListBox4.GetItemChecked(1)) if (Ingredients[i].Contains("Tomatoes")) viable = false;
                if (checkedListBox2.GetItemChecked(2) && checkedListBox4.GetItemChecked(1)) if (Ingredients[i].Contains("Mushroom")) viable = false;
                if (checkedListBox2.GetItemChecked(3) && checkedListBox4.GetItemChecked(1)) if (Ingredients[i].Contains("Garlic")) viable = false;
                if (checkedListBox2.GetItemChecked(4) && checkedListBox4.GetItemChecked(1)) if (Ingredients[i].Contains("Bread")) viable = false;
                if (checkedListBox2.GetItemChecked(5) && checkedListBox4.GetItemChecked(1)) if (Ingredients[i].Contains("Eggs")) viable = false;
                if (checkedListBox3.GetItemChecked(0) && checkedListBox4.GetItemChecked(1)) if (Ingredients[i].Contains("Milk")) viable = false;
                if (checkedListBox3.GetItemChecked(1) && checkedListBox4.GetItemChecked(1)) if (Ingredients[i].Contains("Chilli")) viable = false;
                if (checkedListBox3.GetItemChecked(2) && checkedListBox4.GetItemChecked(1)) if (Ingredients[i].Contains("Cinnamon")) viable = false;
                if (checkedListBox3.GetItemChecked(3) && checkedListBox4.GetItemChecked(1)) if (Ingredients[i].Contains("Ginger")) viable = false;
                if (checkedListBox3.GetItemChecked(4) && checkedListBox4.GetItemChecked(1)) if (Ingredients[i].Contains("Vanilla")) viable = false;
                if (checkedListBox3.GetItemChecked(5) && checkedListBox4.GetItemChecked(1)) if (Ingredients[i].Contains("Lemon")) viable = false;
                if (viable == true)
                {
                    item = new ListViewItem(Name1[i]);
                    item.SubItems.Add(Ingredients[i]);
                    listView1.Items.Add(item);
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
        }

        private void ItemActive(object sender, EventArgs e)
        {
            this.Width = 1150;
            String SelectedItem =listView1.SelectedItems[0].Text;
            label1.Text = SelectedItem;
            for(int i=0; i<this.i;i++)
            {
                if(SelectedItem == Name1[i])
                {
                    textBox1.Text = Recipe[i];
                    label4.Text = Ingredients[i];
                }
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Width = 635;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false) panel1.Visible = true;
            else panel1.Visible = false;
        }

        private void checkedListBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox4_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox4.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox4.SetItemChecked(ix, false);

           
        }

        private void button6_Click(object sender, EventArgs e)
        {
                for(int k =0;k<6;k++)
                {
                checkedListBox1.SetItemChecked(k, true);
                }
            for (int k = 0; k < 6; k++)
            {
                checkedListBox2.SetItemChecked(k, true);
            }
            for (int k = 0; k < 6; k++)
            {
                checkedListBox3.SetItemChecked(k, true);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < 6; k++)
            {
                checkedListBox1.SetItemCheckState(k, CheckState.Unchecked);
            }
            for (int k = 0; k < 6; k++)
            {
                checkedListBox2.SetItemCheckState(k, CheckState.Unchecked);
            }
            for (int k = 0; k < 6; k++)
            {
                checkedListBox3.SetItemCheckState(k, CheckState.Unchecked);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int rInt = r.Next(0, this.i);
            this.Width = 1150;
            label1.Text = Name1[rInt];
            label4.Text = Ingredients[rInt];
            textBox1.Text = Recipe[rInt];
            

        }

       
    }
}
