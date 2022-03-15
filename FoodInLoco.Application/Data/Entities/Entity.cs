using FoodInLoco.Application.Data.Entities.Interfaces;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace FoodInLoco.Application.Data.Entities;

public class Entity : IEntity
{
    [JsonProperty("id")]
    public int Id { get; set; }
}