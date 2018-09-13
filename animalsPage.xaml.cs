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

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace soundBoard
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class animalsPage : Page
    {
        private ObservableCollection<Sound> newsound;
        //private SoundCategory category;
        public animalsPage()
        {
            this.InitializeComponent();
            newsound = new ObservableCollection<Sound>();
            SoundManager.GetSoundByCategory(newsound,SoundCategory.Animals);
        }

        private void animals_gridview_ItemClick(object sender, ItemClickEventArgs e)
        {
            var value = (Sound)e.ClickedItem;
            media_element.Source = new Uri(this.BaseUri, value.AudioPath);
            type_textblock.Text = value.Name.ToString();
            media_element.Play();
        }

        private void auto_suggestbox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            if (!String.IsNullOrEmpty(auto_suggestbox.Text))
            {
                SoundManager.GetSoundByName(newsound, sender.Text);
            }
            else
            {
                SoundManager.GetSoundByCategory(newsound, SoundCategory.Animals);
            }
        }
    }
}
