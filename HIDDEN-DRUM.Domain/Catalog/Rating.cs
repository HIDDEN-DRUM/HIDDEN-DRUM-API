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