// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Japanese.cs" company="SyndicatedLife">
//   Copyright(c) 2018 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (http://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   Japanese.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FFXIVAPP.Plugin.Log.Localization {
    using System.Windows;

    public abstract class Japanese {
        private static readonly ResourceDictionary Dictionary = new ResourceDictionary();

        /// <summary>
        /// </summary>
        /// <returns> </returns>
        public static ResourceDictionary Context() {
            Dictionary.Clear();
            Dictionary.Add("log_", "*PH*");
            Dictionary.Add("log_AddTabButtonText", "タブを追加する");
            Dictionary.Add("log_AllTabHeader", "全て");
            Dictionary.Add("log_DebugTabHeader", "デバッグ");
            Dictionary.Add("log_DebugOptionsHeader", "デバッグオプション");
            Dictionary.Add("log_EnableDebugHeader", "デバッグ情報を表示する");
            Dictionary.Add("log_EnableTranslateHeader", "チャットを翻訳する");
            Dictionary.Add("log_RegExLabel", "正規表現:");
            Dictionary.Add("log_UseRomanizationHeader", "ローマ字を利用する");
            Dictionary.Add("log_ShowASCIIDebugHeader", "ASCIIコードを表示する (デバッグ用)");
            Dictionary.Add("log_TabNameLabel", "タブ名:");
            Dictionary.Add("log_TranslateLSHeader", "LSチャットを翻訳する");
            Dictionary.Add("log_TranslateFCHeader", "FCチャットを翻訳する");
            Dictionary.Add("log_TranslatePartyHeader", "Partyチャットを翻訳する");
            Dictionary.Add("log_TranslateableChatTabHeader", "チャット翻訳対象");
            Dictionary.Add("log_TranslatedTabHeader", "翻訳");
            Dictionary.Add("log_TranslateJPOnlyHeader", "日本語のみ翻訳する");
            Dictionary.Add("log_TranslateSettingsTabHeader", "翻訳オプション");
            Dictionary.Add("log_TranslateToHeader", "翻訳先言語");
            Dictionary.Add("log_TranslateSayHeader", "Sayを翻訳する");
            Dictionary.Add("log_TranslateShoutHeader", "Shoutを翻訳する");
            Dictionary.Add("log_TranslateTellHeader", "Tellを翻訳する");
            Dictionary.Add("log_TranslateYellHeader", "Yellを翻訳する");
            Dictionary.Add("log_EnableAllHeader", "すべて有効にする");
            Dictionary.Add("log_TranslateAllianceHeader", "アライアンスチャットを翻訳する");
            Dictionary.Add("log_GitHubButtonText", "プロジェクトのソースを開く（GitHub）");

            Dictionary.Add("log_OpenNowButtonText", "直ちに開く");
            Dictionary.Add("log_ResetPositionButtonText", "設定をリセット");
            Dictionary.Add("log_TranslationTitleBar", "[翻訳]");
            Dictionary.Add("log_TranslationWidgetHeader", "翻訳ウィジェット");
            Dictionary.Add("log_EnableClickThroughHeader", "ウィジェットのクリックを透過する");
            Dictionary.Add("log_WidgetOpacityHeader", "ウィジェットの透過度");
            Dictionary.Add("log_ShowTitlesOnWidgetsHeader", "ウィジェットにタイトルを表示");
            Dictionary.Add("log_UIScaleHeader", "UI拡大率");
            Dictionary.Add("log_WidgetSettingsTabHeader", "ウィジェット設定");
            Dictionary.Add("log_TranslationWidgetSettingsTabLabel", "設定：翻訳");
            return Dictionary;
        }
    }
}