using Explorer.Data;
using Explorer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace Explorer.Controllers
{
    public class DocumentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DocumentController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var folder = _context.Folders;

            return View(folder);
        }

        //CREATE FOLDER//

        //GET CREATE FOLDER
        public IActionResult CreateFolder()
        {
            return View();
        }

        //POST CREATE FOLDER
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateFolder(Folder folder)
        {
            _context.Folders.Add(folder);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        //DELETE FOLDER//

        //GET DELETE FOLDER
        public IActionResult DeleteFolder()
        {
            var folder = _context.Folders;
            return View(folder);
        }

        //GET DELETE FOLDER second view
        public IActionResult DeleteFolderAction(int? id)
        {
            if (id == 0 || id == null)
            {
                return NotFound();
            }

            var folderId = _context.Folders.Find(id);
            if (folderId == null)
            {
                return NotFound();
            }

            return View(folderId);
        }

        //POST DELETE FOLDER
        [HttpPost, ActionName("DeleteFolderAction")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteFolderPost(int? id)
        {
            var folderId = _context.Folders.Find(id);
            if (folderId == null)
            {
                return NotFound();
            }
            _context.Folders.Remove(folderId);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        //ADD DOCUMENT//

        //GET ADD DOCUMENT
        public IActionResult AddDocument()
        {
            return View();
        }

        //POST ADD DOCUMENT
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> AddDocument(IFormFile file, [Bind("ID,Name,Description,ExtensionID,FolderID,Content, FormFile")] Document document, string description)
        //{
        //    ViewData["ExtensionID"] = new SelectList(_context.Set<Extension>(), "ID", "Type", document.ExtensionID);
        //    ViewData["FolderID"] = new SelectList(_context.Set<Folder>(), "ID", "Name", document.FolderID);



        //    document.Name = Path.GetFileNameWithoutExtension(file.FileName);
        //    document.Description = description;
        //    document.ExtensionID = document.Extension.ID;
        //    document.FolderID = document.Folder.ID;
        //    document.Content = System.IO.File.ReadAllText(file.FileName);


        //        _context.Add(document);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));



        //    var document = _context.Documents
        //        .Include(e => e.Extension)
        //        .Include(f => f.Folder);

        //    foreach (var file in files)
        //    {

        //        Type = Path.GetExtension(file.FileName);
        //        extension.Icon = "png";


        //        document.ExtensionID = extension.ID;
        //        document.Name = Path.GetFileNameWithoutExtension(file.FileName);
        //        document.Content = System.IO.File.ReadAllText(file.FileName);
        //        document.FolderID = folder.ID;
        //        document.Description = description;


        //        _context.Documents.Add(document);
        //        _context.SaveChanges();
        //    }

        //    TempData["Message"] = "File successfully uploaded to Database";

        //    return RedirectToAction("Index");
        //}

        //RENAME//

        //GET RENAME
        public IActionResult Rename()
        {
            var folder = _context.Folders;
            return View(folder);
        }

        //GET RENAME second view
        public IActionResult RenameAction(int? id)
        {
            if (id == 0 || id == null)
            {
                return NotFound();
            }

            var folderId = _context.Folders.Find(id);
            if (folderId == null)
            {
                return NotFound();
            }

            return View(folderId);
        }

        //POST RENAME
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RenameAction(Folder folder)
        {
            _context.Folders.Update(folder);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
