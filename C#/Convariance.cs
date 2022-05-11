public class Small
{

}
public class Big : Small
{

}
public class Bigger : Big
{

}

namespace Convariance
{
    void Run()
    {
        Small big = new Big();
        Small bigger = new Bigger();

        //Not allow Big small = new Small(); 
    }
}