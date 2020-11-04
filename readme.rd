1. run "dotnet new webapi" in project folder
2. run "dotnet watch run" in terminal, get http://localhost:5000/WeatherForecast in postman
3. class
    - partial class / abstract class
    - abstract v.s implement
        - abstract (intersection)
        - implement (unique)
    - function & property
    - construct
    public partial class <Class Name> {
        public string <PropertyName> { get ; set ;  }
        public <Function Name> (){
            this.id = Guid.NewGuid();
        }
    }
3. function construct
    public <Return Type> <Function Name>(<Parameter>)
    {
        return ;
    }

3. controller
    - what is controller
        - bind router & model
            - 1 request from client <website / postman>
            - asp.net core accept and match url from controller(see Controllers/AuthController.cs)
                
                
    - install
        - dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 3.1.3
        - dotnet aspnet-codegenerator controller -name AuthController -async -api -outDir Controllers

4. model
    - what is model
        - create model Pokemon
        - create model Pikachu inherit Pokemon
    - set property
    - engage controller

5. endpoints : 
[POST] /api/Pokemon/pikachu
    body : 
    {
        "name":"皮卡丘01",
        "lv" : 5 , 
        "maxHP" : 1999 ,
        "currentHP" : 999
    }
    response : 
    {
        "entity": {
            "type": "Pikachu",
            "name": "皮卡丘01",
            "currentHP": 999,
            "maxHP": 1999,
            "lv": 5,
            "id": "1728fe0b-8fe6-474e-a838-4e89a9f31cd1"
        }
    }

    Type Assertion
    ActionResult<dynamic>

[POST] /api/Auth/customize/post

[POST] /api/Auth

[GET] /api/Auth

[GET] /WeatherForecast