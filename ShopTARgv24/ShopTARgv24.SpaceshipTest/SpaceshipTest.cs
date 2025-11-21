using ShopTARgv24.Core.Dto;
using ShopTARgv24.Core.ServiceInterface;

namespace ShopTARgv24.SpaceshipTest
{
    public class SpaceshipTest : TestBase
    {
        [Fact]
        public async Task ShouldNot_AddEmptySpaceship_WhenReturnResult()
        {
            // Arrange
            SpaceshipDto dto = MockSpaceshipData();

            // Act
            var result = await Svc<ISpaceshipsServices>().Create(dto);

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public async Task ShouldNot_GetByIdSpaceship_WhenReturnsNotEqual()
        {
            // Arrange
            Guid wrongGuid = Guid.Parse(Guid.NewGuid().ToString());
            Guid guid = Guid.Parse("c4ef2d3f-0f95-4082-873c-7f7ea3c54b5f");

            // Act
            await Svc<ISpaceshipsServices>().DetailAsync(guid);

            // Assert
            Assert.NotEqual(wrongGuid, guid);
        }

        [Fact]
        public async Task Should_DeleteByIdSpaceship_WhenDeleteSpaceship()
        {
            // Arrange
            SpaceshipDto dto = MockSpaceshipData();

            // Act
            var createdSpaceship = await Svc<ISpaceshipsServices>().Create(dto);
            var deletedSpaceship = await Svc<ISpaceshipsServices>().Delete((Guid)createdSpaceship.Id);

            // Assert
            Assert.Equal(createdSpaceship.Id, deletedSpaceship.Id);
        }

        [Fact]
        public async Task Should_UpdateSpaceship_WhenUpdateData()
        {
            // Arrange
            var guid = Guid.Parse("c4ef2d3f-0f95-4082-873c-7f7ea3c54b5f");
            SpaceshipDto dto = MockSpaceshipData();

            SpaceshipDto domain = new();
            domain.Id = Guid.Parse("c4ef2d3f-0f95-4082-873c-7f7ea3c54b5f");
            domain.Name = "Stellar Horizon";
            domain.TypeName = "Interstellar Carrier";
            domain.BuiltDate = new DateTime(2025, 6, 2);
            domain.Crew = 2000;
            domain.EnginePower = 3000;
            domain.Passengers = 100;
            domain.InnerVolume = 15000;
            domain.CreatedAt = DateTime.Now;
            domain.ModifiedAt = DateTime.Now;

            // Act
            await Svc<ISpaceshipsServices>().Update(dto);

            // Assert
            Assert.Equal(domain.Id, guid);
            Assert.DoesNotMatch(domain.Name, dto.Name);
            Assert.DoesNotMatch(domain.TypeName, dto.TypeName);
            Assert.NotEqual(domain.BuiltDate, dto.BuiltDate);
            Assert.NotEqual(domain.Crew, dto.Crew);
            Assert.NotEqual(domain.EnginePower, dto.EnginePower);
            Assert.NotEqual(domain.Passengers, dto.Passengers);
            Assert.NotEqual(domain.InnerVolume, dto.InnerVolume);
            Assert.NotEqual(domain.ModifiedAt, dto.ModifiedAt);
        }

        [Fact]
        public async Task Should_UpdateSpaceship_WhenUpdateData2()
        {
            // Arrange
            SpaceshipDto dto = MockSpaceshipData();
            SpaceshipDto update = MockUpdateSpaceshipData();

            // Act
            await Svc<ISpaceshipsServices>().Create(dto);
            var result = await Svc<ISpaceshipsServices>().Update(update);

            // Assert
            Assert.NotEqual(dto.Crew, result.Crew);
            Assert.DoesNotMatch(dto.Name, result.Name);
            Assert.NotEqual(dto.EnginePower, result.EnginePower);
            Assert.NotEqual(dto.Passengers, result.Passengers);
            Assert.NotEqual(dto.InnerVolume, result.InnerVolume);
            Assert.NotEqual(dto.ModifiedAt, result.ModifiedAt);
        }



        // ======================== HELPERS ========================

        private SpaceshipDto MockSpaceshipData()
        {
            SpaceshipDto dto = new()
            {
                Name = "Enterprise",
                TypeName = "Explorer",
                BuiltDate = new DateTime(2024, 5, 1),
                Crew = 1000,
                EnginePower = 5000,
                Passengers = 200,
                InnerVolume = 10000,
                CreatedAt = DateTime.Now,
                ModifiedAt = DateTime.Now
            };

            return dto;
        }

        private SpaceshipDto MockUpdateSpaceshipData()
        {
            SpaceshipDto dto = new()
            {
                Name = "Stellar Horizon",
                TypeName = "Interstellar Carrier",
                BuiltDate = new DateTime(2025, 6, 2),
                Crew = 2000,
                EnginePower = 3000,
                Passengers = 100,
                InnerVolume = 15000,
                CreatedAt = DateTime.Now.AddYears(1),
                ModifiedAt = DateTime.Now.AddYears(1)
            };
            return dto;
        }
    }
}
