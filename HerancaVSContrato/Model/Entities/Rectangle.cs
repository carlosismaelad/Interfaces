using HerancaVSContrato.Model.Enums;
using System.Globalization;
using HerancaVSContrato.Model.Enums;

namespace HerancaVSContrato.Model.Entities;

public class Rectangle : AbstractShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double Area()
    {
        return Height * Width;
    }

    public override string ToString()
    {
        return "Rectangle color: "
               + Color
               + ", width: "
               + Width.ToString("F2", CultureInfo.InvariantCulture)
               + ", height: "
               + Height.ToString("F2", CultureInfo.InvariantCulture)
               + ", area: "
               + Area().ToString("F2", CultureInfo.InvariantCulture);
    }
}