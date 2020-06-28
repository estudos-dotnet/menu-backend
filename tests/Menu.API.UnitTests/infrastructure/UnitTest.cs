using Bogus;

namespace Menu.API.UnitTests.infrastructure
{
    public abstract class UnitTest
    {
        protected Faker Generator { get; set; } = new Faker();
    }
}
