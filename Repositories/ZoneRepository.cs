using Coffee_Shop_Api.Data;
using Coffee_Shop_Api.DTOs.ZoneDTOs;
using Coffee_Shop_Api.Interfaces;
using Coffee_Shop_Api.Mappers;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace Coffee_Shop_Api.Repositories
{
    public class ZoneRepository(ApplicationDBContext db) : IZoneRepository
    {
        public async Task<ZoneDto> CreateAsync(ZoneCreateDto zoneCreateDto)
        {
            var zoneModel = zoneCreateDto.ToZoneFromCreateDto();
            await db.Zones.AddAsync(zoneModel);
            await db.SaveChangesAsync();
            return zoneModel.ToZoneDto();
        }

        public async Task<List<ZoneDto>> GetAllAsync()
        {
            return await db.Zones.Select(z => z.ToZoneDto()).AsNoTracking().ToListAsync();
        }

        public async Task<ZoneDto?> GetByIdAsync(int id)
        {
            var zoneModel = await db.Zones.FirstOrDefaultAsync(z => z.ZoneId == id);
            return zoneModel?.ToZoneDto();
        }

        public async Task<ZoneDto?> UpdateAsync(int id, ZoneUpdateDto zoneUpdateDto)
        {
            var zoneModel = await db.Zones.FirstOrDefaultAsync(z => z.ZoneId == id);
            if (zoneModel == null) return null;
            zoneModel.ToZoneFromUpdateDto(zoneUpdateDto);
            return zoneModel.ToZoneDto();
        }
    }
}
