﻿using ShopTARgv24.Data;
using ShopTARgv24.Core.Domain;
using ShopTARgv24.Core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopTARgv24.Core.ServiceInterface;

namespace ShopTARgv24.ApplicationServices.Services
{
    public class SpaceshipsServices : ISpaceshipsServices
    {
        private readonly ShopTARgv24Context _context;
        
        public SpaceshipsServices
            (ShopTARgv24Context context)
        {
            _context = context;
        }

        public async Task<Spaceship> Create(SpaceshipDto dto)
        {
            Spaceship spaceship = new Spaceship();
            {
                spaceship.Id = Guid.NewGuid(); // Generate a new GUID for the spaceship
                spaceship.Name = dto.Name;
                spaceship.TypeName = dto.TypeName;
                spaceship.BuiltDate = dto.BuiltDate;
                spaceship.Crew = dto.Crew;
                spaceship.EnginePower = dto.EnginePower;
                spaceship.Passengers = dto.Passengers;
                spaceship.InnerVolume = dto.InnerVolume;
                spaceship.CreatedAt = DateTime.Now;
                spaceship.ModifiedAt = DateTime.Now;

                await _context.Spaceships.AddAsync(spaceship);
                await _context.SaveChangesAsync();
                
                return spaceship;
            }
        }
    }
}
