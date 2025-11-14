using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42160A - .
/// </summary>
public class F42160A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SDDOCO.
        /// </summary>
        public const string SDDOCO = "SDDOCO";

        /// <summary>
        /// SDDCTO.
        /// </summary>
        public const string SDDCTO = "SDDCTO";

        /// <summary>
        /// SDKCOO.
        /// </summary>
        public const string SDKCOO = "SDKCOO";

        /// <summary>
        /// SDLNID.
        /// </summary>
        public const string SDLNID = "SDLNID";

        /// <summary>
        /// SDSLSM.
        /// </summary>
        public const string SDSLSM = "SDSLSM";

        /// <summary>
        /// SDSLCM.
        /// </summary>
        public const string SDSLCM = "SDSLCM";

        /// <summary>
        /// SDSLM2.
        /// </summary>
        public const string SDSLM2 = "SDSLM2";

        /// <summary>
        /// SDSLC2.
        /// </summary>
        public const string SDSLC2 = "SDSLC2";
    }

    /// <inheritdoc />
    public override string TableName => "F42160A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SDDOCO", "SDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SDDCTO", "SDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("SDKCOO", "SDKCOO", JdeDataType.String, 10, true, true),
        new JdeField("SDLNID", "SDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("SDSLSM", "SDSLSM", JdeDataType.Numeric),
        new JdeField("SDSLCM", "SDSLCM", JdeDataType.Numeric),
        new JdeField("SDSLM2", "SDSLM2", JdeDataType.Numeric),
        new JdeField("SDSLC2", "SDSLC2", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42160A_0", "Primary Key on SDDOCO, SDDCTO, SDKCOO, SDLNID", new[] { "SDDOCO", "SDDCTO", "SDKCOO", "SDLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
