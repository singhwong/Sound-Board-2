using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soundBoard
{
    class Sound
    {
        public string Name { get; set; }
        public SoundCategory Category { get; set; }
        public string  ImagePath { get; set; }
        public string AudioPath { get; set; }
        public Sound(string name,SoundCategory category)
        {
            Name = name;
            Category = category;
            ImagePath = string.Format("Assets/Images/{0}/{1}.png",category,name);
            AudioPath = string.Format("Assets/Audio/{0}/{1}.wav", category, name);
        }
    }
}
