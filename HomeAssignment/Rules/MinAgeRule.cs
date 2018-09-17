using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.Rules
{
    public class MinAgeRule: IRule
    {
        public int age = 0;
        public int MinAge
        {
            get { return _minAge; }
        }

        private readonly int _minAge = 0;

        public MinAgeRule(int minAge)
        {
            _minAge = minAge;
            _type = RuleType.MinAge;
        }

        public override bool Validate()
        {
            HasFailed = age < _minAge;
            return !HasFailed;
        }
    }
}
