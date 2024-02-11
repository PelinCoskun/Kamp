// See https://aka.ms/new-console-template for more information
using ConsoleApp1.Business;
using ConsoleApp1.DataAccess.Concretes;
using ConsoleApp1.Entities;

Console.WriteLine("Hello, World!");


CourseManager courseManager = new(new EfCourseDal());
List<Course> courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name + "/" + courses2[i].Price);
}


IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentitiy = "564215665646";
customer1.FirstName = "Pelin";
customer1.LastName = "Coşkun";
customer1.CustomerNumber = "212323";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentitiy = "56454787646";
customer2.FirstName = "İzel";
customer2.LastName = "Coşkun";
customer2.CustomerNumber = "654654654";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Ece";
customer3.CustomerNumber = "21545445251";
customer3.TaxtNumber = "54656565";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "Çağdaş";
customer4.CustomerNumber = "899987551";
customer4.TaxtNumber = "21541212";

BaseCustomer[] customers = {customer1, customer2, customer3, customer4};

//polymorphism
foreach (BaseCustomer customer in customers)
{
    
    Console.WriteLine(customer.CustomerNumber);
}
