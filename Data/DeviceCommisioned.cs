namespace BlazorReflection.Data
{
    public class DeviceProvisioned : IMessage
    {
        public string Id { get; set; } = "Hello";

        public string Source { get; set; }

        public string SourceId { get; set; }
    }
}