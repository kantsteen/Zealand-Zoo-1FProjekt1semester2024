namespace Zealand_Zoo_1FProjekt1semester2024.Models
{
    public class User {
        private bool _admin;
        public bool Admin {
            get { return _admin; } 
            set { bool _admin; }
            
}
        public User()
        {
            _admin = false;
        }
    }
}
