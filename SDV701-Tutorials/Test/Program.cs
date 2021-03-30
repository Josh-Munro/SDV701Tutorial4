using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtGallery.DataAccessLayer;
using ArtGallery.BusinessLayer;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var unitOfWork = new UnitOfWork())
            {
                var artistService = new ArtistService(unitOfWork);
                //var artistRepository = unitOfWork.ArtistRepository;
                //var artists = artistRepository.List();

                //var artistList = artistService.List();
                //artistList.ToList().ForEach(artist => Console.WriteLine(artist.Name));
                //Console.Read();

                foreach (var artist in artistService.List())
                {
                    Console.WriteLine(artist.Name);
                }

                Console.ReadLine();

                //artists.ToList().ForEach(artist => Console.WriteLine(artist.Name));
                //Console.Read();

                
            }
        }
    }
}
