using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.Rules
{
    public class MaxAgeRule: IRule
    {
        public int age = 0;
        public int MaxAge
        {
            get { return _maxAge; }
        }

        private readonly int _maxAge = 0;

        public MaxAgeRule(int maxAge)
        {
            _maxAge = maxAge;
            _type = RuleType.MaxAge;
        }

        public override bool Validate()
        {
            HasFailed = age > _maxAge;
            return !HasFailed;
        }
    }
}
