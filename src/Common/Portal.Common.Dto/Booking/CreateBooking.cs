using System.ComponentModel.DataAnnotations;

namespace Portal.Common.Dto.Booking;

/// <summary>
/// Модель для создания брони. 
/// </summary>
public class CreateBooking
{
    /// <summary>
    /// Идентификатор зоны.
    /// </summary>
    /// <example>f0fe5f0b-cfad-4caf-acaf-f6685c3a5fc6</example>
    [Required]
    public Guid ZoneId { get; set; }
    
    /// <summary>
    /// Идентификатор пользователя.
    /// </summary>
    /// <example>f0fe5f0b-cfad-4caf-acaf-f6685c3a5fc6</example>
    [Required]
    public Guid UserId { get; set; }
    
    /// <summary>
    /// Идентификатор пакета. 
    /// </summary>
    /// <example>f0fe5f0b-cfad-4caf-acaf-f6685c3a5fc6</example>
    [Required]
    public Guid PackageId { get; set; }
    
    /// <summary>
    /// Дата бронирования.
    /// </summary>
    /// <example>10.08.2023</example>
    [Required]
    public DateOnly Date { get; set; }
    
    /// <summary>
    /// Начало времени брони.
    /// </summary>
    /// <example>12:00:00</example>
    [Required]
    public TimeOnly StartTime { get; set; }
    
    /// <summary>
    /// Конец времени брони.
    /// </summary>
    /// <example>18:00:00</example>
    [Required]
    public TimeOnly EndTime { get; set; }
    
    public CreateBooking(Guid zoneId, Guid userId, Guid packageId, DateOnly date, TimeOnly startTime, TimeOnly endTime)
    {
        ZoneId = zoneId;
        UserId = userId;
        PackageId = packageId;
        Date = date;
        StartTime = startTime;
        EndTime = endTime;
    }
}