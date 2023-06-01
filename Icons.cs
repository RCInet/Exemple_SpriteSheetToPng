using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IconsExtractor
{
    public class Icons
    {
        public static List<Icon_Structure> List = new List<Icon_Structure>();
        public static Bitmap Bitmap = null;
        public struct Icon_Structure
        {
            public string name;
            public int background_position_x;
            public int background_position_y;
            public int size_x;
            public int size_y;
        }
    }
}
