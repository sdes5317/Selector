using System.Linq.Expressions;

namespace Selector.Sample.Repository
{
    internal class Repository
    {
        public IEnumerable<string> SelectDistinctPropertyFromPerson<TProperty>(Expression<Func<PersonDao, TProperty>> selector)
        {
            var selectColumn = Selector.Get(selector);
            var sqlCommand = $"Select Distinct {selectColumn} From Person";

            //return sql.Query(sqlCommand);
            return new List<string>();
        }
    }

    internal class PersonDao
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
    }
}
