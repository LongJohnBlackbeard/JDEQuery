using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0101W - .
/// </summary>
public class F0101W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AWAN8.
        /// </summary>
        public const string AWAN8 = "AWAN8";

        /// <summary>
        /// AWABSSID.
        /// </summary>
        public const string AWABSSID = "AWABSSID";

        /// <summary>
        /// AWALPH.
        /// </summary>
        public const string AWALPH = "AWALPH";

        /// <summary>
        /// AWTAX.
        /// </summary>
        public const string AWTAX = "AWTAX";

        /// <summary>
        /// AWADD1.
        /// </summary>
        public const string AWADD1 = "AWADD1";

        /// <summary>
        /// AWADD2.
        /// </summary>
        public const string AWADD2 = "AWADD2";

        /// <summary>
        /// AWADD3.
        /// </summary>
        public const string AWADD3 = "AWADD3";

        /// <summary>
        /// AWADD4.
        /// </summary>
        public const string AWADD4 = "AWADD4";

        /// <summary>
        /// AWCTY1.
        /// </summary>
        public const string AWCTY1 = "AWCTY1";

        /// <summary>
        /// AWADDS.
        /// </summary>
        public const string AWADDS = "AWADDS";

        /// <summary>
        /// AWADDZ.
        /// </summary>
        public const string AWADDZ = "AWADDZ";

        /// <summary>
        /// AWCTR.
        /// </summary>
        public const string AWCTR = "AWCTR";

        /// <summary>
        /// AWCOUN.
        /// </summary>
        public const string AWCOUN = "AWCOUN";

        /// <summary>
        /// AWAT1.
        /// </summary>
        public const string AWAT1 = "AWAT1";

        /// <summary>
        /// AWUSER.
        /// </summary>
        public const string AWUSER = "AWUSER";

        /// <summary>
        /// AWUPMJ.
        /// </summary>
        public const string AWUPMJ = "AWUPMJ";

        /// <summary>
        /// AWFUSTR1.
        /// </summary>
        public const string AWFUSTR1 = "AWFUSTR1";
    }

    /// <inheritdoc />
    public override string TableName => "F0101W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AWAN8", "AWAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("AWABSSID", "AWABSSID", JdeDataType.String, 64, true, true),
        new JdeField("AWALPH", "AWALPH", JdeDataType.String, 80),
        new JdeField("AWTAX", "AWTAX", JdeDataType.String, 40),
        new JdeField("AWADD1", "AWADD1", JdeDataType.String, 80),
        new JdeField("AWADD2", "AWADD2", JdeDataType.String, 80),
        new JdeField("AWADD3", "AWADD3", JdeDataType.String, 80),
        new JdeField("AWADD4", "AWADD4", JdeDataType.String, 80),
        new JdeField("AWCTY1", "AWCTY1", JdeDataType.String, 50),
        new JdeField("AWADDS", "AWADDS", JdeDataType.String, 6),
        new JdeField("AWADDZ", "AWADDZ", JdeDataType.String, 24),
        new JdeField("AWCTR", "AWCTR", JdeDataType.String, 6),
        new JdeField("AWCOUN", "AWCOUN", JdeDataType.String, 50),
        new JdeField("AWAT1", "AWAT1", JdeDataType.String, 6),
        new JdeField("AWUSER", "AWUSER", JdeDataType.String, 20),
        new JdeField("AWUPMJ", "AWUPMJ", JdeDataType.Numeric),
        new JdeField("AWFUSTR1", "AWFUSTR1", JdeDataType.String, 80)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0101W_0", "Primary Key on AWAN8, AWABSSID", new[] { "AWAN8", "AWABSSID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0101W_2", "Index on AWABSSID", new[] { "AWABSSID" }),
        new JdeIndex("F0101W_3", "Index on AWUSER", new[] { "AWUSER" })
    };
}
