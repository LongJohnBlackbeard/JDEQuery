using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L101 - .
/// </summary>
public class FF30L101 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FMMMFID.
        /// </summary>
        public const string FMMMFID = "FMMMFID";

        /// <summary>
        /// FMFSCID.
        /// </summary>
        public const string FMFSCID = "FMFSCID";

        /// <summary>
        /// FMMFN.
        /// </summary>
        public const string FMMFN = "FMMFN";

        /// <summary>
        /// FMDFMCU.
        /// </summary>
        public const string FMDFMCU = "FMDFMCU";

        /// <summary>
        /// FMMMFDSC.
        /// </summary>
        public const string FMMMFDSC = "FMMMFDSC";

        /// <summary>
        /// FMURCD.
        /// </summary>
        public const string FMURCD = "FMURCD";

        /// <summary>
        /// FMURDT.
        /// </summary>
        public const string FMURDT = "FMURDT";

        /// <summary>
        /// FMURAT.
        /// </summary>
        public const string FMURAT = "FMURAT";

        /// <summary>
        /// FMURAB.
        /// </summary>
        public const string FMURAB = "FMURAB";

        /// <summary>
        /// FMURRF.
        /// </summary>
        public const string FMURRF = "FMURRF";

        /// <summary>
        /// FMUSER.
        /// </summary>
        public const string FMUSER = "FMUSER";

        /// <summary>
        /// FMPID.
        /// </summary>
        public const string FMPID = "FMPID";

        /// <summary>
        /// FMMKEY.
        /// </summary>
        public const string FMMKEY = "FMMKEY";

        /// <summary>
        /// FMUUPMJ.
        /// </summary>
        public const string FMUUPMJ = "FMUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L101";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FMMMFID", "FMMMFID", JdeDataType.Numeric, null, true, true),
        new JdeField("FMFSCID", "FMFSCID", JdeDataType.Numeric),
        new JdeField("FMMFN", "FMMFN", JdeDataType.String, 50),
        new JdeField("FMDFMCU", "FMDFMCU", JdeDataType.String, 24),
        new JdeField("FMMMFDSC", "FMMMFDSC", JdeDataType.String, 160),
        new JdeField("FMURCD", "FMURCD", JdeDataType.String, 4),
        new JdeField("FMURDT", "FMURDT", JdeDataType.Numeric),
        new JdeField("FMURAT", "FMURAT", JdeDataType.Numeric),
        new JdeField("FMURAB", "FMURAB", JdeDataType.Numeric),
        new JdeField("FMURRF", "FMURRF", JdeDataType.String, 30),
        new JdeField("FMUSER", "FMUSER", JdeDataType.String, 20),
        new JdeField("FMPID", "FMPID", JdeDataType.String, 20),
        new JdeField("FMMKEY", "FMMKEY", JdeDataType.String, 30),
        new JdeField("FMUUPMJ", "FMUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L101_0", "Primary Key on FMMMFID", new[] { "FMMMFID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L101_2", "Unique Index on FMMFN, FMFSCID", new[] { "FMMFN", "FMFSCID" }, isUnique: true),
        new JdeIndex("FF30L101_3", "Index on FMFSCID", new[] { "FMFSCID" })
    };
}
