using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.Rules
{
    public class StudentRule : IRule
    {
        public bool isStudent = false;

        public StudentRule()
        {
            _type = RuleType.Student;
        }

        public override bool Validate()
        {
            HasFailed = !isStudent;
            return !HasFailed;
        }
    }
}
