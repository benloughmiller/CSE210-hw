using System;

class Program {
    static void Main(string[] args) {
        List<Shape> _shapes = new List<Shape>();

        Square _square = new Square("Red", 4);
        _shapes.Add(_square);

        Rectangle _rectangle = new Rectangle("Orange", 7, 3);
        _shapes.Add(_rectangle);

        Circle _circle = new Circle("Blue", 5);
        _shapes.Add(_circle);

        foreach (Shape s in _shapes) {
            string _color = s.GetColor();
            double _area = s.GetArea();
            Console.WriteLine($"The {_color} shape has an area of {_area}.");
        }
    } 
}