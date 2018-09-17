using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeAssignment.Rules;

namespace HomeAssignment
{
    public static class RulesValidator
    {
        public static bool Validate(List<IRule> rules, int age, bool isStudent, int income, List<string> products)
        {
            bool isEligibleBundle = true;
            for (int i = 0; i < rules.Count && isEligibleBundle; ++i)
            {
                switch (rules[i].Type)
                {
                    case RuleType.MaxAge:
                        MaxAgeRule maxAgeRule = (MaxAgeRule)rules[i];
                        maxAgeRule.age = age;
                        break;
                    case RuleType.MinAge:
                        MinAgeRule minAgeRule = (MinAgeRule)rules[i];
                        minAgeRule.age = age;
                        break;
                    case RuleType.MinIncome:
                        MinIncomeRule minIncomeRule = (MinIncomeRule)rules[i];
                        minIncomeRule.income = income;
                        break;
                    case RuleType.Student:
                        ((StudentRule)rules[i]).isStudent = isStudent;
                        break;
                    case RuleType.IncludeOneOfProducts:
                        ((IncludeOneOfProductsRule)rules[i]).products = products;
                        break;
                    default:
                        break;
                }
                isEligibleBundle &= rules[i].Validate();
            }
            return isEligibleBundle;
        }
    }
}
