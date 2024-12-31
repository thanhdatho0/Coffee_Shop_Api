using System.ComponentModel;

namespace Coffee_Shop_Api.DTOs.ZoneDTOs
{
    public class ZoneDto
    {
        public int ZoneId { get; set; }
        [DefaultValue("")]
        public string ZoneName { get; set; } = string.Empty;
    }
}
