using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Music.Helpers;
using Music.Models;

namespace Music.Controllers
{
    public class MusicController: Controller
    {
        private readonly MusicDbContext musicDbContext;

        public MusicController(MusicDbContext musicDbContext)
        {
            this.musicDbContext = musicDbContext;
        }

        [HttpGet]
        public IActionResult Index() 
        {
            return View(musicDbContext.ArtistDbs.SelectMany(x => x.Tracks).Include(x => x.ArtistDb).Include(x => x.AlbumDb));
        }

        [HttpGet]
        public IActionResult AddTrack()
        {
            ViewBag.Artists = new SelectList(musicDbContext.ArtistDbs, "Id", "Name");
            ViewBag.Albums = new SelectList(musicDbContext.AlbumDbs, "Id", "Title");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(Track track, IFormFile PreviewUrl, IFormFile Cover_mediumUrl)
        {
            if (ModelState.IsValid)
            {
                track.Preview = await FileUploadHelper.UploadPreviewAsync(PreviewUrl);
                track.Cover_medium = await FileUploadHelper.UploadCover_mediumAsync(Cover_mediumUrl);
                
                await musicDbContext.AddAsync(track);
                await musicDbContext.SaveChangesAsync();

                return RedirectToAction("Index", "Music");
            }
            return View("AddTrack", track);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteTrack(int? id)
        {
            if (id != null)
            {
                Track track = new Track { Id = id.Value };
                musicDbContext.Entry(track).State = EntityState.Deleted;
                await musicDbContext.SaveChangesAsync();
                return RedirectToAction("Index", "Music");
            }
            return NotFound();
        }
    }
}
