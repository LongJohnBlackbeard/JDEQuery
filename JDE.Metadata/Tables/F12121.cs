using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F12121 - .
/// </summary>
public class F12121 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ETUKID.
        /// </summary>
        public const string ETUKID = "ETUKID";

        /// <summary>
        /// ETTEMPNAME.
        /// </summary>
        public const string ETTEMPNAME = "ETTEMPNAME";

        /// <summary>
        /// ETTDESC.
        /// </summary>
        public const string ETTDESC = "ETTDESC";

        /// <summary>
        /// ETTDESC1.
        /// </summary>
        public const string ETTDESC1 = "ETTDESC1";

        /// <summary>
        /// ETODOMYN.
        /// </summary>
        public const string ETODOMYN = "ETODOMYN";

        /// <summary>
        /// ETFUELYN.
        /// </summary>
        public const string ETFUELYN = "ETFUELYN";

        /// <summary>
        /// ETHOURYN.
        /// </summary>
        public const string ETHOURYN = "ETHOURYN";

        /// <summary>
        /// ETMTR4YN.
        /// </summary>
        public const string ETMTR4YN = "ETMTR4YN";

        /// <summary>
        /// ETMTR5YN.
        /// </summary>
        public const string ETMTR5YN = "ETMTR5YN";

        /// <summary>
        /// ETMTR6YN.
        /// </summary>
        public const string ETMTR6YN = "ETMTR6YN";

        /// <summary>
        /// ETUSER.
        /// </summary>
        public const string ETUSER = "ETUSER";

        /// <summary>
        /// ETPID.
        /// </summary>
        public const string ETPID = "ETPID";

        /// <summary>
        /// ETMKEY.
        /// </summary>
        public const string ETMKEY = "ETMKEY";

        /// <summary>
        /// ETUPMJ.
        /// </summary>
        public const string ETUPMJ = "ETUPMJ";

        /// <summary>
        /// ETUPMT.
        /// </summary>
        public const string ETUPMT = "ETUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F12121";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ETUKID", "ETUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("ETTEMPNAME", "ETTEMPNAME", JdeDataType.String, 60),
        new JdeField("ETTDESC", "ETTDESC", JdeDataType.String, 60),
        new JdeField("ETTDESC1", "ETTDESC1", JdeDataType.String, 60),
        new JdeField("ETODOMYN", "ETODOMYN", JdeDataType.String, 2),
        new JdeField("ETFUELYN", "ETFUELYN", JdeDataType.String, 2),
        new JdeField("ETHOURYN", "ETHOURYN", JdeDataType.String, 2),
        new JdeField("ETMTR4YN", "ETMTR4YN", JdeDataType.String, 2),
        new JdeField("ETMTR5YN", "ETMTR5YN", JdeDataType.String, 2),
        new JdeField("ETMTR6YN", "ETMTR6YN", JdeDataType.String, 2),
        new JdeField("ETUSER", "ETUSER", JdeDataType.String, 20),
        new JdeField("ETPID", "ETPID", JdeDataType.String, 20),
        new JdeField("ETMKEY", "ETMKEY", JdeDataType.String, 30),
        new JdeField("ETUPMJ", "ETUPMJ", JdeDataType.Numeric),
        new JdeField("ETUPMT", "ETUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F12121_0", "Primary Key on ETUKID", new[] { "ETUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F12121_2", "Unique Index on ETTEMPNAME", new[] { "ETTEMPNAME" }, isUnique: true)
    };
}
