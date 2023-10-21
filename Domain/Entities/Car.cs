using Core.Persistance.Repositories;
using Domain.Enums;
using System.Drawing;

namespace Domain.Entities;

public class Car : Entity<Guid>
{
    public Guid ModelId { get; set; }
    public int Kilometer { get; set; }
    public int ModelYear { get; set; }
    public string Plate { get; set; }
    public short MinFindexScore { get; set; }
    public CarState CarState { get; set; }
    //public virtual Color? Color { get; set; }

    public virtual Model? Model { get; set; }
    //public virtual ICollection<CarDamage> CarDamages { get; set; }
    //public virtual ICollection<Rental> Rentals { get; set; }

    public Car()
    {
       // Rentals = new HashSet<Rental>();
        //CarDamages = new HashSet<CarDamage>();
    }

    public Car(
        Guid id,
        Guid modelId,
        CarState carState,
        int kilometer,
        short modelYear,
        string plate,
        short minFindexScore
    )
        : this()
    {
        Id = id;
       
        ModelId = modelId;
  
        CarState = carState;
        Kilometer = kilometer;
        ModelYear = modelYear;
        Plate = plate;
        MinFindexScore = minFindexScore;
    }
}
