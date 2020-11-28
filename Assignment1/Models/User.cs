using System.Text.Json.Serialization;

namespace Models
{
    public class User 
    {
        [JsonPropertyName("userName")]
        public string UserName { get; set; }
        
        [JsonPropertyName("domain")]
        public string Domain { get; set; }
        
        [JsonPropertyName("city")]
        public string City { get; set; }
        
        [JsonPropertyName("birthYear")]
        public int BirthYear { get; set; }
        
        [JsonPropertyName("role")]
        public string Role { get; set; }
        
        [JsonPropertyName("securityLevel")]
        public int SecurityLevel { get; set; }
        
        [JsonPropertyName("password")]
        public string Password { get; set; }


        public override string ToString() {
            return UserName + "//" + Domain + "//" + City + "//" + BirthYear + "//" + Role + "//" + SecurityLevel + "//" + Password;
        }
    }
}