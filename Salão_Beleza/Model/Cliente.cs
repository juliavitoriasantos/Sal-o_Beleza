using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salão_Beleza.Model
{
   internal class Cliente { 
    public int CodProperty {get; set; }
    public string FullName {get; set;}
    public int Telephone {get; set;}
    public string Email {get; set;}
    public string Username {get; set;}
    public string Password {get; set;}

        public Cliente(int codproperty, string fullname, int telephone, string email, string username, string password)
        {
            CodProperty = codproperty;
            FullName = fullname;
            Telephone = telephone;
            Email = email;
            Username = username;
            Password = password;
        }
    }
}
