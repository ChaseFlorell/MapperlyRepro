using Shouldly;
using Xunit;

namespace MapperlyRepro;

public class Tests
{
    [Fact]
    public void GivenChildMapper_WhenDerivedTypeMapping_ShouldMap()
    {
        // arrange
        var sut = new Mapper();
        var dto = new FooDto("bar");

        // act
        var act = () => sut.Map<Foo>(dto);

        // assert
        act.ShouldNotThrow()
            .ShouldBeOfType<Foo>();
    }
}