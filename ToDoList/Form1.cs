using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class frmToDoList : Form
    {
        private string filePath = "C:\\Users\\Public\\Documents\\To-Do.txt";
        private string settingsPath = "C:\\Users\\Public\\Documents\\settings.txt";
        private bool isDarkMode = false;
        private Color customBackgroundColor = Color.LightSteelBlue; // Custiomzied Background Color only works in Light Mode ;(


        public frmToDoList()
        {
            InitializeComponent();
            lstTasks.DrawMode = DrawMode.OwnerDrawFixed;
            lstTasks.DrawItem += lstTasks_DrawItem;
            LoadTasks();
            LoadTheme();
            this.FormClosing += frmToDoList_FormClosing;
            chkDarkMode.CheckedChanged += chkDarkMode_CheckedChanged;
            btnCustomizeTheme.Click += btnCustomizeTheme_Click;

        }
        private void btnCustomizeTheme_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    customBackgroundColor = colorDialog.Color;
                    ApplyTheme();
                }
            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTask.Text))
            {
                string priority = GetPrioritySymbol();
                lstTasks.Items.Add($"{priority} {txtTask.Text}");
                txtTask.Clear();
                UpdateTaskCount();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(txtTask.Text))
            {
                string priority = GetPrioritySymbol();
                lstTasks.Items[lstTasks.SelectedIndex] = $"{priority} {txtTask.Text}";
                txtTask.Clear();
                UpdateTaskCount();
            }
        }

        private string GetPrioritySymbol()
        {
            if (rbtnHigh.Checked) return "[H]";
            if (rbtnMedium.Checked) return "[M]";
            return "[L]";
        }

        private Color GetPriorityColor(string task)
        {
            if (task.StartsWith("[H]")) return Color.Red;
            if (task.StartsWith("[M]")) return Color.Blue;
            return Color.Green;
        }

        private void lstTasks_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.DrawBackground();
            string task = lstTasks.Items[e.Index].ToString();
            Color color = GetPriorityColor(task);

            using (Brush brush = new SolidBrush(color))
            {
                e.Graphics.DrawString(task, e.Font, brush, e.Bounds);
            }

            e.DrawFocusRectangle();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex != -1)
            {
                lstTasks.Items.RemoveAt(lstTasks.SelectedIndex);
                UpdateTaskCount();
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex != -1)
            {
                string task = lstTasks.SelectedItem.ToString();
                if (!task.Contains("✔"))
                {
                    lstTasks.Items[lstTasks.SelectedIndex] = "✔ " + task;
                }
            }
        }

        private void UpdateTaskCount()
        {
            lblTotalTasks.Text = "Total Tasks: " + lstTasks.Items.Count;
        }

        private void SaveTasks()
        {
            try
            {
                File.WriteAllLines(filePath, lstTasks.Items.Cast<string>());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving tasks: " + ex.Message);
            }
        }

        private void LoadTasks()
        {
            if (File.Exists(filePath))
            {
                try
                {
                    string[] tasks = File.ReadAllLines(filePath);
                    lstTasks.Items.AddRange(tasks);
                    UpdateTaskCount();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading tasks: " + ex.Message);
                }
            }
        }

        private void chkDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            isDarkMode = chkDarkMode.Checked;
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            if (isDarkMode)
            {
                this.BackColor = Color.DimGray;
                this.ForeColor = Color.White;
                lstTasks.BackColor = Color.LightGray;
                lstTasks.ForeColor = Color.White;
                txtTask.BackColor = Color.LightGray;
                txtTask.ForeColor = Color.Black;
                btnAdd.BackColor = Color.LightGray;
                btnEdit.BackColor = Color.LightGray;
                btnDelete.BackColor = Color.LightGray;
                btnComplete.BackColor = Color.LightGray;
                btnCustomizeTheme.BackColor = Color.LightGray;
                chkDarkMode.Text = "Light Mode";
            }
            else
            {
                this.BackColor = customBackgroundColor; 
                this.ForeColor = SystemColors.ControlText;
                lstTasks.BackColor = Color.White;
                lstTasks.ForeColor = Color.Black;
                txtTask.BackColor = Color.White;
                txtTask.ForeColor = Color.Black;
                btnAdd.BackColor = SystemColors.Control;
                btnEdit.BackColor = SystemColors.Control;
                btnDelete.BackColor = SystemColors.Control;
                btnComplete.BackColor = SystemColors.Control;
                btnCustomizeTheme.BackColor = SystemColors.Control;
                chkDarkMode.Text = "Dark Mode";
            }
        }

        private void SaveTheme()
        {
            try
            {
                string colorString = $"{customBackgroundColor.R},{customBackgroundColor.G},{customBackgroundColor.B}";
                File.WriteAllText(settingsPath, $"{(isDarkMode ? "dark" : "light")}\n{colorString}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving theme: " + ex.Message);
            }
        }

        private void LoadTheme()
        {
            if (File.Exists(settingsPath))
            {
                try
                {
                    string[] settings = File.ReadAllLines(settingsPath);
                    isDarkMode = settings[0] == "dark";

                    if (settings.Length > 1)
                    {
                        string[] rgb = settings[1].Split(',');
                        customBackgroundColor = Color.FromArgb(
                            int.Parse(rgb[0]),
                            int.Parse(rgb[1]),
                            int.Parse(rgb[2])
                        );
                    }

                    chkDarkMode.Checked = isDarkMode;
                    ApplyTheme();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading theme: " + ex.Message);
                }
            }
        }

        private void frmToDoList_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveTasks();
            SaveTheme();
        }

       
    }
}
