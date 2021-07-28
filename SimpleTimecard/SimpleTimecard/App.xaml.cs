﻿using Prism;
using Prism.Ioc;
using SimpleTimecard.Common;
using SimpleTimecard.ViewModels;
using SimpleTimecard.Views;
using Xamarin.Forms;

namespace SimpleTimecard
{
    public partial class App
    {
        public App() : this(null) { }

        public App(IPlatformInitializer platformInitializer) : base(platformInitializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("NavigationPage/MainTabbedPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainTabbedPage, MainTabbedPageViewModel>();
            containerRegistry.RegisterForNavigation<TodayPage, TodayPageViewModel>();
            containerRegistry.RegisterForNavigation<HistoryPage, HistoryPageViewModel>();
            containerRegistry.RegisterForNavigation<SettingPage, SettingPageViewModel>();
            containerRegistry.RegisterForNavigation<AddPage, AddPageViewModel>();
            containerRegistry.RegisterForNavigation<EditPage, EditPageViewModel>();
        }

        protected override void OnStart()
        {
            Logger.Trace();
        }

        protected override void OnResume()
        {
            Logger.Trace();
        }

        protected override void OnSleep()
        {
            Logger.Trace();
        }
    }
}