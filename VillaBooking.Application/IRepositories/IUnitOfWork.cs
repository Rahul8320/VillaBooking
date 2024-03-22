namespace VillaBooking.Application.IRepositories;

public interface IUnitOfWork
{
    IVillaRepository Villa { get; }
    IVillaNumberRepository VillaNumber { get; }
}
