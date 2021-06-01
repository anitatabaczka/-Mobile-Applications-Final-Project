﻿using Xamarin.Forms;



namespace CDVShopApp.Views
{
    public partial class CartView : ContentView
    {
        public delegate void TapDelegate();
        public CartView()
        {
            InitializeComponent();
            GoToState("Collapsed");
        }
        public int PageHeader { get; private set; } = 70;

        public TapDelegate OnExpand { get; set; }
        public TapDelegate OnCollapse { get; set; }


        private void OnExpandTapped(object sender, System.EventArgs e)
        {
            GoToState("Expanded");
            OnExpand?.Invoke();
        }
        private void OnCollapseTapped(object sender, System.EventArgs e)
        {
            GoToState( "Collapsed");
            OnCollapse?.Invoke();
        }
        private void GoToState(string visualState)
        {
            VisualStateManager.GoToState(ExpandButton, visualState);
            VisualStateManager.GoToState(CollapseButton, visualState);
        }
    }
}