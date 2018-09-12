using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace soundBoard
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Icon> main_icon;
        private ObservableCollection<Sound> main_sound = new ObservableCollection<Sound>();
        public MainPage()
        {           
            this.InitializeComponent();
            main_icon = SetIcon.GetIcon();
            main_frame.Navigate(typeof(firstOpenPage));
        }

        private void main_listview_ItemClick(object sender, ItemClickEventArgs e)
        {
            var value = (Icon)e.ClickedItem;
            switch (value.Category.ToString())
            {
                case "Animals":main_frame.Navigate(typeof(animalsPage));break;
                case "Cartoon":main_frame.Navigate(typeof(cartoonPage));break;
                case "Taunt":main_frame.Navigate(typeof(tauntPage));break;
                case "Warning": main_frame.Navigate(typeof(warningPage));break;
                default: break;
            }
            main_textblock.Text = value.Category.ToString();
        }

        private void list_button_Click(object sender, RoutedEventArgs e)
        {
            main_splitview.IsPaneOpen = !main_splitview.IsPaneOpen;
        }

        private void back_button_Click(object sender, RoutedEventArgs e)
        {
            main_frame.Navigate(typeof(firstOpenPage));
        }

        //private void auto_suggestbox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        //{
            
        //    SoundManager.GetSoundByName(main_sound,sender.Text);
        //}
    }
}
