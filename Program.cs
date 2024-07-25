
using ConsoleAppPracticWork_1_var1.Data;
using ConsoleAppPracticWork_1_var1.Model;
using ConsoleAppPracticWork_1_var1.Modules;
using ConsoleAppPracticWork_1_var1.Repositories;
using ConsoleAppPracticWork_1_var1.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

// Вариант с консольным выводом

//var services = new ServiceCollection();
//services.AddSingleton<IRepositoryWork, RepositoryWork>();
//services.AddSingleton<Worker>();


//using var serviceProvider = services.BuildServiceProvider();
//var Employee = new Employee()
//{
//    FirstName = "Ivan",
//    LastName = "Petrov",
//    Patronymic = "Ivanovic",
//    Email = "ivan@gmail.com"
//};

//var worker = serviceProvider.GetRequiredService<Worker>();
//worker.CameToWork(Employee);
//Thread.Sleep(2000);
//worker.EscapeFromWork(Employee);

//var worker = new Worker(new RepositoryWork());

//worker.CameToWork(Employee);

//Thread.Sleep(1000);

//worker.EscapeFromWork(Employee);

// Вариант с записью данных в базу данных

var services = new ServiceCollection();
services.AddSingleton<IRepositoryWork, RepositoryWorkerDB>();
services.AddSingleton<Worker>();

using var context = new WorkerContext();
var employee = context.employees.Where(x => x.Id == 1).First();
using var serviceProvider = services.BuildServiceProvider();
var worker = serviceProvider.GetRequiredService<Worker>();
worker.CameToWork(employee);

Thread.Sleep(1000);

worker.EscapeFromWork(employee);