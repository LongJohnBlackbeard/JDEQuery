using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76011 - .
/// </summary>
public class F76011 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AIAN8.
        /// </summary>
        public const string AIAN8 = "AIAN8";

        /// <summary>
        /// AIBMUN.
        /// </summary>
        public const string AIBMUN = "AIBMUN";

        /// <summary>
        /// AIBICC.
        /// </summary>
        public const string AIBICC = "AIBICC";

        /// <summary>
        /// AIBIST.
        /// </summary>
        public const string AIBIST = "AIBIST";

        /// <summary>
        /// AIBIRP.
        /// </summary>
        public const string AIBIRP = "AIBIRP";

        /// <summary>
        /// AIBFII.
        /// </summary>
        public const string AIBFII = "AIBFII";

        /// <summary>
        /// AIBFIP.
        /// </summary>
        public const string AIBFIP = "AIBFIP";

        /// <summary>
        /// AIBFIS.
        /// </summary>
        public const string AIBFIS = "AIBFIS";

        /// <summary>
        /// AIBZFR.
        /// </summary>
        public const string AIBZFR = "AIBZFR";

        /// <summary>
        /// AIBISC.
        /// </summary>
        public const string AIBISC = "AIBISC";

        /// <summary>
        /// AIBCPF.
        /// </summary>
        public const string AIBCPF = "AIBCPF";

        /// <summary>
        /// AIBRG.
        /// </summary>
        public const string AIBRG = "AIBRG";

        /// <summary>
        /// AIBSOE.
        /// </summary>
        public const string AIBSOE = "AIBSOE";

        /// <summary>
        /// AIADDS.
        /// </summary>
        public const string AIADDS = "AIADDS";

        /// <summary>
        /// AIBAUT.
        /// </summary>
        public const string AIBAUT = "AIBAUT";

        /// <summary>
        /// AICTY1.
        /// </summary>
        public const string AICTY1 = "AICTY1";

        /// <summary>
        /// AISTCD.
        /// </summary>
        public const string AISTCD = "AISTCD";

        /// <summary>
        /// AIBNOP.
        /// </summary>
        public const string AIBNOP = "AIBNOP";

        /// <summary>
        /// AIBSOP.
        /// </summary>
        public const string AIBSOP = "AIBSOP";

        /// <summary>
        /// AIEPDJ.
        /// </summary>
        public const string AIEPDJ = "AIEPDJ";

        /// <summary>
        /// AITORG.
        /// </summary>
        public const string AITORG = "AITORG";

        /// <summary>
        /// AIUSER.
        /// </summary>
        public const string AIUSER = "AIUSER";

        /// <summary>
        /// AIPID.
        /// </summary>
        public const string AIPID = "AIPID";

        /// <summary>
        /// AIJOBN.
        /// </summary>
        public const string AIJOBN = "AIJOBN";

        /// <summary>
        /// AIUPMJ.
        /// </summary>
        public const string AIUPMJ = "AIUPMJ";

        /// <summary>
        /// AITDAY.
        /// </summary>
        public const string AITDAY = "AITDAY";

        /// <summary>
        /// AIBRTAX1.
        /// </summary>
        public const string AIBRTAX1 = "AIBRTAX1";

        /// <summary>
        /// AIBRTAX2.
        /// </summary>
        public const string AIBRTAX2 = "AIBRTAX2";

        /// <summary>
        /// AIBRTAX3.
        /// </summary>
        public const string AIBRTAX3 = "AIBRTAX3";

        /// <summary>
        /// AIBRTAX4.
        /// </summary>
        public const string AIBRTAX4 = "AIBRTAX4";

        /// <summary>
        /// AIBRTAX5.
        /// </summary>
        public const string AIBRTAX5 = "AIBRTAX5";

        /// <summary>
        /// AIBRTAX6.
        /// </summary>
        public const string AIBRTAX6 = "AIBRTAX6";

        /// <summary>
        /// AIBRTAX7.
        /// </summary>
        public const string AIBRTAX7 = "AIBRTAX7";

        /// <summary>
        /// AIBRTAX8.
        /// </summary>
        public const string AIBRTAX8 = "AIBRTAX8";

        /// <summary>
        /// AIBRIINS.
        /// </summary>
        public const string AIBRIINS = "AIBRIINS";
    }

    /// <inheritdoc />
    public override string TableName => "F76011";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AIAN8", "AIAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("AIBMUN", "AIBMUN", JdeDataType.String, 24),
        new JdeField("AIBICC", "AIBICC", JdeDataType.String, 2),
        new JdeField("AIBIST", "AIBIST", JdeDataType.String, 2),
        new JdeField("AIBIRP", "AIBIRP", JdeDataType.String, 2),
        new JdeField("AIBFII", "AIBFII", JdeDataType.String, 2),
        new JdeField("AIBFIP", "AIBFIP", JdeDataType.String, 2),
        new JdeField("AIBFIS", "AIBFIS", JdeDataType.String, 2),
        new JdeField("AIBZFR", "AIBZFR", JdeDataType.String, 2),
        new JdeField("AIBISC", "AIBISC", JdeDataType.String, 60),
        new JdeField("AIBCPF", "AIBCPF", JdeDataType.String, 22),
        new JdeField("AIBRG", "AIBRG", JdeDataType.String, 18),
        new JdeField("AIBSOE", "AIBSOE", JdeDataType.String, 10),
        new JdeField("AIADDS", "AIADDS", JdeDataType.String, 6),
        new JdeField("AIBAUT", "AIBAUT", JdeDataType.String, 24),
        new JdeField("AICTY1", "AICTY1", JdeDataType.String, 50),
        new JdeField("AISTCD", "AISTCD", JdeDataType.String, 6),
        new JdeField("AIBNOP", "AIBNOP", JdeDataType.Numeric),
        new JdeField("AIBSOP", "AIBSOP", JdeDataType.String, 4),
        new JdeField("AIEPDJ", "AIEPDJ", JdeDataType.Numeric),
        new JdeField("AITORG", "AITORG", JdeDataType.String, 20),
        new JdeField("AIUSER", "AIUSER", JdeDataType.String, 20),
        new JdeField("AIPID", "AIPID", JdeDataType.String, 20),
        new JdeField("AIJOBN", "AIJOBN", JdeDataType.String, 20),
        new JdeField("AIUPMJ", "AIUPMJ", JdeDataType.Numeric),
        new JdeField("AITDAY", "AITDAY", JdeDataType.Numeric),
        new JdeField("AIBRTAX1", "AIBRTAX1", JdeDataType.String, 16),
        new JdeField("AIBRTAX2", "AIBRTAX2", JdeDataType.String, 16),
        new JdeField("AIBRTAX3", "AIBRTAX3", JdeDataType.String, 16),
        new JdeField("AIBRTAX4", "AIBRTAX4", JdeDataType.String, 16),
        new JdeField("AIBRTAX5", "AIBRTAX5", JdeDataType.String, 16),
        new JdeField("AIBRTAX6", "AIBRTAX6", JdeDataType.String, 16),
        new JdeField("AIBRTAX7", "AIBRTAX7", JdeDataType.String, 16),
        new JdeField("AIBRTAX8", "AIBRTAX8", JdeDataType.String, 16),
        new JdeField("AIBRIINS", "AIBRIINS", JdeDataType.String, 40)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76011_0", "Primary Key on AIAN8", new[] { "AIAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76011_2", "Index on AIBCPF", new[] { "AIBCPF" })
    };
}
