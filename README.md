# Issue

When using query variables that are part of an array it does not set the variables.

# Example of a query

```graphql
query blah($message1:String, $message2: String)
{
  contact(criteria: {
    messages: [
      { 
          message:$message1
      },
      {
          message: $message2
      }
    ]
  })
}
```

> the variables

```json
{
    "message1": "hello",
    "message2": "world"
}
```

Received Value

```json
{
  "data": {
    "contact": [
      null,
      null
    ]
  }
}
```

Expected value


```json
{
  "data": {
    "contact": [
      "hello",
      "world"
    ]
  }
}
```