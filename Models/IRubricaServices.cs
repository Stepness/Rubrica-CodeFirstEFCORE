using System.Collections.Generic;

namespace PlayGround_Dependency_Injection.Models
{
    public interface IRubricaServices
    {
        Contatto ottieniContatto();
        List<ViewModelHome> ottieniHome();
    }
}