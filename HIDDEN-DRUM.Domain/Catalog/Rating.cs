
namespace HIDDEN.DRUM.Domain
{
    public class Rating
    {
        public int Stars { get; set; }
        public string UserName { get; set; }
        public string Review { get; set; }
        public int Id { get; set; }
        public int Star { get; set; }

        public Rating(int stars, string userName, string review)
        {
            if (stars < 1 || stars > 5)
            {
                throw new ArgumentException("Star rating must be an integer of: 1, 2, 3, 4, 5");
            }

            if (string.IsNullOrEmpty(userName))
            {
                throw new ArgumentException("UserName cannot be null.");
            }

            this.Stars = stars;
            this.UserName = userName;
            this.Review = review;
        }
    }
}

namespace HIDDEN-DRUM.Domain.Catalog;

public class Rating 
{
    public int Stars { get; set; }
    public string UserName { get; set; }
    public string Review { get; set; }
}

public Rating(int Stars, string UserName, string Review){
    if ( stars < 1 ||  stars > 5){
        throw new ArguementException("Star rating must be an integer of: 1 , 2, 3, 4, 5,. ");
  }
  if(string.isNullorEmpty(UserName))
  {throw new ArguementException( UserName cannt be null. "");

}
this.Stars = stars;
this.UserName = UserName; 
this.Review = review;
}

