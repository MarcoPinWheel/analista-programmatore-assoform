using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcheggio
{
    internal class Veicolo
    {
        public string targa;
        public DateTime arrivo;
        public DateTime uscita;

        public Veicolo(string targa, DateTime arrivo)
        {
            this.targa = targa;
            this.arrivo = arrivo;
        }

        public int Tempoparcheggio()
        {
            uscita = DateTime.Now;
            TimeSpan tempo = uscita - arrivo;
            double ore = (double)tempo.TotalHours;
            return (int)Math.Ceiling(ore) * 2;

          /* if (tempo.Minutes > 0 || tempo.Seconds > 0 || tempo.Milliseconds > 0)
            {
                ore++; // arrotondo all'ora successiva
            }

            if (ore < 1) 
            {
                ore = 1; 
            }

            return ore * 2; */
        }

        public string getInfoVeicolo()
        {
            return $"Il veicolo con targa {targa} è arrivato il {arrivo.Date.ToString("dd/MM/yyyy")} alle {arrivo.ToString("HH:mm")}";
        }
    }
}