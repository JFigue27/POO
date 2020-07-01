from car import Car

if __name__ == "__main__":
    print("Hola Mundo!!")

    car = Car()
    car.license = "JJFIGUE123"
    car.driver = "Jose Jaime"
    print(vars(car))

    car2 = Car()
    car2.license = "JJFIG"
    car2.driver = "Jaime Abraham"
    print(vars(car2))
