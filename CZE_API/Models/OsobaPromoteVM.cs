
using CZE_DAL.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CZE_API.Models
{
    //[Serializable]
    [JsonObjectAttribute]
    public class OsobaPromoteVM
    {
        public int OsobaID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public Spol Spol { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }
        public int GradID { get; set; }
        public Kandidat Kandidat { get; set; }
        public Zaposlenik Zaposlenik { get; set; }
        public KorisnickiNalog KorisnickiNalog { get; set; }

        public OsobaPromoteVM() { }
        public OsobaPromoteVM(Osoba o)
        {
            this.OsobaID = o.OsobaID;
            this.Ime = o.Ime;
            this.Prezime = o.Prezime;
            this.DatumRodjenja = o.DatumRodjenja;
            this.Spol = o.Spol;
            this.Email = o.Email;
            this.Adresa = o.Adresa;
            this.GradID = o.GradID;
            this.Kandidat = o.Kandidat;
            this.Zaposlenik = o.Zaposlenik;
            this.KorisnickiNalog = o.KorisnickiNalog;
        }

        //public Osoba ToOsoba()
        //{
        //    Data.Models.Osoba o = new Data.Models.Osoba();
        //    o.OsobaID = this.OsobaID;
        //    o.Ime = this.Ime;
        //    o.Prezime = this.Prezime;
        //    o.DatumRodjenja = this.DatumRodjenja;
        //    o.Spol = this.Spol;
        //    o.Email = this.Email;
        //    o.Adresa = this.Adresa;
        //    o.GradID = this.GradID;
        //    o.BrojeviTelefona = this.BrojeviTelefona != null ? this.BrojeviTelefona.Select(s => new BrojTelefona
        //    {
        //        Broj = s.Broj,
        //        BrojTelefonaID = s.BrojTelefonaID,
        //        OsobaID = s.OsobaID,
        //        TipTelefona = s.TipTelefona
        //    }).ToList()
        //    : null;

        //    return o;
        //}
    }
}