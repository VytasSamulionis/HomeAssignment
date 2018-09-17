using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeAssignment.Rules;

namespace HomeAssignment
{
    public class BundleRecommendation
    {
        private readonly Config _config = null;

        public BundleRecommendation(Config config)
        {
            _config = config;
        }

        public string Evaluate(int age, bool isStudent, int income)
        {
            var enumerator = _config.Bundles.GetEnumerator();
            List<string> eligibleBundles = new List<string>();
            while (enumerator.MoveNext())
            {
                Bundle bundle = enumerator.Current.Value;
                bool isEligibleBundle = true;
                for (int i = 0; i < bundle.Rules.Count && isEligibleBundle; ++i)
                {
                    switch (bundle.Rules[i].Type)
                    {
                        case RuleType.MaxAge:
                            ((MaxAgeRule)bundle.Rules[i]).age = age;
                            break;
                        case RuleType.MinAge:
                            ((MinAgeRule)bundle.Rules[i]).age = age;
                            break;
                        case RuleType.MinIncome:
                            ((MinIncomeRule)bundle.Rules[i]).income = income;
                            break;
                        case RuleType.Student:
                            ((StudentRule)bundle.Rules[i]).isStudent = isStudent;
                            break;
                        default:
                            break;
                    }
                    isEligibleBundle &= bundle.Rules[i].Validate();
                }
                if (isEligibleBundle)
                {
                    eligibleBundles.Add(enumerator.Current.Key);
                }
            }
            if (eligibleBundles.Count > 1)
            {
                return GetBestValueBundle(eligibleBundles);
            }
            else if (eligibleBundles.Count == 1)
            {
                return eligibleBundles[0];
            }
            return string.Empty;
        }

        private string GetBestValueBundle(List<string> bundleIDs)
        {
            string bestBundle = bundleIDs[0];
            int bestValue = _config.Bundles[bestBundle].Value;
            for (int i = 1; i < bundleIDs.Count; ++i)
            {
                if (_config.Bundles[bundleIDs[i]].Value > bestValue)
                {
                    bestBundle = bundleIDs[i];
                    bestValue = _config.Bundles[bestBundle].Value;
                }
            }
            return bestBundle;
        }

    }
}
