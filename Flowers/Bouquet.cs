﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Flowers 
{
    class Bouquet 
    {
        private Flower[] bouquet;
             
        public Bouquet(int size) 
        {
            bouquet = new Flower[size];
           
        }
        public int Length => bouquet.Length;
        public Flower this[int index]
        {
            get
            {
                return this.bouquet[index];
            }
            set
            {
                this.bouquet[index] = value;
            }
        }
        public int TotalCost()
        {
            int cost = 0;
            for (int i = 0; i < bouquet.Length; i++)
            {
                cost += bouquet[i].Cost;
            }
            return cost;
        }
       
    }
}
