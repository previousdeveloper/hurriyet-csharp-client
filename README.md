# Client
HurriyetApi wrapper for C# - http://developers.hurriyet.com.tr

## Install

```bash
  
PM> Install-Package HurriyetApiClient

```

## How to use  

**Init**  
```csharp
  IHurriyetApiConfiguration configuration = new HurriyetApiConfiguration("apikey");
  IHurriyetApiClient _hurriyetApiClient = new HurriyetApiApiClient(configuration);
```

**GET ARTICLES SYNC**  
```csharp
        [Test]
        public void Articles_Test()
        {
            List<ArticleResponse> result = _hurriyetApiClient.GetArticles().Result;

            result.Should().NotBeEmpty();
        }

```

**GET ARTICLES ASYNC**  
```csharp
        [Test]
        public async void Article_Async_Test()
        {
            List<ArticleResponse> result =  await _hurriyetApiClient.GetArticles();

            result.Should().NotBeEmpty();
        }

```

##TODO
- Add more Api Resource

##License

Code and documentation are available according to the *MIT* License (see [LICENSE](https://github.com/ziyasal/Httwrap/blob/master/LICENSE)).
