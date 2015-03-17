﻿using System.Linq;
using Libs.Services;
using DB.DAL;
using DB.Entities;

namespace CMS.Areas.Admin.Mvc
{
	public class DefaultSettingsProvider : ISettingsProvider
	{
		public string GetValue(string name)
		{
            using (var db = ApplicationDbContext.Create())
			{
				var s = db.SiteSettings.FirstOrDefault(setting => setting.Name == name);
				if (s == null)
				{
					db.SiteSettings.Add(new SiteSetting
					{
						Name = name,
						Title = name,
						Value = null
					});
					db.SaveChanges();
				}
				return s != null ? s.Value : null;
			}
		}

		public void SetValue(string name, string value)
		{
            using (var db = ApplicationDbContext.Create())
			{
				var s = db.SiteSettings.FirstOrDefault(setting => setting.Name == name);
				if (s == null)
				{
					s = new SiteSetting { Name = name };
					db.SiteSettings.Add(s);
				}
				s.Value = value;
				db.SaveChanges();
			}
		}
	}
}