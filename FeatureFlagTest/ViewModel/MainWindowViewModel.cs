using FeatureControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FeatureFlagTest.ViewModel
{
    public class MainWindowViewModel
    {
        public Visibility ctrl1Vis { get { return IsVisible("mjtest1"); } }
        public Visibility ctrl2Vis { get { return IsVisible("mjtest2"); } }
        public Visibility ctrl3Vis { get { return IsVisible("mjtest3"); } }
        public Visibility ctrl4Vis { get { return IsVisible("mjtest4"); } }

        private Visibility IsVisible(string controlId)
        {
            return FeatureManager.IsFeatureEnabled(controlId) ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}
