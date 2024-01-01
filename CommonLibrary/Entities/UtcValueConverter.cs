using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CommonLibrary.Entities
{
    public class UtcValueConverter : ValueConverter<DateTime, DateTime>
    {
        public UtcValueConverter()
            : base(v => v, v => DateTime.SpecifyKind(v, DateTimeKind.Utc))
        {
        }
    }
}
