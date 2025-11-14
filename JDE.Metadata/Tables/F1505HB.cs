using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1505HB - .
/// </summary>
public class F1505HB : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OKICU.
        /// </summary>
        public const string OKICU = "OKICU";

        /// <summary>
        /// OKBCI.
        /// </summary>
        public const string OKBCI = "OKBCI";

        /// <summary>
        /// OKBCI3.
        /// </summary>
        public const string OKBCI3 = "OKBCI3";

        /// <summary>
        /// OKPMFY.
        /// </summary>
        public const string OKPMFY = "OKPMFY";

        /// <summary>
        /// OKBPN.
        /// </summary>
        public const string OKBPN = "OKBPN";

        /// <summary>
        /// OKAMTB.
        /// </summary>
        public const string OKAMTB = "OKAMTB";

        /// <summary>
        /// OKAPD.
        /// </summary>
        public const string OKAPD = "OKAPD";

        /// <summary>
        /// OKCTRY.
        /// </summary>
        public const string OKCTRY = "OKCTRY";

        /// <summary>
        /// OKURCD.
        /// </summary>
        public const string OKURCD = "OKURCD";

        /// <summary>
        /// OKURDT.
        /// </summary>
        public const string OKURDT = "OKURDT";

        /// <summary>
        /// OKURAT.
        /// </summary>
        public const string OKURAT = "OKURAT";

        /// <summary>
        /// OKURAB.
        /// </summary>
        public const string OKURAB = "OKURAB";

        /// <summary>
        /// OKURRF.
        /// </summary>
        public const string OKURRF = "OKURRF";

        /// <summary>
        /// OKUSER.
        /// </summary>
        public const string OKUSER = "OKUSER";

        /// <summary>
        /// OKPID.
        /// </summary>
        public const string OKPID = "OKPID";

        /// <summary>
        /// OKUPMJ.
        /// </summary>
        public const string OKUPMJ = "OKUPMJ";

        /// <summary>
        /// OKUPMT.
        /// </summary>
        public const string OKUPMT = "OKUPMT";

        /// <summary>
        /// OKJOBN.
        /// </summary>
        public const string OKJOBN = "OKJOBN";

        /// <summary>
        /// OKCRCD.
        /// </summary>
        public const string OKCRCD = "OKCRCD";

        /// <summary>
        /// OKCRRM.
        /// </summary>
        public const string OKCRRM = "OKCRRM";
    }

    /// <inheritdoc />
    public override string TableName => "F1505HB";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OKICU", "OKICU", JdeDataType.Numeric, null, true, true),
        new JdeField("OKBCI", "OKBCI", JdeDataType.Numeric, null, true, true),
        new JdeField("OKBCI3", "OKBCI3", JdeDataType.Numeric),
        new JdeField("OKPMFY", "OKPMFY", JdeDataType.Numeric, null, true, true),
        new JdeField("OKBPN", "OKBPN", JdeDataType.Numeric, null, true, true),
        new JdeField("OKAMTB", "OKAMTB", JdeDataType.Numeric),
        new JdeField("OKAPD", "OKAPD", JdeDataType.Numeric),
        new JdeField("OKCTRY", "OKCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("OKURCD", "OKURCD", JdeDataType.String, 4),
        new JdeField("OKURDT", "OKURDT", JdeDataType.Numeric),
        new JdeField("OKURAT", "OKURAT", JdeDataType.Numeric),
        new JdeField("OKURAB", "OKURAB", JdeDataType.Numeric),
        new JdeField("OKURRF", "OKURRF", JdeDataType.String, 30),
        new JdeField("OKUSER", "OKUSER", JdeDataType.String, 20),
        new JdeField("OKPID", "OKPID", JdeDataType.String, 20),
        new JdeField("OKUPMJ", "OKUPMJ", JdeDataType.Numeric),
        new JdeField("OKUPMT", "OKUPMT", JdeDataType.Numeric),
        new JdeField("OKJOBN", "OKJOBN", JdeDataType.String, 20),
        new JdeField("OKCRCD", "OKCRCD", JdeDataType.String, 6),
        new JdeField("OKCRRM", "OKCRRM", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1505HB_0", "Primary Key on OKBCI, OKCTRY, OKPMFY, OKBPN, OKICU", new[] { "OKBCI", "OKCTRY", "OKPMFY", "OKBPN", "OKICU" }, isUnique: true, isPrimaryKey: true)
    };
}
