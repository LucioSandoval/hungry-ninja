using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

public class Buffet
{
    public List<Food> Menu { get; set; }

    public Buffet()
    {
        Menu = new List<Food>();
    
    Menu.Add(new Food("Sushi", 300, false, false));
    Menu.Add(new Food("Pizza", 800, false, false));
    Menu.Add(new Food("Curry", 600, true, false));
    Menu.Add(new Food("Ice Cream", 250, false, true));
    Menu.Add(new Food("Burger", 700, false, false));
    Menu.Add(new Food("Chili", 500, true, false));
    Menu.Add(new Food("Cake", 400, false, true));
    }
    
    public Food Serve()
    {
        Random random = new Random();
        int randomIndex = random.Next(Menu.Count);
        return Menu[randomIndex];
    }

}
