using HomeAssignment.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment
{
    public abstract class IRule
    {
        public RuleType type
        {
            get { return _type; }
        }

        public abstract bool Validate();

        protected RuleType _type = RuleType.Undefined;
    }
}
