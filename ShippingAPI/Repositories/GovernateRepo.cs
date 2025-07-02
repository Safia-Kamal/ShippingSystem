using ShippingAPI.Data;
using ShippingAPI.Models;

namespace ShippingAPI.Repositories
{
    public class GovernateRepo : GenericRepo<Governorate>
    {
        public GovernateRepo(ShippingContext db) : base(db)
        {
        }
        public Governorate getByName(string name)
        {
            return db.Governorates.FirstOrDefault(g => g.Name == name);
        }
    }
}
