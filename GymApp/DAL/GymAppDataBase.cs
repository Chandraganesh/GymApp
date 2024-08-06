using GymApp.Models;
using SQLite;

namespace GymApp.DAL;

public class GymAppDataBase
{
    SQLiteAsyncConnection dataBase;

    public GymAppDataBase()
    {

    }

    async Task Init()
    {
        if(dataBase is not null)
            return;
        else
            dataBase = new SQLiteAsyncConnection(Constants.DataBasePath, Constants.flags);

        var result = dataBase.CreateTableAsync<Member>();
    }

    public async Task<List<Member>> GetAllMembersAsync()
    {
        await Init();
        return await dataBase.Table<Member>().ToListAsync();
    }

    public async Task<Member> GetMemberAsync(int memberID)
    {
        await Init();
        return await dataBase.Table<Member>().Where(m => m.MemberID == memberID).FirstOrDefaultAsync();
    }

    public async Task<int> CreateOrUpdateMemberAsync(Member member)
    {
        await Init();
        if(await GetMemberAsync(member.MemberID) == null)
            return await dataBase.InsertAsync(member);
        else
            return await dataBase.UpdateAsync(member);
    }

    public async Task<int> DeleteMemberAsync(Member member)
    {
        await Init();
        return await dataBase.DeleteAsync(member);
    }
}