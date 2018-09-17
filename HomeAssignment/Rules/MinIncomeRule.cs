using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.Rules
{
    public class MinIncomeRule: IRule
    {
        public int income = 0;
        public int MinIncome
        {
            get { return _minIncome; }
        }

        private readonly int _minIncome = 0;

        public MinIncomeRule(int minIncome)
        {
            _minIncome = minIncome;
            _type = RuleType.MinIncome;
        }

        public override bool Validate()
        {
            HasFailed = income < _minIncome;
            return !HasFailed;
        }
    }
}
