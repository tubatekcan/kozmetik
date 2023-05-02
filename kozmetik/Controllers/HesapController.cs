using kozmetik.Data;
using kozmetik.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using kozmetik.ViewModel;

namespace kozmetik.Controllers
{
    public class HesapController : Controller
    {
        private readonly cosmeticsDBContext _context;

        public HesapController(cosmeticsDBContext context)
        {
            _context = context;
        }

        public IActionResult Giris()
        {
            GirisViewModel x = new GirisViewModel();    
            return View(x);
        }


            [HttpPost]
        public async Task<IActionResult> Giris([Bind("Emaill,Passwordd")] GirisViewModel girisViewModel)
        {

            if (ModelState.IsValid)
            {

                ClaimsIdentity identityy = null;
                bool isAuthenticated = false;
                Userr recordedUserr = await _context.Userrs.Include(k => k.Rolee).FirstOrDefaultAsync(m => m.Emaill == girisViewModel.Emaill && m.Passwordd == girisViewModel.Passwordd);

                if (recordedUserr== null)
                {
                    ModelState.AddModelError("", "Kullanıcı Bulunamadı.");
                    return View(girisViewModel);
                }

                if (recordedUserr.RoleeID == 1)
                {
                    return Redirect("~/Hesap/AktivasyonHatirlatmasi");
                }

                identityy = new ClaimsIdentity
                (new[]
                        {
                            new Claim(ClaimTypes.Sid,recordedUserr.UserrID.ToString()),
                            new Claim(ClaimTypes.Email,recordedUserr.Emaill),
                            new Claim(ClaimTypes.Role,recordedUserr.Rolee.RoleeName),
                        }, CookieAuthenticationDefaults.AuthenticationScheme
                );



                isAuthenticated = true;

                if (isAuthenticated)
                {
                    var claimss = new ClaimsPrincipal(identityy);
                    var loginn = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimss);



                    if (recordedUserr.Rolee.RoleeName == "Supervisor")
                    {
                        return Redirect("~/");
                    }
                    else if (recordedUserr.Rolee.RoleeName == "Admin")
                    {
                        return Redirect("~/");
                    }

                    else if (recordedUserr.Rolee.RoleeName == "NormalUser")
                    {
                        return Redirect("~/");
                    }

                    //else if (userrr.Rolee.RoleeName == "User Passive")    /*loginn olurken user passive ise zaten daha baştan yönlendirme yapıldığı için buna gerek kalmadı*/
                    //{
                    //    return Redirect("~/Account/SignupInformationPage");
                    //}
                    else
                    {
                        return Redirect("~/SayfaHatali");
                    }



                }
                return View(girisViewModel);
            }

            return View(girisViewModel);

        }

        
        public IActionResult UyeOl()
        {
            Userr userr = new Userr();
            return View(userr);
        }

        [HttpPost]
        public async Task<IActionResult> UyeOl([Bind("Emaill,Passwordd,PasswordRepeatt")] Userr userr)   /*userr = kullanıcı tarafından forma girilen bilgiler*/
        {
            userr.RoleeID = 1;

            Userr userrVarmi =await _context.Userrs.FirstOrDefaultAsync(a => a.Emaill == userr.Emaill);

            if (userrVarmi!=null)
            {
                ModelState.AddModelError("DahaOnceKayitliKullaniciHatasi", "Girmiş olduğunuz eposta başka bir kullanıcı tarafından kaydedilmiş. Lütfen başka bir eposta ile tekrar deneyin. ");
                return View(userr);
            }
            
            
            if (ModelState.IsValid)
            {
                await _context.Userrs.AddAsync(userr);
                _context.SaveChanges();

                Helpers.EpostaIslemleri.AktivasyonMailiGonder(userr.Emaill);


                return RedirectToAction("Giris","Hesap");
            }
            return View(userr);
        }


        public IActionResult AktivasyonHatirlatmasi()
        {

            return View();
        }


        public IActionResult Aktivasyon(string kkk)
        {
            string eposta = Helpers.Sifreleme.SifreyiCoz(kkk);
            Userr userr = _context.Userrs.FirstOrDefault(a=>a.Emaill==eposta);
            userr.RoleeID = 2;

            _context.Userrs.Update(userr);
            _context.SaveChanges();
            return View();
        }
        
        //public IActionResult AktivasyonYapildi()
        //{
        //    return View();
        //}

    }
}
