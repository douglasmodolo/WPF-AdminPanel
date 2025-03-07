﻿using System.Windows;
using System.Windows.Controls;

namespace Sistema.User_Controls
{
    /// <summary>
    /// Interaction logic for Order.xaml
    /// </summary>
    public partial class Order : UserControl
    {
        public Order()
        {
            InitializeComponent();
        }

        public string Title
		{
			get { return (string)GetValue(TitleProperty); }
			set { SetValue(TitleProperty, value); }
		}

		public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(Order), new PropertyMetadata(null));

		public string Desc
		{
			get { return (string)GetValue(DescProperty); }
			set { SetValue(DescProperty, value); }
		}

		public static readonly DependencyProperty DescProperty = DependencyProperty.Register("Desc", typeof(string), typeof(Order), new PropertyMetadata(null));

		public FontAwesome.Sharp.IconChar Icon
		{
			get { return (FontAwesome.Sharp.IconChar)GetValue(IconProperty); }
			set { SetValue(IconProperty, value); }
		}		

		public static readonly DependencyProperty IconProperty = DependencyProperty.Register("Icon", typeof(FontAwesome.Sharp.IconChar), typeof(Order), new PropertyMetadata(null));
	}
}
