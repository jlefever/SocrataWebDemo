# Socrata Web Demo

This ASP.NET Core web application has one endpoint that retrieves a single column of a Socrata data set hosted on https://data.baltimorecity.gov. Calling this single endpoint just passes through to the Socrata API which does the heavy lifting. It could use something like [SODA.NET](https://github.com/CityofSantaMonica/SODA.NET).

## Example

```
https://localhost:44308/9agw-sxsr/policedistrict
```

becomes

```
https://data.baltimorecity.gov/resource/9agw-sxsr.json?$select=policedistrict
```