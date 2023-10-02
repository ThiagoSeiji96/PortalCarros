using Core.Entities;
using Repository.Persistence;

namespace Infrastructure.Persistence
{
    public class DataInitializer
    {
        public async static Task SeedDataBase(PortalCarrosDbContext portalCarrosDbContext)
        {
            if (!portalCarrosDbContext.Brands.Any())
            {
                var marcas = new List<CarBrand>
                    {
                        new CarBrand { Id = 1, Name = "Audi"},
                        new CarBrand { Id = 2, Name = "Bmw"}
                    };

                await portalCarrosDbContext.AddRangeAsync(marcas);
                await portalCarrosDbContext.SaveChangesAsync();
            }

            if(!portalCarrosDbContext.CarModels.Any())
            {
                var carros = new List<CarModel>
                {
                    new CarModel { Id = 1, Name = "A3", ModelYear = 2002, ModelProductionYear = 2003},
                    new CarModel { Id = 2, Name = "320", ModelYear = 2002, ModelProductionYear = 2003}
                };

                await portalCarrosDbContext.AddRangeAsync(carros);
                await portalCarrosDbContext.SaveChangesAsync();
            }

            if (!portalCarrosDbContext.CarAcessories.Any())
            {
                var opcionaisAnuncio = new List<CarAcessories>
                {
                    new CarAcessories { 
                        Id = 1, 
                        Id_AdviceDetails = 1, 
                        AirBag = true, 
                        Alarme = true, 
                        ArCondicionado = true, 
                        Blindado = true, 
                        CameraRe = true,
                        SensorRe = true,
                        Som = true,
                        TravaEletrica = true,
                        VidroEletrico = true
                    },
                    new CarAcessories { 
                        Id = 2,
                        Id_AdviceDetails = 0,
                        AirBag = false,
                        Alarme = false,
                        ArCondicionado = false,
                        Blindado = false,
                        CameraRe = false,
                        SensorRe = false,
                        Som = false,
                        TravaEletrica = false,
                        VidroEletrico = false
                    }
                };

                await portalCarrosDbContext.AddRangeAsync(opcionaisAnuncio);
                await portalCarrosDbContext.SaveChangesAsync();
            }

            if (!portalCarrosDbContext.CarPreservations.Any())
            {
                var anuncioInfoPreservamento = new List<CarPreservation>
                {
                    new CarPreservation
                    {
                        Id = 1,
                        Id_Advice = 1,
                        ChaveReserva = true,
                        ComGarantia = true,
                        ComManual = true,
                        RevisoesConcessionaria = true,
                        UnicoDono = true
                    },
                    new CarPreservation
                    {
                        Id = 2,
                        Id_Advice = 2,
                        ChaveReserva = false,
                        ComGarantia = false,
                        ComManual = false,
                        RevisoesConcessionaria = false,
                        UnicoDono = false
                    }
                };

                await portalCarrosDbContext.AddRangeAsync(anuncioInfoPreservamento);
                await portalCarrosDbContext.SaveChangesAsync();
            }

            if (!portalCarrosDbContext.CarRegularizations.Any())
            {
                var anuncioInfoRegularizao = new List<CarRegularization>
                {
                    new CarRegularization
                    {
                        Id = 1,
                        Id_Advice = 1,
                        IpvaPago = true,
                        PassagemLeilao = true,
                        PossuiMultas = true
                    },
                    new CarRegularization
                    {
                        Id = 2,
                        Id_Advice = 2,
                        IpvaPago = false,
                        PassagemLeilao = false,
                        PossuiMultas = false
                    }
                };

                await portalCarrosDbContext.AddRangeAsync(anuncioInfoRegularizao);
                await portalCarrosDbContext.SaveChangesAsync();
            }

            if (!portalCarrosDbContext.Advices.Any())
            {
                var anuncios = new List<Advice>
                {
                    new Advice
                    {
                        Id = 1,
                        Title = "Teste Titulo 01",
                        Description = "Teste Descrição 01",
                        Status = true,
                        IdUser = 1,
                    },
                    new Advice
                    {
                        Id = 2,
                        Title = "Teste Titulo 02",
                        Description = "Teste Descrição 02",
                        Status = true,
                        IdUser = 1,
                    }
                };

                await portalCarrosDbContext.AddRangeAsync(anuncios);
                await portalCarrosDbContext.SaveChangesAsync();
            }

            if (!portalCarrosDbContext.AdvicesDetails.Any())
            {
                var detalhesAnuncio = new List<AdviceDetails>
                {
                    new AdviceDetails
                    {
                        Id = 1,
                        Id_Advice = 1,
                        Id_Brand = 1,
                        Id_CarModel = 1,
                        Id_CarAcessories = 1,
                        Id_CarPreservation = 1,
                        Id_CarRegularization = 1,
                        DoorNumbers = Core.Enums.DoorNumberEnum.DuasPortas,
                        GasType = Core.Enums.GasTypeEnum.Flex,
                        SteeringType = Core.Enums.SteeringTypeEnum.Hidraulica,
                        TransmissionType = Core.Enums.TransmissionTypeEnum.Manual,
                        Hodometer = "180.000",
                        RotationDay = "Quarta-Feira",
                        HasGnv = false
                    },
                    new AdviceDetails
                    {
                        Id = 2,
                        Id_Advice = 2,
                        Id_Brand = 2,
                        Id_CarModel = 2,
                        Id_CarAcessories = 2,
                        Id_CarPreservation = 2,
                        Id_CarRegularization = 2,
                        DoorNumbers = Core.Enums.DoorNumberEnum.QuatroPortas,
                        GasType = Core.Enums.GasTypeEnum.Híbrido,
                        SteeringType = Core.Enums.SteeringTypeEnum.Eletrica,
                        TransmissionType = Core.Enums.TransmissionTypeEnum.Auto,
                        Hodometer = "360.000",
                        RotationDay = "Quinta-Feira",
                        HasGnv = true
                    }
                };

                await portalCarrosDbContext.AddRangeAsync(detalhesAnuncio);
                await portalCarrosDbContext.SaveChangesAsync();
            }
        }
    }
}
