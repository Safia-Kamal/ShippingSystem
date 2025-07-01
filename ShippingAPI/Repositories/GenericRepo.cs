using ShippingAPI.Data;

namespace ShippingAPI.Repositories
{
    public class GenericRepo<T> where T : class
    {
        public ShippingContext db;
        public GenericRepo(ShippingContext db) {
            this.db = db;
        }

        public List<T> getAll()
        {
            return db.Set<T>().ToList();

        }
        public T getById(int id)
        {
            return db.Set<T>().Find(id);
        }
        public void add(T item)
        {
            db.Set<T>().Add(item);
        }
        public void edit(T item)
        {
            db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
        public void delete(int id)
        {
            T e = db.Set<T>().Find(id);
            db.Set<T>().Remove(e);
        }
    }
}
