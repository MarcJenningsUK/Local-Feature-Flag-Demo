namespace FeatureControl
{
    using System.Collections.Generic;

    public static class FeatureManager
    {
        private static Dictionary<string, bool> features = new Dictionary<string, bool>();

        private static void Initialize()
        {
            features.Clear();
            features.Add("mjtest1", true);
            features.Add("mjtest2", true);
            features.Add("mjtest3", false);
            features.Add("mjtest4", true);
        }

        private static bool initialised = false;

        public static bool IsFeatureEnabled(string feature)
        {
            if(!initialised)
            {
                Initialize();
            }

            if(features.ContainsKey(feature))
            {
                return features[feature];
            }

            return false;
        }
    }
}
