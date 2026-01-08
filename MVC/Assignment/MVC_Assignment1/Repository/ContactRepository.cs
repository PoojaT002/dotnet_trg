using MVC_Assignment1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using static MVC_Assignment1.Repository.ContactRepository;

namespace MVC_Assignment1.Repository
{
   
        public class ContactRepository : IContactRepository
        {
            private readonly ContactContext Context;

            public ContactRepository(ContactContext context)
            {
            Context = context;
            }

            public async Task <List<Contact>> GetAllAsync()
            {
                return await Context.Contacts.ToListAsync();
            }

            public async Task CreateAsync(Contact contact)
            {
            Context.Contacts.Add(contact);
                await Context.SaveChangesAsync();
            }

            public async Task DeleteAsync(long Id)
            {
                var contact = await Context.Contacts.FindAsync(Id);
                if (contact != null)
                {
                Context.Contacts.Remove(contact);
                    await Context.SaveChangesAsync();
                }
            }
        }
    
}