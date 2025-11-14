using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R0005 - .
/// </summary>
public class F74R0005 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DRSY.
        /// </summary>
        public const string DRSY = "DRSY";

        /// <summary>
        /// DRRT.
        /// </summary>
        public const string DRRT = "DRRT";

        /// <summary>
        /// DRKY.
        /// </summary>
        public const string DRKY = "DRKY";

        /// <summary>
        /// DRR74DL01.
        /// </summary>
        public const string DRR74DL01 = "DRR74DL01";

        /// <summary>
        /// DRR74DL02.
        /// </summary>
        public const string DRR74DL02 = "DRR74DL02";

        /// <summary>
        /// DRUSER.
        /// </summary>
        public const string DRUSER = "DRUSER";

        /// <summary>
        /// DRJOBN.
        /// </summary>
        public const string DRJOBN = "DRJOBN";

        /// <summary>
        /// DRPID.
        /// </summary>
        public const string DRPID = "DRPID";

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
    public override string TableName => "F74R0005";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DRSY", "DRSY", JdeDataType.String, 8, true, true),
        new JdeField("DRRT", "DRRT", JdeDataType.String, 4, true, true),
        new JdeField("DRKY", "DRKY", JdeDataType.String, 20, true, true),
        new JdeField("DRR74DL01", "DRR74DL01", JdeDataType.String, 500),
        new JdeField("DRR74DL02", "DRR74DL02", JdeDataType.String, 500),
        new JdeField("DRUSER", "DRUSER", JdeDataType.String, 20),
        new JdeField("DRJOBN", "DRJOBN", JdeDataType.String, 20),
        new JdeField("DRPID", "DRPID", JdeDataType.String, 20),
        new JdeField("DRUPMJ", "DRUPMJ", JdeDataType.Numeric),
        new JdeField("DRUPMT", "DRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R0005_0", "Primary Key on DRSY, DRRT, DRKY", new[] { "DRSY", "DRRT", "DRKY" }, isUnique: true, isPrimaryKey: true)
    };
}
