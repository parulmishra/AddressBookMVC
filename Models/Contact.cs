using System;
using System.Collections.Generic;

namespace AddressBook.Models
{
	public class Contact
    {         
		private string _name;
		private string _phoneNumber;
		private Address _address;
		private int _id;
		private static List<Contact> _addressBook = new List<Contact>();
		
		public Contact(string name, string phoneNumber, Address address)
		{             
			_name = name;
			_phoneNumber = phoneNumber;
			_address = address;
			_addressBook.Add(this);
			_id = _addressBook.Count; 
		}        
		public int GetId()
		{
			return _id;
		}
		public static void Delete(int id)
		{             
			_addressBook[id - 1] = null;
		}         
		public static Contact Find(int id)
		{             
			return _addressBook[id - 1];
		}         
		public static void ClearAllIds()
		{             
			_addressBook.Clear();
		}         
		public string GetName()
		{             
			return _name; 
		}         
		public string GetPhoneNumber()
		{             
			return _phoneNumber; 
		}         
		public Address GetAddress()
		{             
			return _address;         
		}  
		public static List<Contact> GetAllContacts()         
		{             
			return _addressBook;         
		}
  }
}