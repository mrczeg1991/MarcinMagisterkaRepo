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
using System.Drawing.Drawing2D;
using System.Collections;
using AntTreeProgram.Other;

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
            dg_Data.DataBindingComplete -= (sender2, e2) => Dg_Data_DataBindingComplete(sender2, e2, branches);
            dg_Data.Rows.Clear();
            dg_Data.Refresh();
            var source = new BindingSource();
            dg_Data.DataBindingComplete += (sender2, e2) => Dg_Data_DataBindingComplete(sender2, e2, branches);
            source.DataSource = data;
            dg_Data.DataSource = source;
            dg_Data.ReadOnly = true;
            dg_Data.Enabled = true;
     
        }

        private void Dg_Data_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e, List<AntBranch> branches)
        {
            try
            {
                foreach (AntBranch branch in branches)
                {
                    foreach (Ant ant in branch.Ants)
                    {
                        DataGridViewRow row = dg_Data.Rows[ant.Number - 1];// get you required index
                        row.DefaultCellStyle.BackColor = branch.AntColor;
                    }
                }
            }
            catch
            {

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
        TreeNode tn = null;
        public void DrawBranch(AntBranch branch, string name)
        {
            if (branch != null)
            {
                trvBaseTree.Nodes.Clear();
                Ant parent = (from rekord in branch.Ants where rekord.ParentIndex == 999999 select rekord).FirstOrDefault();
                tn = new TreeNode(name);
                tn.Nodes.Add(parent.Number.ToString());
                AddToPaint(parent, branch, tn);
                trvBaseTree.Nodes.Insert(0, tn);
                trvBaseTree.ExpandAll();
            }

        }
        void AddToPaint(Ant parent, AntBranch branch, TreeNode tn)
        {

            List<Ant> childs = branch.Ants.Where(a => a.ParentIndex == parent.Number).Select(b => b).ToList();
            //childs.Add(new Ant(11, 11) { Number = 1991 , ParentIndex=parent.Number});
            foreach (Ant ant in childs)
            {
                TreeNode node = tn.Nodes.Cast<TreeNode>()
                                .Where(r => r.Text == parent.Number.ToString()).FirstOrDefault();
                node.Nodes.Add(ant.Number.ToString());
                AddToPaint(ant, branch, node);
            }
        }

        public void AddToBranchesCombobox(string name)
        {
            cb_Branches.Items.Add(name);
        }

        private void cb_Branches_SelectedIndexChanged(object sender, EventArgs e)
        {
            controler.ShowBranch(cb_Branches.SelectedIndex);
        }
        public void ClearBranchesCombobox()
        {
            cb_Branches.Items.Clear();
        }

        public string GetSimText()
        {
            return tb_sim.Text;
        }

        public string GetDissimText()
        {
            return tb_dissim.Text;
        }

        public bool GetManula()
        {
            return cb_manual.Checked;
        }

        public bool GetBranchOperation()
        {
            return cb_branchOperation.Checked;
        }
        public void AddToSortCombobox(string name)
        {
            cb_RodzajSortowania.Items.Add(name);
        }
        public string GetSortKind()
        {
            object value = cb_RodzajSortowania.SelectedItem ?? "Domyślnie";
            return (string)value;
        }

        private void btn_AutomaticGroup_Click(object sender, EventArgs e)
        {
            controler.GroupAutomatic();
        }

        private void tb_sim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                  && !char.IsDigit(e.KeyChar)
                  && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ','
                && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

        private void tb_dissim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
               && !char.IsDigit(e.KeyChar)
               && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ','
                && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

        private void cb_manual_CheckedChanged(object sender, EventArgs e)
        {
            tb_dissim.Enabled = cb_manual.Checked;
            tb_sim.Enabled = cb_manual.Checked;
            if(!cb_manual.Checked)
            {
                tb_dissim.Text = "";
                tb_sim.Text = "";
            }
        }

        public void AddToMiaraCombobox(Miara name)
        {
            cb_miaraOdleglosci.Items.Add(name);
        }

        public Miara GetMiara()
        {
            object value = cb_miaraOdleglosci.SelectedItem ?? Miara.euklidesowa;
            return (Miara)value;
        }

        public void AddToGrid(object theBest)
        {
            dg_Data.Rows.Clear();
            dg_Data.Refresh();
            var source = new BindingSource();
            source.DataSource = theBest;
            dg_Data.DataSource = source;
            dg_Data.ReadOnly = true;
            dg_Data.Enabled = true;
        }
    }
}
