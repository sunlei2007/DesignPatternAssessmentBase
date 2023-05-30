
using DesignPatternAssessmentBase.Models;

Ticket bugReport = new BugReport();
bugReport.HandleCalculateBreachDeadline();

Ticket serviceRequest = new ServiceRequest();
serviceRequest.HandleCalculateBreachDeadline();

public class BugReport : Ticket
{

    public string ErrorCode { get; set; }
    public string ErrorLog { get; set; }

    public BugReport()
    {
        CalulateHandler = new CalutlateBugReport();
    }

    public override int HandleCalculateResponseDeadline()
    {
        return CalulateHandler.CalculateResponseDeadline();
    }
    public override int HandleCalculateBreachDeadline()
    {
        return CalulateHandler.CalculateResponseDeadline();
    }
}

public enum RequestType
{
    RequestforInformation,
    ChangeRequest
}

public class ServiceRequest : Ticket
{
    // Additional properties for Service Request
    public RequestType RequestType { get; set; }

    public ServiceRequest()
    {
        CalulateHandler = new CalutlateServiceRequest();
    }

    public override int HandleCalculateResponseDeadline()
    {
        return CalulateHandler.CalculateResponseDeadline();
    }
    public override int HandleCalculateBreachDeadline()
    {
        return CalulateHandler.CalculateResponseDeadline();
    }
}

public interface ICalculateService
{
    int CalculateResponseDeadline();
    int CalculateBreachDeadline();
}

public class CalutlateBugReport : ICalculateService
{

    public int CalculateResponseDeadline()
    {

        int baseResponseDeadline = 1;
        int multiplier = 2;
        int responseDeadline = baseResponseDeadline * 1 * multiplier;

        return responseDeadline;
    }

    public int CalculateBreachDeadline()
    {

        int baseBreachDeadline = 0;
        int modifier = 100;
        int breachDeadline = baseBreachDeadline + 1 + modifier;

        return breachDeadline;
    }
}

public class CalutlateServiceRequest : ICalculateService
{

    public int CalculateResponseDeadline()
    {
        return 0;
    }

    public int CalculateBreachDeadline()
    {
        return 0;
    }
}