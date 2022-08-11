
 
var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();



var lst=new Employee();

//app.UseMiddleware<Startup>;//1.0

app.MapGet("/",()=>lst.GetEmployeesDeatils());
app.MapGet("/detail/{Id}",(int Id)=>lst.GetEmployeesDeatils().FirstOrDefault (d=>d.Id==Id));


app.Run();



public class  Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailId { get; set; }

    public List<Employee> GetEmployeesDeatils()
    {
        return new List<Employee>()
        {
            new Employee()
            {
                Id = 1,
                FirstName= "Test",
                LastName = "Name",
                EmailId ="Test.Name@gmail.com"
            },
            new Employee()
            {
                Id = 2,
                FirstName= "Test",
                LastName = "Name1",
                EmailId ="Test.Name1@gmail.com"
            }
        };
    }
}
