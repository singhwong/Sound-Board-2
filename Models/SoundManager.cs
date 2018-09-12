using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soundBoard
{
    class SoundManager
    {
        public static void GetAllSounds(ObservableCollection<Sound> sound)
        {
            var value = SetSound();
            sound.Clear();
            value.ForEach(p=>sound.Add(p));
        }
        public static void GetSoundByCategory(ObservableCollection<Sound> sounds,SoundCategory category)
        {
            var value = SetSound();
            var newvalue = value.Where(p => p.Category == category).ToList();
            sounds.Clear();
            newvalue.ForEach(p=>sounds.Add(p));
        }
        public static void GetSoundByName(ObservableCollection<Sound> sounds, string name)
        {
            var value = SetSound();
            var newvalue = value.Where(p => p.Name == name).ToList();
            sounds.Clear();
            newvalue.ForEach(p => sounds.Add(p));
        }
        public static List<Sound> SetSound()
        {
            var value = new List<Sound>();
            value.Add(new Sound("Cat",SoundCategory.Animals));
            value.Add(new Sound("Cow", SoundCategory.Animals));

            value.Add(new Sound("Gun", SoundCategory.Cartoons));
            value.Add(new Sound("Spring", SoundCategory.Cartoons));

            value.Add(new Sound("Clock", SoundCategory.Taunts));
            value.Add(new Sound("LOL", SoundCategory.Taunts));
            
            value.Add(new Sound("Ship", SoundCategory.Warnings));
            value.Add(new Sound("Siren", SoundCategory.Warnings));
            return value;
        }
    }
}
