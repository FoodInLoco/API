using Newtonsoft.Json;

namespace FoodInLoco.Application.Data.Entities.Interfaces
{
    public interface IEntity
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
