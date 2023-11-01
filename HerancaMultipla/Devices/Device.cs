namespace HerancaMultipla.Devices;

abstract public class Device
{
    public int SerialNumber { get; set; }

    public abstract void ProcessDoc(string document);

}