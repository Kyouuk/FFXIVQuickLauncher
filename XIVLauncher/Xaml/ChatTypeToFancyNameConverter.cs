﻿using System;
using System.Globalization;
using System.Windows.Data;
using Dalamud.Game.Chat;

namespace XIVLauncher.Xaml
{
    public class ChatTypeToFancyNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is XivChatType chatType)
                return chatType.GetDetails().FancyName;

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}