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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.p_Sim = new System.Windows.Forms.Panel();
            this.tb_NumberGroups = new System.Windows.Forms.TextBox();
            this.lbl_dunn = new System.Windows.Forms.Label();
            this.c_algorythm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.l_NumberGroups = new System.Windows.Forms.Label();
            this.c_dissim = new System.Windows.Forms.ComboBox();
            this.l_dissim = new System.Windows.Forms.Label();
            this.c_sim = new System.Windows.Forms.ComboBox();
            this.l_sim = new System.Windows.Forms.Label();
            this.btn_Group = new System.Windows.Forms.Button();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.p_Sim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // p_Sim
            // 
            this.p_Sim.Controls.Add(this.tb_NumberGroups);
            this.p_Sim.Controls.Add(this.lbl_dunn);
            this.p_Sim.Controls.Add(this.c_algorythm);
            this.p_Sim.Controls.Add(this.label1);
            this.p_Sim.Controls.Add(this.l_NumberGroups);
            this.p_Sim.Controls.Add(this.c_dissim);
            this.p_Sim.Controls.Add(this.l_dissim);
            this.p_Sim.Controls.Add(this.c_sim);
            this.p_Sim.Controls.Add(this.l_sim);
            this.p_Sim.Location = new System.Drawing.Point(2, 2);
            this.p_Sim.Name = "p_Sim";
            this.p_Sim.Size = new System.Drawing.Size(200, 374);
            this.p_Sim.TabIndex = 1;
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
            // c_algorythm
            // 
            this.c_algorythm.FormattingEnabled = true;
            this.c_algorythm.Location = new System.Drawing.Point(13, 23);
            this.c_algorythm.Name = "c_algorythm";
            this.c_algorythm.Size = new System.Drawing.Size(165, 21);
            this.c_algorythm.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Algorytm:";
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
            // btn_Group
            // 
            this.btn_Group.Location = new System.Drawing.Point(12, 382);
            this.btn_Group.Name = "btn_Group";
            this.btn_Group.Size = new System.Drawing.Size(75, 23);
            this.btn_Group.TabIndex = 2;
            this.btn_Group.Text = "Grupuj";
            this.btn_Group.UseVisualStyleBackColor = true;
            this.btn_Group.Click += new System.EventHandler(this.btn_Group_Click);
            // 
            // Chart
            // 
            this.Chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea1);
            this.Chart.Location = new System.Drawing.Point(208, 2);
            this.Chart.Name = "Chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Name = "Series1";
            this.Chart.Series.Add(series1);
            this.Chart.Size = new System.Drawing.Size(519, 405);
            this.Chart.TabIndex = 3;
            this.Chart.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AntTreeViewWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 419);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Chart);
            this.Controls.Add(this.btn_Group);
            this.Controls.Add(this.p_Sim);
            this.Name = "AntTreeViewWF";
            this.Text = "Ant Marcin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.p_Sim.ResumeLayout(false);
            this.p_Sim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel p_Sim;
        private System.Windows.Forms.ComboBox c_dissim;
        private System.Windows.Forms.Label l_dissim;
        private System.Windows.Forms.ComboBox c_sim;
        private System.Windows.Forms.Label l_sim;
        private System.Windows.Forms.Button btn_Group;
        private System.Windows.Forms.Label l_NumberGroups;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.ComboBox c_algorythm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_dunn;
        private System.Windows.Forms.TextBox tb_NumberGroups;
        private System.Windows.Forms.Button button1;
    }
}

