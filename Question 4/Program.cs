
          Console.WriteLine("input number");
          Console.WriteLine("firstnumber");
          int firstnumber =int.Parse(Console.ReadLine());
          Console.WriteLine("secondnumber");
          int secondnumber = int.Parse(Console.ReadLine());
          Console.WriteLine("thirdnumber");
          int thirdnumber = int.Parse(Console.ReadLine());
        
            int des1 = 0;
            int des2 = 0;
            int des3 = 0;
            if(thirdnumber > secondnumber)
            {
                if(secondnumber >  firstnumber)
                {
                    des3=firstnumber;
                    des2=secondnumber;
                    des1=thirdnumber;
                }
            }
            else if(secondnumber > firstnumber)
            {
                if(firstnumber > thirdnumber)
                {
                    des3=thirdnumber;
                    des2=firstnumber;
                    des1=secondnumber;
                }
            }
            else
            {
                des1=thirdnumber;
                des2=secondnumber;
                des3=firstnumber;
            }
            Console.WriteLine(des1);
            Console.WriteLine(des2);
            Console.WriteLine(des3);