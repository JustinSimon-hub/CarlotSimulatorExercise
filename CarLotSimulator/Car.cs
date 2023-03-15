using System;
namespace CarLotSimulator
{
	public class Car
	{
		public Car()
		{
		}

		
		private int car2Year;
		private string car2Make;
		private string car2Model;
		private string car2EngineNoise;
		private string car2HonkNoise;
		private bool car2IsDrivable;
		public int Car2Year
		{
			get
			{
				return car2Year;
			}
			set
			{
				car2Year = value;
			}

		}
		public string Car2Make
		{
			get
			{
				return car2Make;
			}
			set
			{
				car2Make = value;
			}
		}
		public string Car2Model
		{
			get
			{
				return car2Model;
			}
			set
			{
				car2Model = value;
			}
		}
		public string Car2EngineNoise
		{
			get
			{
				return car2EngineNoise;
			}
			set
			{
				car2EngineNoise = value;
			}
		}
		public string Car2HonkNoise
		{
			get
			{
				return car2HonkNoise;
			}
			set
			{
				car2HonkNoise = value;
			}
		}
		public bool Car2IsDrivable
		{
			get
			{
				return car2IsDrivable;
			}
			set
			{
				car2IsDrivable = value;
			}


		}

		public int Car3Year { get; set; } = 2021;
		public string Car3Make { get; set; } = "McLaren";
		public string Car3Model { get; set; } = "XL";
		public string Car3EngineNoise { get; set; } = "Wheeeeewheeeewheeee";
		public string Car3HonkNoise { get; set; } = "Bonk bink";
		public bool Car3IsDrivable { get; set; } = true;
		



        public int Year {get; set;}
		public string Make {get; set;}
		public string Model {get; set;}
		public string EngineNoise {get; set;}
		public string HonkNoise {get; set;}
		public bool IsDrivable { get; set; }
		
public string MakeEngineNoise(string EngineNoise)

		{
			return EngineNoise;
		}


		public string MakeHonkNoise(string HonkNoise)
		{
			return HonkNoise;
				
		}
		


	}

}



//Create a seperate class file called Car
//Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
//Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
//The methods should take one string parameter: the respective noise property
