namespace BuilderPrototype
{
    public class SelectBuilder : QueryBuilder
    {
        public override void BuildCommand()
        {
            query.Command = "SELECT";
        }

        public override void BuildColumns()
        {
            query.Columns = "id, name, age";
        }

        public override void BuildTable()
        {
            query.Table = "FROM Students";
        }

        public override void BuildWhere()
        {
            query.Where = "WHERE age > 18";
        }

        public override void BuildOrderBy()
        {
            query.OrderBy = "ORDER BY name";
        }

        public override void BuildEnd()
        {
            query.End = ";";
        }
    }
}
