﻿using MainProject.SBussiness.LandingPage.Models.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MainProject.Controllers
{
	public class ContactController : Controller
	{
		// GET: About
		public ActionResult Index()
		{
			return View(new ContactViewModel());
		}
	}
}