using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46LUI03 - .
/// </summary>
public class F46LUI03 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFUKID.
        /// </summary>
        public const string WFUKID = "WFUKID";

        /// <summary>
        /// WFJOBS.
        /// </summary>
        public const string WFJOBS = "WFJOBS";

        /// <summary>
        /// WFCHAR.
        /// </summary>
        public const string WFCHAR = "WFCHAR";

        /// <summary>
        /// WFEV01.
        /// </summary>
        public const string WFEV01 = "WFEV01";

        /// <summary>
        /// WFMCU.
        /// </summary>
        public const string WFMCU = "WFMCU";

        /// <summary>
        /// WFPLPNU.
        /// </summary>
        public const string WFPLPNU = "WFPLPNU";

        /// <summary>
        /// WFLPNU.
        /// </summary>
        public const string WFLPNU = "WFLPNU";

        /// <summary>
        /// WFITM.
        /// </summary>
        public const string WFITM = "WFITM";

        /// <summary>
        /// WFLOCN.
        /// </summary>
        public const string WFLOCN = "WFLOCN";

        /// <summary>
        /// WFEQTY.
        /// </summary>
        public const string WFEQTY = "WFEQTY";

        /// <summary>
        /// WFGWEI.
        /// </summary>
        public const string WFGWEI = "WFGWEI";

        /// <summary>
        /// WFUWUM.
        /// </summary>
        public const string WFUWUM = "WFUWUM";

        /// <summary>
        /// WFPARTLPN.
        /// </summary>
        public const string WFPARTLPN = "WFPARTLPN";

        /// <summary>
        /// WFMILPN.
        /// </summary>
        public const string WFMILPN = "WFMILPN";

        /// <summary>
        /// WFMLLPN.
        /// </summary>
        public const string WFMLLPN = "WFMLLPN";

        /// <summary>
        /// WFELPN.
        /// </summary>
        public const string WFELPN = "WFELPN";

        /// <summary>
        /// WFCQLPN.
        /// </summary>
        public const string WFCQLPN = "WFCQLPN";
    }

    /// <inheritdoc />
    public override string TableName => "F46LUI03";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFUKID", "WFUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("WFJOBS", "WFJOBS", JdeDataType.Numeric),
        new JdeField("WFCHAR", "WFCHAR", JdeDataType.String, 2),
        new JdeField("WFEV01", "WFEV01", JdeDataType.String, 2),
        new JdeField("WFMCU", "WFMCU", JdeDataType.String, 24),
        new JdeField("WFPLPNU", "WFPLPNU", JdeDataType.String, 80),
        new JdeField("WFLPNU", "WFLPNU", JdeDataType.String, 80),
        new JdeField("WFITM", "WFITM", JdeDataType.Numeric),
        new JdeField("WFLOCN", "WFLOCN", JdeDataType.String, 40),
        new JdeField("WFEQTY", "WFEQTY", JdeDataType.String, 10),
        new JdeField("WFGWEI", "WFGWEI", JdeDataType.Numeric),
        new JdeField("WFUWUM", "WFUWUM", JdeDataType.String, 4),
        new JdeField("WFPARTLPN", "WFPARTLPN", JdeDataType.String, 2),
        new JdeField("WFMILPN", "WFMILPN", JdeDataType.String, 2),
        new JdeField("WFMLLPN", "WFMLLPN", JdeDataType.String, 2),
        new JdeField("WFELPN", "WFELPN", JdeDataType.String, 2),
        new JdeField("WFCQLPN", "WFCQLPN", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46LUI03_0", "Primary Key on WFUKID", new[] { "WFUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F46LUI03_2", "Index on WFJOBS, WFLPNU", new[] { "WFJOBS", "WFLPNU" }),
        new JdeIndex("F46LUI03_3", "Index on WFJOBS, WFCHAR, WFLPNU", new[] { "WFJOBS", "WFCHAR", "WFLPNU" })
    };
}
