namespace BlazorReflection.Data
{
    public class Product : IMessage
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public bool IsAvailable { get; set; }

        public bool? HasSubscription { get; set; }
    }
}