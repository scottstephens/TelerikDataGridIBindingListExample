using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelerikDataGridIBindingListExample
{
    public partial class Form1 : Form
    {
        private IBindingList list2;

        public Form1()
        {
            InitializeComponent();
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AutoGenerateColumns = false;
        }
        
        private void btnWorkingBind_Click(object sender, EventArgs e)
        {
            Bind(() => new BindingList<StudentObject>());
        }

        private void btnBrokenBind_Click(object sender, EventArgs e)
        {
            Bind(() => new BindingListWrapper<StudentObject>());
        }

        private void Bind(Func<IBindingList> builder)
        {
            list2 = builder();
            this.radGridView1.DataSource = list2;            
            AddData();
        }

        private void AddData()
        {
            if (list2.Count == 0)
            {
                list2.Add(new StudentObject("Brent", "Allen", 175.4f, 72.0f, 16));
                list2.Add(new StudentObject("Carolina", "Bailey", 160.7f, 46.0f, 18));
                //list2.Add(new StudentObject("Whitney", "Barnebey", 157.0f, 40.0f, 15));
                //list2.Add(new StudentObject("Sarah", "Beckham", 165.1f, 48.0f, 16));
                //list2.Add(new StudentObject("Dun", "Deng", 173.4f, 70.5f, null));
                //list2.Add(new StudentObject("Tu-Lin", "Chiu", 150.4f, 40.5f, 12));
                //list2.Add(new StudentObject("Alexandra", "Galambos", 152.4f, 42.0f, null));
                //list2.Add(new StudentObject("Tammy", "Goss", 175.4f, 75.3f, 18));
                //list2.Add(new StudentObject("Iljo", "Ha", 178.4f, 74.0f, 17));
                //list2.Add(new StudentObject("Merdith", "Johnson", 180.4f, 68.0f, 17));
                //list2.Add(new StudentObject("Yoon", "Jeon", 182.4f, 80.0f, 18));
                //list2.Add(new StudentObject("Blake", "Rodgers", 154.4f, 46.0f, 12));
                //list2.Add(new StudentObject("Rebecca", "Shields", 175.4f, 60.0f, null));
                //list2.Add(new StudentObject("Erica", "Sim", 175.8f, 72.6f, 18));
                //list2.Add(new StudentObject("Xiaoyi", "Sun", 167.4f, 53.0f, 16));
            }
        }
    }
}
