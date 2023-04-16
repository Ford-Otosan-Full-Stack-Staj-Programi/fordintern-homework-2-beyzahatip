using Homework2.Data.Context;
using Homework2.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly AppDbContext context;
        private bool disposed;
        

        public UnitOfWork(AppDbContext context)
        {
            this.context = context;
            
        }
        //public void CompleteWithTransaction()
        //{
        //    using (var dbContextTransaction = context.Database.BeginTransaction())
        //    {
        //        try
        //        {
        //            context.SaveChanges();
        //            dbContextTransaction.Commit();
        //        }
        //        catch (Exception ex)
        //        {
        //            // logging                    
        //            dbContextTransaction.Rollback();
        //        }
        //    }
        //}

        


        public void Complete()
        {
            context.SaveChanges();
        }

        protected virtual void Clean(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Clean(true);
            GC.SuppressFinalize(this);
        }
    }
}
