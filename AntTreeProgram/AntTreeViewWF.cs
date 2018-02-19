using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AntTreeProgram.DataXLS;
namespace AntTreeProgram
{
    public partial class AntTreeViewWF : Form, IAntTreeView
    {
        AntTreeControler controler = null;
        public AntTreeViewWF()
        {
            InitializeComponent();
            controler = new AntTreeControler(this);
            controler.SetOnStart();
        }

        public void AddDataToChart(Ant ant, Color color)
        {
           
        }
        public void ClearData()
        {
            Chart.Series[0].Points.Clear();
        }
        public void AddToSimCombobox(double value)
        {
            c_sim.Items.Add(value);
        }
        public void AddToDissimCombobox(double value)
        {
            c_dissim.Items.Add(value);
        }
        public void AddToRepoCombobox(XLSData nazwa)
        {
            cb_Repo.Items.Add(nazwa);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Group_Click(object sender, EventArgs e)
        {
            controler.GroupData();
            controler.SetData();
        }
        public object GetDissim()
        {
            object value=c_dissim.SelectedItem;
            return value??"0";
        }
        
        public XLSData GetRepoName()
        {
            object value = cb_Repo.SelectedItem??XLSData.Iris;
            return (XLSData)value;
        }
        public object GetSim()
        {
            object value = c_sim.SelectedItem;
            return value ?? "0";
        }

        public void SetGroupNumber(int number)
        {
            l_NumberGroups.Text = $"Liczba grup: {number.ToString()}";
        }

        private void Chart_Click(object sender, EventArgs e)
        {

        }

        public void SetDunnIndex(double index)
        {
            lbl_dunn.Text = $"Dunn index:{index}";
        }

        public int GetNumberGroups()
        {
            int number = 0;
            return int.TryParse(tb_NumberGroups.Text, out number)==true?number:2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DownloadXLSIris cdd = new DownloadXLSIris();
            cdd.ReadData();
        }
    }
}
