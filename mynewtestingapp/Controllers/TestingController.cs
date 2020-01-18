using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mynewtestingapp.Models;
using mynewtestingapp.TestCases;

namespace mynewtestingapp.Controllers
{
    public class TestingController : Controller
    {
        // GET: Testing
        [HttpGet]
        public ActionResult Index()
        {
            IList<TestingResultModel> studentList = new List<TestingResultModel>();
            studentList.Add(new TestingResultModel() { ApplicatioName = "Bill" });
            ViewData["students"] = studentList;
            return View();
        }
        // Post: Testing
        [HttpPost]
        public ActionResult HandelForm(TestingModel ApplicatioNames, TestingModel TestTypes, TestingModel ProjectNames)
        {
            string ProjectName = ProjectNames.ProjectName.ToString();
            string TestType = TestTypes.TestType.ToString();
            string ApplicatioName = ApplicatioNames.ApplicatioName.ToString();
            App1TestCases Testobj = new App1TestCases();
            switch (ProjectName)
            {
                case "lifeAlborzInsurance":
                {
                    switch (ApplicatioName)
                    {
                        case "AlborzContactManagingDirector":
                        {
                            switch (TestType)
                            {
                                case "AcceptanceTest":
                                    string[] testrepo = Testobj.TestAction();
                                    IList<TestingResultModel> testindexlist = new List<TestingResultModel>();
                                    testindexlist.Add(new TestingResultModel() {ApplicatioName = testrepo[0], ProjectName = testrepo[1], TestType = testrepo[2] });

                                    ViewData["testindexlist"] = testindexlist;
                                    return View("TestResult");
  
                            }
                        }
                            break;
                    }
                    break;
                }
            }
            
            return View("Index");
        }
    }
}