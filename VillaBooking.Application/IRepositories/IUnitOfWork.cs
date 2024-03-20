namespace VillaBooking.Application.IRepositories;

public interface IUnitOfWork
{
    IVillaRepository Villa { get; }
}
