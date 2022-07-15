using System.Linq.Expressions;

namespace Selector.Test
{
    public class SelectorTest
    {
        [Fact]
        public void SelectorGet()
        {
            Assert.Equal(nameof(Foo.Time), Selector.Get<Foo, DateTime>(foo => foo.Time));
            Assert.Equal(nameof(Foo.Uid), Selector.Get<Foo, Guid>(foo => foo.Uid));
            Assert.Equal(nameof(Foo.ID), Selector.Get<Foo, int>(foo => foo.ID));
            Assert.Equal(nameof(Foo.Name), Selector.Get<Foo, string>(foo => foo.Name));

        }
        [Fact]
        public void SelectWrongProperty()
        {
            Assert.Throws<FormatException>(() => Selector.Get<Foo, string>(foo => "123"));
            Assert.Throws<ArgumentException>(() => Selector.Get<Foo, string>(foo => new FooWrong().Name));
        }

        public class Foo
        {
            public DateTime Time { get; set; }
            public Guid Uid { get; set; }
            public int ID { get; set; }
            public string Name { get; set; }
        }

        public class FooWrong
        {
            public string Name { get; set; }
        }
    }
}