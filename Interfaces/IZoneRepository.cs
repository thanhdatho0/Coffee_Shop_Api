using Coffee_Shop_Api.DTOs.CategoryDTOs;
using Coffee_Shop_Api.DTOs.ZoneDTOs;

namespace Coffee_Shop_Api.Interfaces
{
    public interface IZoneRepository
    {
        Task<List<ZoneDto>> GetAllAsync();
        Task<ZoneDto?> GetByIdAsync(int id);
        Task<ZoneDto> CreateAsync(ZoneCreateDto zoneCreateDto);
        Task<ZoneDto?> UpdateAsync(int id, ZoneUpdateDto zoneUpdateDto);
    }
}
