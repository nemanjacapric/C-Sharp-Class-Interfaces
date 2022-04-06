using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokvijum2_Nemanja_Capric_s17_19
{

    class clsBaznaUredjaji : iBazni
    {

        private int _cena;
        public string proizvodjac
        {
            get;
            set;
        }


        public string model
        {
            get;
            set;
        }

        public int cena
        {
            get { return _cena; }
            set
            {
                if (value <= 200000 && value >= 1000)
                {
                    _cena = value;
                }
                else
                {
                    throw new Exception("Unesite vrednost izmedju 1000 i 200 000");
                }
            }
        }

        public string dostava()
        {
            return "bazna-dostava";
        }

        public virtual string unosTeksta()
        {
            return "bazna-unosTeksta";
        }

        public virtual string konekcijaInterneta()
        {
            return "bazna-unosTeksta";
        }


    }

    class clsDesktop : clsBaznaUredjaji, iDesktop
    {

        private string _procesor;
        private int _radnaMemorija;
        private int _memorija;

        public string procesor
        {
            get { return _procesor; }
            set
            {
                if (value == "Intel" || value == "AMD")
                {
                    _procesor = value;

                }
                else { throw new Exception("Unesite proizvodjaca koji je intel ili amd"); }
            }
        }

        public int radnaMemorija
        {
            get { return _radnaMemorija; }
            set
            {
                if (value >= 4 && value <= 64)
                {
                    _radnaMemorija = value;

                }
                else { throw new Exception("Unesite velicinu radne memorije izmedju 4gb i 64gb"); }
            }
        }

        public int memorija
        {
            get { return _memorija; }
            set
            {
                if (value >= 256 && value <= 2048)
                {
                    _memorija = value;

                }
                else { throw new Exception("Unesite velicinu memorije izmedju 256 gb i 2048gb"); }
            }
        }

        public string upali()
        {
            return "desktop-upali";
        }

        public override string unosTeksta()
        {
            return "desktop-unosTeksta";
        }

        public override string konekcijaInterneta()
        {
            return "desktop-konekcijaInterneta";
        }

    }

    class clsLaptop : clsDesktop, iLaptop
    {
        private int _velicina;

        public int velicinaEkrana
        {
            get { return _velicina; }
            set
            {
                if (value >= 13 && value <= 17)
                {
                    _velicina = value;

                }
                else { throw new Exception("Unesite velicinu ekrana izmedju 13 i 17 inca"); }
            }
        }

        public string sleep()
        {
            return "laptop - sleep";
        }

        public override string unosTeksta()
        {
            return "laptop-unosTeksta";
        }

        public override string konekcijaInterneta()
        {
            return "laptop-konekcijaInterneta";
        }

    }

    class clsTablet : clsBaznaUredjaji, iTablet
    {
        private int _kamera;

        public int velicinaEkrana
        {
            get;
            set;
        }

        public int rezolucijaKamere
        {
            get { return _kamera; }
            set
            {
                if (value >= 10 && value <= 70)
                {
                    _kamera = value;

                }
                else { throw new Exception("Unesite odgovarajucu rezoluciju kamere"); }
            }
        }

        public string zakljucaj()
        {
            return "tablet - zakljucaj";
        }

        public override string unosTeksta()
        {
            return "tablet-unosTeksta";
        }

        public override string konekcijaInterneta()
        {
            return "tablet-konekcijaInterneta";
        }

    }

    class clsTelefon : clsTablet, iTelefon
    {
        private string _tastatura;
        public string tipEkrana
        {
            get { return _tastatura; }
            set
            {
                if (value == "tastatura" || value == "ekran na dodir")
                {
                    _tastatura = value;

                }
                else
                {
                    throw new Exception("Unesite da li je proizvod sa ekranom na dodir ili sa tastaturom");
                }
            }
        }

        public string iskljuci()
        {
            return "telefon - iskljuci";
        }

        public override string unosTeksta()
        {
            return "telefon-unosTeksta";
        }

        public override string konekcijaInterneta()
        {
            return "telefon-konekcijaInterneta";
        }

    }
    class clsSingleBoard : clsBaznaUredjaji, iSingle
    //dilema - da li staviti ispod desktopa ili ne
    {

        private string _procesor;
        public string tipPloce
        {
            get;
            set;

        }

        public string procesor
        {
            get { return _procesor; }
            set
            {
                if (value == "Intel" || value == "AMD" || value == "VIA")
                {
                    _procesor = value;

                }
                else { throw new Exception("Unesite proizvodjaca koji je intel ili amd"); }
            }
        }

        public string ugasi()
        {
            return "signle - ugasi";
        }
    }

    class clsKonzole : clsBaznaUredjaji, iKonzole
    {
        private int _broj;
        private string _tip;

        public int brojDzojstika
        {
            get { return _broj; }
            set
            {
                if (value >= 1 && value <= 4)
                {
                    _broj = value;

                }
                else { throw new Exception("Unesite broj izmedju 1 i 4"); }
            }
        }

        public string tipKonekcijeDzojstika
        {
            get { return _tip; }
            set
            {
                if (value == "bezicni" || value == "zicni")
                {
                    _tip = value;

                }
                else { throw new Exception("Unesite da li je zicni ili bezicni"); }
            }
        }

        public string reset()
        {
            return "konzola - reset";
        }

        public override string unosTeksta()
        {
            return "konzola-unosTeksta";
        }

        public override string konekcijaInterneta()
        {
            return "konzola-konekcijaInterneta";
        }
    }

    class clsStampac : clsBaznaUredjaji, iStampac
    {
        private string _tip;

        public string tip
        {
            get { return _tip; }
            set
            {
                if (value == "Inkjet" || value == "Laser" || value == "Laserski")
                {
                    _tip = value;

                }
                else { throw new Exception("Unesite odgovarajuci tip"); }
            }
        }

        public string format
        {
            get;
            set;
        }

        public string stampaj()
        {
            return "stampac - stampaj";
        }
    }



}
