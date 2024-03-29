﻿using Microsoft.Practices.Unity;
using AmaderAd.Controllers;
using AmaderAd.Filters;
using AmaderAd.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AmaderAd.DAL
{
    [ExceptionHandlerAttribute]
    public class NewspaperDataAccessRepository : BaseController, INewspaperAccessRepository<Newspaper, int>
    {
        public IEnumerable<Newspaper> Get()
        {
            var entities = Db.NewspaperTbls.Select(x => new Newspaper()
            {
                Id 						= x.Id 						,		
                NewsGuidId 	            = x.NewsGuidId 	            ,
                NewspaperName           = x.NewspaperName            ,
                AdLocation              = x.AdLocation               ,
                PriceDescription        = x.PriceDescription                    ,
                AdvertiserName          = x.AdvertiserName           ,
                AdvertiserAddress       = x.AdvertiserAddress        ,
                AdvertiserMobile        = x.AdvertiserMobile         ,
                AdvertiserEmail         = x.AdvertiserEmail          ,
                DateofPublication       = x.DateofPublication        ,
                ColumnSize              = x.ColumnSize               ,
                Inch                    = x.Inch                     ,
                TotalColumnInch         = x.TotalColumnInch          ,
                TotalPrice              = x.TotalPrice               ,
                Description             = x.Description              ,
                AdCategoryId             = x.AdCategoryId          ,
                RawDbImagePath = HttpUtility.UrlPathEncode(baseUrl + x.MainImagePath),
               // RawDbImagePath          = x.MainImagePath           ,
                CreatedOnUtc            = x.CreatedOnUtc             ,
                UpdatedOnUtc            = x.UpdatedOnUtc             ,
                Active                  = x.Active                   ,
                IsColor = x.IsColor,

            }).ToList();
            return entities;
        }

        public Newspaper Get(int id)
        {
            var entity = Db.NewspaperTbls.Where(x => x.Id == id).Select(x => new Newspaper()
            {
                Id 						= x.Id 						,		
                NewsGuidId 	            = x.NewsGuidId 	            ,
                NewspaperName           = x.NewspaperName            ,
                AdLocation              = x.AdLocation               ,
                PriceDescription                   = x.PriceDescription                    ,
                AdvertiserName          = x.AdvertiserName           ,
                AdvertiserAddress       = x.AdvertiserAddress        ,
                AdvertiserMobile        = x.AdvertiserMobile         ,
                AdvertiserEmail         = x.AdvertiserEmail          ,
                DateofPublication       = x.DateofPublication        ,
                ColumnSize              = x.ColumnSize               ,
                Inch                    = x.Inch                     ,
                TotalColumnInch         = x.TotalColumnInch          ,
                TotalPrice              = x.TotalPrice               ,
                Description             = x.Description              ,
                AdCategoryId         = x.AdCategoryId          ,
                RawDbImagePath = HttpUtility.UrlPathEncode(baseUrl + x.MainImagePath),
            //    RawDbImagePath          = x.MainImagePath            ,
                CreatedOnUtc            = x.CreatedOnUtc             ,
                UpdatedOnUtc            = x.UpdatedOnUtc             ,
                Active                  = x.Active                   ,
                IsColor = x.IsColor,

            }).SingleOrDefault();
            if (entity != null)
            {
                entity.AdCategoryName = GetAdCategory(entity.AdCategoryId);
            }
            return entity;
        }

        public void Post(Newspaper entity)
        {
            var imgAddress = string.Empty;
            if (entity.RawDbImagePath != null)
            {
                imgAddress = entity.RawDbImagePath.TrimStart('~').TrimStart('/');
            }

            Db.NewspaperTbls.InsertOnSubmit(new NewspaperTbl
            {

                NewsGuidId 	            = entity.NewsGuidId,
                NewspaperName           = entity.NewspaperName            ,
                AdLocation              = entity.AdLocation               ,
                PriceDescription        = entity.PriceDescription                    ,
                AdvertiserName          = entity.AdvertiserName           ,
                AdvertiserAddress       = entity.AdvertiserAddress        ,
                AdvertiserMobile        = entity.AdvertiserMobile         ,
                AdvertiserEmail         = entity.AdvertiserEmail          ,
                DateofPublication       = entity.DateofPublication        ,
                ColumnSize              = entity.ColumnSize               ,
                Inch                    = entity.Inch                     ,
                TotalColumnInch         = entity.TotalColumnInch          ,
                TotalPrice              = entity.TotalPrice               ,
                Description             = entity.Description              ,
                AdCategoryId            = entity.AdCategoryId             ,
                MainImagePath           = imgAddress                      ,
                CreatedOnUtc            = DateTime.Now                    ,
                UpdatedOnUtc            = DateTime.Now                    ,
                Active                  = entity.Active                   ,
                IsColor = entity.IsColor,
            });
            try
            {
                Db.SubmitChanges();
            }
            catch (Exception)
            {
                throw new Exception("Exception");
            }
        }

        public void Put(int id, Newspaper entity)
        {
            var isEntity = from x in Db.NewspaperTbls
                           where x.Id == entity.Id
                           select x;
            var imgAddress = string.Empty;
            if (entity.RawDbImagePath != null)
            {
                imgAddress = entity.RawDbImagePath.TrimStart('~').TrimStart('/');
            }
       

            var entitySingle = isEntity.Single();

            entitySingle.NewspaperName           = entity.NewspaperName          ;
            entitySingle.AdLocation              = entity.AdLocation             ;
            entitySingle.PriceDescription                   = entity.PriceDescription                  ;
            entitySingle.AdvertiserName          = entity.AdvertiserName         ;
            entitySingle.AdvertiserAddress       = entity.AdvertiserAddress      ;
            entitySingle.AdvertiserMobile        = entity.AdvertiserMobile       ;
            entitySingle.AdvertiserEmail         = entity.AdvertiserEmail        ;
            entitySingle.DateofPublication       = entity.DateofPublication      ;
            entitySingle.ColumnSize              = entity.ColumnSize             ;
            entitySingle.Inch                    = entity.Inch                   ;
            entitySingle.TotalColumnInch         = entity.TotalColumnInch        ;
            entitySingle.TotalPrice              = entity.TotalPrice             ;
            entitySingle.Description             = entity.Description            ;
            entitySingle.AdCategoryId         = entity.AdCategoryId        ;
            entitySingle.MainImagePath           = imgAddress                    ;
            entitySingle.UpdatedOnUtc            = DateTime.Now;                 ;
            entitySingle.Active                  = entity.Active                 ;
            entitySingle.IsColor = entity.IsColor;
            try
            {
                Db.SubmitChanges();
            }
            catch (Exception)
            {
                throw new Exception("Exception");
            }
        }
    
        public void Delete(int id)
        {
            var entity = (from x in Db.NewspaperTbls
                          where x.Id == id
                          select x).SingleOrDefault();

            if (entity != null)
            {

                Db.NewspaperTbls.DeleteOnSubmit(entity ?? throw new InvalidOperationException());
            }

            try
            {
                Db.SubmitChanges();
            }
            catch (Exception)
            {
                throw new Exception("Exception");
            }
        }

    }
}