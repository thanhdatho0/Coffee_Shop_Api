using Coffee_Shop_Api.DTOs.ZoneDTOs;
using Coffee_Shop_Api.Models;

namespace Coffee_Shop_Api.Mappers
{
    public static class ZoneMappers
    {
        public static ZoneDto ToZoneDto(this Zone zone)
        {
            return new ZoneDto
            {
                ZoneId = zone.ZoneId,
                ZoneName = zone.ZoneName,
            };
        }

        public static Zone ToZoneFromCreateDto(this ZoneCreateDto zoneCreateDto)
        {
            return new Zone { ZoneName = zoneCreateDto.ZoneName };
        }

        public static void ToZoneFromUpdateDto(this Zone zone, ZoneUpdateDto zoneUpdateDto)
        {
            zone.ZoneName = zoneUpdateDto.ZoneName;
        }
    }
}
