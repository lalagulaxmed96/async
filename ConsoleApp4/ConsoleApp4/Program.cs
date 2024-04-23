using ConsoleApp4;

HotelService hotelService = new HotelService();
RoomService roomService = new RoomService();
bool check = true;
bool subcheck = true;
string choice;

do
{
    Console.WriteLine("1.Sisteme Girish \n 0.Exit");
    choice = Console.ReadLine();
    bool subCheck = false;
    switch (choice)
    {
        case "1":

            do
            {
                Console.WriteLine("1.Hotel Yarat \n 2.Butun Hotelleri gor \n 3.Hotel sec \n 0.Exit");
                switch(choice)
                {
                    case "1":
                        
                         Console.WriteLine("hotel adi daxil edin");
                       string name = Console.ReadLine();

                        HotelService hotel = new Hotel(name);
                        hotelService.Create(hotel);

                        break;

                    case "2":

                        hotelService.GetAll().ForEach(x=> Console.WriteLine(x));    
                        break;
                    case "3":

                        Console.WriteLine("name daxil edin");
                        name = Console.ReadLine();
                        hotelService.ChooseHotel(name);

                        do
                        {
                            choice = Console.ReadLine();
                            switch(choice)
                            {
                                case "1":
                                    Room
                                    break;
                                case "2":
                                    break;
                                    case "3":
                                    break;
                                    case "4":
                                    break;
                            }

                        }while(subCheck);
                        break;
                }

            } while(subCheck);
            break;
        case "0":
            check = false;
            break;
    }
} while (check);
