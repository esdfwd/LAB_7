using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class TaskScheduler
    {
    }
}
class TaskScheduler
{
    constructor()
    {
        this.taskQueue = [];
    }

    addTask(task, priority)
    {
        this.taskQueue.push({ task, priority });
        this.taskQueue.sort((a, b) => b.priority - a.priority);
    }

    executeNext(taskExecution)
    {
        if (this.taskQueue.length > 0)
        {
            const nextTask = this.taskQueue.shift();
            taskExecution(nextTask.task);
        }
        else
        {
            console.log("No tasks in the queue");
        }
    }

    returnToPool(object, resetObject)
    {
        resetObject(object);
        // додати об'єкт назад у пул
    }
}
