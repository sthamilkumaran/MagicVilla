﻿using MagicVilla_VillaAPI.Models.Dto;

namespace MagicVilla_VillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> VillaList = new List<VillaDTO>
        {
            new VillaDTO { Id = 1, Name = "Tamil" ,Occupancy = 100, Sqtf = 12,},
            new VillaDTO { Id = 2,Name = "Kumaran", Occupancy = 12, Sqtf = 100},
        };
    }
}
