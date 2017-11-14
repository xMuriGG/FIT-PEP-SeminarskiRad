using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CZE_DAL.Models;

namespace CZE_API.Models.Android
{
    public class LogiraniKorisnikAndroid
    {
        public int KorisnickiNalogID { get; set; }
        public Osoba Osoba { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public bool Aktivan { get; set; }
        public UlogaKorisnika UlogaKorisnika { get; set; }

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public Spol Spol { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }

        public bool IsKandidat { get; set; }
        public bool IsZaposlenik { get; set; }

        //public List<GrupeKojePohadjam> GrupeKojePohadjam { get; set; }
        //public List<GrupeKojeSamPohadjao> GrupeKojeSamPohadjao { get; set; }
    }
}