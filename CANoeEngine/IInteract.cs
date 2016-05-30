using System;
using System.Collections.Generic;
using System.IO;

namespace CANoeEngine
{
    public class Interact:ICANoe
    {
        #region 和CAPL交互的系统变量
        /// <summary>
        /// 开始硬件自检(一个string类型表示符，比如“on”)
        /// </summary>
        private CANoe.Variable _startDeviceSelfCheck;
        /// <summary>
        /// 硬件自检结果
        /// </summary>
        private CANoe.Variable deviceSelfCheckResult;
        /// <summary>
        /// 开始样件自检(同上)
        /// </summary>
        private CANoe.Variable startPrototypeSelfCheck;
        /// <summary>
        /// 样件自检结果
        /// </summary>
        private CANoe.Variable prototypeSelfCheckResult;
        /// <summary>
        /// 用例编码
        /// </summary>
        private CANoe.Variable exampleCode;
        /// <summary>
        /// 用例执行结果
        /// </summary>
        private CANoe.Variable exampleResult;
        /// <summary>
        /// 执行过程中提示
        /// </summary>
        private CANoe.Variable processingPrompt;
        /// <summary>
        /// 品牌驱动
        /// </summary>
        private CANoe.Variable prototypeBrandDrive;
        /// <summary>
        /// 由于暂停需要存储的缓存数据
        /// </summary>
        private CANoe.Variable CacheSaveAsPause;
        #endregion

        #region 其他变量
        // 工程文件的绝对路径
        private String absoluteConfigurationPath = "";
        private string caplNamespaceName = "mutualVar";
        // CANoe对象
        private CANoe.Application mCANoeApp;
        private CANoe.Measurement mCANoeMeasurement;
        private CANoe.System CANoeSystem;
        private CANoe.Namespaces CANoeNamespaces;
        private CANoe.Namespace CANoeNamespaceGeneral;
        /// <summary>
        /// 
        /// </summary>
        private CANoe.Variables CANoeVariablesGeneral;

        Dictionary<CANoe.Variable, string> dict = new Dictionary<CANoe.Variable, string>();
        #endregion

        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="relativePath">工程文件的绝对路径</param>
        public void InteractCaNoe(string absolutePath)
        {
            absoluteConfigurationPath = absolutePath;
            //dict.Add(startDeviceSelfCheck,"default");
            //dict.Add(deviceSelfCheckResult, "default");
            //dict.Add(startPrototypeSelfCheck, "default");
            //dict.Add(prototypeSelfCheckResult, "default");
            //dict.Add(exampleCode, "default");
            //dict.Add(exampleResult, "default");
            //dict.Add(processingPrompt, "default");

        }
        #endregion

        #region 是否存在此工程文件

        public bool IsExistConfiguration()
        {
            if (File.Exists(absoluteConfigurationPath))
                return true;
            else
                return false;
        }
        #endregion

        #region 打开CANoe
        public bool OpenCANoe()
        {
            mCANoeApp = new CANoe.Application();

            // Init measurement object.
            mCANoeMeasurement = (CANoe.Measurement)mCANoeApp.Measurement;

            // Stopps a running measurement.
            if (mCANoeMeasurement.Running)
            {
                mCANoeMeasurement.Stop();
            }

            if (mCANoeApp != null)
            {
                // Open the demo configuration.
                mCANoeApp.Open(absoluteConfigurationPath, true, true);

                // Make sure the configuration was successfully loaded.
                CANoe.OpenConfigurationResult ocresult = mCANoeApp.Configuration.OpenConfigurationResult;
                if (ocresult.result == 0)
                {
                    GetAllMutualVar();
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        #endregion

        #region 开始运行或停止运行CANoe
        public int StartOrStopCaNoe()
        {
            try
            {
                if (mCANoeMeasurement != null)
                {
                    if (mCANoeMeasurement.Running)
                    {
                        mCANoeMeasurement.Stop();
                        return 0;
                    }
                    else
                    {
                        mCANoeMeasurement.Start();
                        return 1;
                    }
                }
                return 2;
            }
            catch
            {
                return -1;
            }
        }
        #endregion

        #region 关闭CANoe
        public bool CloseCANoe()
        {
            try
            {
                if (mCANoeApp != null)
                {
                    if (mCANoeMeasurement != null)
                    {
                        if (mCANoeMeasurement.Running)
                        {
                            mCANoeMeasurement.Stop();
                        }
                    }
                }
                mCANoeApp.Quit();
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region 获得所有交互变量
        public void GetAllMutualVar()
        {
            CANoeSystem = (CANoe.System)mCANoeApp.System;
            CANoeNamespaces = (CANoe.Namespaces)CANoeSystem.Namespaces;
            CANoeNamespaceGeneral = (CANoe.Namespace)CANoeNamespaces["mutualVar"];
            CANoeVariablesGeneral = (CANoe.Variables)CANoeNamespaceGeneral.Variables;
            _startDeviceSelfCheck = (CANoe.Variable)CANoeVariablesGeneral["startDeviceSelfCheck"];
            deviceSelfCheckResult = (CANoe.Variable)CANoeVariablesGeneral["deviceSelfCheckResult"];
            startPrototypeSelfCheck = (CANoe.Variable)CANoeVariablesGeneral["startPrototypeSelfCheck"];
            prototypeSelfCheckResult = (CANoe.Variable)CANoeVariablesGeneral["prototypeSelfCheckResult"];
            exampleCode = (CANoe.Variable)CANoeVariablesGeneral["exampleCode"];
            exampleResult = (CANoe.Variable)CANoeVariablesGeneral["exampleResult"];
            processingPrompt = (CANoe.Variable)CANoeVariablesGeneral["processingPrompt"];
            deviceSelfCheckResult = (CANoe.Variable)CANoeVariablesGeneral["deviceSelfCheckResult"];
        }

        #endregion

        #region 获得某个变量值
        public string GetMutualVarValue(string varName)
        {
            switch (varName)
            {
                case "startDeviceSelfCheck":
                    _startDeviceSelfCheck = (CANoe.Variable)CANoeVariablesGeneral["startDeviceSelfCheck"];
                    return _startDeviceSelfCheck.Value;
            }
            return "";
        }

        #endregion

        #region 设置某个变量值
        public bool SetMutualVarValue(string varName, string varValue)
        {
            switch (varName)
            {
                case "startDeviceSelfCheck":
                    _startDeviceSelfCheck.Value = varValue;
                    return true;
            }
            return false;
        }
        #endregion
    }
}