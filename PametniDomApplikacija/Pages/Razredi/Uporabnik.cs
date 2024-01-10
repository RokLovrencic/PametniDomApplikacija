using System;

namespace PametniDomAPP {
	public class Uporabnik {
		public int Id { get; set; }
        public string uime { get; set; }
        public string uenaslov { get; set; }
        public string geslo { get; set; }

        public void SetGeslo(ref string geslo) {
			this.geslo = geslo;
		}

        public Uporabnik(string username, string uenaslov , string geslo)
        {
            this.uime = username;
            this.uenaslov = uenaslov;
            this.geslo = geslo;
        }

        public Uporabnik()
        {
        }


    }

}
