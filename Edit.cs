using New_Year_gift;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsLab
{
    public partial class Edit : Form
    {
        New_Year_gift.AbstractSweet sweets;
        bool add_flag;
        int index;
        public Edit(bool add_flag)
        {
            InitializeComponent();
            Init();
            comboBoxClass.SelectedIndex = 0;
            this.add_flag = add_flag;
        }
        public Edit(bool add_flag, int index)
        {
            InitializeComponent();
            Init();
            this.index = index;
            sweets = Main.Gift.Sweets[index];
            this.add_flag = add_flag;
            LabelSet();
        }

        private void LabelSet()
        {
            labelProperities1.Text = "Название:";
            textBoxProperties1.Text = sweets.Name;
            labelProperities2.Text = "Вес:";
            numericUpDown1.Value = (decimal)sweets.Weight;
            if (sweets is ChocolateBar chocolateBar)
            {
                comboBoxClass.SelectedIndex = 0;
                labelProperities3.Text = "Тип шоколада:";
                textBoxProperties3.Text = chocolateBar.ChocolateType;
                labelProperities4.Text = "Процент какао:";
                textBoxProperties4.Text = chocolateBar.ChocolateContent;

            }
            else if (sweets is Caramel caramel)
            {
                comboBoxClass.SelectedIndex = 1;
                labelProperities3.Text = "Наличие начинки:";
                textBoxProperties3.Text = caramel.Filling.ToString();
                labelProperities4.Text = "Есть ли соль:";
                textBoxProperties4.Text = caramel.Salt.ToString();
            }
            else if (sweets is Jelly jelly)
            {
                comboBoxClass.SelectedIndex = 2;
                labelProperities3.Text = "Наличие начинки:";
                textBoxProperties3.Text = jelly.Filling.ToString();
                labelProperities4.Text = "Является халялем:";
                textBoxProperties4.Text = jelly._Halal.ToString();
            }
        }

        private void Init()
        {
            labelProperities1.Text = "Название:";
            labelProperities2.Text = "Вес:";
            comboBoxClass.Items.Add("Протеиновый батончик");
            comboBoxClass.Items.Add("Желейная конфета");
            comboBoxClass.Items.Add("Карамельная конфета");
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (CheckTextBox())
            {
                if (add_flag)
                    AddSweet();
                else
                    EditSweet();
                this.Close();
            }
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxClass.SelectedItem)
            {
                case "Протеиновый батончик":
                    {
                        labelProperities3.Text = "Тип шоколада:";
                        labelProperities4.Text = "Процент какао:";
                        break;
                    }
                case "Желейная конфета":
                    {
                        labelProperities3.Text = "Наличие начинки:";
                        labelProperities4.Text = "Является халялем:";
                        break;
                    }
                case "Карамельная конфета":
                    {
                        labelProperities3.Text = "Наличие начинки:";
                        labelProperities4.Text = "Есть ли соль:";
                        break;
                    }
            }
        }
        public void AddSweet()
        {
            string name = textBoxProperties1.Text;
            double weight = (double)numericUpDown1.Value;
            switch (comboBoxClass.SelectedItem)
            {
                case "Протеиновый батончик":
                    {
                        string type = textBoxProperties3.Text;
                        string content = textBoxProperties4.Text;
                        Main.Gift.Sweets.Add(Logic.ProductFactory.CreateChocolateBar(name, weight, type, content));
                        break;
                    }
                case "Желейная конфета":
                    {
                        bool filling = bool.Parse(textBoxProperties3.Text);
                        bool halal = bool.Parse(textBoxProperties4.Text);
                        Main.Gift.Sweets.Add(Logic.ProductFactory.CreateJelly(name, weight, filling, halal));
                        break;
                    }
                case "Карамельная конфета":
                    {
                        bool filling = bool.Parse(textBoxProperties3.Text);
                        bool salt = bool.Parse(textBoxProperties4.Text);
                        Main.Gift.Sweets.Add(Logic.ProductFactory.CreateCaramel(name, weight, filling, salt));
                        break;
                    }
            }
        }

        public void EditSweet()
        {
            string name = textBoxProperties1.Text;
            double weight = (double)numericUpDown1.Value;
            switch (comboBoxClass.SelectedItem)
            {
                case "Протеиновый батончик":
                    {
                        string type = textBoxProperties3.Text;
                        string content = textBoxProperties4.Text;
                        Main.Gift.Sweets[index] = Logic.ProductFactory.CreateChocolateBar(name, weight, type, content);
                        break;
                    }
                case "Желейная конфета":
                    {
                        bool filling = bool.Parse(textBoxProperties3.Text);
                        bool halal = bool.Parse(textBoxProperties4.Text);
                        Main.Gift.Sweets[index] = Logic.ProductFactory.CreateJelly(name, weight, filling, halal);
                        break;
                    }
                case "Карамельная конфета":
                    {
                        bool filling = bool.Parse(textBoxProperties3.Text);
                        bool salt = bool.Parse(textBoxProperties4.Text);
                        Main.Gift.Sweets[index] = Logic.ProductFactory.CreateCaramel(name, weight, filling, salt);
                        break;
                    }
            }
        }
        public bool CheckTextBox()
        {
            if (textBoxProperties1.Text is null)
                return false;
            if (numericUpDown1.Value == 0)
                return false;
            switch (comboBoxClass.SelectedIndex)
            {
                case 0:
                    {
                        if (string.IsNullOrEmpty(textBoxProperties3.Text))
                            return false;
                        if (string.IsNullOrEmpty(textBoxProperties4.Text))
                            return false;
                        break;
                    }
                case 1:
                case 2:
                    {
                        if (!(textBoxProperties3.Text.ToLower() == "true" || textBoxProperties3.Text.ToLower() == "false"))
                            return false;
                        if (!(textBoxProperties4.Text.ToLower() == "true" || textBoxProperties4.Text.ToLower() == "false"))
                            return false;
                        break;
                    }
            }
            return true;
        }
    }
}
