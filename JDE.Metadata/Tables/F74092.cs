using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74092 - .
/// </summary>
public class F74092 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HBCO.
        /// </summary>
        public const string HBCO = "HBCO";

        /// <summary>
        /// HBIDTS.
        /// </summary>
        public const string HBIDTS = "HBIDTS";

        /// <summary>
        /// HBICRE.
        /// </summary>
        public const string HBICRE = "HBICRE";

        /// <summary>
        /// HBIDEB.
        /// </summary>
        public const string HBIDEB = "HBIDEB";

        /// <summary>
        /// HBDL01.
        /// </summary>
        public const string HBDL01 = "HBDL01";

        /// <summary>
        /// HBDL02.
        /// </summary>
        public const string HBDL02 = "HBDL02";
    }

    /// <inheritdoc />
    public override string TableName => "F74092";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HBCO", "HBCO", JdeDataType.String, 10, true, true),
        new JdeField("HBIDTS", "HBIDTS", JdeDataType.Numeric, null, true, true),
        new JdeField("HBICRE", "HBICRE", JdeDataType.Numeric),
        new JdeField("HBIDEB", "HBIDEB", JdeDataType.Numeric),
        new JdeField("HBDL01", "HBDL01", JdeDataType.String, 60),
        new JdeField("HBDL02", "HBDL02", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74092_0", "Primary Key on HBCO, HBIDTS", new[] { "HBCO", "HBIDTS" }, isUnique: true, isPrimaryKey: true)
    };
}
