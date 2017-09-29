using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyGen
{
    class Icons
    {
        private int id_icon;
        private string name;
        private byte[] image;

        public Icons()
        {

        }

        public Icons(int id_icon, string name, byte[] image)
        {
            this.Id_icon = id_icon;
            this.Name = name;
            this.Image = image;
        }

        public int Id_icon { get => id_icon; set => id_icon = value; }
        public string Name { get => name; set => name = value; }
        public byte[] Image { get => image; set => image = value; }
    }
}
