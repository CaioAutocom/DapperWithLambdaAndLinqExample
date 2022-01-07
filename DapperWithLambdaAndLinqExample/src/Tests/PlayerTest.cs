using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository;

namespace Tests
{
    [TestClass]
    class PlayerTest
    {
        private readonly PlayerRepository _playerRepository;

        public PlayerTest()
        {
            _playerRepository = new PlayerRepository();
            RegisterMappings.Register();
        }

        [TestMethod]
        public void GetById()
        {
            try
            {
                var player = _playerRepository.GetById(2);
                Assert.AreEqual(2, player.id);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
        [TestMethod]
        public void Insert()
        {
            try
            {
                var player = new Player()
                {
                    Age = 38,
                    Name = "Caio",
                    TeamId = 2
                };

                _playerRepository.Insert(ref player);
                Assert.IsTrue(player.id !=0);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
        [TestMethod]
        public void Update()
        {
            try
            {
                var player = _playerRepository.GetById(4);

                player.Name = "Caio Mendes(Alterado)";

                Assert.IsTrue(_playerRepository.Update(player));
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void Delete()
        {
            try
            {
                var player = _playerRepository.GetById(4);

                player.Name = "Caio Mendes(Alterado)";

                Assert.IsTrue(_playerRepository.Update(player));
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }


        [TestMethod]
        public void GetList()
        {
            try
            {
                var result = _playerRepository.GetList(x => x.Age > 25).ToList();

                Assert.IsTrue(result.Any());
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
    }
}
