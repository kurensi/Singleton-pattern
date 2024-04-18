using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Muster_Nach2
{
    class OrkGeneral
    {
        public string name;
        private static OrkGeneral My_General=null;
        private OrkGeneral()
        {

        }                        
        public static OrkGeneral getInstance()
        {
            if (My_General == null)
            {
                My_General = new OrkGeneral();
            }
            return My_General;


        }
        public void setName(string General)
        {
            name = General;
        }
        public string AngrifsBefell()
        {
            return name + " Befehl : Jetzt greifen wir an !!!!!!";
        }
        public string RückzugsBefell()
        {
            return name + " Befehl : Jetzt ziehen  wir zurück !!!!!!";
        }
    }
}

