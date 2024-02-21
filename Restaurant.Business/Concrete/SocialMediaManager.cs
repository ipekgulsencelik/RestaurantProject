using Restaurant.Business.Abstract;
using Restaurant.DataAccess.Abstract;
using Restaurant.Entity.Entities;

namespace Restaurant.Business.Concrete
{
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDAL _socialMediaDAL;

        public SocialMediaManager(ISocialMediaDAL socialMediaDAL)
        {
            _socialMediaDAL = socialMediaDAL;
        }

        public void TAdd(SocialMedia entity)
        {
            _socialMediaDAL.Add(entity);
        }

        public void TDelete(SocialMedia entity)
        {
            _socialMediaDAL.Delete(entity);
        }

        public SocialMedia TGetByID(int id)
        {
            return _socialMediaDAL.GetByID(id);
        }

        public List<SocialMedia> TGetListAll()
        {
            return _socialMediaDAL.GetListAll();
        }

        public void TUpdate(SocialMedia entity)
        {
            _socialMediaDAL.Update(entity);
        }
    }
}