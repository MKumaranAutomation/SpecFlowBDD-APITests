using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowBDDAPITest
{
	class ValidateResponse
	{
		/// <summary>
		/// Gets the Count
		/// </summary>
		[JsonProperty("total")]
		public int Total { get; private set; }
	}
}
