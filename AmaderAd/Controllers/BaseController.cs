using Newtonsoft.Json;
using AmaderAd.DAL;
using AmaderAd.Filters;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Net;
using AmaderAd.Models;
using Microsoft.AspNet.Identity.Owin;
using log4net;
using System.Reflection;
using Microsoft.Owin.Security;
using System.Text.RegularExpressions;
using Microsoft.AspNet.Identity;
using System.Net.Mail;
using System.Text;

namespace AmaderAd.Controllers
{
    [ExceptionHandler]
    public class BaseController:Controller
    {
        public AmaderAdDataContext Db = new AmaderAdDataContext();
        public HttpClient client;
        public string url;
        public string baseUrl = ConfigurationManager.AppSettings["webapibaseurl"];
   

        /// <summary>
        /// caching implementation
        /// </summary>
        public ICacheStorage CacheStorage = new HttpContextCacheAdapter();
        //public ICacheStorage _cacheStorage = new NullObjectCache(); 


        public static readonly log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BaseController()
        {
            client = new HttpClient {BaseAddress = new Uri(baseUrl)};
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = TimeSpan.FromMinutes(30);
            //api url
      
        }


        //AmaderAd

        

        #region  user

        public ApplicationUser GetUserInfo(ApplicationUserManager UserManager, Guid? id)
        {
            ApplicationUser user = UserManager.FindById(id.ToString());
            if (user.IsFakeEmail)
                user.Email = null;
            return user;
        }

        #endregion


        #region Email
        public bool SendEmailBase(string receiver, string subject, string body)
        {
            var destination = receiver;
            MailMessage msg = new MailMessage();
            msg.To.Add(destination);
            msg.From = new System.Net.Mail.MailAddress(
                             ConfigurationManager.AppSettings["FromAddress"], ConfigurationManager.AppSettings["TeamName"]);
            msg.Subject = subject;

            msg.Body = body;

            SmtpClient smtpclient = new SmtpClient
            {
                UseDefaultCredentials = true,
                Host = ConfigurationManager.AppSettings["BaseMailHost"],
                Port = Int32.Parse(ConfigurationManager.AppSettings["Port"]),
                EnableSsl = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential
                (
                    ConfigurationManager.AppSettings["mailAccount"],
                    ConfigurationManager.AppSettings["mailPassword"]
                ),
                Timeout = 20000
            };

            try
            {
                smtpclient.Send(msg);
                return true;

            }
            catch (Exception )
            {
                return false;
            }

        }
        #endregion

        #region ittefaq

        public string GetAdCategory(string id)
        {
            var result = string.Empty;

            var list = GetAllAdCategory();
            foreach (var item in list)
            {
                if (item.Value == id)
                {
                    return item.Text;
                }
            }
            return result;
        }

