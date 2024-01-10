using System;

namespace PametniDomAPP {
	public class Dogodek {
		public DateTime datum {  get; set; }

		public Dogodek() { }

		public Dogodek(DateTime datum) {  this.datum = datum; }

		public void SetOpis(ref string opis) {
			throw new System.NotImplementedException("Not implemented");
		}

	}

}
