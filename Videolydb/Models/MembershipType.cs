using System.ComponentModel.DataAnnotations;

namespace Videolydb.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        [Required]
        public string Name { get; set; }
        public short signUpFee { get; set; }
        public byte durationInMonths { get; set; }
        public byte discountRate { get; set; }

        public static readonly byte Unknown = 0;
        public static readonly byte PayAsYouGo = 1;
    }
}