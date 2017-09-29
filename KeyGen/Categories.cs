using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyGen
{
    class Categories
    {
        private int id_group;
        private string name;
        private byte[] icon;
        private string tree_level;
        private int user_account;

        public Categories()
        {

        }

        public Categories(int id_group, string name, byte[] icon, string tree_level, int user_account)
        {
            this.Id_group = id_group;
            this.Name = name;
            this.Icon = icon;
            this.Tree_level = tree_level;
            this.User_account = user_account;
        }

        public int Id_group { get => id_group; set => id_group = value; }
        public string Name { get => name; set => name = value; }
        public byte[] Icon { get => icon; set => icon = value; }
        public string Tree_level { get => tree_level; set => tree_level = value; }
        public int User_account { get => user_account; set => user_account = value; }
    }
}
