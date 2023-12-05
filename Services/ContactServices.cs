using BookAPI.Data;
using BookAPI.DataTransferObjects;
using BookAPI.Interfaces;
using BookAPI.Model;

namespace BookAPI.Services
{
    //public class ContactServices : IContactServices
    //{
    //    private readonly ApiDbContext _ctx;

    //    public ContactServices(ApiDbContext ctx)
    //    {
    //        this._ctx = ctx;
    //    }
        //public Contact AddContact(ContactDto contactDto)
        //{
        //    var contact = new Contact
        //    {
        //        Id = contactDto.Id,
        //        Name = contactDto.Name,
        //        Email = contactDto.Email,
        //        PhoneNumber = contactDto.PhoneNumber,
        //    };
        //    throw new NotImplementedException();
        //}

        //public string DeleteContact(string id)
        //{
        //    var result = _ctx.Contacts.FirstOrDefault(s => s.Id == id);
        //    if (result != null)
        //    {
        //        _ctx.Contacts.Remove(result);
        //    }
        //    return $"No Matching id found";
        //}

        //public Contact EditContact(string id)
        //{
        //    var result = _ctx.Contacts.FirstOrDefault(s => s.Id == id);
        //    if (result != null)
        //    {
        //        _ctx.Contacts.Update(result);
        //        _ctx.SaveChanges();
        //    }
        //    return result;
        //}

        //public List<Contact> GetContacts()
        //{
        //    var result = _ctx.Contacts.Join(_ctx.Users,
        //                                    contact => contact.UserId, 
        //                                    user => user.Id, 
        //                                    (contact, user) => new Contact
        //                                    {
        //                                        Id = contact.Id,
        //                                        Name = contact.Name,
        //                                        Email = contact.Email,
        //                                        PhoneNumber = contact.PhoneNumber,
        //                                    }).ToList();
        //    return result;
        //}
    //}
}
