using System;

namespace ConsoleApp1
{
	class LinearArray
	{
		private int[] data;
		private static Random generator = new Random();
		public LinearArray(int size)
		{
			//create a space for array
			data = new int[size];
			//fill Array with randim ints in range 10-99
			for (int i = 0; i < size; i++)
				data[i] = generator.Next(10, 100);
		}

		//perform a linear search on the data
		public int LinearSearch(int SearchKey)
		{
			//loop through array squentially
			for (int i = 0; i < data.Length; ++i)
				if (data[i] == SearchKey)
					return i;

			return -1; //else intger was not found
		}//end mathod linear search

		//method to output values array
		public override string ToString()
		{
			string temorary = string.Empty;
			//itreate thrugh array
			foreach (var item in data)
				temorary += item + " ";

			temorary += "\n";  //add newline characte
			return temorary;
		}
	}


}


