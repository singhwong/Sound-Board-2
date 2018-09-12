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
            iconvalue.Add(new Icon { IconPath = "Assets/Icons/cartoon.png", Category = SoundCategory.Cartoons });
            iconvalue.Add(new Icon { IconPath = "Assets/Icons/taunt.png", Category = SoundCategory.Taunts });
            iconvalue.Add(new Icon { IconPath = "Assets/Icons/warning.png", Category = SoundCategory.Warnings });
            return iconvalue;
        }
    }
    public enum SoundCategory
    {
        Animals,
        Cartoons,
        Taunts,
        Warnings
    }
}
