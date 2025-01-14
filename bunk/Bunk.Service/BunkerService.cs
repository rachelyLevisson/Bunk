﻿using Bunk.Core.Entity;
using Bunk.Core.Repositories;
using Bunk.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunk.Service
{
    public class BunkerService : IBunkerService
    {
        private readonly IBunkerRepository _bunkerRepository;

        public BunkerService(IBunkerRepository bunkerRepository)
        {
            _bunkerRepository = bunkerRepository;
        }

        public Bunker Add(Bunker bunker)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Bunker> GetAll()
        {
            return _bunkerRepository.GetList();
        }

        public Bunker? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Bunker Update(Bunker bunker)
        {
            throw new NotImplementedException();
        }
    }
}
