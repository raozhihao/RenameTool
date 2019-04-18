using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RenameTool.Models
{
    public class ResertHelper
    {
        private List<HistoryObj> histories;
        public ResertHelper()
        {
            histories = new List<HistoryObj>();
        }

        /// <summary>
        /// 插入历史记录
        /// </summary>
        /// <param name="history"></param>
        public void Insert(HistoryObj history)
        {
            histories.Add(history);
        }
        

        /// <summary>
        /// 获取历史记录列表
        /// </summary>
        /// <param name="step"></param>
        /// <returns></returns>
        public List<HistoryObj> GetPrevHistorys(int step)
        {
            List<HistoryObj> listHistorys = histories.FindAll(h => h.Serial == step);
            if (listHistorys!=null&&listHistorys.Count>0)
            {
                listHistorys.ForEach(h => histories.Remove(h));
            }
            return listHistorys;
        }

        public void Destory()
        {
            histories.Clear();
        }
    }
    
    /// <summary>
    /// 历史记录对象
    /// </summary>
    public class HistoryObj
    {
        /// <summary>
        /// 序列号(非唯一)
        /// </summary>
        public int Serial { get; set; }
        /// <summary>
        /// 更改前的一次名称
        /// </summary>
        public string OldName { get; set; }
        /// <summary>
        /// 更改后的名称
        /// </summary>
        public string NewName { get; set; }
        /// <summary>
        /// 初始名称
        /// </summary>
        public string StartName { get; set; }
    }
}
