using Restaurant.Business.Abstract;
using Restaurant.DataAccess.Abstract;
using Restaurant.Entity.Entities;

namespace Restaurant.Business.Concrete
{
    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureDAL _featureDAL;

        public FeatureManager(IFeatureDAL featureDAL)
        {
            _featureDAL = featureDAL;
        }

        public void TAdd(Feature entity)
        {
            _featureDAL.Add(entity);
        }

        public void TDelete(Feature entity)
        {
            _featureDAL.Delete(entity);
        }

        public Feature TGetByID(int id)
        {
            return _featureDAL.GetByID(id);
        }

        public List<Feature> TGetListAll()
        {
            return _featureDAL.GetListAll();
        }

        public void TUpdate(Feature entity)
        {
            _featureDAL.Update(entity);
        }
    }
}