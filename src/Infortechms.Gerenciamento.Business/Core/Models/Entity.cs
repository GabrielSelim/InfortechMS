using System;
using System.Numerics;

namespace Infortechms.Gerenciamento.Business.Core.Models
{
    public abstract class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();

            //Guid gd = Guid.NewGuid();

            //BigInteger Id = new BigInteger(gd.ToByteArray());
        }
        //public BigInteger Id { get; set; }
        public Guid Id { get; set; }


    }
}