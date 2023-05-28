using BusinessObject.Models;

namespace DataAccess
{
    public class MemberDAO 
    {
        FstoreContext _context = FstoreContext.Instance;

        public Member GetMember(int id)
        {
            throw new NotImplementedException();
        }
        //public void Add(Member member)
        //{
        //    _context.Members.Add(member);
        //    _context.SaveChanges();
        //}
        //public void Update(Member member)
        //{
        //    _context.Members.Update(member);
        //    _context.SaveChanges();
        //}
        //public void Delete(Member member)
        //{
        //    _context.Members.Remove(member);
        //    _context.SaveChanges();
        //}
        //public void GetByID(int id) => _context.Members.FirstOrDefault(x => x.MemberId == id);

    }
}
