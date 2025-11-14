using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75C012 - .
/// </summary>
public class F75C012 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ABAN8.
        /// </summary>
        public const string ABAN8 = "ABAN8";

        /// <summary>
        /// ABC75SNAM.
        /// </summary>
        public const string ABC75SNAM = "ABC75SNAM";

        /// <summary>
        /// ABFUT1.
        /// </summary>
        public const string ABFUT1 = "ABFUT1";

        /// <summary>
        /// ABFUT2.
        /// </summary>
        public const string ABFUT2 = "ABFUT2";

        /// <summary>
        /// ABFUT3.
        /// </summary>
        public const string ABFUT3 = "ABFUT3";

        /// <summary>
        /// ABFUT4.
        /// </summary>
        public const string ABFUT4 = "ABFUT4";

        /// <summary>
        /// ABFUT5.
        /// </summary>
        public const string ABFUT5 = "ABFUT5";

        /// <summary>
        /// ABFUTDATE1.
        /// </summary>
        public const string ABFUTDATE1 = "ABFUTDATE1";

        /// <summary>
        /// ABFUTANON1.
        /// </summary>
        public const string ABFUTANON1 = "ABFUTANON1";

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
    public override string TableName => "F75C012";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ABAN8", "ABAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ABC75SNAM", "ABC75SNAM", JdeDataType.String, 120),
        new JdeField("ABFUT1", "ABFUT1", JdeDataType.Numeric),
        new JdeField("ABFUT2", "ABFUT2", JdeDataType.Numeric),
        new JdeField("ABFUT3", "ABFUT3", JdeDataType.String, 60),
        new JdeField("ABFUT4", "ABFUT4", JdeDataType.String, 50),
        new JdeField("ABFUT5", "ABFUT5", JdeDataType.String, 50),
        new JdeField("ABFUTDATE1", "ABFUTDATE1", JdeDataType.Numeric),
        new JdeField("ABFUTANON1", "ABFUTANON1", JdeDataType.String, 2),
        new JdeField("ABUSER", "ABUSER", JdeDataType.String, 20),
        new JdeField("ABPID", "ABPID", JdeDataType.String, 20),
        new JdeField("ABJOBN", "ABJOBN", JdeDataType.String, 20),
        new JdeField("ABUPMJ", "ABUPMJ", JdeDataType.Numeric),
        new JdeField("ABUPMT", "ABUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75C012_0", "Primary Key on ABAN8", new[] { "ABAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
