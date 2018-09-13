using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soundBoard
{
    public class Icon
    {
        public string IconPath { get; set; }
        public SoundCategory Category { get; set; }
    }
    public class SetIcon
    {
        public static List<Icon> GetIcon()
        {
            var iconvalue = new List<Icon>();
            iconvalue.Add(new Icon {IconPath="Assets/Icons/animals.png",Category = SoundCategory.Animals});
            iconvalue.Add(new Icon { IconPath = "Assets/Icons/male.png", Category = SoundCategory.Male });
            iconvalue.Add(new Icon { IconPath = "Assets/Icons/nature.png", Category = SoundCategory.Nature });
            iconvalue.Add(new Icon { IconPath = "Assets/Icons/traffic.png", Category = SoundCategory.Traffic });
            iconvalue.Add(new Icon { IconPath = "Assets/Icons/setting.png",Category = SoundCategory.Setting});
            return iconvalue;
        }
    }
    public enum SoundCategory
    {
        Animals,
        Male,
        Nature,
        Traffic,
        Setting
    }
}
