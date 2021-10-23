Class Program
  {
        0 references
        static void Main(String[]  args)
        {
          EmpWageBuilderArray EmpWageBuilder  = new EmpWageBuilderArray();
          empWageBuilder.addCompanyEmpWage("Big Bazaar", 20 , 2, 10);
          empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
          empWageBuilder.computerEmpWage();
         }
}        

public class  EmpWageBuilderArray
{
  public const int IS_PART_TIME =1;
  public const int IS_FULL_TIME =2;
  
  private int numOfCompany =0;
  private CompanyEmpWage[]   CompanyEmpWageArray;
  
  1 reference
  public EmpWageBuilderArray()
  {
  this.companyEmpWageArray = new  CompanyEmpWage[5];
  }
  
  2 references
  public void addCompanyEmpWage(String company ,int empRatePerHour, int numOfWorkingDays,int maxHoursPerMonth)
  {
     companyEmpWageArray[this.numOfCompany] = new companyEmpWage(company, empRatePerHour,numOfWorkingDays,  maxHoursPerMonth);
     numOfCompany++;
     } 
     
  1 reference
  public void computeEmpWage(companyEmpWage    companyEmpWage)
   {
       //variables
       int empHrs = 0, totalEmpHrs = 0,totalWorkingDays = 0;
       //computation
       while(totalEmpHrs <=  companyEmpWage.maxHoursPerMonth &&  totalWorkingDays < companyEmpWage.numOfWorkingDays)
       {
         totalWorkingDays++;
         Random random = new Random();
         int empCheck random.Next(0, 3);
         switch (empCheck)
         {
           case IS_PART_TIME:
                empHrs = 4;
                break;
           case IS_FULL_TIME:
                empHrs  = 8;
                break;
           default:
                empHrs = 0;
                break;
          } 
          totalEmpHrs += empHrs;
          Console.WriteLine("Day#:" + totalWorkingDays + " Emp Hrs :" + empHrs);
 }
  return totalEmpHrs *  companyEmpWage.empRatePerHour;
  
  public class CompanyEmpWage
  {
      public String company;
      public int  empRatePerHour;
      public int  numOfWorkingDays;
      public int  maxHoursPerMonth;
      public int  totalEmpWage;
      
      1 reference
      public  CompanyEmpWage(string company,int empRatePerHour, int numOfWorkingDays, int  maxHoursPerMonth)
      {
        this.company = company;
        this.empRatePerHour = empRatePerHour;
        this.numOfWorkingDays =  numOfWorkingDays;
        this.maxHoursPerMonth = maxHoursPerMonth;
      }
      
      1 reference
      public void setTotalEmpWage(int totalEmpWage)
      {
         this.totalEmpWage = totalEmpWage;
      }
      
      1 reference 
      public String toString()
      {
        return "Total Emp Wage for company :" + this.comnpany +"is:"+ this.totalEmpWage;
      }
 }
  0 reference
  Class Program
  {
        0 references
        static void Main(String[]  args)
        {
          EmpWageBuilderArray EmpWageBuilder  = new EmpWageBuilderArray();
          empWageBuilder.addCompanyEmpWage("Big Bazaar", 20 , 2, 10);
          empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
          empWageBuilder.computerEmpWage();
         }
}        
