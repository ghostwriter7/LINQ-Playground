# Basic

LINQ - Language INtegreated Query

How is LINQ implemented?

1. Extension methods (called operators)
2. Query expression syntax (SQL-like)

### Operators

Higher-order functions (functions taking other functions)

### IEnumerable<T> - LINQ to Objects

1. Implemented by all .NET collection types (arrays, List<T> etc.)
2. LINQ operators are impl as extensions on it

### `IQueryable<T>` - LINQ to Entities

1. It will get turned into SQL queries

### `Enumerable` 

1. Class, not an interface
2. Contains static generators for sequences
3. Contains LINQ extension method definitions