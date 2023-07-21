﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Portal.Common.Models.Enums;

namespace Portal.Database.Models;

public class PackageDbModel
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }
    [Column("name", TypeName = "varchar(64)")]
    public string Name { get; set; }
    [Column("type")]
    public PackageType Type { get; set; }
    [Column("price")]
    public double Price { get; set; }
    [Column("rental_time")]
    public int RentalTime { get; set; }
    [Column("description", TypeName = "text")]
    public string Description { get; set; }

    public ICollection<ZoneDbModel> Zones { get; set; }
    public ICollection<DishDbModel> Dishes { get; set; }

    public PackageDbModel(Guid id, string name, PackageType type, double price, int rentalTime,
        string description, ICollection<DishDbModel> dishes)
    {
        Id = id;
        Name = name;
        Type = type;
        Price = price;
        RentalTime = rentalTime;
        Description = description;
        Dishes = dishes;
        Zones = new List<ZoneDbModel>();
    }

    public PackageDbModel(Guid id, string name, PackageType type, double price, int rentalTime, 
        string description, ICollection<DishDbModel> dishes, ICollection<ZoneDbModel> zones)
    {
        Id = id;
        Name = name;
        Type = type;
        Price = price;
        RentalTime = rentalTime;
        Description = description;
        Dishes = dishes;
        Zones = zones;
    }
}