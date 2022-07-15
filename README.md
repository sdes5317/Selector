# Features
Example usage:
```
public class SelectorTest
{
    [Fact]
    public void Get()
    {
        Assert.Equal(nameof(Foo.Time), Selector.Get<Foo, DateTime>(foo => foo.Time));
        Assert.Equal(nameof(Foo.Uid), Selector.Get<Foo, Guid>(foo => foo.Uid));
        Assert.Equal(nameof(Foo.ID), Selector.Get<Foo, int>(foo => foo.ID));
        Assert.Equal(nameof(Foo.Name), Selector.Get<Foo, string>(foo => foo.Name));
    }

    class Foo
    {
        public Guid Time { get; set; }
        public Guid Uid { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
```
Example in [Repository](../master/Selector.Sample/Repository/Repository.cs )
```
var repo = new Repository();
repo.SelectDistinctPropertyFromPerson(person => person.Gender);
repo.SelectDistinctPropertyFromPerson(person => person.Age);
```
