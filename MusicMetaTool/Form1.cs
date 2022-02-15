namespace MusicMetaTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
                

            using (var fbd = new FolderBrowserDialog())
            {
                fbd.InitialDirectory = "C:\\Users\\maxym\\OneDrive\\Desktop\\New folder";
                DialogResult result = fbd.ShowDialog();


                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);

                    foreach(var file in files)
                    {
                        string[] row = { file };
                        var listViewItem = new ListViewItem(row);
                        listView1.Items.Add(listViewItem);
                    }
                }
            }

        }
    }
}