using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ValuesController : ControllerBase
    {
        [Route("~/api/v1/get-all")]
        [Route("~/getall")]
        [Route("~/get/all")]
        public string GetAll()
        {
            return "hello from get all";
        }

        //[Route("api/v1/getallauthors")]
        public string GetAllAuthors()
        {
            return "hello from get all authors";
        }

        //[Route("books/{id}")]
        public string GetbyId(int id)
        {
            return "hello book " + id;
        }

        //[Route("books/id/{id}/author/{authorId}")]
        public string GetAuhorAddressById(int id, int authorId)
        {
            return "hello id " + id + " author id " + authorId;
        }

        //[Route("searchauthor")]
        [Route("{id}/{authorId}")]
        public string SearchAuthor(int id, int authorId)
        {
            return "hello author  " + authorId;
        }

        [Route("~/search")]
        public string SearchBooks(int id, int authorId, string name, string publish, int price)
        {
            return "hello author  " + authorId;
        }
    }
}
