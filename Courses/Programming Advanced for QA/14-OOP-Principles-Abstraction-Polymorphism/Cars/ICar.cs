namespace Cars;

public interface ICar
{
    string Model { get; set; }              //Properties

    string Color { get; set; }

    string Start();                           //����� Start

    string Stop();                            //����� Stop
}
