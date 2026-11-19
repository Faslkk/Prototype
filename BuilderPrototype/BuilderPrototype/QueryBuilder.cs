namespace BuilderPrototype
{
    public abstract class QueryBuilder
    {
        protected SqlQuery query = new SqlQuery();

        public void Reset()
        {
            query = new SqlQuery();
        }

        public virtual void BuildCommand() { }
        public virtual void BuildTable() { }
        public virtual void BuildColumns() { }
        public virtual void BuildValues() { }
        public virtual void BuildWhere() { }
        public virtual void BuildOrderBy() { }
        public virtual void BuildEnd() { }

        public SqlQuery GetResult()
        {
            return query;
        }
    }
}
