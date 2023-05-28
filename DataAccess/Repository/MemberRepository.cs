using BusinessObject.Models;

namespace DataAccess.Repository
{
    public class MemberRepository : BaseRepository<Member>, IMemberRepository
    {
        FstoreContext _context = FstoreContext.Instance;
        public Member GetMember(int id)
        {
            return _context.Members.FirstOrDefault(x => x.MemberId== id);
        }
        public IEnumerable<Member> GetMembers()
        {
            return _context.Members;
        }

        public void Update(Member member)
        {
            Member _member = _context.Members.FirstOrDefault(x => x.MemberId == member.MemberId);
            _member.Email = member.Email;
            _member.CompanyName= member.CompanyName;
            _member.City = member.City;
            _member.Country = member.Country;
            _member.Password = member.Password;
            _context.SaveChanges();
        }
    }
}
