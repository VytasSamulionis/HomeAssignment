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

        private readonly int _minAge = 0;

        public MinAgeRule(int minAge)
        {
            _minAge = minAge;
            _type = RuleType.MinAge;
        }

        public override bool Validate()
        {
            return age >= _minAge;
        }
    }
}
