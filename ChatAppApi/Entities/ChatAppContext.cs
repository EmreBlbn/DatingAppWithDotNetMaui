using Microsoft.EntityFrameworkCore;

namespace ChatAppApi.Entities;

public class ChatAppContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=localhost;Database=TblUsers;Username=postgres;Password=bmob1234");

    public virtual DbSet<TblUser> TblUsers { get; set; } = null;
    public virtual DbSet<TblUserFriend> TblUserFriends { get; set; } = null;
    public virtual DbSet<TblMessage> TblMessages { get; set; } = null;
}