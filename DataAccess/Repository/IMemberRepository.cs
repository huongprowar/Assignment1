using BusinessObject.Models;

namespace DataAccess.Repository
{

    public interface IMemberRepository
    {        
        Member GetMember(int id);
        void Update(Member member);
        IEnumerable<Member> GetMembers();
    }
}
