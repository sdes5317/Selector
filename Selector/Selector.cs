using System;
using System.Linq.Expressions;

namespace Selector
{
    public static class Selector
    {
        public static string Get<TObject>(Expression<Func<TObject, Object>> selector)
        {
            if (selector.Body is UnaryExpression unary)
            {
                var operand = (MemberExpression)unary.Operand;

                return operand.Member.Name;
            }

            if (selector.Body is MemberExpression member)
            {
                return member.Member.Name;
            }

            throw new ArgumentException("Selector not Handle");
        }
    }
}
