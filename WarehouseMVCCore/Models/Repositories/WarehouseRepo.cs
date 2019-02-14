using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarehouseMVCCore.Data;

namespace WarehouseMVCCore.Models.Repositories
{

    public class WarehouseRepo : IWarehouseRepo
    {

        private readonly ApplicationDbContext context;

        public WarehouseRepo(ApplicationDbContext context)
        {
            this.context = context;
        }

        public int Add(WarehouseModel warehouseModel)
        {
            context.Warehouse.Add(warehouseModel);
            context.SaveChanges();
            return warehouseModel.Id;
        }
        public bool Update(WarehouseModel warehouseModel)
        {
            try
            {
                var dbItem = context.Warehouse.Find(warehouseModel.Id);
                dbItem.Name = warehouseModel.Name;
                dbItem.Quantity = warehouseModel.Quantity;
                context.Warehouse.Update(dbItem);
                //context.Entry(dbItem).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                //Log();
                return false;
            }
        }
        public bool Delete(int? id)
        {
            var dbItem = context.Warehouse.Find(id);
            if (dbItem == null)
            {
                return false;
            }
            context.Warehouse.Remove(dbItem);
            context.SaveChanges();
            return true;
        }

        public IEnumerable<WarehouseModel> GetAll() //IQuerable lepsze od List i IEnumerable bo wybiera z bazy, a List i num pobierają tabele do pamieci i wtedy wykonuja query
        {
            return context.Warehouse.ToList();
        }


    }
}
