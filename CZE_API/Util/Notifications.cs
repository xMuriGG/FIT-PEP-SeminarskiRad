using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CZE_API.Util
{
    public class Notifications
    {
        public static IRestResponse KandidatUspjesnaRegistracija(string imePrezime, string kIme, string lozinka, string broj)
        {
            string poruka = "Postovani/a " +
                GSMConverter.StringToGSM7String(imePrezime) + ",\\n" + "Vas zahtjev za registraciju na CZE sistem je odobren.\\n"
                + "User:" + GSMConverter.StringToGSM7String(kIme)+"\\n"
                + "Pass:" + GSMConverter.StringToGSM7String(lozinka);

            int l = poruka.Length;
            return InfoBipSMS.SingleTextualMessageToOneDestination(broj, poruka);
        }
        public static class GSMConverter
        {
            private const string SPEC_CHAR = "ČčĆćĐđŠšŽž";
            private const string REP_CHAR = "CcCcDdSsZz";

            public static string StringToGSM7String(string text)
            {
                var indicies = new List<int>();
                string s = "";

                for (int i = 0; i < text.Length; i++)
                {
                    if (SPEC_CHAR.Contains(text[i]))
                    {
                        s += REP_CHAR[SPEC_CHAR.IndexOf(text[i])];
                        continue;
                    }
                    s += text[i];
                }

                return s;
            }
        }
    }
}