using Garage;

Zero fxs = new Zero()
{
    MainColor = "Black",
    MaximumOccupancy = 2,
    BatteryKWh = 150
};
Tesla modelS = new Tesla()
{
    MainColor = "Blue",
    MaximumOccupancy = 4,
    BatteryKWh = 225
};
Cessna mx410 = new Cessna()
{
    MainColor = "Green",
    MaximumOccupancy = 1,
    FuelCapacity = 5.5
};
Ram F150 = new Ram()
{
    MainColor = "Silver",
    MaximumOccupancy = 3,
    FuelCapacity = 22
};

fxs.Drive();
fxs.Turn("right");
fxs.Stop();
modelS.Drive();
modelS.Turn("left");
modelS.Stop();
mx410.Drive();
mx410.Turn("right");
mx410.Stop();
F150.Drive();
F150.Turn("left");
F150.Stop();