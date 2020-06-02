﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PanelNewTienda.Data;
using PanelNewTienda.Models;

namespace PanelNewTienda.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<Vendedor> _signInManager;
        private readonly UserManager<Vendedor> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly ApplicationDbContext _context;

        public RegisterModel(
            UserManager<Vendedor> userManager,
            SignInManager<Vendedor> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _context = context;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = new Vendedor { UserName = Input.Email, Email = Input.Email };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");







                    var usuario = await _context.Vendedores.FirstOrDefaultAsync(v => v.Email == Input.Email);


                    var redSocialNueva = new RedSocial { Email = Input.Email, Facebook = "face", Instagram = "insta", Twitter = "twtt", Whatsapp = "22222" };
                    _context.RedesSociales.Add(redSocialNueva);
                    await _context.SaveChangesAsync();



                    var redSocialBD = await _context.RedesSociales.FirstOrDefaultAsync(r => r.Email == Input.Email);


                    var nombreTienda = "Tienda de " + Input.Email;

                    var tiendaNueva = new Tienda { NombreTienda = nombreTienda, IdRedSocial = redSocialBD.IdRedSocial, RedSocial = redSocialBD, Publicada = true };
                    _context.Tiendas.Add(tiendaNueva);
                    await _context.SaveChangesAsync();

                    var tiendaBD = await _context.Tiendas.FirstOrDefaultAsync(t => t.IdRedSocial == redSocialBD.IdRedSocial);

                    var productoNuevo1 = new Producto() { NombreProducto = "Prod de Ejemplo1", DescripcionProducto = "Descripción Ejemplo", PrecioProducto = 99.99, IdTienda = tiendaBD.IdTienda };
                    _context.Productos.Add(productoNuevo1);
                    await _context.SaveChangesAsync();
                    var productoNuevo2 = new Producto() { NombreProducto = "Prod de Ejemplo2", DescripcionProducto = "Descripción Ejemplo", PrecioProducto = 99.99, IdTienda = tiendaBD.IdTienda };
                    _context.Productos.Add(productoNuevo2);
                    await _context.SaveChangesAsync();


                    


                    usuario.IdTienda = tiendaBD.IdTienda;
                    usuario.Tienda = tiendaBD;
                    await _context.SaveChangesAsync();





                    var tiendaDeUsuario = await _context.Tiendas.FirstOrDefaultAsync(t => t.IdTienda == usuario.IdTienda);
                    var redSocialDeTiendaDeUsuario = await _context.RedesSociales.FirstOrDefaultAsync(r => r.IdRedSocial == tiendaDeUsuario.IdRedSocial);






















                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
