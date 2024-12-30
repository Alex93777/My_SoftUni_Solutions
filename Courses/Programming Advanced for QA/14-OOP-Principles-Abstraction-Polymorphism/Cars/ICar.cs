namespace Cars;

public interface ICar
{
    string Model { get; set; }              //Properties

    string Color { get; set; }

    string Start();                           //Метод Start

    string Stop();                            //Метод Stop
}
