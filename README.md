# hc-5893

https://github.com/ChilliCream/graphql-platform/issues/5893

- `docker compose up --detach`
- `dotnet watch --no-hot-reload`
- http://localhost:5095/graphql/
- Queries:
  ```gql
  query one {
    usuarios2 {
      codigo
      data {
        rootElement
      }
    }
  }

  query two {
    usuarios {
      codigo
      data {
        rootElement
      }
    }
  }
  ```

Query `two` error:

> Type 'System.Text.Json.JsonDocument' does not have a default constructor (Parameter 'type')