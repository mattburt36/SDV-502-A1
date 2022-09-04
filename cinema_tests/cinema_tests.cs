namespace CinemaFunctions.Test
{
    //Adults before 5 test
    [TestFixture]
    public class Adult_Before_5_Test
    {
        //----------------------
        //Arrange, Act, Assert. 
        //----------------------

        //Arrange
        TicketPriceController _app = new TicketPriceController();

        //Test cases
        //----------------------------------------------
        [TestCase(14.5, 1, "adult", "monday", 4)]
        [TestCase(29, 2, "adult", "wednesday", 1)]
        [TestCase(-1, 1, "adult", "tuesday", 6)]
        [TestCase(-1, 1, "student", "friday", 3)]
        [TestCase(-1, 1, "senior", "thursday", 7)]
        [TestCase(-1, 2, "child", "tuesday", 4)]
        [TestCase(-1, 0, "", "saturday", 2)]
        //----------------------------------------------

        //Test to run, accepts expected result, quantity of ticket, type of customer, the day and time 
        [Test]
        public void Adult_before_5_Check(decimal expected, int ticket_quantity, string customer_type, string day, decimal time)
        {
            //Act 
            decimal cost = _app.Adult_Before_5(ticket_quantity, customer_type, day, time);
            //Assert 
            Assert.That(cost, Is.EqualTo(expected));
        }
    }
    //Adults after 5 test
    [TestFixture]
    public class Adult_After_5_Test
    {
        //----------------------
        //Arrange, Act, Assert. 
        //----------------------

        //Arrange
        TicketPriceController _app = new TicketPriceController();

        //Test cases
        //----------------------------------------------
        [TestCase(17.5, 1, "adult", "monday", 6)]
        [TestCase(35, 2, "adult", "wednesday", 8)]
        [TestCase(-1, 1, "adult", "tuesday", 7)]
        [TestCase(-1, 1, "student", "thursday", 3)]
        [TestCase(-1, 1, "senior", "friday", 8)]
        [TestCase(-1, 2, "child", "tuesday", 2)]
        [TestCase(-1, 0, "", "saturday", 7)]
        //----------------------------------------------
        [Test]
        public void Adult_after_5_Check(decimal expected, int ticket_quantity, string customer_type, string day, decimal time)
        {
            //Act 
            decimal cost = _app.Adult_After_5(ticket_quantity, customer_type, day, time);
            //Assert 
            Assert.That(cost, Is.EqualTo(expected));
        }

    }
    //Adults on Tuesday tests
    [TestFixture]
    public class Adult_on_Tuesday_Test
    {
        //----------------------
        //Arrange, Act, Assert. 
        //----------------------

        //Arrange
        TicketPriceController _app = new TicketPriceController();

        //Test cases
        //----------------------------------------------
        [TestCase(13, 1, "adult", "Tuesday")]
        [TestCase(26, 2, "adult", "Tuesday")]
        [TestCase(-1, 1, "adult", "wednesday")]
        [TestCase(-1, 1, "student", "thursday")]
        [TestCase(-1, 1, "senior", "friday")]
        [TestCase(-1, 2, "child", "tuesday")]
        [TestCase(-1, 0, "", "saturday")]
        //----------------------------------------------
        [Test]
        public void Adult_on_tuesday_check(decimal expected, int ticket_quantity, string customer_type, string day)
        {
            //Act 
            decimal cost = _app.Adult_Tuesday(ticket_quantity, customer_type, day);
            //Assert 
            Assert.That(cost, Is.EqualTo(expected));
        }
    }
    //Children under 16 
    [TestFixture]
    public class Children_under_16_Test
    {
        //----------------------
        //Arrange, Act, Assert. 
        //----------------------

        //Arrange
        TicketPriceController _app = new TicketPriceController();

        //Test cases
        //----------------------------------------------
        [TestCase(12, 1, "child")]
        [TestCase(24, 2, "child")]
        [TestCase(-1, 1, "adult")]
        [TestCase(-1, 2, "student")]
        [TestCase(-1, 3, "senior")]
        [TestCase(-1, 0, "")]
        //----------------------------------------------
        [Test]
        public void Child_Under_16_check(decimal expected, int ticket_quantity, string customer_type)
        {
            //Act 
            decimal cost = _app.Child_Under_16(ticket_quantity, customer_type);
            //Assert 
            Assert.That(cost, Is.EqualTo(expected));
        }
    }
    //Seniors
    [TestFixture]
    public class Senior_Test
    {
        //----------------------
        //Arrange, Act, Assert. 
        //----------------------

        //Arrange
        TicketPriceController _app = new TicketPriceController();

        //Test cases
        //----------------------------------------------
        [TestCase(12.5, 1, "senior")]
        [TestCase(25, 2, "senior")]
        [TestCase(-1, 1, "adult")]
        [TestCase(-1, 2, "student")]
        [TestCase(-1, 3, "child")]
        [TestCase(-1, 0, "")]
        //----------------------------------------------
        [Test]
        public void Senior_check(decimal expected, int ticket_quantity, string customer_type)
        {
            //Act 
            decimal cost = _app.Senior(ticket_quantity, customer_type);
            //Assert 
            Assert.That(cost, Is.EqualTo(expected));
        }
    }
    //Students
    [TestFixture]
    public class Student_Test
    {
        //----------------------
        //Arrange, Act, Assert. 
        //----------------------

        //Arrange
        TicketPriceController _app = new TicketPriceController();

        //Test cases
        //----------------------------------------------
        [TestCase(14, 1, "student")]
        [TestCase(28, 2, "student")]
        [TestCase(-1, 1, "adult")]
        [TestCase(-1, 3, "senior")]
        [TestCase(-1, 0, "")]
        //----------------------------------------------
        [Test]
        public void Student_check(decimal expected, int ticket_quantity, string customer_type)
        {
            //Act 
            decimal cost = _app.Student(ticket_quantity, customer_type);
            //Assert 
            Assert.That(cost, Is.EqualTo(expected));
        }
    }
    //Family pass
    [TestFixture]
    public class FamilyPass_Test
    {
        //----------------------
        //Arrange, Act, Assert. 
        //----------------------

        //Arrange
        TicketPriceController _app = new TicketPriceController();

        //Test cases
        //----------------------------------------------
        [TestCase(46, 1, 1, 3)]
        [TestCase(46, 1, 2, 2)]
        [TestCase(-1, 1, 3, 1)]
        [TestCase(92, 2, 4, 4)]
        [TestCase(-1, 2, 2, 2)]
        [TestCase(-1, 1, 0, 0)]
        //----------------------------------------------
        [Test]
        public void Family_Pass_check(decimal expected, int ticket_quantity, int adult_quantity, int child_quantity)
        {
            //Act 
            decimal cost = _app.Family_Pass(ticket_quantity, adult_quantity, child_quantity);
            //Assert 
            Assert.That(cost, Is.EqualTo(expected));
        }
    }
    //Chick-flick thursday 
    [TestFixture]
    public class Chick_Flick_Thursday_Test
    {
        //----------------------
        //Arrange, Act, Assert. 
        //----------------------

        //Arrange
        TicketPriceController _app = new TicketPriceController();

        //Test cases
        //----------------------------------------------
        [TestCase(21.5, 1, "adult", "thursday")]
        [TestCase(43, 2, "adult", "thursday")]
        [TestCase(-1, 1, "adult", "monday")]
        [TestCase(-1, 1, "student", "thursday")]
        [TestCase(-1, 1, "senior", "thursday")]
        [TestCase(-1, 2, "child", "tuesday")]
        [TestCase(-1, 0, "", "thursday")]
        //----------------------------------------------
        [Test]
        public void Chick_Flick_Thrusday_check(decimal expected, int ticket_quantity, string customer_type, string day)
        {
            //Act 
            decimal cost = _app.Chick_Flick_Thursday(ticket_quantity, customer_type, day);
            //Assert 
            Assert.That(cost, Is.EqualTo(expected));
        }
    }
    //Kids and carers 
    [TestFixture]
    public class Kids_Carers_Test
    {
        //----------------------
        //Arrange, Act, Assert. 
        //----------------------

        //Arrange
        TicketPriceController _app = new TicketPriceController();

        //Test cases
        //----------------------------------------------
        [TestCase(24, 2, "wednesday", false)]
        [TestCase(-1, 1, "wednesday", true)]
        [TestCase(-1, 2, "tuesday", false)]
        [TestCase(-1, 3, "monday", true)]
        [TestCase(-1, 0, "wednesday", false)]
        //----------------------------------------------

        [Test]
        public void Kids_Carers_check(decimal expected, int ticket_quantity, string day, bool is_holiday)
        {
            //Act 
            decimal cost = _app.Kids_Carers(ticket_quantity, day, is_holiday);
            //Assert 
            Assert.That(cost, Is.EqualTo(expected));
        }
    }
}