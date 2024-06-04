using System.Collections;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class LocaleSelector : MonoBehaviour
{
    private bool activeLocale = false;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="localeID"></param>
    public void ChangeLocale(int localeID)
    {
        if (activeLocale)
            return;
        StartCoroutine(SetLocale(localeID));
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="_localeID"></param>
    /// <returns></returns>
    IEnumerator SetLocale(int _localeID)
    {
        activeLocale = true;
        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[_localeID];
        activeLocale = false;
    }
}
