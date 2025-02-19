/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Autopilot
 * This is the public Twilio REST API.
 *
 * NOTE: This class is auto generated by OpenAPI Generator.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;



namespace Twilio.Rest.Autopilot.V1.Assistant
{
    public class DefaultsResource : Resource
    {
    

        
        private static Request BuildFetchRequest(FetchDefaultsOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Assistants/{AssistantSid}/Defaults";

            string PathAssistantSid = options.PathAssistantSid;
            path = path.Replace("{"+"AssistantSid"+"}", PathAssistantSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Autopilot,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Defaults parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Defaults </returns>
        public static DefaultsResource Fetch(FetchDefaultsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Defaults parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Defaults </returns>
        public static async System.Threading.Tasks.Task<DefaultsResource> FetchAsync(FetchDefaultsOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> fetch </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Defaults </returns>
        public static DefaultsResource Fetch(
                                         string pathAssistantSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchDefaultsOptions(pathAssistantSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Defaults </returns>
        public static async System.Threading.Tasks.Task<DefaultsResource> FetchAsync(string pathAssistantSid, ITwilioRestClient client = null)
        {
            var options = new FetchDefaultsOptions(pathAssistantSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildUpdateRequest(UpdateDefaultsOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Assistants/{AssistantSid}/Defaults";

            string PathAssistantSid = options.PathAssistantSid;
            path = path.Replace("{"+"AssistantSid"+"}", PathAssistantSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Autopilot,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> update </summary>
        /// <param name="options"> Update Defaults parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Defaults </returns>
        public static DefaultsResource Update(UpdateDefaultsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> update </summary>
        /// <param name="options"> Update Defaults parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Defaults </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<DefaultsResource> UpdateAsync(UpdateDefaultsOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> update </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the resource to update. </param>
        /// <param name="defaults"> A JSON string that describes the default task links for the `assistant_initiation`, `collect`, and `fallback` situations. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Defaults </returns>
        public static DefaultsResource Update(
                                          string pathAssistantSid,
                                          object defaults = null,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateDefaultsOptions(pathAssistantSid){ Defaults = defaults };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> update </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the resource to update. </param>
        /// <param name="defaults"> A JSON string that describes the default task links for the `assistant_initiation`, `collect`, and `fallback` situations. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Defaults </returns>
        public static async System.Threading.Tasks.Task<DefaultsResource> UpdateAsync(
                                                                              string pathAssistantSid,
                                                                              object defaults = null,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateDefaultsOptions(pathAssistantSid){ Defaults = defaults };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a DefaultsResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> DefaultsResource object represented by the provided JSON </returns>
        public static DefaultsResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<DefaultsResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Defaults resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the resource. </summary> 
        [JsonProperty("assistant_sid")]
        public string AssistantSid { get; private set; }

        ///<summary> The absolute URL of the Defaults resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The JSON string that describes the default task links for the `assistant_initiation`, `collect`, and `fallback` situations. </summary> 
        [JsonProperty("data")]
        public object Data { get; private set; }



        private DefaultsResource() {

        }
    }
}

