using System.Collections.Generic;

namespace PlayGround_Dependency_Injection.Models
{
    public class Servizi : IRubricaServices
    {
        public Contatto ottieniContatto()
        {
            throw new System.NotImplementedException();
        }

        public List<ViewModelHome> ottieniHome()
        {
            //scorri il database e carica in una lista
            throw new System.NotImplementedException();
        }
    }
}