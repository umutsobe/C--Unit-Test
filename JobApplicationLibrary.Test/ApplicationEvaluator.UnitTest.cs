using _1Giris;

namespace JobApplicationLibrary.Test;

public class Tests
{
    [Test]
    public void Application_WithUnderAge_ShouldTransferredToAutoRejected(){
        //Arrange: testin başlamadan önce test ortamını oluşturduğunuz aşamadır

        var evaluater = new ApplicationEvaluator();

        var form = new JobApplication()
        {
            Applicant = new(){
                Age = 17
            }
        };

        //Action: kodun işlevini gerçekleştiren adımları bu aşamada uygularsınız.

        var appResult = evaluater.Evaluate(form);

        //Assert: testin sonucunu değerlendirmek ve doğrulamak için kullanılır.

        Assert.AreEqual(appResult, ApplicationResult.AutoRejected);
    }
}