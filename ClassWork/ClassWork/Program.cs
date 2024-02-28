using ClassWork.Controllers;
using ClassWork.Models;

UserController userController = new();

//userController.GetById();

AccountController accountController = new();
//accountController.CheckByEmailAndPassword();

Car car = new();

car.speed = 600;
car.Color = "Green";
//Console.WriteLine(car.Color);
Book book = new();
book.Name = "salam";
//Console.WriteLine(book.Name);

Bird bird = new();
//bird.AnimalSoud();

Animal animal = new Bird();

object test = new();

//Console.WriteLine(book.ToString());

string name = "Kamran";
String name2 = new String("Kamran");

int a = 5;

Int32 b = new();

b = 50;
//Console.WriteLine(b);

Test1 test1 = new();

test1.Test();