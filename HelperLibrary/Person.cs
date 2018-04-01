﻿using System;
using System.Collections.Generic;
using System.Text;


namespace HelperLibrary
{
    public class Person
    {
		public int ID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string EmailAddress { get; set; }
		public string PhoneNumber { get; set; }


		//Return Format: "Tim Smith (test@test.com)"
		public string FullInfo
		{
			get { return $"{ FirstName } { LastName } ({ EmailAddress })"; }

		}
		

	}
}
