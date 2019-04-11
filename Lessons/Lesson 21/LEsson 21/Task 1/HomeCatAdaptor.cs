using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class HomeCatAdaptor : IHomeCat
    {
        private IWildCat wildCat;
        public HomeCatAdaptor(IWildCat wc)
        {
            wildCat = wc;
        }

        public string Name
        {
            get { return wildCat.Breed; }
            set { }
        }

        public void Meow()
        {
            wildCat.Growl();
        }

        public void Scratch()
        {
            wildCat.Scratch();
        }
    }
}
