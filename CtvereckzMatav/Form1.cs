namespace CtvereckzMatav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            MultiplikacniCtverek multiplikacniCtverecek = new MultiplikacniCtverek();
            panel1.Controls.Add(multiplikacniCtverecek);
            multiplikacniCtverecek.Location = e.Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}