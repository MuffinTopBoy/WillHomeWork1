using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WillHomeWork1.Models
{   
	public  class 客戶資料Repository : EFRepository<客戶資料>, I客戶資料Repository
	{
        客戶資料Entities db = new 客戶資料Entities();

        public override IQueryable<客戶資料> All()
        {
            return base.All().Where(x => x.IsDelete == false);
        }

        public 客戶資料 Find(int id)
        {
            return this.All().FirstOrDefault(x => x.IsDelete == false&&x.Id==id);
        }

        public void Update(客戶資料 客戶資料)
        {
            this.UnitOfWork.Context.Entry(客戶資料).State = System.Data.Entity.EntityState.Modified;
        }

        public override void Delete(客戶資料 客戶資料)
        {
            //this.UnitOfWork.Context.Entry(客戶資料).State = System.Data.Entity.EntityState.Modified;
            
            if (客戶資料 != null)
            {
                this.UnitOfWork.Context.Configuration.ValidateOnSaveEnabled = false;
                客戶資料.IsDelete = true;
            }
        }
        public IQueryable<客戶資料> 根據客戶分類找資料(string 客戶分類)
        {
            if(客戶分類!="ALL")
            {
                return this.All().Where(x => x.客戶分類.Equals(客戶分類));
            }
            else
            {
                return this.All();
            }
            
        }
    }

	public  interface I客戶資料Repository : IRepository<客戶資料>
	{

	}
}