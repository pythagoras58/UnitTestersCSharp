namespace BasicUnitTesters.Tests;

public static class DumbestFunctionTest
{
    public static void DumbestFunction_ReturnsBabes_ReturnString()
    {
        try
        {
            // Arrange - Get variables, classes and functions
            int num = 0;
            DumbestFunction dumbestFunction = new DumbestFunction();
            
            //Act - execute function
            string results = dumbestFunction.ReturnsBabes(num);
            
            //Assert - whatever is return :: verify if that is what you want
            if (results == "Next Time")
            {
                Console.WriteLine("Test Passed");
            }
            else
            {
                Console.WriteLine("Test Failed");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}