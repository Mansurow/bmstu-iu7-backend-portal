﻿namespace Portal.Common.Models;

/// <summary>
/// Комната/Зал/Зона
/// </summary>
public class Zone
{
    /// <summary>
    /// Идентификатор зоны 
    /// </summary>
    /// <example>f0fe5f0b-cfad-4caf-acaf-f6685c3a5fc6</example>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Название зоны
    /// </summary>
    /// <example>Космос</example>
    public string Name { get; set; }
    
    /// <summary>
    /// Адрес зоны
    /// </summary>
    /// <example>г.Москва, Рубцовская набережная 13/2 (м. Электрозаводская)</example>
    public string Address { get; set; }
    
    /// <summary>
    ///  Ограничение на количесво людей в зоне
    /// </summary>
    /// <example>16</example>
    public int Limit { get; set; }
    
    /// <summary>
    /// Размер зоны в кв. метрах
    /// </summary>
    /// <example>25.0</example>
    public double Size { get; set; }
    
    /// <summary>
    /// Стоимость зоны за час в рублях
    /// </summary>
    /// <example>349.99</example>
    public double Price { get; set; }
    
    /// <summary>
    /// Рейнтинг зоны по отзывам пользователей
    /// </summary>
    /// <example>5.0</example>
    public double Rating { get; set; }
    
    /// <summary>
    /// Инвентарь зоны
    /// </summary>
    public ICollection<Inventory> Inventories { get; set; }
    
    /// <summary>
    /// Пакеты зоны
    /// </summary>
    public ICollection<Package> Packages { get; set; }
    
    public Zone(Guid id, string name, string address, double size, int limit, double price, double rating)
    {
        Id = id;
        Name = name;
        Address = address;
        Size = size;
        Limit = limit;
        Price = price;
        Rating = rating;
        Inventories = new List<Inventory>();
        Packages = new List<Package>();
    }

    public Zone(Guid id, string name, string address, double size, int limit, double price, double rating, ICollection<Inventory> inventories, ICollection<Package> packages)
    {
        Id = id;
        Name = name;
        Address = address;
        Size = size;
        Limit = limit;
        Price = price;
        Rating = rating;
        Inventories = inventories;
        Packages = packages;
    }

    public Zone(Guid id, string name, string address, int size, int limit, double price, double rating, ICollection<Inventory> inventories)
    {
        Id = id;
        Name = name;
        Size = size;
        Address = address;
        Limit = limit;
        Price = price;
        Rating = rating;
        Inventories = inventories;
        Packages = new List<Package>();
    }

    public void ChangeRating(double rating)
    {
        Rating = rating;
    }

    public void ChangePrice(double price)
    {
        Price = price;
    }

    public void ChangeAddress(string address)
    {
        Address = address;
    }

    /// <summary>
    /// Добавить инвентарь
    /// </summary>
    public void AddInventory(Inventory inventory)
    {
        Inventories.Add(inventory);
    }
}