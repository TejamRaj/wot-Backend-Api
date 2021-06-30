using System.IO;
using System.Threading.Tasks;

namespace WorkPlaceOnTour.BACKEND.Components
{
    public interface ITourWorkplacePhotographs
    {
        Task<string> SaveTourWorkplacePhotographas(string name, Stream content);
    }
}
