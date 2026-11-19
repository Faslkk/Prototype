namespace BuilderPrototype
{
    public class SqlQuery : QueryPrototype
    {
        public string Command = "";
        public string Table = "";
        public string Columns = "";
        public string Values = "";
        public string Where = "";
        public string OrderBy = "";
        public string End = "";

        public SqlQuery()
        {
        }

        public SqlQuery(SqlQuery q)
        {
            this.Command = q.Command;
            this.Table = q.Table;
            this.Columns = q.Columns;
            this.Values = q.Values;
            this.Where = q.Where;
            this.OrderBy = q.OrderBy;
            this.End = q.End;
        }

        public override QueryPrototype Clone()
        {
            return new SqlQuery(this);
        }

        public string GetSql()
        {
            string sql = Command;
            if (Command == "SELECT")
            {
                sql = Add(sql, Columns);
            }
            sql = Add(sql, Table);
            if (Command == "INSERT INTO")
            {
                sql = Add(sql, Columns);
            }
            sql = Add(sql, Values);
            sql = Add(sql, Where);
            sql = Add(sql, OrderBy);
            return sql + End;
        }

        private string Add(string sql, string part)
        {
            if (part == "")
            {
                return sql;
            }
            return sql + " " + part;
        }
    }
}
