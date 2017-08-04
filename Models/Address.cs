using System;
using System.Collections.Generic;
public class Address    
 {         
 private string _houseNumber;         
 private string _streetAddress;
 private string _landmark;
 private string _pincode; 
 private string _state;
 private string _country;
 public Address(string country, string state, string pincode, string landmark, string streetAddress, string houseNumber)
 {             
 _country = country;
 _state = state;
 _pincode = pincode;
 _landmark = landmark;
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
 public string GetLandMark()
 {             
 return _landmark;         
 }         
 public string GetPinCode()         
 {             
 return _pincode; 
 }         
 public string GetStater()
 {             
 return _state;         
 }         
 public string GetCountry()
 {             
 return _country;         
 }     
 }