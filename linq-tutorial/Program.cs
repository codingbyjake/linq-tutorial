int[] nbrs = {

   754, 233, 509, 792, 700, 596, 833, 658, 998, 742,
   187, 754, 308, 914, 489, 867, 717, 586, 929, 467,
   460, 241, 770, 324, 599, 259, 120, 800, 336, 609,
   690, 134, 598, 249, 282, 574, 334, 956, 659, 214,
   435, 643, 809, 874, 906, 620, 328, 369, 426, 561

};

//var divBy3 = from i in nbrs
//             where i % 3 == 0 || (i % 5 == 0)
//             orderby i
//             select i;

//method syntx (nbrs divisible by 3 or 5 and softed

var divBy3Or5 = nbrs.Where(i => i % 3 == 0 || i % 5 == 0).OrderBy(i => i).ToList();


foreach(var i in divBy3Or5) {
    Console.Write($"{i} ");
}