using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48127 - .
/// </summary>
public class F48127 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WOGTYP.
        /// </summary>
        public const string WOGTYP = "WOGTYP";

        /// <summary>
        /// WOTYKY.
        /// </summary>
        public const string WOTYKY = "WOTYKY";

        /// <summary>
        /// WOTKEY.
        /// </summary>
        public const string WOTKEY = "WOTKEY";

        /// <summary>
        /// WOEFTB.
        /// </summary>
        public const string WOEFTB = "WOEFTB";

        /// <summary>
        /// WOEFTE.
        /// </summary>
        public const string WOEFTE = "WOEFTE";

        /// <summary>
        /// WOOBJ.
        /// </summary>
        public const string WOOBJ = "WOOBJ";

        /// <summary>
        /// WOOBJT.
        /// </summary>
        public const string WOOBJT = "WOOBJT";

        /// <summary>
        /// WOSUB.
        /// </summary>
        public const string WOSUB = "WOSUB";

        /// <summary>
        /// WOSUBT.
        /// </summary>
        public const string WOSUBT = "WOSUBT";

        /// <summary>
        /// WOTXA1.
        /// </summary>
        public const string WOTXA1 = "WOTXA1";

        /// <summary>
        /// WOEXR1.
        /// </summary>
        public const string WOEXR1 = "WOEXR1";

        /// <summary>
        /// WOTOG.
        /// </summary>
        public const string WOTOG = "WOTOG";

        /// <summary>
        /// WOUKID.
        /// </summary>
        public const string WOUKID = "WOUKID";

        /// <summary>
        /// WOUPMJ.
        /// </summary>
        public const string WOUPMJ = "WOUPMJ";

        /// <summary>
        /// WOUPMT.
        /// </summary>
        public const string WOUPMT = "WOUPMT";

        /// <summary>
        /// WOPID.
        /// </summary>
        public const string WOPID = "WOPID";

        /// <summary>
        /// WOJOBN.
        /// </summary>
        public const string WOJOBN = "WOJOBN";

        /// <summary>
        /// WOUSER.
        /// </summary>
        public const string WOUSER = "WOUSER";

        /// <summary>
        /// WOVVTY.
        /// </summary>
        public const string WOVVTY = "WOVVTY";

        /// <summary>
        /// WOVVTC.
        /// </summary>
        public const string WOVVTC = "WOVVTC";
    }

    /// <inheritdoc />
    public override string TableName => "F48127";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WOGTYP", "WOGTYP", JdeDataType.String, 2),
        new JdeField("WOTYKY", "WOTYKY", JdeDataType.String, 2),
        new JdeField("WOTKEY", "WOTKEY", JdeDataType.String, 24),
        new JdeField("WOEFTB", "WOEFTB", JdeDataType.Numeric),
        new JdeField("WOEFTE", "WOEFTE", JdeDataType.Numeric),
        new JdeField("WOOBJ", "WOOBJ", JdeDataType.String, 12),
        new JdeField("WOOBJT", "WOOBJT", JdeDataType.String, 12),
        new JdeField("WOSUB", "WOSUB", JdeDataType.String, 16),
        new JdeField("WOSUBT", "WOSUBT", JdeDataType.String, 16),
        new JdeField("WOTXA1", "WOTXA1", JdeDataType.String, 20),
        new JdeField("WOEXR1", "WOEXR1", JdeDataType.String, 4),
        new JdeField("WOTOG", "WOTOG", JdeDataType.String, 2),
        new JdeField("WOUKID", "WOUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("WOUPMJ", "WOUPMJ", JdeDataType.Numeric),
        new JdeField("WOUPMT", "WOUPMT", JdeDataType.Numeric),
        new JdeField("WOPID", "WOPID", JdeDataType.String, 20),
        new JdeField("WOJOBN", "WOJOBN", JdeDataType.String, 20),
        new JdeField("WOUSER", "WOUSER", JdeDataType.String, 20),
        new JdeField("WOVVTY", "WOVVTY", JdeDataType.String, 12),
        new JdeField("WOVVTC", "WOVVTC", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48127_0", "Primary Key on WOUKID", new[] { "WOUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F48127_2", "Index on WOTYKY, WOTKEY, WOEFTB, WOOBJT, WOSUBT", new[] { "WOTYKY", "WOTKEY", "WOEFTB", "WOOBJT", "WOSUBT" }),
        new JdeIndex("F48127_3", "Index on WOTYKY, WOTKEY, WOEFTB, WOSUBT, WOOBJT", new[] { "WOTYKY", "WOTKEY", "WOEFTB", "WOSUBT", "WOOBJT" }),
        new JdeIndex("F48127_4", "Index on WOTYKY, WOTKEY, WOEFTB, WOOBJ, WOOBJT, WOSUB, WOSUBT", new[] { "WOTYKY", "WOTKEY", "WOEFTB", "WOOBJ", "WOOBJT", "WOSUB", "WOSUBT" }),
        new JdeIndex("F48127_5", "Index on WOTYKY, WOTKEY, WOEFTB, WOEFTE", new[] { "WOTYKY", "WOTKEY", "WOEFTB", "WOEFTE" })
    };
}
