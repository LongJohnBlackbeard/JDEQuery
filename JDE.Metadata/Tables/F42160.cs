using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42160 - .
/// </summary>
public class F42160 : JdeTable
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
        /// SDSFXO.
        /// </summary>
        public const string SDSFXO = "SDSFXO";

        /// <summary>
        /// SDLNID.
        /// </summary>
        public const string SDLNID = "SDLNID";

        /// <summary>
        /// SDCMLN.
        /// </summary>
        public const string SDCMLN = "SDCMLN";

        /// <summary>
        /// SDSLSM.
        /// </summary>
        public const string SDSLSM = "SDSLSM";

        /// <summary>
        /// SDSLCM.
        /// </summary>
        public const string SDSLCM = "SDSLCM";

        /// <summary>
        /// SDFCA.
        /// </summary>
        public const string SDFCA = "SDFCA";

        /// <summary>
        /// SDAPUN.
        /// </summary>
        public const string SDAPUN = "SDAPUN";

        /// <summary>
        /// SDCCTY.
        /// </summary>
        public const string SDCCTY = "SDCCTY";
    }

    /// <inheritdoc />
    public override string TableName => "F42160";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SDDOCO", "SDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SDDCTO", "SDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("SDKCOO", "SDKCOO", JdeDataType.String, 10, true, true),
        new JdeField("SDSFXO", "SDSFXO", JdeDataType.String, 6, true, true),
        new JdeField("SDLNID", "SDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("SDCMLN", "SDCMLN", JdeDataType.Numeric, null, true, true),
        new JdeField("SDSLSM", "SDSLSM", JdeDataType.Numeric, null, true, true),
        new JdeField("SDSLCM", "SDSLCM", JdeDataType.Numeric, null, true, true),
        new JdeField("SDFCA", "SDFCA", JdeDataType.Numeric),
        new JdeField("SDAPUN", "SDAPUN", JdeDataType.Numeric),
        new JdeField("SDCCTY", "SDCCTY", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42160_0", "Primary Key on SDDOCO, SDDCTO, SDKCOO, SDSFXO, SDLNID, SDSLSM, SDSLCM, SDCMLN", new[] { "SDDOCO", "SDDCTO", "SDKCOO", "SDSFXO", "SDLNID", "SDSLSM", "SDSLCM", "SDCMLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F42160_5", "Index on SDDOCO, SDDCTO", new[] { "SDDOCO", "SDDCTO" }),
        new JdeIndex("F42160_6", "Index on SDDOCO, SDDCTO, SDKCOO, SDSFXO, SDLNID, SDCMLN", new[] { "SDDOCO", "SDDCTO", "SDKCOO", "SDSFXO", "SDLNID", "SDCMLN" }),
        new JdeIndex("F42160_7", "Index on SDDOCO, SDDCTO, SDKCOO, SDLNID", new[] { "SDDOCO", "SDDCTO", "SDKCOO", "SDLNID" })
    };
}
