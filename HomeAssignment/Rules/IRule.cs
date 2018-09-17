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
        public RuleType Type
        {
            get { return _type; }
        }

        public bool HasFailed
        {
            get { return _hasFailed; }
            set { _hasFailed = value; }
        }

        public abstract bool Validate();

        protected RuleType _type = RuleType.Undefined;

        private bool _hasFailed = false;
    }
}