        public List<SelectListItem> GetAllAdCategory()
        {
            List<SelectListItem> ads = new List<SelectListItem>
            {
     
                new SelectListItem { Value = "1", Text = "ক্রয়   (Purchase)"},
                new SelectListItem { Value = "2", Text = " বিক্রয়   (Sale)"},
                new SelectListItem { Value = "3", Text = "বাড়ি ভাড়া (To-let) "},
                new SelectListItem { Value = "4", Text = " অফিস ভাড়া   (Office Rent)"},
                new SelectListItem { Value = "5", Text = "ভাড়া হবে  (For Rent) "},
                new SelectListItem { Value = "6", Text = "ফ্ল্যাট বিক্রয় (Flat Sale) "},
                new SelectListItem { Value = "7", Text = " জমি বিক্রয় (Land Sale)"},
                new SelectListItem { Value = "8", Text = "বিবিধ বিক্রয় (Miscellaneous Sale)"},
                new SelectListItem { Value = "9", Text = "বাড়ি বিক্রয় (House Sale)"},
                new SelectListItem { Value = "10", Text = "প্লট বিক্রয় (Plot Sale)"},
                new SelectListItem { Value = "11", Text = "দোকান বিক্রয় (Shop Sale)"},
                new SelectListItem { Value = "12", Text = " গাড়ি বিক্রয় (Car Sale)"},
                new SelectListItem { Value = "13", Text = " প্লট ক্রয় (Plot Purchase)"},
                new SelectListItem { Value = "14", Text = "আবশ্যক (Wanted)"},
                new SelectListItem { Value = "15", Text = " টিউটর দিচ্ছি/নিচ্ছি (Tution GIVE/Take)"},
                new SelectListItem { Value = "16", Text = " পড়াতে চাই (Tution Wanted)"},
                new SelectListItem { Value = "17", Text = "হোস্টেল ( Hostel) "},
                new SelectListItem { Value = "18", Text = " পাত্র চাই (Groom Wanted)"},
                new SelectListItem { Value = "19", Text = " পাত্রী চাই (Bride Wanted)"},
                new SelectListItem { Value = "20", Text = "হিন্দু পাত্র চাই (Hindu Groom Wanted)"},
                new SelectListItem { Value = "21", Text = "হিন্দু পাত্রী চাই ( Hindu Bride wanted)"},
                new SelectListItem { Value = "22", Text = " বিবিধ  (Miscellaneous)"},
                new SelectListItem { Value = "23", Text = " হারানো বিজ্ঞপ্তি (Missing Notice)"},
                new SelectListItem { Value = "24", Text = " হারানো (Lost)"},
                new SelectListItem { Value = "25", Text = " এফিডেভিট/সংশোধনী (Affidavit/Correction)"},
                new SelectListItem { Value = "26", Text = " সাহায্যের আবেদন (Seeking Help)"},
                new SelectListItem { Value = "27", Text = " শোক সংবাদ (Obituary/Mourn)"},
                new SelectListItem { Value = "28", Text = " কুলখানি (Qulkhani)"},
                new SelectListItem { Value = "29", Text = " মৃত্যুবার্ষিকী (Death Anniversary)"},
                new SelectListItem { Value = "30", Text = "মেধাবী মুখ (Meritorious Student)"},
                new SelectListItem { Value = "31", Text = "জন্মদিনের শুভেচ্ছা (Birthday Greeting)"},
                new SelectListItem { Value = "32", Text = "Others "}
            };

            return ads;
        }

        #endregion


        #region Basic
        private string SwitchEngBan(string number)
        {
            string en = "1234567890.,";
            string bn = "১২৩৪৫৬৭৮৯০.,";
            return number.Select(o => en.Contains(o)
                            ? bn.Substring(en.IndexOf(o), 1)
                            : en.Substring(bn.IndexOf(o), 1))
                            .Aggregate((a, b) => a + b);
        }
        #endregion

        #region usermanager, rolemanager
        public BaseController(ApplicationUserManager userManager, ApplicationRoleManager roleManager, ApplicationSignInManager signInManager)
        {
            UserManager = userManager;
            RoleManager = roleManager;
            SignInManager = signInManager;
        }

        public ApplicationUserManager _userManager;
        public ApplicationUserManager UserManager
        {
            get => _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            private set => _userManager = value;
        }
        public ISecureDataFormat<AuthenticationTicket> AccessTokenFormat { get;  set; }
        public ApplicationRoleManager _roleManager;
        public ApplicationRoleManager RoleManager
        {
            get => _roleManager ?? HttpContext.GetOwinContext().Get<ApplicationRoleManager>();
            private set => _roleManager = value;
        }

        private ApplicationSignInManager _signInManager;

        public ApplicationSignInManager SignInManager
        {
            get => _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            private set => _signInManager = value;
        }
        #endregion

        #region Account
        public IdentityResult CreatePatientUser(ApplicationUser user, string password, ApplicationUserManager UserManager)
        {
            IdentityResult result = UserManager.Create(user, password);
            if (!result.Succeeded)
            {
                return result;
            }
            
            //customer role
            var role = "Patient";
            var resultRole = UserManager.AddToRole(user.Id, role);
            return result;
        }

