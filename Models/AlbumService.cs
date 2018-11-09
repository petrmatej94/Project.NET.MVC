using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.NET.MVC.Models
{
    public sealed class AlbumService
    {
        private static List<Album> MyList;
    
        static AlbumService()
        {
           MyList = new List<Album>()
            {
                new Album(){
                    ID = 1,
                    Name = "Back in Black",
                    Author = "AC/DC",
                    Year = 1980
                },
                new Album(){
                    ID = 2,
                    Name = "Highway to Hell",
                    Author = "AC/DC",
                    Year = 1979
                },
                new Album(){
                    ID = 3,
                    Name = "...And Justice for All",
                    Author = "Metallica",
                    Year = 1988
                },
                new Album(){
                    ID = 4,
                    Name = "Hardwired... To Self-Destruct",
                    Author = "Metallica",
                    Year = 2016
                },
            };
        }

        public List<Album> AlbumsList()
        {
            return MyList;
        }

        public Album FindById(int id)
        {
            return AlbumsList().FirstOrDefault(x => x.ID == id);
        }

        public void AddNewAlbum(Album album)
        {
            int newID = 1;
            foreach(Album item in MyList)
            {
                if(item.ID == newID)
                {
                    newID++;
                }
            }

            album.ID = newID;
            MyList.Add(album);
        }

        public void DeleteAlbum(int id)
        {
            Album toDelete = null;
            foreach (Album item in MyList)
            {
                if (item.ID == id)
                {
                    toDelete = item;
                }
            }
            MyList.Remove(toDelete);
        }

        public void UpdateAlbum(Album album)
        {
            foreach (Album item in MyList)
            {
                if (item.ID == album.ID)
                {
                    item.Author = album.Author;
                    item.Name = album.Name;
                    item.Year = album.Year;
                    break;
                }
            }
        }
    }
}
