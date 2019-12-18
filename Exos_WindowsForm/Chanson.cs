using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exos_WindowsForm
{
    class Chanson
    {
        private String _nomArtiste;
        private Chanson _titreChanson;

        public Chanson TitreChanson 
        {
            get { return _titreChanson; }
            set { _titreChanson = value; }
        }

        public String NomArtiste
        {
            get { return _nomArtiste; }
            set { _nomArtiste = value; }
        }
    }
}
