using EvaluationSampleCode;

namespace EvaluationSampleCodeTest
{
    [TestClass]
    public class ReservationTest
    {
        private Reservation? _reservation;
        private User? _user;
        private User? _adminUser;
        private User? _anotherUser;

        [TestInitialize]
        public void Init()
        {
            _user = new User { IsAdmin = false };
            _adminUser = new User { IsAdmin = true };
            _anotherUser = new User { IsAdmin = false };
            _reservation = new Reservation(_user);
        }

        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            // Act
            var result = _reservation!.CanBeCancelledBy(_adminUser!);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_SameUserCancelling_ReturnsTrue()
        {
            // Act
            var result = _reservation!.CanBeCancelledBy(_user!);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_AnotherUserCancelling_ReturnsFalse()
        {
            // Act
            var result = _reservation!.CanBeCancelledBy(_anotherUser!);

            // Assert
            Assert.IsFalse(result);
        }
    }
}