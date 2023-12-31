﻿using Sandiso.DataAccess.Data;
using Sandiso.DataAccess.Repository.IRepository;
using Sandiso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sandiso.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {

        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) :base (db) 
        { 
            _db = db;
        }
        /*public void save()
        {
            _db.SaveChanges();
        }
        */
        public void update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
