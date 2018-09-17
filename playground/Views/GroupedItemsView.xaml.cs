using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace playground.Views
{
    public partial class GroupedItemsView : ContentView
    {
        public static BindableProperty TextProperty = BindableProperty.Create(
            nameof(Text), 
            typeof(string), 
            typeof(GroupedItemsView)
        );


        public string Text { get; set; }


        public GroupedItemsView()
        {
            InitializeComponent();
        }
    }
}