        public IdentityResult CreateCustomerUser(ApplicationUser user, string password, ApplicationUserManager UserManager)
        {
            IdentityResult result = UserManager.Create(user, password);
            if (!result.Succeeded)
            {
                return result;
            }
            //customer role
            var role = "Customer";
            var resultRole = UserManager.AddToRole(user.Id, role);
            return result;
        }

        public async Task<string> GetUserNameAsync(LoginViewModel model, ApplicationUserManager UserManager)
        {
            if (model.UserName.IndexOf('@') > -1)
            {
                //Validate email format
                string emailRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                                       @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                                          @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

                Regex re = new Regex(emailRegex);
                if (!re.IsMatch(model.UserName))
                {
                    ModelState.AddModelError("UserName", "Email is not valid");
                }
            }
            else
            {
                //validate mobile format
                string emailRegex = @"^[+0-9]*$";
                Regex re = new Regex(emailRegex);
                if (!re.IsMatch(model.UserName))
                {
                    ModelState.AddModelError("UserName", "Username is not valid");
                }
            }

            var userName = model.UserName;
            if (userName.IndexOf('@') > -1)
            {
                var user = await UserManager.FindByEmailAsync(model.UserName);

                if (user == null)
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return null;
                }
                else
                {
                    userName = user.UserName;
                    // userName = user.PhoneNumber;
                }
            }

            return userName;
        }


        public ApplicationUser GetApplicationUserPatient(RegisterPatient model)
        {
            bool isFakeMail = false;
            if (string.IsNullOrEmpty(model.Email))
            {
                model.Email = GetGeneratedEmail();
                isFakeMail = true;
            }

            var user = new ApplicationUser()
            {
                UserName        = model.PhoneNumber,
                Email           = model.Email,
                PhoneNumber     = model.PhoneNumber,
                Address         = model.Address,
                Name            = model.Name,
                DoctorName      = model.DoctorName,
                HospitalName    = model.HospitalName,
                Description     = model.Description,
                IsFakeEmail = isFakeMail,
            };
            return user;
        }


        public ApplicationUser GetApplicationUser(RegisterViewModel model)
        {
            bool isFakeMail = false;
            if (string.IsNullOrEmpty(model.Email))
            {
                model.Email = GetGeneratedEmail();
                isFakeMail = true;
            }

            var user = new ApplicationUser()
            {
                UserName = model.PhoneNumber,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
                Address = model.Address,
                Name = model.Name,
                IsFakeEmail= isFakeMail,
            };
            return user;
        }


        public string GetGeneratedEmail()
        {
            string email = string.Empty;

            email= "temp" + GetRandomNumber() +System.DateTime.Now.Ticks+ "@gmail.com";

            return email;
        }


        // Generate random number for email address
        public static int GetRandomNumber()
        {
            return new Random().Next(100000, 100000000);
        }

        #endregion

      
        #region  Banner
        public async Task<List<System.Web.Mvc.SelectListItem>> GetAllBannerList()
        {
            //custom property for parent     
            url = baseUrl + "api/BannersApi/GetAllBannersSelectList";           
            HttpResponseMessage responseMessageParentCat = await client.GetAsync(url);
            List<SelectListItem> entities = new List<SelectListItem>();
            if (responseMessageParentCat.IsSuccessStatusCode)
            {
                var responseDataParentCat = responseMessageParentCat.Content.ReadAsStringAsync().Result;

                entities = JsonConvert.DeserializeObject<List<SelectListItem>>(responseDataParentCat);
            }
            //end custom property for parent 
            return entities;
        }


        #endregion

    

        #region all
        public List<SelectListItem> SetSelectedItem(List<SelectListItem> items, int? id)
        {
            List<SelectListItem> tempItems = new List<SelectListItem>();

            foreach (var item in items)
            {
                tempItems.Add(new SelectListItem
                {
                    Text = item.Text,
                    Value = item.Value,
                    Selected = (String.Equals(item.Value, id.ToString(), StringComparison.CurrentCultureIgnoreCase)) ? true : false
                });
            }
            return tempItems;
        }
        #endregion



    }
}