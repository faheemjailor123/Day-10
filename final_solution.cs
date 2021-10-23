public class EmpWageBuilder: IComputeEmpWage
{
    public const int IS_PART_TIME = 1;
    public const int IS_PART_TIME = 2;
    
    private LinkedList<CompanyEmpWage>  CompanyWageList;
    private Dictionary<string, CompanyEmpWage>  CompanyToEmpWageMap;
   
   1 reference
   public EmpWageBuilder()
   {
       this.CompanyWageList = new  LinkedList<CompanyEmpWage>();
       this.CompanyToEmpWageMap = new Dictionary<string,   CompanyEmpWage>();
    }
    
    3 references
    public  void addCompanyEmpWage(string company,int  empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
    {
     CompanyEmpWage  CompanyEmpWage = new CompanyEmpWage(company,empRatePerHour,numOfWorkingDays,  maxHoursPerMonth);
     this.CompanyEmpWageList.AddLast(companyEmpWage);
     this.CompanyToEmpWageMap.Add(company , companyEmpWage);
    }
    
    2 references
    public  void ComputeEmpWage()
    {
          foreach(companyEmpWage  companyEmpWage in this.companyEmpWageList)
          {
              companyEmpWage.setTotalEmpWage(this.computeEmpWage(companyEmpWage));
              Console.WriteLine(companyEmpWage.toString());
          }
     }
    
    1 reference
    private int computeEmpWage( companyEmpWage  companyEmpWage )
    
    2 references
    public int getTotalWage(string company)
    {
    return this.companyToEmpWageMap[company].totalEmpWage;
    }
    
    public interface IComputeWage
    {
     3 references 
     public void addCompanyEmpWage(string company, int empRatePerHour,int numOfWorkingDays,int maxHourPerMonth)
     2 references
     public void computeEmpWage();
     2 references
     public int getTotalWage(String company);
    }
    9 references
 public class CompanyEmpWage
 {
   public string company;
   public int empRatePerHour;
   public int numOfWorkingDays;
   public int  maxHoursPerMonth;
   public int   totalEmpWage;
   
   1 reference
   public CompanyEmpWage(String company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
   {
    this.company = company;
    this.empRatePerHour  = empRatePerHour;
    this. numOfWorkingDays  = numOfWorkingDays;
    this. maxHoursPerMonth  =  maxHoursPerMonth;
    this.totalEmpWage = 0; 
    }
    
    1 reference 
   publiuc void setTotalEmpWage(int totalEmpWage)
   {
     this.totalEmpWage =  totalEmpWage;
   }
   
   1 reference
   public  String toString()
   {
     return"Total Emp Wage for company  : " + this.Company +"is:" + this.totalEmpWage;
   }
 }
