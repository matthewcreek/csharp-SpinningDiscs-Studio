// TODO: Declare and initialize a CD and a DVD object.

using SpinningDiscs;

Dictionary<string,string> cdData = new();
cdData.Add("name", "Night Verses");
CD cd1 = new(75, 200, 200, 200, "laser", cdData, "16bit, 44.1kHz");

Dictionary<string, string> dvdData = new();
dvdData.Add("name","Hot Rod");

DVD dvd1 = new(4, 570,570,570,"laser",dvdData,"720p");

// TODO: Call each CD and DVD method to verify that they work as expected.

cd1.SpinDisc();
cd1.ReadData();
cd1.WriteData("genre","Djent");
cd1.ReadData();

dvd1.SpinDisc();
dvd1.ReadData();
dvd1.WriteData("genre","comedy");
dvd1.ReadData();
