using System;
using System.Collections.Generic;
using System.Text;

namespace Objektum_Orientált_programozás
{
    public class Konyv
    {
        private int ar;
        private int raktarKeszlet;
        private static int osszesRegisztraltKonyv = 0;
        public string Azonosito { get; set;}
        public string Cim { get; set; }
        public string Szerzo { get; set; }

        public int Ar 
        {
            get { return Ar; }
            set
            {
                if (ar < 0)
                {
                    Ar = 0;
                }
                else Ar = ar;
            }
        }
        public int RaktarKeszlet 
        {
            get { return RaktarKeszlet; }
            set
            {
                if (raktarKeszlet < 0)
                {
                    RaktarKeszlet = 0;
                }
                else RaktarKeszlet = raktarKeszlet;
            }
        }
        
        public int OsszesRegisztraltKonyv 
        {
            get { return OsszesRegisztraltKonyv; }
            set;
        }

        public Konyv(string azonosito, string cim, string szerzo, int ar) : this(azonosito, cim, szerzo, ar, 1) 
        {
            
        }

        public Konyv(string azonosito, string cim, string szerzo, int ar, int raktarKeszlet)
        {
            Azonosito = azonosito;
            Cim = cim;
            Szerzo = szerzo;
            Ar = ar;
            RaktarKeszlet = raktarKeszlet;
            osszesRegisztraltKonyv++;
        }

        public override string ToString() 
        {
            return $"[{Azonosito}] Szerzo: {Cim} - {Ar} Ft | Készlet: {RaktarKeszlet} db";
        }

        public int TeljesErtek()
        {
            return Ar* RaktarKeszlet;
        }
    }
}
