namespace BioHack.Core.Andr.Domain
{
    public interface ICustomEnum
    {
        int Id { get; set; }
        string Value { get; set; }
        string Display { get; set; }
    }
}