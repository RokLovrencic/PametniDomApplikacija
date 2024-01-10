using System;

namespace PametniDomAPP {
	public class Naprava {
		public int Id{  get; set; }
		public string n_ime { get; set; }
        public DateTime prvic_povezan { get; set; }

		public Naprava() { }

		public Naprava(string n_ime, DateTime prvic_povezan)
        {
            this.n_ime = n_ime;
            this.prvic_povezan = prvic_povezan;
        }

        public void SetImeNaprave(ref string n_ime) {
			throw new System.NotImplementedException("Not implemented");
		}

	}

}
