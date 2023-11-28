using ABHA_API.ViewModel;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ABHA_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ABHA_M1Controller : ControllerBase
    {
        static HttpClient client = new HttpClient();
        public string Access_Token = "";
        private readonly ABHA_KEY_CONFIGURATIONS _AbhaKeyConfigurations;

        public ABHA_M1Controller(IOptions<ABHA_KEY_CONFIGURATIONS> ABHA_KEY_CONFIGURATIONS)
        {
            _AbhaKeyConfigurations = ABHA_KEY_CONFIGURATIONS.Value;
        }
        private string GenerateToken()
        {
            try
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                       | SecurityProtocolType.Tls11
                       | SecurityProtocolType.Tls12
                       ;
                HttpClient client = new HttpClient();

                client.BaseAddress = new Uri(_AbhaKeyConfigurations.ABHAApiBaseUrl);
                client.DefaultRequestHeaders
                      .Accept
                      .Add(new MediaTypeWithQualityHeaderValue("application/json"));//ACCEPT header



                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "sessions");
                request.Content = new StringContent("{\"clientId\":\"SBX_000203\",\"clientSecret\":\"e400321c-4560-4be8-8f0b-0590e500663c\"}",
                                                    Encoding.UTF8,
                                                    "application/json");//CONTENT-TYPE header


                using (HttpResponseMessage response = client.SendAsync(request).Result)
                {
                    using (HttpContent content = response.Content)
                    {
                        var json = content.ReadAsStringAsync().Result;
                        TokenDetailsDO tokenDetailsDO = JsonConvert.DeserializeObject<TokenDetailsDO>(json);
                        Access_Token = tokenDetailsDO.accessToken;
                    }
                }
            }
            catch (Exception e)
            {

            }
            return Access_Token;
        }
        [HttpGet]
        [Route("[action]")]
        public string GenerateToken2()
        {
            try
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                       | SecurityProtocolType.Tls11
                       | SecurityProtocolType.Tls12
                       ;
                HttpClient client = new HttpClient();

                client.BaseAddress = new Uri(_AbhaKeyConfigurations.ABHAApiBaseUrl);
                client.DefaultRequestHeaders
                      .Accept
                      .Add(new MediaTypeWithQualityHeaderValue("application/json"));//ACCEPT header



                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "sessions");
                request.Content = new StringContent("{\"clientId\":\"SBX_000203\",\"clientSecret\":\"e400321c-4560-4be8-8f0b-0590e500663c\"}",
                                                    Encoding.UTF8,
                                                    "application/json");//CONTENT-TYPE header


                using (HttpResponseMessage response = client.SendAsync(request).Result)
                {
                    using (HttpContent content = response.Content)
                    {
                        var json = content.ReadAsStringAsync().Result;
                        TokenDetailsDO tokenDetailsDO = JsonConvert.DeserializeObject<TokenDetailsDO>(json);
                        Access_Token = tokenDetailsDO.accessToken;
                    }
                }
            }
            catch (Exception e)
            {

            }
            return Access_Token;
        }

        //Registration By Using Aadhaar
        [EnableCors("AllowAllHeaders")]
        [HttpGet]
        [Route("[action]")]
        public string GenerateAadhaarOTP(string AadharNumber)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                   | SecurityProtocolType.Tls11
                   | SecurityProtocolType.Tls12
                   ;
            string bearerToken = GenerateToken();
            client = new HttpClient();
            client.BaseAddress = new Uri(_AbhaKeyConfigurations.abdmABHAHealthApiUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Accept-Language", "en-US");

            var json = "";
         
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "v1/registration/aadhaar/generateOtp");
            request.Content = new StringContent("{\"aadhaar\":\"" + AadharNumber + "\"}", Encoding.UTF8,
                                    "application/json");

            using (HttpResponseMessage response = client.SendAsync(request).Result)
            
            {
                if (response.IsSuccessStatusCode)
                {
                    using (HttpContent content = response.Content)
                    {
                        json = content.ReadAsStringAsync().Result;
                        //TokenDetailsDO tokenDetailsDO = JsonConvert.DeserializeObject<TokenDetailsDO>(json);
                        //txnId = tokenDetailsDO.txnId;
                    }
                }
            }
            return json;
        }

        [HttpGet]
        [Route("[action]")]
        public string VerifyAadhaarOTP(int Otp, string transactionId)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                   | SecurityProtocolType.Tls11
                   | SecurityProtocolType.Tls12
                   ;
            string bearerToken = GenerateToken();
            client = new HttpClient();
            client.BaseAddress = new Uri(_AbhaKeyConfigurations.abdmABHAHealthApiUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //client.DefaultRequestHeaders.Add("X-CM-ID", "sbx");
            client.DefaultRequestHeaders.Add("Accept-Language", "en-US");
            //string restrictions = "restrictions";
            var json = "";
            string txnId = "";

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "v1/registration/aadhaar/verifyOTP");
            //request.Content = new StringContent("{\"otp\":" + Otp + ", \"restrictions\":" + restrictions + ",\"txnId\":\"" + transactionId + "\"}");
            request.Content = new StringContent("{\"otp\":\"" + Otp + "\", \"txnId\":\"" + transactionId + "\"}", Encoding.UTF8,
                                    "application/json");
            using (HttpResponseMessage response = client.SendAsync(request).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    using (HttpContent content = response.Content)
                    {
                        json = content.ReadAsStringAsync().Result;
                        //TokenDetailsDO tokenDetailsDO = JsonConvert.DeserializeObject<TokenDetailsDO>(json);
                        //txnId = tokenDetailsDO.txnId;
                    }
                }
            }
            return json;
        }

        [HttpGet]
        [Route("[action]")]
        public string GenerateAadhaarMobileOTP(string mobileNumber, string transactionId)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                   | SecurityProtocolType.Tls11
                   | SecurityProtocolType.Tls12
                  ;
            string bearerToken = GenerateToken();
            client = new HttpClient();
            client.BaseAddress = new Uri(_AbhaKeyConfigurations.abdmABHAHealthApiUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Accept-Language", "en-US");

            var json = "";
            string txnId = "";

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "v1/registration/aadhaar/generateMobileOTP");
            request.Content = new StringContent("{\"mobile\":\"" + mobileNumber + "\", \"txnId\":\"" + transactionId + "\"}", Encoding.UTF8,
                                   "application/json");

            using (HttpResponseMessage response = client.SendAsync(request).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    using (HttpContent content = response.Content)
                    {
                        json = content.ReadAsStringAsync().Result;
                      //  TokenDetailsDO tokenDetailsDO = JsonConvert.DeserializeObject<TokenDetailsDO>(json);
                       // txnId = tokenDetailsDO.txnId;
                    }
                }
            }
            return json;
        }

        [HttpGet]
        [Route("[action]")]
        public string VerifyAadhaarMobileOTP(string Otp, string transactionId)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                   | SecurityProtocolType.Tls11
                   | SecurityProtocolType.Tls12
                   ;
            string bearerToken = GenerateToken();
            client = new HttpClient();
            client.BaseAddress = new Uri(_AbhaKeyConfigurations.abdmABHAHealthApiUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Accept-Language", "en-US");

            string txnId = "";
            string json = "";

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "v1/registration/aadhaar/verifyMobileOTP");
            request.Content = new StringContent("{\"otp\":\"" + Otp + "\", \"txnId\":\"" + transactionId + "\"}", Encoding.UTF8,
                                     "application/json");
            using (HttpResponseMessage response = client.SendAsync(request).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    using (HttpContent content = response.Content)
                    {
                        json = content.ReadAsStringAsync().Result;
                       // TokenDetailsDO tokenDetailsDO = JsonConvert.DeserializeObject<TokenDetailsDO>(json);
                       // txnId = tokenDetailsDO.txnId;
                    }
                }
            }
            return json;
        }

        [HttpPost]
        [Route("[action]")]
        public GetHealthIdDetailsVo CreateHealthIdUsingAadhaar(HealthCardRegistrationAadharDetailsDO objHealthCard)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                   | SecurityProtocolType.Tls11
                   | SecurityProtocolType.Tls12;
            string bearerToken = GenerateToken();
            client = new HttpClient();
            client.BaseAddress = new Uri(_AbhaKeyConfigurations.abdmABHAHealthApiUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Accept-Language", "en-US");

            HealthCardRegistrationAadharDetailsDO aa = new HealthCardRegistrationAadharDetailsDO();
           aa.email = objHealthCard.email;
         //   aa.firstName = objHealthCard.firstName;
         if(objHealthCard.healthId!="")
            {
                aa.healthId = objHealthCard.healthId;
            }
         
       //     aa.lastName = objHealthCard.lastName;
       //     aa.middleName = objHealthCard.middleName;
         //   aa.password = objHealthCard.password;
            aa.txnId = objHealthCard.txnId;
         //   aa.profilePhoto = ""; //objHealthCard.profilePhoto;
          //  string Health_Id = string.Empty;
            string json = "";
            string re = JsonConvert.SerializeObject(aa);
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "v1/registration/aadhaar/createHealthIdWithPreVerified");

            request.Content = new StringContent(re,
                                 Encoding.UTF8,
                                 "application/json");
            GetHealthIdDetailsVo DataList = new GetHealthIdDetailsVo();

            using (HttpResponseMessage response = client.SendAsync(request).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    using (HttpContent content = response.Content)
                    {
                        json = content.ReadAsStringAsync().Result;
                        DataList = JsonConvert.DeserializeObject<GetHealthIdDetailsVo>(json);
                        return DataList;

                    }

                }
                else return null;
            }
        }
    
        //Registration By Using Aadhaar

        //Registration By Using DrivingLicence
        [HttpGet]
        [Route("[action]")]
        public string GenerateDocumentMobileOTP(string MobileNumber)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                   | SecurityProtocolType.Tls11
                   | SecurityProtocolType.Tls12;
            string bearerToken = GenerateToken();
            client = new HttpClient();
            client.BaseAddress = new Uri(_AbhaKeyConfigurations.abdmABHAHealthApiUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Accept-Language", "en-US");

            string txnId = "";
            var json = "";

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "v2/document/generate/mobile/otp");
            request.Content = new StringContent("{\"mobile\":\"" + MobileNumber + "\"}", Encoding.UTF8,
                                    "application/json");

            using (HttpResponseMessage response = client.SendAsync(request).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    using (HttpContent content = response.Content)
                    {
                        json = content.ReadAsStringAsync().Result;
                        //TokenDetailsDO tokenDetailsDO = JsonConvert.DeserializeObject<TokenDetailsDO>(json);
                        //txnId = tokenDetailsDO.txnId;
                    }
                }
            }
            return json;
        }

        [HttpGet]
        [Route("[action]")]
        public string VerifyDocumentMobileOTP(string OTP, string transactionId)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                   | SecurityProtocolType.Tls11
                   | SecurityProtocolType.Tls12;
            string bearerToken = GenerateToken();
            client = new HttpClient();
            client.BaseAddress = new Uri(_AbhaKeyConfigurations.abdmABHAHealthApiUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Accept-Language", "en-US");

            string token = "";
            var json = "";

            var rsaHelper = new RSAHelper();
            var encryptedtext = rsaHelper.Encrypt(OTP);

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "v2/document/verify/mobile/otp");
            request.Content = new StringContent("{\"otp\":\"" + encryptedtext + "\", \"txnId\":\"" + transactionId + "\"}", Encoding.UTF8,
                                    "application/json");

            using (HttpResponseMessage response = client.SendAsync(request).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    using (HttpContent content = response.Content)
                    {
                        json = content.ReadAsStringAsync().Result;
                        TokenDetailsDO tokenDetailsDO = JsonConvert.DeserializeObject<TokenDetailsDO>(json);
                        token = tokenDetailsDO.token;
                    }
                }
            }
            return token;
        }

        [HttpPost]
        [Route("[action]")]
        public JsonResult ValidateDocument(HealthCardRegistrationDocumentDetailsDO objHealthCard)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                   | SecurityProtocolType.Tls11
                   | SecurityProtocolType.Tls12;
            string bearerToken = GenerateToken();
            client = new HttpClient();
            client.BaseAddress = new Uri(_AbhaKeyConfigurations.abdmABHAHealthApiUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Accept-Language", "en-US");

            HealthCardRegistrationDocumentDetailsDO aa = new HealthCardRegistrationDocumentDetailsDO();
            aa.dayOfBirth = objHealthCard.dayOfBirth;
            aa.firstName = objHealthCard.firstName;
            aa.documentNumber = objHealthCard.documentNumber;
            aa.lastName = objHealthCard.lastName;
            aa.documentType = ""; // objHealthCard.documentType;
            aa.middleName = objHealthCard.middleName;
            aa.monthOfBirth = objHealthCard.monthOfBirth;
            aa.yearOfBirth = objHealthCard.yearOfBirth;
            aa.gender = objHealthCard.gender;

            var json = "";
            string re = JsonConvert.SerializeObject(aa);

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "v2/document/validate");

            request.Content = new StringContent(re,
                                  Encoding.UTF8,
                                  "application/json");
            using (HttpResponseMessage response = client.SendAsync(request).Result)
            {
                using (HttpContent content = response.Content)
                {
                    json = content.ReadAsStringAsync().Result;

                }

                JsonResult result = new JsonResult(JsonConvert.DeserializeObject(json));
                return result;
            }
        }

        [HttpGet]
        [Route("[action]")]
        public JsonResult CraeteHealthIdWithDocument(string Token, HealthCardRegistrationDocumentDetailsDO objHealthCard)
        {
            //string Address = "SHANTI PARA,CHHOTEKAPSI,PAKHANJUR,KANKER,CG,494771";
            //string DayOfBirth = "06";
            //int DistrictCode = 381;
            //string DocumentNumber = "CG1920200003864";
            //string DocumentType = "DRIVING_LICENCE";
            //string FirstName = "Bishwaranjan";
            //string Gender = "M";
            //string LastName = "Raha";
            //string middleName = "";
            //long MobileNumber = 7587032003;
            //string monthOfBirth = "04";
            //string Photo = "";
            //string PhotoBack = "";
            //int StateCode = 22;
            //int yearOfBirth = 1997;
            //string transactionid = "0dfa7ba5-1199-4159-ba6e-7d0d1c537682";
            //string Token = "eyJhbGciOiJSUzUxMiJ9.eyJzdWIiOiI3NTg3MDMyMDAzIiwiY2xpZW50SWQiOiJTQlhfMDAwMjAzIiwiZXhwIjoxNjQwMDcyODY4LCJpYXQiOjE2NDAwNzEwNjgsInR4bklkIjoiMGRmYTdiYTUtMTE5OS00MTU5LWJhNmUtN2QwZDFjNTM3NjgyIn0.BCCp1l6VT8OyvDoNEMj-Wf80J7yIhJB2ZRYQamQKRRDCe6m0rgHPDyaRxIj9_tsfbA0lp-VycO8XUDkt0G3VAwzHGe5K2jmiy4OLfxHlolQTgWixOHdumO5qxx7xEzgNmrSAFH-H-ei8_0vakB4V7RyN-szFBwysWn6pZV1nsz5tiUEdrVJ0cewQAD8RA5L1hCcJ5HzjviX_ZqVaApj8si2art4Zbycdg4cx_WQAXOmqi3WzATLrsIYEYtC9YnXlk0La_O8pprIFGwoLbIT9u5aE3hJTKYkvYiMVlYIpo58jon4UY7rSRn_ZVTkzlK6sYeCBK7vp1xnp8C8AWByNctMRgxzSgjRkl7xzEXacAZYwVqqhM0xMNI7YPPfWewz8CLGSVLsOJpmzpsQgVxzMgJCqBvhy5y2lppQjJP4vrc84HHay20uZCnqZuHsqYVn050kCg94V5RDPU-5l4QzjXTATWnWESY3wtMc2FKB-pWQtyJs9_hJXlZKsBvwDCbBV9tvpDenp8VkF4eX7haWC2zjOeEolP6TgQMNv5bbi8kpCQjqOJp2Q6chpTj-3T97EfTgaQhRQNhs0sGZlVuVoG_AxAG8Q2JF0ESBp7OfeBVhn-CJfyl4411Ui2xFLjEvEqjMWUO3oh09aFjAM6PHOC_lZyZ4cPOsSMEl3SRKxrGk";

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                   | SecurityProtocolType.Tls11
                   | SecurityProtocolType.Tls12;
            string bearerToken = GenerateToken();
            client = new HttpClient();
            client.BaseAddress = new Uri(_AbhaKeyConfigurations.abdmABHAHealthApiUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Accept-Language", "en-US");
            client.DefaultRequestHeaders.Add("T-Token", Token);
            HealthCardRegistrationDocumentDetailsDO aa = new HealthCardRegistrationDocumentDetailsDO();
            aa.documentNumber = objHealthCard.documentNumber;
            aa.documentType = objHealthCard.documentType;
            aa.firstName = objHealthCard.firstName;
            aa.middleName = objHealthCard.middleName;
            aa.lastName = objHealthCard.lastName;
            aa.gender = objHealthCard.gender;
            aa.monthOfBirth = objHealthCard.monthOfBirth;
            aa.yearOfBirth = objHealthCard.yearOfBirth;

            var json = "";
            string re = JsonConvert.SerializeObject(aa);
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "v2/document");
            //request.Content = new StringContent("{\"address\":\"" + Address + "\", \"dayOfBirth\":\"" + DayOfBirth + "\", \"districtCode\":\"" + DistrictCode + "\", \"documentNumber\":\"" + DocumentNumber + "\", \"documentType\":\"" + DocumentType + "\", \"firstName\":\"" + FirstName + "\", \"gender\":\"" + Gender + "\", \"lastName\":\"" + LastName + "\", \"middleName\":\"" + middleName + "\", \"mobile\":\"" + MobileNumber + "\", \"monthOfBirth\":\"" + monthOfBirth + "\",  \"photo\":\"" + Photo + "\", \"photoBack\":\"" + PhotoBack + "\", \"stateCode\":\"" + StateCode + "\", \"txnId\":\"" + transactionid + "\", \"yearOfBirth\":\"" + yearOfBirth + "\"}", Encoding.UTF8,
            //                        "application/json");
            request.Content = new StringContent(re,
                                  Encoding.UTF8,
                                  "application/json");

            using (HttpResponseMessage response = client.SendAsync(request).Result)
            {
                using (HttpContent content = response.Content)
                {
                    json = content.ReadAsStringAsync().Result;
                }

                JsonResult result = new JsonResult(JsonConvert.DeserializeObject(json));
                return result;
            }
        }

        [HttpGet]
        [Route("[action]")]
        public JsonResult GetProfile(string Token)
        {
          
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                   | SecurityProtocolType.Tls11
                   | SecurityProtocolType.Tls12;
            string bearerToken = GenerateToken();
            client = new HttpClient();
            client.BaseAddress = new Uri(_AbhaKeyConfigurations.abdmABHAHealthApiUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Accept-Language", "en-US");
            client.DefaultRequestHeaders.Add("T-Token", Token);
           

            var json = "";
          //  string re = JsonConvert.SerializeObject(aa);
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "v2/document");
            request.Content = new StringContent("{\"X-Token\":\"" + Token + "\"}", Encoding.UTF8,
                                    "application/json");
           

            using (HttpResponseMessage response = client.SendAsync(request).Result)
            {
                using (HttpContent content = response.Content)
                {
                    json = content.ReadAsStringAsync().Result;
                }

                JsonResult result = new JsonResult(JsonConvert.DeserializeObject(json));
                return result;
            }
        }


        //Madhu Start 
        //Madhu end

        //Naveen start
        //Naveen end
    }
}
