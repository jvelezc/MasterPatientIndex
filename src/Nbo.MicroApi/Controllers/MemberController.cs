using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nbo.DataTransferObjects;

namespace Nbo.MicroApi.Controllers
{
    //http://localhost:63080/swagger/ui
    //
    [Route("api/[controller]")]

    [Produces("application/json")]
    public class MemberController : Controller
    {

        ///api/Member/1
        /// <summary>
        /// When the caler of this method has the uniqueIdentifer for the member then he is able to get all of the information pertaining 
        /// that member
        /// </summary>
        /// <param name="uniqueIdentifier"></param>
        /// <returns></returns>
        // GET api/member/jose
        [HttpGet("{uniqueIdentifier}")]
        public ApplicationDetailViewModel Get(string uniqueIdentifier)
        {
            return new ApplicationDetailViewModel
            {
                UniqueIdentifier = "77fff-ffdd-ddd",
                UserApplications = new List<UserApplicationsViewModels>()
                    {
                        new UserApplicationsViewModels
                        {
                            ApplicationName ="Eloqua",
                            RecordKey ="Abc",
                            UserName = "mgarcia"
                        },
                        new UserApplicationsViewModels
                        {
                            ApplicationName ="Saleforce",
                            RecordKey ="1",
                            UserName = "saleforce_mgarcia7"
                        }
                }
            };
        }


        ///member/{recordId}/{applicationName}
        /// <summary>
        /// The combination of recordId and application name means that the caller will receive the unique identifier 
        /// that they need in order to do their business process. This is usefull when you do not know the unique identifer but the 
        /// caller knows its own unique id and the name of their application.
        /// </summary>
        /// <param name="recordId"></param>
        /// <param name="applicationName"></param>
        /// <returns></returns>
        
        [HttpGet("{recordId}/{applicationName}")]
        public ApplicationDetailViewModel Get(string recordId, string applicationName)
        {
            return new ApplicationDetailViewModel
            {
                UniqueIdentifier = "77fff-ffdd-ddd",
                UserApplications = new List<UserApplicationsViewModels>()
                    {
                        new UserApplicationsViewModels
                        {
                            ApplicationName ="Eloqua",
                            RecordKey ="Abc",
                            UserName = "mgarcia"
                        }
                    }
            };
        }

    
        [Route("/api/Member/{recordId}/{applicationName}/actions")]
        public ApplicationDetailViewModel Actions(string recordId, string applicationName)
        {
            return new ApplicationDetailViewModel
            {
                UniqueIdentifier = "77fff-ffdd-ddd",
                UserApplications = new List<UserApplicationsViewModels>()
                    {
                        new UserApplicationsViewModels
                        {
                            ApplicationName ="Eloqua",
                            RecordKey ="Abc",
                            UserName = "mgarcia"
                        }
                    }
            };
        }
    }
}

