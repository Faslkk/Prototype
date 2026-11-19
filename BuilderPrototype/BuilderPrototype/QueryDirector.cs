namespace BuilderPrototype
{
    public class QueryDirector
    {
        private QueryBuilder builder;
        private int step;

        public void SetBuilder(QueryBuilder builder)
        {
            this.builder = builder;
            step = 0;
        }

        public string NextStep()
        {
            step++;
            switch (step)
            {
                case 1: builder.Reset(); return "Reset()";
                case 2: builder.BuildCommand(); return "BuildCommand()";
                case 3: builder.BuildTable(); return "BuildTable()";
                case 4: builder.BuildColumns(); return "BuildColumns()";
                case 5: builder.BuildValues(); return "BuildValues()";
                case 6: builder.BuildWhere(); return "BuildWhere()";
                case 7: builder.BuildOrderBy(); return "BuildOrderBy()";
                case 8: builder.BuildEnd(); return "BuildEnd()";
            }
            return "";
        }

        public bool IsFinished()
        {
            return step >= 8;
        }

        public SqlQuery Construct()
        {
            builder.Reset();
            builder.BuildCommand();
            builder.BuildTable();
            builder.BuildColumns();
            builder.BuildValues();
            builder.BuildWhere();
            builder.BuildOrderBy();
            builder.BuildEnd();
            step = 8;
            return builder.GetResult();
        }
    }
}
