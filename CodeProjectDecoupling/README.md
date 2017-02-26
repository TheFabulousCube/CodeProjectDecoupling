I'm following the tutorial on https://www.codeproject.com/Articles/615139/An-Absolute-Beginners-Tutorial-on-Dependency-Inver.
It starts with a simple example:

    class EventLogWriter
    {
        public void Write(string message)
        {
        //Write to event log here
        }
    }

    class AppPoolWatcher
    {
        // Handle to EventLog writer to write to the logs
        EventLogWriter writer = null;

        // This function will be called when the app pool has problem
        public void Notify(string message)
        {
            if (writer == null)
            {
                writer = new EventLogWriter();
            }
            writer.Write(message);
        }
    }
    
  However, these two classes are tightly coupled.  The article explains that the requirements changed and they had to add an Email service and wondered what about adding an SMS service as well.  The tightly coupled design makes changes difficult.
  As I've gone through this tutorial, I went ahead and made the changes to get a better understanding of the decoupling process.  (It also prevents me from simply copy/paste from the tutorial to Visual Studio!)
