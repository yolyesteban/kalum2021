namespace kalum2021.Models
{
    public class Usuarios
    {
        public int Id {get;set;}
        public string UserName{get;set;}
        public bool Enabled {get;set;}
        public string Nombres{get;set;}
        public string Apellidos{get;set;}
        public string Email{get;set;}

        public Usuarios()
        {
            
        }

        public Usuarios(int Id, string UserName, bool Enabled,string Nombres, string Apellidos, string Email)
        {
            this.Id = Id;
            this.UserName= UserName;
            this.Enabled = Enabled;
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.Email = Email;
        }
    }
}