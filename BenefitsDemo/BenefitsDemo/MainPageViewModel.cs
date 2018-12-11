using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace BenefitsDemo
{
    public class MainPageViewModel
   {
        #region Commands
        public ICommand OnFindProviderClick => new Command(GoToProviderPage);
        public ICommand OnWellnessPortalClick => new Command(GoWellnessPortalPage);
        public ICommand OnClaimActivityClick => new Command(GoToClaimActivityPage);
        public ICommand OnBenefitsClick => new Command(GoToBenefitsPage);
        public ICommand OnIDCardClick => new Command(GoToIDCardPage);
        public ICommand OnContactUsClick => new Command(GoToContactUsPage);
        #endregion

        #region CommandMethods
        private void GoToProviderPage(object obj)
        {
            Analytics.TrackEvent("Launch Provider Page");
        }
        private void GoWellnessPortalPage(object obj)
        {
            Analytics.TrackEvent("Launch Wellness Portal Page");
        }
        private void GoToClaimActivityPage(object obj)
        {
            Analytics.TrackEvent("Launch Claim Activity Page");
        }
        private void GoToBenefitsPage(object obj)
        {
            Analytics.TrackEvent("Launch Benfits Page");
        }
        private void GoToIDCardPage(object obj)
        {
            Analytics.TrackEvent("Launch ID Card Page");
        }
        private void GoToContactUsPage(object obj)
        {
            Analytics.TrackEvent("Launch Contact Us Page");
        }
        #endregion

        #region Constructor
        public MainPageViewModel()
        {

        } 
        #endregion
    }
}
