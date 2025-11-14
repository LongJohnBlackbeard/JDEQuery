using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3211 - .
/// </summary>
public class F3211 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KZCFGID.
        /// </summary>
        public const string KZCFGID = "KZCFGID";

        /// <summary>
        /// KZCFGCID.
        /// </summary>
        public const string KZCFGCID = "KZCFGCID";

        /// <summary>
        /// KZPEL.
        /// </summary>
        public const string KZPEL = "KZPEL";

        /// <summary>
        /// KZSGVL.
        /// </summary>
        public const string KZSGVL = "KZSGVL";

        /// <summary>
        /// KZKIT.
        /// </summary>
        public const string KZKIT = "KZKIT";

        /// <summary>
        /// KZCFGSID.
        /// </summary>
        public const string KZCFGSID = "KZCFGSID";

        /// <summary>
        /// KZATSA.
        /// </summary>
        public const string KZATSA = "KZATSA";

        /// <summary>
        /// KZCNUM.
        /// </summary>
        public const string KZCNUM = "KZCNUM";

        /// <summary>
        /// KZURCD.
        /// </summary>
        public const string KZURCD = "KZURCD";

        /// <summary>
        /// KZURDT.
        /// </summary>
        public const string KZURDT = "KZURDT";

        /// <summary>
        /// KZURAT.
        /// </summary>
        public const string KZURAT = "KZURAT";

        /// <summary>
        /// KZURAB.
        /// </summary>
        public const string KZURAB = "KZURAB";

        /// <summary>
        /// KZURRF.
        /// </summary>
        public const string KZURRF = "KZURRF";

        /// <summary>
        /// KZUSER.
        /// </summary>
        public const string KZUSER = "KZUSER";

        /// <summary>
        /// KZPID.
        /// </summary>
        public const string KZPID = "KZPID";

        /// <summary>
        /// KZJOBN.
        /// </summary>
        public const string KZJOBN = "KZJOBN";

        /// <summary>
        /// KZUPMJ.
        /// </summary>
        public const string KZUPMJ = "KZUPMJ";

        /// <summary>
        /// KZTDAY.
        /// </summary>
        public const string KZTDAY = "KZTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F3211";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KZCFGID", "KZCFGID", JdeDataType.Numeric, null, true, true),
        new JdeField("KZCFGCID", "KZCFGCID", JdeDataType.Numeric, null, true, true),
        new JdeField("KZPEL", "KZPEL", JdeDataType.Numeric, null, true, true),
        new JdeField("KZSGVL", "KZSGVL", JdeDataType.String, 80, true, true),
        new JdeField("KZKIT", "KZKIT", JdeDataType.Numeric, null, true, true),
        new JdeField("KZCFGSID", "KZCFGSID", JdeDataType.String, 64, true, true),
        new JdeField("KZATSA", "KZATSA", JdeDataType.String, 2),
        new JdeField("KZCNUM", "KZCNUM", JdeDataType.String, 2),
        new JdeField("KZURCD", "KZURCD", JdeDataType.String, 4),
        new JdeField("KZURDT", "KZURDT", JdeDataType.Numeric),
        new JdeField("KZURAT", "KZURAT", JdeDataType.Numeric),
        new JdeField("KZURAB", "KZURAB", JdeDataType.Numeric),
        new JdeField("KZURRF", "KZURRF", JdeDataType.String, 30),
        new JdeField("KZUSER", "KZUSER", JdeDataType.String, 20),
        new JdeField("KZPID", "KZPID", JdeDataType.String, 20),
        new JdeField("KZJOBN", "KZJOBN", JdeDataType.String, 20),
        new JdeField("KZUPMJ", "KZUPMJ", JdeDataType.Numeric),
        new JdeField("KZTDAY", "KZTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3211_0", "Primary Key on KZCFGID, KZCFGCID, KZPEL, KZSGVL, KZKIT, KZCFGSID", new[] { "KZCFGID", "KZCFGCID", "KZPEL", "KZSGVL", "KZKIT", "KZCFGSID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3211_2", "Index on KZCFGID, KZKIT, KZCFGSID", new[] { "KZCFGID", "KZKIT", "KZCFGSID" }),
        new JdeIndex("F3211_3", "Index on KZCFGID, KZCFGSID", new[] { "KZCFGID", "KZCFGSID" })
    };
}
