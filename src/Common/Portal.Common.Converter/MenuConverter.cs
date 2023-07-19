﻿using Portal.Database.Models;
using Portal.Common.Models;

namespace Portal.Converter;

public static class MenuConverter
{
    public static Dish ConvertDbModelToAppModel(DishDbModel dish) 
    {
        return new Dish(id: dish.Id,
                        name: dish.Name,
                        type: dish.Type,
                        price: dish.Price,
                        description: dish.Description);
    }

    public static DishDbModel ConvertAppModelToDbModel(Dish dish)
    {
        return new DishDbModel(id: dish.Id,
                        name: dish.Name,
                        type: dish.Type,
                        price: dish.Price,
                        description: dish.Description);
    }
}
