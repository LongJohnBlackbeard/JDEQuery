using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B944 - .
/// </summary>
public class F76B944 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SBJOBS.
        /// </summary>
        public const string SBJOBS = "SBJOBS";

        /// <summary>
        /// SBPN.
        /// </summary>
        public const string SBPN = "SBPN";

        /// <summary>
        /// SBGPBT.
        /// </summary>
        public const string SBGPBT = "SBGPBT";

        /// <summary>
        /// SBEFTB.
        /// </summary>
        public const string SBEFTB = "SBEFTB";

        /// <summary>
        /// SBEFTE.
        /// </summary>
        public const string SBEFTE = "SBEFTE";

        /// <summary>
        /// SBUSER.
        /// </summary>
        public const string SBUSER = "SBUSER";

        /// <summary>
        /// SBPID.
        /// </summary>
        public const string SBPID = "SBPID";

        /// <summary>
        /// SBJOBN.
        /// </summary>
        public const string SBJOBN = "SBJOBN";

        /// <summary>
        /// SBUPMJ.
        /// </summary>
        public const string SBUPMJ = "SBUPMJ";

        /// <summary>
        /// SBUPMT.
        /// </summary>
        public const string SBUPMT = "SBUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B944";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SBJOBS", "SBJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("SBPN", "SBPN", JdeDataType.Numeric, null, true, true),
        new JdeField("SBGPBT", "SBGPBT", JdeDataType.Numeric),
        new JdeField("SBEFTB", "SBEFTB", JdeDataType.Numeric),
        new JdeField("SBEFTE", "SBEFTE", JdeDataType.Numeric),
        new JdeField("SBUSER", "SBUSER", JdeDataType.String, 20),
        new JdeField("SBPID", "SBPID", JdeDataType.String, 20),
        new JdeField("SBJOBN", "SBJOBN", JdeDataType.String, 20),
        new JdeField("SBUPMJ", "SBUPMJ", JdeDataType.Numeric),
        new JdeField("SBUPMT", "SBUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B944_0", "Primary Key on SBJOBS, SBPN", new[] { "SBJOBS", "SBPN" }, isUnique: true, isPrimaryKey: true)
    };
}
