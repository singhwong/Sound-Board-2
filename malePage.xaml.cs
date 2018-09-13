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
    public sealed partial class malePage : Page
    {
        private ObservableCollection<Sound> male_sound;
        public malePage()
        {
            this.InitializeComponent();
            male_sound = new ObservableCollection<Sound>();
            SoundManager.GetSoundByCategory(male_sound,SoundCategory.Male);
        }

        private void auto_suggestbox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            if (!String.IsNullOrEmpty(auto_suggestbox.Text))
            {
                SoundManager.GetSoundByName(male_sound, sender.Text);
            }
            else
            {
                SoundManager.GetSoundByCategory(male_sound, SoundCategory.Nature);
            }
        }

        private void animals_gridview_ItemClick(object sender, ItemClickEventArgs e)
        {
            var value = (Sound)e.ClickedItem;
            media_element.Source = new Uri(this.BaseUri, value.Name);
            media_element.Play();
            type_textblock.Text = value.Name.ToString();
        }
    }
}
