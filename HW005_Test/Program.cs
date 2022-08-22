// Instantiate random number generator
        Random rand = new Random();
  
        // Instantiate an array of double
        double[] a = new double[10];
  
        // Store random floating point 
        // numbers in the array
        for (int i = 0; i < 10; i++)
            a[i] = rand.NextDouble();
  
        // Print 10 random floating point numbers
        Console.WriteLine("Printing 10 random "+
                      "floating point numbers");
  
        for (int i = 0; i < 10; i++)
            Console.WriteLine("{0} -> {1}", i, a[i]);
    
