using System;

namespace HIDDEN-DRUM.Domain.Catalog
{
    public classs Item
    {
        publin int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public strin Brand { get; set; }
        public decimal Price { get; set; }
        
    }
}
public Item(string Name, string Description, string Brand, decimal Price){

    if ( string.isNullorEmpty(name))
    {
        throw new ArguementException(name);
    }
    if ( string.isNullorEmpty(Description))
    {
        throw new ArguementException(Description)
    }
    if ( string.isNullorEmpty(Brand))
    {
        throw new ArguementException(Brand)
    }
    if (Price < 0.00m)
    {
        throw new ArguementException ( "Price must be greater than zero. ")
    }
    Name = name;
    Description = description;
    Brand = brand;
    Price = price;

}
