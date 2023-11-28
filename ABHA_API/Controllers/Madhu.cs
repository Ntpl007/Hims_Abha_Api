using ABHA_API.ViewModel;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Aspose.Cells.Utility;

using Aspose.Cells;
using ABHA_API.ABHA_Context;
using System.IO;
using System.Text;
using Aspose.Words.Reporting;
namespace ABHA_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class M1_2 : ControllerBase
    {

        static HttpClient client = new HttpClient();
        public string Access_Token = "";
        private readonly ABHA_KEY_CONFIGURATIONS _AbhaKeyConfigurations;

        public M1_2(IOptions<ABHA_KEY_CONFIGURATIONS> ABHA_KEY_CONFIGURATIONS)
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

        //------------Login With authentication certificate
        [HttpGet]
        [Route("[action]")]
        public string GetAuthCertificate()
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

          
            var json = "";
          //  string value = "";

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "v1/auth/cert");
           
            using (HttpResponseMessage response = client.SendAsync(request).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    using (HttpContent content = response.Content)
                    {
                        json = content.ReadAsStringAsync().Result;
                     
                     //   value =  JsonConvert.DeserializeObject<string>(json);
                     
                    }
                }
            }
            return json;
        }

        //------------Login With searchby healthid certificate
        [HttpGet]
        [Route("[action]")]
        public SearchbyHealthidVo LoginSearchByHealthID(string healthID)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                   | SecurityProtocolType.Tls11
                   | SecurityProtocolType.Tls12
                   ;
            string bearerToken = GenerateToken();
            client = new HttpClient();
            client.BaseAddress =new Uri(_AbhaKeyConfigurations.abdmABHAHealthApiUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Accept-Language", "en-US");

            var json = "";
            //  string txnId = "";

           
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "v1/search/searchByHealthId");
            request.Content = new StringContent("{\"healthId\":\"" + healthID + "\"}", Encoding.UTF8,
                                    "application/json");
            SearchbyHealthidVo obj = new SearchbyHealthidVo();
            using (HttpResponseMessage response = client.SendAsync(request).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    using (HttpContent content = response.Content)
                    {
                        json = content.ReadAsStringAsync().Result;
                         obj = JsonConvert.DeserializeObject<SearchbyHealthidVo>(json);
                       
                        
                    }
                }
                else { return null; }
            }
            return obj;
        }

        //------------Login With searchby mobile certificate
        [HttpGet]
        [Route("[action]")]
        public SearchByMobileResponseVo LoginSearchByMobile(SearchByMobileRequestVo objInput)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                   | SecurityProtocolType.Tls11
                   | SecurityProtocolType.Tls12
                   ;
            string bearerToken = GenerateToken();
            client = new HttpClient();
            client.BaseAddress =new Uri(_AbhaKeyConfigurations.abdmABHAHealthApiUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Accept-Language", "en-US");

            var json = "";
            //  string txnId = "";

            SearchByMobileRequestVo objvo = new SearchByMobileRequestVo();
            objvo.gender = objInput.gender;
            objvo.mobile = objInput.mobile;
            objvo.name = objInput.name;
            objvo.yearOfBirth = objInput.yearOfBirth;
            string inputParam = JsonConvert.SerializeObject(objvo);
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "v1/search/searchByMobile");
            request.Content = new StringContent(inputParam, Encoding.UTF8,
                                    "application/json");
            SearchByMobileResponseVo obj = new SearchByMobileResponseVo();
            using (HttpResponseMessage response = client.SendAsync(request).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    using (HttpContent content = response.Content)
                    {
                        json = content.ReadAsStringAsync().Result;
                        obj = JsonConvert.DeserializeObject<SearchByMobileResponseVo>(json);


                    }
                }
            }
            return obj;
        }

        //------------Login With authentication initiat
        [HttpGet]
        [Route("[action]")]
        public string LoginAuthInitiate(string healthid, string AuthMethod)
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

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "v1/auth/init");
            request.Content = new StringContent("{\"authMethod\":\"" + AuthMethod + "\", \"healthid\":\"" + healthid + "\"}", Encoding.UTF8,
                                     "application/json");
            using (HttpResponseMessage response = client.SendAsync(request).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    using (HttpContent content = response.Content)
                    {
                        json = content.ReadAsStringAsync().Result;
                     //   string tokenDetailsDO = JsonConvert.DeserializeObject<string>(json);
                       // txnId = js;
                    }
                }
            }
            return json;
        }

        //------------Login With confirm Adhaar OTP
        [HttpGet]
        [Route("[action]")]
        public LoginConfirmAdhaarOtpResponse LoginConfirmWithAdhaarOTP(string Otp, string txnId)
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

            string json = "";
            LoginConfirmAdhaarOtpResponse obj = new LoginConfirmAdhaarOtpResponse();
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "v1/auth/confirmWithAadhaarOtp");
            request.Content = new StringContent("{\"otp\":\"" + Otp + "\", \"txnId\":\"" + txnId + "\"}", Encoding.UTF8,
                                     "application/json");
            using (HttpResponseMessage response = client.SendAsync(request).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    using (HttpContent content = response.Content)
                    {
                        json = content.ReadAsStringAsync().Result;
                        obj = JsonConvert.DeserializeObject<LoginConfirmAdhaarOtpResponse>(json);
                    }
                }
            }
            return obj;
        }


        //------------Login With confirm Mobile OTP
        [HttpGet]
        [Route("[action]")]
        public LoginConfirmAdhaarOtpResponse LoginConfirmWithMobileOTP(string Otp, string txnId)
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

            string json = "";
            LoginConfirmAdhaarOtpResponse obj = new LoginConfirmAdhaarOtpResponse();
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "v1/auth/confirmWithMobileOTP");
            request.Content = new StringContent("{\"otp\":\"" + Otp + "\", \"txnId\":\"" + txnId + "\"}", Encoding.UTF8,
                                     "application/json");
            using (HttpResponseMessage response = client.SendAsync(request).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    using (HttpContent content = response.Content)
                    {
                        json = content.ReadAsStringAsync().Result;
                        obj = JsonConvert.DeserializeObject<LoginConfirmAdhaarOtpResponse>(json);
                    }
                }
            }
            return obj;
        }


        //------------Login With PASSWORD 
        [HttpGet]
        [Route("[action]")]
        public LoginConfirmAdhaarOtpResponse LoginWithPwd(string healthIdNumber, string password)
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

            string json = "";
            LoginConfirmAdhaarOtpResponse obj = new LoginConfirmAdhaarOtpResponse();
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "v1/auth/authPassword");
            request.Content = new StringContent("{\"healthIdNumber\":\"" + healthIdNumber + "\", \"password\":\"" + password + "\"}", Encoding.UTF8,
                                     "application/json");
            using (HttpResponseMessage response = client.SendAsync(request).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    using (HttpContent content = response.Content)
                    {
                        json = content.ReadAsStringAsync().Result;
                        obj = JsonConvert.DeserializeObject<LoginConfirmAdhaarOtpResponse>(json);
                    }
                }
            }
            return obj;
        }

        //------------generate otp for forgotten AbhaNo
        [HttpGet]
        [Route("[action]")]
        public ForgottenAbhaResponse GenerateAdhaarOtpForForgotABHANo(string adhaarNo)
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


            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "v1/forgot/healthId/aadhaar/generateOtp");
            request.Content = new StringContent("{\"aadhaar\":\"" + adhaarNo + "\"}", Encoding.UTF8,
                                    "application/json");
            ForgottenAbhaResponse obj = new ForgottenAbhaResponse();
            using (HttpResponseMessage response = client.SendAsync(request).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    using (HttpContent content = response.Content)
                    {
                        json = content.ReadAsStringAsync().Result;
                        obj = JsonConvert.DeserializeObject<ForgottenAbhaResponse>(json);
                      

                    }
                }
            }
            return obj;
        }

        //------------GetForgottenABHA no by adhaar otp
        [HttpGet]
        [Route("[action]")]
        public GetABHANoVo GetAbhaNoByAdhaarOtp(string otp, string txnId)
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

            string json = "";
            GetABHANoVo obj = new GetABHANoVo(); 

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/v1/forgot/healthId/aadhaar");
            request.Content = new StringContent("{\"otp\":\"" + otp + "\", \"txnId\":\"" + txnId + "\"}", Encoding.UTF8,
                                     "application/json");
            using (HttpResponseMessage response = client.SendAsync(request).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    using (HttpContent content = response.Content)
                    {
                        json = content.ReadAsStringAsync().Result;
                        obj = JsonConvert.DeserializeObject<GetABHANoVo>(json);
                        return obj;
                    }
                }
                else
                {
                    return null;
                }
            }
          //  return null;
        }

        //------------generate otp for forgotten AbhaNo
        [HttpGet]
        [Route("[action]")]
        public ForgottenAbhaResponse GenerateMobileOtpForForgotABHANo(string mobileNo)
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


            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "v1/forgot/healthId/mobile/generateOtp");
            request.Content = new StringContent("{\"mobile\":\"" + mobileNo + "\"}", Encoding.UTF8,
                                    "application/json");
            ForgottenAbhaResponse obj = new ForgottenAbhaResponse();
            using (HttpResponseMessage response = client.SendAsync(request).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    using (HttpContent content = response.Content)
                    {
                        json = content.ReadAsStringAsync().Result;
                        obj = JsonConvert.DeserializeObject<ForgottenAbhaResponse>(json);
                      //  txnId = obj.txnId;

                    }
                }
            }
            return obj;
        }
        [HttpPost]
        [Route("[action]")]
        public GetABHANoVo GetAbhaNoByMobileOtp(GetAbhaByMobileRequestVo objInput)
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

            string json = "";
            GetAbhaByMobileRequestVo objvo = new GetAbhaByMobileRequestVo();
            objvo.firstName = objInput.firstName;
            objvo.middleName = objInput.middleName;
            objvo.lastName = objInput.lastName;
            objvo.name = objInput.name;
            objvo.gender = objInput.gender;
            objvo.dayOfBirth = objInput.dayOfBirth;
            objvo.monthOfBirth = objInput.monthOfBirth;

            objvo.status = objInput.status;
            objvo.otp = objInput.otp;
            objvo.txnId = objInput.txnId;
            string input = JsonConvert.SerializeObject(objvo);
            GetABHANoVo obj = new GetABHANoVo();
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "v1/forgot/healthId/mobile");
            request.Content = new StringContent(input, Encoding.UTF8,
                                     "application/json");
            using (HttpResponseMessage response = client.SendAsync(request).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    using (HttpContent content = response.Content)
                    {
                        json = content.ReadAsStringAsync().Result;
                        obj = JsonConvert.DeserializeObject<GetABHANoVo>(json);
                    }
                }
            }
            return obj;
        }

        [HttpGet]
        [Route("[action]")]
        public bool SearchByHealthIDIsExisting(string healthID)
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
            bool status=false;

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "v1/search/existsByHealthId");
            request.Content = new StringContent("{\"healthId\":\"" + healthID + "\"}", Encoding.UTF8,
                                    "application/json");
            using (HttpResponseMessage response = client.SendAsync(request).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    using (HttpContent content = response.Content)
                    {
                        json = content.ReadAsStringAsync().Result;
                        JObject obj = JObject.Parse(json);
                         status = (bool)obj["status"];


                    }
                }
            }
            return status;
        }

        [HttpGet]
        [Route("[action]")]
        public DistrictsVo GetDistrictsByStateCode(string stateCode)
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

            string json = "";
            DistrictsVo obj = new DistrictsVo();
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "v1/ha/lgd/districts");
            request.Content = new StringContent("{\"stateCode\":\"" + stateCode + "\"}", Encoding.UTF8,
                                     "application/json");
           
            using (HttpResponseMessage response = client.SendAsync(request).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    using (HttpContent content = response.Content)
                    {
                        json = content.ReadAsStringAsync().Result;
                        obj = JsonConvert.DeserializeObject<DistrictsVo>(json);
                    }
                }
            }
            return obj;
        }

        [HttpGet]
        [Route("[action]")]
        public StatesVo[] GetStateCodes()
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

            string json = "";
            StatesVo[] obj =null;
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "v1/ha/lgd/states");

           // JsonResult J = null;
            using (HttpResponseMessage response = client.SendAsync(request).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    using (HttpContent content = response.Content)
                    {
                        json = content.ReadAsStringAsync().Result;
                        obj = JsonConvert.DeserializeObject<StatesVo[]>(json);
                       
                    }
                }
              
            }
            return obj;
        }

        [HttpGet]
        [Route("[action]")]
        public StatesVo[] SaveStateCodes()
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

            string json = "";
            StatesVo[] obj = null;
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "v1/ha/lgd/states");

            // JsonResult J = null;
            using (HttpResponseMessage response = client.SendAsync(request).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    using (HttpContent content = response.Content)
                    {
                        json = content.ReadAsStringAsync().Result;
                        obj = JsonConvert.DeserializeObject<StatesVo[]>(json);
                       
                    }
                }

            }
            if (obj.Length > 0)
            {
                using(var context=new bhishak_app_dbContext())
                { 
                for (int i = 0; i < obj.Count(); i++)
                {
                   var checkState = checkedisstateInserted(Convert.ToInt32(obj[i].code));
                        if(checkState == false)
                        {
                            TblAdmState objstate = new TblAdmState();
                            objstate.Id = Convert.ToInt32(obj[i].code);
                            objstate.Name = obj[i].name;
                            objstate.Createdby = "Admin";
                            objstate.CreatedDate = DateTime.Now;
                            context.TblAdmStates.Add(objstate);
                            context.SaveChanges();
                        }
                      
                    var dObject = obj[i].districts;
                    for (int j = 0; j < dObject.Length; j++)
                    {
                        var checkDistrict = checkeisDistrictInserted(Convert.ToInt32(dObject[j].code));
                            if(checkDistrict==false)
                            {
                                TblAdmDistrict objdistrict = new TblAdmDistrict();
                                objdistrict.Id = Convert.ToInt32(dObject[j].code);
                                objdistrict.Name = dObject[j].name;
                                objdistrict.StateId= Convert.ToInt32(obj[i].code);
                                objdistrict.Createdby = "Admin";
                                objdistrict.CreatedDate = DateTime.Now;
                                context.TblAdmDistricts.Add(objdistrict);
                                context.SaveChanges();
                            }
                       
                        }

                }
                }
            }
            return obj;
        }


        private bool checkedisstateInserted(int id)
        {
            using(var context=new bhishak_app_dbContext())
            {
                var c = context.TblAdmStates.Where(x => x.Id == id).FirstOrDefault();
                if (c!= null)
                {
                    return true;
                }
                else return false;

            }
         
        }
        private bool checkeisDistrictInserted(int id)
        {
            using (var context = new bhishak_app_dbContext())
            {
                var c = context.TblAdmDistricts.Where(x => x.Id == id).FirstOrDefault();
                if (c != null)
                {
                    return true;
                }
                else return false;
            }

            
        }

        [EnableCors("AllowAllHeaders")]
        [HttpGet]
        [Route("[action]")]
        public GetHealthIdDetailsVo2 GetProfile(string token)
     {
           // GetHealthIdDetailsVo obj = JsonConvert.DeserializeObject<GetHealthIdDetailsVo>(mydata);
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
            client.DefaultRequestHeaders.Add("X-Token", "Bearer "+token);

            var json = "";
           
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "v1/account/profile");
            request.Content = new StringContent("{\"X-Token\":\"" + token + "\"}", Encoding.UTF8,
                                    "application/json");

            GetHealthIdDetailsVo2 result = new GetHealthIdDetailsVo2();
            using (HttpResponseMessage response = client.SendAsync(request).Result)
            {
                using (HttpContent content = response.Content)
                {
                    json = content.ReadAsStringAsync().Result;
                    result = JsonConvert.DeserializeObject<GetHealthIdDetailsVo2>(json);
                   SavePatientDetails(result);
                }
                
                 return result;
            }
        }
        [EnableCors("AllowAllHeaders")]
        [HttpGet]
        [Route("[action]")]
        public List<GetHealthIdDetailsVo> GetAbhaList()
        {
            List<GetHealthIdDetailsVo> list = new List<GetHealthIdDetailsVo>();
            using (var context=new bhishak_app_dbContext())
            {
             
                AbhaHealthidDetail v = new AbhaHealthidDetail();
               List<AbhaHealthidDetail> datlist = new List<AbhaHealthidDetail>();
                //  AbhaHealthidDetail obj = new AbhaHealthidDetail();
                datlist = context.AbhaHealthidDetails.ToList();
                    for(int i=0;i<datlist.Count;i++)
                  {
                    GetHealthIdDetailsVo k = new GetHealthIdDetailsVo();
                    k.count = i + 1;
                    k.name = datlist[i].Name;
                    k.healthIdNumber= datlist[i].HealthIdNumber;
                   if(datlist[i].Gender=="M")
                    {
                        k.gender = "Male";
                    }
                    else k.gender ="Female";
                   // k.gender= datlist[i].Gender;
                    k.mobile= datlist[i].Mobile;
                    k.stateName= datlist[i].Statename;
                    k.districtName = datlist[i].Districtname;
                    list.Add(k);
                }

                   
                
                    
              
               
                return list;
            }

        }
        private void SavePatientDetails(GetHealthIdDetailsVo2 obj)
        {
            using (var context=new bhishak_app_dbContext())
            {
                var check = context.TblPatients.Where(x=>x.MobileNUmber==obj.mobile && x.FirstNAme==obj.firstName).FirstOrDefault();
                TblPatient tp = new TblPatient();
                if (check==null)
                {
                  
                    tp.FirstNAme = obj.firstName;
                    tp.LastNAme = obj.lastName;
                    if (obj.middleName != null && obj.middleName != "")
                    {
                        tp.Middlename = obj.middleName;
                    }
                    tp.HealthIdNumber = obj.healthIdNumber;
                    tp.MobileNUmber = obj.mobile;
                    if (obj.email != null && obj.email != "")
                    {
                        tp.PatienTEmail = obj.email;
                    }
                    if (obj.healthId != null && obj.healthId != "")
                    {
                        tp.HealthId = obj.healthId;
                    }
                    if (obj.gender == "M")
                    {
                        tp.Sex = 1;
                    }
                    else
                    if (obj.gender == "F")
                    {
                        tp.Sex = 2;
                    }
                    else { tp.Sex = 3; }
                    tp.Address = obj.address;
                    string dob = obj.dayOfBirth + "/" + obj.monthOfBirth + "/" + obj.yearOfBirth;
                    tp.DateOfBirth = Convert.ToDateTime(dob);
                    tp.CreationDate = DateTime.Now;
                    tp.CreatedBy = "admin";
                    tp.Age = getage(Convert.ToDateTime(dob));
                    tp.StatusId = 1;

                    int intIdt = Convert.ToInt32(context.TblPatients.Max(u => u.PatienTId));
                    tp.PatienTMrn = String.Format("{0:D9}", intIdt + 1);
                    context.TblPatients.Add(tp);
                    context.SaveChanges();
                }
                var check2 = context.AbhaHealthidDetails.Where(x => (x.Mobile == obj.mobile) && (x.Firstname == obj.firstName)).FirstOrDefault();
                if(check2==null)
                {
                    var check3 = context.TblPatients.Where(x => x.MobileNUmber == obj.mobile && x.FirstNAme == obj.firstName).FirstOrDefault();


                    AbhaHealthidDetail tblAbha = new AbhaHealthidDetail();
                   
                    tblAbha.Name = obj.name;
                    tblAbha.Firstname = obj.firstName;
                    tblAbha.Lastname = obj.lastName;
                    tblAbha.Gender = obj.gender;
                    if (obj.email != null && obj.email != "")
                    {
                        tblAbha.Email = obj.email;
                    }
                    if (obj.healthId != null && obj.healthId != "")
                    {
                        tblAbha.HealthId = obj.healthId;
                    }
                    if (obj.middleName != null && obj.middleName != "")
                    {
                        tblAbha.Middlename = obj.middleName;
                    }
                    tblAbha.HealthIdNumber = obj.healthIdNumber;
                    tblAbha.ProfilePhoto = obj.profilePhoto;
                    tblAbha.KycPhoto = obj.kycPhoto;
                    tblAbha.Address = obj.address;
                    // string dob = obj.dayOfBirth + "/" + obj.monthOfBirth + "/" + obj.yearOfBirth;
                    tblAbha.DateOfBirth = check3.DateOfBirth;
                    tblAbha.PatientId = check3.PatienTId;
                    if (obj.villageName != null && obj.villageName != "")
                    {
                        tblAbha.VillageName = obj.villageName;
                    }
                    if (obj.villageCode != null && obj.villageCode != "")
                    {
                        tblAbha.VillageCode = obj.villageCode;
                    }

                    tblAbha.Districtname = obj.districtName;
                    tblAbha.DistrictCode = obj.districtCode;
                    tblAbha.Statename = obj.stateName;
                    tblAbha.StateCode = obj.stateCode;
                    tblAbha.TownName = obj.townName;
                    tblAbha.TownCode = obj.townCode;
                    tblAbha.Mobile = obj.mobile;
                    tblAbha.ClientId = obj.clientId;
                    context.AbhaHealthidDetails.Add(tblAbha);
                    context.SaveChanges();
                    
                }
            }
           

        }
        private int getage(DateTime dob)
        {
            int age = 0;
            age = DateTime.Now.Subtract(dob).Days;
            age = age / 365;
            return age;

        }

        [EnableCors("AllowAllHeaders")]
        [HttpGet]
        [Route("[action]")]
        public AbhaHealthidDetail GetAbhaProfile(string healthIdNumber)
        {

            using (var context = new bhishak_app_dbContext())
            {

                AbhaHealthidDetail obj = new AbhaHealthidDetail();
                var datlist = context.AbhaHealthidDetails.Where(x => x.HealthIdNumber == healthIdNumber).FirstOrDefault();
                if (datlist.Gender == "M")
                {
                    datlist.Gender = "Male";
                }
                else
                      if (datlist.Gender == "F")
                {
                    datlist.Gender = "Female";
                }

                return datlist;
            }
        }

            [EnableCors("AllowAllHeaders")]
            [HttpGet]
            [Route("[action]")]
            public void GetProfile2(string token)
            {
                // GetHealthIdDetailsVo obj = JsonConvert.DeserializeObject<GetHealthIdDetailsVo>(mydata);
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
                client.DefaultRequestHeaders.Add("X-Token", "Bearer " + token);

                var json = "";

                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "v1/account/getCard");
                request.Content = new StringContent("{\"X-Token\":\"" + token + "\"}", Encoding.UTF8,
                                        "application/json");

                GetHealthIdDetailsVo2 result = new GetHealthIdDetailsVo2();
                using (HttpResponseMessage response = client.SendAsync(request).Result)
                {
                    using (HttpContent content = response.Content)
                    {
                        json = content.ReadAsStringAsync().Result;
                    string jsonfilepath = @"D:\Abhajson\" + DateTime.Now.DayOfWeek + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Minute + DateTime.Now.Second+".json";


                    System.IO.File.WriteAllText(jsonfilepath, json,Encoding.UTF8);
                  
                    // string json1 = JsonSerializer.Serialize(json);
                   
                  //  File.WriteAllText(@"D:\path.json", json);
                 //   var workbook1 = new Workbook(@"D:\MADHU1.json");
                  //  workbook1.Save(@"D:\zz.pdf");
                    var workbook = new Aspose.Cells.Workbook();

                    // access default worksheet
                    var worksheet = workbook.Worksheets[0];

                    // read JSON data from file
                    string jsonInput = System.IO.File.ReadAllText(jsonfilepath);

                    // set JsonLayoutOptions to treat Arrays as Table
                    var options = new Aspose.Cells.Utility.JsonLayoutOptions();
                    options.ArrayAsTable = true;
                  //  Aspose.Cells.Utility.JsonUtility.ImportData(jsonInput, worksheet.Cells, 0, 0, options);
                    // import JSON data to worksheet starting at cell A1
                    Aspose.Cells.Utility.JsonUtility.ImportData(jsonInput, worksheet.Cells, 0, 0, options);
                    string pdffilepath = @"D:\abhaPdf\" + DateTime.Now.DayOfWeek + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Minute + DateTime.Now.Second + "out.pdf";

                    // convert imported JSON to PDF
                  //  string outputfilename = @"D:\OUT"+DateTime.Now.Day+DateTime.Now.Second+".pdf";
                    workbook.Save(pdffilepath, Aspose.Cells.SaveFormat.Auto);
                }

                   // return result;
                }
            }


        [HttpGet]
        [Route("[action]")]
        public string checkAndGenerateMobileOTP(string Mobile,string txnId)
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

            string json = "";
            GetAbhaByMobileRequestVo objvo = new GetAbhaByMobileRequestVo();
          
           
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "v2/registration/aadhaar/checkAndGenerateMobileOTP");
            request.Content = new StringContent("{\"mobile\":\"" + Mobile + "\", \"txnId\":\"" + txnId + "\"}", Encoding.UTF8,
                                     "application/json");
            using (HttpResponseMessage response = client.SendAsync(request).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    using (HttpContent content = response.Content)
                    {
                        json = content.ReadAsStringAsync().Result;
                       
                    }
                }
            }
            return json;
        }

        [HttpGet]
        [Route("[action]")]
        public string DeleteAbha(string OTP)
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
          ///  request.Content = new StringContent("{\"otp\":\"" + encryptedtext + "\", \"txnId\":\"" + transactionId + "\"}", Encoding.UTF8,
                   //                 "application/json");

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


    }


    }

