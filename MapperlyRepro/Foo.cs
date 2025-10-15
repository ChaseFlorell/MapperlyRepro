namespace MapperlyRepro;

// Domain
public abstract class FooBase(string Bar);
public class Foo(string bar) : FooBase(bar);

// DTO
public abstract record FooBaseDto(string Bar);
public record FooDto(string Bar) : FooBaseDto(Bar);