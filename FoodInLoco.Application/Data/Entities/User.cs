using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace FoodInLoco.Application.Data.Entities;

public class User
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("email")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }

    [JsonProperty("password")]
    [StringLength(100, MinimumLength = 8)]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("phone_number")]
    public string PhoneNumber { get; set; }
}