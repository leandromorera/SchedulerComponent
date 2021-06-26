using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Quartz;
using Quartz.Impl;

/*http://simplequartzschedulerincsharp.blogspot.com/

namespace QuartzExampleWF
{

    
    public class Scheduler
    {
        public IScheduler _scheduler;
        StdSchedulerFactory factory = new StdSchedulerFactory();


        


        public async Task MyMethodAsync()
        {
            Task<int> longRunningTask = LongRunningOperationAsync();
            // independent work which doesn't need the result of LongRunningOperationAsync can be done here

            //and now we call await on the task 
            int result = await longRunningTask;
            //use the result 
            Console.WriteLine(result);
        }

        public class HelloJob 
        {
            public 
            //await Task.Delay(1000); // 1 second delay
            
            return 1;
         }


        public async Task<int> LongRunningOperationAsync() // assume we return an int from this long running operation 
        {


            await _scheduler.Start();

            // define the job and tie it to our HelloJob class
            //IJobDetail job = JobBuilder.Create<HelloJob>()
                .WithIdentity("myJob", "group1")
                .Build();

            // Trigger the job to run now, and then every 40 seconds
            ITrigger trigger = TriggerBuilder.Create()
                .WithIdentity("myTrigger", "group1")
                .StartNow()
                .WithSimpleSchedule(x => x
                    .WithIntervalInSeconds(40)
                    .RepeatForever())
            .Build();

            await _scheduler.ScheduleJob(job, trigger);


            await Task.Delay(1000); // 1 second delay
            return 1;
        }



    }
}*/