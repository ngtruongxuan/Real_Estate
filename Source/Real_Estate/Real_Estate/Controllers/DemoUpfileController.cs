using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Real_Estate.Controllers
{
    public class DemoUpfileController : Controller
    {
        //
        // GET: /DemoUpfile/
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Upload()
        {
            for (int i = 0; i < Request.Files.Count; i++)
            {
                HttpPostedFileBase file = Request.Files[i]; //Uploaded file
                //Use the following properties to get file's name, size and MIMEType
                int fileSize = file.ContentLength;
                string fileName = file.FileName;
                string mimeType = file.ContentType;
                System.IO.Stream fileContent = file.InputStream;
                //To save file, use SaveAs method
                file.SaveAs(Server.MapPath("~/newimage") + fileName); //File will be saved in application root
            }
            return Json("Uploaded " + Request.Files.Count + " files");
        }
        [HttpPost]
        public JsonResult Upload_2()
        {
            string fileName = Request.Headers["X-File-Name"];
            string fileType = Request.Headers["X-File-Type"];
            int fileSize = Convert.ToInt32(Request.Headers["X-File-Size"]);
            //File's content is available in Request.InputStream property
            System.IO.Stream fileContent = Request.InputStream;
            //Creating a FileStream to save file's content
            System.IO.FileStream fileStream = System.IO.File.Create(Server.MapPath("~/") + fileName);
            fileContent.Seek(0, System.IO.SeekOrigin.Begin);
            //Copying file's content to FileStream
            fileContent.CopyTo(fileStream);
            fileStream.Dispose();
            return Json("File uploaded");
        }
        //[HttpPost]
        //public async Task<JsonResult> UploadHomeReport(string id)
        //{
        //    try
        //    {
        //        foreach (string file in Request.Files)
        //        {
        //            var fileContent = Request.Files[file];
        //            if (fileContent != null && fileContent.ContentLength > 0)
        //            {
        //                // get a stream
        //                var stream = fileContent.InputStream;
        //                // and optionally write the file to disk
        //                var fileName = Path.GetFileName(file);
        //                var path = Path.Combine(Server.MapPath("~/App_Data/Images"), fileName);
        //                using (var fileStream = File.Create(path))
        //                {
        //                    stream.CopyTo(fileStream);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        Response.StatusCode = (int)HttpStatusCode.BadRequest;
        //        return Json("Upload failed");
        //    }

        //    return Json("File uploaded successfully");
        //}
        public ActionResult UploadImage(HttpPostedFileBase filename, string _username)
        {
            try
            {
                if (filename != null && filename.ContentLength > 0)
                {
                    string upFolder = Server.MapPath("~/Upload/");

                    if (!Directory.Exists(upFolder))
                    {
                        Directory.CreateDirectory(upFolder);
                    }
                    var fileName = "" + "_" + Path.GetFileName(filename.FileName);
                    var path = Path.Combine(Server.MapPath("~/Upload/"), fileName);
                    filename.SaveAs(path);
                    //var pathsaveData = "../../Upload/UserImages/" + fileName;
                    //_username = this.CurrentUsername;
                    //userService.SaveImage(_username, pathsaveData);
                    return Json(new { data = "43", mess = "" }, JsonRequestBehavior.AllowGet);
                }
                else
                    return RedirectToAction("Profile");
            }
            catch (Exception ex)
            {
                //logger.Error(ex);
                return RedirectToAction("Profile");
            }
        }
	}
}