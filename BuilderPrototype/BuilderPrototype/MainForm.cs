using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BuilderPrototype
{
    public partial class MainForm : Form
    {
        private QueryDirector director = new QueryDirector();
        private QueryBuilder builder;
        private int stepNumber;
        private List<SqlQuery> objects = new List<SqlQuery>();
        private List<string> titles = new List<string>();

        public MainForm()
        {
            InitializeComponent();
            cmbType.Items.Add("SELECT");
            cmbType.Items.Add("INSERT");
            cmbType.Items.Add("UPDATE");
            cmbType.SelectedIndex = 0;
            btnStep.Enabled = false;
            btnAll.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cmbType.Text == "SELECT")
            {
                builder = new SelectBuilder();
            }
            else if (cmbType.Text == "INSERT")
            {
                builder = new InsertBuilder();
            }
            else
            {
                builder = new UpdateBuilder();
            }

            director.SetBuilder(builder);
            stepNumber = 0;
            lstSteps.Items.Clear();
            txtResult.Text = "";
            lstSteps.Items.Add("Створено " + builder.GetType().Name + ", директор отримав будівельника");
            btnStep.Enabled = true;
            btnAll.Enabled = true;
        }

        private void btnStep_Click(object sender, EventArgs e)
        {
            string stepName = director.NextStep();
            stepNumber++;
            string sql = builder.GetResult().GetSql();

            if (stepNumber == 1)
            {
                lstSteps.Items.Add("Крок 1: " + stepName + "  ->  створено порожній запит");
            }
            else if (sql == txtResult.Text)
            {
                lstSteps.Items.Add("Крок " + stepNumber + ": " + stepName + "  ->  SQL без змін");
            }
            else
            {
                lstSteps.Items.Add("Крок " + stepNumber + ": " + stepName + "  ->  " + sql);
            }
            txtResult.Text = sql;

            if (director.IsFinished())
            {
                lstSteps.Items.Add("Запит готовий, його додано до списку об'єктів");
                btnStep.Enabled = false;
                btnAll.Enabled = false;
                AddObject("Оригінал (" + builder.GetType().Name + ")", builder.GetResult());
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            SqlQuery query = director.Construct();
            lstSteps.Items.Add("Construct(): директор виконав усі кроки одразу");
            txtResult.Text = query.GetSql();
            btnStep.Enabled = false;
            btnAll.Enabled = false;
            AddObject("Оригінал (" + builder.GetType().Name + ")", query);
        }

        private void btnClone_Click(object sender, EventArgs e)
        {
            int index = lstObjects.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Оберіть об'єкт у списку.");
                return;
            }

            SqlQuery source = objects[index];
            int count = (int)numCount.Value;
            for (int i = 0; i < count; i++)
            {
                SqlQuery copy = (SqlQuery)source.Clone();
                objects.Add(copy);
                titles.Add("Копія об'єкта " + (index + 1));
            }
            RefreshObjects(index);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int index = lstObjects.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Оберіть об'єкт у списку.");
                return;
            }
            if (txtTable.Text == "")
            {
                MessageBox.Show("Введіть назву таблиці.");
                return;
            }

            SqlQuery query = objects[index];
            if (query.Command == "SELECT")
            {
                query.Table = "FROM " + txtTable.Text;
            }
            else
            {
                query.Table = txtTable.Text;
            }
            RefreshObjects(index);
        }

        private void AddObject(string title, SqlQuery query)
        {
            objects.Add(query);
            titles.Add(title);
            RefreshObjects(objects.Count - 1);
        }

        private void RefreshObjects(int selected)
        {
            lstObjects.Items.Clear();
            for (int i = 0; i < objects.Count; i++)
            {
                lstObjects.Items.Add((i + 1) + ". " + titles[i] + ":  " + objects[i].GetSql());
            }
            lstObjects.SelectedIndex = selected;
        }
    }
}
