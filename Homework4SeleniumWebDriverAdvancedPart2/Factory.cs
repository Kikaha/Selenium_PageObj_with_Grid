namespace Homework4SeleniumWebDriverAdvancedPart2
{
    public static class Factory
    {
        public static UserProperty CreateUser()
        {
            return new UserProperty
            {
                FirstName = "Duke",
                LastName = "Nukem",
                Password = "dukenukem123",
                Day = "3",
                Month = "3",
                Year = "1996",
                AdressFirstName = "Duke",
                AddressLastName = "Nukem",
                Address = "3DRealms HeadQuarters str.",
                City = "Las Vegas",
                State = "Nevada",
                Postalcode = "89111",
                Country = "United States",
                Phone = "151515151515",
                Alias = "gogogo"
            };
        }
    }
}
