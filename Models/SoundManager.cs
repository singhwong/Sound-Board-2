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
            value.Add(new Sound("Bear",SoundCategory.Animals));
            value.Add(new Sound("Camel", SoundCategory.Animals));
            value.Add(new Sound("Cat", SoundCategory.Animals));
            //value.Add(new Sound("Chicken", SoundCategory.Animals));
            //value.Add(new Sound("Cicada", SoundCategory.Animals));
            value.Add(new Sound("Cow", SoundCategory.Animals));
            value.Add(new Sound("Crocodile", SoundCategory.Animals));
            value.Add(new Sound("Deer", SoundCategory.Animals));
            value.Add(new Sound("Dog", SoundCategory.Animals));
            value.Add(new Sound("Dragon", SoundCategory.Animals));
            value.Add(new Sound("Duck", SoundCategory.Animals));
            value.Add(new Sound("Eagle", SoundCategory.Animals));
            value.Add(new Sound("Elephant", SoundCategory.Animals));
            value.Add(new Sound("Hippo", SoundCategory.Animals));
            value.Add(new Sound("Horse", SoundCategory.Animals));
            //value.Add(new Sound("Jaguar", SoundCategory.Animals));
            value.Add(new Sound("Koala", SoundCategory.Animals));
            value.Add(new Sound("Lion", SoundCategory.Animals));
            value.Add(new Sound("Mouse", SoundCategory.Animals));
            //value.Add(new Sound("Myna", SoundCategory.Animals));
            value.Add(new Sound("Panda", SoundCategory.Animals));
            value.Add(new Sound("Sheep", SoundCategory.Animals));
            value.Add(new Sound("Tiger", SoundCategory.Animals));
            value.Add(new Sound("Wolf", SoundCategory.Animals));


            value.Add(new Sound("Blizzard", SoundCategory.Nature));
            //value.Add(new Sound("Earthquake", SoundCategory.Nature));
            value.Add(new Sound("Fire", SoundCategory.Nature));
            value.Add(new Sound("Lightning", SoundCategory.Nature));
            value.Add(new Sound("Rain", SoundCategory.Nature));
      

            value.Add(new Sound("Plane", SoundCategory.Traffic));
            value.Add(new Sound("Train", SoundCategory.Traffic));

            //value.Add(new Sound("Ship", SoundCategory.Warnings));
            //value.Add(new Sound("Siren", SoundCategory.Warnings));
            return value;
        }
    }
}
