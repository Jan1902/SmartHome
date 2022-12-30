namespace SmartHome.Domain.Models;

public record class Device
{
    public int ID { get; init; }
    public DeviceType Type { get; init; }
    public IEnumerable<Trait> Traits { get; init; }
    public string Name { get; set; }
    public bool WillReportState { get; set; }
    public DeviceInfo DeviceInformation { get; set; }

    public Device()
        => Traits = new List<Trait>();
}

public record struct DeviceInfo
{
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public string HardwareVersion { get; set; }
    public string SoftwareVersion { get; set; }
}

public enum DeviceType
{
    Outlet
}

public enum Trait
{
    OnOff
}
