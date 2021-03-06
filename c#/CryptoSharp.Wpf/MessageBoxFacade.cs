﻿using System;
using System.Windows;

namespace CryptoSharp.Wpf
{
    public class MessageBoxFacade
    {
        //private readonly ILogger _logger;

        //public MessageBoxFacade(ILogger logger)
        //{
        //    if (logger == null)
        //        throw new ArgumentNullException(nameof(logger));

        //    _logger = logger;
        //}

        public void ShowInfo(string message)
        {
            //_logger.Info(message);
            MessageBox.Show(message, "Informational", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public void ShowWarning(string message)
        {
            //_logger.Warn(message);
            MessageBox.Show(message, "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        public void ShowError(string message)
        {
            //_logger.Error(message);
            MessageBox.Show(message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public void ShowError(Exception exception)
        {
            //_logger.Error(exception);
            MessageBox.Show(exception.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public bool Confirm(string message)
        {
            var result = MessageBox.Show(message, "Confirm", MessageBoxButton.YesNoCancel,
                MessageBoxImage.Warning, MessageBoxResult.Cancel);
            return result == MessageBoxResult.Yes;
        }
    }
}