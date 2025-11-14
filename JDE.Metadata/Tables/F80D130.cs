using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D130 - .
/// </summary>
public class F80D130 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CMALERT.
        /// </summary>
        public const string CMALERT = "CMALERT";

        /// <summary>
        /// CMKEY1DTAI.
        /// </summary>
        public const string CMKEY1DTAI = "CMKEY1DTAI";

        /// <summary>
        /// CMKEY2DTAI.
        /// </summary>
        public const string CMKEY2DTAI = "CMKEY2DTAI";

        /// <summary>
        /// CMKEY3DTAI.
        /// </summary>
        public const string CMKEY3DTAI = "CMKEY3DTAI";

        /// <summary>
        /// CMKEY4DTAI.
        /// </summary>
        public const string CMKEY4DTAI = "CMKEY4DTAI";

        /// <summary>
        /// CMKEY5DTAI.
        /// </summary>
        public const string CMKEY5DTAI = "CMKEY5DTAI";

        /// <summary>
        /// CMKEY6DTAI.
        /// </summary>
        public const string CMKEY6DTAI = "CMKEY6DTAI";

        /// <summary>
        /// CMKEY7DTAI.
        /// </summary>
        public const string CMKEY7DTAI = "CMKEY7DTAI";

        /// <summary>
        /// CMKEY8DTAI.
        /// </summary>
        public const string CMKEY8DTAI = "CMKEY8DTAI";

        /// <summary>
        /// CMKEY9DTAI.
        /// </summary>
        public const string CMKEY9DTAI = "CMKEY9DTAI";

        /// <summary>
        /// CMKEY0DTAI.
        /// </summary>
        public const string CMKEY0DTAI = "CMKEY0DTAI";

        /// <summary>
        /// CMURCD.
        /// </summary>
        public const string CMURCD = "CMURCD";

        /// <summary>
        /// CMURDT.
        /// </summary>
        public const string CMURDT = "CMURDT";

        /// <summary>
        /// CMURAT.
        /// </summary>
        public const string CMURAT = "CMURAT";

        /// <summary>
        /// CMURAB.
        /// </summary>
        public const string CMURAB = "CMURAB";

        /// <summary>
        /// CMURRF.
        /// </summary>
        public const string CMURRF = "CMURRF";

        /// <summary>
        /// CMUSER.
        /// </summary>
        public const string CMUSER = "CMUSER";

        /// <summary>
        /// CMMKEY.
        /// </summary>
        public const string CMMKEY = "CMMKEY";

        /// <summary>
        /// CMPID.
        /// </summary>
        public const string CMPID = "CMPID";

        /// <summary>
        /// CMUUPMJ.
        /// </summary>
        public const string CMUUPMJ = "CMUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F80D130";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CMALERT", "CMALERT", JdeDataType.Numeric, null, true, true),
        new JdeField("CMKEY1DTAI", "CMKEY1DTAI", JdeDataType.String, 20),
        new JdeField("CMKEY2DTAI", "CMKEY2DTAI", JdeDataType.String, 20),
        new JdeField("CMKEY3DTAI", "CMKEY3DTAI", JdeDataType.String, 20),
        new JdeField("CMKEY4DTAI", "CMKEY4DTAI", JdeDataType.String, 20),
        new JdeField("CMKEY5DTAI", "CMKEY5DTAI", JdeDataType.String, 20),
        new JdeField("CMKEY6DTAI", "CMKEY6DTAI", JdeDataType.String, 20),
        new JdeField("CMKEY7DTAI", "CMKEY7DTAI", JdeDataType.String, 20),
        new JdeField("CMKEY8DTAI", "CMKEY8DTAI", JdeDataType.String, 20),
        new JdeField("CMKEY9DTAI", "CMKEY9DTAI", JdeDataType.String, 20),
        new JdeField("CMKEY0DTAI", "CMKEY0DTAI", JdeDataType.String, 20),
        new JdeField("CMURCD", "CMURCD", JdeDataType.String, 4),
        new JdeField("CMURDT", "CMURDT", JdeDataType.Numeric),
        new JdeField("CMURAT", "CMURAT", JdeDataType.Numeric),
        new JdeField("CMURAB", "CMURAB", JdeDataType.Numeric),
        new JdeField("CMURRF", "CMURRF", JdeDataType.String, 30),
        new JdeField("CMUSER", "CMUSER", JdeDataType.String, 20),
        new JdeField("CMMKEY", "CMMKEY", JdeDataType.String, 30),
        new JdeField("CMPID", "CMPID", JdeDataType.String, 20),
        new JdeField("CMUUPMJ", "CMUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D130_0", "Primary Key on CMALERT", new[] { "CMALERT" }, isUnique: true, isPrimaryKey: true)
    };
}
