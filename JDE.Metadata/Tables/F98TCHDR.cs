using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F98TCHDR - .
/// </summary>
public class F98TCHDR : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HDDOCO.
        /// </summary>
        public const string HDDOCO = "HDDOCO";

        /// <summary>
        /// HDDCTO.
        /// </summary>
        public const string HDDCTO = "HDDCTO";

        /// <summary>
        /// HDKCO.
        /// </summary>
        public const string HDKCO = "HDKCO";

        /// <summary>
        /// HDOTOT.
        /// </summary>
        public const string HDOTOT = "HDOTOT";

        /// <summary>
        /// HDSHAN.
        /// </summary>
        public const string HDSHAN = "HDSHAN";

        /// <summary>
        /// HDAN8.
        /// </summary>
        public const string HDAN8 = "HDAN8";

        /// <summary>
        /// HDTRDJ.
        /// </summary>
        public const string HDTRDJ = "HDTRDJ";
    }

    /// <inheritdoc />
    public override string TableName => "F98TCHDR";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HDDOCO", "HDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("HDDCTO", "HDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("HDKCO", "HDKCO", JdeDataType.String, 10, true, true),
        new JdeField("HDOTOT", "HDOTOT", JdeDataType.Numeric),
        new JdeField("HDSHAN", "HDSHAN", JdeDataType.Numeric),
        new JdeField("HDAN8", "HDAN8", JdeDataType.Numeric),
        new JdeField("HDTRDJ", "HDTRDJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F98TCHDR_0", "Primary Key on HDDOCO, HDDCTO, HDKCO", new[] { "HDDOCO", "HDDCTO", "HDKCO" }, isUnique: true, isPrimaryKey: true)
    };
}
