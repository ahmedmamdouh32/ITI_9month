using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace ADOLec02
{
    internal class BuissinessLogic
    {
        //get all topica
        public static DataTable getAll()
        {
            DataTable dt=  DBLayer.select("select * from topic");
            return dt;
        }






        //get by id
        public static DataTable getById(int id)
        {
            DataTable dt = DBLayer.select($"select * from topic where top_id={id}");
            return dt;
        }


        //add topic

        public static int addTopic(int id, string name)
        {
            return DBLayer.DML($"insert into topic values({id},'{name}')");
        }

            //update topic

        public static int updateTopic(int id, string name)
        {
            return DBLayer.DML($"update topic set top_name='{name}' where top_id={id}");


        
        }
            //delete

        public static int deleteTopic(int id)
        {
            return DBLayer.DML($"delete from topic where top_id={id}");
        }
    }
