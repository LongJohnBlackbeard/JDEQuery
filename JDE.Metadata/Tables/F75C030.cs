using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75C030 - .
/// </summary>
public class F75C030 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ABUKID.
        /// </summary>
        public const string ABUKID = "ABUKID";

        /// <summary>
        /// ABC75CBNK.
        /// </summary>
        public const string ABC75CBNK = "ABC75CBNK";

        /// <summary>
        /// ABTXF1.
        /// </summary>
        public const string ABTXF1 = "ABTXF1";

        /// <summary>
        /// ABFFU3.
        /// </summary>
        public const string ABFFU3 = "ABFFU3";

        /// <summary>
        /// ABFFU4.
        /// </summary>
        public const string ABFFU4 = "ABFFU4";

        /// <summary>
        /// ABGPF1.
        /// </summary>
        public const string ABGPF1 = "ABGPF1";

        /// <summary>
        /// ABDATF01.
        /// </summary>
        public const string ABDATF01 = "ABDATF01";

        /// <summary>
        /// ABUSER.
        /// </summary>
        public const string ABUSER = "ABUSER";

        /// <summary>
        /// ABPID.
        /// </summary>
        public const string ABPID = "ABPID";

        /// <summary>
        /// ABJOBN.
        /// </summary>
        public const string ABJOBN = "ABJOBN";

        /// <summary>
        /// ABUPMJ.
        /// </summary>
        public const string ABUPMJ = "ABUPMJ";

        /// <summary>
        /// ABUPMT.
        /// </summary>
        public const string ABUPMT = "ABUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75C030";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ABUKID", "ABUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("ABC75CBNK", "ABC75CBNK", JdeDataType.String, 100),
        new JdeField("ABTXF1", "ABTXF1", JdeDataType.String, 20),
        new JdeField("ABFFU3", "ABFFU3", JdeDataType.String, 20),
        new JdeField("ABFFU4", "ABFFU4", JdeDataType.Numeric),
        new JdeField("ABGPF1", "ABGPF1", JdeDataType.String, 2),
        new JdeField("ABDATF01", "ABDATF01", JdeDataType.Numeric),
        new JdeField("ABUSER", "ABUSER", JdeDataType.String, 20),
        new JdeField("ABPID", "ABPID", JdeDataType.String, 20),
        new JdeField("ABJOBN", "ABJOBN", JdeDataType.String, 20),
        new JdeField("ABUPMJ", "ABUPMJ", JdeDataType.Numeric),
        new JdeField("ABUPMT", "ABUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75C030_0", "Primary Key on ABUKID", new[] { "ABUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
