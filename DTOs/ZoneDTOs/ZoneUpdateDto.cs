using System.ComponentModel;

namespace Coffee_Shop_Api.DTOs.ZoneDTOs
{
    public class ZoneUpdateDto
    {
        [DefaultValue("")]
        public required string ZoneName { get; set; }
    }
}
