using System;
using System.Drawing;
using System.Windows.Forms;
using InfoTech8;

namespace InfoTech_8Window
{
    public partial class MainForm : Form
    {
        private int counter = 5;
        public MainForm()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            AddEntity(new Technic(new AverageTechnic()));
            AddEntity(new Technic(new AverageTechnic()));
            AddEntity(new Quadcopter("Квадрокоптер #1"));
            AddEntity(new Quadcopter("Квадрокоптер #2"));
            AddEntity(new Quadcopter("Квадрокоптер #3"));
            AddEntity(new Quadcopter("Квадрокоптер #4"));
        }

        private void AddEntity(AbstractEntity entity)
        {
            var view = new ListBox();
            view.Items.Add($"Имя: {entity.Name}");
            view.Items.Add($"Состояние: отдыхает.");
            view.Size = new Size(340, 40);
            entity.ActorEvent += state => view.Items[1] = $"Состояние: {state}";
            Panel.Controls.Add(view);
        }

        private void AddSlowTechnic_Click(object sender, EventArgs e)
        {
            AddEntity(new Technic(new SlowTechnic()));
        }

        private void AddAverageTechnic_Click(object sender, EventArgs e)
        {
            AddEntity(new Technic(new AverageTechnic()));
        }

        private void AddFastTechnic_Click(object sender, EventArgs e)
        {
            AddEntity(new Technic(new FastTechnic()));
        }

        private void AddQuadcopter_Click(object sender, EventArgs e)
        {
            string name = "Квадрокоптер #" + counter++;
            AddEntity(new Quadcopter(name));
        }
    }
}
