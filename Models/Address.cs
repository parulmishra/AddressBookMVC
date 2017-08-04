using System;
using System.Collections.Generic;

namespace AddressBook.Models
{
	public class Address    
	{         
		private string _houseNumber;         
		private string _streetAddress;
		private string _city;
		private string _pincode; 
		private string _state;
		private string _country;
		public Address(string country, string state, string pincode, string city, string streetAddress, string houseNumber)
		{             
			_country = country;
			_state = state;
			_pincode = pincode;
			_city = city;
			_streetAddress = streetAddress;
			_houseNumber = houseNumber;
		}         
		public string GetHouseNumber()
		{                 
			return _houseNumber;         
		}         
		public string GetStreetAddress()
		{             
			return _streetAddress;         
		}         
		public string GetCity()
		{             
			return _city;         
		}         
		public string GetPinCode()         
		{             
			return _pincode; 
		}         
		public string GetState()
		{             
			return _state;         
		}         
		public string GetCountry()
		{             
			return _country;         
		}     
	}
}