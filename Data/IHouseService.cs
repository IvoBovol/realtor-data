///Hussein Abed Work
namespace BlazorServerCRUD.Data
{
    public interface IHouseService
    {
        List<House> Houses { get; set; }
        Task LoadHouse();
        Task<House> GetSingleHouse(int id);
        Task CreateHouse(House house);
        Task UpdateHouse(House house, int id);
        Task DeleteHouse(int id);
    }
}
