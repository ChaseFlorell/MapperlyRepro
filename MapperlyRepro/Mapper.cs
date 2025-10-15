using Riok.Mapperly.Abstractions;

namespace MapperlyRepro;

[Mapper]
public sealed partial class Mapper
{
    public partial T Map<T>(object source);

    [UseMapper] private readonly ChildMapper _childMapper = new();
}

[Mapper]
internal sealed partial class ChildMapper
{
    [MapDerivedType<FooDto, Foo>]
    public partial FooBase Map(FooBaseDto source);
}