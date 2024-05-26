using MagicVilla_VillaAPI.Models.Dto;

namespace MagicVilla_VillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
            {
                new VillaDTO { Id = 1, Name = "Pool View", Sqfc = 100, Ocuppancy = 4}, 
                new VillaDTO { Id = 2, Name = "Beach View", Sqfc = 300, Ocuppancy = 3}
            };
    }
}
