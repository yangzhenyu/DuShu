#region Version Info
/* ========================================================================
* 【本类功能概述】
* 
* 作者：王军 时间：2013/1/31 14:27:33
* 文件名：TaskModel
* 版本：V1.0.1
* 联系方式：511522329  
*
* 修改者： 时间： 
* 修改说明：
* ========================================================================
*/
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ReadSpider.Common
{
    public class TaskModel
    {


        /// <summary>
        /// 是否可以支持乱序，就是不需要等待完毕后才能执行
        /// </summary>
        public bool IsOutOrder { get; set; }

        /// <summary>
        /// 当不支持乱序的时候上一级操作的命令是什么，必须等上级命令执行完才操作。
        /// </summary>
        public Actions ParentAction { get; set; }
        /// <summary>
        /// 当前操作的排序
        /// </summary>
        public int Index { get; set; }
        public TaskModel()
        {
            IsSupShutDown = true;
            DoParms = new List<object>();
        }
        /// <summary>
        /// 是否支持暂停
        /// </summary>
        public bool IsSupShutDown { get; set; }
        /// <summary>
        /// 运行次数
        /// </summary>
        public int RunTime { get; set; }

        /// <summary>
        /// 操作的方法
        /// </summary>
        public Actions DoAction { get; set; }
        /// <summary>
        /// 操作的时候的参数
        /// </summary>
        public List<object> DoParms { get; set; }
        public string ActionName
        {
            get
            {
                switch (DoAction)
                {

                    default:
                        return "";
                }

            }
        }
        /// <summary>
        /// 任务状态
        /// </summary>
        public TaskState taskState { get; set; }
        public string TaskStateStr
        {
            get
            {
                switch (taskState)
                {
                    case TaskState.Complete:
                        return "已完成";
                    case TaskState.Star:
                        return "启动中";
                    case TaskState.Stop:
                        return "已停止";
                    case TaskState.Pause:
                        return "暂停中";
                    case TaskState.Run:
                        return "运行中";
                    case TaskState.Wait:
                        return "等待中";
                    case TaskState.Parper:
                        return "准备中";
                    default:
                        return "启动中";
                }
            }
        }

        public DateTime CreateTime { get; set; }

        public string Log { get; set; }

        public Thread CurrentThread { get; set; }
    }
    /// <summary>
    /// 任务状态
    /// </summary>
    public enum TaskState
    {
        /// <summary>
        /// 已完成
        /// </summary>
        Complete,
        /// <summary>
        /// 启动中
        /// </summary>
        Star,
        /// <summary>
        /// 已停止
        /// </summary>
        Stop,
        /// <summary>
        /// 已暂停
        /// </summary>
        Pause,
        /// <summary>
        /// 运行中
        /// </summary>
        Run,
        /// <summary>
        /// 等待，说明有前一个任务必须要执行完毕才能下一步
        /// </summary>
        Wait,
        /// <summary>
        /// 准备进入队列，已经申请到
        /// </summary>
        Parper
    }
}
