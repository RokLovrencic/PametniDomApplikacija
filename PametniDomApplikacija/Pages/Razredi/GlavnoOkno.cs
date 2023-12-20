using System;

namespace PametniDomAPP {
	public class GlavnoOkno {
		public void SetPrijavljenUporabnik(ref Uporabnik uporabnik) {
			throw new System.NotImplementedException("Not implemented");
		}
		public void Close() {
			throw new System.NotImplementedException("Not implemented");
		}
		public void IzpisVsehNaprav() {
			throw new System.NotImplementedException("Not implemented");
		}

		private PrijavaUporabnikaOkno prijavaUporabnikaOkno;
		private RegistracijaUporabnikaOkno registracijaUporabnikaOkno;
		private PorabaElektrikeOkno porabaElektrikeOkno;
		private PodatkovnaBaza podatkovnaBaza;
		private PosodablanjeOkno[] posodablanjeOknos;
		private ZgodovinaOkno[] zgodovinaOknos;
		private VideoOkno[] videoOknos;
		private UpravljanjeNapravOkno[] upravljanjeNapravOknos;
		private NaprednaStatistikaOkno[] naprednaStatistikaOknos;

	}

}
