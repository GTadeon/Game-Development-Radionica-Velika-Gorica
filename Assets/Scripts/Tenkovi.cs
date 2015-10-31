using UnityEngine;
using System.Collections;

public class Tenkovi : MonoBehaviour {




	class Tenk 
	{
		//field
		private int hp;
		private string nadimak;
		private bool stanje; //ziv ili mrtav (true ili false)
		private int damage;
		private int predenakm;
		
		//property
		public int Hp 
		{
			get 
			{
				return this.hp;
			}
		}
		
		
		public string Nadimak
		{
			get 
			{
				return this.nadimak;
			}
		}
		public bool Stanje
		{
			get 
			{
				return this.stanje;
			}
			set{this.stanje=value;}
		}
		public int Damage
		{
			get 
			{
				return this.damage;
			}
		}
		public int Predenakm
		{
			get 
			{
				return this.predenakm;
			}
		}
		
		
		
		//metode
		public void PrijediKilometrazu (Tenk tenk1, int km)
		{
			tenk1.predenakm += km;
			
		}
		public void IspisStatistikeTenka(Tenk tenk1)
		{
			Debug.Log (string.Format("tenk:{0} ima {1} hp i {2} predene kilometraze i {3} damage",tenk1.Nadimak,tenk1.Hp,tenk1.Predenakm,tenk1.Damage));
			if(tenk1.stanje==true)
				Debug.Log("ovaj je jos uvijek ziv");
		}
		public void Ubij(Tenk tenkNeki)
		{
			tenkNeki.Stanje = false;
		}
		
		//konstruktor
		public Tenk (int zivoti, string NADimak, bool STAnje, int Steta, int Kilometraza)
		{
			
			this.hp = zivoti;
			this.nadimak = NADimak;
			this.stanje = STAnje;
			this.damage = Steta;
			this.predenakm = Kilometraza;
		}
	}

	Tenk slabi = new Tenk (10, "slabi", true, 10, 0);
	Tenk srednji = new Tenk (15,"srednji",true,15,0);
	Tenk jaki = new Tenk (20,"jaki",true,20,10);



	void Start()
	{
		slabi.IspisStatistikeTenka (slabi);
		srednji.IspisStatistikeTenka (srednji);
		jaki.IspisStatistikeTenka (jaki);
		jaki.Ubij (slabi);
		if (slabi.Stanje == false)
			Debug.Log ("taj je pak mrtav");
	}






}
