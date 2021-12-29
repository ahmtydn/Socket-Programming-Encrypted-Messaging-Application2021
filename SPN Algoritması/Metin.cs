using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SPN_Algoritması
{
    public class Metin
    {
        public string GirilecekMetin { get; set; }
        public string Anahtar { get; set; }
        public string SifrelenmisMetin { get; set; }
        public string CozulmusMetin { get; set; }
        public string Saniye { get; set; }
       
        public Metin(string girilecek_metin, string anahtar)
        {
            this.GirilecekMetin = girilecek_metin;
            this.Anahtar = anahtar;
         
        }
        public string MetinSifreleme()
        {
            int j = 0;
            for (int i = 0; i < GirilecekMetin.Length; i++)
            {
                SifrelenmisMetin += Convert.ToChar(Convert.ToInt32(GirilecekMetin[i] + Convert.ToInt32(Anahtar[j])) % 351);
                j += 1;
                if (j == Anahtar.Length)
                    j = 0;
            }
            return SifrelenmisMetin;

        }
        public string MetinCozme()
        {
            int j = 0, anahtar = 0;
            for (int i = 0; i < GirilecekMetin.Length; i++)
            {
                anahtar = Convert.ToInt32(GirilecekMetin[i]) - Convert.ToInt32(Anahtar[j]);
                if (anahtar <= 0)
                {
                    anahtar += 351;
                }   
                    
                else
                    anahtar %= 351;
                CozulmusMetin = CozulmusMetin + Convert.ToChar(anahtar);
                j += 1;
                if (j == Anahtar.Length)
                    j = 0;
            }
            return CozulmusMetin;
        }
    }
}
