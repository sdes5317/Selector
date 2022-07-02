using Selector.Sample.Repository;

var repo = new Repository();
repo.SelectDistinctPropertyFromPerson(person => person.Gender);
repo.SelectDistinctPropertyFromPerson(person => person.Age);
