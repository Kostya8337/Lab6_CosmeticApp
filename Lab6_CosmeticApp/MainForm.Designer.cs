namespace Lab6_CosmeticApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataGridView dataGridView1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.SelectedIndex = 0;

            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage3.Controls.Add(this.dataGridView1);

            this.listBox1.Top = 10;
            this.listBox1.Left = 10;
            this.listBox1.Width = 200;

            this.comboBox1.Top = 220;
            this.comboBox1.Left = 10;
            this.comboBox1.Width = 200;

            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;

            this.Controls.Add(this.tabControl1);
            this.Text = "Cosmetic Manager";
            this.Width = 800;
            this.Height = 600;
        }
    }
}