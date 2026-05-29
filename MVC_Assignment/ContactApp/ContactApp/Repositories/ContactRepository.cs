using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using ContactApp.Models;

namespace ContactApp.Repositories
{
    public class ContactRepository : IContactRepository
    {
        ContactContext db = new ContactContext();

        public async Task<List<Contact>> GetAllAsync()
        {
            return await db.Contacts.ToListAsync();
        }

        public async Task CreateAsync(Contact contact)
        {
            db.Contacts.Add(contact);
            await db.SaveChangesAsync();
        }

        public async Task DeleteAsync(long id)
        {
            var c = await db.Contacts.FindAsync(id);
            if (c != null)
            {
                db.Contacts.Remove(c);
                await db.SaveChangesAsync();
            }
        }
    }
}