using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7430032 - .
/// </summary>
public class F7430032 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PIKCO.
        /// </summary>
        public const string PIKCO = "PIKCO";

        /// <summary>
        /// PIDCT.
        /// </summary>
        public const string PIDCT = "PIDCT";

        /// <summary>
        /// PIDOC.
        /// </summary>
        public const string PIDOC = "PIDOC";

        /// <summary>
        /// PISEQ.
        /// </summary>
        public const string PISEQ = "PISEQ";

        /// <summary>
        /// PIK74LTFR.
        /// </summary>
        public const string PIK74LTFR = "PIK74LTFR";

        /// <summary>
        /// PIDOCO.
        /// </summary>
        public const string PIDOCO = "PIDOCO";

        /// <summary>
        /// PIDCTO.
        /// </summary>
        public const string PIDCTO = "PIDCTO";

        /// <summary>
        /// PIKCOO.
        /// </summary>
        public const string PIKCOO = "PIKCOO";

        /// <summary>
        /// PILNID.
        /// </summary>
        public const string PILNID = "PILNID";

        /// <summary>
        /// PISFX.
        /// </summary>
        public const string PISFX = "PISFX";

        /// <summary>
        /// PIK74PN.
        /// </summary>
        public const string PIK74PN = "PIK74PN";
    }

    /// <inheritdoc />
    public override string TableName => "F7430032";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PIKCO", "PIKCO", JdeDataType.String, 10, true, true),
        new JdeField("PIDCT", "PIDCT", JdeDataType.String, 4, true, true),
        new JdeField("PIDOC", "PIDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("PISEQ", "PISEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("PIK74LTFR", "PIK74LTFR", JdeDataType.String, 6),
        new JdeField("PIDOCO", "PIDOCO", JdeDataType.Numeric),
        new JdeField("PIDCTO", "PIDCTO", JdeDataType.String, 4),
        new JdeField("PIKCOO", "PIKCOO", JdeDataType.String, 10),
        new JdeField("PILNID", "PILNID", JdeDataType.Numeric),
        new JdeField("PISFX", "PISFX", JdeDataType.String, 6),
        new JdeField("PIK74PN", "PIK74PN", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7430032_0", "Primary Key on PIKCO, PIDCT, PIDOC, PISEQ", new[] { "PIKCO", "PIDCT", "PIDOC", "PISEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
