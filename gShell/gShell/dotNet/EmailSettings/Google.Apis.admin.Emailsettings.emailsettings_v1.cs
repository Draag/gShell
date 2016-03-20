// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by google-apis-code-generator 1.5.1
//     C# generator version: 1.10.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

/**
 * \mainpage
 *   Admin Email Settings API Version emailsettings_v1
 *
 * \section ApiInfo API Version Information
 *    <table>
 *      <tr><th>API
 *          <td><a href='https://developers.google.com/admin-sdk/reports/'>Admin Email Settings API</a>
 *      <tr><th>API Version<td>emailsettings_v1
 *      <tr><th>API Rev<td>0
 *      <tr><th>API Docs
 *          <td><a href='https://developers.google.com/admin-sdk/reports/'>
 *              https://developers.google.com/admin-sdk/reports/</a>
 *      <tr><th>Discovery Name<td>admin
 *    </table>
 *
 * \section ForMoreInfo For More Information
 *
 * The complete API documentation for using Admin Email Settings API can be found at
 * <a href='https://developers.google.com/admin-sdk/reports/'>https://developers.google.com/admin-sdk/reports/</a>.
 *
 * For more information about the Google APIs Client Library for .NET, see
 * <a href='https://developers.google.com/api-client-library/dotnet/get_started'>
 * https://developers.google.com/api-client-library/dotnet/get_started</a>
 */

namespace Google.Apis.admin.Emailsettings.emailsettings_v1.Data
{    

    /// <summary>IDGAF</summary>
    public class Label : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        [System.Xml.Serialization.XmlElement("label")]
        public virtual string LabelValue { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("labelId")]
        public virtual string LabelId { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("unreadCount")]
        public virtual System.Nullable<long> UnreadCount { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("visibility")]
        public virtual string Visibility { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class Labels : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<Label> LabelsValue { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}

namespace Google.Apis.admin.Emailsettings.emailsettings_v1
{
    /// <summary>The Emailsettings Service.</summary>
    public class EmailsettingsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "emailsettings_v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public EmailsettingsService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public EmailsettingsService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            labels = new LabelsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features
        {
            get { return new string[0]; }
        }

        /// <summary>Gets the service name.</summary>
        public override string Name
        {
            get { return "admin"; }
        }

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri
        {
            get { return "https://apps-apis.google.com//a/feeds/emailsettings/2.0/"; }
        }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath
        {
            get { return "/a/feeds/emailsettings/2.0/"; }
        }

        /// <summary>Available OAuth 2.0 scopes for use with the Admin Email Settings API.</summary>
        public class Scope
        {
            /// <summary>Global scope for access to all email settings</summary>
            public static string AppsApisGoogleComAFeedsEmailsettings20 = "https://apps-apis.google.com/a/feeds/emailsettings/2.0/";

        }



        private readonly LabelsResource labels;

        /// <summary>Gets the Labels resource.</summary>
        public virtual LabelsResource Labels
        {
            get { return labels; }
        }
    }

    ///<summary>A base abstract class for Emailsettings requests.</summary>
    public abstract class EmailsettingsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new EmailsettingsBaseServiceRequest instance.</summary>
        protected EmailsettingsBaseServiceRequest(Google.Apis.Services.IClientService service)
            : base(service)
        {
        }

        /// <summary>Data format for the response.</summary>
        /// [default: xml]
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for the response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/xml</summary>
            [Google.Apis.Util.StringValueAttribute("xml")]
            Xml,
        }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        /// [default: true]
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string
        /// assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>IP address of the site where the request originates. Use this if you want to enforce per-user
        /// limits.</summary>
        [Google.Apis.Util.RequestParameterAttribute("userIp", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UserIp { get; set; }

        /// <summary>Initializes Emailsettings parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add(
                "alt", new Google.Apis.Discovery.Parameter
                {
                    Name = "alt",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "xml",
                    Pattern = null,
                });
            RequestParameters.Add(
                "fields", new Google.Apis.Discovery.Parameter
                {
                    Name = "fields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "key", new Google.Apis.Discovery.Parameter
                {
                    Name = "key",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "oauth_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "oauth_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "prettyPrint", new Google.Apis.Discovery.Parameter
                {
                    Name = "prettyPrint",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
            RequestParameters.Add(
                "quotaUser", new Google.Apis.Discovery.Parameter
                {
                    Name = "quotaUser",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "userIp", new Google.Apis.Discovery.Parameter
                {
                    Name = "userIp",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
        }
    }

    /// <summary>The "labels" collection of methods.</summary>
    public class LabelsResource
    {
        private const string Resource = "labels";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public LabelsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }



        /// <param name="domain"></param>
        /// <param name="labelName"></param>
        /// <param name="userKey"></param>
        public virtual DeleteRequest Delete(string domain, string labelName, string userKey)
        {
            return new DeleteRequest(service, domain, labelName, userKey);
        }


        public class DeleteRequest : EmailsettingsBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string domain, string labelName, string userKey)
                : base(service)
            {
                Domain = domain;
                LabelName = labelName;
                UserKey = userKey;
                InitParameters();
            }



            [Google.Apis.Util.RequestParameterAttribute("domain", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Domain { get; private set; }


            [Google.Apis.Util.RequestParameterAttribute("labelName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string LabelName { get; private set; }


            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserKey { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "delete"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "DELETE"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "{domain}/{userKey}/label/{labelName}"; }
            }

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "domain", new Google.Apis.Discovery.Parameter
                    {
                        Name = "domain",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "labelName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "labelName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "userKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }


        /// <param name="domain"></param>
        /// <param name="userKey"></param>
        public virtual GetRequest Get(string domain, string userKey)
        {
            return new GetRequest(service, domain, userKey);
        }


        public class GetRequest : EmailsettingsBaseServiceRequest<Google.Apis.admin.Emailsettings.emailsettings_v1.Data.Labels>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string domain, string userKey)
                : base(service)
            {
                Domain = domain;
                UserKey = userKey;
                InitParameters();
            }



            [Google.Apis.Util.RequestParameterAttribute("domain", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Domain { get; private set; }


            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserKey { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "get"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "GET"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "{domain}/{userKey}/label"; }
            }

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "domain", new Google.Apis.Discovery.Parameter
                    {
                        Name = "domain",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "userKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }


        /// <param name="domain"></param>
        /// <param name="userKey"></param>
        public virtual InsertRequest Insert(string domain, string userKey)
        {
            return new InsertRequest(service, domain, userKey);
        }


        public class InsertRequest : EmailsettingsBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, string domain, string userKey)
                : base(service)
            {
                Domain = domain;
                UserKey = userKey;
                InitParameters();
            }



            [Google.Apis.Util.RequestParameterAttribute("domain", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Domain { get; private set; }


            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserKey { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "insert"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "POST"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "{domain}/{userKey}/label"; }
            }

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "domain", new Google.Apis.Discovery.Parameter
                    {
                        Name = "domain",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "userKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }
}