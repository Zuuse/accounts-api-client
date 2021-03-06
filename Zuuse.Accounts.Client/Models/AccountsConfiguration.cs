// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Zuuse.Accounts.Client.Models
{
    /// <summary> The AccountsConfiguration. </summary>
    public partial class AccountsConfiguration
    {
        /// <summary> Initializes a new instance of AccountsConfiguration. </summary>
        public AccountsConfiguration()
        {
        }

        /// <summary> Initializes a new instance of AccountsConfiguration. </summary>
        /// <param name="client"> . </param>
        /// <param name="passwordStrengthType"> . </param>
        /// <param name="bitsEntropy"> . </param>
        /// <param name="tokenExpiration"> . </param>
        /// <param name="requiresLowercase"> . </param>
        /// <param name="requiresUppercase"> . </param>
        /// <param name="requiresDigits"> . </param>
        /// <param name="requiresSymbols"> . </param>
        /// <param name="requiresPasswordHistory"> . </param>
        /// <param name="requiresMaximumPasswordAge"> . </param>
        /// <param name="requiresMinimumPasswordLength"> . </param>
        /// <param name="passwordHistory"> . </param>
        /// <param name="maximumPasswordAge"> . </param>
        /// <param name="minimumPasswordLength"> . </param>
        internal AccountsConfiguration(string client, AccountsConfigurationPasswordStrengthType? passwordStrengthType, int? bitsEntropy, int? tokenExpiration, bool? requiresLowercase, bool? requiresUppercase, bool? requiresDigits, bool? requiresSymbols, bool? requiresPasswordHistory, bool? requiresMaximumPasswordAge, bool? requiresMinimumPasswordLength, int? passwordHistory, int? maximumPasswordAge, int? minimumPasswordLength)
        {
            Client = client;
            PasswordStrengthType = passwordStrengthType;
            BitsEntropy = bitsEntropy;
            TokenExpiration = tokenExpiration;
            RequiresLowercase = requiresLowercase;
            RequiresUppercase = requiresUppercase;
            RequiresDigits = requiresDigits;
            RequiresSymbols = requiresSymbols;
            RequiresPasswordHistory = requiresPasswordHistory;
            RequiresMaximumPasswordAge = requiresMaximumPasswordAge;
            RequiresMinimumPasswordLength = requiresMinimumPasswordLength;
            PasswordHistory = passwordHistory;
            MaximumPasswordAge = maximumPasswordAge;
            MinimumPasswordLength = minimumPasswordLength;
        }

        public string Client { get; set; }
        public AccountsConfigurationPasswordStrengthType? PasswordStrengthType { get; set; }
        public int? BitsEntropy { get; set; }
        public int? TokenExpiration { get; set; }
        public bool? RequiresLowercase { get; set; }
        public bool? RequiresUppercase { get; set; }
        public bool? RequiresDigits { get; set; }
        public bool? RequiresSymbols { get; set; }
        public bool? RequiresPasswordHistory { get; set; }
        public bool? RequiresMaximumPasswordAge { get; set; }
        public bool? RequiresMinimumPasswordLength { get; set; }
        public int? PasswordHistory { get; set; }
        public int? MaximumPasswordAge { get; set; }
        public int? MinimumPasswordLength { get; set; }
    }
}
