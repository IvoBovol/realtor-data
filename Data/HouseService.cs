using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;


///Hussein Abed Work
namespace BlazorServerCRUD.Data
{
    public class HouseService : IHouseService
    {
        private readonly DataContext _context;
        private readonly NavigationManager _navigationManager;

        public HouseService(DataContext context, NavigationManager navigationManager)
        {
            _context = context;
            _navigationManager = navigationManager;
            _context.Database.EnsureCreated();
        }

        public List<House> Houses { get; set; } = new List<House>();
       

        public async Task CreateHouse(House house)
        {
            _context.Houses.Add(house);
            await _context.SaveChangesAsync();
            _navigationManager.NavigateTo("vi");
        }

    

        public async Task DeleteHouse(int id)
        {
            var dbHouse = await _context.Houses.FindAsync(id);
            if (dbHouse == null)
                throw new Exception("No house here. :/");

            _context.Houses.Remove(dbHouse);
            await _context.SaveChangesAsync();
            _navigationManager.NavigateTo("vi");
        }

     

        public async Task<House> GetSingleHouse(int id)
        {
            var house = await _context.Houses.FindAsync(id);
            if (house == null)
                throw new Exception("No House here. :/");
            return house;
        }

     

        public async Task LoadHouse()
        {
            Houses = await _context.Houses.ToListAsync();
        }

      

        public async Task UpdateHouse(House house, int id)
        {
            var dbHouse = await _context.Houses.FindAsync(id);
            if (dbHouse == null)
                throw new Exception("No House here. :/");

            dbHouse.City = house.City;
            dbHouse.Status = house.Status;
            dbHouse.Year = house.Year;

            await _context.SaveChangesAsync();
            _navigationManager.NavigateTo("vi");
        }

      
    }
}
