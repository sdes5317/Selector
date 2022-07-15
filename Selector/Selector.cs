using System;
using System.Linq.Expressions;

namespace Selector
{
    public static class Selector
    {
        public static string Get<TObject, TProperty>(Expression<Func<TObject, TProperty>> selector)
        {
            if (selector.Body is MemberExpression member)
            {
                if (member.Expression.Type != typeof(TObject))
                {
                    throw new ArgumentException("It's necessary to selected TObject's property!");
                }

                return member.Member.Name;
            }

            throw new FormatException(selector.ToString());
        }
    }
}
