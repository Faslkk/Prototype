using System;

namespace BuilderPrototype
{
    public class UpdateBuilder : QueryBuilder
    {
        public override void BuildCommand()
        {
            query.Command = "UPDATE";
        }

        public override void BuildTable()
        {
            query.Table = "Students";
        }

        public override void BuildColumns()
        {
            query.Columns = "name, age";
        }

        public override void BuildValues()
        {
            string[] columns = query.Columns.Split(new string[] { ", " }, StringSplitOptions.None);
            string[] values = { "'Іван'", "20" };
            string set = "SET ";
            for (int i = 0; i < columns.Length; i++)
            {
                if (i > 0)
                {
                    set += ", ";
                }
                set += columns[i] + " = " + values[i];
            }
            query.Values = set;
        }

        public override void BuildWhere()
        {
            query.Where = "WHERE id = 1";
        }

        public override void BuildEnd()
        {
            query.End = ";";
        }
    }
}
