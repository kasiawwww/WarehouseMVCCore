using System.Collections.Generic;

namespace WarehouseMVCCore.Models.Repositories
{
    public interface IWarehouseRepo
    {
        IEnumerable<WarehouseModel> GetAll();
        int Add(WarehouseModel warehouseModel);
        bool Update(WarehouseModel warehouseModel);
        bool Delete(int? id);
    }
}