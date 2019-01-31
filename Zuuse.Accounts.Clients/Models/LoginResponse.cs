// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Zuuse.Accounts.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LoginResponse
    {
        /// <summary>
        /// Initializes a new instance of the LoginResponse class.
        /// </summary>
        public LoginResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LoginResponse class.
        /// </summary>
        public LoginResponse(string userId = default(string), string token = default(string), string clientProjectId = default(string), string clientShortName = default(string), int? clientId = default(int?), int? projectId = default(int?), long? loginId = default(long?), string name = default(string), string email = default(string), string phone = default(string), string externalAccountId = default(string), string accountId = default(string), System.Guid? filterGuid = default(System.Guid?), string ewsApiLocation = default(string))
        {
            UserId = userId;
            Token = token;
            ClientProjectId = clientProjectId;
            ClientShortName = clientShortName;
            ClientId = clientId;
            ProjectId = projectId;
            LoginId = loginId;
            Name = name;
            Email = email;
            Phone = phone;
            ExternalAccountId = externalAccountId;
            AccountId = accountId;
            FilterGuid = filterGuid;
            EwsApiLocation = ewsApiLocation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserId")]
        public string UserId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Token")]
        public string Token { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ClientProjectId")]
        public string ClientProjectId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ClientShortName")]
        public string ClientShortName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ClientId")]
        public int? ClientId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProjectId")]
        public int? ProjectId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LoginId")]
        public long? LoginId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Email")]
        public string Email { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Phone")]
        public string Phone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ExternalAccountId")]
        public string ExternalAccountId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AccountId")]
        public string AccountId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FilterGuid")]
        public System.Guid? FilterGuid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EwsApiLocation")]
        public string EwsApiLocation { get; set; }

    }
}
