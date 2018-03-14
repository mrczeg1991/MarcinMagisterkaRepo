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
            this.dg_Data = new System.Windows.Forms.DataGridView();
            this.p_settings = new System.Windows.Forms.Panel();
            this.lbl_indexGDI = new System.Windows.Forms.Label();
            this.lbl_clusterPurity = new System.Windows.Forms.Label();
            this.lbl_classificationError = new System.Windows.Forms.Label();
            this.btn_Group = new System.Windows.Forms.Button();
            this.lbl_dunn = new System.Windows.Forms.Label();
            this.cb_Repo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.l_NumberGroups = new System.Windows.Forms.Label();
            this.c_dissim = new System.Windows.Forms.ComboBox();
            this.l_dissim = new System.Windows.Forms.Label();
            this.c_sim = new System.Windows.Forms.ComboBox();
            this.l_sim = new System.Windows.Forms.Label();
            this.tp_Dane = new System.Windows.Forms.TabPage();
            this.trvBaseTree = new System.Windows.Forms.TreeView();
            this.tc_Ant.SuspendLayout();
            this.tp_Name.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Data)).BeginInit();
            this.p_settings.SuspendLayout();
            this.tp_Dane.SuspendLayout();
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
            this.tp_Name.Controls.Add(this.dg_Data);
            this.tp_Name.Controls.Add(this.p_settings);
            this.tp_Name.Location = new System.Drawing.Point(4, 22);
            this.tp_Name.Name = "tp_Name";
            this.tp_Name.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Name.Size = new System.Drawing.Size(728, 397);
            this.tp_Name.TabIndex = 0;
            this.tp_Name.Text = "Ustawienia";
            this.tp_Name.UseVisualStyleBackColor = true;
            // 
            // dg_Data
            // 
            this.dg_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Data.Location = new System.Drawing.Point(191, 23);
            this.dg_Data.Name = "dg_Data";
            this.dg_Data.Size = new System.Drawing.Size(531, 368);
            this.dg_Data.TabIndex = 12;
            // 
            // p_settings
            // 
            this.p_settings.Controls.Add(this.lbl_indexGDI);
            this.p_settings.Controls.Add(this.lbl_clusterPurity);
            this.p_settings.Controls.Add(this.lbl_classificationError);
            this.p_settings.Controls.Add(this.btn_Group);
            this.p_settings.Controls.Add(this.lbl_dunn);
            this.p_settings.Controls.Add(this.cb_Repo);
            this.p_settings.Controls.Add(this.label1);
            this.p_settings.Controls.Add(this.l_NumberGroups);
            this.p_settings.Controls.Add(this.c_dissim);
            this.p_settings.Controls.Add(this.l_dissim);
            this.p_settings.Controls.Add(this.c_sim);
            this.p_settings.Controls.Add(this.l_sim);
            this.p_settings.Location = new System.Drawing.Point(0, 0);
            this.p_settings.Name = "p_settings";
            this.p_settings.Size = new System.Drawing.Size(185, 397);
            this.p_settings.TabIndex = 3;
            // 
            // lbl_indexGDI
            // 
            this.lbl_indexGDI.AutoSize = true;
            this.lbl_indexGDI.Location = new System.Drawing.Point(11, 190);
            this.lbl_indexGDI.Name = "lbl_indexGDI";
            this.lbl_indexGDI.Size = new System.Drawing.Size(64, 13);
            this.lbl_indexGDI.TabIndex = 11;
            this.lbl_indexGDI.Text = "Indeks GDI:";
            // 
            // lbl_clusterPurity
            // 
            this.lbl_clusterPurity.AutoSize = true;
            this.lbl_clusterPurity.Location = new System.Drawing.Point(11, 250);
            this.lbl_clusterPurity.Name = "lbl_clusterPurity";
            this.lbl_clusterPurity.Size = new System.Drawing.Size(76, 13);
            this.lbl_clusterPurity.TabIndex = 10;
            this.lbl_clusterPurity.Text = "Czystość grup:";
            // 
            // lbl_classificationError
            // 
            this.lbl_classificationError.AutoSize = true;
            this.lbl_classificationError.Location = new System.Drawing.Point(11, 230);
            this.lbl_classificationError.Name = "lbl_classificationError";
            this.lbl_classificationError.Size = new System.Drawing.Size(87, 13);
            this.lbl_classificationError.TabIndex = 9;
            this.lbl_classificationError.Text = "Błąd klasyfikacji:";
            // 
            // btn_Group
            // 
            this.btn_Group.Location = new System.Drawing.Point(14, 289);
            this.btn_Group.Name = "btn_Group";
            this.btn_Group.Size = new System.Drawing.Size(75, 23);
            this.btn_Group.TabIndex = 4;
            this.btn_Group.Text = "Grupuj";
            this.btn_Group.UseVisualStyleBackColor = true;
            this.btn_Group.Click += new System.EventHandler(this.btn_Group_Click_1);
            // 
            // lbl_dunn
            // 
            this.lbl_dunn.AutoSize = true;
            this.lbl_dunn.Location = new System.Drawing.Point(11, 210);
            this.lbl_dunn.Name = "lbl_dunn";
            this.lbl_dunn.Size = new System.Drawing.Size(75, 13);
            this.lbl_dunn.TabIndex = 7;
            this.lbl_dunn.Text = "Indeks dunna:";
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
            this.l_NumberGroups.Location = new System.Drawing.Point(11, 170);
            this.l_NumberGroups.Name = "l_NumberGroups";
            this.l_NumberGroups.Size = new System.Drawing.Size(65, 13);
            this.l_NumberGroups.TabIndex = 4;
            this.l_NumberGroups.Text = "Liczba grup:";
            // 
            // c_dissim
            // 
            this.c_dissim.FormattingEnabled = true;
            this.c_dissim.Location = new System.Drawing.Point(15, 116);
            this.c_dissim.Name = "c_dissim";
            this.c_dissim.Size = new System.Drawing.Size(165, 21);
            this.c_dissim.TabIndex = 3;
            // 
            // l_dissim
            // 
            this.l_dissim.AutoSize = true;
            this.l_dissim.Location = new System.Drawing.Point(12, 100);
            this.l_dissim.Name = "l_dissim";
            this.l_dissim.Size = new System.Drawing.Size(92, 13);
            this.l_dissim.TabIndex = 2;
            this.l_dissim.Text = "Niepodobieństwo:";
            // 
            // c_sim
            // 
            this.c_sim.FormattingEnabled = true;
            this.c_sim.Location = new System.Drawing.Point(15, 76);
            this.c_sim.Name = "c_sim";
            this.c_sim.Size = new System.Drawing.Size(165, 21);
            this.c_sim.TabIndex = 1;
            // 
            // l_sim
            // 
            this.l_sim.AutoSize = true;
            this.l_sim.Location = new System.Drawing.Point(12, 60);
            this.l_sim.Name = "l_sim";
            this.l_sim.Size = new System.Drawing.Size(77, 13);
            this.l_sim.TabIndex = 0;
            this.l_sim.Text = "Podobieństwo:";
            // 
            // tp_Dane
            // 
            this.tp_Dane.Controls.Add(this.trvBaseTree);
            this.tp_Dane.Location = new System.Drawing.Point(4, 22);
            this.tp_Dane.Name = "tp_Dane";
            this.tp_Dane.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Dane.Size = new System.Drawing.Size(728, 397);
            this.tp_Dane.TabIndex = 1;
            this.tp_Dane.Text = "Dane";
            this.tp_Dane.UseVisualStyleBackColor = true;
            // 
            // trvBaseTree
            // 
            this.trvBaseTree.Location = new System.Drawing.Point(0, 0);
            this.trvBaseTree.Name = "trvBaseTree";
            this.trvBaseTree.Size = new System.Drawing.Size(269, 397);
            this.trvBaseTree.TabIndex = 4;
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
            ((System.ComponentModel.ISupportInitialize)(this.dg_Data)).EndInit();
            this.p_settings.ResumeLayout(false);
            this.p_settings.PerformLayout();
            this.tp_Dane.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_Ant;
        private System.Windows.Forms.TabPage tp_Name;
        private System.Windows.Forms.Panel p_settings;
        private System.Windows.Forms.Button btn_Group;
        private System.Windows.Forms.Label lbl_dunn;
        private System.Windows.Forms.ComboBox cb_Repo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_NumberGroups;
        private System.Windows.Forms.ComboBox c_dissim;
        private System.Windows.Forms.Label l_dissim;
        private System.Windows.Forms.ComboBox c_sim;
        private System.Windows.Forms.Label l_sim;
        private System.Windows.Forms.TabPage tp_Dane;
        private System.Windows.Forms.Label lbl_classificationError;
        private System.Windows.Forms.Label lbl_clusterPurity;
        private System.Windows.Forms.DataGridView dg_Data;
        private System.Windows.Forms.Label lbl_indexGDI;
        private System.Windows.Forms.TreeView trvBaseTree;
    }
}

