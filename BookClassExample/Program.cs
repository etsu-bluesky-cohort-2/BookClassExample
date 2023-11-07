using BookClassExample;

var bookObject = new Book();

var auth = new Author();

auth.FirstName = "Test";
auth.LastName = "Test";
auth.PsName = "Test";

bookObject.AddAuthor(auth);

auth = new Author();

auth.FirstName = "Another Test";
auth.LastName = "AnotherTest";
auth.PsName = string.Empty;

bookObject.AddAuthor(auth);

Console.WriteLine(bookObject);
