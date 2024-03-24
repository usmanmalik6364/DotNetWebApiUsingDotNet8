using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
public interface IHouseRepository{
    Task<List<HouseDto>> GetAll();
    Task<HouseDetailDto?> Get(int id);
}
public class HouseRepository : IHouseRepository{
    private readonly HouseDbContext context;
    public HouseRepository(HouseDbContext dbContext){
        context = dbContext;
    }
    public async Task<List<HouseDto>> GetAll(){
        return await context.Houses.
        Select(h=>
        new HouseDto(h.Id,h.Address,h.Country,h.Price))
        .ToListAsync();
    }
    public async Task<HouseDetailDto?> Get(int id){
        var house =  await context.Houses.SingleOrDefaultAsync(h => h.Id == id);
        if(house == null)
            return null;
        return new HouseDetailDto(house.Id,house.Address,
        house.Country,house.Price,house.Description,house.Photo);
    }
}