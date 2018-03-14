using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AntTreeProgram.Adapters;
using AntTreeProgram.DataXLS;
using System.Threading;

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
            lbl_dunn.Text = $"Indeks Duna:{index}";
        }
        public void AddToGrid(object data, List<AntBranch> branches)
        {
            var source = new BindingSource();
            source.DataSource = data;
            dg_Data.DataSource = source;
            dg_Data.ReadOnly = true;
            dg_Data.Enabled = true;
            dg_Data.DataBindingComplete +=(sender2, e2)=> Dg_Data_DataBindingComplete(sender2,e2,branches);
     
        }

        private void Dg_Data_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e, List<AntBranch> branches)
        {

            foreach (AntBranch branch in branches)
            {
                foreach (Ant ant in branch.Ants)
                {
                    DataGridViewRow row = dg_Data.Rows[ant.Number];// get you required index
                    row.DefaultCellStyle.BackColor = branch.AntColor;
                }
            }
        }
        private void btn_Group_Click_1(object sender, EventArgs e)
        {
            controler.GroupData();
            controler.SetData();
        }

        public void SetClassificationError(string value)
        {
            lbl_classificationError.Text = "Błąd klasyfikacji:" + value;
        }

        public void SetErrorPurity(string value)
        {
            lbl_clusterPurity.Text = "Czystość grup:" + value;
        }

        public void SetGDIIndex(string value)
        {
            lbl_indexGDI.Text = "Indeks GDI: " + value;
        }

    }
}
