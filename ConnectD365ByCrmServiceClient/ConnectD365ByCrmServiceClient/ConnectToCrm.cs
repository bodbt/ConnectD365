using Microsoft.Xrm.Tooling.Connector;
using System;

namespace ConnectD365ByCrmServiceClient
{
    class ConnectToCRM
    {
        public static CrmServiceClient ConnectWithOffice365()
        {
            // Dynamics CRM Webサービスの生成
            var connectionString = "Url=https://nt20200626.crm7.dynamics.com;"
                + "AuthType=Office365;"
                + "UserName=admin@nt20200626.onmicrosoft.com;"
                + "Password=Password1234;";

            var con = new CrmServiceClient(connectionString);

            if (!con.IsReady)
            {

                string message = string.Format(@"対象組織へ接続できません。{0}{1}{2}{3}",
                                  Environment.NewLine,
                                  con.LastCrmError,
                                  Environment.NewLine,
                                  con.LastCrmException);
                throw con.LastCrmException;
            }

            return con;
        }

        public static CrmServiceClient ConnectWithOAuth()
        {
            // Dynamics CRM Webサービスの生成
            var connectionString = "Url=https://nt20200626.crm7.dynamics.com;"
                + "AuthType=OAuth;"
                + "UserName=batchuser@nt20200626.onmicrosoft.com;"
                + "Password=P@ssw0rd;"
                + "AppId=51f81489-12ee-4a9e-aaae-a2591f45987d;" // 固定値 for prototype or develepment
                + "RedirectUri=app://58145B91-0C36-4500-8554-080854F2AC97;" //固定値 for prototype or develepment
                + "TokenCacheStorePath=.\\cache.txt;"
                + "LoginPrompt=Auto";

            // TODO how to create a OAuth Flow for Production?

            var con = new CrmServiceClient(connectionString);

            if (!con.IsReady)
            {

                string message = string.Format(@"対象組織へ接続できません。{0}{1}{2}{3}",
                                  Environment.NewLine,
                                  con.LastCrmError,
                                  Environment.NewLine,
                                  con.LastCrmException);
                throw con.LastCrmException;
            }

            return con;
        }

        public static CrmServiceClient ConnectWithClientSecret()
        {
            // Dynamics CRM Webサービスの生成
            var connectionString = "Url=https://nt20200626.crm7.dynamics.com;"
                + "AuthType=ClientSecret;"
                + "Clientid=f0b3a05e-a1b0-4a02-b7f1-bc18b75a903f;"
                + "ClientSecret=u~0X_JDm4.6.Uv4Nys_wk9ToW7ZrM.Ax1A";

            var con = new CrmServiceClient(connectionString);

            if (!con.IsReady)
            {

                string message = string.Format(@"対象組織へ接続できません。{0}{1}{2}{3}",
                                  Environment.NewLine,
                                  con.LastCrmError,
                                  Environment.NewLine,
                                  con.LastCrmException);
                throw con.LastCrmException;
            }

            return con;
        }
    }
}
