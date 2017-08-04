using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using AddressBook.Models;

namespace AddressBook.Controllers
{
	public class HomeController : Controller  
	{         
		[HttpGet("/")]         
		public ActionResult Index()         
		{             
			List<Contact> contacts = Contact.GetAllContacts();
			return View(contacts);         
		}
		
		[HttpGet("/contact/{id}")]   
		public ActionResult GetContact(int id)
		{             
			Contact contact = Contact.Find(id); 
			return View(contact);   
		}     
		
		[HttpGet("/contact/create")]
		public ActionResult CreateContact()  
		{         
			return View(); 
		}  
		
		[HttpPost("/contact/new")] 
		public ActionResult NewContact()   
		{   
			Address address = new Address(Request.Form["country"], Request.Form["state"], Request.Form["pincode"], Request.Form["city"], Request.Form["streetaddress"], Request.Form["housenumber"]);     
			Contact contact = new Contact(Request.Form["name"], Request.Form["phonenumber"], address);  
			return View(contact);
		}   
		
		[HttpGet("/contact/delete/{id}")]
		public ActionResult DeleteContact(int id)        
		{  
			Contact.Delete(id);
			return View(); 
		}    
		
		[HttpGet("/contact/deleteall")] 
		public ActionResult DeleteAllContact()  
		{          
			Contact.ClearAllIds();  
			return View();   
		}  
		[HttpPost("/search")]
		public ActionResult Search()
		{
			string name = Request.Form["search"];
			var contacts = Contact.SearchContact(name);
			return View("Index", contacts);
		}
	}
}