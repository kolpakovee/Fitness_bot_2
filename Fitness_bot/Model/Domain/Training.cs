using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Fitness_bot.Model.Domain;

public class Training : IDomainObject
{
    [Key]
    public string Identifier { get; set; }
    public long TrainerId { get; set; }
    public string? ClientUsername { get; set; }
    public string? Location { get; set; }
    public DateTime Time { get; set; }
    

    public Training(long trainerId)
    {
        TrainerId = trainerId;
    }

    public override string ToString() => $"⏳ {Identifier.Split('+')[0]}\n📍 {Location}\n 👤 @{ClientUsername}";
}