public class Printer<T>
{
    // array of int as jobs
    private T?[] jobs;

    // the size of the array
    private int size;
    public int Size
    {
        get { return size; }
    }

    public Printer(int capacity)
    {
        jobs = new T[capacity];
    }

    public bool Add(T job)
    {
        // do not let any new jobs be added if size == capacity
        if(size == jobs.Length)
            return false;

        // otherwise, add the job
        jobs[size++] = job;

        return true;
    }

    public T? Print()
    {
        // no jobs to print
        if(size == 0)
            return default;

        // retrieve the job
        T? document = jobs[size - 1];
        
        // erase the job
        jobs[size-- - 1] = default;

        // return the job retrieved
        return document;
    }
}