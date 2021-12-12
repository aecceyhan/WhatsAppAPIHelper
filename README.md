# Whatsapp API Helper
Whatsapp API Models

Simpler integration helper for WhatsApp Business API.

## IMPORTANT

Currently, WhatsApp does not have public API access yet. You have to use one of the solution providers APIs for more information check https://www.whatsapp.com/business/api. But most of the soliton providers just proxy original WhatsApp APIs which are currently documented on https://developers.facebook.com/docs/whatsapp/api/messages. When I prepared this helper I assume that your solution provider reflect original APIs.

## Installing


```shell
  Install-Package WhatsappAPIHelper -Version 1.0.0
```

## Usage

```cs
  using WhatsappAPIHelper;
```

Basic message


```cs
  MainRequestModel mainRequestModel = new MainRequestModel
  {
    recipient_type = recipient_type_enum.individual,
    to = "phone number to test with country code",
    type = mainRequest_type_enum.text,
    text = new Text
    {
      body = "Hello World!"
    },              
  };  
  
  //serilse this mainRequestModel to json and send your solition providers API

```

Interactive message

```cs
   MainRequestModel mainRequestModel = new MainRequestModel
   {
      recipient_type = recipient_type_enum.individual,
      to = "phone number to test with country code",
      type = mainRequest_type_enum.interactive,
      interactive = new Interactive
      {
         type = interactive_type_enum.list,
         body = new Body
         {
            text = "body text"
         },
         footer = new Footer
         {
            text = new Text
            {
              body = "Powerd by Emre Ceyhan"
            }  
         }
      },
      action = new WhatsappAPIHelper.Action
      {
          button = "Press me",
          sections = new List<Section>
          {
              new Section
              {
                  title = "first section",
                  rows = new List<Row>
                  {
                     new Row
                     {
                         id = "unique123",
                         title = "row title 1",
                         description = "description abc"
                     },
                     new Row
                     {
                         id = "unique456",
                         title = "row title 2",
                         description = "description xyz"
                     }
                  }
              },
              new Section
              {
                  title = "second section",
                  rows = new List<Row>
                  {
                     new Row
                     {
                         id = "unique321",
                         title = "row title 1",
                         description = "description abc"
                     },
                     new Row
                     {
                         id = "unique654",
                         title = "row title 2",
                         description = "description xyz"
                     }
                  }
              }
           }
       }
    };
    
      //serilse this mainRequestModel to json and send your solition providers API

 ```





## TODO

* Add more examples
* Add more models
* Add webhook helpers
* Publish as a nuget pack



## Licensing

This project is licensed under MIT license. 

