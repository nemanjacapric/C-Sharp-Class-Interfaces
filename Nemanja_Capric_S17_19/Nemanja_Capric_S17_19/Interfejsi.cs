using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokvijum2_Nemanja_Capric_s17_19
{
    interface iBazni
    {
        string proizvodjac
        {
            get;
            set;
        }

        string model
        {
            get;
            set;
        }
        int cena
        {
            get;
            set;
        }

        string dostava();
        string unosTeksta();
        string konekcijaInterneta();



    }

    interface iDesktop
    {
        string procesor
        {
            get;
            set;
        }

        int radnaMemorija
        {
            get;
            set;
        }

        int memorija
        {
            get;
            set;
        }

        string upali();

    }

    interface iLaptop
    {
        int velicinaEkrana
        {
            get;
            set;
        }

        string sleep();

    }

    interface iTablet
    {
        int velicinaEkrana
        {
            get;
            set;
        }

        int rezolucijaKamere
        {
            get;
            set;
        }

        string zakljucaj();
    }

    interface iTelefon
    {
        string tipEkrana
        {
            get;
            set;
        }

        string iskljuci();
    }

    interface iSingle
    {
        string tipPloce
        {
            get;
            set;
        }
        string procesor
        {
            get;
            set;
        }
        string ugasi();
    }

    interface iKonzole
    {
        int brojDzojstika
        {
            get;
            set;
        }

        string tipKonekcijeDzojstika
        {
            get;
            set;
        }

        string reset();

    }

    interface iStampac
    {
        string tip
        {
            get;
            set;
        }

        string format
        {
            get;
            set;
        }

        string stampaj();

    }
}

