﻿using System.Windows.Controls;
using System.Windows.Input;
using Validic.Core.Model;
using Validic.Windows.DemoApp.Helpers;

namespace Validic.Windows.DemoApp.Views.DataViews
{
    /// <summary>
    ///     Interaction logic for FitnessView.xaml
    /// </summary>
    public partial class FitnessView : UserControl
    {
        public FitnessView()
        {
            InitializeComponent();
        }

        private void CommandBinding_OnCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            ViewHelper.CopyCommandOnCanExecute(sender, e);
        }

        private void CommandBinding_OnExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            ViewHelper.CopyCommandOnExecuted<Fitness>(sender, e);
        }
    }
}