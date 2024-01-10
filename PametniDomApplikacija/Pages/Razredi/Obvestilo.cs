using System;

namespace PametniDomAPP {
	public class Obvestilo {

		public int Id { get; set; }
		public string vsebina {  get; set; }
     
        public Naprava Naprava { get; set; }

        public Obvestilo()
		{

		}

		public Obvestilo(string vs, Naprava npr)
		{
			this.vsebina = vs;

			this.Naprava = npr;
		}

		public void SetSporocilo(ref string sporocilo) {
			throw new System.NotImplementedException("Not implemented");
		}

	}

}
