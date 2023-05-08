using Core.Uslugi;
using Domena;
using Domena.Models;


/*
using (FleetDb db = new FleetDb())
    // Dodanie wielu obiektów
{
    var vehicleTypes = db.VehicleTypes.ToList();

    foreach (VehicleType vehicleType in vehicleTypes)
    {
        Console.WriteLine($"VehicleType: {vehicleType.Id} {vehicleType.Name}");
    }


    var typeOne = db.VehicleTypes.Where(x => x.Id == 1).First();
    // f(x) = x*2
    var typeTwo = db.VehicleTypes.Find(2);



    // Dodanie 1 obiektu
    var createNew = new VehicleType()
    {
        Name = "Autobus"
    };
    var addResult = db.VehicleTypes.Add(createNew);
    db.SaveChanges();

    Console.WriteLine($"Dodany obiekt jest pod Id: {addResult.Entity.Id}"); //wyświetlenie, gdzie jest ten obiekt 



    // Dodanie obiektu 
    createNew.Name = "Bus";
    db.VehicleTypes.Update(createNew);
    db.SaveChanges();


    //Vehicle car = new Vehicle();
    //car.TypeId = 1;
    //car.DriverId = 2;


    // Usuwanie obiektu
    db.VehicleTypes.Remove(createNew);
    db.SaveChanges();
}
*/
/*
Vehicle[] arr = new Vehicle[] {};

List<Vehicle> list = new List<Vehicle>() {
    new Vehicle()
    {
        Model = "Skoda Fabia",
    },
    new Vehicle()
    {
        Model = "Toyota Avensis",
    }
};


var enumerable = list.Where(x => x.Model.ToUpper().Contains("SKODA"));
var lst = list.Where(x => x.Model.ToUpper().Contains("SKODA")).ToList();
*/

DriverService service = new DriverService();

Driver kierowca = new Driver();

kierowca.Name = "Mateusz";
kierowca.Surname = "Nowak";
kierowca.Phone = "123456789";
kierowca.Address = "Słoneczna 38";
kierowca.Email = "jakis.email@gmail.com";

var utworzony = service.Create(kierowca);

    Console.ReadKey();
