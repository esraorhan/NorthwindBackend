using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T :class,IEntity,new()
    {
        //T Referans tip olmalı bir class olmasına gerek yok bir interface de gönderilebilir T yerine
        //kısıt olarak gönderilen nesne new lenebilir olması gerekir demektir. 
        //Referans olan ,IEntity implemente edilen , newlenebilir herşeyi gönderebilirsin demektir.

        T GET(Expression<Func<T,bool>> filter); //şarta göre bir nesne getirecek.
        List<T> GETLIST(Expression<Func<T, bool>> filter = null); //C# Delege Kullanımı 
        void ADD(T entity);
        void UPDATE(T entity);
        void DELETE(T entity);
    }
}
