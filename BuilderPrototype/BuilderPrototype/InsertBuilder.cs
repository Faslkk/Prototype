namespace BuilderPrototype
{
    public class InsertBuilder : QueryBuilder
    {
        public override void BuildCommand()
        {
            query.Command = "INSERT INTO";
        }

        public override void BuildTable()
        {
            query.Table = "Students";
        }

        public override void BuildColumns()
        {
            query.Columns = "(name, age)";
        }

        public override void BuildValues()
        {
            query.Values = "VALUES ('Іван', 19)";
        }

        public override void BuildEnd()
        {
            query.End = ";";
        }
    }
}
