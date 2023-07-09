using GameProject;

GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
gamerManager.Add(new Gamer { Id = 1, BirthYear=1982, FirstName="NİZES", LastName="LORE", IdentityNumber=12345 }) ;


