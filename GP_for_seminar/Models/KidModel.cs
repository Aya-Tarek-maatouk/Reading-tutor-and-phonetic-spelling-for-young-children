using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GP_for_seminar.Models
{
    public class KidModel
    {
        public String Regester(Kid K)
        {
            try
            {
                KidsKingdomEntities1 DB = new KidsKingdomEntities1();
                DB.Kids.Add(K);
                DB.SaveChanges();
                return "success";
            }
            catch
            {
                return "error";
            }

        }

        public Boolean Login(String username, String pass)
        {

            KidsKingdomEntities1 DB = new KidsKingdomEntities1();
            var query = from k in DB.Kids
                        where
      (k.Password == pass && k.UserName == username)
                        select k;
            if (query.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}