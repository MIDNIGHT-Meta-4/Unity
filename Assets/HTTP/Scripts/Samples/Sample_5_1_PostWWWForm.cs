using System.Collections;
using UnityEngine;

namespace HTTP
{
    public class Sample_5_1_PostWWWForm : Sample_Base
    {
        protected override IEnumerator RequestProcess()
        {
            using var webRequest = API_5_PostForm.CreateWebRequestWithWWWForm("test1", "test2", "test3", "test4");
            // requestTextUI.text = webRequest.uri.ToString();
            Debug.Log(webRequest.uri.ToString());
            yield return webRequest.SendWebRequest();

            if (ApiBase.ErrorHandling(webRequest))
            {
                yield break;
            }
            
            var result = ApiBase.GetResultFromJson<API_5_PostForm.Result>(webRequest);
            Debug.Log(result.ToString());
        }
    }
}