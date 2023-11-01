using HerancaVSContrato.Model.Enums;
namespace HerancaVSContrato.Model.Entities;


abstract public class AbstractShape : IShape
{
    public Color Color { get; set; }


    public abstract double Area();
}