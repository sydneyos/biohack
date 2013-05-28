namespace BioHack.Core.Andr.Domain
{
    public interface ICustomEnum
    {
        long Id { get; set; }
        string Value { get; set; }
        string Display { get; set; }
    }
}