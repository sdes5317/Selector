# Features
Example usage:
```
public class SelectorTest
{
    [Fact]
    public void Get()
    {
        Assert.Equal(nameof(Foo.Time), Selector.Get<Foo>(foo => foo.Time));
        Assert.Equal(nameof(Foo.Uid), Selector.Get<Foo>(foo => foo.Uid));
        Assert.Equal(nameof(Foo.ID), Selector.Get<Foo>(foo => foo.ID));
        Assert.Equal(nameof(Foo.Name), Selector.Get<Foo>(foo => foo.Name));
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
