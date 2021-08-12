using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Financial_Manager_V0._0.EntityFramework;
using System.Windows;
using static System.Console;

namespace Financial_Manager_V0._0.Model
{
    class ClientModel
    {
        //Input properties
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        private string _email;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        private string _address;
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }
        private string _phone;
        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                _phone = value;
            }
        }
        private string _city;
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }
        private string _zipcode;
        public string Zipcode
        {
            get
            {
                return _zipcode;
            }
            set
            {
                _zipcode=value;
            }
        }
        //Name property for query only 
        private string _nameQuery;
        public string NameQuery
        {
            get
            {
                return _nameQuery;
            }
            set
            {
                _nameQuery = value;
            }
        }
        //Constructor 
        public ClientModel(string name, string phone , string address, string email, string city, string zip)
        {
            this.Name = name;
            this.Phone = phone;
            this.Address = address;
            this.Email = email;
            this.City = city;
            this.Zipcode = zip;
        }
        //Overloaded constructor for queries
        public ClientModel(string name)
        {
            this.NameQuery = name;
        }
        //Adds client to database 
        public void AddClient()
        {
            
            using (var context= new FinancialEntities())
            {
                try
                {
                    WriteLine("Client added");
                    var ClientEntry = new Client()
                    {
                        ClientName = this.Name,
                        ClientEmail = this.Email,
                        ClientCity = this.City,
                        ClientAddress = this.Address,
                        ClientPhone = Int32.Parse(this.Phone),
                        ClientZIP = this.Zipcode

                    };
                    context.Clients.Add(ClientEntry);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    WriteLine(ex.InnerException?.Message);

                }
            }
        }
        // Searches for an spececific client 
        public ClientModel SearchClient(string nameQuery)
        {
            ClientModel clientFound;
            using(var context=new FinancialEntities())
            {
                try
                {
                    var clientQuery = from item in context.Clients
                                      where item.ClientName == nameQuery
                                      select item;
                    foreach(var client in clientQuery)
                    {
                        clientFound = new ClientModel(client.ClientName, client.ClientPhone.ToString(), client.ClientAddress, client.ClientEmail, client.ClientCity, client.ClientZIP);
                    }
                }
                catch (Exception ex)
                {
                    WriteLine(ex.InnerException?.Message);
                }
            }
            throw new NotImplementedException();
        }

    }
}
