
public class Blind
{
  public double _width; 
  public double _height;
  public string _color;
}
/// this has three variavke in blind



Blind kitchen = new Blind();
/// this makes a new box for the three vaiables above, called kitchen


kitchen._width = 60;
kitchen._height = 48;
kitchen._color = "white";
/// this is now saying, in the kitchen, we need blinds to be 60 in width, 48 in height, and color white.
/// 

Console.WriteLine(kitchen._width);
// this will then write the kitchen width.





// this is putting method in methods in methods
// now there is a fourth variable in the box, the area
public class Blind
{
    public double _width;
    public double _height;
    public string _color;
    
    public double GetArea()
    {
        return _width * _height;
    }
}

// now materialAmount can get the area of the kitchen
double materialAmount = kitchen.GetArea();



// this is the example of code
Blind kitchen = new Blind();

kitchen._width = 60;
kitchen._height = 48;
kitchen._color = "White";

double materialAmount = kitchen.GetArea();

