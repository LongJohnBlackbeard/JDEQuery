using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1505H - .
/// </summary>
public class F1505H : JdeTable
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
        /// OKUSER.
        /// </summary>
        public const string OKUSER = "OKUSER";

        /// <summary>
        /// OKUPMJ.
        /// </summary>
        public const string OKUPMJ = "OKUPMJ";

        /// <summary>
        /// OKPID.
        /// </summary>
        public const string OKPID = "OKPID";

        /// <summary>
        /// OKJOBN.
        /// </summary>
        public const string OKJOBN = "OKJOBN";

        /// <summary>
        /// OKUPMT.
        /// </summary>
        public const string OKUPMT = "OKUPMT";

        /// <summary>
        /// OKCTRY.
        /// </summary>
        public const string OKCTRY = "OKCTRY";
    }

    /// <inheritdoc />
    public override string TableName => "F1505H";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OKICU", "OKICU", JdeDataType.Numeric, null, true, true),
        new JdeField("OKBCI", "OKBCI", JdeDataType.Numeric, null, true, true),
        new JdeField("OKPMFY", "OKPMFY", JdeDataType.Numeric, null, true, true),
        new JdeField("OKBPN", "OKBPN", JdeDataType.Numeric, null, true, true),
        new JdeField("OKAMTB", "OKAMTB", JdeDataType.Numeric),
        new JdeField("OKAPD", "OKAPD", JdeDataType.Numeric),
        new JdeField("OKUSER", "OKUSER", JdeDataType.String, 20),
        new JdeField("OKUPMJ", "OKUPMJ", JdeDataType.Numeric),
        new JdeField("OKPID", "OKPID", JdeDataType.String, 20),
        new JdeField("OKJOBN", "OKJOBN", JdeDataType.String, 20),
        new JdeField("OKUPMT", "OKUPMT", JdeDataType.Numeric),
        new JdeField("OKCTRY", "OKCTRY", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1505H_0", "Primary Key on OKBCI, OKCTRY, OKPMFY, OKBPN, OKICU", new[] { "OKBCI", "OKCTRY", "OKPMFY", "OKBPN", "OKICU" }, isUnique: true, isPrimaryKey: true)
    };
}
