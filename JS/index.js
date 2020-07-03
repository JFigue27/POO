const car = new Car('Honda Accord', new Account('Jaime Figueroa', 'JJFIGUE321321'));

car.passenger = 4;
car.printDataCar();

var uberX = new UberX('JJFW456', new Account('Sara Figueroa', 'LICENCIASARA020115'), 'Honda', 'Accord');
uberX.passenger = 5;
uberX.printDataCar();

var driver = new Driver('Juan el chofis', 'UBER-LICENSE-0002154');
driver.printAccount();

var user = new User('Jose Jaime el User', 'IFE-6546546546354');
user.printAccount();
