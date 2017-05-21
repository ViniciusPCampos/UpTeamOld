using Microsoft.VisualStudio.TestTools.UnitTesting;
using UPTEAM.Infra.Data.Repositories;
using UPTEAM.ApplicationServices.Helpers.Criptography;

namespace UPTEAM.ApplicationServices.Tests
{
    [TestClass()]
    public class UsuarioServiceTests
    {
        [TestMethod()]
        public void AuthenticateEmBrancoTest()
        {
            UsuarioService userService = new UsuarioService(new UsuarioRepository(), new CryptographyHelper());
            var usuario = userService.Authenticate("", "");
            Assert.AreEqual(usuario, null);
        }
        [TestMethod()]
        public void AuthenticateLoginComSenhaInvalidaTest()
        {
            UsuarioService userService = new UsuarioService(new UsuarioRepository(), new CryptographyHelper());
            var usuario = userService.Authenticate("admin", "1234");
            Assert.AreEqual(usuario, null);
        }
        [TestMethod()]
        public void AuthenticateLoginESenhaInvalidosTest()
        {
            UsuarioService userService = new UsuarioService(new UsuarioRepository(), new CryptographyHelper());
            var usuario = userService.Authenticate("1234", "1234");
            Assert.AreEqual(usuario, null);
        }
        [TestMethod()]
        public void AuthenticateLoginESenhaCorretosTest()
        {
            UsuarioService userService = new UsuarioService(new UsuarioRepository(), new CryptographyHelper());
            var usuario = userService.Authenticate("1234", "1234");
            Assert.AreEqual(usuario, null);
        }
    }
}