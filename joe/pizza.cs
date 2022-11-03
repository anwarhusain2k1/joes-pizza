using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace joe
{
    public class pizza
    {
        public string Name { get; set; }
        public string detail { get; set; }
        public int price { get; set; }
    }
    public class op
    {
        public List<pizza> menu = new List<pizza>();
        public static List<pizza> cart = new List<pizza>();
        public void add()
        {
            pizza p = new pizza();
            p.Name = "PEPPY PANEER";
            p.detail = "paneer with crisp capsicum and spicy red pepper";
            p.price = 220;
            menu.Add(p);
            pizza p1 = new pizza();
            p1.Name = "MEXICAN GREEN WAVE";
            p1.detail = " crunchy onions, crisp capsicum, juicy tomatoes and jalapeno";
            p1.price = 230;
            menu.Add(p1);
            pizza p2 = new pizza();
            p2.Name = "PEPPER BARBECUE CHICKEN";
            p2.detail = "Pepper Barbecue Chicken I Cheese";
            p2.price = 260;
            menu.Add(p2);
            pizza p3 = new pizza();
            p3.Name = "NON VEG SUPREME";
            p3.detail = "Black Olives, Onions, Grilled Mushrooms, Pepper BBQ Chicken";
            p3.price = 290;
            menu.Add(p3);
            pizza p4 = new pizza();
            p4.Name = "STUFFED GARLIC BREAD";
            p4.detail = "Baked Garlic Bread stuffed with mozzarella cheese, sweet corns";
            p4.price = 140;
            menu.Add(p4);
        }
    }
}