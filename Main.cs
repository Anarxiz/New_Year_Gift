namespace WinFormsLab
{
    public partial class Main : Form
    {
        public static New_Year_gift.Gift Gift;
        public Main()
        {
            InitializeComponent();
            Gift = Logic.ProductFactory.CreateGift();
            UpdateListBox();

        }
        private void UpdateListBox()
        {
            listBox_Sweets.Items.Clear();
            foreach (var sweet in Gift.Sweets)
            {
                listBox_Sweets.Items.Add(sweet.Name);
            }
            Label_Weight.Text = "Total Weight: " + Logic.Logic.GetTotalWeight(Gift);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit(true);
            edit.ShowDialog();
            UpdateListBox();
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit(false, listBox_Sweets.SelectedIndex);
            edit.ShowDialog();
            UpdateListBox();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (listBox_Sweets.SelectedIndex != -1)
            {
                for (int i = 0; i < Gift.Sweets.Count; i++)
                    if (Gift.Sweets[i].Name == listBox_Sweets.SelectedItem.ToString())
                    {
                        Gift.Sweets.RemoveAt(i);
                        break;
                    }
            }
            UpdateListBox();
        }
    }
}
