using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1726 - .
/// </summary>
public class F1726 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DRFBDUR.
        /// </summary>
        public const string DRFBDUR = "DRFBDUR";

        /// <summary>
        /// DRTBDUR.
        /// </summary>
        public const string DRTBDUR = "DRTBDUR";

        /// <summary>
        /// DRABDUR.
        /// </summary>
        public const string DRABDUR = "DRABDUR";

        /// <summary>
        /// DRCRTU.
        /// </summary>
        public const string DRCRTU = "DRCRTU";

        /// <summary>
        /// DRPID.
        /// </summary>
        public const string DRPID = "DRPID";

        /// <summary>
        /// DRJOBN.
        /// </summary>
        public const string DRJOBN = "DRJOBN";

        /// <summary>
        /// DRUSER.
        /// </summary>
        public const string DRUSER = "DRUSER";

        /// <summary>
        /// DRUPMJ.
        /// </summary>
        public const string DRUPMJ = "DRUPMJ";

        /// <summary>
        /// DRUPMT.
        /// </summary>
        public const string DRUPMT = "DRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1726";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DRFBDUR", "DRFBDUR", JdeDataType.Numeric, null, true, true),
        new JdeField("DRTBDUR", "DRTBDUR", JdeDataType.Numeric),
        new JdeField("DRABDUR", "DRABDUR", JdeDataType.Numeric),
        new JdeField("DRCRTU", "DRCRTU", JdeDataType.String, 20),
        new JdeField("DRPID", "DRPID", JdeDataType.String, 20),
        new JdeField("DRJOBN", "DRJOBN", JdeDataType.String, 20),
        new JdeField("DRUSER", "DRUSER", JdeDataType.String, 20),
        new JdeField("DRUPMJ", "DRUPMJ", JdeDataType.Numeric),
        new JdeField("DRUPMT", "DRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1726_0", "Primary Key on DRFBDUR", new[] { "DRFBDUR" }, isUnique: true, isPrimaryKey: true)
    };
}
