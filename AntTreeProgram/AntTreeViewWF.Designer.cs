namespace AntTreeProgram
{
    partial class AntTreeViewWF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tc_Ant = new System.Windows.Forms.TabControl();
            this.tp_Name = new System.Windows.Forms.TabPage();
            this.tp_Dane = new System.Windows.Forms.TabPage();
            this.btn_Group = new System.Windows.Forms.Button();
            this.p_Sim = new System.Windows.Forms.Panel();
            this.tb_NumberGroups = new System.Windows.Forms.TextBox();
            this.lbl_dunn = new System.Windows.Forms.Label();
            this.cb_Repo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.l_NumberGroups = new System.Windows.Forms.Label();
            this.c_dissim = new System.Windows.Forms.ComboBox();
            this.l_dissim = new System.Windows.Forms.Label();
            this.c_sim = new System.Windows.Forms.ComboBox();
            this.l_sim = new System.Windows.Forms.Label();
            this.dg_Data = new System.Windows.Forms.DataGridView();
            this.tc_Ant.SuspendLayout();
            this.tp_Name.SuspendLayout();
            this.tp_Dane.SuspendLayout();
            this.p_Sim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // tc_Ant
            // 
            this.tc_Ant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tc_Ant.Controls.Add(this.tp_Name);
            this.tc_Ant.Controls.Add(this.tp_Dane);
            this.tc_Ant.Location = new System.Drawing.Point(2, -1);
            this.tc_Ant.Name = "tc_Ant";
            this.tc_Ant.SelectedIndex = 0;
            this.tc_Ant.Size = new System.Drawing.Size(736, 423);
            this.tc_Ant.TabIndex = 0;
            // 
            // tp_Name
            // 
            this.tp_Name.Controls.Add(this.p_Sim);
            this.tp_Name.Location = new System.Drawing.Point(4, 22);
            this.tp_Name.Name = "tp_Name";
            this.tp_Name.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Name.Size = new System.Drawing.Size(728, 397);
            this.tp_Name.TabIndex = 0;
            this.tp_Name.Text = "Ustawienia";
            this.tp_Name.UseVisualStyleBackColor = true;
            // 
            // tp_Dane
            // 
            this.tp_Dane.Controls.Add(this.dg_Data);
            this.tp_Dane.Location = new System.Drawing.Point(4, 22);
            this.tp_Dane.Name = "tp_Dane";
            this.tp_Dane.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Dane.Size = new System.Drawing.Size(728, 397);
            this.tp_Dane.TabIndex = 1;
            this.tp_Dane.Text = "Dane";
            this.tp_Dane.UseVisualStyleBackColor = true;
            // 
            // btn_Group
            // 
            this.btn_Group.Location = new System.Drawing.Point(14, 246);
            this.btn_Group.Name = "btn_Group";
            this.btn_Group.Size = new System.Drawing.Size(75, 23);
            this.btn_Group.TabIndex = 4;
            this.btn_Group.Text = "Grupuj";
            this.btn_Group.UseVisualStyleBackColor = true;
            this.btn_Group.Click += new System.EventHandler(this.btn_Group_Click_1);
            // 
            // p_Sim
            // 
            this.p_Sim.Controls.Add(this.btn_Group);
            this.p_Sim.Controls.Add(this.tb_NumberGroups);
            this.p_Sim.Controls.Add(this.lbl_dunn);
            this.p_Sim.Controls.Add(this.cb_Repo);
            this.p_Sim.Controls.Add(this.label1);
            this.p_Sim.Controls.Add(this.l_NumberGroups);
            this.p_Sim.Controls.Add(this.c_dissim);
            this.p_Sim.Controls.Add(this.l_dissim);
            this.p_Sim.Controls.Add(this.c_sim);
            this.p_Sim.Controls.Add(this.l_sim);
            this.p_Sim.Location = new System.Drawing.Point(0, 0);
            this.p_Sim.Name = "p_Sim";
            this.p_Sim.Size = new System.Drawing.Size(728, 397);
            this.p_Sim.TabIndex = 3;
            // 
            // tb_NumberGroups
            // 
            this.tb_NumberGroups.Location = new System.Drawing.Point(14, 194);
            this.tb_NumberGroups.Name = "tb_NumberGroups";
            this.tb_NumberGroups.Size = new System.Drawing.Size(115, 20);
            this.tb_NumberGroups.TabIndex = 8;
            // 
            // lbl_dunn
            // 
            this.lbl_dunn.AutoSize = true;
            this.lbl_dunn.Location = new System.Drawing.Point(11, 217);
            this.lbl_dunn.Name = "lbl_dunn";
            this.lbl_dunn.Size = new System.Drawing.Size(64, 13);
            this.lbl_dunn.TabIndex = 7;
            this.lbl_dunn.Text = "Dunn index:";
            // 
            // cb_Repo
            // 
            this.cb_Repo.FormattingEnabled = true;
            this.cb_Repo.Location = new System.Drawing.Point(13, 23);
            this.cb_Repo.Name = "cb_Repo";
            this.cb_Repo.Size = new System.Drawing.Size(165, 21);
            this.cb_Repo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Repozytorium:";
            // 
            // l_NumberGroups
            // 
            this.l_NumberGroups.AutoSize = true;
            this.l_NumberGroups.Location = new System.Drawing.Point(11, 177);
            this.l_NumberGroups.Name = "l_NumberGroups";
            this.l_NumberGroups.Size = new System.Drawing.Size(65, 13);
            this.l_NumberGroups.TabIndex = 4;
            this.l_NumberGroups.Text = "Liczba grup:";
            // 
            // c_dissim
            // 
            this.c_dissim.FormattingEnabled = true;
            this.c_dissim.Location = new System.Drawing.Point(13, 139);
            this.c_dissim.Name = "c_dissim";
            this.c_dissim.Size = new System.Drawing.Size(165, 21);
            this.c_dissim.TabIndex = 3;
            // 
            // l_dissim
            // 
            this.l_dissim.AutoSize = true;
            this.l_dissim.Location = new System.Drawing.Point(10, 123);
            this.l_dissim.Name = "l_dissim";
            this.l_dissim.Size = new System.Drawing.Size(92, 13);
            this.l_dissim.TabIndex = 2;
            this.l_dissim.Text = "Niepodobieństwo:";
            // 
            // c_sim
            // 
            this.c_sim.FormattingEnabled = true;
            this.c_sim.Location = new System.Drawing.Point(13, 99);
            this.c_sim.Name = "c_sim";
            this.c_sim.Size = new System.Drawing.Size(165, 21);
            this.c_sim.TabIndex = 1;
            // 
            // l_sim
            // 
            this.l_sim.AutoSize = true;
            this.l_sim.Location = new System.Drawing.Point(10, 83);
            this.l_sim.Name = "l_sim";
            this.l_sim.Size = new System.Drawing.Size(77, 13);
            this.l_sim.TabIndex = 0;
            this.l_sim.Text = "Podobieństwo:";
            // 
            // dg_Data
            // 
            this.dg_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Data.Location = new System.Drawing.Point(0, 0);
            this.dg_Data.Name = "dg_Data";
            this.dg_Data.Size = new System.Drawing.Size(728, 397);
            this.dg_Data.TabIndex = 0;
            // 
            // AntTreeViewWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 419);
            this.Controls.Add(this.tc_Ant);
            this.Name = "AntTreeViewWF";
            this.Text = "Ant Marcin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tc_Ant.ResumeLayout(false);
            this.tp_Name.ResumeLayout(false);
            this.tp_Dane.ResumeLayout(false);
            this.p_Sim.ResumeLayout(false);
            this.p_Sim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_Ant;
        private System.Windows.Forms.TabPage tp_Name;
        private System.Windows.Forms.Panel p_Sim;
        private System.Windows.Forms.Button btn_Group;
        private System.Windows.Forms.TextBox tb_NumberGroups;
        private System.Windows.Forms.Label lbl_dunn;
        private System.Windows.Forms.ComboBox cb_Repo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_NumberGroups;
        private System.Windows.Forms.ComboBox c_dissim;
        private System.Windows.Forms.Label l_dissim;
        private System.Windows.Forms.ComboBox c_sim;
        private System.Windows.Forms.Label l_sim;
        private System.Windows.Forms.TabPage tp_Dane;
        private System.Windows.Forms.DataGridView dg_Data;
    }
}

