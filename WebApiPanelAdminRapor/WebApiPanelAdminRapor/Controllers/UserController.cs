using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;

namespace WebApiPanelAdminRapor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly PanelappContext _context;
        public UserController(PanelappContext context)
        {
            _context = context;
        }
        //Tüm kullanicilari getir
        [HttpGet]
        public async Task <ActionResult<List<AspNetUser>>> GetAllUsers()
        {
            return Ok(await _context.AspNetUsers.ToListAsync());
        }
        //user ekleme
        // POST: api/User
        [HttpPost]
        public async Task<ActionResult<AspNetUser>> PostUser([FromBody] AspNetUser user)
        {
            if (user == null)
            {
                return BadRequest("User cannot be null.");
            }

            // Validation logic if needed
            if (string.IsNullOrEmpty(user.UserName) || string.IsNullOrEmpty(user.PasswordHash))
            {
                return BadRequest("UserName and PasswordHash are required.");
            }

            // Create new user ID
            user.Id = Guid.NewGuid().ToString();

            _context.AspNetUsers.Add(user);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (UserExists(user.Id))
                {
                    return Conflict("A user with this ID already exists.");
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
        }

        private bool UserExists(string id)
        {
            return _context.AspNetUsers.Any(e => e.Id == id);
        }

        // Optional: Get user by ID method
        [HttpGet("{id}")]
        public async Task<ActionResult<AspNetUser>> GetUser(string id)
        {
            var user = await _context.AspNetUsers.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }




        //Id'ye göre kullanicilar
        [HttpGet("userId")]
        public async Task<ActionResult<AspNetUser>> GetUserById(string id)
        {
            var user = await _context.AspNetUsers.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
        //Toplam kullanici
        [HttpGet("total")]
        public async Task<ActionResult<int>> GetTotalUsers()
        {
            var totalUsers = await _context.AspNetUsers.CountAsync();
            return Ok(totalUsers);
        }
        //eklenen son kullanıcıyı-adını getir
        [HttpGet("EklenenSonKullanici")]
        public async Task<ActionResult<AspNetUser>> GetLatestUser()
        {
            var latestUser = await _context.AspNetUsers
                .OrderByDescending(u => u.Id) // En son eklenen kullanıcıyı almak için Id'ye göre sıralama
                .FirstOrDefaultAsync();

            if (latestUser == null)
            {
                return NotFound();
            }

            return Ok(latestUser.UserName);
        }
        //Kulalnıcı role göre getir
        [HttpGet("KullaniciRole")]
        public async Task<ActionResult<List<AspNetUser>>> GetUsersByRole(string role)
        {
            var normalizedRole = role.ToLower(); // Arama terimini küçük harfe çevir
            var users = await _context.AspNetUsers
                .Where(u => u.UserRole.ToLower() == normalizedRole) // Veritabanındaki rol değerini küçük harfe çevirerek karşılaştır
                .ToListAsync();

            return Ok(users);
        }
     
     

    
        //kullanıcı silme
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await _context.AspNetUsers.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.AspNetUsers.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        // Kullanıcı güncelleme
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(string id, [FromBody] AspNetUser updatedUser)
        {
            if (updatedUser == null || id != updatedUser.Id)
            {
                return BadRequest("User data is required and ID must match.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingUser = await _context.AspNetUsers.FindAsync(id);
            if (existingUser == null)
            {
                return NotFound("User not found.");
            }

            try
            {
                // Mevcut kullanıcının bilgilerini güncelle
                existingUser.UserName = updatedUser.UserName;
                existingUser.NormalizedUserName = updatedUser.NormalizedUserName;
                existingUser.Email = updatedUser.Email;
                existingUser.NormalizedEmail = updatedUser.NormalizedEmail;
                existingUser.EmailConfirmed = updatedUser.EmailConfirmed;
                existingUser.PhoneNumber = updatedUser.PhoneNumber;
                existingUser.PhoneNumberConfirmed = updatedUser.PhoneNumberConfirmed;
                existingUser.TwoFactorEnabled = updatedUser.TwoFactorEnabled;
                existingUser.LockoutEnd = updatedUser.LockoutEnd;
                existingUser.LockoutEnabled = updatedUser.LockoutEnabled;
                existingUser.AccessFailedCount = updatedUser.AccessFailedCount;
                existingUser.Adi = updatedUser.Adi;
                existingUser.Soyadi = updatedUser.Soyadi;
                existingUser.AvatarHash = updatedUser.AvatarHash;
                existingUser.UserRole = updatedUser.UserRole;
                existingUser.TagNames = updatedUser.TagNames;
                existingUser.OrgFk = updatedUser.OrgFk;
                existingUser.CalendarIntegrated = updatedUser.CalendarIntegrated;
                existingUser.Tema = updatedUser.Tema;
                existingUser.Font = updatedUser.Font;
                existingUser.KulupLogouKullan = updatedUser.KulupLogouKullan;
                existingUser.RaporGecmisi = updatedUser.RaporGecmisi;
                existingUser.Sayfalama = updatedUser.Sayfalama;
                existingUser.FavGamesCount = updatedUser.FavGamesCount;

                if (!string.IsNullOrEmpty(updatedUser.PasswordHash))
                {
                    existingUser.PasswordHash = new PasswordHasher<AspNetUser>().HashPassword(existingUser, updatedUser.PasswordHash);
                }

                if (updatedUser.OrgFkNavigation != null)
                {
                    _context.Entry(updatedUser.OrgFkNavigation).State = EntityState.Unchanged;
                }

                _context.Entry(existingUser).State = EntityState.Modified;
                await _context.SaveChangesAsync();

                return Ok(existingUser);
            }
            catch (Exception ex)
            {
                var innerExceptionMessage = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                return StatusCode(500, $"Internal server error: {innerExceptionMessage}");
            }
        }
        [HttpPost("upload-users")]
        public async Task<IActionResult> UploadUsersFromExcel(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest(new { message = "A valid Excel file is required." });
            }

            try
            {
                using (var stream = new System.IO.MemoryStream())
                {
                    await file.CopyToAsync(stream);

                    // EPPlus lisans ayarları
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                    using (var package = new ExcelPackage(stream))
                    {
                        var worksheet = package.Workbook.Worksheets[0]; // İlk sayfayı al
                        var rowCount = worksheet.Dimension.Rows;

                        for (int row = 2; row <= rowCount; row++) // Başlık satırını atla
                        {
                            var newUser = new AspNetUser
                            {
                                Id = Guid.NewGuid().ToString(),
                                UserName = worksheet.Cells[row, 1].Text,
                                NormalizedUserName = worksheet.Cells[row, 2].Text.ToUpper(),
                                Email = worksheet.Cells[row, 3].Text,
                                NormalizedEmail = worksheet.Cells[row, 4].Text.ToUpper(),
                                EmailConfirmed = bool.Parse(worksheet.Cells[row, 5].Text),
                                PasswordHash = new PasswordHasher<AspNetUser>().HashPassword(null, worksheet.Cells[row, 6].Text),
                                SecurityStamp = worksheet.Cells[row, 7].Text,
                                ConcurrencyStamp = worksheet.Cells[row, 8].Text,
                                PhoneNumber = worksheet.Cells[row, 9].Text,
                                PhoneNumberConfirmed = bool.Parse(worksheet.Cells[row, 10].Text),
                                TwoFactorEnabled = bool.Parse(worksheet.Cells[row, 11].Text),
                                LockoutEnd = string.IsNullOrEmpty(worksheet.Cells[row, 12].Text) ? (DateTime?)null : DateTime.Parse(worksheet.Cells[row, 12].Text),
                                LockoutEnabled = bool.Parse(worksheet.Cells[row, 13].Text),
                                AccessFailedCount = int.Parse(worksheet.Cells[row, 14].Text),
                                Adi = worksheet.Cells[row, 15].Text,
                                Soyadi = worksheet.Cells[row, 16].Text,
                                AvatarHash = worksheet.Cells[row, 17].Text,
                                UserRole = worksheet.Cells[row, 18].Text,
                                TagNames = worksheet.Cells[row, 19].Text,
                                OrgFk = int.Parse(worksheet.Cells[row, 20].Text),
                                CalendarIntegrated = bool.Parse(worksheet.Cells[row, 21].Text),
                                Tema = int.Parse(worksheet.Cells[row, 22].Text),
                                Font = int.Parse(worksheet.Cells[row, 23].Text),
                                KulupLogouKullan = bool.Parse(worksheet.Cells[row, 24].Text),
                                RaporGecmisi = worksheet.Cells[row, 25].Text,
                                Sayfalama = worksheet.Cells[row, 26].Text,
                                FavGamesCount = int.Parse(worksheet.Cells[row, 27].Text)
                            };

                            _context.AspNetUsers.Add(newUser);
                        }

                        await _context.SaveChangesAsync();
                    }
                }

                return Ok(new { message = "Users imported successfully." });
            }
            catch (Exception ex)
            {
                var innerExceptionMessage = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                return StatusCode(500, new { message = $"Internal server error: {innerExceptionMessage}" });
            }
        }

    }
}
