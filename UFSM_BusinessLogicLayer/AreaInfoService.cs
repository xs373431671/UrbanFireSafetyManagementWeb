using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UFSM_Model;
using UFSM_DataAccessLayer;

namespace UFSM_BusinessLogicLayer
{
    public class AreaInfoService
    {
        /// <summary>
        /// 全局共享：数据库中的AreaInfo对象集合
        /// </summary>
        private static List<AreaInfo> areaInfoList = new AreaInfoDal().GetAreaInfoList();

        /// <summary>
        /// 通过AreaNum属性查找数据库中的对应对象并返回
        /// </summary>
        /// <param name="ai">设置好AreaNum属性的AreaNum对象</param>
        /// <param name="returnMessage">返回操作信息</param>
        /// <returns></returns>
        public AreaInfo SelectAreaInfo(int areaNum,out string returnMessage)
        {
            try
            {
                if (areaInfoList.Count == 0 || areaInfoList == null)
                {
                    returnMessage = "数据库为空！";
                    return new AreaInfo();
                }
                foreach (AreaInfo a in areaInfoList)
                {
                    if (a.AreaNum == areaNum)
                    {
                        returnMessage = "查找成功！";
                        return a;
                    }
                }
                returnMessage = "未找到相关信息，请先添加！";
                return new AreaInfo();
            }
            catch
            {
                returnMessage = "数据库为空！";
                return new AreaInfo();
            }
            
        }


        /// <summary>
        /// 向数据库添加AreaInfo对象（如果AreaNum与已存在，则更改，不存在，则添加）
        /// </summary>
        /// <param name="ai">要添加的AreaInfo对象</param>
        /// <param name="returnMessage">返回操作信息</param>
        /// <returns></returns>
        public bool AddAreaInfo(AreaInfo ai,out string returnMessage)
        {
            if (ai.AreaNum > 0) { }
            else
            {
                returnMessage = "失败，要操作的地区编号异常，请联系数据库管理员！";
                return false;
            }
            
            if(areaInfoList.Count>0)
            {
                foreach (AreaInfo ai2 in areaInfoList)
                {
                    if (ai.AreaNum == ai2.AreaNum)
                    {
                        if(new AreaInfoDal().ChangeAreaInfoByAreaNum(ai))
                        {
                            returnMessage = "编号为" + ai.AreaNum + "的地区已经存在，已成功更改该地属性！";
                            areaInfoList = new AreaInfoDal().GetAreaInfoList();
                            return true;
                        }
                        else
                        {
                            returnMessage = "更改异常，请检查要上传的数据并稍后重试";
                            return false;
                        }
                    }
                }
            }              
            if (new AreaInfoDal().AddAreaInfo(ai) > 0)
            {
                returnMessage = "添加成功！";
                areaInfoList = new AreaInfoDal().GetAreaInfoList();
                return true;
            }
            else
            {
                returnMessage = "添加失败，请检查上传数据后重试！";
                return false;
            }                     
        }


        /// <summary>
        /// 通过AreaInfo的AreaNum属性更改数据库AreaInfo对象
        /// </summary>
        /// <param name="ai">要更改的AreaInfo对象</param>
        /// <param name="returnMessage">返回的操作信息</param>
        /// <returns></returns>
        public bool ChangeAreaInfo(AreaInfo ai, out string returnMessage)
        {
            if (new AreaInfoDal().ChangeAreaInfoByAreaNum(ai))
            {
                returnMessage = "更改成功";
                areaInfoList = new AreaInfoDal().GetAreaInfoList();
                return true;                
            }
            else
            {
                returnMessage = "更改失败，请查看信息格式并重试";
                return false;
            }
        }    


        /// <summary>
        /// 通过地区编号删除数据库对应地区。
        /// </summary>
        /// <param name="ai">设置好AreaNum属性的AreaInfo对象</param>
        /// <param name="returnMessage">返回的操作信息</param>
        /// <returns></returns>
        public bool DeleteAreaInfo(AreaInfo ai,out string returnMessage)
        {
            if(areaInfoList.Count==0)
            {
                returnMessage = "数据库为空，删除失败";
                return false;
            }
            
            foreach(AreaInfo a in areaInfoList)
            {
                if(a.AreaNum==ai.AreaNum)
                {
                    if(new AreaInfoDal().DeleteAreaInfoByAreaNum(ai))
                    {
                        returnMessage = "删除成功";
                        areaInfoList = new AreaInfoDal().GetAreaInfoList();
                        return true;
                    }
                    else
                    {
                        returnMessage = "删除异常，请稍后再试";
                        return false;
                    }
                }
            }

            returnMessage = "要删除的对象不存在";
            return false;           
        }


                
             
        
    }
}
